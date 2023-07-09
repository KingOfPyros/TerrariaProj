using TerrariaProj.Models;

namespace TerrariaProj.Interface
{
    public interface IItemRepository
    {
        List<Item> GetAllItems();
        Item GetItemByIdRep(int id);
        void AddItem(Item item);
    }
}
