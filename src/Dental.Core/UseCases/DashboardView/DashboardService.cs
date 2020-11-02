using Dental.Common.Interfaces;
using Dental.Common.Repositories;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Dental.Core.UseCases.DashboardView
{
    public class DashboardService : IDashboardService
    {
        private readonly IAppointmentRepository _appointmentRepository;

        public DashboardService(IAppointmentRepository appointmentRepository)
        {
            _appointmentRepository = appointmentRepository;
        }

        public async Task<List<string>> GetAvailableSlots(DateTime startDate, DateTime endDate)
        {
            var availableSlots = new List<string>();

            try
            {
                var appointments = await _appointmentRepository.GetCurrentDayAppointmentRecords(startDate, endDate);

            }
            catch (Exception ex)
            {

            }
            return null;
        }

        public Task<string> GetConsultationSlot(DateTime startDate, DateTime endDate)
        {
            throw new NotImplementedException();
        }

        public Task<int> GetTotalAppointments(DateTime startDate, DateTime endDate)
        {
            throw new NotImplementedException();
        }
    }
}
