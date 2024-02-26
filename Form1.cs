using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;
namespace super_market_project
{
    public partial class Form1 : Form
    {
        string ordb = "Data source=orcl;User Id=hr;Password=hr;";
        OracleConnection conn;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "insert into customer values(c_id_s.nextval,:c_name,:c_email,:c_password,:c_card,:c_number)";
           
            cmd.Parameters.Add("name", textBox2.Text);
            cmd.Parameters.Add("email", textBox3.Text);
            cmd.Parameters.Add("password", textBox4.Text);
            cmd.Parameters.Add("card", textBox5.Text);
            cmd.Parameters.Add("number", textBox6.Text);
            int r = cmd.ExecuteNonQuery();
            if (r != -1)
            {
                MessageBox.Show("new account is added");
            }
           
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }
    }
}