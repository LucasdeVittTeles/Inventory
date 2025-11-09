using Inventory.Application.Services;
using Inventory.Domain.Interfaces.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Inventory.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            // Serviços de aplicação
            services.AddScoped<IProductService, ProductService>();
            services.AddScoped<ICategoryService, CategoryService>();
            services.AddScoped<IPersonService, PersonService>();
            services.AddScoped<IPersonTypeService, PersonTypeService>();
            services.AddScoped<ITransactionService, TransactionService>();
            services.AddScoped<ITransactionProductService, TransactionProductService>();

            return services;
        }

    }
}
