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
    public partial class medicine : Form
    {
        OracleConnection con = new OracleConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString);

        public medicine()
        {
            InitializeComponent();
            con.Open();
            OracleDataAdapter oda = new OracleDataAdapter("Select * from drug", con);
            OracleDataAdapter oda1 = new OracleDataAdapter("Select * from patient", con);


            DataTable dt = new DataTable();
            DataTable dt1 = new DataTable();

            oda.Fill(dt);
            oda1.Fill(dt1);


            showDrugs.DataSource = dt;
            showPatients.DataSource = dt1;


            con.Close();
        }

        private void showDrugs_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void showPatients_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            double num1 = Convert.ToDouble(num1Input.Text);
            double num2 = Convert.ToDouble(num2Input.Text);

            double answer = num1 + num2;
            feeInput.Text = answer.ToString(); 
        }

        private void button2_Click(object sender, EventArgs e)
        {

            OracleDataAdapter oda = new OracleDataAdapter("INSERT INTO treatment VALUES('"+ nameInput.Text + "', " + patientIDInput.Text + ", '" + drugInput.Text + "', " + drugIntakeInput.Text + ", " + feeInput.Text + ")", con);

            DataTable dt = new DataTable();
            oda.Fill(dt);

            MessageBox.Show("Drug given");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            treatmentHistory history = new treatmentHistory();
            history.Show();
        }
    }
}
