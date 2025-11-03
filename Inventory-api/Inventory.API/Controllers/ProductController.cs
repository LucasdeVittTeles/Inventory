using Inventory.Domain.Entities;
using Inventory.Domain.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;

namespace Inventory.API.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class ProductController : Controller
    {

        private readonly IProductService _service;

        public ProductController(IProductService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<ActionResult<List<Product>>> GetAll()
        {

            List<Product> products = await _service.GetAllAsync();
            return Ok(products);

        }

        [HttpGet("{id:long}")]
        public async Task<ActionResult<Product>> GetById(long id)
        {

            Product product = await _service.GetByIdAsync(id);
            return Ok(product);

        }

        [HttpPost]
        public async Task<ActionResult> Create([FromBody] Product product)
        {

            await _service.CreateAsync(product);
            return CreatedAtAction(nameof(GetById), new { id = product.Id }, product);

        }

        [HttpPut("{id:long}")]
        public async Task<IActionResult> Update(long id, [FromBody] Product product)
        {

            await _service.UpdateAsync(product);
            return NoContent();

        }

        [HttpDelete("{id:long}")]
        public async Task<IActionResult> Delete(long id)
        {

            await _service.DeleteAsync(id);
            return NoContent();

        }
    }
}
