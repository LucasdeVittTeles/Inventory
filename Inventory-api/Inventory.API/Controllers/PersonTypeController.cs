using Inventory.Domain.Entities;
using Inventory.Domain.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;

namespace Inventory.API.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class PersonTypeController : Controller
    {

        private readonly IPersonTypeService _service;

        public PersonTypeController(IPersonTypeService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<ActionResult<List<PersonType>>> GetAll()
        {

            List<PersonType> personType = await _service.GetAllAsync();

            return Ok(personType);

        }

        [HttpGet("{id:long}")]
        public async Task<ActionResult<PersonType>> GetById(long id)
        {

            PersonType personType = await _service.GetByIdAsync(id);
            return Ok(personType);

        }

        [HttpPost]
        public async Task<ActionResult> Create([FromBody] PersonType personType)
        {

            await _service.CreateAsync(personType);
            return CreatedAtAction(nameof(GetById), new { id = personType.Id }, personType);

        }

        [HttpPut("{id:long}")]
        public async Task<IActionResult> Update(long id, [FromBody] PersonType personType)
        {

            personType.Id = id;

            await _service.UpdateAsync(personType);
            return NoContent();

        }
    }
}
