namespace Hospital.WindowsApp.Forms
{
    partial class PatientDetailsForm
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
            lblId = new Label();
            txtId = new TextBox();
            lblFirstName = new Label();
            txtFirstName = new TextBox();
            lblLastName = new Label();
            txtLastName = new TextBox();
            lblPhone = new Label();
            txtPhone = new TextBox();
            lblEmail = new Label();
            txtEmail = new TextBox();
            lblDOB = new Label();
            dtpDOB = new DateTimePicker();
            lblGender = new Label();
            cmbGender = new ComboBox();
            lblBloodGroup = new Label();
            cmbBloodGroup = new ComboBox();
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
            pnlButtons = new Panel();
            btnClose = new Button();
            tableLayoutPanel1.SuspendLayout();
            pnlButtons.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
            tableLayoutPanel1.Controls.Add(lblId, 0, 0);
            tableLayoutPanel1.Controls.Add(txtId, 1, 0);
            tableLayoutPanel1.Controls.Add(lblFirstName, 0, 1);
            tableLayoutPanel1.Controls.Add(txtFirstName, 1, 1);
            tableLayoutPanel1.Controls.Add(lblLastName, 0, 2);
            tableLayoutPanel1.Controls.Add(txtLastName, 1, 2);
            tableLayoutPanel1.Controls.Add(lblPhone, 0, 3);
            tableLayoutPanel1.Controls.Add(txtPhone, 1, 3);
            tableLayoutPanel1.Controls.Add(lblEmail, 0, 4);
            tableLayoutPanel1.Controls.Add(txtEmail, 1, 4);
            tableLayoutPanel1.Controls.Add(lblDOB, 0, 5);
            tableLayoutPanel1.Controls.Add(dtpDOB, 1, 5);
            tableLayoutPanel1.Controls.Add(lblGender, 0, 6);
            tableLayoutPanel1.Controls.Add(cmbGender, 1, 6);
            tableLayoutPanel1.Controls.Add(lblBloodGroup, 0, 7);
            tableLayoutPanel1.Controls.Add(cmbBloodGroup, 1, 7);
            tableLayoutPanel1.Controls.Add(lblAddressLine1, 0, 8);
            tableLayoutPanel1.Controls.Add(txtAddressLine1, 1, 8);
            tableLayoutPanel1.Controls.Add(lblCity, 0, 9);
            tableLayoutPanel1.Controls.Add(txtCity, 1, 9);
            tableLayoutPanel1.Controls.Add(lblEmergencyName, 0, 10);
            tableLayoutPanel1.Controls.Add(txtEmergencyName, 1, 10);
            tableLayoutPanel1.Controls.Add(lblEmergencyPhone, 0, 11);
            tableLayoutPanel1.Controls.Add(txtEmergencyPhone, 1, 11);
            tableLayoutPanel1.Controls.Add(lblMedicalHistory, 0, 12);
            tableLayoutPanel1.Controls.Add(rtbMedicalHistory, 0, 13);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.Padding = new Padding(23, 27, 23, 27);
            tableLayoutPanel1.RowCount = 14;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 47F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 47F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 47F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 47F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 47F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 47F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 47F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 47F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 47F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 47F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 47F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 47F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 47F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(800, 880);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // lblId
            // 
            lblId.Anchor = AnchorStyles.Left;
            lblId.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblId.Location = new Point(26, 35);
            lblId.Name = "lblId";
            lblId.Size = new Size(114, 31);
            lblId.TabIndex = 0;
            lblId.Text = "ID:";
            // 
            // txtId
            // 
            txtId.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtId.Location = new Point(255, 37);
            txtId.Margin = new Padding(6, 7, 6, 7);
            txtId.Name = "txtId";
            txtId.Size = new Size(516, 27);
            txtId.TabIndex = 1;
            // 
            // lblFirstName
            // 
            lblFirstName.Anchor = AnchorStyles.Left;
            lblFirstName.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblFirstName.Location = new Point(26, 82);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(114, 31);
            lblFirstName.TabIndex = 2;
            lblFirstName.Text = "First Name:";
            // 
            // txtFirstName
            // 
            txtFirstName.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtFirstName.Location = new Point(255, 84);
            txtFirstName.Margin = new Padding(6, 7, 6, 7);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(516, 27);
            txtFirstName.TabIndex = 3;
            // 
            // lblLastName
            // 
            lblLastName.Anchor = AnchorStyles.Left;
            lblLastName.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblLastName.Location = new Point(26, 129);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(114, 31);
            lblLastName.TabIndex = 4;
            lblLastName.Text = "Last Name:";
            // 
            // txtLastName
            // 
            txtLastName.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtLastName.Location = new Point(255, 131);
            txtLastName.Margin = new Padding(6, 7, 6, 7);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(516, 27);
            txtLastName.TabIndex = 5;
            // 
            // lblPhone
            // 
            lblPhone.Anchor = AnchorStyles.Left;
            lblPhone.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblPhone.Location = new Point(26, 176);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(114, 31);
            lblPhone.TabIndex = 6;
            lblPhone.Text = "Phone:";
            // 
            // txtPhone
            // 
            txtPhone.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtPhone.Location = new Point(255, 178);
            txtPhone.Margin = new Padding(6, 7, 6, 7);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(516, 27);
            txtPhone.TabIndex = 7;
            // 
            // lblEmail
            // 
            lblEmail.Anchor = AnchorStyles.Left;
            lblEmail.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblEmail.Location = new Point(26, 223);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(114, 31);
            lblEmail.TabIndex = 8;
            lblEmail.Text = "Email:";
            // 
            // txtEmail
            // 
            txtEmail.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtEmail.Location = new Point(255, 225);
            txtEmail.Margin = new Padding(6, 7, 6, 7);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(516, 27);
            txtEmail.TabIndex = 9;
            // 
            // lblDOB
            // 
            lblDOB.Anchor = AnchorStyles.Left;
            lblDOB.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblDOB.Location = new Point(26, 270);
            lblDOB.Name = "lblDOB";
            lblDOB.Size = new Size(114, 31);
            lblDOB.TabIndex = 10;
            lblDOB.Text = "Date of Birth:";
            // 
            // dtpDOB
            // 
            dtpDOB.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            dtpDOB.Location = new Point(255, 272);
            dtpDOB.Margin = new Padding(6, 7, 6, 7);
            dtpDOB.Name = "dtpDOB";
            dtpDOB.Size = new Size(516, 27);
            dtpDOB.TabIndex = 11;
            // 
            // lblGender
            // 
            lblGender.Anchor = AnchorStyles.Left;
            lblGender.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblGender.Location = new Point(26, 317);
            lblGender.Name = "lblGender";
            lblGender.Size = new Size(114, 31);
            lblGender.TabIndex = 12;
            lblGender.Text = "Gender:";
            // 
            // cmbGender
            // 
            cmbGender.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            cmbGender.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbGender.Location = new Point(255, 318);
            cmbGender.Margin = new Padding(6, 7, 6, 7);
            cmbGender.Name = "cmbGender";
            cmbGender.Size = new Size(516, 28);
            cmbGender.TabIndex = 13;
            // 
            // lblBloodGroup
            // 
            lblBloodGroup.Anchor = AnchorStyles.Left;
            lblBloodGroup.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblBloodGroup.Location = new Point(26, 364);
            lblBloodGroup.Name = "lblBloodGroup";
            lblBloodGroup.Size = new Size(114, 31);
            lblBloodGroup.TabIndex = 14;
            lblBloodGroup.Text = "Blood Group:";
            // 
            // cmbBloodGroup
            // 
            cmbBloodGroup.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            cmbBloodGroup.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbBloodGroup.Location = new Point(255, 365);
            cmbBloodGroup.Margin = new Padding(6, 7, 6, 7);
            cmbBloodGroup.Name = "cmbBloodGroup";
            cmbBloodGroup.Size = new Size(516, 28);
            cmbBloodGroup.TabIndex = 15;
            // 
            // lblAddressLine1
            // 
            lblAddressLine1.Anchor = AnchorStyles.Left;
            lblAddressLine1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblAddressLine1.Location = new Point(26, 411);
            lblAddressLine1.Name = "lblAddressLine1";
            lblAddressLine1.Size = new Size(114, 31);
            lblAddressLine1.TabIndex = 16;
            lblAddressLine1.Text = "Address:";
            // 
            // txtAddressLine1
            // 
            txtAddressLine1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtAddressLine1.Location = new Point(255, 413);
            txtAddressLine1.Margin = new Padding(6, 7, 6, 7);
            txtAddressLine1.Name = "txtAddressLine1";
            txtAddressLine1.Size = new Size(516, 27);
            txtAddressLine1.TabIndex = 17;
            // 
            // lblCity
            // 
            lblCity.Anchor = AnchorStyles.Left;
            lblCity.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblCity.Location = new Point(26, 458);
            lblCity.Name = "lblCity";
            lblCity.Size = new Size(114, 31);
            lblCity.TabIndex = 18;
            lblCity.Text = "City:";
            // 
            // txtCity
            // 
            txtCity.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtCity.Location = new Point(255, 460);
            txtCity.Margin = new Padding(6, 7, 6, 7);
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(516, 27);
            txtCity.TabIndex = 19;
            // 
            // lblEmergencyName
            // 
            lblEmergencyName.Anchor = AnchorStyles.Left;
            lblEmergencyName.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblEmergencyName.Location = new Point(26, 505);
            lblEmergencyName.Name = "lblEmergencyName";
            lblEmergencyName.Size = new Size(114, 31);
            lblEmergencyName.TabIndex = 20;
            lblEmergencyName.Text = "Emergency Name:";
            // 
            // txtEmergencyName
            // 
            txtEmergencyName.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtEmergencyName.Location = new Point(255, 507);
            txtEmergencyName.Margin = new Padding(6, 7, 6, 7);
            txtEmergencyName.Name = "txtEmergencyName";
            txtEmergencyName.Size = new Size(516, 27);
            txtEmergencyName.TabIndex = 21;
            // 
            // lblEmergencyPhone
            // 
            lblEmergencyPhone.Anchor = AnchorStyles.Left;
            lblEmergencyPhone.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblEmergencyPhone.Location = new Point(26, 552);
            lblEmergencyPhone.Name = "lblEmergencyPhone";
            lblEmergencyPhone.Size = new Size(114, 31);
            lblEmergencyPhone.TabIndex = 22;
            lblEmergencyPhone.Text = "Emergency Phone:";
            // 
            // txtEmergencyPhone
            // 
            txtEmergencyPhone.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtEmergencyPhone.Location = new Point(255, 554);
            txtEmergencyPhone.Margin = new Padding(6, 7, 6, 7);
            txtEmergencyPhone.Name = "txtEmergencyPhone";
            txtEmergencyPhone.Size = new Size(516, 27);
            txtEmergencyPhone.TabIndex = 23;
            // 
            // lblMedicalHistory
            // 
            lblMedicalHistory.Anchor = AnchorStyles.Left;
            lblMedicalHistory.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblMedicalHistory.Location = new Point(26, 599);
            lblMedicalHistory.Name = "lblMedicalHistory";
            lblMedicalHistory.Size = new Size(114, 31);
            lblMedicalHistory.TabIndex = 24;
            lblMedicalHistory.Text = "Medical History:";
            // 
            // rtbMedicalHistory
            // 
            rtbMedicalHistory.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            rtbMedicalHistory.Location = new Point(29, 645);
            rtbMedicalHistory.Margin = new Padding(6, 7, 6, 7);
            rtbMedicalHistory.Name = "rtbMedicalHistory";
            rtbMedicalHistory.Size = new Size(214, 201);
            rtbMedicalHistory.TabIndex = 25;
            rtbMedicalHistory.Text = "";
            // 
            // pnlButtons
            // 
            pnlButtons.BackColor = Color.WhiteSmoke;
            pnlButtons.Controls.Add(btnClose);
            pnlButtons.Dock = DockStyle.Bottom;
            pnlButtons.Location = new Point(0, 880);
            pnlButtons.Margin = new Padding(3, 4, 3, 4);
            pnlButtons.Name = "pnlButtons";
            pnlButtons.Padding = new Padding(23, 27, 23, 27);
            pnlButtons.Size = new Size(800, 80);
            pnlButtons.TabIndex = 2;
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.Right;
            btnClose.BackColor = Color.White;
            btnClose.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnClose.ForeColor = Color.Black;
            btnClose.Image = Properties.Resources.ico_Cancel;
            btnClose.Location = new Point(693, 20);
            btnClose.Margin = new Padding(3, 4, 3, 4);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(85, 40);
            btnClose.TabIndex = 0;
            btnClose.Text = "Close";
            btnClose.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // PatientDetailsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 960);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(pnlButtons);
            Margin = new Padding(3, 4, 3, 4);
            Name = "PatientDetailsForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Patient Details";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            pnlButtons.ResumeLayout(false);
            ResumeLayout(false);
        }
        private TableLayoutPanel tableLayoutPanel1;
        private Label lblId;
        private TextBox txtId;
        private Label lblFirstName;
        private TextBox txtFirstName;
        private Label lblLastName;
        private TextBox txtLastName;
        private Label lblPhone;
        private TextBox txtPhone;
        private Label lblEmail;
        private TextBox txtEmail;
        private Label lblDOB;
        private DateTimePicker dtpDOB;
        private Label lblGender;
        private ComboBox cmbGender;
        private Label lblBloodGroup;
        private ComboBox cmbBloodGroup;
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
        private Panel pnlButtons;
        private Button btnClose;
    }
}
