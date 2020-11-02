using System;
using System.Collections.Generic;
using System.Text;
using Dental.Common.Entities;
using System.Threading.Tasks;
using Dental.Common.Dtos;

namespace Dental.Common.Repositories
{
    public interface IPatientRepository
    {
        Task<long> CreatePatient(Patient patient);
        Task<List<PatientItemDto>> GetAllAsync(int pageNumber = 1, int pageSize = 10, string searchStr = "");
        Task<PatientDto> GetPatientById(long patientId);
    }
}
