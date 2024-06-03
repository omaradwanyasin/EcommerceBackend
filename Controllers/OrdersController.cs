using Ecommerce_Backend.Business.Dto;
using Microsoft.AspNetCore.Mvc;

namespace Ecommerce_Backend.Controllers
{
    [ApiController]
    public class OrdersController:Controller
    {
        private readonly OrdersDto OrderDto;
        public OrdersController(OrdersDto ordersDto)
        {
            OrderDto = ordersDto;
        }
        //[HttpGet]
        //[Route("/order")]
        //public async Task<IActionResult> order()
        //{
        //    ///should call the function in repo 
        //}
        //[HttpPost]
        //[Route("order")]
        //public async Task<IActionResult> AddOrder()
        //{
        //    //call the function inside the repo cart
        //}
        //[HttpDelete]
        //[Route("/order")]
        //public async Task<IActionResult> DeleteOrder()
        //{

        //}

    }
}
