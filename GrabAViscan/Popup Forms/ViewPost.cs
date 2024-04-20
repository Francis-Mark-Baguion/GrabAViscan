using GrabAViscan.Classes;

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

namespace GrabAViscan.Popup_Forms
{
    public partial class ViewPost : Form
    {
        private DatabaseManagement db = new DatabaseManagement();
        private string loc;
        private string loc2;
        private int locId;
        private int locId2;
        public ViewPost(Posting post)
        {
            InitializeComponent();

            
            string loc = post.Near_pickUp;
            this.locId = (int)double.Parse(loc);
            string loc2 = post.Near_deliveryLocation;
            this.locId2 = (int)double.Parse(loc2);

            string pick = db.GetLocationByMatchingId(db.locations, locId).LocationName;
            string deliver = db.GetLocationByMatchingId(db.locations, locId2).LocationName;


            SetImageFromByteArrayProfile(profile, db.getUserById(post.User_id).Profile_pic);
            SetImageFromByteArray1(picture, post.image);
            this.Name_label.Text = db.getUserById(post.User_id).FirstName + " "+ db.getUserById(post.User_id).LastName;
            this.statusTxt.Text = db.getUserById(post.User_id).Status;
            this.requestTxt.Text = post.Requested;
            this.quantityTxt.Text = post.Quantity;
            this.categoryTxt.Text = post.Category; 
            this.Fee.Text = post.Fee + "";
            this.pickUp.Text = pick + ": " + post.Pick_up;

            this.delivery.Text = deliver + ": " + post.Delivery_location;
            this.descriptionTxt.Text = post.Description;
            this.Show();

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


        public void SetImageFromByteArray1(GunaPictureBox Image_cont, byte[] byteArray)
        {
            if (byteArray != null)
            {
                using (MemoryStream ms = new MemoryStream(byteArray))
                {
                    Image image = Image.FromStream(ms);
                    picture.Image = image;
                }
            }
        }

        private void gunaLabel5_Click(object sender, EventArgs e)
        {

        }

        private void addressTxt_Click(object sender, EventArgs e)
        {

        }

        private void gunaLabel4_Click(object sender, EventArgs e)
        {

        }

        private void phoneTxt_Click(object sender, EventArgs e)
        {

        }

        private void upload_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
