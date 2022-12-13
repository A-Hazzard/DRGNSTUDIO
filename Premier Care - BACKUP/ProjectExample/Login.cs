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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
namespace ProjectExample
{
    public partial class Login : Form
    {
   
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
            if (emailInput.Text == "premierecare@gmail.com" && passwordInput.Text == "premierecare")
            {
                MessageBox.Show("Login Success");
                this.Hide();
                home.Show();
            }
            else
            {
                MessageBox.Show("Invalid email/passowrd");
                
            }

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
    }
    
    }

