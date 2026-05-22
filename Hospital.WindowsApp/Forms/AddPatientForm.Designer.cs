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
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 120F));
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
            tableLayoutPanel.Location = new Point(10, 10);
            tableLayoutPanel.Name = "tableLayoutPanel";
            tableLayoutPanel.Padding = new Padding(10);
            tableLayoutPanel.RowCount = 13;
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 100F));
            tableLayoutPanel.Size = new Size(500, 600);
            tableLayoutPanel.TabIndex = 0;
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Dock = DockStyle.Fill;
            lblFirstName.Location = new Point(13, 10);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(114, 30);
            lblFirstName.TabIndex = 0;
            lblFirstName.Text = "First Name:";
            lblFirstName.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtFirstName
            // 
            txtFirstName.Dock = DockStyle.Fill;
            txtFirstName.Location = new Point(133, 13);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(354, 23);
            txtFirstName.TabIndex = 1;
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Dock = DockStyle.Fill;
            lblLastName.Location = new Point(13, 40);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(114, 30);
            lblLastName.TabIndex = 2;
            lblLastName.Text = "Last Name:";
            lblLastName.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtLastName
            // 
            txtLastName.Dock = DockStyle.Fill;
            txtLastName.Location = new Point(133, 43);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(354, 23);
            txtLastName.TabIndex = 3;
            // 
            // lblDateOfBirth
            // 
            lblDateOfBirth.AutoSize = true;
            lblDateOfBirth.Dock = DockStyle.Fill;
            lblDateOfBirth.Location = new Point(13, 70);
            lblDateOfBirth.Name = "lblDateOfBirth";
            lblDateOfBirth.Size = new Size(114, 30);
            lblDateOfBirth.TabIndex = 4;
            lblDateOfBirth.Text = "Date of Birth:";
            lblDateOfBirth.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // dtpDOB
            // 
            dtpDOB.Dock = DockStyle.Fill;
            dtpDOB.Location = new Point(133, 73);
            dtpDOB.Name = "dtpDOB";
            dtpDOB.Size = new Size(354, 23);
            dtpDOB.TabIndex = 5;
            dtpDOB.Value = new DateTime(2026, 5, 18, 18, 40, 52, 795);
            // 
            // lblGender
            // 
            lblGender.AutoSize = true;
            lblGender.Dock = DockStyle.Fill;
            lblGender.Location = new Point(13, 100);
            lblGender.Name = "lblGender";
            lblGender.Size = new Size(114, 30);
            lblGender.TabIndex = 6;
            lblGender.Text = "Gender:";
            lblGender.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // cmbGender
            // 
            cmbGender.Dock = DockStyle.Fill;
            cmbGender.FormattingEnabled = true;
            cmbGender.Location = new Point(133, 103);
            cmbGender.Name = "cmbGender";
            cmbGender.Size = new Size(354, 23);
            cmbGender.TabIndex = 7;
            // 
            // lblBloodGroup
            // 
            lblBloodGroup.AutoSize = true;
            lblBloodGroup.Dock = DockStyle.Fill;
            lblBloodGroup.Location = new Point(13, 130);
            lblBloodGroup.Name = "lblBloodGroup";
            lblBloodGroup.Size = new Size(114, 30);
            lblBloodGroup.TabIndex = 8;
            lblBloodGroup.Text = "Blood Group:";
            lblBloodGroup.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // cmbBloodGroup
            // 
            cmbBloodGroup.Dock = DockStyle.Fill;
            cmbBloodGroup.FormattingEnabled = true;
            cmbBloodGroup.Location = new Point(133, 133);
            cmbBloodGroup.Name = "cmbBloodGroup";
            cmbBloodGroup.Size = new Size(354, 23);
            cmbBloodGroup.TabIndex = 9;
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Dock = DockStyle.Fill;
            lblPhone.Location = new Point(13, 160);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(114, 30);
            lblPhone.TabIndex = 10;
            lblPhone.Text = "Phone:";
            lblPhone.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtPhone
            // 
            txtPhone.Dock = DockStyle.Fill;
            txtPhone.Location = new Point(133, 163);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(354, 23);
            txtPhone.TabIndex = 11;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Dock = DockStyle.Fill;
            lblEmail.Location = new Point(13, 190);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(114, 30);
            lblEmail.TabIndex = 12;
            lblEmail.Text = "Email:";
            lblEmail.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtEmail
            // 
            txtEmail.Dock = DockStyle.Fill;
            txtEmail.Location = new Point(133, 193);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(354, 23);
            txtEmail.TabIndex = 13;
            // 
            // lblAddressLine1
            // 
            lblAddressLine1.AutoSize = true;
            lblAddressLine1.Dock = DockStyle.Fill;
            lblAddressLine1.Location = new Point(13, 220);
            lblAddressLine1.Name = "lblAddressLine1";
            lblAddressLine1.Size = new Size(114, 30);
            lblAddressLine1.TabIndex = 14;
            lblAddressLine1.Text = "Address:";
            lblAddressLine1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtAddressLine1
            // 
            txtAddressLine1.Dock = DockStyle.Fill;
            txtAddressLine1.Location = new Point(133, 223);
            txtAddressLine1.Name = "txtAddressLine1";
            txtAddressLine1.Size = new Size(354, 23);
            txtAddressLine1.TabIndex = 15;
            // 
            // lblCity
            // 
            lblCity.AutoSize = true;
            lblCity.Dock = DockStyle.Fill;
            lblCity.Location = new Point(13, 250);
            lblCity.Name = "lblCity";
            lblCity.Size = new Size(114, 30);
            lblCity.TabIndex = 16;
            lblCity.Text = "City:";
            lblCity.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtCity
            // 
            txtCity.Dock = DockStyle.Fill;
            txtCity.Location = new Point(133, 253);
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(354, 23);
            txtCity.TabIndex = 17;
            // 
            // lblEmergencyName
            // 
            lblEmergencyName.AutoSize = true;
            lblEmergencyName.Dock = DockStyle.Fill;
            lblEmergencyName.Location = new Point(13, 280);
            lblEmergencyName.Name = "lblEmergencyName";
            lblEmergencyName.Size = new Size(114, 30);
            lblEmergencyName.TabIndex = 18;
            lblEmergencyName.Text = "Emergency Name:";
            lblEmergencyName.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtEmergencyName
            // 
            txtEmergencyName.Dock = DockStyle.Fill;
            txtEmergencyName.Location = new Point(133, 283);
            txtEmergencyName.Name = "txtEmergencyName";
            txtEmergencyName.Size = new Size(354, 23);
            txtEmergencyName.TabIndex = 19;
            // 
            // lblEmergencyPhone
            // 
            lblEmergencyPhone.AutoSize = true;
            lblEmergencyPhone.Dock = DockStyle.Fill;
            lblEmergencyPhone.Location = new Point(13, 310);
            lblEmergencyPhone.Name = "lblEmergencyPhone";
            lblEmergencyPhone.Size = new Size(114, 30);
            lblEmergencyPhone.TabIndex = 20;
            lblEmergencyPhone.Text = "Emergency Phone:";
            lblEmergencyPhone.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtEmergencyPhone
            // 
            txtEmergencyPhone.Dock = DockStyle.Fill;
            txtEmergencyPhone.Location = new Point(133, 313);
            txtEmergencyPhone.Name = "txtEmergencyPhone";
            txtEmergencyPhone.Size = new Size(354, 23);
            txtEmergencyPhone.TabIndex = 21;
            // 
            // lblMedicalHistory
            // 
            lblMedicalHistory.AutoSize = true;
            lblMedicalHistory.Dock = DockStyle.Fill;
            lblMedicalHistory.Location = new Point(13, 340);
            lblMedicalHistory.Name = "lblMedicalHistory";
            lblMedicalHistory.Size = new Size(114, 25);
            lblMedicalHistory.TabIndex = 22;
            lblMedicalHistory.Text = "Medical History:";
            lblMedicalHistory.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // rtbMedicalHistory
            // 
            tableLayoutPanel.SetColumnSpan(rtbMedicalHistory, 2);
            rtbMedicalHistory.Dock = DockStyle.Fill;
            rtbMedicalHistory.Location = new Point(13, 368);
            rtbMedicalHistory.Name = "rtbMedicalHistory";
            rtbMedicalHistory.Size = new Size(474, 219);
            rtbMedicalHistory.TabIndex = 23;
            rtbMedicalHistory.Text = "";
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.Green;
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(10, 620);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(140, 35);
            btnSave.TabIndex = 0;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.Red;
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(360, 620);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(140, 35);
            btnCancel.TabIndex = 1;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // AddPatientForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(520, 670);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(tableLayoutPanel);
            MaximizeBox = false;
            Name = "AddPatientForm";
            Padding = new Padding(10);
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
