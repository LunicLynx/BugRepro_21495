using BugRepro.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace BugRepro.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        [HttpGet]
        public async Task<object> Get()
        {
            var identity = new ClaimsIdentity(new[]
            {
                new Claim(ClaimTypes.Name, "Test"),
                new Claim(ClaimTypes.Email, "test@test.test"),
            }, "Identity.Application", ClaimTypes.Name, ClaimTypes.Role);

            var principal = new ClaimsPrincipal(identity);
            await HttpContext.SignInAsync(IdentityConstants.ApplicationScheme, principal);
            return Ok(new object());
        }
    }
}
