using Dental.Common.Dtos;
using Dental.Common.Entities;
using Dental.Common.Interfaces;
using Dental.Common.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Dental.Core.UseCases.Patients
{
    public class PatientService : IPatientService
    {
        private readonly IPatientRepository _patientRepository;
        private readonly ITreatmentRepository _treatmentRepository;
        private readonly IAppointmentRepository _appointmentRespository;

        public PatientService(
            IPatientRepository patientRepository,
            ITreatmentRepository treatmentRepository,
            IAppointmentRepository appointmentRepository)
        {
            _patientRepository = patientRepository;
            _treatmentRepository = treatmentRepository;
            _appointmentRespository = appointmentRepository;
        }

        public async Task<List<PatientItemDto>> GetAllPatients(int pageNumber = 1, int pageSize = 10, string searchStr = "")
        {
            return await _patientRepository.GetAllAsync(pageNumber, pageSize, searchStr);
        }

        public async Task<PatientDto> GetPatientDetails(long patientId)
        {
            return await _patientRepository.GetPatientById(patientId);
        }

        public async Task<long> PersistPatientDetailsAsync(PatientDto patientDto)
        {
            long patientId = 0;

            if (patientDto.Patients != null)
                patientId = await _patientRepository.CreatePatient(patientDto.Patients);

            if (patientDto.Treatments != null)
            {
                patientDto.Treatments.PatientId = patientId;
                await _treatmentRepository.CreateTreatment(patientDto.Treatments);
            }

            return patientId;
        }

        public Task PersistPatientDetailsAsync(Patient patient)
        {
            throw new NotImplementedException();
        }
    }
}
