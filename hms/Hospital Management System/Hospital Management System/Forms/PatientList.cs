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
    public partial class PatientList : Form
    {
        public PatientList()
        {
            InitializeComponent();
        }

        private void PatientList_Load(object sender, EventArgs e)
        {
            cmbFilter.SelectedIndex = 0;
            LoadPatients();

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
        private void LoadPatients()
        {
            string q = "";

            if (cmbFilter.SelectedItem.ToString() == "All")
            {
                q = "SELECT * FROM Patients";
            }
            else
            {
                q =
                "SELECT P.* " +
                "FROM Patients P " +
                "INNER JOIN AdmitPatients A ON P.PatientID = A.PatientID " +
                "WHERE A.Status = '" + cmbFilter.SelectedItem.ToString() + "'";
            }

            DataTable dt = DatabaseHelper.ReadData(q);
            dataGridView1.DataSource = dt;
        }


        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(
    dataGridView1.SelectedRows[0].Cells["PatientID"].Value
);

            // Check if admitted
            DataTable dt = DatabaseHelper.ReadData(
                "SELECT * FROM AdmitPatients WHERE PatientID=" + id + " AND Status='Admitted'"
            );

            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Patient is currently admitted. Discharge first.");
                return;
            }

            // Safe delete
            DatabaseHelper.Execute("DELETE FROM Patients WHERE PatientID=" + id);
            LoadPatients();


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
             



        }

        private void cmbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadPatients();
            dataGridView1.ClearSelection();
            dataGridView1.CurrentCell = null;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dataGridView1.ClearSelection();
            dataGridView1.CurrentCell = null;
        }
    }
}
