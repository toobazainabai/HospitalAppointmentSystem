using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;
using Hospital.Core.Contracts;
using Hospital.Core.Services;
using Hospital.WindowsApp.Views;

namespace Hospital.WindowsApp.Forms
{
    public partial class MainForm : Form
    {
        private readonly IPatientService _patientService;
        private readonly IDoctorService _doctorService;
        private readonly IAppointmentService _appointmentService;

        private DashboardView _dashboardView;
        private PatientView _patientView;
        private DoctorView _doctorView;
        private AppointmentView _appointmentView;

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string LoggedInUser { get; set; } = "Admin";

        public MainForm(IPatientService patientService, IDoctorService doctorService, IAppointmentService appointmentService)
        {
            InitializeComponent();
            this.Text = "Hospital Management System";

            _patientService = patientService;
            _doctorService = doctorService;
            _appointmentService = appointmentService;

            btnDashboard.Click += BtnDashboard_Click;
            btnPatients.Click += BtnPatients_Click;
            btnDoctors.Click += BtnDoctors_Click;
            btnAppointments.Click += BtnAppointments_Click;

            // Initialize status bar
            UpdateStatusBar();

            // Load dashboard in Form_Load event, not in constructor
            this.Load += MainForm_Load;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadDashboardAsync();
        }

        private void BtnDashboard_Click(object sender, EventArgs e)
        {
            LoadDashboardAsync();
        }

        private void BtnPatients_Click(object sender, EventArgs e)
        {
            LoadPatientView();
        }

        private void BtnDoctors_Click(object sender, EventArgs e)
        {
            LoadDoctorView();
        }

        private void BtnAppointments_Click(object sender, EventArgs e)
        {
            LoadAppointmentView();
        }

        private void LoadDashboard()
        {
            if (_dashboardView == null)
            {
                _dashboardView = new DashboardView();
                _dashboardView.Dock = DockStyle.Fill;
            }

            pnlContent.Controls.Clear();
            pnlContent.Controls.Add(_dashboardView);
            _dashboardView.LoadData(_patientService, _doctorService, _appointmentService);
            UpdateRecordCountsAsync();
        }

        private async void LoadDashboardAsync()
        {
            if (_dashboardView == null)
            {
                _dashboardView = new DashboardView();
                _dashboardView.Dock = DockStyle.Fill;
            }

            pnlContent.Controls.Clear();
            pnlContent.Controls.Add(_dashboardView);
            await _dashboardView.LoadDataAsync(_patientService, _doctorService, _appointmentService);
            UpdateRecordCountsAsync();
        }

        private void LoadPatientView()
        {
            if (_patientView == null)
            {
                _patientView = new PatientView();
                _patientView.Dock = DockStyle.Fill;
            }

            pnlContent.Controls.Clear();
            pnlContent.Controls.Add(_patientView);
            _patientView.LoadData(_patientService);
            UpdateRecordCountsAsync();
        }

        private void LoadDoctorView()
        {
            if (_doctorView == null)
            {
                _doctorView = new DoctorView();
                _doctorView.Dock = DockStyle.Fill;
            }

            pnlContent.Controls.Clear();
            pnlContent.Controls.Add(_doctorView);
            _doctorView.LoadData(_doctorService);
            UpdateRecordCountsAsync();
        }

        private void LoadAppointmentView()
        {
            if (_appointmentView == null)
            {
                _appointmentView = new AppointmentView(_appointmentService);
                _appointmentView.Dock = DockStyle.Fill;
            }

            pnlContent.Controls.Clear();
            pnlContent.Controls.Add(_appointmentView);
            UpdateRecordCountsAsync();
        }

        private void UpdateStatusBar()
        {
            UpdateRecordCountsAsync();
        }

        private async void UpdateRecordCountsAsync()
        {
            try
            {
                var patients = await _patientService.GetAllAsync();
                var doctors = await _doctorService.GetAllAsync();
                var appointments = await _appointmentService.GetAllAsync();

                lblStatusRecords.Text = $"User: {LoggedInUser} | Patients: {patients.Count} | Doctors: {doctors.Count} | Appointments: {appointments.Count}";
            }
            catch (Exception ex)
            {
                lblStatusRecords.Text = "Error loading record counts";
            }
        }

        private void lblUser_Click(object sender, EventArgs e)
        {
            // Status bar showing record counts
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            // Status strip item clicked
        }

        private void statusStrip1_ItemClicked_1(object sender, ToolStripItemClickedEventArgs e)
        {
            // Status strip item clicked
        }
    }
}
