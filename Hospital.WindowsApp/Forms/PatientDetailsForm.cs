using System;
using System.Windows.Forms;
using Hospital.Core.Models;
using Hospital.Core.Utilities;

namespace Hospital.WindowsApp.Forms
{
    public partial class PatientDetailsForm : Form
    {
        public PatientDetailsForm(Patient patient)
        {
            InitializeComponent();
            PopulateForm(patient);
        }

        private void PopulateForm(Patient patient)
        {
            if (patient == null) return;

            // Initialize Gender ComboBox
            if (cmbGender.Items.Count == 0)
            {
                cmbGender.DataSource = Enum.GetValues(typeof(GenderEnum));
            }

            // Initialize BloodGroup ComboBox
            if (cmbBloodGroup.Items.Count == 0)
            {
                cmbBloodGroup.Items.AddRange(new string[] { "A+", "A-", "B+", "B-", "AB+", "AB-", "O+", "O-", "Unknown" });
            }

            this.Text = $"Patient Details - {patient.FirstName} {patient.LastName}";

            txtId.Text = patient.Id;
            txtFirstName.Text = patient.FirstName ?? "";
            txtLastName.Text = patient.LastName ?? "";
            txtPhone.Text = patient.Phone ?? "";
            dtpDOB.Value = patient.DateOfBirth != DateTime.MinValue ? patient.DateOfBirth : DateTime.Now;
            cmbGender.SelectedItem = patient.Gender;
            cmbBloodGroup.SelectedItem = patient.BloodGroup ?? "Unknown";
            txtEmail.Text = patient.Email ?? "";
            txtAddressLine1.Text = patient.AddressLine1 ?? "";
            txtCity.Text = patient.City ?? "";
            txtEmergencyName.Text = patient.EmergencyName ?? "";
            txtEmergencyPhone.Text = patient.EmergencyPhone ?? "";
            rtbMedicalHistory.Text = patient.MedicalHistory ?? "";

            // Make all fields read-only since this is view-only
            txtId.ReadOnly = true;
            txtFirstName.ReadOnly = true;
            txtLastName.ReadOnly = true;
            txtPhone.ReadOnly = true;
            dtpDOB.Enabled = false;
            cmbGender.Enabled = false;
            cmbBloodGroup.Enabled = false;
            txtEmail.ReadOnly = true;
            txtAddressLine1.ReadOnly = true;
            txtCity.ReadOnly = true;
            txtEmergencyName.ReadOnly = true;
            txtEmergencyPhone.ReadOnly = true;
            rtbMedicalHistory.ReadOnly = true;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
