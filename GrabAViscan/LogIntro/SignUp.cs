using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using GrabAViscan.LogIntro;
using MySql.Data.MySqlClient;

namespace GrabAViscan
{
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }

        private void SignUp_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LogIn log = new LogIn();
            log.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SignUpInformation signUpInformation = new SignUpInformation();
            signUpInformation.Show();
            signUpInformation.BringToFront();
            

            string email = emailTxt.Text;
            string pass = passwordTxt.Text;

            signUpInformation.Signup_info(email, pass, emailTxt, passwordTxt,this);
            signUpInformation.Sign_in_method();







        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void emailTxt_Click(object sender, EventArgs e)
        {
            emailTxt.Text = "";
        }

        private void passwordTxt_Click(object sender, EventArgs e)
        {
            passwordTxt.Text = "";
        }
    }
}
