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

namespace GrabAViscan
{
    public partial class History : UserControl
    {
        private DatabaseManagement db = new DatabaseManagement();
        private int User_id;
        public History(int User_id)
        {
            InitializeComponent();
            this.User_id = User_id;
            feed();
        }


        private void feed()
        {
            flow1.Controls.Clear();


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
                        HistroyLogRec Received = new HistroyLogRec(post);

                        flow1.Controls.Add(Received);
                    }
                    else if (post.Available == 5 || post.Available==10)
                    {
                        CancelledRepost Cancelled = new CancelledRepost(post);

                        flow1.Controls.Add(Cancelled);
                    }
                    Buffers buff = new Buffers();
                    flow1.Controls.Add(buff);
                }
            }





            List<Deliver> deliveries = db.GetDeliveriesById(User_id);

            
                    foreach (Deliver delivery in deliveries)
                    {
                            Posting post = db.getPostById(delivery.Post_Id);
                            if (post.Available == 4)
                            {
                                
                                HistroyLogDel Delivered = new HistroyLogDel(post);

                                flow2.Controls.Add(Delivered);


                            }
                            else if (post.Available == 3)
                            {
                                HistroyLogDel Received = new HistroyLogDel(post);

                                flow2.Controls.Add(Received);
                            }
                            else if (post.Available == 5 || post.Available==10)
                            {
                                HistroyLogCan Cancelled = new HistroyLogCan(post,this.User_id,"You");

                                flow2.Controls.Add(Cancelled);
                            }

                            Buffers buff = new Buffers();
                            flow2.Controls.Add(buff);


                        
                    }



                
            
        }
            
        private void History_Load(object sender, EventArgs e)
        {

        }

        private void gunaGradiantButton2_Click(object sender, EventArgs e)
        {

        }
    }
}
