using Hospital.WindowsApp.Forms;
using System.Configuration;
using Hospital.Core.Contracts;
using Hospital.Core.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Hospital.WindowsApp
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            try
            {
                // Setup Dependency Injection
                var services = new ServiceCollection();
                RegisterServices(services);
                var serviceProvider = services.BuildServiceProvider();

                var mainForm = serviceProvider.GetRequiredService<MainForm>();
                Application.Run(mainForm);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Application Error: {ex.Message}\n\n{ex.StackTrace}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private static void RegisterServices(ServiceCollection services)
        {
            // Get connection string from App.config
            string connectionString = ConfigurationManager.ConnectionStrings["HospitalDb"]?.ConnectionString
                ?? throw new InvalidOperationException("Connection string 'HospitalDb' not found in App.config");

            // Register Database Services
            services.AddSingleton<IPatientService>(new DbPatientService(connectionString));
            services.AddSingleton<IDoctorService>(new DbDoctorService(connectionString));
            services.AddSingleton<IAppointmentService>(new DbAppointmentService(connectionString));

            // Register Forms
            services.AddSingleton<MainForm>();
        }
    }
}
