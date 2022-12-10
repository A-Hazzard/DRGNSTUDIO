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
    public partial class Invoice : Form
    {
        OracleConnection con = new OracleConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString);
        public Invoice()
        {
            InitializeComponent();
        }

    
        private void sendBTN_Click(object sender, EventArgs e)
        {
            //Load Button
            con.Open();

            /*when clicked will load the datain table table in the datagrid.
             First an object of the DataAdapter class will allow you to fetch the records*/
            OracleDataAdapter oda = new OracleDataAdapter("INSERT INTO invoice VALUES(" + inputID + ",'" + inputInvoice.Text + "')", con);

            DataTable dt = new DataTable();
            oda.Fill(dt);
            MessageBox.Show("Sent");


            con.Close();
        }

        private void inputID_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
