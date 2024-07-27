using Catalog.API.Data;
using Catalog.API.Repositories;
using Catalog.API.Repositories.Interfaces;

namespace Catalog.API.Configurations
{
    public static class ServicesResgisteration
    {

        public static void AddServices(this IServiceCollection services)
        {
            services.AddScoped<ICatalogContext, CatalogContext>();
            services.AddScoped<IProductRepository, ProductRepository>();
        }
    }
}
