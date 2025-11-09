using Inventory.Domain.Entities;

namespace Inventory.Domain.Interfaces.Services
{
    public interface ICategoryService
    {
        Task<List<Category>> GetAllAsync();
        Task<Category> GetByIdAsync(long id);
        Task CreateAsync(Category category);
        Task UpdateAsync(Category category);
        Task DeleteAsync(long id);

    }
}
