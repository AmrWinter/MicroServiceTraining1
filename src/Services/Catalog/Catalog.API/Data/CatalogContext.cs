using Catalog.API.Entities;
using MongoDB.Driver;

namespace Catalog.API.Data
{
    public class CatalogContext : ICatalogContext
    {
        public CatalogContext(IConfiguration configuration)
        {
            var client = new MongoClient(configuration.GetValue<string>("ConnectionStrings:ConnectionString"));
            var database = client.GetDatabase(configuration.GetValue<string>("ConnectionStrings:DatabaseName"));

            Products = database.GetCollection<Product>(configuration.GetValue<string>("ConnectionStrings:CollectionName"));
            CatalogContextSeed.SeedDataAsync(Products);
        
        }

        public IMongoCollection<Product> Products { get;}
    
    }
}
