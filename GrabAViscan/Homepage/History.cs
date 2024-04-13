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
        public History()
        {
            InitializeComponent();
            feed();
        }


        private void feed()
        {
            flow1.Controls.Clear();


            List<Posting> posts = db.getAllPost();


            foreach (Posting post in posts)
            {
                if (post.Available==4)
                {

                    HistroyLogDel history = new HistroyLogDel(post);

                    flow1.Controls.Add(history);

                    
                }

                Buffers buff = new Buffers();
                flow1.Controls.Add(buff);
            }
        }
        private void History_Load(object sender, EventArgs e)
        {

        }

        private void gunaPictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void gunaPanel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void gunaPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gunaPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gunaPanel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
