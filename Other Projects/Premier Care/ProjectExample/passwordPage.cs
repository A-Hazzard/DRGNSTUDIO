using Oracle.ManagedDataAccess.Client;
using ProjectExample.Properties;
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
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace ProjectExample
{

    public partial class passwordPage : Form
    {

        public passwordPage()
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
                this.Hide();
                Form1 home = new Form1();
                home.Show();
            }
            else
            {
                e.Cancel = true;
            }


        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
        OracleConnection con = new OracleConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString);


            con.Open();


            //Check to see if credentials match the db email and password
            OracleCommand command = new OracleCommand("Select * from admin where adminsecuritykey = '" + adminsecuritykey.Text + "'", con);
            OracleDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {
                ////OracleDataAdapter oda = new OracleDataAdapter("UPDATE password from admin SET password = '" + password.Text + "' WHERE securitykey = '" + securitykey.Text + "'", con);

                //DataTable dt = new DataTable();
                //oda.Fill(dt);

                OracleCommand updateCmd = new OracleCommand("UPDATE admin SET password = '" + password.Text + "' WHERE adminsecuritykey = '" + adminsecuritykey.Text + "'", con);
                updateCmd.ExecuteNonQuery();
                OracleDataReader reader2 = command.ExecuteReader();
                if (reader2.Read())
                {
                    MessageBox.Show("Password Changed");
                    
                }

            }
            else
            {
                MessageBox.Show("Invalid Email/Security Key");
            }
        
    }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();

            Form1 home = new Form1();

            home.Show();
        }

        private void passwordPage_Load(object sender, EventArgs e)
        {

        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
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

        private void cancelbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 home = new Form1();
            home.Show();
        }
    }
}
