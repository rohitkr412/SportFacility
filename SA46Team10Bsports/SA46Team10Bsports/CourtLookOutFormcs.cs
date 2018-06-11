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
    public partial class CourtLookOutFormcs : Form
    {
        public CourtLookOutFormcs()
        {
            InitializeComponent();
            var q = from s in ct.CourtTables select s;
            dataGridView1.DataSource = q.ToList();
        }

        SA46Team10BsportsEntities ct = new SA46Team10BsportsEntities();

        private void searchTextbox_TextChanged(object sender, EventArgs e)
        {
            var q = from s in ct.CourtTables
                    where (s.CourtType.Contains(searchTextbox.Text) ||
                    s.SportsType.Contains(searchTextbox.Text) &&
                    s.Flag == "active")
                    select s;

            dataGridView1.DataSource = q.ToList();
        }

        private void retrieveButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count != 1)
                MessageBox.Show("Please Select one row");
            else
                this.Close();
        }

        public string CIDFromGrid => dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
        public string CTFromGrid => dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
        public string STFromGrid => dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
        public string MDFromGrid => dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
        public string RFromGrid => dataGridView1.SelectedRows[0].Cells[4].Value.ToString();

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
