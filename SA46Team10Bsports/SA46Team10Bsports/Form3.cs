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
    public partial class loginForm : Form
    {
        public loginForm()
        {
            InitializeComponent();
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            rect.Width += 1;
            if (rect.Width >= 316)
            {
                timer3.Stop();

                mainForm fm = new mainForm();
                fm.ShowDialog();
            }
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            SA46Team10BsportsEntities context = new SA46Team10BsportsEntities();
            string userID = loginTBox.Text;
            string pw = passwordTBox.Text;

            try
            {
                var q = from x in context.UserMasters where x.LoginName.Equals(userID) select x;
                UserMaster obj = q.First();            

                if (obj.Password.Equals(pw))
                 {
                    
                    rect.Visible = true;
                    rectOuter.Visible = true;
                    timer3.Start();
                }

                else
                    MessageBox.Show("Incorrect User Name or Password!");
            }

            catch (System.InvalidOperationException exc)
            {
               System.InvalidOperationException e2 = exc;
               MessageBox.Show("Incorrect User Name or Password!");
            }
                
            
        }

        private void crossBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
