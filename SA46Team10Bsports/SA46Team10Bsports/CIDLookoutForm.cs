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
    public partial class CIDLookoutForm : Form
    {
        public CIDLookoutForm()
        {
            InitializeComponent();
            var q = from s in ct.CustomerTables select s;
            dataGridView1.DataSource = q.ToList();
        }

        SA46Team10BsportsEntities ct = new SA46Team10BsportsEntities();

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            var q = from s in ct.CustomerTables
                    where (s.FirstName.Contains(textBox1.Text) ||
                    s.LastName.Contains(textBox1.Text) ||
                    s.PhoneNumber.Contains(textBox1.Text) ||
                    s.PostalCode.Contains(textBox1.Text) ||
                    s.Address.Contains(textBox1.Text) ||
                    s.Email.Contains(textBox1.Text))
                    select s;

            dataGridView1.DataSource = q.ToList();
        }

        public delegate void delPassData(DataGridView text);

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count != 1)
                MessageBox.Show("Please Select one row");
            else
                this.Close();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
            dataGridView1.DataSource = null;

        }

        public string CIDFromGrid
        {
            get
            {
                if (dataGridView1.DataSource == null)
                { return " "; }
                else
                { return dataGridView1.SelectedCells[0].Value.ToString(); }
            }
        }
        public string FirstNameFromGrid
        {
            get
            {
                if (dataGridView1.DataSource == null)
                { return " "; }
                else
                { return dataGridView1.SelectedCells[1].Value.ToString(); }
            }
        }
        public string LastNameFromGrid
        {
            get
            {
                if (dataGridView1.DataSource == null)
                { return " "; }
                else
                { return dataGridView1.SelectedCells[2].Value.ToString(); }
            }
        }
        public string PhoneFromGrid
        {
            get
            {
                if (dataGridView1.DataSource == null)
                { return " "; }
                else
                { return dataGridView1.SelectedCells[8].Value.ToString(); }
            }
        }
        public string EmailFromGrid
        {
            get
            {
                if (dataGridView1.DataSource == null)
                { return " "; }
                else
                { return dataGridView1.SelectedCells[9].Value.ToString(); }
            }
        }
        public string AddressFromGrid
        {
            get
            {
                if (dataGridView1.DataSource == null)
                { return " "; }
                else
                { return dataGridView1.SelectedCells[5].Value.ToString(); }
            }
        }

        public string PostalcodeFromGrid
        {
            get
            {
                if (dataGridView1.DataSource == null)
                { return " "; }
                else
                { return dataGridView1.SelectedCells[6].Value.ToString(); }
            }
        }

        public string CountryFromGrid
        {
            get
            {
                if (dataGridView1.DataSource == null)
                { return " "; }
                else
                { return dataGridView1.SelectedCells[7].Value.ToString(); }
            }
        }

    }
}
