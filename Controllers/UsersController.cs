using System.ComponentModel.DataAnnotations;
using Ecommerce_Backend.Business.Dto;
using Microsoft.AspNetCore.Mvc;

namespace Ecommerce_Backend.Controllers
{
    [ApiController]
    public class UsersController:Controller
    {
        private readonly UserDto UserDto;
        public UsersController(UserDto userDto)
        {
            userDto = userDto;
        }
      


    }
}
