﻿using GrabAViscan.Classes;
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
using GrabAViscan.Popup;
using GrabAViscan.Popup_Messages;

namespace GrabAViscan.Feed
{
    public partial class FeedNoImage : UserControl
    {

        
        private DatabaseManagement db = new DatabaseManagement();
        private Posting post;
        private int id;
        private int uid;
        private int post_id;
        private int locId;
        private int locId2;
        private Profile profile_pic;
        
        public Home home;

        public FeedNoImage(Posting post, int uid,Home home)
        {
            this.home = home;
            this.uid = db.getUserById(uid).User_id;
            this.id = post.Post_id;
            InitializeComponent();
            this.post = post;
            if (post != null && db.getUserById(post.User_id) != null)
            {

                this.post_id = post.Post_id;
                string loc = post.Near_pickUp;
                this.locId = (int)double.Parse(loc);
                string loc2 = post.Near_deliveryLocation;
                this.locId2 = (int)double.Parse(loc2);

                string pick = db.GetLocationByMatchingId(db.locations, locId).LocationName;
                string deliver = db.GetLocationByMatchingId(db.locations, locId2).LocationName;
                SetImageFromByteArrayProfile(this.profile, db.getUserById(post.User_id).Profile_pic);
                this.Name_label.Text = db.getUserById(post.User_id).FirstName +""+ db.getUserById(post.User_id).LastName;
                this.TimeTxt.Text = post.Date_posted.ToString("MMMM dd, yyyy");
                this.Category_label.Text = post.Category;
                this.descriptionTxt.Text = post.Description;
                


                this.requestTxt.Text = post.Requested;
                this.quantityTxt.Text = post.Quantity;
                this.pickUpTxt.Text = pick + ": " +  post.Pick_up;
                this.deadline.Text = post.Deadline.ToString("MMMM dd, yyyy");
                this.deliveryTxt.Text = deliver + ": "+ post.Delivery_location;
                

                this.Fee.Text = "" + post.Fee;
                // this.deadline.Text = "" + post.Deadline;
                Category cat = db.GetCategoryByName(post.Category);
                SetImageFromByteArray(this.category, cat.categoryImage);

                
               


            }
        }



        public void SetImageFromByteArrayProfile(GunaCirclePictureBox profile, byte[] byteArray)
        {
            if (byteArray != null)
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

        private void gunaButton9_Click(object sender, EventArgs e)
        {
            AcceptRequest accept = new AcceptRequest(this.id, this.uid,this,home);
            
                
            

        }

        private void gunaButton2_Click(object sender, EventArgs e)
        {

        }

        private void viewProfile(object sender, EventArgs e)
        {
            profile_pic = new Profile(db.getPostById(post_id).User_id);
        }


        private void gunaLabel2_Click(object sender, EventArgs e)
        {

        }

        private void deadline_Click(object sender, EventArgs e)
        {

        }
    }
}
