using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using MyFirstWebApp.Data;
using MyFirstWebApp.Models;
using System.IdentityModel.Tokens.Jwt;

namespace MyFirstWebApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly WebDbContext _dbContext;
        private readonly AppSettings _appSettings;

        public UserController(WebDbContext context, IOptionsMonitor<AppSettings> optionsMonitor) {
             _dbContext = context;
            _appSettings = optionsMonitor.CurrentValue;
        }

        [HttpPost("Login")]
        public IActionResult Validate(LoginModel model)
        {
            var user = _dbContext.NguoiDungs.SingleOrDefault( p => p.UserName == model.UserName && p.Password == model.Password );

            if (user == null)
            {
                return Ok(new ApiResponse
                {
                    Success = false,
                    Message = "Invalid UserName or Password",
                    Data = null
                });
            }

            // Cấp token


            return Ok(new ApiResponse
            {
                Success = true,
                Message = "Authenticate Success",
                Data = null
            });
        }

        private string GenerateToken(NguoiDung nguoiDung)
        {
            var jwtTokenHandler = new JwtSecurityTokenHandler();

            return null;
        }
    }   
}
