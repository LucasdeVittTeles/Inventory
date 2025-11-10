using Inventory.Domain.Entities;
using Inventory.Domain.Interfaces.Repositories;
using Inventory.Domain.Interfaces.Services;

namespace Inventory.Application.Services
{
    public class PersonTypeService : IPersonTypeService
    {

        private readonly IPersonTypeRepository _repository;

        public PersonTypeService(IPersonTypeRepository repository)
        {
            _repository = repository;
        }
        private void ValidateFields(Person person)
        {

            if (person == null)
                throw new ArgumentNullException(nameof(person), "O tipo da pessoa não pode ser nulo.");

            if (string.IsNullOrWhiteSpace(person.Name))
                throw new ArgumentException("O nome do tipo da pessoa é obrigatório.");

        }

        public Task CreateAsync(PersonType personType)
        {
            throw new NotImplementedException();
        }

        public Task<List<PersonType>> GetAllAsync()
        {
            return _repository.GetAllAsync();
        }

        public async Task<PersonType> GetByIdAsync(long id)
        {
            PersonType personType = await _repository.GetByIdAsync(id);

            if (personType == null)
            {
                throw new KeyNotFoundException("Tipo de pessoa não encontrado.");
            }

            return personType;
        }

        public Task UpdateAsync(PersonType personType)
        {
            throw new NotImplementedException();
        }
    }
}
