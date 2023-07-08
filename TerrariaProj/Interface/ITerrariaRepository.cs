using TerrariaProj.Models;

namespace TerrariaProj.Interface
{
    public interface ITerrariaRepository
    {
        IEnumerable<Player> GetPlayers();
        Player GetPlayerByName(string name);
        void CreatePlayer(Player player);
        void UpdatePlayer(Player player);
        void DeletePlayer(string name);

        IEnumerable<Item> GetItem();
        Item GetItemById(int id);
        void CreateItem(Item item);
        void UpdateItem(Item item);
        void DeleteItem(int id);

        IEnumerable<World> GetWorld();
        World GetWorldById(int id);
        void CreateWorld(World world);
        void UpdateWorld(World world);
        void DeleteWorld(int id);

    }
}
