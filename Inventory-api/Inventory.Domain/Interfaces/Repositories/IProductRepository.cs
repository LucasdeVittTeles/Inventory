using Inventory.Domain.Entities;

namespace Inventory.Domain.Interfaces.Repositories
{
    public interface IProductRepository
    {

        Task<Product> GetByIdAsync(long id);
        Task<List<Product>> GetAllAsync();
        Task CreateAsync(Product produto);
        Task UpdateAsync(Product produto);
        Task DeleteAsync(long id);

    }
}
