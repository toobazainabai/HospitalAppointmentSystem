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
            pnlHeader.SuspendLayout();
            flpLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pblogo).BeginInit();
            flpRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picUser).BeginInit();
            pnlSidebar.SuspendLayout();
            flpSidebar.SuspendLayout();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = SystemColors.Window;
            pnlHeader.Controls.Add(flpLeft);
            pnlHeader.Controls.Add(flpRight);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Padding = new Padding(12, 8, 12, 8);
            pnlHeader.Size = new Size(800, 56);
            pnlHeader.TabIndex = 0;
            // 
            // flpLeft
            // 
            flpLeft.Controls.Add(pblogo);
            flpLeft.Controls.Add(lblAppTitle);
            flpLeft.Dock = DockStyle.Left;
            flpLeft.Location = new Point(12, 8);
            flpLeft.Name = "flpLeft";
            flpLeft.Size = new Size(270, 40);
            flpLeft.TabIndex = 2;
            flpLeft.WrapContents = false;
            // 
            // pblogo
            // 
            pblogo.Image = Properties.Resources.ico_Hospital;
            pblogo.Location = new Point(3, 3);
            pblogo.Name = "pblogo";
            pblogo.Size = new Size(32, 32);
            pblogo.SizeMode = PictureBoxSizeMode.Zoom;
            pblogo.TabIndex = 0;
            pblogo.TabStop = false;
            // 
            // lblAppTitle
            // 
            lblAppTitle.AutoSize = true;
            lblAppTitle.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAppTitle.Location = new Point(41, 0);
            lblAppTitle.Name = "lblAppTitle";
            lblAppTitle.Padding = new Padding(8, 6, 0, 0);
            lblAppTitle.Size = new Size(228, 26);
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
            flpRight.Location = new Point(683, 8);
            flpRight.Name = "flpRight";
            flpRight.Size = new Size(105, 40);
            flpRight.TabIndex = 1;
            flpRight.WrapContents = false;
            // 
            // picUser
            // 
            picUser.Image = Properties.Resources.admin;
            picUser.Location = new Point(58, 4);
            picUser.Margin = new Padding(4);
            picUser.Name = "picUser";
            picUser.Padding = new Padding(5);
            picUser.Size = new Size(43, 34);
            picUser.TabIndex = 0;
            picUser.TabStop = false;
            // 
            // lblUser
            // 
            lblUser.AutoSize = true;
            lblUser.Dock = DockStyle.Fill;
            lblUser.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUser.Location = new Point(0, 0);
            lblUser.Name = "lblUser";
            lblUser.Padding = new Padding(0, 6, 8, 0);
            lblUser.Size = new Size(51, 42);
            lblUser.TabIndex = 1;
            lblUser.Text = "Admin";
            lblUser.TextAlign = ContentAlignment.MiddleCenter;
            lblUser.Click += lblUser_Click;
            // 
            // pnlSidebar
            // 
            pnlSidebar.BackColor = SystemColors.Window;
            pnlSidebar.Controls.Add(flpSidebar);
            pnlSidebar.Dock = DockStyle.Left;
            pnlSidebar.Location = new Point(0, 56);
            pnlSidebar.Name = "pnlSidebar";
            pnlSidebar.Size = new Size(190, 394);
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
            flpSidebar.Size = new Size(190, 394);
            flpSidebar.TabIndex = 0;
            flpSidebar.WrapContents = false;
            // 
            // btnDashboard
            // 
            btnDashboard.Cursor = Cursors.Hand;
            btnDashboard.FlatStyle = FlatStyle.Flat;
            btnDashboard.Image = Properties.Resources.ico_Dashboard;
            btnDashboard.ImageAlign = ContentAlignment.MiddleLeft;
            btnDashboard.Location = new Point(3, 3);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(187, 43);
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
            btnPatients.Location = new Point(3, 52);
            btnPatients.Name = "btnPatients";
            btnPatients.Size = new Size(187, 43);
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
            btnDoctors.Location = new Point(3, 101);
            btnDoctors.Name = "btnDoctors";
            btnDoctors.Size = new Size(187, 43);
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
            btnAppointments.Location = new Point(3, 150);
            btnAppointments.Name = "btnAppointments";
            btnAppointments.Size = new Size(187, 43);
            btnAppointments.TabIndex = 3;
            btnAppointments.Text = "Appointments";
            btnAppointments.TextAlign = ContentAlignment.MiddleLeft;
            btnAppointments.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAppointments.UseVisualStyleBackColor = true;
            // 
            // pnlContent
            // 
            pnlContent.Dock = DockStyle.Fill;
            pnlContent.Location = new Point(190, 56);
            pnlContent.Name = "pnlContent";
            pnlContent.Size = new Size(610, 394);
            pnlContent.TabIndex = 2;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pnlContent);
            Controls.Add(pnlSidebar);
            Controls.Add(pnlHeader);
            Name = "MainForm";
            Text = "MainForm";
            pnlHeader.ResumeLayout(false);
            flpLeft.ResumeLayout(false);
            flpLeft.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pblogo).EndInit();
            flpRight.ResumeLayout(false);
            flpRight.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picUser).EndInit();
            pnlSidebar.ResumeLayout(false);
            flpSidebar.ResumeLayout(false);
            ResumeLayout(false);
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
    }
}