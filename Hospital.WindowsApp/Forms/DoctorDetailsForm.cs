using System;
using System.Windows.Forms;
using Hospital.Core.Models;
using Hospital.Core.Utilities;

namespace Hospital.WindowsApp.Forms
{
    public partial class DoctorDetailsForm : Form
    {
        public DoctorDetailsForm(Doctor doctor)
        {
            InitializeComponent();
            PopulateForm(doctor);
        }

        private void PopulateForm(Doctor doctor)
        {
            if (doctor == null) return;

            // Initialize Specialty ComboBox
            if (cmbSpecialty.Items.Count == 0)
            {
                cmbSpecialty.DataSource = Enum.GetValues(typeof(DoctorSpecialtyEnum));
            }

            this.Text = $"Doctor Details - {doctor.FirstName} {doctor.LastName}";

            txtDoctorId.Text = doctor.Id ?? "";
            txtFirstName.Text = doctor.FirstName ?? "";
            txtLastName.Text = doctor.LastName ?? "";
            txtPhone.Text = doctor.Phone ?? "";
            txtEmail.Text = doctor.Email ?? "";
            numExperience.Value = doctor.ExperienceYears;
            cmbSpecialty.SelectedItem = doctor.Specialty;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
