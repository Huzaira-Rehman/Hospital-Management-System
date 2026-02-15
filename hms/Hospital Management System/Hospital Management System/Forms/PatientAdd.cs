using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Hospital_Management_System.Helpers;

namespace Hospital_Management_System.Forms
{
    public partial class PatientAdd : Form
    {
        public PatientAdd()
        {
            InitializeComponent();
        }

        private void txtName_TextChanged(object sender, EventArgs e) { }
        private void txtAge_TextChanged(object sender, EventArgs e) { }
        private void cmbGender_SelectedIndexChanged(object sender, EventArgs e) { }
        private void txtContact_TextChanged(object sender, EventArgs e) { }
        private void txtAddress_TextChanged(object sender, EventArgs e) { }
        private void txtDisease_TextChanged(object sender, EventArgs e) { }
        private void lblName_Click(object sender, EventArgs e) { }


        private void button1_Click(object sender, EventArgs e)
        {
            // 1️⃣ Validation
            if (txtName.Text == "" || txtAge.Text == "" || cmbGender.SelectedIndex == -1 ||
                txtContact.Text == "" || txtAddress.Text == "" || txtDisease.Text == "")
            {
                MessageBox.Show("Please fill all fields.");
                return;
            }

            int age;
            if (!int.TryParse(txtAge.Text, out age))
            {
                MessageBox.Show("Age must be a number.");
                return;
            }

            // 2️⃣ Insert Query
            string query =
                "INSERT INTO Patients (Name, Age, Gender, Contact, Address, Disease) VALUES (" +
                "'" + txtName.Text + "', " +
                age + ", " +
                "'" + cmbGender.Text + "', " +
                "'" + txtContact.Text + "', " +
                "'" + txtAddress.Text + "', " +
                "'" + txtDisease.Text + "')";

            // 3️⃣ Execute
            DatabaseHelper.Execute(query);

            MessageBox.Show("Patient added successfully!");

            ClearFields();
        }


        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        void ClearFields()
        {
            txtName.Clear();
            txtAge.Clear();
            cmbGender.SelectedIndex = -1;
            txtContact.Clear();
            txtAddress.Clear();
            txtDisease.Clear();
        }

        private void PatientAdd_Load(object sender, EventArgs e)
        {
             

        }
    }
}
