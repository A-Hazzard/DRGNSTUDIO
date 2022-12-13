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
        }

        private void loadappbtn_Click(object sender, EventArgs e)
        {
            //Load Button
            con.Open();

            /*when clicked will load the datain table table in the datagrid.
             First an object of the DataAdapter class will allow you to fetch the records*/
            OracleDataAdapter oda = new OracleDataAdapter("Select * from appointment", con);

            DataTable dt = new DataTable();
            oda.Fill(dt);

            Show.DataSource = dt;

            con.Close();
        }

        private void createappbtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Connected :");


            /*when clicked will load the datain table table in the datagrid.
             First an object of the DataAdapter class will allow you to fetch the records*/
            OracleDataAdapter oda = new OracleDataAdapter("INSERT INTO appointment VALUES(appID.nextval, '" + insertPatNum.Text + "', '" + insertTime.Text + "', '" + insertParticulars.Text + "', '" + insertStaff.Text + "', '" + insertCSR.Text + "')", con);

            DataTable dt = new DataTable();
            oda.Fill(dt);

            Show.DataSource = dt;

            con.Close();
        }

        private void Show_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
