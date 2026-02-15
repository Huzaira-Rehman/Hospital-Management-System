using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hospital_Management_System.Helpers;


namespace Hospital_Management_System.Forms
{
    public partial class DoctorAdd : Form
    {
        public DoctorAdd()
        {
            InitializeComponent();
        }

        private void DoctorAdd_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtDoctorName.Text == "" || txtSpecialization.Text == "" || txtContact.Text == "")
            {
                MessageBox.Show("Please fill all fields.",
                                "Validation Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            string query =
            "INSERT INTO Doctors (DoctorName, Specialization, Contact, Status) VALUES ('" +
            txtDoctorName.Text + "', '" +
            txtSpecialization.Text + "', '" +
            txtContact.Text + "', 'Available')";

            DatabaseHelper.Execute(query);

            MessageBox.Show("Doctor added successfully.",
                            "Success",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);

            txtDoctorName.Text = "";
            txtSpecialization.Text = "";
            txtContact.Text = "";
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
