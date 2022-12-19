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
    public partial class Staff : Form
    {
        OracleConnection con = new OracleConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString);
        public Staff()
        {
            InitializeComponent();
            con.Open();
            FormClosing += closeForm;


            /*when clicked will load the datain table table in the datagrid.
             First an object of the DataAdapter class will allow you to fetch the records*/
            OracleDataAdapter oda = new OracleDataAdapter("Select * from staff", con);
            OracleDataAdapter oda1 = new OracleDataAdapter("Select * from doctor", con);
            OracleDataAdapter oda2 = new OracleDataAdapter("Select * from nurse", con);
            OracleDataAdapter oda3 = new OracleDataAdapter("Select * from therapist", con);
            OracleDataAdapter oda4 = new OracleDataAdapter("Select * from lab", con);
            OracleDataAdapter oda5 = new OracleDataAdapter("Select * from xray", con);
            OracleDataAdapter oda6 = new OracleDataAdapter("Select * from csr", con);

            DataTable dt = new DataTable();
            DataTable dt1 = new DataTable();
            DataTable dt2 = new DataTable();
            DataTable dt3 = new DataTable();
            DataTable dt4 = new DataTable();
            DataTable dt5 = new DataTable();
            DataTable dt6 = new DataTable();

            oda.Fill(dt);
            oda1.Fill(dt1);
            oda2.Fill(dt2);
            oda3.Fill(dt3);
            oda4.Fill(dt4);
            oda5.Fill(dt5);
            oda6.Fill(dt6);

            ShowMembers.DataSource = dt;
            showDoctors.DataSource = dt1;
            showNurses.DataSource = dt2;
            showTherapist.DataSource = dt3;
            showLabTechnicians.DataSource = dt4;
            showXRayTechnicians.DataSource = dt5;
            showCsr.DataSource = dt6;

            con.Close();

        }
        private void closeForm(object sender, FormClosingEventArgs e)
        {
            // Set the Cancel property to false to exit the program
            DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Confirm", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Environment.Exit(0);

            }
            else
            {
                e.Cancel = true;
            }


        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void medicineBtn_Click(object sender, EventArgs e)
        {
            medicine medpage = new medicine();

            this.Hide();
            medpage.Show();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login logout = new Login();

            logout.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 home = new Form1();

            home.Show();
        }

        private void registry_Click(object sender, EventArgs e)
        {
            this.Hide();
            Registration reg = new Registration();

            reg.Show();
        }

        private void infobtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Staff staffPage = new Staff();

            staffPage.Show();
        }

        private void appointbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Appointments appoint = new Appointments();

            appoint.Show();
        }

        private void Staff_Load(object sender, EventArgs e)
        {

        }

        private void medicineBtn_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            medicine medic = new medicine();
            medic.Show();
        }

        private void loginBtn_Click_1(object sender, EventArgs e)
        {
            Login logout = new Login();
            this.Hide();
            logout.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            passwordPage pwd = new passwordPage();
            this.Hide();
            pwd.Show();
        }

        private void registry_Click_1(object sender, EventArgs e)
        {
            Registration reg = new Registration();
            this.Hide();
            reg.Show();
        }

        private void infobtn_Click_1(object sender, EventArgs e)
        {
            Staff staff = new Staff();
            this.Hide();
            staff.Show();
        }

        private void appointbtn_Click_1(object sender, EventArgs e)
        {
            Appointments appoint = new Appointments();
            this.Hide();

            appoint.Show();
        }
    }
}
