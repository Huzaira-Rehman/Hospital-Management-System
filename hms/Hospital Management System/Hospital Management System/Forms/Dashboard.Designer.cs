namespace Hospital_Management_System.Forms
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.btnAddPatient = new System.Windows.Forms.Button();
            this.btnPatientList = new System.Windows.Forms.Button();
            this.btnAdmitPatient = new System.Windows.Forms.Button();
            this.btnDischargePatient = new System.Windows.Forms.Button();
            this.btnAddDoctor = new System.Windows.Forms.Button();
            this.btnDoctorList = new System.Windows.Forms.Button();
            this.btnRoom = new System.Windows.Forms.Button();
            this.btnBilling = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.panelSidebar = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelMain = new System.Windows.Forms.Panel();
            this.panelContent = new System.Windows.Forms.Panel();
            this.panelSidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAddPatient
            // 
            this.btnAddPatient.BackColor = System.Drawing.Color.Transparent;
            this.btnAddPatient.FlatAppearance.BorderSize = 0;
            this.btnAddPatient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddPatient.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddPatient.ForeColor = System.Drawing.Color.White;
            this.btnAddPatient.Location = new System.Drawing.Point(43, 72);
            this.btnAddPatient.Name = "btnAddPatient";
            this.btnAddPatient.Size = new System.Drawing.Size(134, 23);
            this.btnAddPatient.TabIndex = 0;
            this.btnAddPatient.Text = "Add Patient";
            this.btnAddPatient.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddPatient.UseVisualStyleBackColor = false;
            this.btnAddPatient.Click += new System.EventHandler(this.btnAddPatient_Click);
            this.btnAddPatient.MouseEnter += new System.EventHandler(this.SidebarButton_MouseEnter);
            this.btnAddPatient.MouseLeave += new System.EventHandler(this.SidebarButton_MouseLeave);
            // 
            // btnPatientList
            // 
            this.btnPatientList.BackColor = System.Drawing.Color.Transparent;
            this.btnPatientList.FlatAppearance.BorderSize = 0;
            this.btnPatientList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPatientList.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPatientList.ForeColor = System.Drawing.Color.White;
            this.btnPatientList.Location = new System.Drawing.Point(43, 114);
            this.btnPatientList.Name = "btnPatientList";
            this.btnPatientList.Size = new System.Drawing.Size(134, 23);
            this.btnPatientList.TabIndex = 1;
            this.btnPatientList.Text = "Patient List";
            this.btnPatientList.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPatientList.UseVisualStyleBackColor = false;
            this.btnPatientList.Click += new System.EventHandler(this.btnPatientList_Click);
            this.btnPatientList.MouseEnter += new System.EventHandler(this.SidebarButton_MouseEnter);
            this.btnPatientList.MouseLeave += new System.EventHandler(this.SidebarButton_MouseLeave);
            // 
            // btnAdmitPatient
            // 
            this.btnAdmitPatient.BackColor = System.Drawing.Color.Transparent;
            this.btnAdmitPatient.FlatAppearance.BorderSize = 0;
            this.btnAdmitPatient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdmitPatient.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdmitPatient.ForeColor = System.Drawing.Color.White;
            this.btnAdmitPatient.Location = new System.Drawing.Point(43, 158);
            this.btnAdmitPatient.Name = "btnAdmitPatient";
            this.btnAdmitPatient.Size = new System.Drawing.Size(134, 23);
            this.btnAdmitPatient.TabIndex = 2;
            this.btnAdmitPatient.Text = "Admit Patient";
            this.btnAdmitPatient.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdmitPatient.UseVisualStyleBackColor = false;
            this.btnAdmitPatient.Click += new System.EventHandler(this.btnAdmitPatient_Click);
            this.btnAdmitPatient.MouseEnter += new System.EventHandler(this.SidebarButton_MouseEnter);
            this.btnAdmitPatient.MouseLeave += new System.EventHandler(this.SidebarButton_MouseLeave);
            // 
            // btnDischargePatient
            // 
            this.btnDischargePatient.BackColor = System.Drawing.Color.Transparent;
            this.btnDischargePatient.FlatAppearance.BorderSize = 0;
            this.btnDischargePatient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDischargePatient.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDischargePatient.ForeColor = System.Drawing.Color.White;
            this.btnDischargePatient.Location = new System.Drawing.Point(43, 198);
            this.btnDischargePatient.Name = "btnDischargePatient";
            this.btnDischargePatient.Size = new System.Drawing.Size(134, 35);
            this.btnDischargePatient.TabIndex = 3;
            this.btnDischargePatient.Text = "Discharge Patient";
            this.btnDischargePatient.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDischargePatient.UseVisualStyleBackColor = false;
            this.btnDischargePatient.Click += new System.EventHandler(this.btnDischargePatient_Click);
            this.btnDischargePatient.MouseEnter += new System.EventHandler(this.SidebarButton_MouseEnter);
            this.btnDischargePatient.MouseLeave += new System.EventHandler(this.SidebarButton_MouseLeave);
            // 
            // btnAddDoctor
            // 
            this.btnAddDoctor.BackColor = System.Drawing.Color.Transparent;
            this.btnAddDoctor.FlatAppearance.BorderSize = 0;
            this.btnAddDoctor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddDoctor.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddDoctor.ForeColor = System.Drawing.Color.White;
            this.btnAddDoctor.Location = new System.Drawing.Point(43, 239);
            this.btnAddDoctor.Name = "btnAddDoctor";
            this.btnAddDoctor.Size = new System.Drawing.Size(119, 23);
            this.btnAddDoctor.TabIndex = 4;
            this.btnAddDoctor.Text = "Add Doctor";
            this.btnAddDoctor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddDoctor.UseVisualStyleBackColor = false;
            this.btnAddDoctor.Click += new System.EventHandler(this.btnAddDoctor_Click);
            this.btnAddDoctor.MouseEnter += new System.EventHandler(this.SidebarButton_MouseEnter);
            this.btnAddDoctor.MouseLeave += new System.EventHandler(this.SidebarButton_MouseLeave);
            // 
            // btnDoctorList
            // 
            this.btnDoctorList.BackColor = System.Drawing.Color.Transparent;
            this.btnDoctorList.FlatAppearance.BorderSize = 0;
            this.btnDoctorList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDoctorList.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDoctorList.ForeColor = System.Drawing.Color.White;
            this.btnDoctorList.Location = new System.Drawing.Point(43, 277);
            this.btnDoctorList.Name = "btnDoctorList";
            this.btnDoctorList.Size = new System.Drawing.Size(119, 30);
            this.btnDoctorList.TabIndex = 5;
            this.btnDoctorList.Text = "Doctor List";
            this.btnDoctorList.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDoctorList.UseVisualStyleBackColor = false;
            this.btnDoctorList.Click += new System.EventHandler(this.btnDoctorList_Click);
            this.btnDoctorList.MouseEnter += new System.EventHandler(this.SidebarButton_MouseEnter);
            this.btnDoctorList.MouseLeave += new System.EventHandler(this.SidebarButton_MouseLeave);
            // 
            // btnRoom
            // 
            this.btnRoom.BackColor = System.Drawing.Color.Transparent;
            this.btnRoom.FlatAppearance.BorderSize = 0;
            this.btnRoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRoom.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRoom.ForeColor = System.Drawing.Color.White;
            this.btnRoom.Location = new System.Drawing.Point(43, 313);
            this.btnRoom.Name = "btnRoom";
            this.btnRoom.Size = new System.Drawing.Size(119, 23);
            this.btnRoom.TabIndex = 6;
            this.btnRoom.Text = "Room Management";
            this.btnRoom.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRoom.UseVisualStyleBackColor = false;
            this.btnRoom.Click += new System.EventHandler(this.btnRoom_Click);
            this.btnRoom.MouseEnter += new System.EventHandler(this.SidebarButton_MouseEnter);
            this.btnRoom.MouseLeave += new System.EventHandler(this.SidebarButton_MouseLeave);
            // 
            // btnBilling
            // 
            this.btnBilling.BackColor = System.Drawing.Color.Transparent;
            this.btnBilling.FlatAppearance.BorderSize = 0;
            this.btnBilling.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBilling.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBilling.ForeColor = System.Drawing.Color.White;
            this.btnBilling.Location = new System.Drawing.Point(43, 351);
            this.btnBilling.Name = "btnBilling";
            this.btnBilling.Size = new System.Drawing.Size(122, 29);
            this.btnBilling.TabIndex = 8;
            this.btnBilling.Text = "Billing System";
            this.btnBilling.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBilling.UseVisualStyleBackColor = false;
            this.btnBilling.Click += new System.EventHandler(this.btnBilling_Click);
            this.btnBilling.MouseEnter += new System.EventHandler(this.SidebarButton_MouseEnter);
            this.btnBilling.MouseLeave += new System.EventHandler(this.SidebarButton_MouseLeave);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.Transparent;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(40, 425);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(122, 34);
            this.btnLogout.TabIndex = 9;
            this.btnLogout.Text = "Logout";
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            this.btnLogout.MouseEnter += new System.EventHandler(this.SidebarButton_MouseEnter);
            this.btnLogout.MouseLeave += new System.EventHandler(this.SidebarButton_MouseEnter);
            // 
            // panelSidebar
            // 
            this.panelSidebar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelSidebar.BackgroundImage")));
            this.panelSidebar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelSidebar.Controls.Add(this.label1);
            this.panelSidebar.Controls.Add(this.pictureBox1);
            this.panelSidebar.Controls.Add(this.btnAddPatient);
            this.panelSidebar.Controls.Add(this.btnLogout);
            this.panelSidebar.Controls.Add(this.btnPatientList);
            this.panelSidebar.Controls.Add(this.btnBilling);
            this.panelSidebar.Controls.Add(this.btnAdmitPatient);
            this.panelSidebar.Controls.Add(this.btnRoom);
            this.panelSidebar.Controls.Add(this.btnDischargePatient);
            this.panelSidebar.Controls.Add(this.btnDoctorList);
            this.panelSidebar.Controls.Add(this.btnAddDoctor);
            this.panelSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSidebar.Location = new System.Drawing.Point(0, 0);
            this.panelSidebar.Name = "panelSidebar";
            this.panelSidebar.Size = new System.Drawing.Size(233, 482);
            this.panelSidebar.TabIndex = 13;
            this.panelSidebar.Paint += new System.Windows.Forms.PaintEventHandler(this.panelSidebar_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(44, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 21);
            this.label1.TabIndex = 11;
            this.label1.Text = "Hospital Management";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(26, 24);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelMain.Controls.Add(this.panelContent);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(233, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(778, 482);
            this.panelMain.TabIndex = 14;
            this.panelMain.Paint += new System.Windows.Forms.PaintEventHandler(this.panelMain_Paint);
            // 
            // panelContent
            // 
            this.panelContent.BackColor = System.Drawing.Color.White;
            this.panelContent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelContent.Location = new System.Drawing.Point(19, 12);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(737, 458);
            this.panelContent.TabIndex = 0;
            this.panelContent.Paint += new System.Windows.Forms.PaintEventHandler(this.panelContent_Paint);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1011, 482);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelSidebar);
            this.IsMdiContainer = true;
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.panelSidebar.ResumeLayout(false);
            this.panelSidebar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAddPatient;
        private System.Windows.Forms.Button btnPatientList;
        private System.Windows.Forms.Button btnAdmitPatient;
        private System.Windows.Forms.Button btnDischargePatient;
        private System.Windows.Forms.Button btnAddDoctor;
        private System.Windows.Forms.Button btnDoctorList;
        private System.Windows.Forms.Button btnRoom;
        private System.Windows.Forms.Button btnBilling;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Panel panelSidebar;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelContent;
    }
}