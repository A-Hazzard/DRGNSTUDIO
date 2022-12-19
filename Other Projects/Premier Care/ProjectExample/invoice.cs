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
    public partial class invoice : Form
    {
        OracleConnection con = new OracleConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString);

        public invoice()
        {
            InitializeComponent();
            FormClosing += closeForm;

            OracleDataAdapter oda = new OracleDataAdapter("Select * from invoice", con);
            DataTable dt = new DataTable();
            oda.Fill(dt);
            showInvoices.DataSource = dt;

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


        private void invoice_Load(object sender, EventArgs e)
        {

        }
    }
}
