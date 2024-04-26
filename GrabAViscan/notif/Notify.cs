using GrabAViscan.Feed;
using GrabAViscan.notif;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GrabAViscan.Classes.notif
{
    public partial class Notify : Form
    {
        private DatabaseManagement db = new DatabaseManagement();
        private int User_id;
        public Notify(int User_id,Home home)
        {
            InitializeComponent();
            this.Owner = home;
            this.User_id = User_id;
            feed();
        }

        public void feed()
        {
            flow1.Controls.Clear();
            int ctr = 0;

            List<Deliver> cancelledPost = db.Deliveries;
            List<Deliver> reversedDelivers = cancelledPost.ToList();
            reversedDelivers.Reverse();

            for (int i = 0; i < reversedDelivers.Count; i++) // Use reversedDelivers for Option 1
            {
                Deliver deliver = reversedDelivers[i]; // Use reversedDelivers[i] for Option 1

                // ... your existing logic using deliver ...
                Posting post = db.getPostById(deliver.Post_Id);
                if (db.getPostById(deliver.Post_Id).User_id == User_id && db.getPostById(deliver.Post_Id).Available > 1 && ctr<10)
                {
                    if (post.Available == 4)
                    {
                        // Logic for Available == 4
                    }
                    else if (post.Available == 3)
                    {
                        NotifBoxComplete com = new NotifBoxComplete(deliver.User_Id);
                        flow1.Controls.Add(com);
                    }
                    else if (post.Available == 5 || post.Available == 10)
                    {
                        NotifBoxCancel Cancelled = new NotifBoxCancel(deliver.User_Id);
                        flow1.Controls.Add(Cancelled);
                    }

                    Buffers buff = new Buffers();
                    flow1.Controls.Add(buff);

                    if (ctr < 7)
                    {
                        flow1.AutoScroll = false;
                    }
                    else
                    {
                        flow1.AutoScroll = true;
                    }
                    ctr++;
                }
            }
        }
        

        private void gunaShadowPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
