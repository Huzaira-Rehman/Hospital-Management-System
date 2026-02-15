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
    public partial class DischargePatient : Form
    {
        public DischargePatient()
        {
            InitializeComponent();
        }

        private void DischargePatient_Load(object sender, EventArgs e)
        {
            LoadAdmittedPatients();
        }

        void LoadAdmittedPatients()
        {
            string q =
            "SELECT A.AdmitID, P.Name " +
            "FROM AdmitPatients A " +
            "INNER JOIN Patients P ON A.PatientID = P.PatientID " +
            "WHERE A.Status='Admitted'";

            DataTable dt = DatabaseHelper.ReadData(q);

            cmbAdmitPatient.DataSource = dt;
            cmbAdmitPatient.DisplayMember = "Name";
            cmbAdmitPatient.ValueMember = "AdmitID";
        }

        private void btnDischarge_Click(object sender, EventArgs e)
        {
            if (cmbAdmitPatient.SelectedIndex == -1)
            {
                MessageBox.Show("Please select patient");
                return;
            }

            int admitId = Convert.ToInt32(cmbAdmitPatient.SelectedValue);

            // 1. Discharge patient
            DatabaseHelper.Execute(
                "UPDATE AdmitPatients SET Status='Discharged', DischargeDate=GETDATE() " +
                "WHERE AdmitID=" + admitId
            );

            // 2. Free room
            DatabaseHelper.Execute(
                "UPDATE Rooms SET Status='Available' WHERE RoomID = " +
                "(SELECT RoomID FROM AdmitPatients WHERE AdmitID=" + admitId + ")"
            );

            // 3. Doctor available again
            DatabaseHelper.Execute(
                "UPDATE Doctors SET Status='Available' WHERE DoctorID = " +
                "(SELECT DoctorID FROM AdmitPatients WHERE AdmitID=" + admitId + ")"
            );


            MessageBox.Show("Patient discharged successfully!");

            LoadAdmittedPatients(); // refresh list
        }

    }
}
