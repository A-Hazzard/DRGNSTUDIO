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
    public partial class treatmentHistory : Form
    {
        OracleConnection con = new OracleConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString);

        public treatmentHistory()
        {
            InitializeComponent();
            con.Open();

            OracleDataAdapter oda = new OracleDataAdapter("Select * from treatment", con);
            DataTable dt = new DataTable();
            oda.Fill(dt);
            showTreatments.DataSource = dt;
            con.Close();


        }

        private void showPatients_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
