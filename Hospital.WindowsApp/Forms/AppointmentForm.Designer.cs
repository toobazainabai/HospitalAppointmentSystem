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
            lblPatientId.Size = new Size(58, 15);
            lblPatientId.TabIndex = 0;
            lblPatientId.Text = "Patient ID";
            // 
            // txtPatientId
            // 
            txtPatientId.Dock = DockStyle.Fill;
            txtPatientId.Location = new Point(203, 3);
            txtPatientId.Name = "txtPatientId";
            txtPatientId.Size = new Size(461, 23);
            txtPatientId.TabIndex = 1;
            // 
            // lblDoctorId
            // 
            lblDoctorId.AutoSize = true;
            lblDoctorId.Location = new Point(3, 30);
            lblDoctorId.Name = "lblDoctorId";
            lblDoctorId.Size = new Size(57, 15);
            lblDoctorId.TabIndex = 2;
            lblDoctorId.Text = "Doctor ID";
            // 
            // txtDoctorId
            // 
            txtDoctorId.Dock = DockStyle.Fill;
            txtDoctorId.Location = new Point(203, 33);
            txtDoctorId.Name = "txtDoctorId";
            txtDoctorId.Size = new Size(461, 23);
            txtDoctorId.TabIndex = 3;
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Location = new Point(3, 60);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(83, 15);
            lblDate.TabIndex = 4;
            lblDate.Text = "Date and Time";
            // 
            // dtpDate
            // 
            dtpDate.CustomFormat = "MM/dd/yyyy hh:mm tt";
            dtpDate.Dock = DockStyle.Fill;
            dtpDate.Format = DateTimePickerFormat.Custom;
            dtpDate.Location = new Point(203, 63);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(461, 23);
            dtpDate.TabIndex = 5;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(3, 90);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(39, 15);
            lblStatus.TabIndex = 6;
            lblStatus.Text = "Status";
            // 
            // cmbStatus
            // 
            cmbStatus.Dock = DockStyle.Fill;
            cmbStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Location = new Point(203, 93);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(461, 23);
            cmbStatus.TabIndex = 7;
            // 
            // lblNotes
            // 
            lblNotes.AutoSize = true;
            lblNotes.Location = new Point(3, 120);
            lblNotes.Name = "lblNotes";
            lblNotes.Size = new Size(38, 15);
            lblNotes.TabIndex = 8;
            lblNotes.Text = "Notes";
            // 
            // txtNotes
            // 
            txtNotes.Dock = DockStyle.Fill;
            txtNotes.Location = new Point(203, 123);
            txtNotes.Multiline = true;
            txtNotes.Name = "txtNotes";
            txtNotes.Size = new Size(461, 114);
            txtNotes.TabIndex = 9;
            // 
            // btnSave
            // 
            btnSave.Image = Properties.Resources.ico_Save;
            btnSave.Location = new Point(589, 3);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 30);
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
            btnCancel.Location = new Point(508, 3);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 30);
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
            tblAppointment.Location = new Point(10, 10);
            tblAppointment.Name = "tblAppointment";
            tblAppointment.RowCount = 5;
            tblAppointment.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tblAppointment.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tblAppointment.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tblAppointment.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tblAppointment.RowStyles.Add(new RowStyle(SizeType.Absolute, 80F));
            tblAppointment.Size = new Size(667, 240);
            tblAppointment.TabIndex = 0;
            // 
            // flpAppointmentbtn
            // 
            flpAppointmentbtn.Controls.Add(btnSave);
            flpAppointmentbtn.Controls.Add(btnCancel);
            flpAppointmentbtn.Dock = DockStyle.Bottom;
            flpAppointmentbtn.FlowDirection = FlowDirection.RightToLeft;
            flpAppointmentbtn.Location = new Point(10, 281);
            flpAppointmentbtn.Name = "flpAppointmentbtn";
            flpAppointmentbtn.Size = new Size(667, 50);
            flpAppointmentbtn.TabIndex = 1;
            // 
            // AppointmentForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(687, 341);
            Controls.Add(tblAppointment);
            Controls.Add(flpAppointmentbtn);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AppointmentForm";
            Padding = new Padding(10);
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