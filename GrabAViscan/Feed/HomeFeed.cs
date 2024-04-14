﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
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
        public HomeFeed(Posting post,int uid)
        {

            this.uid = db.getUserById(uid).User_id;
            InitializeComponent();
            new Posting(post);
            if(post != null && db.getUserById(post.User_id)!=null) 
            {
                id = post.Post_id;
                SetImageFromByteArrayProfile(this.profile, db.getUserById(post.User_id).Profile_pic);
                this.Name_label.Text = db.getUserById(post.User_id).FirstName +""+ db.getUserById(post.User_id).LastName;
                this.TimeTxt.Text = "" + post.Date_posted;
                this.Category_label.Text = post.Category;
                this.descriptionTxt.Text = post.Description;
                SetImageFromByteArray(Image_cont, post.image);


                this.requestTxt.Text = post.Requested;
                this.quantityTxt.Text = post.Quantity;
                this.pickUpTxt.Text = post.Pick_up;
                this.pickNearbyTxt.Text = post.Near_pickUp;
                this.deliveryTxt.Text = post.Delivery_location;
                this.deliveryNearTxt.Text = post.Delivery_location;

                this.Fee.Text ="" +  post.Fee;
                this.deadline.Text = "" + post.Deadline;


            }
            

        }
        public void SetImageFromByteArrayProfile(GunaCirclePictureBox profile, byte[] byteArray)
        {
            using (MemoryStream ms = new MemoryStream(byteArray))
            {
                Image image = Image.FromStream(ms);
                profile.Image = image;
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

        }

        private void profile_Click(object sender, EventArgs e)
        {

        }
    }
}
