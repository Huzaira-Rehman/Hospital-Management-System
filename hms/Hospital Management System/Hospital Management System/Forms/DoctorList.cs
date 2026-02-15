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
    public partial class DoctorList : Form
    {
        public DoctorList()
        {
            InitializeComponent();
        }

        private void DoctorList_Load(object sender, EventArgs e)
        {
            LoadDoctors();

            dataGridView1.EnableHeadersVisualStyles = false;

            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.MediumPurple;
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView1.ColumnHeadersDefaultCellStyle.Font =
                new Font("Segoe UI", 10, FontStyle.Bold);

            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;

            // 🔥 REAL FIX
            dataGridView1.ClearSelection();
            dataGridView1.CurrentCell = null;
            
        }

        void LoadDoctors()
        {
            string q =
            "SELECT DoctorID, DoctorName, Specialization, Contact, Status FROM Doctors";

            DataTable dt = DatabaseHelper.ReadData(q);
            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dataGridView1.ClearSelection();
            dataGridView1.CurrentCell = null;
        }  

    }
}
