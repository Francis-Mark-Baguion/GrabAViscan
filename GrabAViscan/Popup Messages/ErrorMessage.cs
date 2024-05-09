using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GrabAViscan.Popup
{
    public partial class ErrorMessage : Form
    {


        private System.Windows.Forms.Timer closeTimer;
        public ErrorMessage(string message)
        {
            InitializeComponent();
            Message.Text = message;
            this.Show();

            closeTimer = new System.Windows.Forms.Timer();
            closeTimer.Interval = 5000; 
            closeTimer.Tick += CloseTimer_Tick; 

            
            closeTimer.Start();
        }

        private void CloseTimer_Tick(object sender, EventArgs e)
        {
            
            closeTimer.Stop();

            
            this.Close();
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ErrorMessage_Load(object sender, EventArgs e)
        {

        }

        private void gunaPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
