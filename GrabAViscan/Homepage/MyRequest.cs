using GrabAViscan.Classes;
using GrabAViscan.Feed;
using GrabAViscan.Popup;
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
    public partial class MyRequest : UserControl
    {
        DatabaseManagement db = new DatabaseManagement();
        private int User_id;
        Home home;
        public MyRequest(int User_id)
        {
            InitializeComponent();
            
            this.User_id = User_id;
        }

        
           
            

        

        public void feed(Home home)
        {
            flow1.Controls.Clear();


            List<Posting> posts = db.getAllPost();


            foreach (Posting post in posts)
            {
                if (post.Available == 0 || post.Available ==  1 || post.Available == 2 && post.User_id == this.User_id && post.Available<3)
                {

                    Requests req = new Requests(post);
                    req.setter(home);

                    flow1.Controls.Add(req);


                }
                

                //Buffers buff = new Buffers();
                //flow1.Controls.Add(buff);
            }
        }
    }
}
