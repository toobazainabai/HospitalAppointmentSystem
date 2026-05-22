using System;
using System.Windows.Forms;
using Hospital.Core.Models;
using Hospital.Core.Utilities;

namespace Hospital.WindowsApp.Forms
{
    public partial class AddPatientForm : Form
    {
        public Patient Patient { get; private set; }
        private bool _isEditMode = false;

        public AddPatientForm(Patient patientToEdit = null)
        {
            InitializeComponent();
            cmbGender.DataSource = Enum.GetValues(typeof(GenderEnum));
            cmbBloodGroup.Items.AddRange(new string[] { "A+", "A-", "B+", "B-", "AB+", "AB-", "O+", "O-", "Unknown" });
            cmbBloodGroup.SelectedIndex = 8;

            if (patientToEdit != null)
            {
                _isEditMode = true;
                this.Text = "Edit Patient";
                PopulateForm(patientToEdit);
                Patient = patientToEdit;
            }
            else
            {
                this.Text = "Add Patient";
            }
        }

        private void PopulateForm(Patient patient)
        {
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
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFirstName.Text))
            {
                MessageBox.Show("First Name is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (_isEditMode)
            {
                // Update existing patient
                Patient.FirstName = txtFirstName.Text;
                Patient.LastName = txtLastName.Text;
                Patient.Phone = txtPhone.Text;
                Patient.DateOfBirth = dtpDOB.Value;
                Patient.Gender = cmbGender.SelectedItem != null ? (GenderEnum)cmbGender.SelectedItem : GenderEnum.Unknown;
                Patient.BloodGroup = cmbBloodGroup.SelectedItem?.ToString() ?? "Unknown";
                Patient.Email = txtEmail.Text;
                Patient.AddressLine1 = txtAddressLine1.Text;
                Patient.City = txtCity.Text;
                Patient.EmergencyName = txtEmergencyName.Text;
                Patient.EmergencyPhone = txtEmergencyPhone.Text;
                Patient.MedicalHistory = rtbMedicalHistory.Text;
            }
            else
            {
                // Create new patient
                Patient = new Patient
                {
                    FirstName = txtFirstName.Text,
                    LastName = txtLastName.Text,
                    Phone = txtPhone.Text,
                    DateOfBirth = dtpDOB.Value,
                    Gender = cmbGender.SelectedItem != null ? (GenderEnum)cmbGender.SelectedItem : GenderEnum.Unknown,
                    BloodGroup = cmbBloodGroup.SelectedItem?.ToString() ?? "Unknown",
                    Email = txtEmail.Text,
                    AddressLine1 = txtAddressLine1.Text,
                    City = txtCity.Text,
                    EmergencyName = txtEmergencyName.Text,
                    EmergencyPhone = txtEmergencyPhone.Text,
                    MedicalHistory = rtbMedicalHistory.Text
                };
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
