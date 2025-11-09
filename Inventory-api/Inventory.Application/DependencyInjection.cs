using global::Inventory.Application.Services;
using global::Inventory.Domain.Interfaces.Services;
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
            // Exemplo: depois você adiciona os outros
            // services.AddScoped<ICategoryService, CategoryService>();
            // services.AddScoped<IPersonService, PersonService>();
            // services.AddScoped<ITransactionService, TransactionService>();

            return services;
        }

    }
}
