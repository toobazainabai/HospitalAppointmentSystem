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
    public partial class DoctorView : UserControl
    {
        private IDoctorService _doctorService;
        private string _selectedDoctorId = string.Empty;
        private BindingList<Doctor> _allDoctors = new BindingList<Doctor>();
        private LoadingManager _loadingManager;
        private SortOrder _lastSortOrder = SortOrder.None;
        private int _lastSortColumnIndex = -1;

        public DoctorView()
        {
            InitializeComponent();
            dgvDoctors.AutoGenerateColumns = false;
            _loadingManager = new LoadingManager(this);

            // Enable column sorting
            dgvDoctors.ColumnHeaderMouseClick += DgvDoctors_ColumnHeaderMouseClick;
        }

        public void LoadData(IDoctorService doctorService)
        {
            _doctorService = doctorService;
            RefreshGridAsync();
        }

        private async void RefreshGridAsync()
        {
            if (_doctorService == null) return;

            _loadingManager.ExecuteAsync(async () =>
            {
                var doctors = await _doctorService.GetAllAsync();
                _allDoctors = new BindingList<Doctor>(doctors);
                dgvDoctors.DataSource = null;
                dgvDoctors.DataSource = _allDoctors;
                _selectedDoctorId = string.Empty;
            }, "Loading doctors...");
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
                var searchResults = await _doctorService.SearchAsync(searchText);
                dgvDoctors.DataSource = null;
                dgvDoctors.DataSource = searchResults;

                if (searchResults.Count == 0)
                {
                    MessageBox.Show("No doctors found matching your search.", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }, "Searching doctors...");
        }

        private void btnClearSearch_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();
            RefreshGrid();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (var form = new DoctorForm())
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    _loadingManager.ExecuteAsync(async () =>
                    {
                        await _doctorService.AddAsync(form.CurrentDoctor);
                        MessageBox.Show("Doctor added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        RefreshGridAsync();
                    }, "Adding doctor...");
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(_selectedDoctorId))
            {
                MessageBox.Show("Please select a doctor to edit.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _loadingManager.ExecuteAsync(async () =>
            {
                var doctor = await _doctorService.GetByIdAsync(_selectedDoctorId);
                if (doctor != null)
                {
                    using (var form = new DoctorForm(doctor))
                    {
                        _loadingManager.HideLoading();
                        if (form.ShowDialog() == DialogResult.OK)
                        {
                            _loadingManager.ExecuteAsync(async () =>
                            {
                                await _doctorService.UpdateAsync(form.CurrentDoctor);
                                MessageBox.Show("Doctor updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                RefreshGridAsync();
                            }, "Updating doctor...");
                        }
                    }
                }
            }, "Loading doctor...");
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(_selectedDoctorId))
            {
                MessageBox.Show("Please select a doctor to view.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _loadingManager.ExecuteAsync(async () =>
            {
                var doctor = await _doctorService.GetByIdAsync(_selectedDoctorId);
                if (doctor != null)
                {
                    _loadingManager.HideLoading();
                    using (var form = new DoctorDetailsForm(doctor))
                    {
                        form.ShowDialog();
                    }
                }
            }, "Loading doctor details...");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(_selectedDoctorId))
            {
                MessageBox.Show("Please select a doctor to delete.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("Are you sure you want to delete this doctor?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                _loadingManager.ExecuteAsync(async () =>
                {
                    await _doctorService.DeleteAsync(_selectedDoctorId);
                    MessageBox.Show("Doctor deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RefreshGridAsync();
                }, "Deleting doctor...");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void ClearForm()
        {
            _selectedDoctorId = string.Empty;
        }

        private void dgvDoctors_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvDoctors.Rows[e.RowIndex].DataBoundItem is Doctor selectedDoctor)
            {
                _selectedDoctorId = selectedDoctor.Id;
            }
        }

        private void DgvDoctors_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var column = dgvDoctors.Columns[e.ColumnIndex];
            var dataSource = dgvDoctors.DataSource as BindingList<Doctor>;

            if (dataSource == null || string.IsNullOrEmpty(column.DataPropertyName))
                return;

            var propertyName = column.DataPropertyName;
            var propertyInfo = typeof(Doctor).GetProperty(propertyName);

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

                _allDoctors = new BindingList<Doctor>(sortedList);
                dgvDoctors.DataSource = _allDoctors;
            }
        }
    }
}