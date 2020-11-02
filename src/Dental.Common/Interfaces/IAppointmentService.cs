using Dental.Common.Entities;
using Dental.Common.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Dental.Common.Interfaces
{
    public interface IAppointmentService
    {
        Task<long> PersistAppointment(Appointment appointment);
        Task<TimeSlots> GetAppointmentSlots();
    }
}
