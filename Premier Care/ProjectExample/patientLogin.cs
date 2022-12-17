using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using Oracle.ManagedDataAccess.Client;

namespace ProjectExample
{
    public partial class patientLogin : Form
    {
        OracleConnection con = new OracleConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString);
        // OleDbDataAdapter da = new OleDbDataAdapter();
      

        public patientLogin()
        {
            InitializeComponent();
            FormClosing += closeForm;

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
        private void loginBtn_Click(object sender, EventArgs e)
        {
            invoice invoiceHome = new invoice();

            con.Open();


            //Check to see if credentials match the db email and password
            OracleCommand command = new OracleCommand("Select * from patient where pat_num = '" + idInput.Text + "' AND password = '" + passwordInput.Text + "'", con);
            OracleDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {
                MessageBox.Show("Logged in as patient");
                this.Hide();
                invoiceHome.Show();
            }
            else
            {
                MessageBox.Show("Invalid Email/Password");
            }






            con.Close();

        }

        private void cancelbtn_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login staffLogin = new Login();
            staffLogin.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
