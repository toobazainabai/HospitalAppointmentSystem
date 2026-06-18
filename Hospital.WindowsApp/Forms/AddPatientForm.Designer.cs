namespace Hospital.WindowsApp.Forms
{
    partial class AddPatientForm
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
            tableLayoutPanel = new TableLayoutPanel();
            lblFirstName = new Label();
            txtFirstName = new TextBox();
            lblLastName = new Label();
            txtLastName = new TextBox();
            lblDateOfBirth = new Label();
            dtpDOB = new DateTimePicker();
            lblGender = new Label();
            cmbGender = new ComboBox();
            lblBloodGroup = new Label();
            cmbBloodGroup = new ComboBox();
            lblPhone = new Label();
            txtPhone = new TextBox();
            lblEmail = new Label();
            txtEmail = new TextBox();
            lblAddressLine1 = new Label();
            txtAddressLine1 = new TextBox();
            lblCity = new Label();
            txtCity = new TextBox();
            lblEmergencyName = new Label();
            txtEmergencyName = new TextBox();
            lblEmergencyPhone = new Label();
            txtEmergencyPhone = new TextBox();
            lblMedicalHistory = new Label();
            rtbMedicalHistory = new RichTextBox();
            btnSave = new Button();
            btnCancel = new Button();
            tableLayoutPanel.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel
            // 
            tableLayoutPanel.AutoScroll = true;
            tableLayoutPanel.ColumnCount = 2;
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 137F));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel.Controls.Add(lblFirstName, 0, 0);
            tableLayoutPanel.Controls.Add(txtFirstName, 1, 0);
            tableLayoutPanel.Controls.Add(lblLastName, 0, 1);
            tableLayoutPanel.Controls.Add(txtLastName, 1, 1);
            tableLayoutPanel.Controls.Add(lblDateOfBirth, 0, 2);
            tableLayoutPanel.Controls.Add(dtpDOB, 1, 2);
            tableLayoutPanel.Controls.Add(lblGender, 0, 3);
            tableLayoutPanel.Controls.Add(cmbGender, 1, 3);
            tableLayoutPanel.Controls.Add(lblBloodGroup, 0, 4);
            tableLayoutPanel.Controls.Add(cmbBloodGroup, 1, 4);
            tableLayoutPanel.Controls.Add(lblPhone, 0, 5);
            tableLayoutPanel.Controls.Add(txtPhone, 1, 5);
            tableLayoutPanel.Controls.Add(lblEmail, 0, 6);
            tableLayoutPanel.Controls.Add(txtEmail, 1, 6);
            tableLayoutPanel.Controls.Add(lblAddressLine1, 0, 7);
            tableLayoutPanel.Controls.Add(txtAddressLine1, 1, 7);
            tableLayoutPanel.Controls.Add(lblCity, 0, 8);
            tableLayoutPanel.Controls.Add(txtCity, 1, 8);
            tableLayoutPanel.Controls.Add(lblEmergencyName, 0, 9);
            tableLayoutPanel.Controls.Add(txtEmergencyName, 1, 9);
            tableLayoutPanel.Controls.Add(lblEmergencyPhone, 0, 10);
            tableLayoutPanel.Controls.Add(txtEmergencyPhone, 1, 10);
            tableLayoutPanel.Controls.Add(lblMedicalHistory, 0, 11);
            tableLayoutPanel.Controls.Add(rtbMedicalHistory, 0, 12);
            tableLayoutPanel.Dock = DockStyle.Top;
            tableLayoutPanel.Location = new Point(11, 13);
            tableLayoutPanel.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel.Name = "tableLayoutPanel";
            tableLayoutPanel.Padding = new Padding(11, 13, 11, 13);
            tableLayoutPanel.RowCount = 13;
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 33F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 133F));
            tableLayoutPanel.Size = new Size(572, 800);
            tableLayoutPanel.TabIndex = 0;
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Dock = DockStyle.Fill;
            lblFirstName.Location = new Point(14, 13);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(131, 40);
            lblFirstName.TabIndex = 0;
            lblFirstName.Text = "First Name:";
            lblFirstName.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtFirstName
            // 
            txtFirstName.Dock = DockStyle.Fill;
            txtFirstName.Location = new Point(151, 17);
            txtFirstName.Margin = new Padding(3, 4, 3, 4);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(407, 27);
            txtFirstName.TabIndex = 1;
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Dock = DockStyle.Fill;
            lblLastName.Location = new Point(14, 53);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(131, 40);
            lblLastName.TabIndex = 2;
            lblLastName.Text = "Last Name:";
            lblLastName.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtLastName
            // 
            txtLastName.Dock = DockStyle.Fill;
            txtLastName.Location = new Point(151, 57);
            txtLastName.Margin = new Padding(3, 4, 3, 4);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(407, 27);
            txtLastName.TabIndex = 3;
            // 
            // lblDateOfBirth
            // 
            lblDateOfBirth.AutoSize = true;
            lblDateOfBirth.Dock = DockStyle.Fill;
            lblDateOfBirth.Location = new Point(14, 93);
            lblDateOfBirth.Name = "lblDateOfBirth";
            lblDateOfBirth.Size = new Size(131, 40);
            lblDateOfBirth.TabIndex = 4;
            lblDateOfBirth.Text = "Date of Birth:";
            lblDateOfBirth.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // dtpDOB
            // 
            dtpDOB.Dock = DockStyle.Fill;
            dtpDOB.Location = new Point(151, 97);
            dtpDOB.Margin = new Padding(3, 4, 3, 4);
            dtpDOB.Name = "dtpDOB";
            dtpDOB.Size = new Size(407, 27);
            dtpDOB.TabIndex = 5;
            dtpDOB.Value = new DateTime(2026, 5, 18, 18, 40, 52, 795);
            // 
            // lblGender
            // 
            lblGender.AutoSize = true;
            lblGender.Dock = DockStyle.Fill;
            lblGender.Location = new Point(14, 133);
            lblGender.Name = "lblGender";
            lblGender.Size = new Size(131, 40);
            lblGender.TabIndex = 6;
            lblGender.Text = "Gender:";
            lblGender.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // cmbGender
            // 
            cmbGender.Dock = DockStyle.Fill;
            cmbGender.FormattingEnabled = true;
            cmbGender.Location = new Point(151, 137);
            cmbGender.Margin = new Padding(3, 4, 3, 4);
            cmbGender.Name = "cmbGender";
            cmbGender.Size = new Size(407, 28);
            cmbGender.TabIndex = 7;
            // 
            // lblBloodGroup
            // 
            lblBloodGroup.AutoSize = true;
            lblBloodGroup.Dock = DockStyle.Fill;
            lblBloodGroup.Location = new Point(14, 173);
            lblBloodGroup.Name = "lblBloodGroup";
            lblBloodGroup.Size = new Size(131, 40);
            lblBloodGroup.TabIndex = 8;
            lblBloodGroup.Text = "Blood Group:";
            lblBloodGroup.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // cmbBloodGroup
            // 
            cmbBloodGroup.Dock = DockStyle.Fill;
            cmbBloodGroup.FormattingEnabled = true;
            cmbBloodGroup.Location = new Point(151, 177);
            cmbBloodGroup.Margin = new Padding(3, 4, 3, 4);
            cmbBloodGroup.Name = "cmbBloodGroup";
            cmbBloodGroup.Size = new Size(407, 28);
            cmbBloodGroup.TabIndex = 9;
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Dock = DockStyle.Fill;
            lblPhone.Location = new Point(14, 213);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(131, 40);
            lblPhone.TabIndex = 10;
            lblPhone.Text = "Phone:";
            lblPhone.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtPhone
            // 
            txtPhone.Dock = DockStyle.Fill;
            txtPhone.Location = new Point(151, 217);
            txtPhone.Margin = new Padding(3, 4, 3, 4);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(407, 27);
            txtPhone.TabIndex = 11;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Dock = DockStyle.Fill;
            lblEmail.Location = new Point(14, 253);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(131, 40);
            lblEmail.TabIndex = 12;
            lblEmail.Text = "Email:";
            lblEmail.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtEmail
            // 
            txtEmail.Dock = DockStyle.Fill;
            txtEmail.Location = new Point(151, 257);
            txtEmail.Margin = new Padding(3, 4, 3, 4);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(407, 27);
            txtEmail.TabIndex = 13;
            // 
            // lblAddressLine1
            // 
            lblAddressLine1.AutoSize = true;
            lblAddressLine1.Dock = DockStyle.Fill;
            lblAddressLine1.Location = new Point(14, 293);
            lblAddressLine1.Name = "lblAddressLine1";
            lblAddressLine1.Size = new Size(131, 40);
            lblAddressLine1.TabIndex = 14;
            lblAddressLine1.Text = "Address:";
            lblAddressLine1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtAddressLine1
            // 
            txtAddressLine1.Dock = DockStyle.Fill;
            txtAddressLine1.Location = new Point(151, 297);
            txtAddressLine1.Margin = new Padding(3, 4, 3, 4);
            txtAddressLine1.Name = "txtAddressLine1";
            txtAddressLine1.Size = new Size(407, 27);
            txtAddressLine1.TabIndex = 15;
            // 
            // lblCity
            // 
            lblCity.AutoSize = true;
            lblCity.Dock = DockStyle.Fill;
            lblCity.Location = new Point(14, 333);
            lblCity.Name = "lblCity";
            lblCity.Size = new Size(131, 40);
            lblCity.TabIndex = 16;
            lblCity.Text = "City:";
            lblCity.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtCity
            // 
            txtCity.Dock = DockStyle.Fill;
            txtCity.Location = new Point(151, 337);
            txtCity.Margin = new Padding(3, 4, 3, 4);
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(407, 27);
            txtCity.TabIndex = 17;
            // 
            // lblEmergencyName
            // 
            lblEmergencyName.AutoSize = true;
            lblEmergencyName.Dock = DockStyle.Fill;
            lblEmergencyName.Location = new Point(14, 373);
            lblEmergencyName.Name = "lblEmergencyName";
            lblEmergencyName.Size = new Size(131, 40);
            lblEmergencyName.TabIndex = 18;
            lblEmergencyName.Text = "Emergency Name:";
            lblEmergencyName.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtEmergencyName
            // 
            txtEmergencyName.Dock = DockStyle.Fill;
            txtEmergencyName.Location = new Point(151, 377);
            txtEmergencyName.Margin = new Padding(3, 4, 3, 4);
            txtEmergencyName.Name = "txtEmergencyName";
            txtEmergencyName.Size = new Size(407, 27);
            txtEmergencyName.TabIndex = 19;
            // 
            // lblEmergencyPhone
            // 
            lblEmergencyPhone.AutoSize = true;
            lblEmergencyPhone.Dock = DockStyle.Fill;
            lblEmergencyPhone.Location = new Point(14, 413);
            lblEmergencyPhone.Name = "lblEmergencyPhone";
            lblEmergencyPhone.Size = new Size(131, 40);
            lblEmergencyPhone.TabIndex = 20;
            lblEmergencyPhone.Text = "Emergency Phone:";
            lblEmergencyPhone.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtEmergencyPhone
            // 
            txtEmergencyPhone.Dock = DockStyle.Fill;
            txtEmergencyPhone.Location = new Point(151, 417);
            txtEmergencyPhone.Margin = new Padding(3, 4, 3, 4);
            txtEmergencyPhone.Name = "txtEmergencyPhone";
            txtEmergencyPhone.Size = new Size(407, 27);
            txtEmergencyPhone.TabIndex = 21;
            // 
            // lblMedicalHistory
            // 
            lblMedicalHistory.AutoSize = true;
            lblMedicalHistory.Dock = DockStyle.Fill;
            lblMedicalHistory.Location = new Point(14, 453);
            lblMedicalHistory.Name = "lblMedicalHistory";
            lblMedicalHistory.Size = new Size(131, 33);
            lblMedicalHistory.TabIndex = 22;
            lblMedicalHistory.Text = "Medical History:";
            lblMedicalHistory.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // rtbMedicalHistory
            // 
            tableLayoutPanel.SetColumnSpan(rtbMedicalHistory, 2);
            rtbMedicalHistory.Dock = DockStyle.Fill;
            rtbMedicalHistory.Location = new Point(14, 490);
            rtbMedicalHistory.Margin = new Padding(3, 4, 3, 4);
            rtbMedicalHistory.Name = "rtbMedicalHistory";
            rtbMedicalHistory.Size = new Size(544, 293);
            rtbMedicalHistory.TabIndex = 23;
            rtbMedicalHistory.Text = "";
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.White;
            btnSave.ForeColor = Color.Black;
            btnSave.Image = Properties.Resources.ico_Save;
            btnSave.Location = new Point(366, 829);
            btnSave.Margin = new Padding(3, 4, 3, 4);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(104, 47);
            btnSave.TabIndex = 0;
            btnSave.Text = "Save";
            btnSave.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.White;
            btnCancel.ForeColor = Color.Black;
            btnCancel.Image = Properties.Resources.ico_Cancel;
            btnCancel.Location = new Point(476, 829);
            btnCancel.Margin = new Padding(3, 4, 3, 4);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(93, 47);
            btnCancel.TabIndex = 1;
            btnCancel.Text = "Cancel";
            btnCancel.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // AddPatientForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(594, 893);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(tableLayoutPanel);
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "AddPatientForm";
            Padding = new Padding(11, 13, 11, 13);
            StartPosition = FormStartPosition.CenterParent;
            Text = "Add New Patient";
            tableLayoutPanel.ResumeLayout(false);
            tableLayoutPanel.PerformLayout();
            ResumeLayout(false);
        }

        private TableLayoutPanel tableLayoutPanel;
        private Label lblFirstName;
        private TextBox txtFirstName;
        private Label lblLastName;
        private TextBox txtLastName;
        private Label lblDateOfBirth;
        private DateTimePicker dtpDOB;
        private Label lblGender;
        private ComboBox cmbGender;
        private Label lblBloodGroup;
        private ComboBox cmbBloodGroup;
        private Label lblPhone;
        private TextBox txtPhone;
        private Label lblEmail;
        private TextBox txtEmail;
        private Label lblAddressLine1;
        private TextBox txtAddressLine1;
        private Label lblCity;
        private TextBox txtCity;
        private Label lblEmergencyName;
        private TextBox txtEmergencyName;
        private Label lblEmergencyPhone;
        private TextBox txtEmergencyPhone;
        private Label lblMedicalHistory;
        private RichTextBox rtbMedicalHistory;
        private Button btnSave;
        private Button btnCancel;
    }
}
