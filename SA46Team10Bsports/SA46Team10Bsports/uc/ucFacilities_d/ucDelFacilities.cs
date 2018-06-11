using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SA46Team10Bsports.uc.ucFacilities
{
    public partial class ucDelFacilities : UserControl
    {
        public ucDelFacilities()
        {
            InitializeComponent();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (!(string.IsNullOrWhiteSpace(courtIDTextBox.Text)))
                {
                    SA46Team10BsportsEntities ctx = new SA46Team10BsportsEntities();
                    int CID = Convert.ToInt32(courtIDTextBox.Text);
                    CourtTable c = ctx.CourtTables.Where(x => x.CourtID == CID && x.Flag == "active").First();
                    LockCourtIDTextBox();
                    courtNameTextBox2.Text = c.CourtType;
                    sportTextBox4.Text = c.SportsType;
                    lastDOM.Text = c.MaintDate.Value.ToString("dd-MM-yyyy");
                    remarksTextBox.Text = c.Remarks;
                }
                else
                {
                    CourtLookOutFormcs clof = new CourtLookOutFormcs();
                    clof.ShowDialog();
                    LockCourtIDTextBox();
                    this.courtIDTextBox.Text = clof.CIDFromGrid;
                    this.courtNameTextBox2.Text = clof.CTFromGrid;
                    this.sportTextBox4.Text = clof.STFromGrid;
                    this.lastDOM.Text = clof.MDFromGrid;
                    this.remarksTextBox.Text = clof.RFromGrid;
                }
            }
            catch (System.ArgumentOutOfRangeException)
            {
                MessageBox.Show("Please ensure all fields have relevant data before updating.");
            }

            catch (System.FormatException)
            {
                MessageBox.Show("Please enter the correct ID");
            }
            catch (System.InvalidOperationException)
            {
                MessageBox.Show("This ID does not exist");
            }
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            ClearContent();
        }

        private void deleteButtom_Click(object sender, EventArgs e)
        {
            SA46Team10BsportsEntities ctx = new SA46Team10BsportsEntities();
            int CID = Convert.ToInt32(courtIDTextBox.Text);
            CourtTable c = ctx.CourtTables.Where(x => x.CourtID == CID && x.Flag == "active").First();
            c.Flag = "inactive";
            ctx.SaveChanges();
            MessageBox.Show(c.CourtType + " record has been deleted");
            ClearContent();
        }
        public void ClearContent()
        {
            courtIDTextBox.Text = "";
            courtNameTextBox2.Text = "";
            sportTextBox4.Text = "";
            remarksTextBox.Text = "";
            courtIDTextBox.ReadOnly = false;
            courtIDTextBox.BackColor = System.Drawing.SystemColors.Window;
        }
        public void LockCourtIDTextBox()
        {
            courtIDTextBox.ReadOnly = true;
            courtIDTextBox.BackColor = System.Drawing.SystemColors.GrayText;
        }
    }
}
