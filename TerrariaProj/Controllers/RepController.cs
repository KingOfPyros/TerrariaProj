using Microsoft.AspNetCore.Mvc;
using TerrariaProj.Interface;
using TerrariaProj.Models;

namespace TerrariaProj.Controllers
{
    public class RepController : Controller
    {
        private IItemRepository iitemRepository;

        [HttpGet("Items/{id}")]
        public IActionResult GetItemByIdRep(int id)
        {
            Item item1 = new Item(1, "TerraSword", "Sword", "Legendary", "sword.png");
            iitemRepository.AddItem(item1);

            Item item2 = new Item(2, "AnchShield", "Shield", "Rare", "shield.png");
            iitemRepository.AddItem(item2);

            List<Item> items = iitemRepository.GetAllItems();
            foreach (var item in items)
            {
                Console.WriteLine($"Id: {item.id}");
                Console.WriteLine($"Name: {item.Name}");
                Console.WriteLine($"Description: {item.Type}");
                Console.WriteLine($"Rarity: {item.Rarity}");
                Console.WriteLine($"Image URL: {item.ImageUrl}");
            }
            int itemId = 1;
            Item selectedItem = iitemRepository.GetItemByIdRep(itemId);
            if (selectedItem != null)
            {
                Console.WriteLine($"Selected Item: {selectedItem.Name}");
            };
        }
    }
}

        
