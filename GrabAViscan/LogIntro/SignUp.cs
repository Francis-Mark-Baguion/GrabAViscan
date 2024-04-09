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
using GrabAViscan.Classes;
using GrabAViscan.LogIntro;
using MySql.Data.MySqlClient;

namespace GrabAViscan
{
    public partial class SignUp : Form
    {

        DatabaseManagement db = new DatabaseManagement();
        public SignUp()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LogIn log = new LogIn();
            log.Show();
            this.Hide();
        }

        private void emailTxt_Click(object sender, EventArgs e)
        {
            emailTxt.Text = "";
        }

        private void passwordTxt_Click(object sender, EventArgs e)
        {
            passwordTxt.Text = "";
        }

        private void signUp_btn_Click(object sender, EventArgs e)
        {

            string email = emailTxt.Text;
            string pass = passwordTxt.Text;

            if (db.ValidateCredentials(email, pass))
            {
                SignUpInformation signUpInformation = new SignUpInformation();
                signUpInformation.Show();
                signUpInformation.BringToFront();
                signUpInformation.Signup_info(email, pass, emailTxt, passwordTxt, this);
                signUpInformation.Sign_in_method();

            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Close_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Minimize_btn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
