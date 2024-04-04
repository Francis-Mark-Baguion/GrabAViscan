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

namespace GrabAViscan
{
    public partial class Home : Form
    {
        rightWing right;
        public Home()
        {
            InitializeComponent();
            right = new rightWing();
            RightWing.Controls.Add(right);
            feed();
            
            
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void feed()
        {
            flow1.Controls.Clear();
            string con = "server=127.0.0.1;uid=root;pwd=Testing123;database=grab";
            MySqlConnection conConn = new MySqlConnection(con);
            conConn.Open();
            string sql = "SELECT * FROM grab.accounts;";
            MySqlCommand cmd = new MySqlCommand(sql, conConn);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {

                int ctr = 0;
                string name = (string)reader["username"];

                HomeFeed home = new HomeFeed(name);
                Buffers buff = new Buffers();
                flow1.Controls.Add(home);
                flow1.Controls.Add(buff);


            }
        }

        private void gunaButton2_Click(object sender, EventArgs e)
        {

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

        private void gunaButton3_Click(object sender, EventArgs e)
        {
            flow1.Controls.Clear();
        }

        private void emailTxt_Click(object sender, EventArgs e)
        {

        }

        

        private void gunaButton10_Click(object sender, EventArgs e)
        {

        }

        private void gunaPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void gunaButton11_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gunaLabel1_Click(object sender, EventArgs e)
        {

        }

        private void gunaButton7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gunaButton8_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void My_Request(object sender, EventArgs e)
        {
            MyRequest myRequest = new MyRequest();
            flow1.Controls.Clear();

            tableLayoutPanel1.ColumnStyles[2].SizeType = SizeType.Percent;
            tableLayoutPanel1.ColumnStyles[2].Width = 0;
            tableLayoutPanel1.ColumnStyles[1].SizeType = SizeType.Percent;
            tableLayoutPanel1.ColumnStyles[1].Width = 78;
            tableLayoutPanel1.ColumnStyles[0].SizeType = SizeType.Percent;
            tableLayoutPanel1.ColumnStyles[0].Width = 22;

            flow1.Controls.Add(myRequest);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gunaButton4_Click(object sender, EventArgs e)
        {

        }

        private void gunaButton5_Click(object sender, EventArgs e)
        {

        }

        private void gunaButton9_Click(object sender, EventArgs e)
        {

        }
    }
}
