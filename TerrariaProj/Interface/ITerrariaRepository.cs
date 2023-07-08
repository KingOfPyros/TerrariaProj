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

    }
}
