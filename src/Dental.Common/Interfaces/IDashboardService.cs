using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Dental.Common.Interfaces
{
    public interface IDashboardService
    {
        Task<int> GetTotalAppointments(DateTime startDate, DateTime endDate);
        Task<List<string>> GetAvailableSlots(DateTime startDate, DateTime endDate);
        Task<string> GetConsultationSlot(DateTime startDate, DateTime endDate);
    }
}
