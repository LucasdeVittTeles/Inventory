using AutoMapper;
using Inventory.Application.DTOs.Product;
using Inventory.Domain.Entities;

namespace Inventory.Application.Mappings
{
    internal class TransactionProfile : Profile
    {

        public TransactionProfile()
        {
            CreateMap<Transaction, TransactionDTO>().ReverseMap();
        }

    }
}
