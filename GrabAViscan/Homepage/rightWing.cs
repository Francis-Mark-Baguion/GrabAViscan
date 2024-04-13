using GrabAViscan.Classes;
using GrabAViscan.Popup;
using Guna.UI.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GrabAViscan.Homepage;

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
        Home form;

        public rightWing( )
        {
            InitializeComponent();
            
            
            
        }

        public void Refresh()
        {
            post.Close();
            notif.Close();
            flagnotif = false;
            flagpost = false;
            
        }

        public void setter(string email,Home form)
        {
            user = db.InitializeUser(email);
            post.setter(email);
            this.email = email;
            this.nameHolder.Text = user.FirstName + " " + user.LastName;
            SetImageFromByteArrayProfile(this.ProfilePic, user.Profile_pic);
           this.form = form;

        }


        public void SetImageFromByteArrayProfile(GunaCirclePictureBox profile, byte[] byteArray)
        {
            if (byteArray != null)
                using (MemoryStream ms = new MemoryStream(byteArray))
                {
                    Image image = Image.FromStream(ms);
                    ProfilePic.Image = image;
                }
        }
        private void Notification_click(object sender, EventArgs e)
        {
            if (notif.Visible)
            {
                notif.Hide();
            }
            else if (notif.Visible == false)
            {
                notif.Show();

                if (post.Visible)
                {
                    post.Hide();
                }
            }

        }

        private void EditPost_btn_Click(object sender, EventArgs e)
        {
           
           if(post.Visible)
            {
                post.Hide();
            }
           else if(post.Visible == false)  
            {
                post.Show();

                if (notif.Visible)
                {
                    notif.Hide();
                }
            }

          
        }

        private void nameHolder_Click(object sender, EventArgs e)
        {

        }

        private void ProfilePic_Click(object sender, EventArgs e)
        {

            form.gunaButton9_Click(sender, e);
            
        }
    }
}
