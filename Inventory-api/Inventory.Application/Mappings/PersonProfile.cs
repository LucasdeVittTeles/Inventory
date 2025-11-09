using AutoMapper;
using Inventory.Application.DTOs.Product;
using Inventory.Domain.Entities;

namespace Inventory.Application.Mappings
{
    internal class PersonProfile : Profile
    {

        public PersonProfile()
        {
            CreateMap<Person, PersonDTO>().ReverseMap();
        }

    }
}
