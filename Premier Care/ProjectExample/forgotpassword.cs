using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectExample
{
    public partial class forgotpassword : Form
    {
        OracleConnection con = new OracleConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString);

        public forgotpassword()
        {
            InitializeComponent();
            FormClosing += closeForm;

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            Login login = new Login();

            con.Open();


            //Check to see if credentials match the db email and password
            OracleCommand command = new OracleCommand("Select * from admin where email = '" + email.Text + "' AND securityKey = '" + securitykey.Text + "'", con);
            OracleDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {
                ////OracleDataAdapter oda = new OracleDataAdapter("UPDATE password from admin SET password = '" + password.Text + "' WHERE securitykey = '" + securitykey.Text + "'", con);

                //DataTable dt = new DataTable();
                //oda.Fill(dt);

                OracleCommand updateCmd = new OracleCommand("UPDATE admin SET password = '" + password.Text + "' WHERE securitykey = '" + securitykey.Text + "'", con);
                updateCmd.ExecuteNonQuery();
                OracleDataReader reader2 = command.ExecuteReader();
                if (reader2.Read())
                {
                    MessageBox.Show("Password Changed");
                    this.Hide();
                    login.Show();
                }
               
            }
            else
            {
                MessageBox.Show("Invalid Email/Security Key");
            }
        }

        private void closeForm(object sender, FormClosingEventArgs e)
        {
            // Set the Cancel property to false to exit the program
            DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Confirm", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                this.Hide();
                Form1 home = new Form1();
                home.Show();
            }
            else
            {
                e.Cancel = true;
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void cancelbtn_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void welcomeBackText_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void securitykey_TextChanged(object sender, EventArgs e)
        {

        }

        private void password_TextChanged(object sender, EventArgs e)
        {

        }

        private void email_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();

            Form1 home = new Form1();

            home.Show();
        }

        private void forgotpassword_Load(object sender, EventArgs e)
        {

        }
    }
}
