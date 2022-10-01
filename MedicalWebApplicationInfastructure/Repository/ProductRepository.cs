using MedicalWebApplicationDomain.Models;
using MedicalWebApplicationHelpers.IHelpers;
using MedicalWebApplicationInfastructure.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MedicalWebApplicationInfastructure.Repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly string productFile = "Products.json";
        private readonly IReadWriteToJson _readWriteToJson;
        public ProductRepository(IReadWriteToJson readWriteToJson)
        {
            _readWriteToJson = readWriteToJson;
        }
        public async Task<List<Product>> GetAllProductsAsync()
        {
            return await _readWriteToJson.ReadJsonAsync<Product>(productFile);
        }
        public async Task<bool> AddProductAsync(Product product)
        {
            return await _readWriteToJson.WriteJsonAsync<Product>(productFile, product);
        }
        public async Task<bool> DeleteProductAsync(Guid Id)
        {
            var products = await _readWriteToJson.ReadJsonAsync<Product>(productFile);
            var product = products.Where(s=>s.Id.Equals(Id)).FirstOrDefault();
            if (product is null)
            {
                return false;
            }
            products.Remove(product);
            return _readWriteToJson.UpdateJsonAsync<Product>(productFile, products);
        }
    }
}
