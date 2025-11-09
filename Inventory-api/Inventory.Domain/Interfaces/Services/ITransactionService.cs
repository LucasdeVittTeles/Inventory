using Inventory.Domain.Entities;

namespace Inventory.Domain.Interfaces.Services
{
    public interface ITransactionService
    {

        Task<Transaction> GetByIdAsync(long id);
        Task<List<Transaction>> GetAllAsync();
        Task CreateAsync(Transaction transaction);
        Task UpdateAsync(Transaction transaction);
        Task DeleteAsync(long id);

    }
}
