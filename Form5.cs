﻿using System;
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
    public partial class Form5 : Form
    {
        string ordb = "Data source=orcl;User Id=hr;Password=hr;";
        OracleConnection conn;
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "single_row";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("c", textBox1.Text.ToString());
            cmd.Parameters.Add("password", OracleDbType.Varchar2, ParameterDirection.Output);
            int r = cmd.ExecuteNonQuery();
            if (r != -1)
            {
                if (cmd.Parameters["password"].Value.ToString() == textBox2.Text)
                   MessageBox.Show("login successfully");
            }
        }
    }
}
