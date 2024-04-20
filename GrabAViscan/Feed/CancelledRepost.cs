﻿using GrabAViscan.Classes;
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
        public CancelledRepost(Posting post)
        {
            InitializeComponent();
            this.Post_id = post.Post_id;
            Label.Text = "CANCELLED";
            this.nameHolder.Text = db.getUserById(post.User_id).FirstName + " " + db.getUserById(post.User_id).LastName;
            SetImageFromByteArrayProfile(this.profile, db.getUserById(post.User_id).Profile_pic);
            this.dateCompleted.Text = DateTime.Now.ToString("dd/MM/yyyy");
            this.requestTxt.Text = post.Requested;
            
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
            repost_btn.Enabled = false;
            db.Post_upload(post);
        }
    }
}
