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
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GrabAViscan.Feed
{
    public partial class HistroyLogCan : UserControl
    {
        private DatabaseManagement db = new DatabaseManagement();
        private int User_id;
        private Profile profile1;
        private Posting post;
        public HistroyLogCan(Posting post,int Youser, string name)
        {
            InitializeComponent();
            this.post = post;   
            Label.Text = "CANCELLED";
            this.User_id = post.User_id;
            this.nameHolder.Text = db.getUserById(post.User_id).FirstName + " " + db.getUserById(post.User_id).LastName;
            SetImageFromByteArrayProfile(this.profile, db.getUserById(post.User_id).Profile_pic);
            this.dateCompleted.Text = DateTime.Now.ToString("dd/MM/yyyy");
            this.requestTxt.Text = post.Category;
            this.Fee.Text = post.Fee.ToString();
            Category cat = db.GetCategoryByName(post.Category);
            SetImageFromByteArrayProfile(this.category, cat.categoryImage);
        }

        public HistroyLogCan(Posting post, int Cancelled_User_id)
        {
            InitializeComponent();
            Label.Text = "CANCELLED";
            this.nameHolder.Text = db.getUserById(Cancelled_User_id).FirstName + " " + db.getUserById(Cancelled_User_id).LastName;
            SetImageFromByteArrayProfile(this.profile, db.getUserById(Cancelled_User_id).Profile_pic);
            this.dateCompleted.Text = DateTime.Now.ToString("dd/MM/yyyy");
            this.requestTxt.Text = post.Requested;
            this.Fee.Text = post.Fee.ToString();
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

        private void profile_Click(object sender, EventArgs e)
        {
            profile1 = new Profile(User_id);
        }

        private void Close_btn_Click(object sender, EventArgs e)
        {
            ViewPost view = new ViewPost(post);
        }
    }
}
