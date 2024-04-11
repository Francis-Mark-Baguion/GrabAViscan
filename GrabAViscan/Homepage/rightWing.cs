using GrabAViscan.Classes;
using GrabAViscan.Popup;
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
    public partial class rightWing : UserControl
    {
        DatabaseManagement db = new DatabaseManagement();
        public Notification notif = new Notification();
        public Post post = new Post();
        public User user;
        private string email;
        bool flagnotif = false;
        bool flagpost = false;
        

        public rightWing()
        {
            InitializeComponent();

        }

        public void setter(string email)
        {
            user = db.InitializeUser(email);
            post.setter(email);
            this.email = email;
            this.nameHolder.Text = user.Username;
        }
        private void Notification_click(object sender, EventArgs e)
        {
            if(flagpost)
            {
                post.Hide();
                flagpost = false;
            }

            if(flagnotif)
            {
                notif.Hide();
                flagnotif = false;
            }
            else
            {
               
                notif.Show();
                flagnotif = true;
            }
              
        }

        private void EditPost_btn_Click(object sender, EventArgs e)
        {
           
            if(flagnotif) 
            {
                notif.Hide();
                flagnotif = false;
            }
            
            if(flagpost) 
            {
                post.Hide();
                flagpost = false;
            }
            else
            {
                post.Show();
                flagpost = true;  
            }
        }

    }
}
