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
    public partial class logNotif : Form
    {
        private Home home;
        public logNotif(Home home)
        {
            InitializeComponent();
            this.home = home; 
            this.Owner = home;
        }

        private void gunaButton3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gunaButton4_Click(object sender, EventArgs e)
        {
            LogIn logIn = new LogIn();
            logIn.Show();
            this.home.Close();
            this.Close();
        }
    }
}
