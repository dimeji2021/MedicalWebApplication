using MedicalWebApplicationDomain.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MedicalWebApplicationInfastructure.IRepository
{
    public interface IProductRepository
    {
        Task<List<Product>> GetAllProductsAsync();
        Task<bool> AddProductAsync(Product product);
        Task<bool> DeleteProductAsync(Guid Id);
    }
}