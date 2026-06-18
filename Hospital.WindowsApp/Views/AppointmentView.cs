using System;
using System.Windows.Forms;
using Hospital.Core.Models;
using Hospital.Core.Utilities;
using Hospital.Core.Contracts;
using Hospital.WindowsApp.Forms;
using Hospital.WindowsApp.Helpers;
using System.Linq;
using System.ComponentModel;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Hospital.WindowsApp.Views
{
    public partial class AppointmentView : UserControl
    {
        private readonly IAppointmentService _appointmentService;
        private BindingList<Appointment> _appointments;
        private LoadingManager _loadingManager;
        private SortOrder _lastSortOrder = SortOrder.None;
        private int _lastSortColumnIndex = -1;

        public AppointmentView(IAppointmentService appointmentService)
        {
            InitializeComponent();
            dgvAppointments.AutoGenerateColumns = false;
            _appointmentService = appointmentService;
            _loadingManager = new LoadingManager(this);

            // Enable column sorting
            dgvAppointments.ColumnHeaderMouseClick += DgvAppointments_ColumnHeaderMouseClick;

            LoadAppointmentsAsync();

            btnAdd.Click += btnAdd_Click;
            btnEdit.Click += btnEdit_Click;
            btnView.Click += btnView_Click;
            btnDelete.Click += btnDelete_Click;
            btnRefresh.Click += btnRefresh_Click;

            txtSearch.TextChanged += FilterAppointments;
            
            cmbStatusFilter.SelectedIndexChanged += FilterAppointments;

            cmbStatusFilter.SelectedIndex = 0; // "All"
        }

        private async void LoadAppointmentsAsync()
        {
            _loadingManager.ExecuteAsync(async () =>
            {
                var appointments = await _appointmentService.GetAllAsync();
                _appointments = new BindingList<Appointment>(appointments.ToList());
                dgvAppointments.DataSource = _appointments;
            }, "Loading appointments...");
        }

        private void LoadAppointments()
        {
            LoadAppointmentsAsync();
        }

        private void FilterAppointments(object sender, EventArgs e)
        {
            var query = _appointments?.AsQueryable() ?? _appointmentService.GetAll().AsQueryable();

            if (!string.IsNullOrWhiteSpace(txtSearch.Text))
            {
                var search = txtSearch.Text.ToLower();
                query = query.Where(a => a.Id.ToLower().Contains(search) ||
                                         a.PatientId.ToLower().Contains(search) ||
                                         a.DoctorId.ToLower().Contains(search));
            }

            

            if (cmbStatusFilter.SelectedIndex > 0)
            {
                if (Enum.TryParse(cmbStatusFilter.SelectedItem.ToString(), out AppointmentStatusEnum status))
                {
                    query = query.Where(a => a.Status == status);
                }
            }

            _appointments = new BindingList<Appointment>(query.ToList());
            dgvAppointments.DataSource = _appointments;

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (var form = new AppointmentForm(null, _appointmentService))
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    _loadingManager.ExecuteAsync(async () =>
                    {
                        await _appointmentService.AddAsync(form.CurrentAppointment);
                        MessageBox.Show("Appointment added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadAppointmentsAsync();
                    }, "Adding appointment...");
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvAppointments.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an appointment to edit.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var selectedAppointment = (Appointment)dgvAppointments.SelectedRows[0].DataBoundItem;

            using (var form = new AppointmentForm(selectedAppointment, _appointmentService))
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    _loadingManager.ExecuteAsync(async () =>
                    {
                        await _appointmentService.UpdateAsync(form.CurrentAppointment);
                        MessageBox.Show("Appointment updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadAppointmentsAsync();
                    }, "Updating appointment...");
                }
            }
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            if (dgvAppointments.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an appointment to view.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var selectedAppointment = (Appointment)dgvAppointments.SelectedRows[0].DataBoundItem;

            using (var form = new AppointmentDetailsForm(selectedAppointment))
            {
                form.ShowDialog();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvAppointments.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an appointment to delete.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var selectedAppointment = (Appointment)dgvAppointments.SelectedRows[0].DataBoundItem;

            var result = MessageBox.Show($"Are you sure you want to delete appointment ID '{selectedAppointment.Id}'?",
                                         "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                _loadingManager.ExecuteAsync(async () =>
                {
                    await _appointmentService.DeleteAsync(selectedAppointment.Id);
                    MessageBox.Show("Appointment deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadAppointmentsAsync();
                }, "Deleting appointment...");
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtSearch.Text = string.Empty;
            
            cmbStatusFilter.SelectedIndex = 0;
            LoadAppointmentsAsync();
        }

        private void DgvAppointments_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var column = dgvAppointments.Columns[e.ColumnIndex];
            var dataSource = dgvAppointments.DataSource as BindingList<Appointment>;

            if (dataSource == null || string.IsNullOrEmpty(column.DataPropertyName))
                return;

            var propertyName = column.DataPropertyName;
            var propertyInfo = typeof(Appointment).GetProperty(propertyName);

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

                _appointments = new BindingList<Appointment>(sortedList);
                dgvAppointments.DataSource = _appointments;
            }
        }

        private void dtpDateFilter_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}