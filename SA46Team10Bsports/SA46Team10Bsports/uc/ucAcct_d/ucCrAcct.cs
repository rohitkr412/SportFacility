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
    public partial class ucCrAcct : UserControl
    {
        public ucCrAcct()
        {
            InitializeComponent();
        }

        private void crAcctSaveBtn_Click(object sender, EventArgs e)
        {
            bool PhoneNumberOk = false;
            bool PostalCodeOk = false;

            int i;
            bool isPhoneNumberInteger = int.TryParse(phoneTBox.Text,out i);

            if(isPhoneNumberInteger)
            {
                if(phoneTBox.Text.Length==8)
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
                MessageBox.Show("Phone Number must be in digits (8 digits) ");
            }


            int ii;
            bool isPostalCodeInteger = int.TryParse(postalTBox.Text,out ii);

            if(isPostalCodeInteger)
            {
                if(postalTBox.Text.Length==6)
                {
                    PostalCodeOk = true;
                }
                else
                {
                    MessageBox.Show("Postal Code must be exactly 6 digits");
                }

            }
            else
            {
                MessageBox.Show("Postal Code must be in digits (6 digits) ");
            }

            if(PhoneNumberOk && PostalCodeOk)
            {
                if ((firstNameTBox.Text == "" || LastNameTBox.Text == "" || addressTBox.Text == "" || postalTBox.Text == "" || ctyTBox.Text == "") || (maleRadBtn.Checked == false && femaleRadBtn.Checked == false))
                { MessageBox.Show("Please fill in all fields!"); }
                else
                {
                    SA46Team10BsportsEntities ctx = new SA46Team10BsportsEntities();
                    CustomerTable c = new CustomerTable();

                    try
                    {
                        c.FirstName = firstNameTBox.Text;
                        c.LastName = LastNameTBox.Text;
                        c.DOB = Convert.ToDateTime(dobDatePicker.Text);
                        c.PhoneNumber = phoneTBox.Text;
                        c.Email = EmailTBox.Text;
                        c.Address = addressTBox.Text;
                        c.PostalCode = postalTBox.Text;
                        c.Country = ctyTBox.Text;

                        if (maleRadBtn.Checked == true)
                        {
                            c.Gender = "Male";
                        }
                        else
                        {
                            c.Gender = "Female";
                        }
                        ctx.CustomerTables.Add(c);
                        ctx.SaveChanges();
                        MessageBox.Show("User Account " + c.CustomerID + " successfully created!");
                        ClearContent();
                    }

                    catch (System.FormatException a)
                    {
                        MessageBox.Show("Please fill in all fields!");
                    }
                }
            }
        }

        public void ClearContent()
        {
            firstNameTBox.Text = "";
            LastNameTBox.Text = "";
            phoneTBox.Text = "";
            EmailTBox.Text = "";
            addressTBox.Text = "";
            postalTBox.Text = "";
            ctyTBox.Text = "";
        }
    }
}
