using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace cycle_store_be.Controllers
{
    [Route("api/auth")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        [Authorize]
        [HttpGet]
        [Route("me")]
        public Task<IActionResult> GetMe()
        {
            var claims = HttpContext.User.Claims.ToDictionary(c => c.Type, c => c.Value);
            return Task.FromResult<IActionResult>(StatusCode(200, claims));
        }
    }
}
