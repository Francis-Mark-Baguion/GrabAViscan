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
using System.Linq.Expressions;
using GrabAViscan.Classes.notif;
using GrabAViscan.Feed;



namespace GrabAViscan
{
    public partial class rightWing : UserControl
    {
        private DatabaseManagement db = new DatabaseManagement();
        public Notify notif;
        public Post post;
        private User user;
        private string email;
        private bool flagnotif = false;
        private bool flagpost = false;
        private Home form;

        public rightWing(Home home)
        {
            InitializeComponent();
            post = new Post(home);


            List<Promotion> promotions = db.GetPromotions();

            foreach (Promotion promotion in promotions) 
            {
                Recommended reco = new Recommended(promotion);
                flow1.Controls.Add(reco);
            }


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
            post.setter(email,form);
            this.email = email;
            this.nameHolder.Text = user.FirstName + " " + user.LastName;
            SetImageFromByteArrayProfile(this.ProfilePic, user.Profile_pic);
           this.form = form;
            notif = new Notify(this.user.User_id,form);

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
            try
            {
                /*if(post.IsDisposed)
                {
                    post = post = new Post();
                    post.setter(email, form);
                }
                */
                if (post.Visible)
                {
                    post.Hide();
                }
                else if (post.Visible == false)
                {
                    post.Show();
                    
                    if (notif.Visible)
                    {
                        notif.Hide();
                    }
                    
                }
            }
            catch(Exception ex) 
            {
                ErrorMessage err = new ErrorMessage(ex.Message);
            }
           

          
        }

        private void nameHolder_Click(object sender, EventArgs e)
        {

        }

        private void ProfilePic_Click(object sender, EventArgs e)
        {

            form.gunaButton9_Click(sender, e);
            
        }

        private void flow1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
