using System;
using System.Windows.Forms;
using Hospital.Core.Contracts;
using System.Collections.Generic;
using System.Linq;
using OxyPlot;
using OxyPlot.Series;
using OxyPlot.WindowsForms;

namespace Hospital.WindowsApp.Views
{
    public partial class DashboardView : UserControl
    {
        private PlotView chartAppointmentStatus;
        private PlotView chartPatientsPerDoctor;

        public DashboardView()
        {
            InitializeComponent();
            InitializeDataGrid();
            InitializeCharts();
        }

        private void InitializeDataGrid()
        {
            dgvRecentAppointments.AutoGenerateColumns = true;
        }

        private void InitializeCharts()
        {
            // Initialize Appointment Status Chart (Pie Chart) - Left side
            chartAppointmentStatus = new PlotView();
            chartAppointmentStatus.Name = "chartAppointmentStatus";
            chartAppointmentStatus.Size = new System.Drawing.Size(450, 300);
            chartAppointmentStatus.Location = new System.Drawing.Point(5, 480);
            chartAppointmentStatus.Model = new PlotModel { Title = "Appointment Status Distribution" };
            chartAppointmentStatus.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            this.Controls.Add(chartAppointmentStatus);

            // Initialize Patients per Doctor Chart (Bar Chart) - Right side
            chartPatientsPerDoctor = new PlotView();
            chartPatientsPerDoctor.Name = "chartPatientsPerDoctor";
            chartPatientsPerDoctor.Size = new System.Drawing.Size(750, 300);
            chartPatientsPerDoctor.Location = new System.Drawing.Point(460, 480);
            chartPatientsPerDoctor.Model = new PlotModel { Title = "Appointments per Doctor" };
            chartPatientsPerDoctor.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            // Disable mouse interactions to prevent bars from shrinking on hover
            chartPatientsPerDoctor.PanCursor = System.Windows.Forms.Cursors.Default;
            this.Controls.Add(chartPatientsPerDoctor);
        }

        public async Task LoadDataAsync(IPatientService patientService, IDoctorService doctorService, IAppointmentService appointmentService)
        {
            try
            {
                // Load counts asynchronously
                System.Diagnostics.Debug.WriteLine($"=== TEST === Before DB Call - Thread: {System.Threading.Thread.CurrentThread.ManagedThreadId}");

                var patientCount = (await patientService.GetAllAsync())?.Count ?? 0;
                var doctorCount = (await doctorService.GetAllAsync())?.Count ?? 0;
                var appointmentCount = (await appointmentService.GetAllAsync())?.Count ?? 0;

                System.Diagnostics.Debug.WriteLine($"=== TEST === After DB Call - Thread: {System.Threading.Thread.CurrentThread.ManagedThreadId}");

                lblTotalPatientsValue.Text = patientCount.ToString();
                lblTotalDoctorsValue.Text = doctorCount.ToString();
                lblTotalAppointmentsValue.Text = appointmentCount.ToString();

                // Load recent appointments (last 5) with proper formatting
                var appointments = await appointmentService.GetRecentAsync(5);
                var patients = await patientService.GetAllAsync();
                var doctors = await doctorService.GetAllAsync();

                var patientDict = patients?.ToDictionary(p => p.Id) ?? new Dictionary<string, Hospital.Core.Models.Patient>();
                var doctorDict = doctors?.ToDictionary(d => d.Id) ?? new Dictionary<string, Hospital.Core.Models.Doctor>();

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

                // Load Charts
                await LoadChartsAsync(appointmentService, doctorService);

                // Style the grid
                StyleDataGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading dashboard: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Backward compatibility - sync wrapper (optional, can be removed later)
        public void LoadData(IPatientService patientService, IDoctorService doctorService, IAppointmentService appointmentService)
        {
            // Call async version synchronously for backward compatibility
            LoadDataAsync(patientService, doctorService, appointmentService).GetAwaiter().GetResult();
        }

        private async Task LoadChartsAsync(IAppointmentService appointmentService, IDoctorService doctorService)
        {
            try
            {
                // Chart 1: Appointment Status Distribution (Pie Chart)
                var allAppointments = await appointmentService.GetAllAsync() ?? new List<Hospital.Core.Models.Appointment>();
                var statusGroups = allAppointments.GroupBy(a => a.Status).ToDictionary(g => g.Key, g => g.Count());

                var pieModel = new PlotModel { Title = "Appointment Status Distribution" };
                var pieSeries = new PieSeries();

                // Define soft colors for different statuses
                var statusColors = new Dictionary<string, OxyColor>
                {
                    { "Scheduled", OxyColor.FromArgb(255, 173, 216, 230) },      // Light Blue
                    { "Completed", OxyColor.FromArgb(255, 144, 238, 144) },      // Light Green
                    { "Cancelled", OxyColor.FromArgb(255, 255, 192, 203) }       // Light Pink
                };

                foreach (var status in statusGroups)
                {
                    var slice = new PieSlice(status.Key.ToString(), status.Value);
                    if (statusColors.ContainsKey(status.Key.ToString()))
                    {
                        slice.Fill = statusColors[status.Key.ToString()];
                    }
                    pieSeries.Slices.Add(slice);
                }

                pieModel.Series.Add(pieSeries);
                chartAppointmentStatus.Model = pieModel;

                // Chart 2: Appointments per Doctor (Column/Bar Chart using BarSeries)
                var doctors = await doctorService.GetAllAsync() ?? new List<Hospital.Core.Models.Doctor>();
                var appointmentsPerDoctor = doctors
                    .Select(d => new
                    {
                        Name = $"{d.FirstName} {d.LastName}",
                        Count = allAppointments.Count(a => a.DoctorId == d.Id)
                    })
                    .OrderByDescending(x => x.Count)
                    .Take(10)
                    .ToList();

                var barModel = new PlotModel { Title = "Appointments per Doctor" };
                barModel.IsLegendVisible = false;
                barModel.Axes.Add(new OxyPlot.Axes.CategoryAxis 
                { 
                    Position = OxyPlot.Axes.AxisPosition.Left,
                    ItemsSource = appointmentsPerDoctor.Select(x => x.Name).ToList()
                });
                barModel.Axes.Add(new OxyPlot.Axes.LinearAxis 
                { 
                    Position = OxyPlot.Axes.AxisPosition.Bottom,
                    Title = "Number of Appointments",
                    Minimum = 0,
                    Maximum = 10
                });

                var barSeries = new OxyPlot.Series.BarSeries();
                barSeries.TrackerFormatString = "";
                barSeries.IsVisible = true;
                foreach (var doctorAppointment in appointmentsPerDoctor)
                {
                    barSeries.Items.Add(new OxyPlot.Series.BarItem { Value = doctorAppointment.Count });
                }

                barModel.Series.Add(barSeries);
                chartPatientsPerDoctor.Model = barModel;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading charts: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
