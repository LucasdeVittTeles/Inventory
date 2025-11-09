using Inventory.Domain.Entities;

namespace Inventory.Domain.Interfaces.Services
{
    public interface ITransactionProductService
    {
        Task<TransactionProduct> GetByIdAsync(long id);
        Task<List<TransactionProduct>> GetAllAsync();
        Task CreateAsync(TransactionProduct transactionProduct);
        Task UpdateAsync(TransactionProduct transactionProduct);
        Task DeleteAsync(long id);

    }
}
