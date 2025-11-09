using AutoMapper;
using Inventory.Application.DTOs.Product;
using Inventory.Domain.Entities;

namespace Inventory.Application.Mappings
{
    internal class CategoryProfile : Profile
    {

        public CategoryProfile()
        {
            CreateMap<Category, CategoryDTO>().ReverseMap();
        }

    }
}
