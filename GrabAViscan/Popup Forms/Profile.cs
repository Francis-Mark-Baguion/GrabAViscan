using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GrabAViscan.Classes;
using Guna.UI.WinForms;

namespace GrabAViscan.Popup
{
    public partial class Profile : Form
    {
        DatabaseManagement db = new DatabaseManagement();
        public Profile(Posting post)
        {
            InitializeComponent();
            this.nameHolder.Text = db.getUserById(post.User_id).FirstName + " " + db.getUserById(post.User_id).LastName;
            this.emailHolder.Text = db.getUserById(post.User_id).Email;
            this.addressHoldler.Text = db.getUserById(post.User_id).Address;
            this.DescriptionTxt.Text = db.getUserById(post.User_id).Bio;
            SetImageFromByteArrayProfile(profile_pic, post.image);
            this.Show();
        }


        public void SetImageFromByteArrayProfile(GunaCirclePictureBox profile, byte[] byteArray)
        {
            if (byteArray != null)
            {
                using (MemoryStream ms = new MemoryStream(byteArray))
                {
                    Image image = Image.FromStream(ms);
                    profile_pic.Image = image;
                }
            }

        }

        private void gunaButton4_Click(object sender, EventArgs e)
        {
            this.Hide();
            
            
        }

        private void gunaPanel4_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
