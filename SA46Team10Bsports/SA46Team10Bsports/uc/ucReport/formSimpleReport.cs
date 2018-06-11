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
    public partial class formSimpleReport : Form
    {
        public formSimpleReport()
        {
            InitializeComponent();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            dsSimpleReport ds = new dsSimpleReport();
            dsSimpleReportTableAdapters.CustomerTableTableAdapter ct = new dsSimpleReportTableAdapters.CustomerTableTableAdapter();

            ct.Fill(ds.CustomerTable);

            crSimpleReport cr = new crSimpleReport();
            cr.SetDataSource(ds);
            crystalReportViewer1.ReportSource = cr;
        }
    }
}
