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
    public partial class ucCrFacilities : UserControl
    {
        public ucCrFacilities()
        {
            InitializeComponent();
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            if (courtNameTextBox2.Text == "" || sportTextBox4.Text == "" || remarksTextBox.Text == "")
            { MessageBox.Show("Please fill in all fields!"); }

            else
            {
                SA46Team10BsportsEntities ctx = new SA46Team10BsportsEntities();
                CourtTable ct = new CourtTable();

                try
                {
                    ct.CourtType = courtNameTextBox2.Text;
                    ct.SportsType = sportTextBox4.Text;
                    ct.MaintDate = lastDOM.Value;
                    ct.Remarks = remarksTextBox.Text;
                    ct.Flag = "active";
                    ctx.CourtTables.Add(ct);
                    ctx.SaveChanges();
                    MessageBox.Show("New Court " + ct.CourtID + " successfully created!");
                    ClearContent();

                }

                catch (System.FormatException)
                {
                    MessageBox.Show("Please fill in the correct values for the fields!");
                }
            }
        }

        public void ClearContent()
        {
            courtNameTextBox2.Text = "";
            sportTextBox4.Text = "";
            remarksTextBox.Text = "";
        }


    }
}
