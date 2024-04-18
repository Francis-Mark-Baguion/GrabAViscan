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
using GrabAViscan.Classes;
using GrabAViscan.Popup;
using Guna.UI.WinForms;

namespace GrabAViscan
{
    public partial class HomeFeed : UserControl
    {
        private Posting post;
        private DatabaseManagement db = new DatabaseManagement();
        private int id;
        private int uid;
        private int post_id;
        private int locId;
        private int locId2;
        Profile profile_pic;
        public HomeFeed(Posting post,int uid)
        {

            this.uid = db.getUserById(uid).User_id;
            InitializeComponent();
            new Posting(post);
            if(post != null && db.getUserById(post.User_id)!=null) 
            {
                this.post_id = post.Post_id;
                string loc = post.Near_pickUp;
                this.locId = (int)double.Parse(loc);
                string loc2 = post.Near_deliveryLocation;
                this.locId2 = (int)double.Parse(loc2);

                string pick = db.GetLocationByMatchingId(db.locations, locId).LocationName;
                string deliver = db.GetLocationByMatchingId(db.locations, locId2).LocationName;



                id = post.Post_id;
                SetImageFromByteArrayProfile(this.profile, db.getUserById(post.User_id).Profile_pic);
                this.Name_label.Text = db.getUserById(post.User_id).FirstName +""+ db.getUserById(post.User_id).LastName;
                this.TimeTxt.Text = "" + post.Date_posted;
                this.Category_label.Text = post.Category;
                this.descriptionTxt.Text = post.Description;
                SetImageFromByteArray(Image_cont, post.image);


                this.requestTxt.Text = post.Requested;
                this.quantityTxt.Text = post.Quantity;
                this.pickUpTxt.Text = pick + ": " + post.Pick_up;

                this.pickUpTxt.Text = deliver + ": " + post.Delivery_location;

                this.Fee.Text ="" +  post.Fee;
                this.deadline.Text = "" + post.Deadline;


                profile_pic = new Profile(db.getPostById(post_id));
                profile_pic.Hide();

            }
            

        }
        public void SetImageFromByteArrayProfile(GunaCirclePictureBox profile, byte[] byteArray)
        {
            if(byteArray!=null)
            {
                using (MemoryStream ms = new MemoryStream(byteArray))
                {
                    Image image = Image.FromStream(ms);
                    profile.Image = image;
                }
            }
            
        }


        public void SetImageFromByteArray(GunaPictureBox Image_cont, byte[] byteArray)
        {
            using (MemoryStream ms = new MemoryStream(byteArray))
            {
                Image image = Image.FromStream(ms);
                Image_cont.Image = image;
            }
        }

        private void Image_cont_Click(object sender, EventArgs e)
        {

        }

        private void gunaLabel4_Click(object sender, EventArgs e)
        {

        }

        private void gunaButton9_Click(object sender, EventArgs e)
        {
            
            db.updateAvailability(db.getPostById(this.id).Post_id, 1);
            db.AssignDeliver(db.getPostById(this.id).Post_id , uid);
            this.Hide();

        }

        private void viewProfile(object sender, EventArgs e)
        {
            if (profile_pic.Visible == false)
            {
                profile_pic.Show();
            }
            else
            {
                profile_pic.Hide();
            }
        }
    }
}
