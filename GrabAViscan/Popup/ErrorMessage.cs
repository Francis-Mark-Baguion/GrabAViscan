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
    public partial class ErrorMessage : Form
    {
        public ErrorMessage(string message)
        {
            InitializeComponent();
            Message.Text = message;
            this.Show();
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
