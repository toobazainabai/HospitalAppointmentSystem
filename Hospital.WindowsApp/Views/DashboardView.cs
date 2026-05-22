using System;
using System.Windows.Forms;
using Hospital.Core.Contracts;
using System.Collections.Generic;
using System.Linq;

namespace Hospital.WindowsApp.Views
{
    public partial class DashboardView : UserControl
    {
        public DashboardView()
        {
            InitializeComponent();
            InitializeDataGrid();
        }

        private void InitializeDataGrid()
        {
            dgvRecentAppointments.AutoGenerateColumns = true;
        }

        public void LoadData(IPatientService patientService, IDoctorService doctorService, IAppointmentService appointmentService)
        {
            try
            {
                // Load counts
                lblTotalPatientsValue.Text = (patientService.GetAll()?.Count ?? 0).ToString();
                lblTotalDoctorsValue.Text = (doctorService.GetAll()?.Count ?? 0).ToString();
                lblTotalAppointmentsValue.Text = (appointmentService.GetAll()?.Count ?? 0).ToString();

                // Load recent appointments (last 5) with proper formatting
                var appointments = appointmentService.GetRecent(5);
                var patientDict = patientService.GetAll().ToDictionary(p => p.Id);
                var doctorDict = doctorService.GetAll().ToDictionary(d => d.Id);

                var appointmentData = appointments?.Select(a => new
                {
                    PatientName = patientDict.ContainsKey(a.PatientId) 
                        ? patientDict[a.PatientId].FirstName + " " + patientDict[a.PatientId].LastName 
                        : "Unknown",
                    DoctorName = doctorDict.ContainsKey(a.DoctorId) 
                        ? doctorDict[a.DoctorId].FirstName + " " + doctorDict[a.DoctorId].LastName 
                        : "Unknown",
                    a.AppointmentDateTime,
                    a.Status,
                    a.Notes
                }).ToList();

                dgvRecentAppointments.DataSource = appointmentData;

                // Style the grid
                StyleDataGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading dashboard: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void StyleDataGrid()
        {
            if (dgvRecentAppointments.Rows.Count == 0)
                return;

            // Rename column headers
            foreach (DataGridViewColumn col in dgvRecentAppointments.Columns)
            {
                if (col.Name == "PatientName")
                    col.HeaderText = "Patient Name";
                else if (col.Name == "DoctorName")
                    col.HeaderText = "Doctor Name";
                else if (col.Name == "AppointmentDateTime")
                    col.HeaderText = "Date & Time";
                else if (col.Name == "Status")
                    col.HeaderText = "Status";
                else if (col.Name == "Notes")
                    col.HeaderText = "Notes";

                col.SortMode = DataGridViewColumnSortMode.NotSortable;
            }

            // Set column widths
            dgvRecentAppointments.AutoResizeColumns();

            // Style header
            dgvRecentAppointments.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.DarkSlateBlue;
            dgvRecentAppointments.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            dgvRecentAppointments.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10, System.Drawing.FontStyle.Bold);
            dgvRecentAppointments.ColumnHeadersHeight = 30;

            // Style rows
            dgvRecentAppointments.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9);
            dgvRecentAppointments.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            dgvRecentAppointments.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            dgvRecentAppointments.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.WhiteSmoke;

            // Hide ID columns if they exist
            foreach (DataGridViewColumn col in dgvRecentAppointments.Columns)
            {
                if (col.Name.Contains("Id"))
                    col.Visible = false;
            }
        }
    }
}

