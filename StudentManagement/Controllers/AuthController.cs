using Microsoft.AspNetCore.Mvc;
using StudentManagementAPI.DTOs;
using StudentManagementAPI.Services;

namespace StudentManagementAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly JwtService _jwtService;

        public AuthController(JwtService jwtService)
        {
            _jwtService = jwtService;
        }

        [HttpPost("login")]
        public IActionResult Login(LoginRequest request)
        {
            // Demo credentials
            if (request.Username == "admin" &&
                request.Password == "admin123")
            {
                var token = _jwtService.GenerateToken(request.Username);

                return Ok(new
                {
                    Token = token
                });
            }

            return Unauthorized(new
            {
                Message = "Invalid Username or Password"
            });
        }
    }
}