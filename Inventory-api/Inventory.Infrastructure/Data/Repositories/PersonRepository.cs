using Inventory.Domain.Entities;
using Inventory.Domain.Interfaces.Repositories;
using Inventory.Infrastructure.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace Inventory.Infrastructure.Data.Repositories
{
    public class PersonRepository : IPersonRepository
    {

        private readonly InventoryContext _context;

        public PersonRepository(InventoryContext context)
        {
            _context = context;
        }

        public async Task<List<Person>> GetAllAsync()
        {
            return await _context.Person.ToListAsync();
        }

        public async Task<Person> GetByIdAsync(long id)
        {
            return await _context.Person.FindAsync(id);
        }

        public async Task CreateAsync(Person person)
        {
            await _context.Person.AddAsync(person);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(Person person)
        {
            _context.Person.Update(person);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(long id)
        {
            var person = await _context.Person.FindAsync(id);

            if (person != null)
            {
                _context.Person.Remove(person);
                await _context.SaveChangesAsync();
            }
        }

    }
}
