using System.Collections.Generic;
using System.Threading.Tasks;

namespace MedicalWebApplicationHelpers.IHelpers
{
    public interface IReadWriteToJson
    {
        Task<List<T>> ReadJsonAsync<T>(string location);
        Task<bool> WriteJsonAsync<T>(string location, T content);
        bool UpdateJsonAsync<T>(string location, List<T> contents);
    }
}