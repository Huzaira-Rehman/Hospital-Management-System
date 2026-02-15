using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hospital_Management_System.Helpers;
using Hospital_Management_System.Forms;

 

namespace Hospital_Management_System
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MakePanel1Round(panel1, 35);
            MakePanel2Round(panel2, 35);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
         
        private void button1_Click(object sender, EventArgs e)
        {
            string user = txtUserName.Text;
            string pass = txtPassword.Text;

            string query = "SELECT * FROM Users WHERE Username='" + user + "' AND Password='" + pass + "'";


            DataTable dt = DatabaseHelper.ReadData(query);

            if (dt.Rows.Count > 0)
            {
                Dashboard dash = new Dashboard();
                dash.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Incorrect username or password");
            }
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void MakePanel1Round(Panel panel, int radius)
        {
            GraphicsPath path = new GraphicsPath();

            // Top-left corner (straight)
            path.AddLine(0, 0, panel.Width - radius, 0);

            // Top-right (rounded)
            path.AddArc(panel.Width - radius, 0, radius, radius, 270, 90);

            // Right side
            path.AddLine(panel.Width, radius, panel.Width, panel.Height - radius);

            // Bottom-right (rounded)
            path.AddArc(panel.Width - radius, panel.Height - radius, radius, radius, 0, 90);

            // Bottom-left (straight)
            path.AddLine(panel.Width - radius, panel.Height, 0, panel.Height);

            path.CloseFigure();
            panel.Region = new Region(path);
        }

        private void MakePanel2Round(Panel panel, int radius)
        {
            GraphicsPath path = new GraphicsPath();

            // Top-left (rounded)
            path.AddArc(0, 0, radius, radius, 180, 90);

            // Top-right (straight)
            path.AddLine(radius, 0, panel.Width, 0);

            // Right side
            path.AddLine(panel.Width, 0, panel.Width, panel.Height);

            // Bottom-right (straight)
            path.AddLine(panel.Width, panel.Height, radius, panel.Height);

            // Bottom-left (rounded)
            path.AddArc(0, panel.Height - radius, radius, radius, 90, 90);

            path.CloseFigure();
            panel.Region = new Region(path);
        }



    }
}
