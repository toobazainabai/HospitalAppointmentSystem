namespace Hospital.WindowsApp.Views
{
    partial class AppointmentView
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            tsAppointments = new ToolStrip();
            btnAdd = new ToolStripButton();
            btnEdit = new ToolStripButton();
            btnView = new ToolStripButton();
            btnDelete = new ToolStripButton();
            btnRefresh = new ToolStripButton();
            pnlSearch = new Panel();
            tblSearch = new TableLayoutPanel();
            lblSearch = new Label();
            txtSearch = new TextBox();
            lblDate = new Label();
            dtpDateFilter = new DateTimePicker();
            lblStatusFilter = new Label();
            cmbStatusFilter = new ComboBox();
            dgvAppointments = new DataGridView();
            colId = new DataGridViewTextBoxColumn();
            colPatientId = new DataGridViewTextBoxColumn();
            colDoctorId = new DataGridViewTextBoxColumn();
            colDate = new DataGridViewTextBoxColumn();
            colStatus = new DataGridViewTextBoxColumn();
            colNotes = new DataGridViewTextBoxColumn();
            tblMain = new TableLayoutPanel();
            pnlTop = new Panel();
            tsAppointments.SuspendLayout();
            pnlSearch.SuspendLayout();
            tblSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAppointments).BeginInit();
            tblMain.SuspendLayout();
            pnlTop.SuspendLayout();
            SuspendLayout();
            // 
            // tsAppointments
            // 
            tsAppointments.Items.AddRange(new ToolStripItem[] { btnAdd, btnEdit, btnView, btnDelete, btnRefresh });
            tsAppointments.Location = new Point(0, 0);
            tsAppointments.Name = "tsAppointments";
            tsAppointments.Size = new Size(794, 25);
            tsAppointments.TabIndex = 0;
            tsAppointments.Text = "toolStrip1";
            // 
            // btnAdd
            // 
            btnAdd.Image = Properties.Resources.ico_Add;
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(49, 22);
            btnAdd.Text = "Add";
            // 
            // btnEdit
            // 
            btnEdit.Image = Properties.Resources.ico_edit;
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(47, 22);
            btnEdit.Text = "Edit";
            // 
            // btnView
            // 
            btnView.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnView.Image = Properties.Resources.ico_View;
            btnView.Name = "btnView";
            btnView.Size = new Size(36, 22);
            btnView.Text = "View";
            // 
            // btnDelete
            // 
            btnDelete.Image = Properties.Resources.ico_Delete;
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(60, 22);
            btnDelete.Text = "Delete";
            // 
            // btnRefresh
            // 
            btnRefresh.Image = Properties.Resources.ico_Refresh;
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(66, 22);
            btnRefresh.Text = "Refresh";
            // 
            // pnlSearch
            // 
            pnlSearch.Controls.Add(tblSearch);
            pnlSearch.Dock = DockStyle.Fill;
            pnlSearch.Location = new Point(3, 53);
            pnlSearch.Name = "pnlSearch";
            pnlSearch.Size = new Size(794, 54);
            pnlSearch.TabIndex = 1;
            // 
            // tblSearch
            // 
            tblSearch.ColumnCount = 3;
            tblSearch.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33F));
            tblSearch.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33F));
            tblSearch.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33F));
            tblSearch.Controls.Add(lblSearch, 0, 0);
            tblSearch.Controls.Add(txtSearch, 0, 1);
            tblSearch.Controls.Add(lblDate, 1, 0);
            tblSearch.Controls.Add(dtpDateFilter, 1, 1);
            tblSearch.Controls.Add(lblStatusFilter, 2, 0);
            tblSearch.Controls.Add(cmbStatusFilter, 2, 1);
            tblSearch.Dock = DockStyle.Fill;
            tblSearch.Location = new Point(0, 0);
            tblSearch.Name = "tblSearch";
            tblSearch.RowCount = 2;
            tblSearch.RowStyles.Add(new RowStyle(SizeType.Percent, 40F));
            tblSearch.RowStyles.Add(new RowStyle(SizeType.Percent, 60F));
            tblSearch.Size = new Size(794, 54);
            tblSearch.TabIndex = 0;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Dock = DockStyle.Bottom;
            lblSearch.Location = new Point(3, 6);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(258, 15);
            lblSearch.TabIndex = 0;
            lblSearch.Text = "Search (ID/Name)";
            // 
            // txtSearch
            // 
            txtSearch.Dock = DockStyle.Fill;
            txtSearch.Location = new Point(3, 24);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(258, 23);
            txtSearch.TabIndex = 1;
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Dock = DockStyle.Bottom;
            lblDate.Location = new Point(267, 6);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(258, 15);
            lblDate.TabIndex = 2;
            lblDate.Text = "Date";
            // 
            // dtpDateFilter
            // 
            dtpDateFilter.Checked = false;
            dtpDateFilter.Dock = DockStyle.Fill;
            dtpDateFilter.Format = DateTimePickerFormat.Short;
            dtpDateFilter.Location = new Point(267, 24);
            dtpDateFilter.Name = "dtpDateFilter";
            dtpDateFilter.ShowCheckBox = true;
            dtpDateFilter.Size = new Size(258, 23);
            dtpDateFilter.TabIndex = 3;
            // 
            // lblStatusFilter
            // 
            lblStatusFilter.AutoSize = true;
            lblStatusFilter.Dock = DockStyle.Bottom;
            lblStatusFilter.Location = new Point(531, 6);
            lblStatusFilter.Name = "lblStatusFilter";
            lblStatusFilter.Size = new Size(260, 15);
            lblStatusFilter.TabIndex = 4;
            lblStatusFilter.Text = "Status";
            // 
            // cmbStatusFilter
            // 
            cmbStatusFilter.Dock = DockStyle.Fill;
            cmbStatusFilter.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStatusFilter.FormattingEnabled = true;
            cmbStatusFilter.Items.AddRange(new object[] { "All", "Scheduled", "Completed", "Cancelled", "NoShow" });
            cmbStatusFilter.Location = new Point(531, 24);
            cmbStatusFilter.Name = "cmbStatusFilter";
            cmbStatusFilter.Size = new Size(260, 23);
            cmbStatusFilter.TabIndex = 5;
            // 
            // dgvAppointments
            // 
            dgvAppointments.AllowUserToAddRows = false;
            dgvAppointments.AllowUserToDeleteRows = false;
            dgvAppointments.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAppointments.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAppointments.Columns.AddRange(new DataGridViewColumn[] { colId, colPatientId, colDoctorId, colDate, colStatus, colNotes });
            dgvAppointments.Dock = DockStyle.Fill;
            dgvAppointments.Location = new Point(3, 113);
            dgvAppointments.Name = "dgvAppointments";
            dgvAppointments.ReadOnly = true;
            dgvAppointments.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAppointments.Size = new Size(794, 484);
            dgvAppointments.TabIndex = 2;
            // 
            // colId
            // 
            colId.DataPropertyName = "Id";
            colId.HeaderText = "ID";
            colId.Name = "colId";
            colId.ReadOnly = true;
            // 
            // colPatientId
            // 
            colPatientId.DataPropertyName = "PatientId";
            colPatientId.HeaderText = "Patient ID";
            colPatientId.Name = "colPatientId";
            colPatientId.ReadOnly = true;
            // 
            // colDoctorId
            // 
            colDoctorId.DataPropertyName = "DoctorId";
            colDoctorId.HeaderText = "Doctor ID";
            colDoctorId.Name = "colDoctorId";
            colDoctorId.ReadOnly = true;
            // 
            // colDate
            // 
            colDate.DataPropertyName = "AppointmentDateTime";
            colDate.HeaderText = "Date";
            colDate.Name = "colDate";
            colDate.ReadOnly = true;
            // 
            // colStatus
            // 
            colStatus.DataPropertyName = "Status";
            colStatus.HeaderText = "Status";
            colStatus.Name = "colStatus";
            colStatus.ReadOnly = true;
            // 
            // colNotes
            // 
            colNotes.DataPropertyName = "Notes";
            colNotes.HeaderText = "Notes";
            colNotes.Name = "colNotes";
            colNotes.ReadOnly = true;
            // 
            // tblMain
            // 
            tblMain.ColumnCount = 1;
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblMain.Controls.Add(pnlTop, 0, 0);
            tblMain.Controls.Add(pnlSearch, 0, 1);
            tblMain.Controls.Add(dgvAppointments, 0, 2);
            tblMain.Dock = DockStyle.Fill;
            tblMain.Location = new Point(0, 0);
            tblMain.Name = "tblMain";
            tblMain.RowCount = 3;
            tblMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblMain.Size = new Size(800, 600);
            tblMain.TabIndex = 5;
            // 
            // pnlTop
            // 
            pnlTop.Controls.Add(tsAppointments);
            pnlTop.Dock = DockStyle.Fill;
            pnlTop.Location = new Point(3, 3);
            pnlTop.Name = "pnlTop";
            pnlTop.Size = new Size(794, 44);
            pnlTop.TabIndex = 4;
            // 
            // AppointmentView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tblMain);
            Name = "AppointmentView";
            Size = new Size(800, 600);
            tsAppointments.ResumeLayout(false);
            tsAppointments.PerformLayout();
            pnlSearch.ResumeLayout(false);
            tblSearch.ResumeLayout(false);
            tblSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAppointments).EndInit();
            tblMain.ResumeLayout(false);
            pnlTop.ResumeLayout(false);
            pnlTop.PerformLayout();
            ResumeLayout(false);
        }

        private System.Windows.Forms.ToolStrip tsAppointments;
        private System.Windows.Forms.ToolStripButton btnAdd;
        private System.Windows.Forms.ToolStripButton btnEdit;
        private System.Windows.Forms.ToolStripButton btnView;
        private System.Windows.Forms.ToolStripButton btnDelete;
        private System.Windows.Forms.ToolStripButton btnRefresh;
        private System.Windows.Forms.Panel pnlSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.DateTimePicker dtpDateFilter;
        private System.Windows.Forms.Label lblStatusFilter;
        private System.Windows.Forms.ComboBox cmbStatusFilter;
        private System.Windows.Forms.DataGridView dgvAppointments;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPatientId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDoctorId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNotes;
        private System.Windows.Forms.TableLayoutPanel tblMain;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.TableLayoutPanel tblSearch;
    }
}