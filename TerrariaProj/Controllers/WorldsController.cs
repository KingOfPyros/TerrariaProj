using Microsoft.AspNetCore.Mvc;

namespace TerrariaProj.Controllers
{
    [ApiController]
    [Route("api/World")]
    public class WorldsController : ControllerBase
    {
        private readonly TerrariaDbContext _dbContext;

        public WorldsController(TerrariaDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet("{id}")]
        public IActionResult GetWorldById(int id)
        {
            var world = _dbContext.World.FirstOrDefault(w => w.id == id);
            if (world == null)
                return NotFound();

            return Ok(world);
        }
    }
}
