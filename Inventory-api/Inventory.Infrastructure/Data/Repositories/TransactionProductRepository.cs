using Inventory.Domain.Entities;
using Inventory.Domain.Interfaces.Repositories;
using Inventory.Infrastructure.Data.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Infrastructure.Data.Repositories
{
    public class TransactionProductRepository : ITransactionProductRepository
    {

        private readonly InventoryContext _context;

        public TransactionProductRepository(InventoryContext context)
        {
            _context = context;
        }

        public async Task<List<TransactionProduct>> GetAllAsync()
        {
            return await _context.TransactionProduct.ToListAsync();
        }

        public async Task<TransactionProduct> GetByIdAsync(long id)
        {
            return await _context.TransactionProduct.FindAsync(id);
        }

        public async Task CreateAsync(TransactionProduct transactionProduct)
        {
            await _context.TransactionProduct.AddAsync(transactionProduct);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(TransactionProduct transactionProduct)
        {
            _context.TransactionProduct.Update(transactionProduct);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(long id)
        {

            var transactionProduct = await _context.TransactionProduct.FindAsync(id);

            if (transactionProduct != null)
            {
                _context.TransactionProduct.Remove(transactionProduct);
                await _context.SaveChangesAsync();
            }

        }
    }
}
