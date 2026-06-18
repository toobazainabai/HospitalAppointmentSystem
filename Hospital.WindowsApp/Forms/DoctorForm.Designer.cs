namespace Hospital.WindowsApp.Forms
{
    partial class DoctorForm
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
            lblFirstName = new Label();
            txtFirstName = new TextBox();
            lblLastName = new Label();
            txtLastName = new TextBox();
            lblPhone = new Label();
            txtPhone = new TextBox();
            lblEmail = new Label();
            txtEmail = new TextBox();
            lblExperience = new Label();
            numExperience = new NumericUpDown();
            lblSpecialty = new Label();
            cmbSpecialty = new ComboBox();
            btnSave = new Button();
            btnCancel = new Button();
            tblDoctor = new TableLayoutPanel();
            flpDoctorbtn = new FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)numExperience).BeginInit();
            tblDoctor.SuspendLayout();
            flpDoctorbtn.SuspendLayout();
            SuspendLayout();
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Location = new Point(3, 0);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(80, 20);
            lblFirstName.TabIndex = 0;
            lblFirstName.Text = "First Name";
            // 
            // txtFirstName
            // 
            txtFirstName.Dock = DockStyle.Fill;
            txtFirstName.Location = new Point(229, 3);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(523, 27);
            txtFirstName.TabIndex = 1;
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Location = new Point(3, 40);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(79, 20);
            lblLastName.TabIndex = 2;
            lblLastName.Text = "Last Name";
            // 
            // txtLastName
            // 
            txtLastName.Dock = DockStyle.Fill;
            txtLastName.Location = new Point(229, 43);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(523, 27);
            txtLastName.TabIndex = 3;
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Location = new Point(3, 80);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(50, 20);
            lblPhone.TabIndex = 4;
            lblPhone.Text = "Phone";
            // 
            // txtPhone
            // 
            txtPhone.Dock = DockStyle.Fill;
            txtPhone.Location = new Point(229, 83);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(523, 27);
            txtPhone.TabIndex = 5;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(3, 120);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(46, 20);
            lblEmail.TabIndex = 6;
            lblEmail.Text = "Email";
            // 
            // txtEmail
            // 
            txtEmail.Dock = DockStyle.Fill;
            txtEmail.Location = new Point(229, 123);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(523, 27);
            txtEmail.TabIndex = 7;
            // 
            // lblExperience
            // 
            lblExperience.AutoSize = true;
            lblExperience.Location = new Point(3, 160);
            lblExperience.Name = "lblExperience";
            lblExperience.Size = new Size(81, 20);
            lblExperience.TabIndex = 8;
            lblExperience.Text = "Experience";
            // 
            // numExperience
            // 
            numExperience.Dock = DockStyle.Fill;
            numExperience.Location = new Point(229, 163);
            numExperience.Name = "numExperience";
            numExperience.Size = new Size(523, 27);
            numExperience.TabIndex = 9;
            // 
            // lblSpecialty
            // 
            lblSpecialty.AutoSize = true;
            lblSpecialty.Location = new Point(3, 200);
            lblSpecialty.Name = "lblSpecialty";
            lblSpecialty.Size = new Size(69, 20);
            lblSpecialty.TabIndex = 10;
            lblSpecialty.Text = "Specialty";
            // 
            // cmbSpecialty
            // 
            cmbSpecialty.Dock = DockStyle.Fill;
            cmbSpecialty.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSpecialty.FormattingEnabled = true;
            cmbSpecialty.Location = new Point(229, 203);
            cmbSpecialty.Name = "cmbSpecialty";
            cmbSpecialty.Size = new Size(523, 28);
            cmbSpecialty.TabIndex = 11;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.White;
            btnSave.Image = Properties.Resources.ico_Save;
            btnSave.ImageAlign = ContentAlignment.MiddleLeft;
            btnSave.Location = new Point(677, 3);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 47);
            btnSave.TabIndex = 1;
            btnSave.Text = "Save";
            btnSave.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.White;
            btnCancel.Image = Properties.Resources.ico_Cancel;
            btnCancel.ImageAlign = ContentAlignment.MiddleLeft;
            btnCancel.Location = new Point(586, 3);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(85, 47);
            btnCancel.TabIndex = 0;
            btnCancel.Text = "Cancel";
            btnCancel.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // tblDoctor
            // 
            tblDoctor.ColumnCount = 2;
            tblDoctor.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tblDoctor.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
            tblDoctor.Controls.Add(lblFirstName, 0, 0);
            tblDoctor.Controls.Add(txtFirstName, 1, 0);
            tblDoctor.Controls.Add(lblLastName, 0, 1);
            tblDoctor.Controls.Add(txtLastName, 1, 1);
            tblDoctor.Controls.Add(lblPhone, 0, 2);
            tblDoctor.Controls.Add(txtPhone, 1, 2);
            tblDoctor.Controls.Add(lblEmail, 0, 3);
            tblDoctor.Controls.Add(txtEmail, 1, 3);
            tblDoctor.Controls.Add(lblExperience, 0, 4);
            tblDoctor.Controls.Add(numExperience, 1, 4);
            tblDoctor.Controls.Add(lblSpecialty, 0, 5);
            tblDoctor.Controls.Add(cmbSpecialty, 1, 5);
            tblDoctor.Dock = DockStyle.Top;
            tblDoctor.Location = new Point(10, 10);
            tblDoctor.Name = "tblDoctor";
            tblDoctor.RowCount = 6;
            tblDoctor.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tblDoctor.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tblDoctor.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tblDoctor.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tblDoctor.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tblDoctor.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tblDoctor.Size = new Size(755, 240);
            tblDoctor.TabIndex = 0;
            // 
            // flpDoctorbtn
            // 
            flpDoctorbtn.Controls.Add(btnSave);
            flpDoctorbtn.Controls.Add(btnCancel);
            flpDoctorbtn.Dock = DockStyle.Bottom;
            flpDoctorbtn.FlowDirection = FlowDirection.RightToLeft;
            flpDoctorbtn.Location = new Point(10, 363);
            flpDoctorbtn.Name = "flpDoctorbtn";
            flpDoctorbtn.Size = new Size(755, 53);
            flpDoctorbtn.TabIndex = 2;
            // 
            // DoctorForm
            // 
            ClientSize = new Size(775, 426);
            Controls.Add(flpDoctorbtn);
            Controls.Add(tblDoctor);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "DoctorForm";
            Padding = new Padding(10);
            StartPosition = FormStartPosition.CenterParent;
            Text = "Doctor Form";
            ((System.ComponentModel.ISupportInitialize)numExperience).EndInit();
            tblDoctor.ResumeLayout(false);
            tblDoctor.PerformLayout();
            flpDoctorbtn.ResumeLayout(false);
            ResumeLayout(false);
        }

        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblExperience;
        private System.Windows.Forms.NumericUpDown numExperience;
        private System.Windows.Forms.Label lblSpecialty;
        private System.Windows.Forms.ComboBox cmbSpecialty;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TableLayoutPanel tblDoctor;
        private FlowLayoutPanel flpDoctorbtn;
    }
}