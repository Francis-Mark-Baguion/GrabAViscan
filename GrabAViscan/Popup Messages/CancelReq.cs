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

namespace GrabAViscan.Popup_Messages
{
    public partial class CancelReq : Form
    {

        private DatabaseManagement  db = new DatabaseManagement();
        private Posting post;
        private Home home;
        public CancelReq(Posting post,Home home)
        {
            InitializeComponent();
            this.post = post;
            this.home = home;
        }

        
        private void gunaLabel1_Click(object sender, EventArgs e)
        {

        }

       

        private void gunaButton3_Click(object sender, EventArgs e)
        {
            
            this.Close();
            
        }

        private void gunaButton4_Click(object sender, EventArgs e)
        {

            db.updatePostingInformation(post);
            home.My_Request(sender, e);
            this.Close();
        }
    }
}
