﻿using Guna.UI.WinForms;
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

namespace GrabAViscan
{
    public partial class Home : Form
    {
        DatabaseManagement db = new DatabaseManagement();
        public User user;
        rightWing right;
        private string email;
        public Home()
        {
            InitializeComponent();
            right = new rightWing();
            
            RightWing.Controls.Add(right);
            feed();
        }

        
        public void setter(string email)
        {
            user = db.InitializeUser(email);
            this.email = email;
            right.setter(email);

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
                string name = (string)reader["email"];

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

        private void gunaButton9_Click(object sender, EventArgs e)
        {

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
    }
}
