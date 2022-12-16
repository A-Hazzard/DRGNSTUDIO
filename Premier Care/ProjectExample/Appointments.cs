using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectExample
{
    public partial class Appointments : Form
    {
        OracleConnection con = new OracleConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString);
        public Appointments()
        {
            InitializeComponent();
            con.Open();

            /*when clicked will load the datain table table in the datagrid.
             First an object of the DataAdapter class will allow you to fetch the records*/
            OracleDataAdapter oda = new OracleDataAdapter("Select * from service", con);

            DataTable dt = new DataTable();
            oda.Fill(dt);

            Show.DataSource = dt;

            con.Close();
        }

   

   

        private void Show_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 home = new Form1();

            home.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OracleDataAdapter oda = new OracleDataAdapter("INSERT INTO appointment VALUES(appID.nextval, pat_num.nextval, '" + nameInput.Text + "', '" + dobInput.Text + "', '" + phoneInput.Text + "', '" + allergiesInput.Text + "','" + bloodtypeInput.Text + "', '" + doc_nameInput.Text+ "' ,'" + doc_emailInput.Text+ "','" + doc_positionInput.Text+ "'," + doc_idInput.Text + ", '" + timeInput.Text + "', '" + particularInput.Text + "', '" + serviceInput.Text.ToUpper() + "', " + serviceFeeInput.Text + ")", con);
            OracleDataAdapter oda1 = new OracleDataAdapter("INSERT INTO patient VALUES(pat_num.nextval, '" + nameInput.Text + "', '" + phoneInput.Text  + "', '" + dobInput.Text+ "', '" + allergiesInput.Text + "','" + bloodtypeInput.Text + "')", con);

            DataTable dt = new DataTable();
            DataTable dt1 = new DataTable();

            oda.Fill(dt);
            oda1.Fill(dt1);

            MessageBox.Show("Appointment made for " + nameInput.Text + " and Dr. " + doc_nameInput.Text);
        }

        private void serviceView_Click(object sender, EventArgs e)
        {
            con.Open();

            /*when clicked will load the datain table table in the datagrid.
             First an object of the DataAdapter class will allow you to fetch the records*/
            OracleDataAdapter oda = new OracleDataAdapter("Select * from service", con);

            DataTable dt = new DataTable();
            oda.Fill(dt);

            Show.DataSource = dt;

            con.Close();
        }

        private void Show_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void serviceFeeInput_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
