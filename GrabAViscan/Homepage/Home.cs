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
using GrabAViscan.Popup_Forms;
using System.Security.Policy;


namespace GrabAViscan
{
    public partial class Home : Form
    {
        private DatabaseManagement db = new DatabaseManagement();
        private Filter filter = new Filter();
        public User user;
        private rightWing right;
        private string email;
        private int User_id;
        ToDeliver todeliver;
        public Home(int uid)
        {
            List<Posting> posts = db.GetAvailablePosts();
            this.User_id = uid;
            InitializeComponent();
            right = new rightWing(this);

            RightWing.Controls.Add(right);
            feed(posts);
            ctrSet();
            
        }




        public void setter(string email)
        {
            user = db.InitializeUser(email);
            this.User_id = user.User_id;
            this.email = email;
            right.setter(email, this);

        }

        public void feed(List<Posting> posts)
        {
            flow1.Controls.Clear();
            ctrSet();




            foreach (Posting post in posts)
            {
                if (post.User_id != User_id && post.Deadline >= DateTime.Now)
                {
                    if (post.image != null)
                    {
                        HomeFeed home = new HomeFeed(post, User_id,this);



                        flow1.Controls.Add(home);
                    }
                    else
                    {
                        FeedNoImage feedNoImage = new FeedNoImage(post, User_id,this);
                        flow1.Controls.Add(feedNoImage);

                    }
                    Buffers buff = new Buffers();
                    flow1.Controls.Add(buff);
                }



            }
        }

        public void homeclick(object sender, EventArgs e)
        {
            List<Posting> posts = db.GetAvailablePosts();
            user = db.InitializeUser(email);


            right.setter(email, this);
            tableLayoutPanel1.ColumnStyles[2].SizeType = SizeType.Percent;
            tableLayoutPanel1.ColumnStyles[2].Width = 25;
            tableLayoutPanel1.ColumnStyles[1].SizeType = SizeType.Percent;
            tableLayoutPanel1.ColumnStyles[1].Width = 53;
            tableLayoutPanel1.ColumnStyles[0].SizeType = SizeType.Percent;
            tableLayoutPanel1.ColumnStyles[0].Width = 22;

            this.RightWing.Controls.Add(right);
            flow1.Controls.Clear();
            feed(posts);
            ctrSet();

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
            ctrSet();
            
        }


        public void To_deliver(object sender, EventArgs e)
        {
            todeliver = new ToDeliver(this.User_id);
            todeliver.feed(this);
            flow1.Controls.Clear();

            tableLayoutPanel1.ColumnStyles[2].SizeType = SizeType.Percent;
            tableLayoutPanel1.ColumnStyles[2].Width = 0;
            tableLayoutPanel1.ColumnStyles[1].SizeType = SizeType.Percent;
            tableLayoutPanel1.ColumnStyles[1].Width = 78;
            tableLayoutPanel1.ColumnStyles[0].SizeType = SizeType.Percent;
            tableLayoutPanel1.ColumnStyles[0].Width = 22;

            flow1.Controls.Add(todeliver);
            ctrSet();
        }

        private void History(object sender, EventArgs e)
        {
            History history = new History(this.User_id,this);
            flow1.Controls.Clear();

            tableLayoutPanel1.ColumnStyles[2].SizeType = SizeType.Percent;
            tableLayoutPanel1.ColumnStyles[2].Width = 0;
            tableLayoutPanel1.ColumnStyles[1].SizeType = SizeType.Percent;
            tableLayoutPanel1.ColumnStyles[1].Width = 78;
            tableLayoutPanel1.ColumnStyles[0].SizeType = SizeType.Percent;
            tableLayoutPanel1.ColumnStyles[0].Width = 22;

            flow1.Controls.Add(history);
            ctrSet();
        }

        public void gunaButton9_Click(object sender, EventArgs e)
        {
            Settings settings = new Settings(user.Email,this);

            flow1.Controls.Clear();

            tableLayoutPanel1.ColumnStyles[2].SizeType = SizeType.Percent;
            tableLayoutPanel1.ColumnStyles[2].Width = 0;
            tableLayoutPanel1.ColumnStyles[1].SizeType = SizeType.Percent;
            tableLayoutPanel1.ColumnStyles[1].Width = 78;
            tableLayoutPanel1.ColumnStyles[0].SizeType = SizeType.Percent;
            tableLayoutPanel1.ColumnStyles[0].Width = 22;

            flow1.Controls.Add(settings);
            ctrSet();
        }



        private void Close_btn_Click(object sender, EventArgs e)
        {
            right.post.Close();
            //right.notif.Close();
            this.Close();
        }

        private void Minimize_btn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void flow1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            logNotif logout = new logNotif(this);
            logout.Show();
        }

        private void gunaTextBox1_Click(object sender, EventArgs e)
        {


            filterBox.Text = "";
            filter = new Filter(this);
        }

        private void Filter_btn_Click(object sender, EventArgs e)
        {
            if(filterBox.Text != "")
            {
                try
                {

                    List<Posting> filteredPost = filter.returnFilter();

                    filter.Hide();
                    feed(filteredPost);
                }
                catch (Exception ex)
                {
                    ErrorMessage err = new ErrorMessage(ex.Message);
                }
            }
            
            
            

        }

        public int requestCtr()
        {
            List<Posting> posts = db.getAllPost();
            int ctr = 0;

            foreach (Posting post in posts)
            {
                if (post.User_id == this.User_id && post.Available < 3)
                {



                    ctr++;


                }
                else if (post.User_id == this.User_id && post.Available > 5)
                {


                    ctr++;
                }

               
            }
            return ctr;
        }

        public int deliveryCtr()
        {
            int ctr = 0;
            bool flag = false;
            List<Posting> posts = db.getAllPost();
            db.GetDeliveries();
            List<Deliver> deliveries = db.Deliveries;

            foreach (Posting post in posts)
            {
                if (post.Available == 1 || post.Available > 5)
                {
                    foreach (Deliver delivery in deliveries)
                    {
                        if (post.Post_id == delivery.Post_Id &&delivery.User_Id == User_id)
                        {
                            ctr++;
                        }
                    }



                }


                
            }
            return ctr;
        }

        public void ctrSet()
        {
            this.reqCtr.Text = requestCtr()+"";
            this.deliverCtr.Text = deliveryCtr() + "";
        }

        private void LeftWing_Paint(object sender, PaintEventArgs e)
        {

        }

        private void reqCtr_Click(object sender, EventArgs e)
        {

        }

        private void deliverCtr_Click(object sender, EventArgs e)
        {

        }

        private void hover(object sender, EventArgs e)
        {
            reqCtr.BackColor = Color.FromArgb(76, 104, 62);
            reqCtr.ForeColor = Color.White;
        }

        private void mouseleave(object sender, EventArgs e)
        {
            reqCtr.BackColor = Color.FromArgb(240, 242, 245);
            reqCtr.ForeColor = Color.Firebrick;
        }

        private void gunaButton4_MouseHover(object sender, EventArgs e)
        {
            deliverCtr.BackColor = Color.FromArgb(76, 104, 62);
            deliverCtr.ForeColor = Color.White;
        }

        private void gunaButton4_MouseLeave(object sender, EventArgs e)
        {
            deliverCtr.BackColor = Color.FromArgb(240, 242, 245);
            deliverCtr.ForeColor = Color.Firebrick;
        }
    }
}
