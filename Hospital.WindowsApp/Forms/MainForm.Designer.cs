namespace Hospital.WindowsApp.Forms
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pnlHeader = new Panel();
            flpLeft = new FlowLayoutPanel();
            pblogo = new PictureBox();
            lblAppTitle = new Label();
            flpRight = new FlowLayoutPanel();
            picUser = new PictureBox();
            lblUser = new Label();
            pnlSidebar = new Panel();
            flpSidebar = new FlowLayoutPanel();
            btnDashboard = new Button();
            btnPatients = new Button();
            btnDoctors = new Button();
            btnAppointments = new Button();
            pnlContent = new Panel();
            statusStrip1 = new StatusStrip();
            lblStatusRecords = new ToolStripStatusLabel();
            pnlHeader.SuspendLayout();
            flpLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pblogo).BeginInit();
            flpRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picUser).BeginInit();
            pnlSidebar.SuspendLayout();
            flpSidebar.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = SystemColors.Window;
            pnlHeader.Controls.Add(flpLeft);
            pnlHeader.Controls.Add(flpRight);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Margin = new Padding(3, 4, 3, 4);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Padding = new Padding(14, 11, 14, 11);
            pnlHeader.Size = new Size(914, 75);
            pnlHeader.TabIndex = 0;
            // 
            // flpLeft
            // 
            flpLeft.Controls.Add(pblogo);
            flpLeft.Controls.Add(lblAppTitle);
            flpLeft.Dock = DockStyle.Left;
            flpLeft.Location = new Point(14, 11);
            flpLeft.Margin = new Padding(3, 4, 3, 4);
            flpLeft.Name = "flpLeft";
            flpLeft.Size = new Size(309, 53);
            flpLeft.TabIndex = 2;
            flpLeft.WrapContents = false;
            // 
            // pblogo
            // 
            pblogo.Image = Properties.Resources.ico_Hospital;
            pblogo.Location = new Point(3, 4);
            pblogo.Margin = new Padding(3, 4, 3, 4);
            pblogo.Name = "pblogo";
            pblogo.Size = new Size(37, 43);
            pblogo.SizeMode = PictureBoxSizeMode.Zoom;
            pblogo.TabIndex = 0;
            pblogo.TabStop = false;
            // 
            // lblAppTitle
            // 
            lblAppTitle.AutoSize = true;
            lblAppTitle.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAppTitle.Location = new Point(46, 0);
            lblAppTitle.Name = "lblAppTitle";
            lblAppTitle.Padding = new Padding(9, 8, 0, 0);
            lblAppTitle.Size = new Size(287, 33);
            lblAppTitle.TabIndex = 1;
            lblAppTitle.Text = "Hospital Appointment System";
            lblAppTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // flpRight
            // 
            flpRight.Controls.Add(picUser);
            flpRight.Controls.Add(lblUser);
            flpRight.Dock = DockStyle.Right;
            flpRight.FlowDirection = FlowDirection.RightToLeft;
            flpRight.Location = new Point(780, 11);
            flpRight.Margin = new Padding(3, 4, 3, 4);
            flpRight.Name = "flpRight";
            flpRight.Size = new Size(120, 53);
            flpRight.TabIndex = 1;
            flpRight.WrapContents = false;
            // 
            // picUser
            // 
            picUser.Image = Properties.Resources.admin;
            picUser.Location = new Point(66, 5);
            picUser.Margin = new Padding(5, 5, 5, 5);
            picUser.Name = "picUser";
            picUser.Padding = new Padding(6, 7, 6, 7);
            picUser.Size = new Size(49, 45);
            picUser.TabIndex = 0;
            picUser.TabStop = false;
            // 
            // lblUser
            // 
            lblUser.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblUser.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUser.Location = new Point(-62, 0);
            lblUser.Name = "lblUser";
            lblUser.Padding = new Padding(0, 11, 11, 0);
            lblUser.Size = new Size(120, 56);
            lblUser.TabIndex = 1;
            lblUser.Text = "admin";
            lblUser.TextAlign = ContentAlignment.MiddleRight;
            lblUser.Click += lblUser_Click;
            // 
            // pnlSidebar
            // 
            pnlSidebar.BackColor = SystemColors.Window;
            pnlSidebar.Controls.Add(flpSidebar);
            pnlSidebar.Dock = DockStyle.Left;
            pnlSidebar.Location = new Point(0, 75);
            pnlSidebar.Margin = new Padding(3, 4, 3, 4);
            pnlSidebar.Name = "pnlSidebar";
            pnlSidebar.Size = new Size(217, 499);
            pnlSidebar.TabIndex = 1;
            // 
            // flpSidebar
            // 
            flpSidebar.Controls.Add(btnDashboard);
            flpSidebar.Controls.Add(btnPatients);
            flpSidebar.Controls.Add(btnDoctors);
            flpSidebar.Controls.Add(btnAppointments);
            flpSidebar.Dock = DockStyle.Fill;
            flpSidebar.FlowDirection = FlowDirection.TopDown;
            flpSidebar.Location = new Point(0, 0);
            flpSidebar.Margin = new Padding(0);
            flpSidebar.Name = "flpSidebar";
            flpSidebar.Size = new Size(217, 499);
            flpSidebar.TabIndex = 0;
            flpSidebar.WrapContents = false;
            // 
            // btnDashboard
            // 
            btnDashboard.Cursor = Cursors.Hand;
            btnDashboard.FlatStyle = FlatStyle.Flat;
            btnDashboard.Image = Properties.Resources.ico_Dashboard;
            btnDashboard.ImageAlign = ContentAlignment.MiddleLeft;
            btnDashboard.Location = new Point(3, 4);
            btnDashboard.Margin = new Padding(3, 4, 3, 4);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(214, 57);
            btnDashboard.TabIndex = 0;
            btnDashboard.Text = "Dashboard";
            btnDashboard.TextAlign = ContentAlignment.MiddleLeft;
            btnDashboard.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnDashboard.UseVisualStyleBackColor = true;
            // 
            // btnPatients
            // 
            btnPatients.Cursor = Cursors.Hand;
            btnPatients.FlatStyle = FlatStyle.Flat;
            btnPatients.Image = Properties.Resources.ico_Patients;
            btnPatients.ImageAlign = ContentAlignment.MiddleLeft;
            btnPatients.Location = new Point(3, 69);
            btnPatients.Margin = new Padding(3, 4, 3, 4);
            btnPatients.Name = "btnPatients";
            btnPatients.Size = new Size(214, 57);
            btnPatients.TabIndex = 1;
            btnPatients.Text = "Patients";
            btnPatients.TextAlign = ContentAlignment.MiddleLeft;
            btnPatients.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnPatients.UseVisualStyleBackColor = true;
            // 
            // btnDoctors
            // 
            btnDoctors.Cursor = Cursors.Hand;
            btnDoctors.FlatStyle = FlatStyle.Flat;
            btnDoctors.Image = Properties.Resources.ico_Doctors;
            btnDoctors.ImageAlign = ContentAlignment.MiddleLeft;
            btnDoctors.Location = new Point(3, 134);
            btnDoctors.Margin = new Padding(3, 4, 3, 4);
            btnDoctors.Name = "btnDoctors";
            btnDoctors.Size = new Size(214, 57);
            btnDoctors.TabIndex = 2;
            btnDoctors.Text = "Doctors";
            btnDoctors.TextAlign = ContentAlignment.MiddleLeft;
            btnDoctors.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnDoctors.UseVisualStyleBackColor = true;
            // 
            // btnAppointments
            // 
            btnAppointments.Cursor = Cursors.Hand;
            btnAppointments.FlatStyle = FlatStyle.Flat;
            btnAppointments.Image = Properties.Resources.ico_Appointments;
            btnAppointments.ImageAlign = ContentAlignment.MiddleLeft;
            btnAppointments.Location = new Point(3, 199);
            btnAppointments.Margin = new Padding(3, 4, 3, 4);
            btnAppointments.Name = "btnAppointments";
            btnAppointments.Size = new Size(214, 57);
            btnAppointments.TabIndex = 3;
            btnAppointments.Text = "Appointments";
            btnAppointments.TextAlign = ContentAlignment.MiddleLeft;
            btnAppointments.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAppointments.UseVisualStyleBackColor = true;
            // 
            // pnlContent
            // 
            pnlContent.Dock = DockStyle.Fill;
            pnlContent.Location = new Point(217, 75);
            pnlContent.Margin = new Padding(3, 4, 3, 4);
            pnlContent.Name = "pnlContent";
            pnlContent.Size = new Size(697, 499);
            pnlContent.TabIndex = 2;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { lblStatusRecords });
            statusStrip1.Location = new Point(0, 574);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Padding = new Padding(1, 0, 16, 0);
            statusStrip1.Size = new Size(914, 26);
            statusStrip1.TabIndex = 3;
            statusStrip1.Text = "statusStrip1";
            // 
            // lblStatusRecords
            // 
            lblStatusRecords.Name = "lblStatusRecords";
            lblStatusRecords.Size = new Size(897, 20);
            lblStatusRecords.Spring = true;
            lblStatusRecords.Text = "Ready";
            lblStatusRecords.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(pnlContent);
            Controls.Add(pnlSidebar);
            Controls.Add(pnlHeader);
            Controls.Add(statusStrip1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "MainForm";
            Text = "MainForm";
            pnlHeader.ResumeLayout(false);
            flpLeft.ResumeLayout(false);
            flpLeft.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pblogo).EndInit();
            flpRight.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picUser).EndInit();
            pnlSidebar.ResumeLayout(false);
            flpSidebar.ResumeLayout(false);
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlHeader;
        private Panel pnlSidebar;
        private Panel pnlContent;
        private Button btnAppointments;
        private Button btnDoctors;
        private Button btnPatients;
        private Button btnDashboard;
        private FlowLayoutPanel flpSidebar;
        private FlowLayoutPanel flpRight;
        private FlowLayoutPanel flpLeft;
        private PictureBox pblogo;
        private PictureBox picUser;
        private Label lblAppTitle;
        private Label lblUser;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel lblStatusRecords;
    }
}