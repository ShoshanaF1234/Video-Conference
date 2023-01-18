using dotnNetCoreApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace dotnNetCoreApp.Controllers
{
    [ApiController]
    [Route("api/login")]
    public class LogInController : ControllerBase
    {


        private readonly ILogger<LogInController> _logger;

        public LogInController(ILogger<LogInController> logger)
        {
            _logger = logger;
        }


        [AllowAnonymous]
        [Route("log")]
        [HttpPost]
        public async Task<User> LoginAsync(LoginRequest request)
        {//goes and get's the user and athourion from the micro services
            User user = null;
            user.Permissions= Permissions.Permissions.GetPermissions(User.Title);
            return user;
        }
    }
}