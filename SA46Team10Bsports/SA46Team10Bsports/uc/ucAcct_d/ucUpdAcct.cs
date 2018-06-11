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
    public partial class ucUpdAcct : UserControl
    {
        public ucUpdAcct()
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
                    CustomerTable c = ctx.CustomerTables.Where(x => x.CustomerID == CID).First();
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
                    CIDLookoutForm luf = new CIDLookoutForm();
                    luf.ShowDialog();
                    this.CustomerIDTextBox.Text = luf.CIDFromGrid;
                    if (CustomerIDTextBox.Text != " ")
                    { LockCustomerIDTextBox(); }
                    this.FirstNameTextBox.Text = luf.FirstNameFromGrid;
                    this.LastNameTextBox.Text = luf.LastNameFromGrid;
                    this.PhoneTextBox.Text = luf.PhoneFromGrid;
                    this.EmailTextBox.Text = luf.EmailFromGrid;
                    this.AddressTextBox.Text = luf.AddressFromGrid;
                    this.PostalCodeTextBox.Text = luf.PostalcodeFromGrid;
                    this.CountyTextBox.Text = luf.CountryFromGrid;
                }
            }

            catch (System.ArgumentOutOfRangeException a)
            {
                MessageBox.Show("Please ensure all fields have relevant data before updating.");
            }

            catch (System.FormatException a)
            {
                MessageBox.Show("Please enter the correct ID");
            }

            catch (System.InvalidOperationException a)
            {
                MessageBox.Show("This ID does not exist");
            }
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            bool PhoneNumberOk = false;
            bool PostalCodeOk = false;

            int i;
            bool PhoneNumberisInteger = int.TryParse(PhoneTextBox.Text,out i);

            if(PhoneNumberisInteger)
            {
                if(PhoneTextBox.Text.Length == 8)
                {
                    PhoneNumberOk = true;
                }
                else
                {
                    MessageBox.Show("Phone Number must be exactly 8 digits");
                }
            }
            else
            {
                MessageBox.Show("Phone Number must be in digits (8 digits)");
            }

            int ii;
            bool PostalCodeIsInteger = int.TryParse(PostalCodeTextBox.Text, out ii);

            if (PostalCodeIsInteger)
            {
                if (PostalCodeTextBox.Text.Length == 6)
                {
                    PostalCodeOk = true;
                }
                else
                {
                    PostalCodeOk = false;
                    MessageBox.Show("Postal Code must be exactly 6 digits");
                }
            }
            else
            {
                PostalCodeOk = false;
                MessageBox.Show("Postal Code must be in digits (6 digits)");
            }



            if (PhoneNumberOk && PostalCodeOk)
            {
                try
                {
                    SA46Team10BsportsEntities ctx = new SA46Team10BsportsEntities();
                    int CID = Convert.ToInt32(CustomerIDTextBox.Text);
                    CustomerTable c = ctx.CustomerTables.Where(x => x.CustomerID == CID).First();
                    c.FirstName = FirstNameTextBox.Text;
                    c.LastName = LastNameTextBox.Text;
                    c.PhoneNumber = PhoneTextBox.Text;
                    c.Email = EmailTextBox.Text;
                    c.Address = AddressTextBox.Text;
                    c.PostalCode = PostalCodeTextBox.Text;
                    c.Country = CountyTextBox.Text;
                    ctx.SaveChanges();
                    MessageBox.Show("Update Successful");
                    ClearContent();
                }

                catch (System.ArgumentOutOfRangeException a)
                {
                    MessageBox.Show("Please ensure all fields are filled before updating");
                }

                catch (System.FormatException b)
                {
                    MessageBox.Show("Please ensure all fields are filled before updating");
                }
            }           
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
