using Inventory.Domain.Entities;
using Inventory.Domain.Interfaces.Repositories;
using Inventory.Infrastructure.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace Inventory.Infrastructure.Data.Repositories
{
    public class PersonTypeRespository : IPersonTypeRepository
    {

        private readonly InventoryContext _context;

        public PersonTypeRespository(InventoryContext context)
        {
            _context = context;
        }

        public async Task<List<PersonType>> GetAllAsync()
        {
            return await _context.PersonType.ToListAsync();
        }

        public async Task<PersonType> GetByIdAsync(long id)
        {
            return await _context.PersonType.FindAsync(id);
        }

        public async Task CreateAsync(PersonType personType)
        {
            await _context.PersonType.AddAsync(personType);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(PersonType personType)
        {
            _context.PersonType.Update(personType);
            await _context.SaveChangesAsync();
        }

    }
}
