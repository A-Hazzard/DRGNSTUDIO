using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;
using System.Configuration;


namespace ProjectExample
{
    public partial class PatientDetails : Form
    {
        OracleConnection con = new OracleConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString);
        public PatientDetails()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Load Button
            con.Open();

            MessageBox.Show("Connected :");
            

            /*when clicked will load the datain table table in the datagrid.
             First an object of the DataAdapter class will allow you to fetch the records*/
            OracleDataAdapter oda = new OracleDataAdapter("Select * from patientDetails", con);

            DataTable dt = new DataTable();
            oda.Fill(dt);

            View.DataSource = dt;

            con.Close();
        }

        private void PatientDetails_Load(object sender, EventArgs e)
        {

        }

        private void insertName_TextChanged(object sender, EventArgs e)
        {

        }

        private void insertDOB_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Connected :");


            /*when clicked will load the datain table table in the datagrid.
             First an object of the DataAdapter class will allow you to fetch the records*/
            OracleDataAdapter oda = new OracleDataAdapter("INSERT INTO patientDetails VALUES(pat#.nextval, '" + insertName.Text + "', '" + insertAddress.Text + "', '" + insertDOB.Text + "', '" + inputAllergies + "', '" + insertBloodtype + "')", con);

            DataTable dt = new DataTable();
            oda.Fill(dt);

            View.DataSource = dt;

            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
