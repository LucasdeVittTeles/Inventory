using Inventory.Domain.Entities;
using Inventory.Domain.Interfaces.Repositories;
using Inventory.Infrastructure.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace Inventory.Infrastructure.Data.Repositories
{
    internal class CategoryRepository : ICategoryRepository
    {

        private readonly InventoryContext _context;

        public CategoryRepository(InventoryContext context)
        {
            _context = context;
        }

        public async Task<List<Category>> GetAllAsync()
        {
            return await _context.Category.ToListAsync();
        }

        public async Task<Category> GetByIdAsync(long id)
        {
            return await _context.Category.FindAsync(id);
        }

        public async Task CreateAsync(Category category)
        {
            await _context.Category.AddAsync(category);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(Category category)
        {
            _context.Category.Update(category);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(long id)
        {
            var category = await _context.Category.FindAsync(id);

            if (category != null)
            {
                _context.Category.Remove(category);
                await _context.SaveChangesAsync();
            }
        }
    }
}
