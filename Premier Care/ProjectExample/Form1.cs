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
            FormClosing += closeForm;


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
        private void closeForm(object sender, FormClosingEventArgs e)
        {
            // Set the Cancel property to false to exit the program
            DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Confirm", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                    Environment.Exit(0);

            }
            else
            {
                e.Cancel = true;
            }
           

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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            passwordPage passwordpg = new passwordPage();
            passwordpg.Show();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
