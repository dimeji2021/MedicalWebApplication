using MedicalWebApplicationDomain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MedicalWebApplicationInfastructure.IRepository
{
    public interface IUserRepository
    {
        Task<bool> AddUserToDataBaseAsync(User model);
        Task<List<User>> GetAllUsersAsync();
    }
}