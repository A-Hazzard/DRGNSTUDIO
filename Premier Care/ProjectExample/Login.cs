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
    public partial class Login : Form
    {
    OracleConnection con = new OracleConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString);
        // OleDbDataAdapter da = new OleDbDataAdapter();
        OleDbCommand cmd = new OleDbCommand();
        public Login()
        {


            FormClosing += closeForm;
            InitializeComponent();
        }
        private void closeForm(object sender, FormClosingEventArgs e)
        {
            // Set the Cancel property to false to exit the program
            Environment.Exit(0);

        }


        private void loginBtn_Click(object sender, EventArgs e)
        {
            Form1 home = new Form1();

           /* con.Open();

            
                //Check to see if credentials match the db email and password
                OracleCommand command = new OracleCommand("Select * from admin where email = '" + emailInput.Text + "' AND password = '" + passwordInput.Text + "'", con);
                OracleDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    //MessageBox.Show("Logged in");
                    this.Hide();
                    home.Show();
                }
                else
                {
                    MessageBox.Show("Invalid Email/Password");
                }
            */

            if(emailInput.Text == "care@gmail.com" && passwordInput.Text == "care123")
            {
                this.Hide();
                home.Show();
            }
            else
            {
                MessageBox.Show("Invalid Email/Password");
            }





            con.Close();
   
        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);   
        }

        private void Login_Load(object sender, EventArgs e)
        {
            
        }

        private void passwordInput_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void signUp_btn_Click(object sender, EventArgs e)
        {
            Registration signup = new Registration();
            this.Hide();
            signup.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            patientLogin pLogin = new patientLogin();
            pLogin.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            forgotpassword fGot = new forgotpassword();

            fGot.Show();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
    
    }

