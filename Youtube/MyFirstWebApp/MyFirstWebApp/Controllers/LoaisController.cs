using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyFirstWebApp.Data;
using MyFirstWebApp.Models;
using MyFirstWebApp.Services;

namespace MyFirstWebApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoaisController : ControllerBase
    {
        private readonly ILoaiRepository _loaiRepository;

        public LoaisController(ILoaiRepository loaiRepository) {
            _loaiRepository = loaiRepository;
        }
        [HttpGet]
        public IActionResult GetAll () {
            try
            {
                return Ok(_loaiRepository.GetAll());
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            try
            {
                return Ok(_loaiRepository.GetById(id));
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost]
        public IActionResult Add(LoaiModel loai)
        {
            try
            {
                return Ok(_loaiRepository.Add(loai));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, LoaiVM loai)
        {
            try
            {
                _loaiRepository.Update(loai);
                return NoContent();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            try
            {
                _loaiRepository.Delete(id);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
