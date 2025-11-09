using Inventory.Domain.Entities;
using Inventory.Domain.Interfaces.Services;

namespace Inventory.Application.Services
{
    public class TransactionProductService : ITransactionProductService
    {
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
            throw new NotImplementedException();
        }

        public Task<TransactionProduct> GetByIdAsync(long id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(TransactionProduct transactionProduct)
        {
            throw new NotImplementedException();
        }
    }
}
