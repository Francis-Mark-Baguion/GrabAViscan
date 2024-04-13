using GrabAViscan.Classes;
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
        DatabaseManagement db = new DatabaseManagement();
        public HistroyLogCan(Posting post)
        {
            InitializeComponent();

            this.nameHolder.Text = db.getUserById(post.User_id).FirstName + " " + db.getUserById(post.User_id).LastName;
            SetImageFromByteArrayProfile(this.profile, db.getUserById(post.User_id).Profile_pic);
            this.dateCompleted.Text = DateTime.Now.ToString("dd/MM/yyyy");
            this.requestTxt.Text = post.Requested;
            this.Fee.Text = post.Fee.ToString();

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
    }
}
