using Inventory.Domain.Entities;
using Inventory.Domain.Interfaces.Services;

namespace Inventory.Application.Services
{
    internal class TransactionService : ITransactionService
    {
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
            throw new NotImplementedException();
        }

        public Task<Transaction> GetByIdAsync(long id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(Transaction transaction)
        {
            throw new NotImplementedException();
        }
    }
}
