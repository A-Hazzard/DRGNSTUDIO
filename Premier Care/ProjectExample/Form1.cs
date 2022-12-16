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
            Registration reg = new Registration();

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

        private void loginBtn_Click(object sender, EventArgs e)//Changed to logout button
        {
            this.Hide();
            Login loginForm = new Login();

            loginForm.Show();
        }

        private void infobtn_Click(object sender, EventArgs e)
        {
            Staff staffMembers = new Staff();

            this.Hide();
            staffMembers.Show();
        }

      

        private void appointbtn_Click(object sender, EventArgs e)
        {
            Appointments appoint = new Appointments();

            this.Hide();
            appoint.Show();
        }

        private void medicineBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            medicine medicinePage = new medicine();


            medicinePage.Show();
        }
    }
}
