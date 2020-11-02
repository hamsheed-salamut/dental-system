using Dental.Common.Repositories;
using Infrastructure.Persistence.Relational.Connection;
using Infrastructure.Persistence.Relational.Repositories;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Persistence
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddPersistenceService(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddTransient<IConnectionFactory, ConnectionFactory>();

            // SQL Repo
            serviceCollection.AddTransient<IAppointmentRepository, AppointmentRepository>();
            serviceCollection.AddTransient<IPatientRepository, PatientRepository>();
            serviceCollection.AddTransient<ITreatmentRepository, TreatmentRepository>();

            return serviceCollection;
        }
    }
}
