namespace TerrariaProj.Models
{
    public class Item
    {
        public int id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string Rarity { get; set; }
        public string ImageUrl { get; set; }

        public Item(int _id, string name, string type, string rarity, string imageUrl)
        {
            id = _id;
            Name = name;
            Type = type;
            Rarity = rarity;
            ImageUrl = imageUrl;
        }
    }
}
