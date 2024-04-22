using GrabAViscan.Classes;
using GrabAViscan.Popup_Forms;
using GrabAViscan.Popup_Messages;
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
using GrabAViscan.Popup_Messages;

namespace GrabAViscan.Feed
{
    public partial class Deliveries : UserControl
    {
        private DatabaseManagement db = new DatabaseManagement();
        private Category cat;
        private int locId;
        private int locId2;
        private int post_id;
        private Home home;
        public Deliveries(Posting post)
        {
            InitializeComponent();

            this.post_id = post.Post_id;
            string loc = post.Near_pickUp;
            this.locId = (int)double.Parse(loc);
            string loc2 = post.Near_deliveryLocation;
            this.locId2 = (int)double.Parse(loc2);
            this.RequestTxt.Text = post.Requested;
            string pick = db.GetLocationByMatchingId(db.locations, locId).LocationName;
            string deliver = db.GetLocationByMatchingId(db.locations, locId2).LocationName;


            statusTxt.Text = post.Requested;
            quantityTxt.Text = post.Quantity;

            pickNearbyTxt.Text = pick;

            deliveryNearTxt.Text = deliver;
            NameLabel.Text = db.getUserById(post.User_id).FirstName + " " + db.getUserById(post.User_id).LastName;
            Fee.Text = post.Fee + "";


            
            SetImageFromByteArrayProfile(this.profile, db.getUserById(post.User_id).Profile_pic);

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
            else if (post.Available == 6)
            {
                statusTxt.Text = "PICK UP ITEM";
                statusTxt.BorderColor = Color.FromArgb(76, 104, 62);
            }
            else if (post.Available == 7)
            {
                statusTxt.Text = "TRAVELLING";
                statusTxt.BorderColor = Color.FromArgb(76, 104, 62);
            }
            else if (post.Available == 8)
            {
                statusTxt.Text = "ARRIVED";
                statusTxt.BorderColor = Color.FromArgb(76, 104, 62);
            }

        }

        public void setter(Home form)
        {

            this.home = form;

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

        private void gunaButton4_Click(object sender, EventArgs e)
        {
            
        }

        private void gunaButton4_Click_1(object sender, EventArgs e)
        {
            Posting temp = db.getPostById(this.post_id);


            string loc = temp.Near_pickUp;
            this.locId = (int)double.Parse(loc);
            string loc2 = temp.Near_deliveryLocation;
            this.locId2 = (int)double.Parse(loc2);

            string pick = db.GetLocationByMatchingId(db.locations, locId).LocationName;
            string deliver = db.GetLocationByMatchingId(db.locations, locId2).LocationName;
            
            temp.Near_pickUp = pick;
            temp.Near_deliveryLocation = deliver;
            temp.Available = 5;
            CancelReq cancel = new CancelReq(temp, home,1);
            cancel.Show();
            
        }

        private void discard_btn_Click(object sender, EventArgs e)
        {
            Popup_Messages.UpdateStatus update = new Popup_Messages.UpdateStatus(this.post_id,this.home);
        }

        private void upload_btn_Click(object sender, EventArgs e)
        {
            ViewPost view = new ViewPost(db.getPostById(post_id));
        }
    }
}
