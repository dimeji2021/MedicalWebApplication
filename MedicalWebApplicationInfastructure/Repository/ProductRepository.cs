using MedicalWebApplicationDomain.Models;
using MedicalWebApplicationHelpers.IHelpers;
using MedicalWebApplicationInfastructure.IRepository;
using System;
using System.Collections.Generic;
using System.Text;
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
    }
}
