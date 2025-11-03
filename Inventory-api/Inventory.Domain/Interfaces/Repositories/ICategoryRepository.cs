using Inventory.Domain.Entities;

namespace Inventory.Domain.Interfaces.Repositories
{
    public interface ICategoryRepository
    {

        Task<Category> GetByIdAsync(long id);
        Task<List<Category>> GetAllAsync();
        Task CreateAsync(Category category);
        Task UpdateAsync(Category category);
        Task DeleteAsync(long id);
    }
}
