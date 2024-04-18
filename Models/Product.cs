using System.ComponentModel.DataAnnotations;

namespace LevelUpInventorySystem.Models
{
    public class Product
    {
        public int Id { get; set; } // Unique identifier for the product

        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; } // Name of the product

        [StringLength(100, MinimumLength = 5, ErrorMessage = "Description must be between 5 and 100 characters")]
        public string Description { get; set; } // Description of the product

        [Range(0.01, double.MaxValue, ErrorMessage = "Price must be greater than 0")]
        public decimal Price { get; set; } // Price of the product

        [Range(0, int.MaxValue, ErrorMessage = "Inventory must be a non-negative number")]
        public int Inventory { get; set; } // Available quantity in inventory
    }
}
