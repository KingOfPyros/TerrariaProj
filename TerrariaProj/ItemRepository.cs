using TerrariaProj.Interface;
using TerrariaProj.Models;

namespace TerrariaProj
{
    public class ItemRepository : IItemRepository
    {
        private List<Item> _items;

        public ItemRepository()
        {
            _items = new List<Item>();
        }

        public List<Item> GetAllItems()
        {
            return _items;
        }

        public Item GetItemById(int id)
        {
            return _items.FirstOrDefault(item => item.Id == id);
        }

        public void AddItem(Item item)
        {
            _items.Add(item);
        }
    }
}
