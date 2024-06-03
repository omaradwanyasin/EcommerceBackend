using System.ComponentModel.DataAnnotations;

namespace Ecommerce_Backend.Controllers
{
    public class ProductsController
    {
        public int ProductId { get; set; }

        [Required]
        public string? ProductName  { get; set; }

        [Required]
        public string? ProductDescrption { get; set; }




    }
}
