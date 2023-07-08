using Microsoft.EntityFrameworkCore;
using TerrariaProj.Models;

namespace TerrariaProj
{
    public class TerrariaDbContext : DbContext
    {
        public DbSet<Item> Items { get; set; }
        public DbSet<World> Worlds { get; set; }

        public TerrariaDbContext(DbContextOptions<TerrariaDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Item>().ToTable("Items");
            modelBuilder.Entity<World>().ToTable("Worlds");
        }
    }
}
