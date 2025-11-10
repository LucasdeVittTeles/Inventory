using Inventory.Domain.Entities;
using Inventory.Domain.Interfaces.Repositories;
using Inventory.Domain.Interfaces.Services;

namespace Inventory.Application.Services
{
    public class TransactionService : ITransactionService
    {

        private readonly ITransactionRepository _repository;

        public TransactionService(ITransactionRepository repository)
        {
            _repository = repository;
        }

        private void ValidateFields(Transaction transaction)
        {
            if (transaction == null)
                throw new ArgumentNullException(nameof(transaction), "A transação não pode ser nula.");

            if (transaction.PartnerId == 0)
                throw new ArgumentException("Um parceiro é obrigatório");

        }


        public Task CreateAsync(Transaction transaction)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(long id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Transaction>> GetAllAsync()
        {
            return _repository.GetAllAsync();
        }

        public async Task<Transaction> GetByIdAsync(long id)
        {
            Transaction transaction = await _repository.GetByIdAsync(id);

            if (transaction == null)
            {
                throw new KeyNotFoundException("Transação não encontrada.");
            }

            return transaction;
        }

        public Task UpdateAsync(Transaction transaction)
        {
            throw new NotImplementedException();
        }
    }
}
