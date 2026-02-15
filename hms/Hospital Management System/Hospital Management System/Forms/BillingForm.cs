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
    public partial class BillingForm : Form
    {
        public BillingForm()
        {
            InitializeComponent();
        }

        // ================= FORM LOAD =================
        private void BillingForm_Load(object sender, EventArgs e)
        {
            LoadDischargedPatients();
        }

        void LoadDischargedPatients()
        {
            string q =
            "SELECT A.AdmitID, P.Name " +
            "FROM AdmitPatients A " +
            "INNER JOIN Patients P ON A.PatientID = P.PatientID " +
            "WHERE A.Status='Discharged'";

            DataTable dt = DatabaseHelper.ReadData(q);

            cmbPatient.DataSource = dt;
            cmbPatient.DisplayMember = "Name";
            cmbPatient.ValueMember = "AdmitID";
        }

        // ================= ROOM CHARGES AUTO =================
        private void cmbPatient_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbPatient.SelectedIndex == -1) return;

            int admitId = Convert.ToInt32(cmbPatient.SelectedValue);

            string q =
            "SELECT R.Charges, DATEDIFF(day, A.AdmitDate, A.DischargeDate) AS Days " +
            "FROM AdmitPatients A " +
            "INNER JOIN Rooms R ON A.RoomID = R.RoomID " +
            "WHERE A.AdmitID=" + admitId;

            DataTable dt = DatabaseHelper.ReadData(q);

            if (dt.Rows.Count > 0)
            {
                int perDay = Convert.ToInt32(dt.Rows[0]["Charges"]);
                int days = Convert.ToInt32(dt.Rows[0]["Days"]);
                txtRoomCharges.Text = (perDay * days).ToString();
            }
        }

        // ================= CALCULATE =================
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            int room, doctor;

            if (!int.TryParse(txtRoomCharges.Text, out room) ||
                !int.TryParse(txtDoctorCharges.Text, out doctor))
            {
                MessageBox.Show("Charges must be numbers only");
                return;
            }

            txtTotal.Text = (room + doctor).ToString();
        }

        // ================= GENERATE BILL =================
        private void btnGenerate_Click(object sender, EventArgs e)
        {
            if (cmbPatient.SelectedIndex == -1) return;
            if (cmbPatient.SelectedValue == null) return;
            if (cmbPatient.SelectedValue is DataRowView) return;

            int admitId = Convert.ToInt32(cmbPatient.SelectedValue);

            string q =
            "SELECT R.Charges, " +
            "CASE WHEN DATEDIFF(day, A.AdmitDate, A.DischargeDate) = 0 " +
            "THEN 1 ELSE DATEDIFF(day, A.AdmitDate, A.DischargeDate) END AS Days " +
            "FROM AdmitPatients A " +
            "INNER JOIN Rooms R ON A.RoomID = R.RoomID " +
            "WHERE A.AdmitID=" + admitId;

            DataTable dt = DatabaseHelper.ReadData(q);

            if (dt.Rows.Count > 0)
            {
                int perDay = Convert.ToInt32(dt.Rows[0]["Charges"]);
                int days = Convert.ToInt32(dt.Rows[0]["Days"]);
                txtRoomCharges.Text = (perDay * days).ToString();
                DatabaseHelper.Execute(q);

                MessageBox.Show("Bill generated successfully!");
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
 











