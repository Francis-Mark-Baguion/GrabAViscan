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

namespace GrabAViscan
{
    public partial class History : UserControl
    {
        DatabaseManagement db = new DatabaseManagement();
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


            List<Posting> posts = db.getAllPost();


            

            List<Deliver> deliveries = db.GetDeliveriesById(User_id);

            
                    foreach (Deliver delivery in deliveries)
                    {
                            Posting post = db.getPostById(delivery.Post_Id);
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
                            else if (post.Available == 5)
                            {
                                HistroyLogCan Cancelled = new HistroyLogCan(post);

                                flow1.Controls.Add(Cancelled);
                            }

                            Buffers buff = new Buffers();
                            flow1.Controls.Add(buff);


                        
                    }



                
            
        }
            
        private void History_Load(object sender, EventArgs e)
        {

        }

      
    }
}
