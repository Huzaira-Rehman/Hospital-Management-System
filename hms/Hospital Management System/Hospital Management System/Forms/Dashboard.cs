using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hospital_Management_System.Forms;


namespace Hospital_Management_System.Forms
{
    public partial class Dashboard : Form
    {

        void LoadForm(Form frm)
        {
            panelContent.Controls.Clear();
            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            panelContent.Controls.Add(frm);
            frm.Show();
        }

        public Dashboard()
        {
            InitializeComponent();
        }

        private void btnAddPatient_Click(object sender, EventArgs e)
        {
            SetActiveButton(btnAddPatient);
            LoadForm(new PatientAdd());
        }

        private void btnPatientList_Click(object sender, EventArgs e)
        {
            SetActiveButton(btnPatientList);
            LoadForm(new PatientList());
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
             
             
        }
         
        private void btnRoom_Click(object sender, EventArgs e)
        {
            SetActiveButton(btnRoom);
            LoadForm(new RoomManagement());
        }

        private void btnAdmitPatient_Click(object sender, EventArgs e)
        {
            SetActiveButton(btnAdmitPatient);
            LoadForm(new AdmitPatient());
        }

        private void btnDischargePatient_Click(object sender, EventArgs e)
        {
            SetActiveButton(btnDischargePatient);
            LoadForm(new DischargePatient());
        }

        private void btnAddDoctor_Click(object sender, EventArgs e)
        {
            SetActiveButton(btnAddDoctor);
            LoadForm(new DoctorAdd());
        }

        private void btnDoctorList_Click(object sender, EventArgs e)
        {
            SetActiveButton(btnDoctorList);
            LoadForm(new DoctorList());
        }

        private void btnBilling_Click(object sender, EventArgs e)
        {
            SetActiveButton(btnBilling);
            LoadForm(new BillingForm());
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            LoginForm l = new LoginForm();
            l.Show();
            this.Hide();
        }

        private void panelSidebar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void SidebarButton_MouseEnter(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (btn.BackColor.A < 100) // agar active nahi
                btn.BackColor = Color.FromArgb(60, 255, 255, 255);
        }

        private void SidebarButton_MouseLeave(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (btn.BackColor.A < 100) // active ko mat hatao
                btn.BackColor = Color.FromArgb(0, 0, 0, 0);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        void SetActiveButton(Button btn)
        {
            foreach (Control c in panelSidebar.Controls)
            {
                if (c is Button)
                {
                    c.BackColor = Color.FromArgb(0, 0, 0, 0);
                }
            }

            btn.BackColor = Color.FromArgb(120, 255, 255, 255); // visible highlight
            btn.BringToFront(); // ensure visibility
        }

        private void panelContent_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelMain_Paint(object sender, PaintEventArgs e)
        {

        }



    }
}
