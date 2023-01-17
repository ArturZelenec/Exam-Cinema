using Exam_Cinema.Model.DTO;
using Exam_Cinema.Repository.IRepository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Exam_Cinema.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserRepository _userRepo;

        public UserController(IUserRepository userRepo)
        {
            _userRepo = userRepo;
        }

        [HttpPost("Login")]
        public async Task<IActionResult> Login([FromBody] LoginRequest model)
        {
            var loginResponse = await _userRepo.LoginAsync(model);
            if (loginResponse.User == null || string.IsNullOrEmpty(loginResponse.Token))
            {
                return BadRequest(new { mesage = "Username or password is incorect" });
            }
            return Ok(loginResponse);
        }

        [HttpPost("Registration")]
        public async Task<IActionResult> Register([FromBody] RegistrationRequest model)
        {
            var isUserNameUnique = await _userRepo.IsUniqueUserAsync(model.Username);

            if (!isUserNameUnique)
            {
                return BadRequest(new { message = "Username already exists" });
            }

            var user = await _userRepo.RegisterAsync(model);

            if (user == null)
            {
                return BadRequest(new { message = "Error while registering" });
            }

            return Ok();
            
        }
    }
}
