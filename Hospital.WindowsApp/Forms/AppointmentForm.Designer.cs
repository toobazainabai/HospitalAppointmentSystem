namespace Hospital.WindowsApp.Forms
{
    partial class AppointmentForm
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
            btnSave = new Button();
            btnCancel = new Button();
            tblAppointment = new TableLayoutPanel();
            flpAppointmentbtn = new FlowLayoutPanel();
            tblAppointment.SuspendLayout();
            flpAppointmentbtn.SuspendLayout();
            SuspendLayout();
            // 
            // lblPatientId
            // 
            lblPatientId.AutoSize = true;
            lblPatientId.Location = new Point(3, 0);
            lblPatientId.Name = "lblPatientId";
            lblPatientId.Size = new Size(73, 20);
            lblPatientId.TabIndex = 0;
            lblPatientId.Text = "Patient ID";
            // 
            // txtPatientId
            // 
            txtPatientId.Dock = DockStyle.Fill;
            txtPatientId.Location = new Point(231, 4);
            txtPatientId.Margin = new Padding(3, 4, 3, 4);
            txtPatientId.Name = "txtPatientId";
            txtPatientId.Size = new Size(529, 27);
            txtPatientId.TabIndex = 1;
            // 
            // lblDoctorId
            // 
            lblDoctorId.AutoSize = true;
            lblDoctorId.Location = new Point(3, 40);
            lblDoctorId.Name = "lblDoctorId";
            lblDoctorId.Size = new Size(74, 20);
            lblDoctorId.TabIndex = 2;
            lblDoctorId.Text = "Doctor ID";
            // 
            // txtDoctorId
            // 
            txtDoctorId.Dock = DockStyle.Fill;
            txtDoctorId.Location = new Point(231, 44);
            txtDoctorId.Margin = new Padding(3, 4, 3, 4);
            txtDoctorId.Name = "txtDoctorId";
            txtDoctorId.Size = new Size(529, 27);
            txtDoctorId.TabIndex = 3;
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Location = new Point(3, 80);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(107, 20);
            lblDate.TabIndex = 4;
            lblDate.Text = "Date and Time";
            // 
            // dtpDate
            // 
            dtpDate.CustomFormat = "MM/dd/yyyy hh:mm tt";
            dtpDate.Dock = DockStyle.Fill;
            dtpDate.Format = DateTimePickerFormat.Custom;
            dtpDate.Location = new Point(231, 84);
            dtpDate.Margin = new Padding(3, 4, 3, 4);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(529, 27);
            dtpDate.TabIndex = 5;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(3, 120);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(49, 20);
            lblStatus.TabIndex = 6;
            lblStatus.Text = "Status";
            // 
            // cmbStatus
            // 
            cmbStatus.Dock = DockStyle.Fill;
            cmbStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Location = new Point(231, 124);
            cmbStatus.Margin = new Padding(3, 4, 3, 4);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(529, 28);
            cmbStatus.TabIndex = 7;
            // 
            // lblNotes
            // 
            lblNotes.AutoSize = true;
            lblNotes.Location = new Point(3, 160);
            lblNotes.Name = "lblNotes";
            lblNotes.Size = new Size(48, 20);
            lblNotes.TabIndex = 8;
            lblNotes.Text = "Notes";
            // 
            // txtNotes
            // 
            txtNotes.Dock = DockStyle.Fill;
            txtNotes.Location = new Point(231, 164);
            txtNotes.Margin = new Padding(3, 4, 3, 4);
            txtNotes.Multiline = true;
            txtNotes.Name = "txtNotes";
            txtNotes.Size = new Size(529, 152);
            txtNotes.TabIndex = 9;
            // 
            // btnSave
            // 
            btnSave.Image = Properties.Resources.ico_Save;
            btnSave.Location = new Point(674, 4);
            btnSave.Margin = new Padding(3, 4, 3, 4);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(86, 40);
            btnSave.TabIndex = 10;
            btnSave.Text = "Save";
            btnSave.TextAlign = ContentAlignment.MiddleRight;
            btnSave.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Image = Properties.Resources.ico_Cancel;
            btnCancel.Location = new Point(582, 4);
            btnCancel.Margin = new Padding(3, 4, 3, 4);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(86, 40);
            btnCancel.TabIndex = 11;
            btnCancel.Text = "Cancel";
            btnCancel.TextAlign = ContentAlignment.MiddleRight;
            btnCancel.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // tblAppointment
            // 
            tblAppointment.ColumnCount = 2;
            tblAppointment.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tblAppointment.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
            tblAppointment.Controls.Add(lblPatientId, 0, 0);
            tblAppointment.Controls.Add(txtPatientId, 1, 0);
            tblAppointment.Controls.Add(lblDoctorId, 0, 1);
            tblAppointment.Controls.Add(txtDoctorId, 1, 1);
            tblAppointment.Controls.Add(lblDate, 0, 2);
            tblAppointment.Controls.Add(dtpDate, 1, 2);
            tblAppointment.Controls.Add(lblStatus, 0, 3);
            tblAppointment.Controls.Add(cmbStatus, 1, 3);
            tblAppointment.Controls.Add(lblNotes, 0, 4);
            tblAppointment.Controls.Add(txtNotes, 1, 4);
            tblAppointment.Dock = DockStyle.Top;
            tblAppointment.Location = new Point(11, 13);
            tblAppointment.Margin = new Padding(3, 4, 3, 4);
            tblAppointment.Name = "tblAppointment";
            tblAppointment.RowCount = 5;
            tblAppointment.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tblAppointment.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tblAppointment.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tblAppointment.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tblAppointment.RowStyles.Add(new RowStyle(SizeType.Absolute, 107F));
            tblAppointment.Size = new Size(763, 320);
            tblAppointment.TabIndex = 0;
            // 
            // flpAppointmentbtn
            // 
            flpAppointmentbtn.Controls.Add(btnSave);
            flpAppointmentbtn.Controls.Add(btnCancel);
            flpAppointmentbtn.Dock = DockStyle.Bottom;
            flpAppointmentbtn.FlowDirection = FlowDirection.RightToLeft;
            flpAppointmentbtn.Location = new Point(11, 375);
            flpAppointmentbtn.Margin = new Padding(3, 4, 3, 4);
            flpAppointmentbtn.Name = "flpAppointmentbtn";
            flpAppointmentbtn.Size = new Size(763, 67);
            flpAppointmentbtn.TabIndex = 1;
            // 
            // AppointmentForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(785, 455);
            Controls.Add(tblAppointment);
            Controls.Add(flpAppointmentbtn);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AppointmentForm";
            Padding = new Padding(11, 13, 11, 13);
            StartPosition = FormStartPosition.CenterParent;
            Text = "Appointment";
            tblAppointment.ResumeLayout(false);
            tblAppointment.PerformLayout();
            flpAppointmentbtn.ResumeLayout(false);
            ResumeLayout(false);
        }

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
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TableLayoutPanel tblAppointment;
        private System.Windows.Forms.FlowLayoutPanel flpAppointmentbtn;
    }
}