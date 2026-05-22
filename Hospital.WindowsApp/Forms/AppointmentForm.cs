using System;
using System.Windows.Forms;
using Hospital.Core.Models;
using Hospital.Core.Utilities;
using Hospital.Core.Contracts;
using System.Linq;

namespace Hospital.WindowsApp.Forms
{
    public partial class AppointmentForm : Form
    {
        public Appointment CurrentAppointment { get; private set; }
        private readonly IAppointmentService _appointmentService;

        public AppointmentForm(Appointment appointment = null, IAppointmentService appointmentService = null)
        {
            InitializeComponent();

            _appointmentService = appointmentService;
            cmbStatus.DataSource = Enum.GetValues(typeof(AppointmentStatusEnum));

            if (appointment != null)
            {
                CurrentAppointment = appointment;
                txtPatientId.Text = appointment.PatientId;
                txtDoctorId.Text = appointment.DoctorId;
                dtpDate.Value = appointment.AppointmentDateTime;
                cmbStatus.SelectedItem = appointment.Status;
                txtNotes.Text = appointment.Notes;
                this.Text = "Edit Appointment";
                // Show existing ID for edit
                if (!string.IsNullOrEmpty(appointment.Id))
                {
                    DisplayAppointmentId(appointment.Id);
                }
            }
            else
            {
                CurrentAppointment = new Appointment();
                this.Text = "Add Appointment";
                dtpDate.Value = DateTime.Now;
                // Generate and display new ID for add
                if (_appointmentService != null)
                {
                    string newId = _appointmentService.GetNextAppointmentId();
                    CurrentAppointment.Id = newId;
                    DisplayAppointmentId(newId);
                }
            }
        }

        private void DisplayAppointmentId(string id)
        {
            // If there's a label or text box to display the ID, update it here
            // For now, we'll just ensure it's set
            if (string.IsNullOrEmpty(CurrentAppointment.Id))
            {
                CurrentAppointment.Id = id;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPatientId.Text) || string.IsNullOrWhiteSpace(txtDoctorId.Text))
            {
                MessageBox.Show("Patient ID and Doctor ID are required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            CurrentAppointment.PatientId = txtPatientId.Text;
            CurrentAppointment.DoctorId = txtDoctorId.Text;
            CurrentAppointment.AppointmentDateTime = dtpDate.Value;
            CurrentAppointment.Status = (AppointmentStatusEnum)cmbStatus.SelectedItem;
            CurrentAppointment.Notes = txtNotes.Text;

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