using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SA46Team10Bsports.uc.ucReport
{
    public partial class pieChart : Form
    {
        public pieChart()
        {
            InitializeComponent();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            DataSetPieChart ds = new DataSetPieChart();

            DataSetPieChartTableAdapters.TransactionTableTableAdapter tt = new DataSetPieChartTableAdapters.TransactionTableTableAdapter();
            tt.Fill(ds.TransactionTable);

            DataSetPieChartTableAdapters.CourtTableTableAdapter ct = new DataSetPieChartTableAdapters.CourtTableTableAdapter();
            ct.Fill(ds.CourtTable);

            crPieChart cr = new crPieChart();
            cr.SetDataSource(ds);
            crystalReportViewer1.ReportSource = cr;
        }
    }
}
