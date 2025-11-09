using AutoMapper;
using Inventory.Application.DTOs.Product;
using Inventory.Domain.Entities;
using Inventory.Domain.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;

namespace Inventory.API.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class TransactionController : Controller
    {

        private readonly ITransactionService _service;
        private readonly IMapper _mapper;

        public TransactionController(ITransactionService service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<List<TransactionDTO>>> GetAll()
        {

            List<Transaction> transactions = await _service.GetAllAsync();
            List<TransactionDTO> result = _mapper.Map<List<TransactionDTO>>(transactions);

            return Ok(result);

        }

        [HttpGet("{id:long}")]
        public async Task<ActionResult<TransactionDTO>> GetById(long id)
        {

            Transaction transaction = await _service.GetByIdAsync(id);
            TransactionDTO result = _mapper.Map<TransactionDTO>(transaction);
            return Ok(result);

        }

        [HttpPost]
        public async Task<ActionResult> Create([FromBody] TransactionDTO transactionDTO)
        {

            Transaction transaction = _mapper.Map<Transaction>(transactionDTO);
            await _service.CreateAsync(transaction);
            return CreatedAtAction(nameof(GetById), new { id = transaction.Id }, transaction);

        }

        [HttpPut("{id:long}")]
        public async Task<IActionResult> Update(long id, [FromBody] TransactionDTO transactionDTO)
        {

            Transaction transaction = _mapper.Map<Transaction>(transactionDTO);
            transaction.Id = id;

            await _service.UpdateAsync(transaction);
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
