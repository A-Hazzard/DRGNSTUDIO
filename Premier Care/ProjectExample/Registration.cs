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
    public partial class Registration : Form
    {
       Login loginForm = new Login();
        OracleConnection con = new OracleConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString);

        public Registration()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<string> strings = new List<string>()
            {

            "NURSE",
            "X-RAY TECHNICIAN",
            "LAB TECHNICIAN",
            "THERAPIST",
            "CSR",
            "DOCTOR"
            };

            if (strings.Contains(positionInput.Text.ToUpper()))
            {
                OracleDataAdapter oda = new OracleDataAdapter("INSERT INTO staff VALUES(staffID.nextval, '" + nameInput.Text + "', '" + emailInput.Text + "', '" + positionInput.Text.ToUpper() + "')", con);

                DataTable dt = new DataTable();
                oda.Fill(dt);





                if (positionInput.Text.ToUpper() == "NURSE")
                {
                    OracleDataAdapter oda1 = new OracleDataAdapter("INSERT INTO nurse VALUES(nurseID.nextval, '" + nameInput.Text + "', '" + emailInput.Text + "', 'NURSE')", con);

                    DataTable dt1 = new DataTable();
                    oda1.Fill(dt1);

                }
                else if (positionInput.Text.ToUpper() == "X-RAY TECHNICIAN")
                {
                    OracleDataAdapter oda2 = new OracleDataAdapter("INSERT INTO XRay VALUES(xray_tech_ID.nextval, '" + nameInput.Text + "', '" + emailInput.Text + "', 'XRAY_TECHNCIAN')", con);
                    DataTable dt2 = new DataTable();
                    oda2.Fill(dt2);

                }
                else if (positionInput.Text.ToUpper() == "LAB TECHNICIAN")
                {
                    OracleDataAdapter oda3 = new OracleDataAdapter("INSERT INTO Lab VALUES(lab_tech_ID.nextval, '" + nameInput.Text + "', '" + emailInput.Text + "', 'LAB_TECHNCIAIN')", con);
                    DataTable dt3 = new DataTable();
                    oda3.Fill(dt3);

                }
                else if (positionInput.Text.ToUpper() == "THERAPIST")
                {
                    OracleDataAdapter oda4 = new OracleDataAdapter("INSERT INTO therapist VALUES(therapist_ID.nextval, '" + nameInput.Text + "', '" + emailInput.Text + "', 'THERAPIST')", con);
                    DataTable dt4 = new DataTable();
                    oda4.Fill(dt4);

                }
                else if (positionInput.Text.ToUpper() == "CSR")
                {
                    OracleDataAdapter oda5 = new OracleDataAdapter("INSERT INTO csr VALUES(csrID.nextval, '" + nameInput.Text + "', '" + emailInput.Text + "', 'CSR')", con);
                    DataTable dt5 = new DataTable();
                    oda5.Fill(dt5);

                }
                else if (positionInput.Text.ToUpper() == "DOCTOR")
                {
                    OracleDataAdapter oda6 = new OracleDataAdapter("INSERT INTO doctor VALUES(doctorID.nextval, '" + nameInput.Text + "', '" + emailInput.Text + "', 'DOCTOR')", con);
                    DataTable dt6 = new DataTable();
                    oda6.Fill(dt6);

                }
                else
                {
                    MessageBox.Show("Position Invalid. Valid Positions: Doctor, CSR,  THERAPIST, LAB TECHNICAIN, X-RAY TECHNICAIN AND NURSE");
                }
                MessageBox.Show("Seccessfull Registered " + nameInput.Text + " as a " + positionInput.Text);
            }
            else
            {
                MessageBox.Show("Position Invalid. Valid Positions: Doctor, CSR,  THERAPIST, LAB TECHNICAIN, X-RAY TECHNICAIN AND NURSE");
            }
            //View.DataSource = dt;
            emailInput.Text = "";
            nameInput.Text = "";
            positionInput.Text = "";
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 home = new Form1();
            this.Hide();
           home.Show();
        }
    }
    
}
