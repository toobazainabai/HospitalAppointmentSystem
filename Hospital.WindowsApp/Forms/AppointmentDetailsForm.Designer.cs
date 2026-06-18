namespace Hospital.WindowsApp.Forms
{
    partial class AppointmentDetailsForm
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
            lblAppointmentId = new Label();
            txtAppointmentId = new TextBox();
            lblPatientId = new Label();
            txtPatientId = new TextBox();
            lblDoctorId = new Label();
            txtDoctorId = new TextBox();
            lblDate = new Label();
            dtpDate = new DateTimePicker();
            lblStatus = new Label();
            cmbStatus = new ComboBox();
            lblNotes = new Label();
            txtNotes = new TextBox();
            btnClose = new Button();
            tblAppointment = new TableLayoutPanel();
            flpButtons = new FlowLayoutPanel();
            tblAppointment.SuspendLayout();
            flpButtons.SuspendLayout();
            SuspendLayout();
            // 
            // lblAppointmentId
            // 
            lblAppointmentId.AutoSize = true;
            lblAppointmentId.Location = new Point(3, 0);
            lblAppointmentId.Name = "lblAppointmentId";
            lblAppointmentId.Size = new Size(116, 20);
            lblAppointmentId.TabIndex = 0;
            lblAppointmentId.Text = "Appointment ID";
            // 
            // txtAppointmentId
            // 
            txtAppointmentId.Dock = DockStyle.Fill;
            txtAppointmentId.Location = new Point(231, 4);
            txtAppointmentId.Margin = new Padding(3, 4, 3, 4);
            txtAppointmentId.Name = "txtAppointmentId";
            txtAppointmentId.ReadOnly = true;
            txtAppointmentId.Size = new Size(529, 27);
            txtAppointmentId.TabIndex = 1;
            // 
            // lblPatientId
            // 
            lblPatientId.AutoSize = true;
            lblPatientId.Location = new Point(3, 40);
            lblPatientId.Name = "lblPatientId";
            lblPatientId.Size = new Size(73, 20);
            lblPatientId.TabIndex = 2;
            lblPatientId.Text = "Patient ID";
            // 
            // txtPatientId
            // 
            txtPatientId.Dock = DockStyle.Fill;
            txtPatientId.Location = new Point(231, 44);
            txtPatientId.Margin = new Padding(3, 4, 3, 4);
            txtPatientId.Name = "txtPatientId";
            txtPatientId.ReadOnly = true;
            txtPatientId.Size = new Size(529, 27);
            txtPatientId.TabIndex = 3;
            // 
            // lblDoctorId
            // 
            lblDoctorId.AutoSize = true;
            lblDoctorId.Location = new Point(3, 80);
            lblDoctorId.Name = "lblDoctorId";
            lblDoctorId.Size = new Size(74, 20);
            lblDoctorId.TabIndex = 4;
            lblDoctorId.Text = "Doctor ID";
            // 
            // txtDoctorId
            // 
            txtDoctorId.Dock = DockStyle.Fill;
            txtDoctorId.Location = new Point(231, 84);
            txtDoctorId.Margin = new Padding(3, 4, 3, 4);
            txtDoctorId.Name = "txtDoctorId";
            txtDoctorId.ReadOnly = true;
            txtDoctorId.Size = new Size(529, 27);
            txtDoctorId.TabIndex = 5;
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Location = new Point(3, 120);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(107, 20);
            lblDate.TabIndex = 6;
            lblDate.Text = "Date and Time";
            // 
            // dtpDate
            // 
            dtpDate.CustomFormat = "MM/dd/yyyy hh:mm tt";
            dtpDate.Dock = DockStyle.Fill;
            dtpDate.Enabled = false;
            dtpDate.Format = DateTimePickerFormat.Custom;
            dtpDate.Location = new Point(231, 124);
            dtpDate.Margin = new Padding(3, 4, 3, 4);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(529, 27);
            dtpDate.TabIndex = 7;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(3, 160);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(49, 20);
            lblStatus.TabIndex = 8;
            lblStatus.Text = "Status";
            // 
            // cmbStatus
            // 
            cmbStatus.Dock = DockStyle.Fill;
            cmbStatus.Enabled = false;
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Location = new Point(231, 164);
            cmbStatus.Margin = new Padding(3, 4, 3, 4);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(529, 28);
            cmbStatus.TabIndex = 9;
            // 
            // lblNotes
            // 
            lblNotes.AutoSize = true;
            lblNotes.Location = new Point(3, 200);
            lblNotes.Name = "lblNotes";
            lblNotes.Size = new Size(48, 20);
            lblNotes.TabIndex = 10;
            lblNotes.Text = "Notes";
            // 
            // txtNotes
            // 
            txtNotes.Dock = DockStyle.Fill;
            txtNotes.Location = new Point(231, 204);
            txtNotes.Margin = new Padding(3, 4, 3, 4);
            txtNotes.Multiline = true;
            txtNotes.Name = "txtNotes";
            txtNotes.ReadOnly = true;
            txtNotes.Size = new Size(529, 165);
            txtNotes.TabIndex = 11;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.White;
            btnClose.Image = Properties.Resources.ico_Cancel;
            btnClose.Location = new Point(674, 4);
            btnClose.Margin = new Padding(3, 4, 3, 4);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(86, 40);
            btnClose.TabIndex = 12;
            btnClose.Text = "Close";
            btnClose.TextAlign = ContentAlignment.MiddleRight;
            btnClose.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // tblAppointment
            // 
            tblAppointment.ColumnCount = 2;
            tblAppointment.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tblAppointment.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
            tblAppointment.Controls.Add(lblAppointmentId, 0, 0);
            tblAppointment.Controls.Add(txtAppointmentId, 1, 0);
            tblAppointment.Controls.Add(lblPatientId, 0, 1);
            tblAppointment.Controls.Add(txtPatientId, 1, 1);
            tblAppointment.Controls.Add(lblDoctorId, 0, 2);
            tblAppointment.Controls.Add(txtDoctorId, 1, 2);
            tblAppointment.Controls.Add(lblDate, 0, 3);
            tblAppointment.Controls.Add(dtpDate, 1, 3);
            tblAppointment.Controls.Add(lblStatus, 0, 4);
            tblAppointment.Controls.Add(cmbStatus, 1, 4);
            tblAppointment.Controls.Add(lblNotes, 0, 5);
            tblAppointment.Controls.Add(txtNotes, 1, 5);
            tblAppointment.Dock = DockStyle.Top;
            tblAppointment.Location = new Point(11, 13);
            tblAppointment.Margin = new Padding(3, 4, 3, 4);
            tblAppointment.Name = "tblAppointment";
            tblAppointment.RowCount = 6;
            tblAppointment.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tblAppointment.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tblAppointment.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tblAppointment.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tblAppointment.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tblAppointment.RowStyles.Add(new RowStyle(SizeType.Absolute, 107F));
            tblAppointment.Size = new Size(763, 373);
            tblAppointment.TabIndex = 0;
            // 
            // flpButtons
            // 
            flpButtons.Controls.Add(btnClose);
            flpButtons.Dock = DockStyle.Bottom;
            flpButtons.FlowDirection = FlowDirection.RightToLeft;
            flpButtons.Location = new Point(11, 428);
            flpButtons.Margin = new Padding(3, 4, 3, 4);
            flpButtons.Name = "flpButtons";
            flpButtons.Size = new Size(763, 67);
            flpButtons.TabIndex = 1;
            // 
            // AppointmentDetailsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(785, 508);
            Controls.Add(tblAppointment);
            Controls.Add(flpButtons);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AppointmentDetailsForm";
            Padding = new Padding(11, 13, 11, 13);
            StartPosition = FormStartPosition.CenterParent;
            Text = "Appointment Details";
            tblAppointment.ResumeLayout(false);
            tblAppointment.PerformLayout();
            flpButtons.ResumeLayout(false);
            ResumeLayout(false);
        }

        private System.Windows.Forms.Label lblAppointmentId;
        private System.Windows.Forms.TextBox txtAppointmentId;
        private System.Windows.Forms.Label lblPatientId;
        private System.Windows.Forms.TextBox txtPatientId;
        private System.Windows.Forms.Label lblDoctorId;
        private System.Windows.Forms.TextBox txtDoctorId;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.Label lblNotes;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TableLayoutPanel tblAppointment;
        private System.Windows.Forms.FlowLayoutPanel flpButtons;
    }
}
