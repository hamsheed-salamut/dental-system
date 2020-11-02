using Dental.Common.Dtos;
using Dental.Common.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Dental.Common.Interfaces
{
    public interface IPatientService
    {
        Task<long> PersistPatientDetailsAsync(PatientDto patientDto);
        Task<PatientDto> GetPatientDetails(long patientId);
        Task<List<PatientItemDto>> GetAllPatients(int pageNumber = 1, int pageSize = 10, string searchStr = "");
    }
}
