using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MedicalWebApplicationDomain.Models
{
    public class Post
    {
        public Guid Id { get; set; }
        [Required]
        public IFormFile ProductImageUrl { get; set; }
        [Required]
        public string ProductDescription { get; set; }
        [Required]
        public string ProductName { get; set; }
        [Required]
        public string ProductLink { get; set; }
    }
}
