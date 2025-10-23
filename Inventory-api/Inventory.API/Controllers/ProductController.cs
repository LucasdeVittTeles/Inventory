using Inventory.Domain.Entities;
using Inventory.Infrastructure.Context;
using Microsoft.AspNetCore.Mvc;

namespace Inventory.API.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class ProductController : Controller
    {

        private readonly InventoryContext _context;

        public ProductController(InventoryContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Get() => Ok(_context.Products.ToList());

        [HttpPost]
        public IActionResult Post([FromBody] Product product)
        {
            _context.Products.Add(product);
            _context.SaveChanges();
            return CreatedAtAction(nameof(Get), new { id = product.Id }, product);
        }

    }
}
