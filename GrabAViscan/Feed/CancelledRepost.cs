using GrabAViscan.Classes;
using GrabAViscan.Popup;
using GrabAViscan.Popup_Forms;
using Guna.UI.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GrabAViscan.Feed
{
    public partial class CancelledRepost : UserControl
    {
        private DatabaseManagement db = new DatabaseManagement();
        private int Post_id;
        private int locId;
        private int locId2;
        private Profile profile1;
        private int User_id;
        private Posting post;
        private Home home;
        private Post pst;
        private ViewPost view;
        public CancelledRepost(Posting post,int UID,Home home)
        {
            InitializeComponent();
            this.home = home;
            pst = new Post(post, home);
            
            view = new ViewPost(post, this.home, 1);
            this.post = post;
            this.Post_id = post.Post_id;
            this.User_id = UID;
            
            this.nameHolder.Text = db.getUserById(UID).FirstName + " " + db.getUserById(UID).LastName;
            SetImageFromByteArrayProfile(this.profile, db.getUserById(UID).Profile_pic);
            this.dateCompleted.Text = DateTime.Now.ToString("dd/MM/yyyy");
            this.categeryTxt.Text = post.Category;
            
            Category cat = db.GetCategoryByName(post.Category);
            SetImageFromByteArrayProfile(this.category, cat.categoryImage);
            
        }

        
        public void SetImageFromByteArrayProfile(GunaPictureBox profile, byte[] byteArray)
        {
            if (byteArray != null)
                using (MemoryStream ms = new MemoryStream(byteArray))
                {
                    Image image = Image.FromStream(ms);
                    profile.Image = image;
                }
        }

        public void SetImageFromByteArrayProfile(GunaCirclePictureBox profile, byte[] byteArray)
        {
            if (byteArray != null)
                using (MemoryStream ms = new MemoryStream(byteArray))
                {
                    Image image = Image.FromStream(ms);
                    profile.Image = image;
                }
        }

        private void upload_btn_Click(object sender, EventArgs e)   
        {
            
            
            Posting post = new Posting(db.getPostById(Post_id));
            string loc = post.Near_pickUp;
            this.locId = (int)double.Parse(loc);
            string loc2 = post.Near_deliveryLocation;
            this.locId2 = (int)double.Parse(loc2);

            string pick = db.GetLocationByMatchingId(db.locations, locId).LocationName;
            string deliver = db.GetLocationByMatchingId(db.locations, locId2).LocationName;
            post.Available = 0;
            post.Near_pickUp = pick;
            post.Near_deliveryLocation = deliver;

            if (pst.Visible == false)
            {
                pst.Show();
                pst.Visible = true;
            }
            else
            {
                pst.Visible = false;

            }

            //db.Post_upload(post);
        }

        private void profile_Click(object sender, EventArgs e)
        {
            profile1 = new Profile(User_id, home);
        }

        private void gunaElipsePanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Close_btn_Click(object sender, EventArgs e)
        {
           if (view.Visible == false)
            {
                view.Show();
                view.Visible = true;
            }
            else
            {
                view.Visible = false;

            }
        }
    }
}
