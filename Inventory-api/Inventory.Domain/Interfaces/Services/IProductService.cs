using Inventory.Domain.Entities;

namespace Inventory.Domain.Interfaces.Services

{
    public interface IProductService
    {

        Task<List<Product>> GetAllAsync();
        Task<Product> GetByIdAsync(long id);
        Task CreateAsync(Product product);
        Task UpdateAsync(Product product);
        Task DeleteAsync(long id);

    }
}
