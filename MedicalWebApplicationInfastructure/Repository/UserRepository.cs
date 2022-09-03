using MedicalWebApplicationDomain.Models;
using MedicalWebApplicationHelpers.IHelpers;
using MedicalWebApplicationInfastructure.IRepository;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MedicalWebApplicationInfastructure.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly string userFile = "Users.json";
        private readonly IReadWriteToJson _readWriteToJson;
        public UserRepository(IReadWriteToJson readWriteToJson)
        {
            _readWriteToJson = readWriteToJson;
        }

        public async Task<List<User>> GetAllUsersAsync()
        {
            return await _readWriteToJson.ReadJsonAsync<User>(userFile);
        }
        public async Task<bool> AddUserToDataBaseAsync(User model)
        {
            return await _readWriteToJson.WriteJsonAsync<User>(userFile, model);
        }
    }
}
