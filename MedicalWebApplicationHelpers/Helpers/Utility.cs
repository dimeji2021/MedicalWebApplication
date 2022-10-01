using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using MedicalWebApplicationHelpers.IHelpers;
using Microsoft.AspNetCore.Http;

namespace MedicalWebApplicationHelpers.Helpers
{
    public class Utility : IUtility
    {
        public string ComputeSha256Hash(string rawData)
        {
            // Create a SHA256   
            using (SHA256 sha256Hash = SHA256.Create())
            {
                // ComputeHash - returns byte array  
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(rawData));

                // Convert byte array to a string   
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }
        public  async Task<string> uploadImage(IFormFile imagefile, string path)
        {
            string fileName =$"/images/{Guid.NewGuid().ToString()}-{imagefile.FileName}";
            string filePath = Path.Combine(path, fileName);
            await imagefile.CopyToAsync(new FileStream(filePath, FileMode.Create));
            return fileName;
        }
    }
}
