using AutoMapper;
using Inventory.Application.DTOs.Product;
using Inventory.Domain.Entities;

namespace Inventory.Application.Mappings
{
    internal class TransactionProductProfile : Profile
    {

        public TransactionProductProfile()
        {
            CreateMap<TransactionProduct, TransactionProductDTO>().ReverseMap();
        }

    }
}
