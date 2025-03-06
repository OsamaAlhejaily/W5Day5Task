using Microsoft.AspNetCore.Mvc;
using ProductAPI.Models;

namespace ProductAPI.Controllers
{
    [ApiController]
    [Route("api/products")]
    public class ProductsController : ControllerBase
    {
        private static readonly List<Product> products = new()
        {
            new Product { Id = 1, Name = "Laptop", Description = "HP Pavilion Laptop", Price = 1200, ImageUrl = "https://m.media-amazon.com/images/I/61LdecwlWYL.jpg" },
            new Product { Id = 2, Name = "Tablet", Description = "Iphone 14", Price = 800, ImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcScx0zZIc5mZmYq4zhvQ4kjJqp5kGwY8U4AOg&s"},
            new Product { Id = 3, Name = "Phone", Description = "Lenovo Tab M10", Price = 1000, ImageUrl = "https://m.media-amazon.com/images/I/618Bb+QzCmL.jpg" },

        };

        [HttpGet]
        public IActionResult GetProducts() => Ok(products);

        [HttpGet("{id}")]
        public IActionResult GetProductById(int id)
        {
            var product = products.FirstOrDefault(p => p.Id == id);
            return product is null ? NotFound() : Ok(product);
        }
    }
}
