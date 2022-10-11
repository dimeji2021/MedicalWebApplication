using MedicalWebApplicationDomain.Models;
using MedicalWebApplicationHelpers.IHelpers;
using MedicalWebApplicationInfastructure.IRepository;
using MedicalWebApplicationService.IService;
using MedicalWebApplicationService.ViewModel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace MedicalWebApplicationService.Service
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;
        private readonly IUtility _utility;
        private readonly string FilePath = Path.Combine(Directory.GetParent
            (Directory.GetCurrentDirectory()).FullName,
            @"MedicalWebApplication\wwwroot\images\");
        public ProductService(IProductRepository productRepository, IUtility utility)
        {
            _productRepository = productRepository;
            _utility = utility;
        }
        public async Task<List<Product>> GetAllProducts()
        {
            return await _productRepository.GetAllProductsAsync();
        }
        public async Task<bool> AddProduct(PostViewModel post)
        {
            Product product = new Product
            {
                Id = Guid.NewGuid(),
                ProductDescription = post.ProductDescription,
                ProductName = post.ProductName,
                ProductLink = post.ProductLink,
                ProductImageUrl = await _utility.uploadImage(post.ProductImageUrl, FilePath),
            };
            return await _productRepository.AddProductAsync(product);
        }
        public async Task<bool> DeleteProduct(Guid Id)
        {
            return await _productRepository.DeleteProductAsync(Id);
        }
    }
}
    