using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using Dental.Common.Dtos;
using Dental.Common.Entities;
using Dental.Common.Repositories;
using Infrastructure.Persistence.Relational.Connection;
using Infrastructure.Persistence.Relational.Connection.Configuration;
using PagedList;

namespace Infrastructure.Persistence.Relational.Repositories
{
    public class PatientRepository : BaseRepository<long, Patient>, IPatientRepository
    {
        public PatientRepository(IConnectionFactory connectionFactory) 
            : base(ConnectionSettingsConfiguration.Dental, connectionFactory)
        {

        }

        public async Task<long> CreatePatient(Patient patient)
        {
            patient.IsActive = true;
            return await InsertAsync(patient);
        }

        public async Task<PatientDto> GetPatientById(long patientId)
        {
            try
            {
                using (var connection = ConnectionFactory.GetDbConnection(ConnectionSettings.Connection))
                {
                    var query = await connection.QuerySingleOrDefaultAsync<dynamic>(
                        $@"SELECT 
                            patient.FirstName,
                            patient.LastName,
                            patient.Gender,
                            patient.Phone,
                            patient.DateBirth,
                            patient.HealthNotes,
                            treatment.Description,
                            treatment.Diagnosis
                        FROM 
                            dbo.Patient patient
                        INNER JOIN 
                            dbo.Treatment treatment
                        ON patient.PatientId = treatment.PatientId
                        WHERE
                            patient.PatientId = @patientIdParam",
                        new
                        {
                            patientIdParam = patientId                           
                        });

                    var x = query;

                    var patientDto = new PatientDto
                    {
                        Patients = new Patient
                        {
                            FirstName = query.FirstName,
                            LastName = query.LastName,
                            Gender = query.Gender,
                            HealthNotes = query.HealthNotes,
                            Phone = query.Phone,
                            DateBirth = query.DateBirth
                        },
                        Treatments = new Treatment
                        {
                            Description = query.Description,
                            Diagnosis = query.Diagnosis
                        }
                    };

                    return patientDto;
                }

            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public async Task<List<PatientItemDto>> GetAllAsync(int pageNumber = 1, int pageSize = 10, string searchStr = "")
        {
            try
            {
                StringBuilder builder = new StringBuilder($@"SELECT DISTINCT
                            patient.PatientId as PatientId,
                            patient.FirstName as FirstName, 
                            patient.LastName as LastName,
                            patient.Phone as Phone,
                            appointment.AppointmentStartTime as AppointmentTime,
                            appointment.AppointmentDate as AppointmentDate,
                            appointment.Reason as Reason
                        FROM
                            dbo.Patient patient
                        LEFT JOIN
                            dbo.Appointment appointment
                        ON 
                            patient.PatientId = appointment.PatientId
                       ");

                using (var connection = ConnectionFactory.GetDbConnection(ConnectionSettings.Connection))
                {
                    if (!string.IsNullOrEmpty(searchStr))
                    {
                        builder.Append(" WHERE patient.FirstName LIKE '@FirstName%'");
                    }

                    var query = await connection.QueryAsync<PatientItemDto>(
                                    builder.ToString(),
                                new
                                {
                                    Active = true,
                                    LastName = searchStr,
                                    FirstName = searchStr
                                });

                    var x = query.ToPagedList(pageNumber, pageSize).ToList();

                    return query.ToPagedList(pageNumber, pageSize).ToList();
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
