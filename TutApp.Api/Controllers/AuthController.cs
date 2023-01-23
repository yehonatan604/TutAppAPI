using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Tut.Model.SiteDbContext;
using TutApp.Core.DTOs;
using TutApp.Data.Models;

namespace TutApp.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly SiteDbContext _context;
        private readonly IMapper _mapper;
        private User? _user;

        public AuthController(IDbContextFactory<SiteDbContext> dbContextFactory, IMapper mapper)
        {
            _context = dbContextFactory.CreateDbContext();
            _mapper = mapper;
        }

        // POST: api/Auth/register
        [HttpPost]
        [Route("register")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<bool>> Register([FromBody] UserRegisterDTO user)
        {
            _context.Users.Add(_mapper.Map<User>(user));
            _context.SaveChanges();

            _user = await _context.Users.SingleAsync(u => u.Email == user.Email);
            _user.UserType = UserTypes.Reader;
            _context.SaveChanges();

            return Ok(true);
        }

        // POST: api/Auth/login
        [HttpPost]
        [Route("login")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<UserReturnDto?>> Login([FromBody] UserLoginDTO user)
        {
            _user = await _context.Users.FirstOrDefaultAsync(u => u.Email == user.Email);

            if (_user != null)
            {
                if (_user!.Password == user.Password)
                {
                    return Ok(_mapper.Map<UserReturnDto>(_user));
                }
                return BadRequest("Wrong Password");
            }

            return BadRequest("Email does not exists");
        }

        //PUT: api/Auth/updateUser
        [HttpPut]
        [Route("updateUser")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<IActionResult> UpdateUser([FromBody] UserUpdateDTO user)
        {
            _user = await _context.Users.FirstOrDefaultAsync(u => u.Email == user.Email);

            if (_user == null)
            {
                return BadRequest();
            }

            try
            {
                UpdateUserDetails(user);
                _context.Entry(_user).State = EntityState.Modified;
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                throw;
            }

            return NoContent();
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [Route("checkEmailExist/{email}")]
        public async Task<ActionResult<bool>> CheckEmailExist(string email)
        {
            return Ok(await _context.Users.AnyAsync(u => u.Email == email));
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
