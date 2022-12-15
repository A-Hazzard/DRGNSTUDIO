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


            FormClosing += MyForm_FormClosing;
            InitializeComponent();
        }
        private void MyForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Set the Cancel property to false to exit the program
            e.Cancel = false;
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            Form1 home = new Form1();

            con.Open();
           
            //Check to see if credentials match the db email and password
            OracleCommand command = new OracleCommand("Select * from admin where email = '" + emailInput.Text + "' AND password = '" + passwordInput.Text + "'", con);

            OracleDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {
                MessageBox.Show("Logged in");
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
    }
    
    }

