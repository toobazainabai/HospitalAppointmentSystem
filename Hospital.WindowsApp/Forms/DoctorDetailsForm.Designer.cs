namespace Hospital.WindowsApp.Forms
{
    partial class DoctorDetailsForm
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
            lblDoctorId = new Label();
            txtDoctorId = new TextBox();
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
            btnClose = new Button();
            tblDoctor = new TableLayoutPanel();
            flpButtons = new FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)numExperience).BeginInit();
            tblDoctor.SuspendLayout();
            flpButtons.SuspendLayout();
            SuspendLayout();
            // 
            // lblDoctorId
            // 
            lblDoctorId.AutoSize = true;
            lblDoctorId.Location = new Point(3, 0);
            lblDoctorId.Name = "lblDoctorId";
            lblDoctorId.Size = new Size(57, 15);
            lblDoctorId.TabIndex = 0;
            lblDoctorId.Text = "Doctor ID";
            // 
            // txtDoctorId
            // 
            txtDoctorId.Dock = DockStyle.Fill;
            txtDoctorId.Location = new Point(229, 3);
            txtDoctorId.Name = "txtDoctorId";
            txtDoctorId.ReadOnly = true;
            txtDoctorId.Size = new Size(523, 23);
            txtDoctorId.TabIndex = 1;
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Location = new Point(3, 40);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(64, 15);
            lblFirstName.TabIndex = 2;
            lblFirstName.Text = "First Name";
            // 
            // txtFirstName
            // 
            txtFirstName.Dock = DockStyle.Fill;
            txtFirstName.Location = new Point(229, 43);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.ReadOnly = true;
            txtFirstName.Size = new Size(523, 23);
            txtFirstName.TabIndex = 3;
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Location = new Point(3, 80);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(63, 15);
            lblLastName.TabIndex = 4;
            lblLastName.Text = "Last Name";
            // 
            // txtLastName
            // 
            txtLastName.Dock = DockStyle.Fill;
            txtLastName.Location = new Point(229, 83);
            txtLastName.Name = "txtLastName";
            txtLastName.ReadOnly = true;
            txtLastName.Size = new Size(523, 23);
            txtLastName.TabIndex = 5;
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Location = new Point(3, 120);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(41, 15);
            lblPhone.TabIndex = 6;
            lblPhone.Text = "Phone";
            // 
            // txtPhone
            // 
            txtPhone.Dock = DockStyle.Fill;
            txtPhone.Location = new Point(229, 123);
            txtPhone.Name = "txtPhone";
            txtPhone.ReadOnly = true;
            txtPhone.Size = new Size(523, 23);
            txtPhone.TabIndex = 7;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(3, 160);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(36, 15);
            lblEmail.TabIndex = 8;
            lblEmail.Text = "Email";
            // 
            // txtEmail
            // 
            txtEmail.Dock = DockStyle.Fill;
            txtEmail.Location = new Point(229, 163);
            txtEmail.Name = "txtEmail";
            txtEmail.ReadOnly = true;
            txtEmail.Size = new Size(523, 23);
            txtEmail.TabIndex = 9;
            // 
            // lblExperience
            // 
            lblExperience.AutoSize = true;
            lblExperience.Location = new Point(3, 200);
            lblExperience.Name = "lblExperience";
            lblExperience.Size = new Size(64, 15);
            lblExperience.TabIndex = 10;
            lblExperience.Text = "Experience";
            // 
            // numExperience
            // 
            numExperience.Dock = DockStyle.Fill;
            numExperience.Enabled = false;
            numExperience.Location = new Point(229, 203);
            numExperience.Name = "numExperience";
            numExperience.Size = new Size(523, 23);
            numExperience.TabIndex = 11;
            // 
            // lblSpecialty
            // 
            lblSpecialty.AutoSize = true;
            lblSpecialty.Location = new Point(3, 240);
            lblSpecialty.Name = "lblSpecialty";
            lblSpecialty.Size = new Size(54, 15);
            lblSpecialty.TabIndex = 12;
            lblSpecialty.Text = "Specialty";
            // 
            // cmbSpecialty
            // 
            cmbSpecialty.Dock = DockStyle.Fill;
            cmbSpecialty.Enabled = false;
            cmbSpecialty.FormattingEnabled = true;
            cmbSpecialty.Location = new Point(229, 243);
            cmbSpecialty.Name = "cmbSpecialty";
            cmbSpecialty.Size = new Size(523, 23);
            cmbSpecialty.TabIndex = 13;
            // 
            // btnClose
            // 
            btnClose.Image = Properties.Resources.ico_Cancel;
            btnClose.ImageAlign = ContentAlignment.MiddleLeft;
            btnClose.Location = new Point(677, 3);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(75, 33);
            btnClose.TabIndex = 14;
            btnClose.Text = "Close";
            btnClose.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // tblDoctor
            // 
            tblDoctor.ColumnCount = 2;
            tblDoctor.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tblDoctor.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
            tblDoctor.Controls.Add(lblDoctorId, 0, 0);
            tblDoctor.Controls.Add(txtDoctorId, 1, 0);
            tblDoctor.Controls.Add(lblFirstName, 0, 1);
            tblDoctor.Controls.Add(txtFirstName, 1, 1);
            tblDoctor.Controls.Add(lblLastName, 0, 2);
            tblDoctor.Controls.Add(txtLastName, 1, 2);
            tblDoctor.Controls.Add(lblPhone, 0, 3);
            tblDoctor.Controls.Add(txtPhone, 1, 3);
            tblDoctor.Controls.Add(lblEmail, 0, 4);
            tblDoctor.Controls.Add(txtEmail, 1, 4);
            tblDoctor.Controls.Add(lblExperience, 0, 5);
            tblDoctor.Controls.Add(numExperience, 1, 5);
            tblDoctor.Controls.Add(lblSpecialty, 0, 6);
            tblDoctor.Controls.Add(cmbSpecialty, 1, 6);
            tblDoctor.Dock = DockStyle.Top;
            tblDoctor.Location = new Point(10, 10);
            tblDoctor.Name = "tblDoctor";
            tblDoctor.RowCount = 7;
            tblDoctor.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tblDoctor.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tblDoctor.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tblDoctor.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tblDoctor.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tblDoctor.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tblDoctor.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tblDoctor.Size = new Size(755, 280);
            tblDoctor.TabIndex = 0;
            // 
            // flpButtons
            // 
            flpButtons.Controls.Add(btnClose);
            flpButtons.Dock = DockStyle.Bottom;
            flpButtons.FlowDirection = FlowDirection.RightToLeft;
            flpButtons.Location = new Point(10, 343);
            flpButtons.Name = "flpButtons";
            flpButtons.Size = new Size(755, 53);
            flpButtons.TabIndex = 1;
            // 
            // DoctorDetailsForm
            // 
            ClientSize = new Size(775, 406);
            Controls.Add(flpButtons);
            Controls.Add(tblDoctor);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "DoctorDetailsForm";
            Padding = new Padding(10);
            StartPosition = FormStartPosition.CenterParent;
            Text = "Doctor Details";
            ((System.ComponentModel.ISupportInitialize)numExperience).EndInit();
            tblDoctor.ResumeLayout(false);
            tblDoctor.PerformLayout();
            flpButtons.ResumeLayout(false);
            ResumeLayout(false);
        }

        private System.Windows.Forms.Label lblDoctorId;
        private System.Windows.Forms.TextBox txtDoctorId;
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
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TableLayoutPanel tblDoctor;
        private System.Windows.Forms.FlowLayoutPanel flpButtons;
    }
}
