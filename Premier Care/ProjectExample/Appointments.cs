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
            OracleDataAdapter oda = new OracleDataAdapter("INSERT INTO appointment VALUES(appID.nextval, pat_num.nextval, '" + nameInput.Text + "', '" + dobInput.Text + "', '" + phoneInput.Text + "', '" + allergiesInput.Text + "','" + bloodtypeInput.Text + "', '" + doc_nameInput.Text+ "' ,'" + doc_emailInput.Text+ "','" + doc_positionInput.Text+ "'," + doc_idInput.Text + ", '" + timeInput.Text + "', '" + particularInput.Text + "', '" + serviceInput.Text + "')", con);

            DataTable dt = new DataTable();
            oda.Fill(dt);
        }
    }
}
