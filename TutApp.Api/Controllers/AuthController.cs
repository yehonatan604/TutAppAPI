using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Tut.Model.SiteDbContext;
using TutApp.Core.Contracts;
using TutApp.Core.DTOs;

namespace TutApp.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly SiteDbContext _context;
        private readonly IMapper _mapper;
        private readonly IAuthRepository _repo;

        public AuthController(IDbContextFactory<SiteDbContext> dbContextFactory, IMapper mapper, IAuthRepository repo)
        {
            _context = dbContextFactory.CreateDbContext();
            _mapper = mapper;
            _repo = repo;
        }

        // POST: api/Auth/register
        [HttpPost]
        [Route("register")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult> Register([FromBody] UserRegisterDTO user)
        {
            var errors = await _repo.Register(user);

            if (errors.Any())
            {
                /*foreach (var error in errors)
                {
                    ModelState.AddModelError(error.Code, error.Description);
                }
                throw new BadRequestException(nameof(Register), ModelState);*/
                return BadRequest(errors);
            }
            return Ok();
        }

        // POST: api/Auth/login
        [HttpPost]
        [Route("login")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<UserReturnDto?>> Login([FromBody] UserLoginDTO user)
        {
            var authResponse = await _repo.Login(user);
            return authResponse == null ?
                   //throw new UnauthorizedException(nameof(Login), loginVM.Email) 
                   Unauthorized(nameof(Login)) :
                   Ok(authResponse);
        }

        //GET: api/Auth/checkEmailExist
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [Route("checkEmailExist/{email}")]
        public async Task<ActionResult<bool>> CheckEmailExist(string email)
        {
            return Ok(await _context.Users.AnyAsync(u => u.Email == email));
        }

        //PUT: api/Auth/updateUser
        [HttpPut]
        [Route("updateUser")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [Authorize]
        public async Task<IActionResult> UpdateUser([FromBody] UserUpdateDTO user)
        {
            return await _repo.UpdateUser(user) ? NoContent() : BadRequest();
        }

        // POST: api/Auth/refreshtoken
        [HttpPost]
        [Route("refreshtoken")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [Authorize]
        public async Task<ActionResult> RefreshToken([FromBody] UserTokenDTO request)
        {
            var authResponse = await _repo.VerifyRefreshToken(request);
            return authResponse == null ?
                   //throw new UnauthorizedException(nameof(RefreshToken), request.UserId!)
                   Unauthorized(nameof(RefreshToken)) :
                   Ok(authResponse);
        }

        // GET: api/Auth/getUsers
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [Route("getUsers")]
        [Authorize(Roles = "Admin")]
        public async Task<ActionResult<bool>> GetUsers()
        {
            return Ok(await _context.Users.ToListAsync());
        }

        // GET: api/Auth/getUser
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [Route("getUser/{id}")]
        [Authorize]
        public async Task<ActionResult<UserReturnDto?>> GetUser(string id)
        {
            return await _repo.GetUser(id);
        }
    }
}
