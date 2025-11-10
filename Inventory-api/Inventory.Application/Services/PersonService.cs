using Inventory.Domain.Entities;
using Inventory.Domain.Interfaces.Repositories;
using Inventory.Domain.Interfaces.Services;

namespace Inventory.Application.Services
{
    public class PersonService : IPersonService
    {

        private readonly IPersonRepository _repository;

        public PersonService(IPersonRepository repository)
        {
            _repository = repository;
        }

        private void ValidateFields(Person person)
        {

            if (person == null)
                throw new ArgumentNullException(nameof(person), "A pessoa não pode ser nula.") ;

            if (string.IsNullOrWhiteSpace(person.Name))
                throw new ArgumentException("O nome da pessoa é obrigatório.");

            if (string.IsNullOrWhiteSpace(person.Email))
                throw new ArgumentException("O email da pessoa é obrigatório.");

            if (string.IsNullOrWhiteSpace(person.Phone))
                throw new ArgumentException("O contato da pessoa é obrigatório.");

            if (string.IsNullOrWhiteSpace(person.Address))
                throw new ArgumentException("O endereço da pessoa é obrigatório.");

            if (person.PersonTypeId == 0)
                throw new ArgumentException("O tipo de pessoa é obrigatório.");

        }


        public Task CreateAsync(Person person)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(long id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Person>> GetAllAsync()
        {
            return _repository.GetAllAsync();
        }

        public async Task<Person> GetByIdAsync(long id)
        {
            Person person = await _repository.GetByIdAsync(id);

            if (person == null)
            {
                throw new KeyNotFoundException("Pessoa não encontrada.");
            }

            return person;
        }

        public Task UpdateAsync(Person person)
        {
            throw new NotImplementedException();
        }
    }
}
