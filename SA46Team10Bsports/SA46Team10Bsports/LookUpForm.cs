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
    public partial class LookUpForm : Form
    {
        public LookUpForm()
        {
            InitializeComponent();
        }

        private void SearchBox_TextChanged_1(object sender, EventArgs e)
        {
            SA46Team10BsportsEntities context = new SA46Team10BsportsEntities();
            string s = "active";
            var q = from x in context.CustomerTables
                    where ((x.FirstName.Contains(SearchBox.Text) || x.LastName.Contains(SearchBox.Text) || x.Address.Contains(SearchBox.Text) || x.Email.Contains(SearchBox.Text) || x.PhoneNumber.Contains(SearchBox.Text))
                    && (x.Flag.Equals(s)))
                    select x;

            dataGridView1.DataSource = q.ToList();
        }

        private void RetrieveButton_Click_1(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count != 1)
                MessageBox.Show("Please Select one row");
            else
                this.Close();
        }

        //public string CIDFromGrid => dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
        //public string FirstNameFromGrid => dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
        //public string LastNameFromGrid => dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
        //public string PhoneFromGrid => dataGridView1.SelectedRows[0].Cells[8].Value.ToString();
        //public string EmailFromGrid => dataGridView1.SelectedRows[0].Cells[9].Value.ToString();
        //public string AddressFromGrid => dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
        //public string PostalcodeFromGrid => dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
        //public string CountryFromGrid => dataGridView1.SelectedRows[0].Cells[7].Value.ToString();

        private void CancelButton_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
