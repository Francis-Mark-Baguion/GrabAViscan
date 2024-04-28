using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GrabAViscan.Popup_Messages
{
    public partial class TermsAndCondition : Form
    {
        public TermsAndCondition(SignUp sign)
        {
            InitializeComponent();
            this.Owner = sign;
        }

        

        private void Close_btn_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
