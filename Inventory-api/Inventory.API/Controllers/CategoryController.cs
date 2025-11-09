using AutoMapper;
using Inventory.Application.DTOs.Product;
using Inventory.Domain.Entities;
using Inventory.Domain.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;

namespace Inventory.API.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class CategoryController : Controller
    {

        private readonly ICategoryService _service;
        private readonly IMapper _mapper;

        public CategoryController(ICategoryService service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<List<CategoryDTO>>> GetAll()
        {

            List<Category> categories = await _service.GetAllAsync();
            List<CategoryDTO> result = _mapper.Map<List<CategoryDTO>>(categories);

            return Ok(result);

        }

        [HttpGet("{id:long}")]
        public async Task<ActionResult<CategoryDTO>> GetById(long id)
        {

            Category category = await _service.GetByIdAsync(id);
            CategoryDTO result = _mapper.Map<CategoryDTO>(category);

            return Ok(result);

        }

        [HttpPost]
        public async Task<ActionResult> Create([FromBody] CategoryDTO categoryDTO)
        {

            Category category = _mapper.Map<Category>(categoryDTO);
            await _service.CreateAsync(category);
            return CreatedAtAction(nameof(GetById), new { id = category.Id }, category);

        }

        [HttpPut("{id:long}")]
        public async Task<IActionResult> Update(long id, [FromBody] CategoryDTO categoryDTO)
        {

            Category category = _mapper.Map<Category>(categoryDTO);
            category.Id = id;

            await _service.UpdateAsync(category);
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
