using Ecommerce_Backend.Business.Dto;
using Microsoft.AspNetCore.Mvc;

namespace Ecommerce_Backend.Controllers
{
    [ApiController]
    public class CartsController:Controller
    {
        private readonly CartDto cartDto;
        public CartsController(CartDto cartDto)
        {
            this.cartDto = cartDto;
        }
        [HttpGet]
        [Route("/cart")]
        public async Task<IActionResult> Cart()
        {
            ///should call the function in repo 
        }
        [HttpPost]
        [Route("cart")]
        public async Task<IActionResult> AddToCart()
        {
            //call the function inside the repo cart
        }
        [HttpDelete]
        [Route("/cart")]
        public async Task<IActionResult> DeleteFromCart()
        {

        }
    }
}
