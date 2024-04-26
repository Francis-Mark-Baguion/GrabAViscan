using GrabAViscan.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GrabAViscan.Popup_Messages
{
    public partial class UpdateStatus : Form
    {
        DatabaseManagement db = new DatabaseManagement();
        private int Post_id;
        private int flag = 1;

        private int locId;
        private int locId2;
        private Home home;
        public UpdateStatus(int Post_id, Home home)
        {
            InitializeComponent();
            this.Post_id = Post_id;
            this.home = home;
            this.Show();
            Posting post = db.getPostById(Post_id);

            if(post.Available==6)
            {
               
                one.BaseColor = Color.FromArgb(76, 104, 62);

                panelOne.BackColor = Color.Silver;
                two.BaseColor = Color.Silver;
                panelTwo.BackColor = Color.Silver;
                three.BaseColor = Color.Silver;
                panelThree.BackColor = Color.Silver;
                four.BaseColor = Color.Silver;
            }
            else if(post.Available==7)
            {
                
                one.BaseColor = Color.FromArgb(76, 104, 62);
                panelOne.BackColor = Color.FromArgb(76, 104, 62);
                two.BaseColor = Color.FromArgb(76, 104, 62);


                panelTwo.BackColor = Color.Silver;
                three.BaseColor = Color.Silver;
                panelThree.BackColor = Color.Silver;
                four.BaseColor = Color.Silver;
            }
            else if (post.Available == 8)
            {
                one.BaseColor = Color.FromArgb(76, 104, 62);
                panelOne.BackColor = Color.FromArgb(76, 104, 62);
                two.BaseColor = Color.FromArgb(76, 104, 62);
                panelTwo.BackColor = Color.FromArgb(76, 104, 62);
                three.BaseColor = Color.FromArgb(76, 104, 62);

                panelThree.BackColor = Color.Silver;
                four.BaseColor = Color.Silver;
            }
            
        }

        private void gunaButton4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void one_Click(object sender, EventArgs e)
        {

            this.flag = 6;
            one.BaseColor = Color.FromArgb(76, 104, 62);

            panelOne.BackColor = Color.Silver;
            two.BaseColor = Color.Silver;
            panelTwo.BackColor = Color.Silver;
            three.BaseColor = Color.Silver;
            panelThree.BackColor = Color.Silver;
            four.BaseColor = Color.Silver;
            

        }

        private void upload_btn_Click(object sender, EventArgs e)
        {

            

            Posting post = db.getPostById(Post_id);
            this.Post_id = post.Post_id;
            string loc = post.Near_pickUp;
            this.locId = (int)double.Parse(loc);
            string loc2 = post.Near_deliveryLocation;
            this.locId2 = (int)double.Parse(loc2);

            string pick = db.GetLocationByMatchingId(db.locations, locId).LocationName;
            string deliver = db.GetLocationByMatchingId(db.locations, locId2).LocationName;
            post.Near_pickUp = pick;
            post.Near_deliveryLocation = deliver;
            

            post.Available = flag;
            
            db.updatePostingInformation(post);
            this.Close();
            home.To_deliver(sender, e);
        }

        private void two_Click(object sender, EventArgs e)
        {
            this.flag = 7;
            one.BaseColor = Color.FromArgb(76, 104, 62);
            panelOne.BackColor = Color.FromArgb(76, 104, 62);
            two.BaseColor = Color.FromArgb(76, 104, 62);
            

            panelTwo.BackColor = Color.Silver;
            three.BaseColor = Color.Silver;
            panelThree.BackColor = Color.Silver;
            four.BaseColor = Color.Silver;
        }

        private void three_Click(object sender, EventArgs e)
        {
            this.flag = 8;
            one.BaseColor = Color.FromArgb(76, 104, 62);
            panelOne.BackColor = Color.FromArgb(76, 104, 62);
            two.BaseColor = Color.FromArgb(76, 104, 62);
            panelTwo.BackColor = Color.FromArgb(76, 104, 62);
            three.BaseColor = Color.FromArgb(76, 104, 62);

            panelThree.BackColor = Color.Silver;
            four.BaseColor = Color.Silver;
        }

        private void four_Click(object sender, EventArgs e)
        {
            this.flag = 3;
            one.BaseColor = Color.FromArgb(76, 104, 62);
            panelOne.BackColor = Color.FromArgb(76, 104, 62);
            two.BaseColor = Color.FromArgb(76, 104, 62);
            panelTwo.BackColor = Color.FromArgb(76, 104, 62);
            three.BaseColor = Color.FromArgb(76, 104, 62);
            panelThree.BackColor = Color.FromArgb(76, 104, 62);
            four.BaseColor = Color.FromArgb(76, 104, 62);
        }
    }
}
