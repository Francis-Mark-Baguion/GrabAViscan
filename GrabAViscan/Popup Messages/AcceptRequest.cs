using GrabAViscan.Classes;
using GrabAViscan.Feed;
using GrabAViscan.Popup;
using Org.BouncyCastle.Asn1.Pkcs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GrabAViscan.Popup_Messages
{
    public partial class AcceptRequest : Form
    {
        private DatabaseManagement db = new DatabaseManagement();
        private int id;
        private int uid;
        private int flag = 0;
        private FeedNoImage noImage;
        private HomeFeed withImage;
        private Home home;
        
        public AcceptRequest(int id, int uid,HomeFeed YesImage, Home home)
        {
            this.Owner = home;
            this.home = home;   
            InitializeComponent();
            this.Show();
            this.id = id;
            this.uid = uid;
            this.withImage = YesImage;
        }


        public AcceptRequest(int id, int uid,FeedNoImage NoImage, Home home) 
        {
            InitializeComponent();
            this.home = home;
            this.Owner = home;
            this.Show();
            this.id = id;
            this.uid = uid;
            this.noImage = NoImage;
        }

        public int confirmed()
        {
            return flag;
        }
        private void gunaButton3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gunaButton4_Click(object sender, EventArgs e)
        {
            flag = 1;
            try
            {
                db.updateAvailability(db.getPostById(this.id).Post_id, 1);
                db.AssignDeliver(db.getPostById(this.id).Post_id, uid);
                if(noImage != null) 
                {
                    home.homeclick(sender, e);
                    noImage.Hide();
                }
                if (withImage != null)
                {
                    home.homeclick(sender, e);
                    withImage.Hide();
                    
                }

                this.Close();

            }
            catch (Exception ex)

            {
                ErrorMessage err = new ErrorMessage(ex.Message);
            }
        }
    }
}
