using Dapper;
using Dental.Common.Entities;
using Dental.Common.Repositories;
using Infrastructure.Persistence.Relational.Connection;
using Infrastructure.Persistence.Relational.Connection.Configuration;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Dental.Common.Models;

namespace Infrastructure.Persistence.Relational.Repositories
{
    public class AppointmentRepository : BaseRepository<long, Appointment>, IAppointmentRepository
    {
        public AppointmentRepository(IConnectionFactory connectionFactory)
                    : base(ConnectionSettingsConfiguration.Dental, connectionFactory)
        {

        }

        public async Task<int> GetCurrentDayAppointmentCount(DateTime fromDate, DateTime toDate)
        {
            int recordCount = 0;

            try
            {
                using (var connection = ConnectionFactory.GetDbConnection(ConnectionSettings.Connection))
                {
                    recordCount = await connection.RecordCountAsync<int>(
                        $@"SELECT 
                               COUNT(*)
                           FROM 
                               dbo.Appointment
                           WHERE 
                            AppointmentDate BETWEEN @StartDate AND @EndDate
                            AND IsActive = @IsAppointmentValid",
                        new
                        {
                            StartDate = fromDate,
                            EndDate = toDate,
                            IsAppointmentValid = true
                        });
                }
            }
            catch (Exception ex)
            {

            }
            return recordCount;
        }

        public async Task<List<Appointment>> GetCurrentDayAppointmentRecords(DateTime fromDate, DateTime toDate)
        {
            var appointmentRecords = new List<Appointment>();

            try
            {
                using (var connection = ConnectionFactory.GetDbConnection(ConnectionSettings.Connection))
                {
                    var query = await connection.QueryAsync<Appointment>(
                        $@"SELECT 
                               *
                           FROM 
                               dbo.Appointment
                           WHERE 
                            AppointmentDate BETWEEN @StartDate AND @EndDate
                            AND IsActive = @IsAppointmentValid",
                        new
                        {
                            StartDate = fromDate,
                            EndDate = toDate,
                            IsAppointmentValid = true
                        });

                    appointmentRecords = query.ToList();
                }
            }
            catch (Exception ex)
            {

            }
            return appointmentRecords;
        }

        public async Task<long> SaveAppointment(Appointment appointment)
        {
            try
            {
                return await InsertAsync(appointment);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public async Task<bool> GetAppointmentForCurrentDay(Appointment appointment)
        {
            using (var connection = ConnectionFactory.GetDbConnection(ConnectionSettings.Connection))
            {
                var query = await connection.QueryAsync<Appointment>(
                    $@"SELECT 
                            *
                        FROM 
                            dbo.Appointment
                        WHERE
                                    AppointmentDate = @appointmentDate
                                    AND IsActive = @appointmentValid
			                        AND
                                    (CAST(AppointmentStartTime AS TIME) < cast(@appointmentEndTime as time) 
                                    and CAST(@appointmentStartTime AS TIME) < cast(AppointmentEndTime as time))
                                    ORDER BY AppointmentStartTime",
                    new
                    {
                        appointmentDate = appointment.AppointmentDate,
                        appointmentValid = true,
                        appointmentStartTime = appointment.AppointmentStartTime,
                        appointmentEndTime = appointment.AppointmentEndTime
                    });

                return query.Any();
            }
        }

        public async Task<List<Appointment>> GetAppointmentCountCurrentDay()
        {
            using (var connection = ConnectionFactory.GetDbConnection(ConnectionSettings.Connection))
            {
                var query = await connection.QueryAsync<Appointment>(
                    $@"SELECT 
                            *
                        FROM 
                            dbo.Appointment
                        WHERE
                                    AppointmentDate = @appointmentDate
                                    AND IsActive = @appointmentValid",
                    new
                    {
                        appointmentDate = DateTime.Now.ToShortDateString(),
                        appointmentValid = true
                    });

                return query.OrderBy(x => x.AppointmentStartTime).ToList();
            }
        }

        public async Task<List<TimeBlock>> GetAppointmentsCurrentDay()
        {
            using (var connection = ConnectionFactory.GetDbConnection(ConnectionSettings.Connection))
            {
                var query = await connection.QueryAsync<TimeBlock>(
                    $@"SELECT 
                            CAST(AppointmentStartTime AS DATETIME) as StartTime,
                            CAST(AppointmentEndTime AS DATETIME) as EndTime
                        FROM 
                            dbo.Appointment
                        WHERE
                            AppointmentDate = @appointmentDate
                            AND IsActive = @appointmentValid",
                    new
                    {
                        appointmentDate = DateTime.Now.ToShortDateString(),
                        appointmentValid = true
                    });

                return query.OrderBy(x => x.StartTime).ToList();
            }
        }
    }
}
