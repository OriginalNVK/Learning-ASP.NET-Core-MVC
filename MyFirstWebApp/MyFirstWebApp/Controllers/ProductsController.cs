using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyFirstWebApp.Services;

namespace MyFirstWebApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IHangHoaRepository _hangHoaRepository;

        public ProductsController(IHangHoaRepository hangHoaRepository) { 
            _hangHoaRepository = hangHoaRepository;
        }

        [HttpGet]
        public IActionResult GetAll(string search)
        {
            try
            {
                return Ok(_hangHoaRepository.GetAll(search));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
