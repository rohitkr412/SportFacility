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
    public partial class crossTab : Form
    {
        public crossTab()
        {
            InitializeComponent();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            DataSetCrossTab ds = new DataSetCrossTab();

            DataSetCrossTabTableAdapters.CustomerTableTableAdapter ct = new DataSetCrossTabTableAdapters.CustomerTableTableAdapter();
            ct.Fill(ds.CustomerTable);

            DataSetCrossTabTableAdapters.TransactionTableTableAdapter tt = new DataSetCrossTabTableAdapters.TransactionTableTableAdapter();
            tt.Fill(ds.TransactionTable);

            DataSetCrossTabTableAdapters.CourtTableTableAdapter crtt = new DataSetCrossTabTableAdapters.CourtTableTableAdapter();
            crtt.Fill(ds.CourtTable);

            crCrossTab cr = new crCrossTab();
            cr.SetDataSource(ds);
            crystalReportViewer1.ReportSource = cr;
        }
    }
}
