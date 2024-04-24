using GrabAViscan.Classes;
using GrabAViscan.Feed;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GrabAViscan.Feed;
using GrabAViscan.Popup;
using System.Security.Policy;
using System.CodeDom;

namespace GrabAViscan
{
    public partial class History : UserControl
    {
        private DatabaseManagement db = new DatabaseManagement();
        private int User_id;
        private Image personal;
        private Image delivery;
        public History(int User_id)
        {
            InitializeComponent();
            this.User_id = User_id;
            feed();
        }


        private void feed()
        {
            flow1.Controls.Clear();

            personal = btn_personal.Image;
            delivery = btn_delivery.Image;
            List<Deliver> cancelledPost = db.Deliveries;


            foreach (Deliver deliver in cancelledPost)
            {
                if(db.getPostById(deliver.Post_Id).User_id == User_id && db.getPostById(deliver.Post_Id).Available>1) 
                {   
                    Posting post = db.getPostById(deliver.Post_Id);
                    if (post.Available == 4)
                    {

                        HistroyLogDel Delivered = new HistroyLogDel(post);

                        flow1.Controls.Add(Delivered);


                    }
                    else if (post.Available == 3)
                    {
                        HistroyLogRec Received = new HistroyLogRec(post,User_id);

                        flow1.Controls.Add(Received);
                    }
                    else if (post.Available == 5 || post.Available==10)
                    {
                        CancelledRepost Cancelled = new CancelledRepost(post,deliver.User_Id);

                        flow1.Controls.Add(Cancelled);
                    }
                    Buffers buff = new Buffers();
                    flow1.Controls.Add(buff);
                }
            }
            
        }
            
        private void History_Load(object sender, EventArgs e)
        {

        }

        private void gunaGradiantButton2_Click(object sender, EventArgs e)
        {

        }

        private void gunaButton2_Click(object sender, EventArgs e)
        {
            
            btn_personal.BaseColor = Color.FromArgb(76, 104, 62);
            btn_personal.ForeColor = Color.White;
            btn_personal.Image = btn_personal.OnHoverImage;

            btn_delivery.BaseColor = Color.FromArgb(240, 242, 245);
            btn_delivery.ForeColor = Color.Black;
            btn_delivery.Image = delivery;
            
            flow1.Controls.Clear();
            PersonalReq personalReq = new PersonalReq(this.User_id);
            flow1.Controls.Add(personalReq);
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            btn_delivery.BaseColor = Color.FromArgb(76, 104, 62);
            btn_delivery.ForeColor = Color.White;
            btn_delivery.Image = btn_delivery.OnHoverImage;

            btn_personal.BaseColor = Color.FromArgb(240, 242, 245);
            btn_personal.ForeColor = Color.Black;
            btn_personal.Image = personal;
            flow1.Controls.Clear();
            DeliveryHistory deliveries = new DeliveryHistory(User_id);
            flow1.Controls.Add(deliveries);
        }
    }
}
