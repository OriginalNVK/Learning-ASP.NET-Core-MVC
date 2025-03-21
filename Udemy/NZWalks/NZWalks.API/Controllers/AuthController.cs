using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Identity.Client;
using NZWalks.API.Models.DTOs;
using NZWalks.API.Repositories;

namespace NZWalks.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly UserManager<IdentityUser> userManager;
        private readonly ITokenRepository tokenRepository;

        public AuthController(UserManager<IdentityUser> userManager, ITokenRepository tokenRepository)
        {
            this.userManager = userManager;
            this.tokenRepository = tokenRepository;
        }

        [HttpPost]
        [Route("Register")]
        public async Task<IActionResult> Register([FromBody] RegisterRequestDto registerRequestDto)
        {
            var IdentityUser = new IdentityUser() {
                Email = registerRequestDto.UserName,
                UserName = registerRequestDto.UserName,
            };

            var IdentityResult = await userManager.CreateAsync(IdentityUser, registerRequestDto.Password);

            if (IdentityResult.Succeeded)
            {
                if(registerRequestDto.Roles != null && registerRequestDto.Roles.Any())
                {
                    IdentityResult = await userManager.AddToRolesAsync(IdentityUser, registerRequestDto.Roles);

                    if(IdentityResult.Succeeded)
                    {
                        return Ok("User was registerd! Please Login.");
                    }
                }
            }
            return BadRequest("Something went wrong");
        }

        [HttpPost]
        [Route("Login")]
        public async Task<IActionResult> Login(LoginRequestDto loginRequestDto)
        {
            var user = await userManager.FindByEmailAsync(loginRequestDto.UserName);
            if(user != null)
            {
                var checkPasswordResult = await userManager.CheckPasswordAsync(user, loginRequestDto.Password);
                if (checkPasswordResult)
                {
                    // Create Token
                    var roles = await userManager.GetRolesAsync(user);
                    if (roles != null)
                    {
                        var jwtToken = tokenRepository.CreateToken(user, roles.ToList());
                        var response = new LoginResponseDto()
                        {
                            JwtToken = jwtToken,
                        };
                        return Ok(response);
                    }
                }

                
            }
            return BadRequest("Something Went Wrong");
        }
    }
}
