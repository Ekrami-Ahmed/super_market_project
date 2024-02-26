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
    public partial class Form2 : Form
    {
        string ordb = "Data source=orcl;User Id=hr;Password=hr;";
        OracleConnection conn;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "single_row";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("c", textBox1.Text);
            cmd.Parameters.Add("name", OracleDbType.Varchar2, ParameterDirection.Output);
            int r = cmd.ExecuteNonQuery();
            if (r != -1)
            {    comboBox1.Items.Add(cmd.Parameters["name"].Value.ToString());
                MessageBox.Show("successfully");
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select p_name from product where p_category =:c";
            cmd.Parameters.Add("c", textBox1.Text.ToString());
            cmd.CommandType = CommandType.Text;
            OracleDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                comboBox1.Items.Add(dr[0]);
                MessageBox.Show("successfully");
            }
            dr.Close();

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select_product_name";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("c", textBox1.Text);
            cmd.Parameters.Add("name", OracleDbType.RefCursor, ParameterDirection.Output);
            OracleDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                comboBox1.Items.Add(dr[0]);
                MessageBox.Show("successfully");
            }
            dr.Close();
        }
    }
}
