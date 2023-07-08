using Microsoft.EntityFrameworkCore;
using TerrariaProj.Models;

namespace TerrariaProj
{
    public class TerrariaDbContext : DbContext
    {
        public DbSet<Item> Item { get; set; }
        public DbSet<World> World { get; set; }
        public DbSet<Admin> Admins { get; set; }

        public TerrariaDbContext(DbContextOptions<TerrariaDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Item>().ToTable("Item");
            modelBuilder.Entity<World>().ToTable("World");
            modelBuilder.Entity<Admin>().ToTable("Admins");
        }
    }
}
