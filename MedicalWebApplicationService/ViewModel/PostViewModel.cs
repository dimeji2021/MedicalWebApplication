using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace MedicalWebApplicationService.ViewModel
{
    public class PostViewModel
    {
        public IFormFile ProductImageUrl { get; set; }
        public string ProductDescription { get; set; }
        public string ProductName { get; set; }
        public string ProductLink { get; set; }
    }
}
