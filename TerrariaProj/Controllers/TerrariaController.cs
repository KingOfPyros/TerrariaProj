﻿using Microsoft.AspNetCore.Mvc;
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

        [HttpGet("items")]
        public IActionResult GetItems()
        {
            var items = _repository.GetItems();
            return Ok(items);
        }

        [HttpGet("items/{id}")]
        public IActionResult GetItemById(int id)
        {
            var item = _repository.GetItemById(id);
            if (item == null)
                return NotFound();

            return Ok(item);
        }

        [HttpPost("items")]
        public IActionResult CreateItem(Item item)
        {
            _repository.CreateItem(item);
            return CreatedAtAction(nameof(GetItemById), new { id = item.Id }, item);
        }

        [HttpPut("items/{id}")]
        public IActionResult UpdateItem(int id, Item updatedItem)
        {
            var item = _repository.GetItemById(id);
            if (item == null)
                return NotFound();

            item.Name = updatedItem.Name;
            item.Type = updatedItem.Type;
            item.Rarity = updatedItem.Rarity;

            _repository.UpdateItem(item);
            return NoContent();
        }

        [HttpDelete("items/{id}")]
        public IActionResult DeleteItem(int id)
        {
            var item = _repository.GetItemById(id);
            if (item == null)
                return NotFound();

            _repository.DeleteItem(id);
            return NoContent();
        }

        [HttpGet("worlds")]
        public IActionResult GetWorlds()
        {
            var world = _repository.GetWorlds();
            return Ok(world);
        }

        [HttpGet("worlds/{id}")]
        public IActionResult GetWorldById(int id)
        {
            var world = _repository.GetWorldById(id);
            if (world == null)
                return NotFound();

            return Ok(world);
        }

        [HttpPost("worlds")]
        public IActionResult CreateWorld(World world)
        {
            _repository.CreateWorld(world);
            return CreatedAtAction(nameof(GetWorldById), new { world = world.Id }, world);
        }

        [HttpPut("worlds/{id}")]
        public IActionResult UpdateWorld(int id, World updatedWorld)
        {
            var world = _repository.GetWorldById(id);
            if (world == null)
                return NotFound();

            world.Name = updatedWorld.Name;
            world.Size = updatedWorld.Size;
            world.Difficulty = updatedWorld.Difficulty;

            _repository.UpdateWorld(world);
            return NoContent();
        }

        [HttpDelete("worlds/{id}")]
        public IActionResult DeleteWorld(int id)
        {
            var world = _repository.GetWorldById(id);
            if (world == null)
                return NotFound();

            _repository.DeleteWorld(id);
            return NoContent();
        }
    }
}
