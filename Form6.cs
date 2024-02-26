using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace super_market_project
{
    public partial class Form6 : Form
    {
        CrystalReport1 CR;
        CrystalReport2 cr;
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            CR = new CrystalReport1();
            cr = new CrystalReport2();
        }

        private void prodect_view_Click(object sender, EventArgs e)
        {
            crystalReportViewer1.ReportSource = CR;

        }
        private void orderinfo_Click(object sender, EventArgs e)
        {
            crystalReportViewer2.ReportSource = cr;

        }


    }
}