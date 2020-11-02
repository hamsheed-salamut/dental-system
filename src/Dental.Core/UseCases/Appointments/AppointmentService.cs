using Dental.Common.Entities;
using Dental.Common.Interfaces;
using Dental.Common.Models;
using Dental.Common.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dental.Core.UseCases.Appointments
{
    public class AppointmentService : IAppointmentService
    {
        private readonly IAppointmentRepository _appointmentRepository;

        public AppointmentService(IAppointmentRepository appointmentRepository)
        {
            _appointmentRepository = appointmentRepository;
        }

        public async Task<long> PersistAppointment(Appointment appointment)
        {
            long appointmentId = 0;

            var isSlotUnavailable = await _appointmentRepository.GetAppointmentForCurrentDay(appointment);

            if (!isSlotUnavailable)
            {
                appointmentId = await _appointmentRepository.SaveAppointment(appointment);
            }

            return appointmentId;
        }

        public async Task<TimeSlots> GetAppointmentSlots()
        {
            var appointments = await _appointmentRepository.GetAppointmentsCurrentDay();
            var freeSlots = new List<TimeBlock>();
            var orderedAppointments = appointments.OrderBy(a => a.StartTime).ToArray();

            for (int i = 0; i < orderedAppointments.Length - 1; i++)
            {
                freeSlots.Add(new TimeBlock() { StartTime = orderedAppointments[i].EndTime, EndTime = orderedAppointments[i + 1].StartTime });
            }

            var firstAppointment = orderedAppointments.First();
            var lastAppointment = orderedAppointments.Last();

            if (firstAppointment.StartTime.Hour > 8)
                freeSlots.Add(new TimeBlock() { StartTime = firstAppointment.Today.AddHours(8), EndTime = firstAppointment.StartTime });

            if (lastAppointment.EndTime.Hour < 18)
                freeSlots.Add(new TimeBlock() { StartTime = lastAppointment.EndTime, EndTime = lastAppointment.Today.AddHours(18) });

            var appointmentSlots = new TimeSlots();

            foreach (var item in appointments.OrderBy(x => x.StartTime))
            {
                appointmentSlots.UsedSlots.Add($"{item.StartTime.ToShortTimeString()} - {item.EndTime.ToShortTimeString()}");
            }

            foreach (var item in freeSlots.OrderBy(x => x.StartTime))
            {
                appointmentSlots.AvailableSlots.Add($"{item.StartTime.ToShortTimeString()} - {item.EndTime.ToShortTimeString()}");
            }

            return appointmentSlots;
        }
    }
}
