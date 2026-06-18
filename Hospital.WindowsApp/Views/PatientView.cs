using System;
using System.Windows.Forms;
using System.ComponentModel;
using Hospital.Core.Models;
using Hospital.Core.Utilities;
using Hospital.Core.Contracts;
using Hospital.WindowsApp.Forms;
using Hospital.WindowsApp.Helpers;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Hospital.WindowsApp.Views
{
    public partial class PatientView : UserControl
    {
        private IPatientService _patientService;
        private IDoctorService _doctorService;
        private IAppointmentService _appointmentService;
        private string _selectedPatientId = string.Empty;
        private BindingList<Patient> _allPatients = new BindingList<Patient>();
        private LoadingManager _loadingManager;
        private SortOrder _lastSortOrder = SortOrder.None;
        private int _lastSortColumnIndex = -1;

        public PatientView()
        {
            InitializeComponent();
            dgvPatients.AutoGenerateColumns = false;
            _loadingManager = new LoadingManager(this);

            // Enable column sorting
            dgvPatients.ColumnHeaderMouseClick += DgvPatients_ColumnHeaderMouseClick;
        }

        public void LoadData(IPatientService patientService, IDoctorService doctorService = null, IAppointmentService appointmentService = null)
        {
            _patientService = patientService;
            _doctorService = doctorService;
            _appointmentService = appointmentService;
            RefreshGridAsync();
        }

        private async void RefreshGridAsync()
        {
            if (_patientService == null) return;

            _loadingManager.ExecuteAsync(async () =>
            {
                var patients = await _patientService.GetAllAsync();
                _allPatients = new BindingList<Patient>(patients);
                dgvPatients.DataSource = null;
                dgvPatients.DataSource = _allPatients;
            }, "Loading patients...");
        }

        private void RefreshGrid()
        {
            RefreshGridAsync();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchText = txtSearch.Text.Trim();
            if (string.IsNullOrEmpty(searchText))
            {
                MessageBox.Show("Please enter search text.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _loadingManager.ExecuteAsync(async () =>
            {
                // 1. Data database se lekar aayein
                var searchResults = await _patientService.SearchAsync(searchText);

                // 2. Isko BindingList mein convert karein takay UI grid crash na ho aur refresh ho
                _allPatients = new BindingList<Patient>(searchResults);

                dgvPatients.DataSource = null;
                dgvPatients.DataSource = _allPatients; // BindingList assign karein

                if (searchResults.Count == 0)
                {
                    MessageBox.Show("No patients found matching your search.", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }, "Searching patients...");
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
                    _loadingManager.ExecuteAsync(async () =>
                    {
                        await _patientService.AddAsync(form.Patient);
                        MessageBox.Show("Patient added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        RefreshGridAsync();
                    }, "Adding patient...");
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

            _loadingManager.ExecuteAsync(async () =>
            {
                var patient = await _patientService.GetByIdAsync(_selectedPatientId);
                if (patient != null)
                {
                    using (var form = new AddPatientForm(patient))
                    {
                        _loadingManager.HideLoading();
                        if (form.ShowDialog() == DialogResult.OK)
                        {
                            _loadingManager.ExecuteAsync(async () =>
                            {
                                await _patientService.UpdateAsync(form.Patient);
                                MessageBox.Show("Patient updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                RefreshGridAsync();
                            }, "Updating patient...");
                        }
                    }
                }
            }, "Loading patient...");
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(_selectedPatientId))
            {
                MessageBox.Show("Please select a patient to view.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _loadingManager.ExecuteAsync(async () =>
            {
                var patient = await _patientService.GetByIdAsync(_selectedPatientId);
                if (patient != null)
                {
                    _loadingManager.HideLoading();
                    PatientDetailsForm detailsForm = new PatientDetailsForm(patient);
                    detailsForm.ShowDialog();
                }
            }, "Loading patient details...");
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
                _loadingManager.ExecuteAsync(async () =>
                {
                    await _patientService.DeleteAsync(_selectedPatientId);
                    MessageBox.Show("Patient deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RefreshGridAsync();
                }, "Deleting patient...");
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

        private void DgvPatients_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var column = dgvPatients.Columns[e.ColumnIndex];
            var dataSource = dgvPatients.DataSource as BindingList<Patient>;

            if (dataSource == null || string.IsNullOrEmpty(column.DataPropertyName))
                return;

            // Sort the data
            var propertyName = column.DataPropertyName;
            var propertyInfo = typeof(Patient).GetProperty(propertyName);

            if (propertyInfo != null)
            {
                var sortedList = dataSource.ToList();

                if (_lastSortColumnIndex != e.ColumnIndex)
                {
                    sortedList = sortedList.OrderBy(x => propertyInfo.GetValue(x)).ToList();
                    _lastSortOrder = SortOrder.Ascending;
                    _lastSortColumnIndex = e.ColumnIndex;
                }
                else
                {
                    if (_lastSortOrder == SortOrder.Ascending)
                    {
                        sortedList = sortedList.OrderByDescending(x => propertyInfo.GetValue(x)).ToList();
                        _lastSortOrder = SortOrder.Descending;
                    }
                    else
                    {
                        sortedList = sortedList.OrderBy(x => propertyInfo.GetValue(x)).ToList();
                        _lastSortOrder = SortOrder.Ascending;
                    }
                }

                _allPatients = new BindingList<Patient>(sortedList);
                dgvPatients.DataSource = _allPatients;
            }
        }
    }
}