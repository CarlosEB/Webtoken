using Microsoft.AspNetCore.Mvc;
using System;

namespace WebToken.Controllers
{
    [Route("api/[controller]")]
    public class TokenController : Controller
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok (
                new
                {
                    Guid = Guid.NewGuid().ToString(),
                    Expires = DateTime.UtcNow.AddMinutes(30),
                    Origin = Environment.MachineName
                }
            );
        }
    }
}
