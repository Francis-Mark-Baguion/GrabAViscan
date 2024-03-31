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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
            panel1.BackColor = ColorTranslator.FromHtml("#4C683E");
            rightWing.BackColor = ColorTranslator.FromHtml("#E0E0E0");
            LeftWing.BackColor = ColorTranslator.FromHtml("#E0E0E0");
            textBox1.BackgroundImage = Image.FromFile(@"C:\Users\user\source\repos\GrabAViscan\GrabAViscan\Resources\TextField.png");
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
