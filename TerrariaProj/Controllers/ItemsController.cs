using Microsoft.AspNetCore.Mvc;

namespace TerrariaProj.Controllers
{
    [ApiController]
    [Route("api/Item")]
    public class ItemsController : ControllerBase
    {
        private readonly TerrariaDbContext _dbContext;

        public ItemsController(TerrariaDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet("{id}")]
        public IActionResult GetItemById(int id)
        {
            var item = _dbContext.Item.FirstOrDefault(i => i.id == id);
            if (item == null)
                return NotFound();

            return Ok(item);
        }
    }

}
