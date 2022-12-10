using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;
using System.Configuration;

namespace ProjectExample
{
    public partial class appointmentBTN : Form
    {
        OracleConnection con = new OracleConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString);
        Information info = new Information();
        Registration reg = new Registration();
        Login loginForm = new Login();
        PatientDetails patientDetail = new PatientDetails();
        Invoice inv = new Invoice();
        Appointments appoint = new Appointments();
        public appointmentBTN()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void registry_Click(object sender, EventArgs e)
        {
            // MessageBox.Show("Registration Form");
            this.Hide();
            reg.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            this.Hide(); 
            loginForm.Show();
        }

        private void infobtn_Click(object sender, EventArgs e)
        {
            info.Show();
        }

        private void patientDetails_Click(object sender, EventArgs e)
        {
            this.Hide();
            patientDetail.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            inv.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            appoint.Show();
        }

        private void moreDetails_Click(object sender, EventArgs e)
        {
            this.Hide();
            info.Show();
        }
    }
}
