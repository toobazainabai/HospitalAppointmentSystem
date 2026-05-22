using System;
using System.Windows.Forms;
using Hospital.Core.Models;
using Hospital.Core.Utilities;

namespace Hospital.WindowsApp.Forms
{
    public partial class DoctorForm : Form
    {
        public Doctor CurrentDoctor { get; private set; }

        public DoctorForm(Doctor doctor = null)
        {
            InitializeComponent();
            
            cmbSpecialty.DataSource = Enum.GetValues(typeof(DoctorSpecialtyEnum));

            if (doctor != null)
            {
                CurrentDoctor = doctor;
                txtFirstName.Text = doctor.FirstName;
                txtLastName.Text = string.IsNullOrEmpty(doctor.LastName) ? "" : doctor.LastName;
                txtPhone.Text = string.IsNullOrEmpty(doctor.Phone) ? "" : doctor.Phone;
                txtEmail.Text = string.IsNullOrEmpty(doctor.Email) ? "" : doctor.Email;
                numExperience.Value = doctor.ExperienceYears;
                cmbSpecialty.SelectedItem = doctor.Specialty;
                this.Text = "Edit Doctor";
            }
            else
            {
                CurrentDoctor = new Doctor();
                this.Text = "Add Doctor";
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFirstName.Text))
            {
                MessageBox.Show("First Name is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            CurrentDoctor.FirstName = txtFirstName.Text;
            CurrentDoctor.LastName = txtLastName.Text;
            CurrentDoctor.Phone = txtPhone.Text;
            CurrentDoctor.Email = txtEmail.Text;
            CurrentDoctor.ExperienceYears = (int)numExperience.Value;
            CurrentDoctor.Specialty = (DoctorSpecialtyEnum)cmbSpecialty.SelectedItem;

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