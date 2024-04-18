using LevelUpInventorySystem.Models;
using Microsoft.EntityFrameworkCore;

namespace LevelUpInventorySystem.Data
{
    public class InventoryContext : DbContext
    {
        public DbSet<Product> Products { get; set; } // DbSet for your Product class

        public InventoryContext(DbContextOptions<InventoryContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Seed initial data for Products
            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    Id = 1,
                    Name = "Super Mario Odyssey",
                    Description = "Explore incredible places far from the Mushroom Kingdom",
                    Price = 49.99m,
                    Inventory = 10
                },
                new Product
                {
                    Id = 2,
                    Name = "The Legend of Zelda: Breath of the Wild",
                    Description = "Discover Hyrule like never before",
                    Price = 59.99m,
                    Inventory = 8
                },
                new Product
                {
                    Id = 3,
                    Name = "God of War",
                    Description = "Join Kratos on a deep and reflective journey",
                    Price = 39.99m,
                    Inventory = 12
                },
                new Product
                {
                    Id = 4,
                    Name = "Red Dead Redemption 2",
                    Description = "Experience an epic tale of life in America's unforgiving heartland",
                    Price = 49.99m,
                    Inventory = 6
                },
                new Product
                {
                    Id = 5,
                    Name = "Fortnite: Battle Royale",
                    Description = "Drop into a massive online battle with up to 100 players",
                    Price = 0, // Free-to-play
                    Inventory = 15
                }
            );

            base.OnModelCreating(modelBuilder);
        }
    }
}
