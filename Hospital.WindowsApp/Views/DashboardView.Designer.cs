namespace Hospital.WindowsApp.Views
{
    partial class DashboardView
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            tableLayoutPanel1 = new TableLayoutPanel();
            pnlPatients = new Panel();
            lblTotalPatientsValue = new Label();
            lblTotalPatientsTitle = new Label();
            pnlDoctors = new Panel();
            lblTotalDoctorsValue = new Label();
            lblTotalDoctorsTitle = new Label();
            pnlAppointments = new Panel();
            lblTotalAppointmentsValue = new Label();
            lblTotalAppointmentsTitle = new Label();
            lblTotalPrescriptionsTitle = new Label();
            lblTotalPrescriptionsValue = new Label();
            dgvRecentAppointments = new DataGridView();
            lblGridTitle = new Label();
            tableLayoutPanel1.SuspendLayout();
            pnlPatients.SuspendLayout();
            pnlDoctors.SuspendLayout();
            pnlAppointments.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRecentAppointments).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33F));
            tableLayoutPanel1.Controls.Add(pnlPatients, 0, 0);
            tableLayoutPanel1.Controls.Add(pnlDoctors, 1, 0);
            tableLayoutPanel1.Controls.Add(pnlAppointments, 2, 0);
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.Padding = new Padding(20);
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 130F));
            tableLayoutPanel1.Size = new Size(869, 170);
            tableLayoutPanel1.TabIndex = 4;
            // 
            // pnlPatients
            // 
            pnlPatients.BackColor = Color.FromArgb(173, 216, 230);
            pnlPatients.Controls.Add(lblTotalPatientsValue);
            pnlPatients.Controls.Add(lblTotalPatientsTitle);
            pnlPatients.Dock = DockStyle.Fill;
            pnlPatients.Location = new Point(23, 23);
            pnlPatients.Name = "pnlPatients";
            pnlPatients.Padding = new Padding(10);
            pnlPatients.Size = new Size(270, 124);
            pnlPatients.TabIndex = 0;
            // 
            // lblTotalPatientsValue
            // 
            lblTotalPatientsValue.Dock = DockStyle.Fill;
            lblTotalPatientsValue.Font = new Font("Segoe UI", 32F, FontStyle.Bold);
            lblTotalPatientsValue.ForeColor = Color.DarkBlue;
            lblTotalPatientsValue.Location = new Point(10, 40);
            lblTotalPatientsValue.Name = "lblTotalPatientsValue";
            lblTotalPatientsValue.Size = new Size(250, 74);
            lblTotalPatientsValue.TabIndex = 1;
            lblTotalPatientsValue.Text = "0";
            lblTotalPatientsValue.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTotalPatientsTitle
            // 
            lblTotalPatientsTitle.Dock = DockStyle.Top;
            lblTotalPatientsTitle.Font = new Font("Segoe UI", 12F);
            lblTotalPatientsTitle.ForeColor = Color.DarkBlue;
            lblTotalPatientsTitle.Location = new Point(10, 10);
            lblTotalPatientsTitle.Name = "lblTotalPatientsTitle";
            lblTotalPatientsTitle.Size = new Size(250, 30);
            lblTotalPatientsTitle.TabIndex = 0;
            lblTotalPatientsTitle.Text = "Total Patients";
            lblTotalPatientsTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlDoctors
            // 
            pnlDoctors.BackColor = Color.FromArgb(144, 238, 144);
            pnlDoctors.Controls.Add(lblTotalDoctorsValue);
            pnlDoctors.Controls.Add(lblTotalDoctorsTitle);
            pnlDoctors.Dock = DockStyle.Fill;
            pnlDoctors.Location = new Point(299, 23);
            pnlDoctors.Name = "pnlDoctors";
            pnlDoctors.Padding = new Padding(10);
            pnlDoctors.Size = new Size(270, 124);
            pnlDoctors.TabIndex = 1;
            // 
            // lblTotalDoctorsValue
            // 
            lblTotalDoctorsValue.Dock = DockStyle.Fill;
            lblTotalDoctorsValue.Font = new Font("Segoe UI", 32F, FontStyle.Bold);
            lblTotalDoctorsValue.ForeColor = Color.DarkGreen;
            lblTotalDoctorsValue.Location = new Point(10, 40);
            lblTotalDoctorsValue.Name = "lblTotalDoctorsValue";
            lblTotalDoctorsValue.Size = new Size(250, 74);
            lblTotalDoctorsValue.TabIndex = 1;
            lblTotalDoctorsValue.Text = "0";
            lblTotalDoctorsValue.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTotalDoctorsTitle
            // 
            lblTotalDoctorsTitle.Dock = DockStyle.Top;
            lblTotalDoctorsTitle.Font = new Font("Segoe UI", 12F);
            lblTotalDoctorsTitle.ForeColor = Color.DarkGreen;
            lblTotalDoctorsTitle.Location = new Point(10, 10);
            lblTotalDoctorsTitle.Name = "lblTotalDoctorsTitle";
            lblTotalDoctorsTitle.Size = new Size(250, 30);
            lblTotalDoctorsTitle.TabIndex = 0;
            lblTotalDoctorsTitle.Text = "Total Doctors";
            lblTotalDoctorsTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlAppointments
            // 
            pnlAppointments.BackColor = Color.FromArgb(255, 192, 203);
            pnlAppointments.Controls.Add(lblTotalAppointmentsValue);
            pnlAppointments.Controls.Add(lblTotalAppointmentsTitle);
            pnlAppointments.Dock = DockStyle.Fill;
            pnlAppointments.Location = new Point(575, 23);
            pnlAppointments.Name = "pnlAppointments";
            pnlAppointments.Padding = new Padding(10);
            pnlAppointments.Size = new Size(271, 124);
            pnlAppointments.TabIndex = 2;
            // 
            // lblTotalAppointmentsValue
            // 
            lblTotalAppointmentsValue.Dock = DockStyle.Fill;
            lblTotalAppointmentsValue.Font = new Font("Segoe UI", 32F, FontStyle.Bold);
            lblTotalAppointmentsValue.ForeColor = Color.DarkRed;
            lblTotalAppointmentsValue.Location = new Point(10, 40);
            lblTotalAppointmentsValue.Name = "lblTotalAppointmentsValue";
            lblTotalAppointmentsValue.Size = new Size(251, 74);
            lblTotalAppointmentsValue.TabIndex = 1;
            lblTotalAppointmentsValue.Text = "0";
            lblTotalAppointmentsValue.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTotalAppointmentsTitle
            // 
            lblTotalAppointmentsTitle.Dock = DockStyle.Top;
            lblTotalAppointmentsTitle.Font = new Font("Segoe UI", 12F);
            lblTotalAppointmentsTitle.ForeColor = Color.DarkRed;
            lblTotalAppointmentsTitle.Location = new Point(10, 10);
            lblTotalAppointmentsTitle.Name = "lblTotalAppointmentsTitle";
            lblTotalAppointmentsTitle.Size = new Size(251, 30);
            lblTotalAppointmentsTitle.TabIndex = 0;
            lblTotalAppointmentsTitle.Text = "Total Appointments";
            lblTotalAppointmentsTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTotalPrescriptionsTitle
            // 
            lblTotalPrescriptionsTitle.Location = new Point(0, 0);
            lblTotalPrescriptionsTitle.Name = "lblTotalPrescriptionsTitle";
            lblTotalPrescriptionsTitle.Size = new Size(100, 23);
            lblTotalPrescriptionsTitle.TabIndex = 0;
            // 
            // lblTotalPrescriptionsValue
            // 
            lblTotalPrescriptionsValue.Location = new Point(0, 0);
            lblTotalPrescriptionsValue.Name = "lblTotalPrescriptionsValue";
            lblTotalPrescriptionsValue.Size = new Size(100, 23);
            lblTotalPrescriptionsValue.TabIndex = 0;
            // 
            // dgvRecentAppointments
            // 
            dgvRecentAppointments.AllowUserToAddRows = false;
            dgvRecentAppointments.AllowUserToDeleteRows = false;
            dgvRecentAppointments.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dgvRecentAppointments.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.DarkSlateBlue;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvRecentAppointments.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvRecentAppointments.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRecentAppointments.Location = new Point(0, 280);
            dgvRecentAppointments.Name = "dgvRecentAppointments";
            dgvRecentAppointments.ReadOnly = true;
            dgvRecentAppointments.RowHeadersWidth = 51;
            dgvRecentAppointments.Size = new Size(869, 200);
            dgvRecentAppointments.TabIndex = 2;
            // 
            // lblGridTitle
            // 
            lblGridTitle.AutoSize = true;
            lblGridTitle.BackColor = Color.WhiteSmoke;
            lblGridTitle.Dock = DockStyle.Top;
            lblGridTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblGridTitle.Location = new Point(0, 170);
            lblGridTitle.Name = "lblGridTitle";
            lblGridTitle.Padding = new Padding(20, 15, 0, 10);
            lblGridTitle.Size = new Size(281, 57);
            lblGridTitle.TabIndex = 3;
            lblGridTitle.Text = "Recent Appointments";
            // 
            // DashboardView
            // 
            AutoScroll = true;
            Controls.Add(dgvRecentAppointments);
            Controls.Add(lblGridTitle);
            Controls.Add(tableLayoutPanel1);
            Name = "DashboardView";
            Padding = new Padding(0, 0, 0, 20);
            Size = new Size(869, 750);
            tableLayoutPanel1.ResumeLayout(false);
            pnlPatients.ResumeLayout(false);
            pnlDoctors.ResumeLayout(false);
            pnlAppointments.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvRecentAppointments).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void SetupStatPanel(System.Windows.Forms.Panel panel, System.Windows.Forms.Label title, System.Windows.Forms.Label value, string titleText, System.Drawing.Color backColor)
        {
            panel.BackColor = backColor;
            panel.Dock = System.Windows.Forms.DockStyle.Fill;
            panel.Margin = new System.Windows.Forms.Padding(10);
            panel.Padding = new System.Windows.Forms.Padding(10);

            title.Text = titleText;
            title.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular);
            title.Dock = System.Windows.Forms.DockStyle.Top;
            title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            value.Text = "0";
            value.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            value.Dock = System.Windows.Forms.DockStyle.Fill;
            value.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            panel.Controls.Add(value);
            panel.Controls.Add(title);
        }

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel pnlPatients;
        private System.Windows.Forms.Label lblTotalPatientsTitle;
        private System.Windows.Forms.Label lblTotalPatientsValue;
        private System.Windows.Forms.Panel pnlDoctors;
        private System.Windows.Forms.Label lblTotalDoctorsTitle;
        private System.Windows.Forms.Label lblTotalDoctorsValue;
        private System.Windows.Forms.Panel pnlAppointments;
        private System.Windows.Forms.Label lblTotalAppointmentsTitle;
        private System.Windows.Forms.Label lblTotalAppointmentsValue;
        private System.Windows.Forms.Label lblTotalPrescriptionsTitle;
        private System.Windows.Forms.Label lblTotalPrescriptionsValue;
        private System.Windows.Forms.DataGridView dgvRecentAppointments;
        private System.Windows.Forms.Label lblGridTitle;
    }
}


