using System;

namespace MedicalWebApplicationDomain.Models
{
    public class Product
    {
        public Guid Id { get; set; }
        public string ProductImageUrl { get; set; }
        public string ProductDescription { get; set; }
        public string ProductName { get; set; }
        public string ProductLink { get; set; }
    }
}
