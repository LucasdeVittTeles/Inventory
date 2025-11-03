using Inventory.Domain.Entities;

namespace Inventory.Domain.Interfaces.Repositories

{
    public interface ITransactionProductRepository
    {
        Task<TransactionProduct> GetByIdAsync(long id);
        Task<List<TransactionProduct>> GetAllAsync();
        Task CreateAsync(TransactionProduct transactionProduct);
        Task UpdateAsync(TransactionProduct transactionProduct);
        Task DeleteAsync(long id);

    }
}
