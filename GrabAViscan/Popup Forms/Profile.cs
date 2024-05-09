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
        public Profile(int User_id,Home home)
        {
            InitializeComponent();
            this.Owner = home;
            this.nameHolder.Text = db.getUserById(User_id).FirstName + " " + db.getUserById(User_id).LastName;
            this.emailHolder.Text = db.getUserById(User_id).Email;
            this.addressHoldler.Text = db.getUserById(User_id).Address;
            this.phoneTxt.Text = db.getUserById(User_id).PhoneNumber;
            
            
            SetImageFromByteArrayProfile(profile_pic, db.getUserById(User_id).Profile_pic);
            this.Show();
        }

        public Profile(int User_id, Home home,int flag)
        {
            InitializeComponent();
            this.Owner = home;
            this.nameHolder.Text = db.getUserById(User_id).FirstName + " " + db.getUserById(User_id).LastName;
            this.emailHolder.Text = db.getUserById(User_id).Email;
            this.addressHoldler.Text = db.getUserById(User_id).Address;
            this.phoneTxt.Text = db.getUserById(User_id).PhoneNumber;
            

            SetImageFromByteArrayProfile(profile_pic, db.getUserById(User_id).Profile_pic);
            
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

        private void gunaButton4_Click(object sender, EventArgs e)
        {
            this.Close();
            
            
        }

        private void gunaPanel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gunaLabel2_Click(object sender, EventArgs e)
        {

        }
    }
}
