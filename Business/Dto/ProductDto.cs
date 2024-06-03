using System.ComponentModel.DataAnnotations;

namespace Ecommerce_Backend.Business.Dto
{
    public class ProductDto
    {
        public int ProductId { get; set; }

        [Required]
        public string? ProductName { get; set; }

        [Required]
        public string? ProductDescrption { get; set; }

        public string? ProductPrice  { get; set; }
    }
}
