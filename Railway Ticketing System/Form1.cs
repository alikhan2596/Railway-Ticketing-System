using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Railway_Ticketing_System
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static string con_str = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\railway.mdb;";
        OleDbConnection conn = new OleDbConnection(con_str);

        private void bunifuMetroTextbox1_MouseEnter(object sender, EventArgs e)
        {
            if (bunifuMetroTextbox1.Text == "Username")
            {
                bunifuMetroTextbox1.Text = "";
            }
        }

        private void bunifuMetroTextbox1_MouseLeave(object sender, EventArgs e)
        {
            if (bunifuMetroTextbox1.Text == "")
            {
                bunifuMetroTextbox1.Text = "Username";
            }
        }

        private void bunifuMetroTextbox2_MouseEnter(object sender, EventArgs e)
        {
            if (bunifuMetroTextbox2.Text == "Password")
            {
                bunifuMetroTextbox2.Text = "";
            }
        }

        private void bunifuMetroTextbox2_MouseLeave(object sender, EventArgs e)
        {
            if (bunifuMetroTextbox2.Text == "")
            {
                bunifuMetroTextbox2.Text = "Password";
            }
        }

        private void bunifuMetroTextbox3_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'misProjDataSet.customer' table. You can move, or remove it, as needed.
            this.customerTableAdapter.Fill(this.misProjDataSet.customer);

        }

        private void bunifuMetroTextbox4_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuMetroTextbox6_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void bunifuTileButton1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void bunifuMetroTextbox15_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            string user = "select count(*) from [user] where U_email = '" + bunifuMetroTextbox1.Text + "' and U_password='" + bunifuMetroTextbox2.Text + "'";
            conn.Open();
            OleDbCommand cmd = new OleDbCommand();
            cmd.CommandText = user;
            cmd.Connection = conn;
            if ((int)cmd.ExecuteScalar() == 1)
            {
                MessageBox.Show("login successfull");
            }
            else
            {
                MessageBox.Show("uns");
            }
            conn.Close();

        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            conn.Open();
            OleDbCommand cmd = new OleDbCommand();
            string query1 = "SELECT count(*) FROM [User] where U_email='"+ bunifuMetroTextbox4.Text+"'";
            cmd.CommandText = query1;
            cmd.Connection = conn;

            if ((int)cmd.ExecuteScalar() > 0)
            {
                
                //label13.Visible = true;
                //label13.Text = "email already exist";
                conn.Close();
            }

            else
            {
                conn.Close();
                conn.Open();
                //OleDbCommand cmd = new OleDbCommand();
                //string table;
                //if (comboBox_jobtype.Text == "Admin")
                //    table = "Admin";
                //else
                //    table = "employee";

                string query2 = "insert into [User] (U_fname, U_lname, U_email, U_password, U_phone) values('" + bunifuMetroTextbox7.Text + "','" + bunifuMetroTextbox8.Text + "','" + bunifuMetroTextbox4.Text + "','" + bunifuMetroTextbox5.Text + "','" + bunifuMetroTextbox9.Text + "')";
                cmd.CommandText = query2;
                cmd.Connection = conn;
                MessageBox.Show(query2);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Data inserted!");
                    //panel_signup.Visible = false;
                    //panel_login.Visible = true;
                }

                conn.Close();
            }
        }
    }
}
