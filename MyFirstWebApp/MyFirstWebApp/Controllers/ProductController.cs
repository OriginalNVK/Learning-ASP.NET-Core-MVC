using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyFirstWebApp.Models;

namespace MyFirstWebApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        public static List<Product> Products { get; set; } = new List<Product>();

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(Products);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(string id)
        {
            try
            {
                var product = Products.SingleOrDefault(x => x.ID == Guid.Parse(id));
                if (product == null)
                {
                    return NotFound();
                }
                return Ok(product);
            }
            catch(Exception ex) { 
                Console.Error.WriteLine(ex.ToString());
                return BadRequest();
            }
        }

        [HttpPost]
        public IActionResult Create(ProductVM productVM)
        {
            var Product = new Product()
            {
                ID = Guid.NewGuid(),
                Name = productVM.Name,
                Price = productVM.Price,
            };

            Products.Add(Product);
            return Ok(new
            {
                Message = true,
                Data = Product
            });
        }

        [HttpPut("{id}")]
        public IActionResult Edit(string id, ProductVM productVM)
        {
            try
            {
                var product = Products.SingleOrDefault(x => x.ID == Guid.Parse(id));
                if (product == null)
                {
                    return NotFound();
                }
                product.Name = productVM.Name;
                product.Price = productVM.Price;
                return Ok();
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine(ex.ToString());
                return BadRequest();
            }
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(string id)
        {
            try
            {
                var product = Products.SingleOrDefault(x => x.ID == Guid.Parse(id));
                if (product == null)
                {
                    return NotFound();
                }

                Products.Remove(product);
                return Ok();
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine(ex.ToString());
                return BadRequest();
            }
        }
    }
}
