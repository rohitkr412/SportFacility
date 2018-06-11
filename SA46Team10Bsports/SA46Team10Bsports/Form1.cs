using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SA46Team10Bsports
{
    public partial class mainForm : Form
    {
        int panelWidth;
        bool Hidden;
        public mainForm()
        {
            InitializeComponent();
            panelWidth = panelSlide.Width;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Hidden)
            {
                panelSlide.Width = panelSlide.Width + 10;
                if (panelSlide.Width >= panelWidth)
                {
                    timer1.Stop();
                    Hidden = false;
                    this.Refresh();
                }
            }

            else
            {
                panelSlide.Width = panelSlide.Width - 10;
                if (panelSlide.Width <= 0)
                {
                    timer1.Stop();
                    Hidden = true;
                    this.Refresh();
                }
            }
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void miniBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void hamburgerBtn_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void homeBtn_Click(object sender, EventArgs e)
        {
            ucWallpaper1.BringToFront();
        }

        private void crAcctBtn_Click(object sender, EventArgs e)
        {
            ucCrAcct1.BringToFront();            
            ucCrAcct1.ClearContent();
 
        }

        private void updAcctBtn_Click(object sender, EventArgs e)
        {
            ucUpdAcct1.BringToFront();
            ucUpdAcct1.ClearContent();
        }

        private void delAcctBtn_Click(object sender, EventArgs e)
        {
            ucDelAcct1.BringToFront();
            ucDelAcct1.ClearContent();
        }

        private void crbookBtn_Click(object sender, EventArgs e)
        {
            ucBookCourt1.BringToFront();
            ucBookCourt1.ClearContent();
            ucBookCourt1.PopulateCourtTable();
        }

        private void viewBookBtn_Click(object sender, EventArgs e)
        {
            ucViewCourt1.BringToFront();
            ucViewCourt1.ClearContent();
            
        }

        private void cancelBookBtn_Click(object sender, EventArgs e)
        {
            ucCancelCourt1.BringToFront();
            /////////////////////////////////
            //ucCancelCourt1.ClearContent();
            /////////////////////////////////
        }

        private void crCourtBtn_Click(object sender, EventArgs e)
        {
            ucCrFacilities1.BringToFront();
            ucCrFacilities1.ClearContent();         
        }

        private void updCourtBtn_Click(object sender, EventArgs e)
        {
            ucUpdFacilities1.BringToFront();
            ucUpdFacilities1.ClearContent();
        }

        private void delCourtBtn_Click(object sender, EventArgs e)
        {
            ucDelFacilities1.BringToFront();
            ucDelFacilities1.ClearContent();
        }

        private void rptCustList_Click(object sender, EventArgs e)
        {
            uc.ucReport.formSimpleReport rptCL = new uc.ucReport.formSimpleReport();
            rptCL.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            uc.ucReport.pieChart rptPC = new uc.ucReport.pieChart();
            rptPC.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            uc.ucReport.crossTab rptCT = new uc.ucReport.crossTab();
            rptCT.ShowDialog();
        }
    }
}
