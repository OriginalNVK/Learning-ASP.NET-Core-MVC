using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Identity.Client;
using MyFirstWebApp.Data;
using MyFirstWebApp.Models;

namespace MyFirstWebApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoaiController : ControllerBase
    {
        private readonly WebDbContext _DbContext;

        public LoaiController(WebDbContext context)
        {
            _DbContext = context;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var Loais = _DbContext.Loais.ToList();
            return Ok(Loais);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var loai = _DbContext.Loais.FirstOrDefault(x => x.MaLoai == id);
            if(loai == null)
            {
                return BadRequest();
            }
            return Ok(loai);
        }

        [HttpPost]
        public IActionResult Create(LoaiModel model)
        {
            var loai = new Loai()
            { 
                TenLoai = model.TenLoai,
            };

            _DbContext.Loais.Add(loai);
            _DbContext.SaveChanges();
            return Ok(loai);
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, LoaiModel model)
        {
            var loai = _DbContext.Loais.FirstOrDefault(x => x.MaLoai == id);
            if(loai == null)
            {
                return NotFound();
            }

            loai.TenLoai  = model.TenLoai;

            _DbContext.SaveChanges();
            return NoContent(); 
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var loai = _DbContext.Loais.FirstOrDefault(x => x.MaLoai == id);
            if(loai == null)
            {
                return NotFound();
            }

            _DbContext.Loais.Remove(loai);
            _DbContext.SaveChanges();
            return NoContent();
        }
    }
}
