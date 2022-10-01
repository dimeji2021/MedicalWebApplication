using MedicalWebApplicationDomain.Models;
using MedicalWebApplicationService.ViewModel;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MedicalWebApplicationService.IService
{
    public interface IProductService
    {
        Task<List<Product>> GetAllProducts();
        Task<bool> AddProduct(PostViewModel post);
        Task<bool> DeleteProduct(Guid Id);
    }
}