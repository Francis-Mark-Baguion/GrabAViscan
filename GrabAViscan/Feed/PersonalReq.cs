using GrabAViscan.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GrabAViscan.Feed
{
    public partial class PersonalReq : UserControl
    {

        DatabaseManagement db = new DatabaseManagement();
        private int User_id;
        private Home home;
        public PersonalReq(int User_id, Home home)
        {
            InitializeComponent();
            this.User_id = User_id; 
            flow1.Controls.Clear();
            this.home = home;

            List<Deliver> cancelledPost = db.Deliveries;


            foreach (Deliver deliver in cancelledPost)
            {
                if (db.getPostById(deliver.Post_Id).User_id == User_id && db.getPostById(deliver.Post_Id).Available > 1)
                {
                    Posting post = db.getPostById(deliver.Post_Id);
                    if (post.Available == 4)
                    {

                        HistroyLogDel Delivered = new HistroyLogDel(post);

                        flow1.Controls.Add(Delivered);


                    }
                    else if (post.Available == 3)
                    {
                        HistroyLogRec Received = new HistroyLogRec(post,User_id,home);

                        flow1.Controls.Add(Received);
                    }
                    else if (post.Available == 5 || post.Available == 10)
                    {
                        CancelledRepost Cancelled = new CancelledRepost(post, deliver.User_Id,this.home);

                        flow1.Controls.Add(Cancelled);
                    }
                    Buffers buff = new Buffers();
                    flow1.Controls.Add(buff);
                }
            }
        }
    }
}
