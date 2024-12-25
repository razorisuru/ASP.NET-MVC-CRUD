using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Products.Models
{
    public class ProductDto
    {
        [Required, MaxLength(100)]
        public string Name { get; set; } = " ";
        [Required]
        public string Description { get; set; } = " ";

        [Required, MaxLength(100)]
        public string Category { get; set; } = " ";
        [Required]
        public decimal Price { get; set; }

        public IFormFile? ImageFile { get; set; }
    }
}
