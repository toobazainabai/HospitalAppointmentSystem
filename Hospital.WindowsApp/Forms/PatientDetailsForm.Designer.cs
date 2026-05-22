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
            pnlHeader = new Panel();
            lblTitle = new Label();
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
            pnlHeader.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            pnlButtons.SuspendLayout();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.DarkSlateBlue;
            pnlHeader.Controls.Add(lblTitle);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Padding = new Padding(20, 16, 20, 12);
            pnlHeader.Size = new Size(700, 60);
            pnlHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(20, 16);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(164, 30);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Patient Details";
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
            tableLayoutPanel1.Location = new Point(0, 60);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.Padding = new Padding(20);
            tableLayoutPanel1.RowCount = 14;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(700, 600);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // lblId
            // 
            lblId.Anchor = AnchorStyles.Left;
            lblId.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblId.Location = new Point(23, 26);
            lblId.Name = "lblId";
            lblId.Size = new Size(100, 23);
            lblId.TabIndex = 0;
            lblId.Text = "ID:";
            // 
            // txtId
            // 
            txtId.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtId.Location = new Point(223, 26);
            txtId.Margin = new Padding(5);
            txtId.Name = "txtId";
            txtId.Size = new Size(452, 23);
            txtId.TabIndex = 1;
            // 
            // lblFirstName
            // 
            lblFirstName.Anchor = AnchorStyles.Left;
            lblFirstName.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblFirstName.Location = new Point(23, 61);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(100, 23);
            lblFirstName.TabIndex = 2;
            lblFirstName.Text = "First Name:";
            // 
            // txtFirstName
            // 
            txtFirstName.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtFirstName.Location = new Point(223, 61);
            txtFirstName.Margin = new Padding(5);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(452, 23);
            txtFirstName.TabIndex = 3;
            // 
            // lblLastName
            // 
            lblLastName.Anchor = AnchorStyles.Left;
            lblLastName.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblLastName.Location = new Point(23, 96);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(100, 23);
            lblLastName.TabIndex = 4;
            lblLastName.Text = "Last Name:";
            // 
            // txtLastName
            // 
            txtLastName.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtLastName.Location = new Point(223, 96);
            txtLastName.Margin = new Padding(5);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(452, 23);
            txtLastName.TabIndex = 5;
            // 
            // lblPhone
            // 
            lblPhone.Anchor = AnchorStyles.Left;
            lblPhone.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblPhone.Location = new Point(23, 131);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(100, 23);
            lblPhone.TabIndex = 6;
            lblPhone.Text = "Phone:";
            // 
            // txtPhone
            // 
            txtPhone.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtPhone.Location = new Point(223, 131);
            txtPhone.Margin = new Padding(5);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(452, 23);
            txtPhone.TabIndex = 7;
            // 
            // lblEmail
            // 
            lblEmail.Anchor = AnchorStyles.Left;
            lblEmail.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblEmail.Location = new Point(23, 166);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(100, 23);
            lblEmail.TabIndex = 8;
            lblEmail.Text = "Email:";
            // 
            // txtEmail
            // 
            txtEmail.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtEmail.Location = new Point(223, 166);
            txtEmail.Margin = new Padding(5);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(452, 23);
            txtEmail.TabIndex = 9;
            // 
            // lblDOB
            // 
            lblDOB.Anchor = AnchorStyles.Left;
            lblDOB.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblDOB.Location = new Point(23, 201);
            lblDOB.Name = "lblDOB";
            lblDOB.Size = new Size(100, 23);
            lblDOB.TabIndex = 10;
            lblDOB.Text = "Date of Birth:";
            // 
            // dtpDOB
            // 
            dtpDOB.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            dtpDOB.Location = new Point(223, 201);
            dtpDOB.Margin = new Padding(5);
            dtpDOB.Name = "dtpDOB";
            dtpDOB.Size = new Size(452, 23);
            dtpDOB.TabIndex = 11;
            // 
            // lblGender
            // 
            lblGender.Anchor = AnchorStyles.Left;
            lblGender.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblGender.Location = new Point(23, 236);
            lblGender.Name = "lblGender";
            lblGender.Size = new Size(100, 23);
            lblGender.TabIndex = 12;
            lblGender.Text = "Gender:";
            // 
            // cmbGender
            // 
            cmbGender.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            cmbGender.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbGender.Location = new Point(223, 236);
            cmbGender.Margin = new Padding(5);
            cmbGender.Name = "cmbGender";
            cmbGender.Size = new Size(452, 23);
            cmbGender.TabIndex = 13;
            // 
            // lblBloodGroup
            // 
            lblBloodGroup.Anchor = AnchorStyles.Left;
            lblBloodGroup.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblBloodGroup.Location = new Point(23, 271);
            lblBloodGroup.Name = "lblBloodGroup";
            lblBloodGroup.Size = new Size(100, 23);
            lblBloodGroup.TabIndex = 14;
            lblBloodGroup.Text = "Blood Group:";
            // 
            // cmbBloodGroup
            // 
            cmbBloodGroup.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            cmbBloodGroup.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbBloodGroup.Location = new Point(223, 271);
            cmbBloodGroup.Margin = new Padding(5);
            cmbBloodGroup.Name = "cmbBloodGroup";
            cmbBloodGroup.Size = new Size(452, 23);
            cmbBloodGroup.TabIndex = 15;
            // 
            // lblAddressLine1
            // 
            lblAddressLine1.Anchor = AnchorStyles.Left;
            lblAddressLine1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblAddressLine1.Location = new Point(23, 306);
            lblAddressLine1.Name = "lblAddressLine1";
            lblAddressLine1.Size = new Size(100, 23);
            lblAddressLine1.TabIndex = 16;
            lblAddressLine1.Text = "Address:";
            // 
            // txtAddressLine1
            // 
            txtAddressLine1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtAddressLine1.Location = new Point(223, 306);
            txtAddressLine1.Margin = new Padding(5);
            txtAddressLine1.Name = "txtAddressLine1";
            txtAddressLine1.Size = new Size(452, 23);
            txtAddressLine1.TabIndex = 17;
            // 
            // lblCity
            // 
            lblCity.Anchor = AnchorStyles.Left;
            lblCity.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblCity.Location = new Point(23, 341);
            lblCity.Name = "lblCity";
            lblCity.Size = new Size(100, 23);
            lblCity.TabIndex = 18;
            lblCity.Text = "City:";
            // 
            // txtCity
            // 
            txtCity.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtCity.Location = new Point(223, 341);
            txtCity.Margin = new Padding(5);
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(452, 23);
            txtCity.TabIndex = 19;
            // 
            // lblEmergencyName
            // 
            lblEmergencyName.Anchor = AnchorStyles.Left;
            lblEmergencyName.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblEmergencyName.Location = new Point(23, 376);
            lblEmergencyName.Name = "lblEmergencyName";
            lblEmergencyName.Size = new Size(100, 23);
            lblEmergencyName.TabIndex = 20;
            lblEmergencyName.Text = "Emergency Name:";
            // 
            // txtEmergencyName
            // 
            txtEmergencyName.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtEmergencyName.Location = new Point(223, 376);
            txtEmergencyName.Margin = new Padding(5);
            txtEmergencyName.Name = "txtEmergencyName";
            txtEmergencyName.Size = new Size(452, 23);
            txtEmergencyName.TabIndex = 21;
            // 
            // lblEmergencyPhone
            // 
            lblEmergencyPhone.Anchor = AnchorStyles.Left;
            lblEmergencyPhone.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblEmergencyPhone.Location = new Point(23, 411);
            lblEmergencyPhone.Name = "lblEmergencyPhone";
            lblEmergencyPhone.Size = new Size(100, 23);
            lblEmergencyPhone.TabIndex = 22;
            lblEmergencyPhone.Text = "Emergency Phone:";
            // 
            // txtEmergencyPhone
            // 
            txtEmergencyPhone.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtEmergencyPhone.Location = new Point(223, 411);
            txtEmergencyPhone.Margin = new Padding(5);
            txtEmergencyPhone.Name = "txtEmergencyPhone";
            txtEmergencyPhone.Size = new Size(452, 23);
            txtEmergencyPhone.TabIndex = 23;
            // 
            // lblMedicalHistory
            // 
            lblMedicalHistory.Anchor = AnchorStyles.Left;
            lblMedicalHistory.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblMedicalHistory.Location = new Point(23, 446);
            lblMedicalHistory.Name = "lblMedicalHistory";
            lblMedicalHistory.Size = new Size(100, 23);
            lblMedicalHistory.TabIndex = 24;
            lblMedicalHistory.Text = "Medical History:";
            // 
            // rtbMedicalHistory
            // 
            rtbMedicalHistory.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            rtbMedicalHistory.Location = new Point(25, 480);
            rtbMedicalHistory.Margin = new Padding(5);
            rtbMedicalHistory.Name = "rtbMedicalHistory";
            rtbMedicalHistory.Size = new Size(188, 95);
            rtbMedicalHistory.TabIndex = 25;
            rtbMedicalHistory.Text = "";
            // 
            // pnlButtons
            // 
            pnlButtons.BackColor = Color.WhiteSmoke;
            pnlButtons.Controls.Add(btnClose);
            pnlButtons.Dock = DockStyle.Bottom;
            pnlButtons.Location = new Point(0, 660);
            pnlButtons.Name = "pnlButtons";
            pnlButtons.Padding = new Padding(20);
            pnlButtons.Size = new Size(700, 60);
            pnlButtons.TabIndex = 2;
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.Right;
            btnClose.BackColor = Color.Red;
            btnClose.ForeColor = Color.White;
            btnClose.Location = new Point(620, 15);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(60, 30);
            btnClose.TabIndex = 0;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // PatientDetailsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 720);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(pnlButtons);
            Controls.Add(pnlHeader);
            Name = "PatientDetailsForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Patient Details";
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            pnlButtons.ResumeLayout(false);
            ResumeLayout(false);
        }

        private Panel pnlHeader;
        private Label lblTitle;
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
