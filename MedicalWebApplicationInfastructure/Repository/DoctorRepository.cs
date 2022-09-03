using MedicalWebApplicationDomain.Models;
using MedicalWebApplicationHelpers.IHelpers;
using MedicalWebApplicationInfastructure.IRepository;
using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace MedicalWebApplicationInfastructure.Repository
{
    public class DoctorRepository : IDoctorRepository
    {
        private readonly IReadWriteToJson _readWriteToJson;
        private readonly string doctorsFile = "Doctors.json";
        public DoctorRepository(IReadWriteToJson readWriteToJson)
        {
            _readWriteToJson = readWriteToJson;
        }
        public async Task<List<Doctor>> GetAllDoctorsAsync()
        {
            return await _readWriteToJson.ReadJsonAsync<Doctor>(doctorsFile);
        }
    }
}
