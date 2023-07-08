using Microsoft.AspNetCore.Mvc;
using TerrariaProj.Interface;
using TerrariaProj.Models;

namespace TerrariaProj.Controllers
{
    [ApiController]
    [Route("api/terraria")]
    public class TerrariaController : ControllerBase
    {
        private readonly ITerrariaRepository _repository;

        public TerrariaController(ITerrariaRepository repository)
        {
            _repository = repository;
        }

        [HttpGet("players")]
        public IActionResult GetPlayers()
        {
            var players = _repository.GetPlayers();
            return Ok(players);
        }

        [HttpGet("players/{name}")]
        public IActionResult GetPlayerByName(string name)
        {
            var player = _repository.GetPlayerByName(name);
            if (player == null)
                return NotFound();

            return Ok(player);
        }

        [HttpPost("players")]
        public IActionResult CreatePlayer(Player player)
        {
            _repository.CreatePlayer(player);
            return CreatedAtAction(nameof(GetPlayerByName), new { name = player.Name }, player);
        }

        [HttpPut("players/{name}")]
        public IActionResult UpdatePlayer(string name, Player updatedPlayer)
        {
            var player = _repository.GetPlayerByName(name);
            if (player == null)
                return NotFound();

            player.Name = updatedPlayer.Name;
            player.Health = updatedPlayer.Health;
            player.Armor = updatedPlayer.Armor;

            _repository.UpdatePlayer(player);
            return NoContent();
        }

        [HttpDelete("players/{name}")]
        public IActionResult DeletePlayer(string name)
        {
            var player = _repository.GetPlayerByName(name);
            if (player == null)
                return NotFound();

            _repository.DeletePlayer(name);
            return NoContent();
        }
    }
}
