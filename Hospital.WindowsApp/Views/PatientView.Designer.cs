namespace Hospital.WindowsApp.Views
{
    partial class PatientView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PatientView));
            tableLayoutPanel1 = new TableLayoutPanel();
            tsPatient = new ToolStrip();
            btnAdd = new ToolStripButton();
            btnEdit = new ToolStripButton();
            btnView = new ToolStripButton();
            btnDelete = new ToolStripButton();
            btnRefresh = new ToolStripButton();
            pnlSearch = new Panel();
            lblSearch = new Label();
            txtSearch = new TextBox();
            btnSearch = new Button();
            btnClearSearch = new Button();
            dgvPatients = new DataGridView();
            colId = new DataGridViewTextBoxColumn();
            colFirstName = new DataGridViewTextBoxColumn();
            colLastName = new DataGridViewTextBoxColumn();
            colPhone = new DataGridViewTextBoxColumn();
            colEmail = new DataGridViewTextBoxColumn();
            colDateOfBirth = new DataGridViewTextBoxColumn();
            colGender = new DataGridViewTextBoxColumn();
            colBloodGroup = new DataGridViewTextBoxColumn();
            colAddressLine1 = new DataGridViewTextBoxColumn();
            colCity = new DataGridViewTextBoxColumn();
            colEmergencyName = new DataGridViewTextBoxColumn();
            colEmergencyPhone = new DataGridViewTextBoxColumn();
            colMedicalHistory = new DataGridViewTextBoxColumn();
            tableLayoutPanel1.SuspendLayout();
            tsPatient.SuspendLayout();
            pnlSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPatients).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(tsPatient, 0, 0);
            tableLayoutPanel1.Controls.Add(pnlSearch, 0, 1);
            tableLayoutPanel1.Controls.Add(dgvPatients, 0, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 80F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1029, 800);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // tsPatient
            // 
            tsPatient.ImageScalingSize = new Size(20, 20);
            tsPatient.Items.AddRange(new ToolStripItem[] { btnAdd, btnEdit, btnView, btnDelete, btnRefresh });
            tsPatient.Location = new Point(0, 0);
            tsPatient.Name = "tsPatient";
            tsPatient.Size = new Size(1029, 27);
            tsPatient.TabIndex = 0;
            tsPatient.Text = "toolStrip1";
            // 
            // btnAdd
            // 
            btnAdd.Image = Properties.Resources.ico_Add;
            btnAdd.ImageTransparentColor = Color.Magenta;
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(61, 24);
            btnAdd.Text = "Add";
            btnAdd.Click += btnAdd_Click;
            // 
            // btnEdit
            // 
            btnEdit.Image = Properties.Resources.ico_Editt;
            btnEdit.ImageAlign = ContentAlignment.MiddleLeft;
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(59, 24);
            btnEdit.Text = "Edit";
            btnEdit.Click += btnEdit_Click;
            // 
            // btnView
            // 
            btnView.Image = (Image)resources.GetObject("btnView.Image");
            btnView.Name = "btnView";
            btnView.Size = new Size(65, 24);
            btnView.Text = "View";
            btnView.Click += btnView_Click;
            // 
            // btnDelete
            // 
            btnDelete.Image = Properties.Resources.ico_Delete;
            btnDelete.ImageTransparentColor = Color.Magenta;
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(77, 24);
            btnDelete.Text = "Delete";
            btnDelete.Click += btnDelete_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.Image = Properties.Resources.ico_Refresh;
            btnRefresh.ImageTransparentColor = Color.Magenta;
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(82, 24);
            btnRefresh.Text = "Refresh";
            btnRefresh.Click += btnRefresh_Click;
            // 
            // pnlSearch
            // 
            pnlSearch.BackColor = Color.WhiteSmoke;
            pnlSearch.Controls.Add(lblSearch);
            pnlSearch.Controls.Add(txtSearch);
            pnlSearch.Controls.Add(btnSearch);
            pnlSearch.Controls.Add(btnClearSearch);
            pnlSearch.Dock = DockStyle.Fill;
            pnlSearch.Location = new Point(3, 44);
            pnlSearch.Margin = new Padding(3, 4, 3, 4);
            pnlSearch.Name = "pnlSearch";
            pnlSearch.Padding = new Padding(11, 13, 11, 13);
            pnlSearch.Size = new Size(1023, 72);
            pnlSearch.TabIndex = 1;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblSearch.Location = new Point(11, 20);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(68, 23);
            lblSearch.TabIndex = 0;
            lblSearch.Text = "Search:";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(91, 16);
            txtSearch.Margin = new Padding(3, 4, 3, 4);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Last Name,First Name,Phone";
            txtSearch.Size = new Size(571, 27);
            txtSearch.TabIndex = 1;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.DarkSlateBlue;
            btnSearch.ForeColor = Color.White;
            btnSearch.Location = new Point(674, 16);
            btnSearch.Margin = new Padding(3, 4, 3, 4);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(86, 31);
            btnSearch.TabIndex = 2;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnClearSearch
            // 
            btnClearSearch.BackColor = Color.Gray;
            btnClearSearch.ForeColor = Color.White;
            btnClearSearch.Location = new Point(766, 16);
            btnClearSearch.Margin = new Padding(3, 4, 3, 4);
            btnClearSearch.Name = "btnClearSearch";
            btnClearSearch.Size = new Size(86, 31);
            btnClearSearch.TabIndex = 3;
            btnClearSearch.Text = "Clear";
            btnClearSearch.UseVisualStyleBackColor = false;
            btnClearSearch.Click += btnClearSearch_Click;
            // 
            // dgvPatients
            // 
            dgvPatients.AllowUserToAddRows = false;
            dgvPatients.AllowUserToDeleteRows = false;
            dgvPatients.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPatients.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPatients.Columns.AddRange(new DataGridViewColumn[] { colId, colFirstName, colLastName, colPhone, colEmail, colDateOfBirth, colGender, colBloodGroup, colAddressLine1, colCity, colEmergencyName, colEmergencyPhone, colMedicalHistory });
            dgvPatients.Dock = DockStyle.Fill;
            dgvPatients.Location = new Point(3, 124);
            dgvPatients.Margin = new Padding(3, 4, 3, 4);
            dgvPatients.Name = "dgvPatients";
            dgvPatients.ReadOnly = true;
            dgvPatients.RowHeadersWidth = 51;
            dgvPatients.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPatients.Size = new Size(1023, 672);
            dgvPatients.TabIndex = 2;
            dgvPatients.SelectionChanged += dgvPatients_SelectionChanged;
            // 
            // colId
            // 
            colId.DataPropertyName = "Id";
            colId.HeaderText = "ID";
            colId.MinimumWidth = 6;
            colId.Name = "colId";
            colId.ReadOnly = true;
            // 
            // colFirstName
            // 
            colFirstName.DataPropertyName = "FirstName";
            colFirstName.HeaderText = "First Name";
            colFirstName.MinimumWidth = 6;
            colFirstName.Name = "colFirstName";
            colFirstName.ReadOnly = true;
            // 
            // colLastName
            // 
            colLastName.DataPropertyName = "LastName";
            colLastName.HeaderText = "Last Name";
            colLastName.MinimumWidth = 6;
            colLastName.Name = "colLastName";
            colLastName.ReadOnly = true;
            // 
            // colPhone
            // 
            colPhone.DataPropertyName = "Phone";
            colPhone.HeaderText = "Phone";
            colPhone.MinimumWidth = 6;
            colPhone.Name = "colPhone";
            colPhone.ReadOnly = true;
            // 
            // colEmail
            // 
            colEmail.DataPropertyName = "Email";
            colEmail.HeaderText = "Email";
            colEmail.MinimumWidth = 6;
            colEmail.Name = "colEmail";
            colEmail.ReadOnly = true;
            // 
            // colDateOfBirth
            // 
            colDateOfBirth.DataPropertyName = "DateOfBirth";
            colDateOfBirth.HeaderText = "Date of Birth";
            colDateOfBirth.MinimumWidth = 6;
            colDateOfBirth.Name = "colDateOfBirth";
            colDateOfBirth.ReadOnly = true;
            // 
            // colGender
            // 
            colGender.DataPropertyName = "Gender";
            colGender.HeaderText = "Gender";
            colGender.MinimumWidth = 6;
            colGender.Name = "colGender";
            colGender.ReadOnly = true;
            // 
            // colBloodGroup
            // 
            colBloodGroup.DataPropertyName = "BloodGroup";
            colBloodGroup.HeaderText = "Blood Group";
            colBloodGroup.MinimumWidth = 6;
            colBloodGroup.Name = "colBloodGroup";
            colBloodGroup.ReadOnly = true;
            // 
            // colAddressLine1
            // 
            colAddressLine1.DataPropertyName = "AddressLine1";
            colAddressLine1.HeaderText = "Address";
            colAddressLine1.MinimumWidth = 6;
            colAddressLine1.Name = "colAddressLine1";
            colAddressLine1.ReadOnly = true;
            // 
            // colCity
            // 
            colCity.DataPropertyName = "City";
            colCity.HeaderText = "City";
            colCity.MinimumWidth = 6;
            colCity.Name = "colCity";
            colCity.ReadOnly = true;
            // 
            // colEmergencyName
            // 
            colEmergencyName.DataPropertyName = "EmergencyName";
            colEmergencyName.HeaderText = "Emergency Name";
            colEmergencyName.MinimumWidth = 6;
            colEmergencyName.Name = "colEmergencyName";
            colEmergencyName.ReadOnly = true;
            // 
            // colEmergencyPhone
            // 
            colEmergencyPhone.DataPropertyName = "EmergencyPhone";
            colEmergencyPhone.HeaderText = "Emergency Phone";
            colEmergencyPhone.MinimumWidth = 6;
            colEmergencyPhone.Name = "colEmergencyPhone";
            colEmergencyPhone.ReadOnly = true;
            // 
            // colMedicalHistory
            // 
            colMedicalHistory.DataPropertyName = "MedicalHistory";
            colMedicalHistory.HeaderText = "Medical History";
            colMedicalHistory.MinimumWidth = 6;
            colMedicalHistory.Name = "colMedicalHistory";
            colMedicalHistory.ReadOnly = true;
            // 
            // PatientView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "PatientView";
            Size = new Size(1029, 800);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tsPatient.ResumeLayout(false);
            tsPatient.PerformLayout();
            pnlSearch.ResumeLayout(false);
            pnlSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPatients).EndInit();
            ResumeLayout(false);
        }

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ToolStrip tsPatient;
        private System.Windows.Forms.ToolStripButton btnAdd;
        private System.Windows.Forms.ToolStripButton btnEdit;
        private System.Windows.Forms.ToolStripButton btnView;
        private System.Windows.Forms.ToolStripButton btnDelete;
        private System.Windows.Forms.ToolStripButton btnRefresh;
        private System.Windows.Forms.Panel pnlSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnClearSearch;
        private System.Windows.Forms.DataGridView dgvPatients;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDateOfBirth;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGender;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBloodGroup;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAddressLine1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCity;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEmergencyName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEmergencyPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMedicalHistory;
    }
}
