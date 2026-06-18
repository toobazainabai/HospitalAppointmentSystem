using Hospital.WindowsApp.Forms;
using System.Configuration;
using Hospital.Core.Contracts;
using Hospital.Core.Services;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Windows.Forms;

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
            ApplicationConfiguration.Initialize();

            try
            {
                // 1. Pehle hi step mein saari services register karein
                var services = new ServiceCollection();
                RegisterServices(services);
                var serviceProvider = services.BuildServiceProvider();

                // 2. Main Form ka instance lein
                var mainForm = serviceProvider.GetRequiredService<MainForm>();

                // Login bypass kar ke direct admin username assign kar dein
                mainForm.LoggedInUser = "admin";

                // 3. Application ko direct chalayein
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