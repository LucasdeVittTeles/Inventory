using Inventory.Domain.Entities;
using Inventory.Domain.Interfaces.Repositories;
using Inventory.Domain.Interfaces.Services;

namespace Inventory.Application.Services
{
    public class TransactionProductService : ITransactionProductService
    {

        private readonly ITransactionProductRepository _repository;

        public TransactionProductService(ITransactionProductRepository repository)
        {
            _repository = repository;
        }

        private void ValidateFields(TransactionProduct transactionProduct)
        {
            if (transactionProduct == null)
                throw new ArgumentNullException(nameof(transactionProduct), "O produto da transação não pode ser nulo.");

            if (transactionProduct.TransactionId == 0)
                throw new ArgumentException("A transação é obrigatório.");

            if (transactionProduct.TransactionId == 0)
                throw new ArgumentException("O produto é obrigatório");

            if (transactionProduct.Amount <= 1)
                throw new ArgumentException("A quantidade deve ser no minimo um.");

            if (transactionProduct.UnitPrice < 0)
                throw new ArgumentException("A preço unitário não pode ser negativo.");
        }

        public Task CreateAsync(TransactionProduct transactionProduct)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(long id)
        {
            throw new NotImplementedException();
        }

        public Task<List<TransactionProduct>> GetAllAsync()
        {
            return _repository.GetAllAsync();
        }

        public async Task<TransactionProduct> GetByIdAsync(long id)
        {
            TransactionProduct transactionProduct = await _repository.GetByIdAsync(id);

            if (transactionProduct == null)
            {
                throw new KeyNotFoundException("Produto da transação não encontrado.");
            }

            return transactionProduct;
        }

        public Task UpdateAsync(TransactionProduct transactionProduct)
        {
            throw new NotImplementedException();
        }
    }
}
