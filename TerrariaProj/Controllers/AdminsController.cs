using Microsoft.AspNetCore.Mvc;
using TerrariaProj.Models;

namespace TerrariaProj.Controllers
{
    [ApiController]
    [Route("api/admins")]
    public class AdminsController : ControllerBase
    {
        private readonly TerrariaDbContext _dbContext;

        public AdminsController(TerrariaDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpPost("login")]
        public IActionResult Login([FromBody] LoginDto loginDto)
        {
            var admin = _dbContext.Admins.FirstOrDefault(a => a.Username == loginDto.Username && a.Password == loginDto.Password);
            if (admin == null)
                return Unauthorized();

            return Ok();
        }
    }

}
