using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace MedicalWebApplicationHelpers.IHelpers
{
    public interface IUtility
    {
        string ComputeSha256Hash(string rawData);
        Task<string> uploadImage(IFormFile imagefile, string path);
    }
}