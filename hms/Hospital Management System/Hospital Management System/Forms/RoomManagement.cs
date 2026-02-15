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
    public partial class RoomManagement : Form
    {
        public RoomManagement()
        {
            InitializeComponent();
        }

        private void RoomManagement_Load(object sender, EventArgs e)
        {
            LoadRooms();
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
        void LoadRooms()
        {
            string q = "SELECT RoomID, RoomNo, RoomType, Charges, Status FROM Rooms";
            dataGridView1.DataSource = DatabaseHelper.ReadData(q);
        }


        private void btnAddRoom_Click(object sender, EventArgs e)
        {
            int charges;
            if (!int.TryParse(txtCharges.Text, out charges))
            {
                MessageBox.Show("Charges must be numeric");
                return;
            }

            if (txtRoomNo.Text == "" || txtCharges.Text == "")
            {
                MessageBox.Show("Please fill all fields.",
                                "Validation Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            string q =
            "INSERT INTO Rooms (RoomNo, RoomType, Charges, Status) VALUES ('" +
            txtRoomNo.Text + "', '" +
            cmbRoomType.Text + "', " +
            txtCharges.Text + ", 'Available')";

            DatabaseHelper.Execute(q);

            MessageBox.Show("Room added successfully.",
                            "Success",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);

            txtRoomNo.Text = "";
            txtCharges.Text = "";
            cmbRoomType.SelectedIndex = -1;

            LoadRooms();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


    }
}
