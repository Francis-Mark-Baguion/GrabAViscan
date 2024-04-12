using GrabAViscan.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GrabAViscan.Popup
{
    public partial class ChangePass : Form
    {
        DatabaseManagement db = new DatabaseManagement();
        private string email;
        public ChangePass(string email)
        {
            InitializeComponent();
            this.email = email;

        }

        private void gunaLabel1_Click(object sender, EventArgs e)
        {

        }

        private void gunaButton4_Click(object sender, EventArgs e)
        {
            

        }

        private void gunaButton4_Click_1(object sender, EventArgs e)
        {
            if (db.changePass(email, this.Curr.Text, this.newPass.Text))
            {
                this.Hide();
            }
        }

        private void gunaButton3_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
