using Guna.UI.WinForms;
using MySql.Data.MySqlClient;
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
using GrabAViscan.Classes;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using GrabAViscan.Popup;
using GrabAViscan.Homepage;


namespace GrabAViscan
{
    public partial class Home : Form
    {
        DatabaseManagement db = new DatabaseManagement();
        public User user;
        rightWing right = new rightWing();
        private string email;
        private int User_id;
        public Home(int uid)
        {
            this.User_id = uid;
            InitializeComponent();
            right = new rightWing();
            
            RightWing.Controls.Add(right);
            feed();
        }

        

         
        public void setter(string email)
        {
            user = db.InitializeUser(email);
            this.User_id = user.User_id;
            this.email = email;
            right.setter(email,this);

        }

        private void feed()
        {
            flow1.Controls.Clear();

            
            List<Posting> posts = db.GetAvailablePosts();

            
            foreach (Posting post in posts)
            {
                if(post.User_id != User_id)
                {
                    if (post.image != null)
                    {
                        HomeFeed home = new HomeFeed(post,User_id);


                        flow1.Controls.Add(home);
                    }
                    else
                    {
                        FeedNoImage feedNoImage = new FeedNoImage(post,User_id);
                        flow1.Controls.Add(feedNoImage);

                    }
                    Buffers buff = new Buffers();
                    flow1.Controls.Add(buff);
                }
                
                
               
            }
        }

        public void homeclick(object sender, EventArgs e)
        {
            
            user = db.InitializeUser(email);
            
            
            right.setter(email,this);
            tableLayoutPanel1.ColumnStyles[2].SizeType = SizeType.Percent;
            tableLayoutPanel1.ColumnStyles[2].Width = 25;
            tableLayoutPanel1.ColumnStyles[1].SizeType = SizeType.Percent;
            tableLayoutPanel1.ColumnStyles[1].Width = 53;
            tableLayoutPanel1.ColumnStyles[0].SizeType = SizeType.Percent;
            tableLayoutPanel1.ColumnStyles[0].Width = 22;

            this.RightWing.Controls.Add(right);
            flow1.Controls.Clear();
            feed();

        }

        public void My_Request(object sender, EventArgs e)
        {
            MyRequest myRequest = new MyRequest(this.User_id);
            myRequest.feed(this);
            flow1.Controls.Clear();

            tableLayoutPanel1.ColumnStyles[2].SizeType = SizeType.Percent;
            tableLayoutPanel1.ColumnStyles[2].Width = 0;
            tableLayoutPanel1.ColumnStyles[1].SizeType = SizeType.Percent;
            tableLayoutPanel1.ColumnStyles[1].Width = 78;
            tableLayoutPanel1.ColumnStyles[0].SizeType = SizeType.Percent;
            tableLayoutPanel1.ColumnStyles[0].Width = 22;

            flow1.Controls.Add(myRequest);
        }

      
        private void To_deliver(object sender, EventArgs e)
        {
            ToDeliver deliver = new ToDeliver();  
            flow1.Controls.Clear();

            tableLayoutPanel1.ColumnStyles[2].SizeType = SizeType.Percent;
            tableLayoutPanel1.ColumnStyles[2].Width = 0;
            tableLayoutPanel1.ColumnStyles[1].SizeType = SizeType.Percent;
            tableLayoutPanel1.ColumnStyles[1].Width = 78;
            tableLayoutPanel1.ColumnStyles[0].SizeType = SizeType.Percent;
            tableLayoutPanel1.ColumnStyles[0].Width = 22;

            flow1.Controls.Add(deliver);
        }

        private void History(object sender, EventArgs e)
        {
            History history = new History();  
            flow1.Controls.Clear();

            tableLayoutPanel1.ColumnStyles[2].SizeType = SizeType.Percent;
            tableLayoutPanel1.ColumnStyles[2].Width = 0;
            tableLayoutPanel1.ColumnStyles[1].SizeType = SizeType.Percent;
            tableLayoutPanel1.ColumnStyles[1].Width = 78;
            tableLayoutPanel1.ColumnStyles[0].SizeType = SizeType.Percent;
            tableLayoutPanel1.ColumnStyles[0].Width = 22;

            flow1.Controls.Add(history);
        }

        public void gunaButton9_Click(object sender, EventArgs e)
        {
            Settings settings = new Settings(user.Email);
            
            flow1.Controls.Clear();

            tableLayoutPanel1.ColumnStyles[2].SizeType = SizeType.Percent;
            tableLayoutPanel1.ColumnStyles[2].Width = 0;
            tableLayoutPanel1.ColumnStyles[1].SizeType = SizeType.Percent;
            tableLayoutPanel1.ColumnStyles[1].Width = 78;
            tableLayoutPanel1.ColumnStyles[0].SizeType = SizeType.Percent;
            tableLayoutPanel1.ColumnStyles[0].Width = 22;

            flow1.Controls.Add(settings);
        }

        

        private void Close_btn_Click(object sender, EventArgs e)
        {
            right.post.Close();
            right.notif.Close();
            this.Close();
        }

        private void Minimize_btn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void flow1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
