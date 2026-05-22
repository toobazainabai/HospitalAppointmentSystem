using System;
using System.Windows.Forms;
using Hospital.Core.Models;
using Hospital.Core.Utilities;
using Hospital.Core.Contracts;
using Hospital.WindowsApp.Forms;
using System.Linq;

namespace Hospital.WindowsApp.Views
{
    public partial class DoctorView : UserControl
    {
        private IDoctorService _doctorService;
        private string _selectedDoctorId = string.Empty;
        private List<Doctor> _allDoctors = new List<Doctor>();

        public DoctorView()
        {
            InitializeComponent();
            dgvDoctors.AutoGenerateColumns = false;
        }

        public void LoadData(IDoctorService doctorService)
        {
            _doctorService = doctorService;
            RefreshGrid();
        }

        private void RefreshGrid()
        {
            if (_doctorService == null) return;
            _allDoctors = _doctorService.GetAll();
            dgvDoctors.DataSource = null;
            dgvDoctors.DataSource = _allDoctors;
            _selectedDoctorId = string.Empty;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchText = txtSearch.Text.Trim();
            if (string.IsNullOrEmpty(searchText))
            {
                MessageBox.Show("Please enter search text.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var searchResults = _allDoctors.Where(d =>
                (d.Id ?? "").Contains(searchText, StringComparison.OrdinalIgnoreCase) ||
                (d.FirstName ?? "").Contains(searchText, StringComparison.OrdinalIgnoreCase) ||
                (d.LastName ?? "").Contains(searchText, StringComparison.OrdinalIgnoreCase) ||
                (d.Phone ?? "").Contains(searchText, StringComparison.OrdinalIgnoreCase) ||
                (d.Email ?? "").Contains(searchText, StringComparison.OrdinalIgnoreCase) ||
                d.Specialty.ToString().Contains(searchText, StringComparison.OrdinalIgnoreCase) ||
                d.ExperienceYears.ToString().Contains(searchText, StringComparison.OrdinalIgnoreCase)
            ).ToList();

            dgvDoctors.DataSource = null;
            dgvDoctors.DataSource = searchResults;

            if (searchResults.Count == 0)
            {
                MessageBox.Show("No doctors found matching your search.", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
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
                    _doctorService.Add(form.CurrentDoctor);
                    MessageBox.Show("Doctor added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RefreshGrid();
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

            var doctor = _doctorService.GetById(_selectedDoctorId);
            if (doctor != null)
            {
                using (var form = new DoctorForm(doctor))
                {
                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        _doctorService.Update(form.CurrentDoctor);
                        MessageBox.Show("Doctor updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        RefreshGrid();
                    }
                }
            }
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(_selectedDoctorId))
            {
                MessageBox.Show("Please select a doctor to view.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var doctor = _doctorService.GetById(_selectedDoctorId);
            if (doctor != null)
            {
                using (var form = new DoctorDetailsForm(doctor))
                {
                    form.ShowDialog();
                }
            }
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
                _doctorService.Delete(_selectedDoctorId);
                MessageBox.Show("Doctor deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                RefreshGrid();
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

        private void dgvDoctors_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvDoctors.CurrentRow != null && dgvDoctors.CurrentRow.DataBoundItem is Doctor selectedDoctor)
            {
                _selectedDoctorId = selectedDoctor.Id;
            }
        }

        private void tsDoctor_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
        }

        private void dgvDoctors_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
    }
}