using System.ComponentModel.DataAnnotations;

namespace Models
{
    public class Product
    {
        public int Id { get; set; }

        [Required]
        [StringLength(maximumLength: 100, MinimumLength = 3)]
        public string Name { get; set; } = null!;

        [Range(0.01, 100000.00)]
        public decimal Price { get; set; }

        // Foreign Key for Category
        public int CategoryId { get; set; }

        // Navigation property (Relationship)
        public Category ProductCategory { get; set; } = null!;
    }

    public class Category
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; } = null!;

        // Navigation property (One-to-Many Relationship)
        public ICollection<Product>? Products { get; set; }
    }
}