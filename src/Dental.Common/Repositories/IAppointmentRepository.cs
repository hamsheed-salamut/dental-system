using Dental.Common.Entities;
using Dental.Common.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Dental.Common.Repositories
{
    public interface IAppointmentRepository
    {
        Task<int> GetCurrentDayAppointmentCount(DateTime fromDate, DateTime toDate);
        Task<long> SaveAppointment(Appointment appointment);
        Task<List<Appointment>> GetCurrentDayAppointmentRecords(DateTime fromDate, DateTime toDate);
        Task<bool> GetAppointmentForCurrentDay(Appointment appointment);
        Task<List<Appointment>> GetAppointmentCountCurrentDay();
        Task<List<TimeBlock>> GetAppointmentsCurrentDay();
    }
}
