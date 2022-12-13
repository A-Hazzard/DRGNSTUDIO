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
    public partial class Registration : Form
    {
       Login loginForm = new Login();
        OracleConnection con = new OracleConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString);

        public Registration()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            OracleDataAdapter oda = new OracleDataAdapter("INSERT INTO staff VALUES(staffID.nextval, '" + emailInput.Text + "', '" + nameInput.Text + "')", con);

            DataTable dt = new DataTable();
            oda.Fill(dt);
            MessageBox.Show("Seccessfull Registered " + nameInput.Text);

            //View.DataSource = dt;
            emailInput.Text = "";
            nameInput.Text = "";

            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 home = new Form1();
            this.Hide();
           home.Show();
        }
    }
    
}
