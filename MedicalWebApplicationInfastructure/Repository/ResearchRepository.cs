using MedicalWebApplicationDomain.Models;
using MedicalWebApplicationHelpers.IHelpers;
using MedicalWebApplicationInfastructure.IRepository;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MedicalWebApplicationInfastructure.Repository
{
    public class ResearchRepository : IResearchRepository
    {
        private readonly string ResearchStatisticsFile = "Researchs.json";
        private readonly IReadWriteToJson _readWriteToJson;
        public ResearchRepository(IReadWriteToJson readWriteToJson)
        {
            _readWriteToJson = readWriteToJson;
        }
        public async Task<List<ResearchStatistics>> GetAllStatisticsAsync()
        {
            return await _readWriteToJson.ReadJsonAsync<ResearchStatistics>(ResearchStatisticsFile);
        }
    }
}
