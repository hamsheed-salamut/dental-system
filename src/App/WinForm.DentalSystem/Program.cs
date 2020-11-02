using Dental.Core.UseCases;
using Infrastructure.Persistence;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm.DentalSystem
{
    static class Program
    {
        public static IServiceProvider serviceProvider { get; set; }

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var host = Host.CreateDefaultBuilder()
                           .ConfigureAppConfiguration((context, builder) =>
                           {
                                // Add other configuration files...
                                builder.AddJsonFile("appsettings.json", optional: true);
                           })
                           .ConfigureServices((context, services) =>
                           {
                               ConfigureServices(context.Configuration, services);
                           })
                           .Build();

            var services = host.Services;
            var mainForm = services.GetRequiredService<PatientForm>();

            Application.Run(mainForm);
        }

        private static void ConfigureServices(IConfiguration configuration, IServiceCollection services)
        {
            var conf = configuration.GetSection("DentalSqlConnection");

            services.AddPersistenceService();
            services.AddApplicationService();

            services.AddTransient<Dashboard>();
            services.AddTransient<AppointmentForm>();
            services.AddTransient<PatientForm>();
            services.AddTransient<PatientListForm>();
        }
    }
}
