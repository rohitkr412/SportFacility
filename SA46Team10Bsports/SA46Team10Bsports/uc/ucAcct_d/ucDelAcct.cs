using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SA46Team10Bsports
{
    public partial class ucDelAcct : UserControl
    {
        public ucDelAcct()
        {
            InitializeComponent();
        }

        private void LookUpButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (!(string.IsNullOrWhiteSpace(CustomerIDTextBox.Text)))
                {
                    SA46Team10BsportsEntities ctx = new SA46Team10BsportsEntities();
                    int CID = Convert.ToInt32(CustomerIDTextBox.Text);
                    CustomerTable c = ctx.CustomerTables.Where(x => x.CustomerID == CID && x.Flag == "active").First();
                    LockCustomerIDTextBox();
                    FirstNameTextBox.Text = c.FirstName;
                    LastNameTextBox.Text = c.LastName;
                    PhoneTextBox.Text = c.PhoneNumber;
                    EmailTextBox.Text = c.Email;
                    AddressTextBox.Text = c.Address;
                    PostalCodeTextBox.Text = c.PostalCode;
                    CountyTextBox.Text = c.Country;
                }
                else
                {
                    CIDLookoutForm luf2 = new CIDLookoutForm();
                    luf2.ShowDialog();
                    this.CustomerIDTextBox.Text = luf2.CIDFromGrid; CustomerIDTextBox.Enabled = true;
                    if (CustomerIDTextBox.Text != " ")
                    { LockCustomerIDTextBox(); }
                    this.FirstNameTextBox.Text = luf2.FirstNameFromGrid;
                    this.LastNameTextBox.Text = luf2.LastNameFromGrid;
                    this.PhoneTextBox.Text = luf2.PhoneFromGrid;
                    this.EmailTextBox.Text = luf2.EmailFromGrid;
                    this.AddressTextBox.Text = luf2.AddressFromGrid;
                    this.PostalCodeTextBox.Text = luf2.PostalcodeFromGrid;
                    this.CountyTextBox.Text = luf2.CountryFromGrid;
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

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            SA46Team10BsportsEntities ctx = new SA46Team10BsportsEntities();
            int CID = Convert.ToInt32(CustomerIDTextBox.Text);
            CustomerTable c = ctx.CustomerTables.Where(x => x.CustomerID == CID).First();
            c.Flag = "inactive";
            ctx.SaveChanges();
            MessageBox.Show(c.FirstName + "'s id has been deleted");
            ClearContent();
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            ClearContent();
        }

        public void ClearContent()
        {
            CustomerIDTextBox.Text = "";
            FirstNameTextBox.Text = "";
            LastNameTextBox.Text = "";
            PhoneTextBox.Text = "";
            EmailTextBox.Text = "";
            AddressTextBox.Text = "";
            PostalCodeTextBox.Text = "";
            CountyTextBox.Text = "";
            CustomerIDTextBox.ReadOnly = false;
            CustomerIDTextBox.BackColor = System.Drawing.SystemColors.Window;
        }
        public void LockCustomerIDTextBox()
        {
            CustomerIDTextBox.ReadOnly = true;
            CustomerIDTextBox.BackColor = System.Drawing.SystemColors.GrayText;
        }
    }
}
