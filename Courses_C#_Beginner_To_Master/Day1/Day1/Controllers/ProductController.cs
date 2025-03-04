using Day1.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Day1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        public List<Product> Products { get; set; } = new List<Product>()
        {
            new Product{ID = 1, Name = "Product 1", Price = 123.1 } ,
            new Product{ID = 2, Name = "Product 2", Price = 123.2}
        };

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(Products);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            Product? product = Products.FirstOrDefault(x => x.ID == id);
            if(product == null)
            {
                return NotFound();
            }    
            return Ok(product);
        }

        [HttpPost]
        public IActionResult Create(Product product)
        {
            if(Products.FirstOrDefault(x => x.ID == product.ID) != null) {
                return BadRequest();
            }
            Products.Add(product);
            return Ok(GetById(product.ID));
        }

        [HttpPut("{id}")]
        public IActionResult Put(Product product)
        {
            Product? productBeforeUpdate = Products.FirstOrDefault(x => x.ID == product.ID);
            if (productBeforeUpdate == null)
            {
                return NotFound();
            }    
            productBeforeUpdate.Name = product.Name;
            productBeforeUpdate.Price = product.Price;
            return Ok(productBeforeUpdate);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            Product? product = Products.FirstOrDefault(y => y.ID == id);
            if(product == null)
            {
                return NotFound();
            }
            Products.Remove(product);
            return Ok();
        }
        
    }
}
