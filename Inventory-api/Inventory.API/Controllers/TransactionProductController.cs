using AutoMapper;
using Inventory.Application.DTOs.Product;
using Inventory.Domain.Entities;
using Inventory.Domain.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;

namespace Inventory.API.Controllers
{


    [ApiController]
    [Route("api/[controller]")]
    public class TransactionProductController : Controller
    {

        private readonly ITransactionProductService _service;
        private readonly IMapper _mapper;

        public TransactionProductController(ITransactionProductService service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<List<TransactionProductDTO>>> GetAll()
        {

            List<TransactionProduct> transactionsProducts = await _service.GetAllAsync();
            List<TransactionProductDTO> result = _mapper.Map<List<TransactionProductDTO>>(transactionsProducts);

            return Ok(result);

        }

        [HttpGet("{id:long}")]
        public async Task<ActionResult<TransactionDTO>> GetById(long id)
        {

            TransactionProduct transactionProduct = await _service.GetByIdAsync(id);
            TransactionProductDTO result = _mapper.Map<TransactionProductDTO>(transactionProduct);
            return Ok(result);

        }

        [HttpPost]
        public async Task<ActionResult> Create([FromBody] TransactionProductDTO transactionProductDTO)
        {

            TransactionProduct transactionProduct = _mapper.Map<TransactionProduct>(transactionProductDTO);
            await _service.CreateAsync(transactionProduct);
            return CreatedAtAction(nameof(GetById), new { id = transactionProduct.Id }, transactionProduct);

        }

        [HttpPut("{id:long}")]
        public async Task<IActionResult> Update(long id, [FromBody] TransactionProductDTO transactionProductDTO)
        {

            TransactionProduct transactionProduct = _mapper.Map<TransactionProduct>(transactionProductDTO);
            transactionProduct.Id = id;

            await _service.UpdateAsync(transactionProduct);
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
