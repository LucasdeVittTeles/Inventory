using Inventory.Domain.Entities;
using Inventory.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Application.Services
{
    public class PersonTypeService : IPersonTypeService
    {
        public Task CreateAsync(PersonType personType)
        {
            throw new NotImplementedException();
        }

        public Task<List<PersonType>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<PersonType> GetByIdAsync(long id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(PersonType personType)
        {
            throw new NotImplementedException();
        }
    }
}
