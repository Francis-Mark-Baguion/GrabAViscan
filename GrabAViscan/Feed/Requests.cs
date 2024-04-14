using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GrabAViscan.Classes;
using System.Drawing;
using Guna.UI.WinForms;
using System.IO;
using static Google.Protobuf.Reflection.SourceCodeInfo.Types;
using GrabAViscan.Popup;

namespace GrabAViscan.Feed
{
    public partial class Requests : UserControl
    {
        DatabaseManagement db = new DatabaseManagement();
        Category cat;
        private int locId;
        private int locId2;
        private int post_id;
        private Home home;
        public Requests(Posting post)
        {
            InitializeComponent();
            
            this.post_id = post.Post_id;
            string loc = post.Near_pickUp;
            this.locId = (int)double.Parse(loc);
            string loc2 = post.Near_deliveryLocation;
            this.locId2 = (int)double.Parse(loc2);
           
            string pick = db.GetLocationByMatchingId(db.locations, locId).LocationName;
            string deliver = db.GetLocationByMatchingId(db.locations, locId2).LocationName;
    

            statusTxt.Text = post.Requested;
            quantityTxt.Text = post.Quantity;
            
            pickNearbyTxt.Text = pick;
            
            deliveryNearTxt.Text = deliver;
            Category_label.Text = post.Category;

            
            
               cat = db.GetCategoryByName(post.Category);
               SetImageFromByteArrayProfile(this.profile, cat.categoryImage);

            if (post.Available == 0)
            {
                statusTxt.Text = "Waiting";
                statusTxt.BorderColor = Color.FromArgb(224, 207, 115);
            }
            else if (post.Available == 1)
            {
                statusTxt.Text = "in Progress";
                statusTxt.BorderColor = Color.FromArgb(76, 104, 62);
            }

        }

        public void setter( Home form)
        {
            
            this.home = form;

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

        private void gunaButton4_Click(object sender, EventArgs e)
        {
            Posting temp = db.getPostById(this.post_id);

            
            string loc = temp.Near_pickUp;
            this.locId = (int)double.Parse(loc);
            string loc2 = temp.Near_deliveryLocation;
            this.locId2 = (int)double.Parse(loc2);

            string pick = db.GetLocationByMatchingId(db.locations, locId).LocationName;
            string deliver = db.GetLocationByMatchingId(db.locations, locId2).LocationName;
            MessageBox.Show(pick + " " +deliver);
            temp.Near_pickUp = pick;
            temp.Near_deliveryLocation = deliver;
            temp.Available = 5;
            db.updatePostingInformation(temp);
            home.My_Request(sender,e);
        }
    }
}
