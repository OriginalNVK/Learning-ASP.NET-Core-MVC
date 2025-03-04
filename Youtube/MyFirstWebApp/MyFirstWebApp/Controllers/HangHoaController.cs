using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyFirstWebApp.Data;
using MyFirstWebApp.Models;

namespace MyFirstWebApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HangHoaController : ControllerBase
    {
        private readonly WebDbContext _dbContext;

        public HangHoaController(WebDbContext dbContext) {
            _dbContext = dbContext;
        }

        [HttpGet]
        public IActionResult Get() {
            return Ok(_dbContext.HangHoas.ToList());
        }

        [HttpGet("{id}")]
        public IActionResult GetById(string id) {
            try
            {
                var product = _dbContext.HangHoas.FirstOrDefault(x => x.MaHh == Guid.Parse(id));
                if (product == null)
                {
                    return NotFound($"The {id} does not match any product");
                }
                return Ok(product);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        public IActionResult Create(HangHoaVM product)
        {
            try
            {
                var HangHoa = new Data.HangHoa()
                {
                    TenHH = product.TenHH,
                    GiaHH = product.Gia,
                };
                _dbContext.HangHoas.Add(HangHoa);
                _dbContext.SaveChanges();
                return CreatedAtAction(nameof(GetById), new {id = HangHoa.MaHh},
                    new
                {
                    Status = true,
                    Data = product
                }); ;
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut("{id}")]
        public IActionResult Edit(string id, HangHoaVM product)
        {
            try
            {
                var _product = _dbContext.HangHoas.FirstOrDefault(x => x.MaHh == Guid.Parse(id));
                if (_product == null)
                {
                    return NotFound($"The {id} does not match any product");
                }
                _product.TenHH = product.TenHH;
                _product.GiaHH = product.Gia;
                _dbContext.SaveChanges();
                return NoContent();
            }
            catch(Exception ex) {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(string id) {
            try
            {
                var _product = _dbContext.HangHoas.FirstOrDefault(x => x.MaHh == Guid.Parse(id));
                if (_product == null)
                {
                    return NotFound($"The {id} does not match any product");
                }
                _dbContext.HangHoas.Remove(_product);
                _dbContext.SaveChanges();
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
