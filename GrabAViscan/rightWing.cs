﻿using GrabAViscan.Classes;
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
    public partial class rightWing : UserControl
    {
        DatabaseManagement db = new DatabaseManagement();
        public User user;
        private string email;

        public rightWing()
        {
            InitializeComponent();
        }

        public void setter(string email)
        {
            user = db.InitializeUser(email);
            this.email = email;
            MessageBox.Show(user.User_id + user.Email + user.Username + user.School_id + user.DOB + user.Address);
            this.nameHolder.Text = user.Username;
        }
        private void gunaButton2_Click(object sender, EventArgs e)
        {

        }

        private void rightWing_Load(object sender, EventArgs e)
        {

        }

        private void gunaButton10_Click(object sender, EventArgs e)
        {

        }
    }
}
