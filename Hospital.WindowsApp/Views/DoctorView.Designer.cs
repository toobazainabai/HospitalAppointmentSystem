namespace Hospital.WindowsApp.Views
{
    partial class DoctorView
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
            tableLayoutPanel1 = new TableLayoutPanel();
            tsDoctor = new ToolStrip();
            btnAdd = new ToolStripButton();
            btnUpdate = new ToolStripButton();
            btnView = new ToolStripButton();
            btnDelete = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            btnRefresh = new ToolStripButton();
            pnlSearch = new Panel();
            lblSearch = new Label();
            txtSearch = new TextBox();
            btnSearch = new Button();
            btnClearSearch = new Button();
            dgvDoctors = new DataGridView();
            colId = new DataGridViewTextBoxColumn();
            colFirstName = new DataGridViewTextBoxColumn();
            colLastName = new DataGridViewTextBoxColumn();
            colPhone = new DataGridViewTextBoxColumn();
            colEmail = new DataGridViewTextBoxColumn();
            colExperience = new DataGridViewTextBoxColumn();
            colSpecialty = new DataGridViewTextBoxColumn();
            tableLayoutPanel1.SuspendLayout();
            tsDoctor.SuspendLayout();
            pnlSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDoctors).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(tsDoctor, 0, 0);
            tableLayoutPanel1.Controls.Add(pnlSearch, 0, 1);
            tableLayoutPanel1.Controls.Add(dgvDoctors, 0, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(800, 600);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // tsDoctor
            // 
            tsDoctor.Items.AddRange(new ToolStripItem[] { btnAdd, btnUpdate, btnView, btnDelete, toolStripSeparator1, btnRefresh });
            tsDoctor.Location = new Point(0, 0);
            tsDoctor.Name = "tsDoctor";
            tsDoctor.Size = new Size(800, 25);
            tsDoctor.TabIndex = 0;
            tsDoctor.Text = "toolStrip1";
            tsDoctor.ItemClicked += tsDoctor_ItemClicked;
            // 
            // btnAdd
            // 
            btnAdd.Image = Properties.Resources.ico_Add;
            btnAdd.ImageTransparentColor = Color.Magenta;
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(49, 22);
            btnAdd.Text = "Add";
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Image = Properties.Resources.ico_edit;
            btnUpdate.ImageTransparentColor = Color.Magenta;
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(47, 22);
            btnUpdate.Text = "Edit";
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnView
            // 
            btnView.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnView.Image = Properties.Resources.ico_View;
            btnView.Name = "btnView";
            btnView.Size = new Size(36, 22);
            btnView.Text = "View";
            btnView.Click += btnView_Click;
            // 
            // btnDelete
            // 
            btnDelete.Image = Properties.Resources.ico_Delete;
            btnDelete.ImageTransparentColor = Color.Magenta;
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(60, 22);
            btnDelete.Text = "Delete";
            btnDelete.Click += btnDelete_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 25);
            // 
            // btnRefresh
            // 
            btnRefresh.Image = Properties.Resources.ico_Refresh;
            btnRefresh.ImageTransparentColor = Color.Magenta;
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(66, 22);
            btnRefresh.Text = "Refresh";
            btnRefresh.Click += btnClear_Click;
            // 
            // pnlSearch
            // 
            pnlSearch.BackColor = Color.WhiteSmoke;
            pnlSearch.Controls.Add(lblSearch);
            pnlSearch.Controls.Add(txtSearch);
            pnlSearch.Controls.Add(btnSearch);
            pnlSearch.Controls.Add(btnClearSearch);
            pnlSearch.Dock = DockStyle.Fill;
            pnlSearch.Location = new Point(3, 33);
            pnlSearch.Name = "pnlSearch";
            pnlSearch.Padding = new Padding(10);
            pnlSearch.Size = new Size(794, 54);
            pnlSearch.TabIndex = 1;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblSearch.Location = new Point(10, 15);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(58, 19);
            lblSearch.TabIndex = 0;
            lblSearch.Text = "Search:";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(80, 12);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Enter any doctor data (ID, Name, Phone, Email, Specialty, etc.)";
            txtSearch.Size = new Size(450, 23);
            txtSearch.TabIndex = 1;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.DarkSlateBlue;
            btnSearch.ForeColor = Color.White;
            btnSearch.Location = new Point(540, 12);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(75, 23);
            btnSearch.TabIndex = 2;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnClearSearch
            // 
            btnClearSearch.BackColor = Color.Gray;
            btnClearSearch.ForeColor = Color.White;
            btnClearSearch.Location = new Point(620, 12);
            btnClearSearch.Name = "btnClearSearch";
            btnClearSearch.Size = new Size(75, 23);
            btnClearSearch.TabIndex = 3;
            btnClearSearch.Text = "Clear";
            btnClearSearch.UseVisualStyleBackColor = false;
            btnClearSearch.Click += btnClearSearch_Click;
            // 
            // dgvDoctors
            // 
            dgvDoctors.AllowUserToAddRows = false;
            dgvDoctors.AllowUserToDeleteRows = false;
            dgvDoctors.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDoctors.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDoctors.Columns.AddRange(new DataGridViewColumn[] { colId, colFirstName, colLastName, colPhone, colEmail, colExperience, colSpecialty });
            dgvDoctors.Dock = DockStyle.Fill;
            dgvDoctors.Location = new Point(3, 93);
            dgvDoctors.Name = "dgvDoctors";
            dgvDoctors.ReadOnly = true;
            dgvDoctors.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDoctors.Size = new Size(794, 504);
            dgvDoctors.TabIndex = 2;
            dgvDoctors.CellClick += dgvDoctors_CellClick;
            dgvDoctors.CellContentClick += dgvDoctors_CellContentClick;
            dgvDoctors.SelectionChanged += dgvDoctors_SelectionChanged;
            // 
            // colId
            // 
            colId.DataPropertyName = "Id";
            colId.HeaderText = "ID";
            colId.Name = "colId";
            colId.ReadOnly = true;
            colId.Visible = false;
            // 
            // colFirstName
            // 
            colFirstName.DataPropertyName = "FirstName";
            colFirstName.HeaderText = "First Name";
            colFirstName.Name = "colFirstName";
            colFirstName.ReadOnly = true;
            // 
            // colLastName
            // 
            colLastName.DataPropertyName = "LastName";
            colLastName.HeaderText = "Last Name";
            colLastName.Name = "colLastName";
            colLastName.ReadOnly = true;
            // 
            // colPhone
            // 
            colPhone.DataPropertyName = "Phone";
            colPhone.HeaderText = "Phone";
            colPhone.Name = "colPhone";
            colPhone.ReadOnly = true;
            // 
            // colEmail
            // 
            colEmail.DataPropertyName = "Email";
            colEmail.HeaderText = "Email";
            colEmail.Name = "colEmail";
            colEmail.ReadOnly = true;
            // 
            // colExperience
            // 
            colExperience.DataPropertyName = "ExperienceYears";
            colExperience.HeaderText = "Experience";
            colExperience.Name = "colExperience";
            colExperience.ReadOnly = true;
            // 
            // colSpecialty
            // 
            colSpecialty.DataPropertyName = "Specialty";
            colSpecialty.HeaderText = "Specialty";
            colSpecialty.Name = "colSpecialty";
            colSpecialty.ReadOnly = true;
            // 
            // DoctorView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Name = "DoctorView";
            Size = new Size(800, 600);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tsDoctor.ResumeLayout(false);
            tsDoctor.PerformLayout();
            pnlSearch.ResumeLayout(false);
            pnlSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDoctors).EndInit();
            ResumeLayout(false);
        }
        private TableLayoutPanel tableLayoutPanel1;
        private ToolStrip tsDoctor;
        private ToolStripButton btnAdd;
        private ToolStripButton btnUpdate;
        private ToolStripButton btnView;
        private ToolStripButton btnDelete;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton btnRefresh;
        private Panel pnlSearch;
        private Label lblSearch;
        private TextBox txtSearch;
        private Button btnSearch;
        private Button btnClearSearch;
        private DataGridView dgvDoctors;
        private DataGridViewTextBoxColumn colId;
        private DataGridViewTextBoxColumn colFirstName;
        private DataGridViewTextBoxColumn colLastName;
        private DataGridViewTextBoxColumn colPhone;
        private DataGridViewTextBoxColumn colEmail;
        private DataGridViewTextBoxColumn colExperience;
        private DataGridViewTextBoxColumn colSpecialty;
    }
}