using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyFirstWebApp.Services;

namespace MyFirstWebApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HangHoasController : ControllerBase
    {
        private readonly IHangHoaRepository _hangHoaRepository;

        public HangHoasController(IHangHoaRepository hangHoaRepository) {
            _hangHoaRepository = hangHoaRepository;
        }

        [HttpGet]
        public IActionResult GetAll(string? search = null, double? from = null, double? to = null, int pageNumber = 1, int pageSize = 1)
        {
            return Ok(_hangHoaRepository.GetAll(search, from, to, pageNumber, pageSize));
        }
    }
}
