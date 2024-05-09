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
    public partial class DeliveryHistory : UserControl
    {
        private DatabaseManagement db = new DatabaseManagement();
        private int User_id;
        private Home home;
        public DeliveryHistory(int User_id,Home home)
        {
            InitializeComponent();
            this.home = home;   
            this.User_id = User_id;
            List<Deliver> deliveries = db.GetDeliveriesById(User_id);


            foreach (Deliver delivery in deliveries)
            {
                Posting post = db.getPostById(delivery.Post_Id);
                if (post.Available == 4)
                {

                    HistroyLogDel Delivered = new HistroyLogDel(post,home);

                    flow2.Controls.Add(Delivered);


                }
                else if (post.Available == 3)
                {
                    HistroyLogDel Received = new HistroyLogDel(post, home);

                    flow2.Controls.Add(Received);
                }
                else if (post.Available == 5 || post.Available == 10)
                {
                    HistroyLogCan Cancelled = new HistroyLogCan(post, this.User_id, "You",home);

                    flow2.Controls.Add(Cancelled);
                }

                Buffers buff = new Buffers();
                flow2.Controls.Add(buff);



            }

        }
    }
}
