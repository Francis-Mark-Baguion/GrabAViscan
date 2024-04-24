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
using GrabAViscan.Popup;
using MySql.Data.MySqlClient;

namespace GrabAViscan
{
    public partial class SignUp : Form
    {

        private DatabaseManagement db = new DatabaseManagement();
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
            Credentials credentials = new Credentials();
            credentials.email = email;
            credentials.password = pass;
            try
            {
                if (credentials.IsValid() && db.ValidateCredentials(email, pass) && ValidatePassword(pass)&&ValidateEmail(email))
                {
                    SignUpInformation signUpInformation = new SignUpInformation();
                    signUpInformation.Show();
                    signUpInformation.BringToFront();
                    signUpInformation.Signup_info(email, pass, emailTxt, passwordTxt, this);
                    signUpInformation.Sign_in_method();

                }
                else
                {
                    if(credentials.IsValid()!=true && db.ValidateCredentials(email, pass)!=true)
                    {
                        ErrorMessage error = new ErrorMessage("Account Already Exist");
                    }
                    else if(ValidateEmail(email)==false)
                    {
                        ErrorMessage error = new ErrorMessage("Invalid Email Format");
                    }
                    else if (ValidatePassword(pass)==false)
                    {
                        ErrorMessage error = new ErrorMessage("The password should contain an Uppercase, special character and a number");
                    }
                   
                }
            }
            catch (Exception ex) 
            
            {
                ErrorMessage err = new ErrorMessage(ex.Message);  
            }
            
        }


        public static bool ValidatePassword(String pass)
        {
            bool hasUpperCase = false;
            bool hasNumber = false;
            bool hasSpecial = false;
            foreach (char c in pass)
            {
                if (char.IsUpper(c))
                    hasUpperCase = true;
                if (char.IsNumber(c))
                    hasNumber = true;
                if (!char.IsLetterOrDigit(c))
                    hasSpecial = true;
            }
            if (hasUpperCase && hasNumber && hasSpecial && pass.Length > 7)
                return true;
            return false;
        }

        public static bool ValidatePhoneNumber(String phoneNumber)
        {
            try
            {
                long.Parse(phoneNumber.Substring(1, 12));
            }
            catch (Exception)
            {
                return false;
            }
            if (phoneNumber.Length != 13 || phoneNumber[0] != '+')
                return false;
            return true;
        }

        public static bool ValidateEmail(String email)
        {
            int atIndex = email.IndexOf('@');
            if (atIndex < 0)
                return false;

            string domain = email.Substring(atIndex + 1);
            if (!domain.EndsWith(".com") && !domain.EndsWith(".ph"))
                return false;
            return true;
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
