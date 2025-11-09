using AutoMapper;
using Inventory.Application.DTOs.Product;
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
        private readonly IMapper _mapper;

        public ProductController(IProductService service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<List<ProductDTO>>> GetAll()
        {

            List<Product> products = await _service.GetAllAsync();
            List<ProductDTO> result = _mapper.Map<List<ProductDTO>>(products);

            return Ok(result);

        }

        [HttpGet("{id:long}")]
        public async Task<ActionResult<ProductDTO>> GetById(long id)
        {

            Product product = await _service.GetByIdAsync(id);
            ProductDTO result = _mapper.Map<ProductDTO>(product);
            return Ok(result);

        }

        [HttpPost]
        public async Task<ActionResult> Create([FromBody] ProductDTO productDto)
        {

            Product product = _mapper.Map<Product>(productDto);
            await _service.CreateAsync(product);
            return CreatedAtAction(nameof(GetById), new { id = product.Id }, product);

        }

        [HttpPut("{id:long}")]
        public async Task<IActionResult> Update(long id, [FromBody] ProductDTO productDto)
        {

            Product product = _mapper.Map<Product>(productDto);
            product.Id = id;

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
