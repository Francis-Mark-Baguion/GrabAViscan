using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GrabAViscan
{
    public partial class Intro : Form
    {
        public Intro()
        {
            InitializeComponent();
            LogIn.FlatStyle = FlatStyle.Flat;
            LogIn.FlatAppearance.BorderSize = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            LogIn log = new LogIn();
            log.Show();
            this.Hide();
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void SignUp_Click(object sender, EventArgs e)
        {
            SignUp sign = new SignUp();
            sign.Show();
            this.Hide();   
        }
    }
}
