using System;
using System.Windows.Forms;
using Hospital.Core.Models;
using Hospital.Core.Utilities;
using Hospital.Core.Contracts;
using Hospital.WindowsApp.Forms;
using System.Linq;

namespace Hospital.WindowsApp.Views
{
    public partial class PatientView : UserControl
    {
        private IPatientService _patientService;
        private IDoctorService _doctorService;
        private IAppointmentService _appointmentService;
        private string _selectedPatientId = string.Empty;
        private List<Patient> _allPatients = new List<Patient>();

        public PatientView()
        {
            InitializeComponent();
            dgvPatients.AutoGenerateColumns = false;
        }

        public void LoadData(IPatientService patientService, IDoctorService doctorService = null, IAppointmentService appointmentService = null)
        {
            _patientService = patientService;
            _doctorService = doctorService;
            _appointmentService = appointmentService;
            RefreshGrid();
        }

        private void RefreshGrid()
        {
            if (_patientService == null) return;
            _allPatients = _patientService.GetAll();
            dgvPatients.DataSource = null;
            dgvPatients.DataSource = _allPatients;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchText = txtSearch.Text.Trim();
            if (string.IsNullOrEmpty(searchText))
            {
                MessageBox.Show("Please enter search text.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var searchResults = _allPatients.Where(p =>
                (p.Id ?? "").Contains(searchText, StringComparison.OrdinalIgnoreCase) ||
                (p.FirstName ?? "").Contains(searchText, StringComparison.OrdinalIgnoreCase) ||
                (p.LastName ?? "").Contains(searchText, StringComparison.OrdinalIgnoreCase) ||
                (p.Phone ?? "").Contains(searchText, StringComparison.OrdinalIgnoreCase) ||
                (p.Email ?? "").Contains(searchText, StringComparison.OrdinalIgnoreCase) ||
                (p.City ?? "").Contains(searchText, StringComparison.OrdinalIgnoreCase) ||
                (p.BloodGroup ?? "").Contains(searchText, StringComparison.OrdinalIgnoreCase) ||
                p.Gender.ToString().Contains(searchText, StringComparison.OrdinalIgnoreCase) ||
                (p.AddressLine1 ?? "").Contains(searchText, StringComparison.OrdinalIgnoreCase) ||
                (p.EmergencyName ?? "").Contains(searchText, StringComparison.OrdinalIgnoreCase) ||
                (p.EmergencyPhone ?? "").Contains(searchText, StringComparison.OrdinalIgnoreCase)
            ).ToList();

            dgvPatients.DataSource = null;
            dgvPatients.DataSource = searchResults;

            if (searchResults.Count == 0)
            {
                MessageBox.Show("No patients found matching your search.", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnClearSearch_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();
            RefreshGrid();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (var form = new AddPatientForm())
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    _patientService.Add(form.Patient);
                    MessageBox.Show("Patient added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RefreshGrid();
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(_selectedPatientId))
            {
                MessageBox.Show("Please select a patient to edit.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var patient = _patientService.GetById(_selectedPatientId);
            if (patient != null)
            {
                using (var form = new AddPatientForm(patient))
                {
                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        _patientService.Update(form.Patient);
                        MessageBox.Show("Patient updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        RefreshGrid();
                    }
                }
            }
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(_selectedPatientId))
            {
                MessageBox.Show("Please select a patient to view.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var patient = _patientService.GetById(_selectedPatientId);
            if (patient != null)
            {
                PatientDetailsForm detailsForm = new PatientDetailsForm(patient);
                detailsForm.ShowDialog();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(_selectedPatientId))
            {
                MessageBox.Show("Please select a patient to delete.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("Are you sure you want to delete this patient?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                _patientService.Delete(_selectedPatientId);
                RefreshGrid();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshGrid();
        }

        private void dgvPatients_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvPatients.CurrentRow != null && dgvPatients.CurrentRow.DataBoundItem is Patient selectedPatient)
            {
                _selectedPatientId = selectedPatient.Id;
            }
        }
    }
}
