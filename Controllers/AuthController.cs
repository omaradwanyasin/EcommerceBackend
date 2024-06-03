using Ecommerce_Backend.Data.DBContext;
using Ecommerce_Backend.Data.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Ecommerce_Backend.Business;
using Ecommerce_Backend.Business.Dto;
using Org.BouncyCastle.Crypto.Generators;



namespace Ecommerce_Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly EcommerceContext _context;
        private readonly IConfiguration _configuration;
        private readonly JwtTokenService _jwtTokenService;

        public AuthController(EcommerceContext context, JwtTokenService jwtTokenService)
        {
            _context = context;
            _jwtTokenService = jwtTokenService;
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register(UserDto request)
        {
            var user = new UserModel { Username = request.Username, Password=request.Password};
            _context.Users.Add(user);
            await _context.SaveChangesAsync();
            return Ok(new { message = "User registered successfully" });
        }

        // below should br login 
    }
}
