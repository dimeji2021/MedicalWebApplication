using MedicalWebApplicationDomain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MedicalWebApplicationDomain.Models
{
    public class User
    {
        public string UserId { get; set; } = Guid.NewGuid().ToString();
        public string FullName { get; set; }
        [Required]
        public string Email { get; set; }
        public Gend Gender { get; set; }
        public decimal PhoneNumber { get; set; }
        public string Password { get; set; }
        public bool IsActive { get; set; } = true;
        public Role Role { get; set; } = Role.Users;
        public DateTime DateCreated { get; set; } = DateTime.Now;
    }
}
