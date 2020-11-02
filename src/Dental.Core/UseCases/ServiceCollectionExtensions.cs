using Dental.Common.Interfaces;
using Dental.Core.UseCases.Appointments;
using Dental.Core.UseCases.DashboardView;
using Dental.Core.UseCases.Patients;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dental.Core.UseCases
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddApplicationService(this IServiceCollection serviceCollection)
        {
            // Application services
            serviceCollection.AddTransient<IPatientService, PatientService>();
            serviceCollection.AddTransient<IAppointmentService, AppointmentService>();
            serviceCollection.AddTransient<IDashboardService, DashboardService>();

            return serviceCollection;
        }
    }
}
