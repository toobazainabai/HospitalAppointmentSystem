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
            tsAppointments.ImageScalingSize = new Size(20, 20);
            tsAppointments.Items.AddRange(new ToolStripItem[] { btnAdd, btnEdit, btnView, btnDelete, btnRefresh });
            tsAppointments.Location = new Point(0, 0);
            tsAppointments.Name = "tsAppointments";
            tsAppointments.Size = new Size(908, 27);
            tsAppointments.TabIndex = 0;
            tsAppointments.Text = "toolStrip1";
            // 
            // btnAdd
            // 
            btnAdd.Image = Properties.Resources.ico_Add;
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(61, 24);
            btnAdd.Text = "Add";
            // 
            // btnEdit
            // 
            btnEdit.Image = Properties.Resources.ico_edit;
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(59, 24);
            btnEdit.Text = "Edit";
            // 
            // btnView
            // 
            btnView.Image = Properties.Resources.ico_View;
            btnView.Name = "btnView";
            btnView.Size = new Size(65, 24);
            btnView.Text = "View";
            // 
            // btnDelete
            // 
            btnDelete.Image = Properties.Resources.ico_Delete;
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(77, 24);
            btnDelete.Text = "Delete";
            // 
            // btnRefresh
            // 
            btnRefresh.Image = Properties.Resources.ico_Refresh;
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(82, 24);
            btnRefresh.Text = "Refresh";
            // 
            // pnlSearch
            // 
            pnlSearch.Controls.Add(tblSearch);
            pnlSearch.Dock = DockStyle.Fill;
            pnlSearch.Location = new Point(3, 71);
            pnlSearch.Margin = new Padding(3, 4, 3, 4);
            pnlSearch.Name = "pnlSearch";
            pnlSearch.Size = new Size(908, 72);
            pnlSearch.TabIndex = 1;
            // 
            // tblSearch
            // 
            tblSearch.ColumnCount = 2;
            tblSearch.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33F));
            tblSearch.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33F));
            tblSearch.Controls.Add(lblSearch, 0, 0);
            tblSearch.Controls.Add(txtSearch, 0, 1);
            tblSearch.Controls.Add(lblStatusFilter, 1, 0);
            tblSearch.Controls.Add(cmbStatusFilter, 1, 1);
            tblSearch.Dock = DockStyle.Fill;
            tblSearch.Location = new Point(0, 0);
            tblSearch.Margin = new Padding(3, 4, 3, 4);
            tblSearch.Name = "tblSearch";
            tblSearch.RowCount = 2;
            tblSearch.RowStyles.Add(new RowStyle(SizeType.Percent, 40F));
            tblSearch.RowStyles.Add(new RowStyle(SizeType.Percent, 60F));
            tblSearch.Size = new Size(908, 72);
            tblSearch.TabIndex = 0;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Dock = DockStyle.Bottom;
            lblSearch.Location = new Point(3, 8);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(448, 20);
            lblSearch.TabIndex = 0;
            lblSearch.Text = "Search (ID/Name)";
            // 
            // txtSearch
            // 
            txtSearch.Dock = DockStyle.Fill;
            txtSearch.Location = new Point(3, 32);
            txtSearch.Margin = new Padding(3, 4, 3, 4);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(448, 27);
            txtSearch.TabIndex = 1;
            // 
            // lblStatusFilter
            // 
            lblStatusFilter.AutoSize = true;
            lblStatusFilter.Dock = DockStyle.Bottom;
            lblStatusFilter.Location = new Point(457, 8);
            lblStatusFilter.Name = "lblStatusFilter";
            lblStatusFilter.Size = new Size(448, 20);
            lblStatusFilter.TabIndex = 4;
            lblStatusFilter.Text = "Status";
            // 
            // cmbStatusFilter
            // 
            cmbStatusFilter.Dock = DockStyle.Fill;
            cmbStatusFilter.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStatusFilter.FormattingEnabled = true;
            cmbStatusFilter.Items.AddRange(new object[] { "All", "Scheduled", "Completed", "Cancelled", "NoShow" });
            cmbStatusFilter.Location = new Point(457, 32);
            cmbStatusFilter.Margin = new Padding(3, 4, 3, 4);
            cmbStatusFilter.Name = "cmbStatusFilter";
            cmbStatusFilter.Size = new Size(448, 28);
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
            dgvAppointments.Location = new Point(3, 151);
            dgvAppointments.Margin = new Padding(3, 4, 3, 4);
            dgvAppointments.Name = "dgvAppointments";
            dgvAppointments.ReadOnly = true;
            dgvAppointments.RowHeadersWidth = 51;
            dgvAppointments.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAppointments.Size = new Size(908, 645);
            dgvAppointments.TabIndex = 2;
            // 
            // colId
            // 
            colId.DataPropertyName = "Id";
            colId.HeaderText = "ID";
            colId.MinimumWidth = 6;
            colId.Name = "colId";
            colId.ReadOnly = true;
            // 
            // colPatientId
            // 
            colPatientId.DataPropertyName = "PatientId";
            colPatientId.HeaderText = "Patient ID";
            colPatientId.MinimumWidth = 6;
            colPatientId.Name = "colPatientId";
            colPatientId.ReadOnly = true;
            // 
            // colDoctorId
            // 
            colDoctorId.DataPropertyName = "DoctorId";
            colDoctorId.HeaderText = "Doctor ID";
            colDoctorId.MinimumWidth = 6;
            colDoctorId.Name = "colDoctorId";
            colDoctorId.ReadOnly = true;
            // 
            // colDate
            // 
            colDate.DataPropertyName = "AppointmentDateTime";
            colDate.HeaderText = "Date";
            colDate.MinimumWidth = 6;
            colDate.Name = "colDate";
            colDate.ReadOnly = true;
            // 
            // colStatus
            // 
            colStatus.DataPropertyName = "Status";
            colStatus.HeaderText = "Status";
            colStatus.MinimumWidth = 6;
            colStatus.Name = "colStatus";
            colStatus.ReadOnly = true;
            // 
            // colNotes
            // 
            colNotes.DataPropertyName = "Notes";
            colNotes.HeaderText = "Notes";
            colNotes.MinimumWidth = 6;
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
            tblMain.Margin = new Padding(3, 4, 3, 4);
            tblMain.Name = "tblMain";
            tblMain.RowCount = 3;
            tblMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 67F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 80F));
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblMain.Size = new Size(914, 800);
            tblMain.TabIndex = 5;
            // 
            // pnlTop
            // 
            pnlTop.Controls.Add(tsAppointments);
            pnlTop.Dock = DockStyle.Fill;
            pnlTop.Location = new Point(3, 4);
            pnlTop.Margin = new Padding(3, 4, 3, 4);
            pnlTop.Name = "pnlTop";
            pnlTop.Size = new Size(908, 59);
            pnlTop.TabIndex = 4;
            // 
            // AppointmentView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tblMain);
            Margin = new Padding(3, 4, 3, 4);
            Name = "AppointmentView";
            Size = new Size(914, 800);
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