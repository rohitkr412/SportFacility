using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SA46Team10Bsports.uc.ucBook
{
    public partial class ucBookCourt : UserControl
    {
        public ucBookCourt()
        {
            InitializeComponent();
        }

        private void lookOutButton_Click(object sender, EventArgs e)
        {
            CIDLookoutForm cid = new CIDLookoutForm();
            cid.ShowDialog();
            this.CIDTextBox.Text = cid.CIDFromGrid.ToString();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            PopulateTimeSlot();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "")
            {
                string x = "Please choose a Hall";
                timeSlotListBox1.Items.Add(x);
                timeSlotListBox1.Show();
            }
            else
            {
                PopulateTimeSlot();
            }
        }

        public void PopulateTimeSlot()
        {
            SA46Team10BsportsEntities Content = new SA46Team10BsportsEntities();

            var qry2 = Content.TransactionTables.Where(x => x.CourtTable.CourtType == comboBox1.Text && x.DateBook == dateTimePicker1.Value.Date && x.Status == "Booked").Select(x => x.SlotTable.Time);
            var qry1 = Content.SlotTables.Select(x => x.Time).Except(qry2);

            timeSlotListBox1.DataSource = qry1.ToList();
        }
        
        private void button1_Click_1(object sender, EventArgs e)
        {
            SA46Team10BsportsEntities ctx = new SA46Team10BsportsEntities();
            TransactionTable tt = new TransactionTable();
            try
            {
                tt.CustomerID = Convert.ToInt32(CIDTextBox.Text);
                CourtTable ct = ctx.CourtTables.Where(x => x.CourtType == comboBox1.Text).First();
                tt.CourtTable = ct;
                tt.DateBook = dateTimePicker1.Value.Date;
                SlotTable st = ctx.SlotTables.Where(x => x.Time == timeSlotListBox1.Text).First();
                tt.SlotTable = st;
                tt.Status = "Booked";

                ctx.TransactionTables.Add(tt);
                ctx.SaveChanges();
                MessageBox.Show("Booking for " + comboBox1.Text + " on " + dateTimePicker1.Value.ToString("dd/MM/yyyy") + " at " + timeSlotListBox1.Text + " is completed.");
                ClearContent();
            }

            catch (System.FormatException)
            {
                MessageBox.Show("Please ensure all fields are manually selected");
            }
        }

        public void ClearContent()
        {
            CIDTextBox.Text = "";
            comboBox1.Text = "";
            timeSlotListBox1.DataSource = null;
            timeSlotListBox1.Items.Clear();

        }
        public void PopulateCourtTable()
        {
            string cons = "Data Source=(local);Initial Catalog=SA46Team10Bsports;Integrated Security=SSPI";
            SqlConnection con = new SqlConnection(cons);
            string sql = "select Courttype from CourtTable where flag = 'active' order by courttype";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader dr;
            con.Open();
            dr = cmd.ExecuteReader();
            comboBox1.Items.Clear();
            while (dr.Read())
            {
                string sname = dr.GetString(0);
                comboBox1.Items.Add(sname);
            }
            dr.Close();

        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            ClearContent();
        }
        
    }

}

