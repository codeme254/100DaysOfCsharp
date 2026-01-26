using System.ComponentModel.DataAnnotations;

namespace DTOs
{
    public class GetProductDTO
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public decimal Price { get; set; }
        public string CategoryName { get; set; } = null!;
    }

    public class CreateProductDTO
    {
        [Required(ErrorMessage = "Product name is required")]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "Name must be between 3 and 100 characters")]
        public string Name { get; set; } = null!;

        [Range(0.01, 100000.00, ErrorMessage = "Price must be between 0.01 and 100_000")]
        public decimal Price { get; set; }

        [Required(ErrorMessage = "Category ID is required")]
        public int CategoryId { get; set; }
    }

    public class UpdateProductDTO
    {
        [Required(ErrorMessage = "Product Id is required")]
        public int Id { get; set; }

        [Required(ErrorMessage = "Product name is required")]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "Name must be between 3 and 100 characters")]
        public string Name { get; set; } = null!;

        [Range(0.01, 100000.00, ErrorMessage = "Price must be between 0.01 and 100_000")]
        public decimal Price { get; set; }

        [Required(ErrorMessage = "Category ID is required")]
        public int CategoryId { get; set; }
    }
}