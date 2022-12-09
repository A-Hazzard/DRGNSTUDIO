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
    public partial class Information : Form
    {
        OracleConnection con = new OracleConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString);
        public Information()
        {
            InitializeComponent();
        }

        private void Information_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            OracleCommand oc = new OracleCommand("select name from staff", con);
            con.Open();

            //
            OracleDataReader odr = oc.ExecuteReader();

            //
            while (odr.Read())
            {
                //
                string name = odr["name"].ToString();

                //add items to lostbox
                Staff.Items.Add(name);
            }
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OracleCommand oc = new OracleCommand("select serve_type from service", con);
            con.Open();

            //
            OracleDataReader odr = oc.ExecuteReader();

            //
            while (odr.Read())
            {
                //
                string serve_type = odr["serve_type"].ToString();

                //add items to lostbox
                comboBox1.Items.Add(serve_type);
            }
            con.Close();
        }

        private void invoicebtn_Click(object sender, EventArgs e)
        {
            OracleDataAdapter oda = new OracleDataAdapter("Select * from invoice", con);

            DataTable dt = new DataTable();
            oda.Fill(dt);

            View.DataSource = dt;
        }
    }
}
