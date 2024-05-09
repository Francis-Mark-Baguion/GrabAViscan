using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms;


namespace GrabAViscan.Popup
{

    public partial class SucMessage : Form
    {
        private System.Windows.Forms.Timer closeTimer;
        public SucMessage(string message)
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

        private void Message_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
