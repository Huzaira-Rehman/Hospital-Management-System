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
    public partial class AdmitPatient : Form
    {
        public AdmitPatient()
        {
            InitializeComponent();
        }

        private void AdmitPatient_Load(object sender, EventArgs e)
        {
            LoadPatients();
            LoadDoctors();
            LoadRooms();
             

        }

        void LoadPatients()
        {
            string q = "SELECT PatientID, Name FROM Patients";
            DataTable dt = DatabaseHelper.ReadData(q);

            cmbPatient.DataSource = dt;
            cmbPatient.DisplayMember = "Name";
            cmbPatient.ValueMember = "PatientID";
        }

        void LoadDoctors()
        {
            string q = "SELECT DoctorID, DoctorName FROM Doctors WHERE Status='Available'";
            DataTable dt = DatabaseHelper.ReadData(q);

            cmbDoctor.DataSource = dt;
            cmbDoctor.DisplayMember = "DoctorName";
            cmbDoctor.ValueMember = "DoctorID";
        }

        private void btnAdmit_Click(object sender, EventArgs e)
        {
            int patientId = Convert.ToInt32(cmbPatient.SelectedValue);
            int doctorId = Convert.ToInt32(cmbDoctor.SelectedValue);
            int roomId = Convert.ToInt32(cmbRoom.SelectedValue);

            // 1. Admit patient
            DatabaseHelper.Execute(
                "INSERT INTO AdmitPatients (PatientID, DoctorID, RoomID, AdmitDate, Status) VALUES (" +
                patientId + ", " +
                doctorId + ", " +
                roomId + ", GETDATE(), 'Admitted')"
            );

            // 2. Room occupied (SIRF ek dafa)
            DatabaseHelper.Execute(
                "UPDATE Rooms SET Status='Occupied' WHERE RoomID=" + roomId
            );

            MessageBox.Show("Patient admitted successfully!");
            LoadRooms();

            // 3. Doctor busy
            DatabaseHelper.Execute(
                "UPDATE Doctors SET Status='Busy' WHERE DoctorID=" + doctorId
            );


        }



        private void cmbRoom_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        void LoadRooms()
        {
            string q = "SELECT RoomID, RoomNo FROM Rooms WHERE Status='Available'";
            DataTable dt = DatabaseHelper.ReadData(q);

            cmbRoom.DataSource = dt;
            cmbRoom.DisplayMember = "RoomNo";
            cmbRoom.ValueMember = "RoomID";
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cmbPatient_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    }
}
