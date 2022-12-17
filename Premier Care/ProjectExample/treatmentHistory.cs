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
            FormClosing += closeForm;

            con.Open();

            OracleDataAdapter oda = new OracleDataAdapter("Select * from treatment", con);
            DataTable dt = new DataTable();
            oda.Fill(dt);
            showTreatments.DataSource = dt;
            con.Close();


        }
        private void closeForm(object sender, FormClosingEventArgs e)
        {
            // Set the Cancel property to false to exit the program
            DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Confirm", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                this.Hide();
                Form1 home = new Form1();
                home.Show();
            }
            else
            {
                e.Cancel = true;
            }


        }

        private void showPatients_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
