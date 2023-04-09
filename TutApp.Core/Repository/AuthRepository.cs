using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Tut.Model.SiteDbContext;
using TutApp.Core.Contracts;
using TutApp.Core.DTOs;
using TutApp.Data.Models;
using JwtRegisteredClaimNames = Microsoft.IdentityModel.JsonWebTokens.JwtRegisteredClaimNames;

namespace TutApp.Core.Repository
{
    public class AuthRepository : GenericRepository<User>, IAuthRepository
    {
        private readonly IMapper _mapper;
        private User? _user;
        private readonly UserManager<User> _manager;
        private readonly IConfiguration _config;

        private const string _loginProvider = "TutApi";
        private const string _refreshToken = "RefreshToken";

        public AuthRepository(
            IMapper mapper,
            IDbContextFactory<SiteDbContext> dbContextFactory,
            UserManager<User> _manager,
            IConfiguration config
        ) : base(dbContextFactory)
        {
            _mapper = mapper;
            this._manager = _manager;
            _config = config;
        }

        public async Task<UserReturnDto?> Login(UserLoginDTO loginDto)
        {
            //_logger.LogInformation($"Looking for user '{loginVM.Email}'");
            _user = await _manager.FindByEmailAsync(loginDto.Email);
            bool isValid = await _manager.CheckPasswordAsync(_user, loginDto.Password);

            if (_user == null || !isValid)
            {
                //_logger.LogWarning($"user with email '{loginDto.Email}' was not found!!!");
                return null;
            }

            var token = await GenerateToken();
            //_logger.LogInformation($"Generated token: {token}\nfor user: {loginDto.Email}");

            return new UserReturnDto
            {
                Token = token,
                UserId = _user.Id,
                RefreshToken = await CreateRefreshToken()
            };
        }

        public async Task<string> CreateRefreshToken()
        {
            await _manager.RemoveAuthenticationTokenAsync
                (_user!, _loginProvider, _refreshToken);
            var newRefreshToken = await _manager.GenerateUserTokenAsync
                (_user!, _loginProvider, _refreshToken);
            var result = await _manager.SetAuthenticationTokenAsync
                (_user!, _loginProvider, _refreshToken, newRefreshToken);
            return newRefreshToken;
        }

        public async Task<IEnumerable<IdentityError>> Register(UserRegisterDTO userDTO)
        {
            var user = _mapper.Map<User>(userDTO);
            var res = await _manager.CreateAsync(user, userDTO.Password);

            if (res.Succeeded)
            {
                await _manager.AddToRoleAsync(user, "User");
            }

            return res.Errors;
        }

        public async Task<bool> UpdateUser(UserUpdateDTO user)
        {
            _user = await _db.Users.FirstOrDefaultAsync(u => u.Email == user.Email);

            if (_user == null)
            {
                return false;
            }

            try
            {
                UpdateUserDetails(user);
                _db.Entry(_user).State = EntityState.Modified;
                await _db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                throw;
            }

            return true;
        }

        private async Task<string> GenerateToken()
        {
            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["Keys:Key"]!));
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

            var roles = await _manager.GetRolesAsync(_user);
            var roleClaims = roles.Select(x => new Claim(ClaimTypes.Role, x)).ToList();
            var userClaims = await _manager.GetClaimsAsync(_user);

            var claims = new List<Claim>
            {
                new Claim(JwtRegisteredClaimNames.Sub, _user.Email),
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                new Claim(JwtRegisteredClaimNames.Email, _user.Email),
            }.Union(userClaims).Union(roleClaims);

            var token = new JwtSecurityToken(
                issuer: _config["JwtSettings:Issuer"],
                audience: _config["JwtSettings:Audience"],
                claims: claims,
                expires: DateTime.Now.AddDays(Convert.ToInt16(_config["JwtSettings:DurationInDays"])),
                signingCredentials: credentials
                );

            return new JwtSecurityTokenHandler().WriteToken(token);
        }

        public async Task<UserReturnDto?> VerifyRefreshToken(UserReturnDto request)
        {
            var jsonSecurityTokeHandler = new JwtSecurityTokenHandler();
            var tokenContent = jsonSecurityTokeHandler.ReadJwtToken(request.Token);
            var userName = tokenContent.Claims.ToList()
                .FirstOrDefault(e => e.Type == JwtRegisteredClaimNames.Email)?.Value;

            _user = await _manager.FindByNameAsync(userName);

            if (_user == null || _user.Id != request.UserId)
            {
                return null;
            }

            var isValidRefreshToken = await _manager.VerifyUserTokenAsync
                (_user, _loginProvider, _refreshToken, request.RefreshToken);

            if (isValidRefreshToken)
            {
                var token = await GenerateToken();
                return new UserReturnDto
                {
                    Token = token,
                    UserId = _user.Id,
                    RefreshToken = await CreateRefreshToken()
                };
            }
            await _manager.UpdateSecurityStampAsync(_user);
            return null;
        }

        public void UpdateUserDetails(UserUpdateDTO user)
        {
            _user!.UserName = user.UserName;
            _user.DOB = user.Dob;
            _user.Email = string.IsNullOrEmpty(user.newEmail) ? user.Email : user.newEmail;
            _user.HobbiesList = user.HobbiesList;
            _user.FavCategoriesList = user.FavCategoriesList;
            _user.AboutMe = user.AboutMe;
        }
    }
}
