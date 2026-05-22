using System;
using System.Windows.Forms;
using Hospital.Core.Models;
using Hospital.Core.Utilities;
using Hospital.Core.Contracts;
using Hospital.WindowsApp.Forms;
using System.Linq;
using System.ComponentModel;
using System.Collections.Generic;

namespace Hospital.WindowsApp.Views
{
    public partial class AppointmentView : UserControl
    {
        private readonly IAppointmentService _appointmentService;
        private BindingList<Appointment> _appointments;

        public AppointmentView(IAppointmentService appointmentService)
        {
            InitializeComponent();
            dgvAppointments.AutoGenerateColumns = false;
            _appointmentService = appointmentService;
            
            LoadAppointments();

            btnAdd.Click += btnAdd_Click;
            btnEdit.Click += btnEdit_Click;
            btnView.Click += btnView_Click;
            btnDelete.Click += btnDelete_Click;
            btnRefresh.Click += btnRefresh_Click;

            txtSearch.TextChanged += FilterAppointments;
            dtpDateFilter.ValueChanged += FilterAppointments;
            cmbStatusFilter.SelectedIndexChanged += FilterAppointments;
            
            cmbStatusFilter.SelectedIndex = 0; // "All"
        }

        private void LoadAppointments()
        {
            var appointments = _appointmentService.GetAll();
            _appointments = new BindingList<Appointment>(appointments.ToList());
            dgvAppointments.DataSource = _appointments;
          
        }
       
        private void FilterAppointments(object sender, EventArgs e)
        {
            var query = _appointmentService.GetAll().AsQueryable();

            if (!string.IsNullOrWhiteSpace(txtSearch.Text))
            {
                var search = txtSearch.Text.ToLower();
                query = query.Where(a => a.Id.ToLower().Contains(search) || 
                                         a.PatientId.ToLower().Contains(search) || 
                                         a.DoctorId.ToLower().Contains(search));
            }

            if (dtpDateFilter.Checked)
            {
                query = query.Where(a => a.AppointmentDateTime.Date == dtpDateFilter.Value.Date);
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
                    _appointmentService.Add(form.CurrentAppointment);
                    LoadAppointments();
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
                    _appointmentService.Update(form.CurrentAppointment);
                    LoadAppointments();
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
                _appointmentService.Delete(selectedAppointment.Id);
                LoadAppointments();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtSearch.Text = string.Empty;
            dtpDateFilter.Checked = false;
            cmbStatusFilter.SelectedIndex = 0;
            LoadAppointments();
        }

        
    }
}