using AutoMapper;
using Inventory.Application.DTOs.Product;
using Inventory.Domain.Entities;
using Inventory.Domain.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;

namespace Inventory.API.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class PersonController : Controller
    {

        private readonly IPersonService _service;
        private readonly IMapper _mapper;

        public PersonController(IPersonService service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<List<PersonDTO>>> GetAll()
        {

            List<Person> persons = await _service.GetAllAsync();
            List<PersonDTO> result = _mapper.Map<List<PersonDTO>>(persons);

            return Ok(result);

        }

        [HttpGet("{id:long}")]
        public async Task<ActionResult<PersonDTO>> GetById(long id)
        {

            Person person = await _service.GetByIdAsync(id);
            PersonDTO result = _mapper.Map<PersonDTO>(person);
            return Ok(result);

        }

        [HttpPost]
        public async Task<ActionResult> Create([FromBody] PersonDTO personDTO)
        {

            Person person = _mapper.Map<Person>(personDTO);
            await _service.CreateAsync(person);
            return CreatedAtAction(nameof(GetById), new { id = person.Id }, person);

        }

        [HttpPut("{id:long}")]
        public async Task<IActionResult> Update(long id, [FromBody] PersonDTO personDTO)
        {

            Person person = _mapper.Map<Person>(personDTO);
            person.Id = id;

            await _service.UpdateAsync(person);
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
