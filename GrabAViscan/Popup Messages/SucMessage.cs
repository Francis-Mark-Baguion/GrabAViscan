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
            closeTimer.Interval = 5000; // Set the interval to 5 seconds (5000 milliseconds)
            closeTimer.Tick += CloseTimer_Tick; // Add event handler for the Tick event

            // Start the timer when the form loads
            closeTimer.Start();
        }

        private void CloseTimer_Tick(object sender, EventArgs e)
        {
            // Stop the timer to prevent continuous closing
            closeTimer.Stop();

            // Close the form
            this.Close();
        }

        private void Message_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
