using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectExample
{
    public partial class Form1 : Form
    {
        Appointments appoint = new Appointments();
        Information info = new Information();
        Registration reg = new Registration();
        Login loginForm = new Login();
        PatientDetails patientDetail = new PatientDetails();
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void registry_Click(object sender, EventArgs e)
        {
            // MessageBox.Show("Registration Form");
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
            loginForm.Show();
        }

        private void infobtn_Click(object sender, EventArgs e)
        {
            info.Show();
        }

        private void patientDetails_Click(object sender, EventArgs e)
        {
            patientDetail.Show();
        }

        private void appointbtn_Click(object sender, EventArgs e)
        {
            appoint.Show();
        }
    }
}
