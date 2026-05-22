using System;
using System.Windows.Forms;
using Hospital.Core.Models;
using Hospital.Core.Utilities;

namespace Hospital.WindowsApp.Forms
{
    public partial class AppointmentDetailsForm : Form
    {
        public AppointmentDetailsForm(Appointment appointment)
        {
            InitializeComponent();
            PopulateForm(appointment);
        }

        private void PopulateForm(Appointment appointment)
        {
            if (appointment == null) return;

            // Initialize Status ComboBox
            if (cmbStatus.Items.Count == 0)
            {
                cmbStatus.DataSource = Enum.GetValues(typeof(AppointmentStatusEnum));
            }

            this.Text = $"Appointment Details - {appointment.Id}";

            txtAppointmentId.Text = appointment.Id ?? "";
            txtPatientId.Text = appointment.PatientId ?? "";
            txtDoctorId.Text = appointment.DoctorId ?? "";
            dtpDate.Value = appointment.AppointmentDateTime != DateTime.MinValue ? appointment.AppointmentDateTime : DateTime.Now;
            cmbStatus.SelectedItem = appointment.Status;
            txtNotes.Text = appointment.Notes ?? "";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
