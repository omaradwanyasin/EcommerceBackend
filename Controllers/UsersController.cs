using System.ComponentModel.DataAnnotations;
using Ecommerce_Backend.Business.Dto;
using Ecommerce_Backend.Data.DBContext;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Ecommerce_Backend.Data.Models;
namespace Ecommerce_Backend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsersController:ControllerBase
    {
        private readonly UserDto UserDto;
        private readonly UserContext _context;

        public UsersController(UserContext context)
        {
            _context = context;
        }
        //public UsersController(UserDto userDto)
        //{
        //    userDto = userDto;
        //}

        [HttpPost]
        public async Task<ActionResult<UserModel>> PostUser(UserModel user)
        {
            _context.Users.Add(user);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetUser), new { id = user.Id }, user);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<UserModel>> GetUser(int id)
        {
            var user = await _context.Users.FindAsync(id);

            if (user == null)
            {
                return NotFound();
            }

            return user;
        }

    }
}
