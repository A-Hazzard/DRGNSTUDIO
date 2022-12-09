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
        Form1 home = new Form1();
        public Login()
        {
            InitializeComponent();
        }
        
        
        private void loginBtn_Click(object sender, EventArgs e)
        {
            if (emailInput.Text == "premierstaff@gmail.com" && passwordInput.Text == "premiercare123")
            {
                MessageBox.Show("Successful Login");
                home.Show();
            }
            else
            {
                MessageBox.Show("Invalid Credentials");
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

    }
    
    }

