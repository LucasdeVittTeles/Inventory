using Inventory.Domain.Entities;
using Inventory.Domain.Interfaces.Repositories;
using Inventory.Infrastructure.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace Inventory.Infrastructure.Data.Repositories
{
    public class TransactionRepository : ITransactionRepository
    {

        private readonly InventoryContext _context;

        public TransactionRepository(InventoryContext context)
        {
            _context = context;
        }


        public async Task<List<Transaction>> GetAllAsync()
        {
            return await _context.Transaction.ToListAsync();
        }

        public async Task<Transaction> GetByIdAsync(long id)
        {
            return await _context.Transaction.FindAsync(id);
        }

        public async Task CreateAsync(Transaction transaction)
        {
            await _context.Transaction.AddAsync(transaction);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(Transaction transaction)
        {
            _context.Transaction.Update(transaction);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(long id)
        {

            var transaction = await _context.Transaction.FindAsync(id);

            if (transaction != null)
            {
                _context.Transaction.Remove(transaction);
                await _context.SaveChangesAsync();
            }

            throw new NotImplementedException();
        }
    }
}
