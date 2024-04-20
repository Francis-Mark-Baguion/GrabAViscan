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

namespace GrabAViscan
{
    public partial class ToDeliver : UserControl
    {
        private DatabaseManagement db = new DatabaseManagement();
        private int User_id;
        Home home;
        public ToDeliver(int User_id)
        {
            InitializeComponent();

            this.User_id = User_id;
        }







        public void feed(Home home)
        {
            flow1.Controls.Clear();

            bool flag = false;
            List<Posting> posts = db.getAllPost();
            List<Deliver> deliveries = db.Deliveries;

            foreach (Posting post in posts)
            {
                if ( post.Available == 1 || post.Available>5)
                {
                    foreach(Deliver delivery in deliveries)
                    {
                        if(post.Post_id == delivery.Post_Id && delivery.User_Id == User_id)
                        {
                            Deliveries req = new Deliveries(post);
                            req.setter(home);

                            flow1.Controls.Add(req);
                        }
                    }
                    


                }


                //Buffers buff = new Buffers();
                //flow1.Controls.Add(buff);
            }
        }
    }
}
