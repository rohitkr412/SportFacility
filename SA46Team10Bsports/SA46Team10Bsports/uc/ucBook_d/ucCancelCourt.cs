using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SA46Team10Bsports.uc.ucBook
{
    public partial class ucCancelCourt : UserControl
    {
        public ucCancelCourt()
        {
            InitializeComponent();
        }

       





        private void lookOutButton_Click(object sender, EventArgs e)
        {
            CIDLookoutForm cid = new CIDLookoutForm();
            cid.ShowDialog();
            this.CIDTextBox.Text = cid.CIDFromGrid.ToString();
        }


        
        private void SearchButton_Click(object sender, EventArgs e)
        {
            SA46Team10BsportsEntities context = new SA46Team10BsportsEntities();
            try
            {
                if (radioButton1.Checked == true)
                {
                    int CID = Convert.ToInt32(CIDTextBox.Text);
                    dataGridView1.DataSource = context.TransactionTables.Where(x => x.CustomerID == CID && x.Status == "Booked").Select(x => new { x.TransactionID, x.CustomerTable.FirstName, x.CustomerTable.LastName, x.CourtTable.CourtType, x.DateBook, x.SlotTable.Time }).ToList();

                }
                else if (radioButton2.Checked == true)
                {
                    int TransID = Convert.ToInt32(TransTextBox.Text);
                    dataGridView1.DataSource = context.TransactionTables.Where(x => x.TransactionID == TransID && x.Status == "Booked").Select(x => new { x.TransactionID, x.CustomerTable.FirstName, x.CustomerTable.LastName, x.CourtTable.CourtType, x.DateBook, x.SlotTable.Time }).ToList();

                }
            }


            catch (System.FormatException exc)
            {
                MessageBox.Show(exc.Message + "\nSearch for CustomerID and TransactionID only accept numbers");
            }
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            ClearContent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int TransID = Convert.ToInt32(dataGridView1.SelectedCells[0].FormattedValue.ToString());
                SA46Team10BsportsEntities context = new SA46Team10BsportsEntities();
                TransactionTable t = context.TransactionTables.Where(x => x.TransactionID == TransID).First();
                t.Status = "Cancelled";
                context.SaveChanges();
                MessageBox.Show("Transaction " + dataGridView1.SelectedCells[0].FormattedValue.ToString() + " has been cancelled.");
                ClearContent();
            }

            catch (System.IndexOutOfRangeException ex)
            {
                MessageBox.Show(ex.Message + "\nPlease select a row");
            }

            catch (System.ArgumentOutOfRangeException ex)
            {
                MessageBox.Show("\nPlease select a row before click on cancel");
            }

        }

        public void ClearContent()
        {
            CIDTextBox.Text = "";
            TransTextBox.Text = "";
            dataGridView1.DataSource = null;
            dataGridView1.Show();
        }
    
    }
}
