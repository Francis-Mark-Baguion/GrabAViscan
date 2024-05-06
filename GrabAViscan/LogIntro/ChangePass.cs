using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GrabAViscan.Popup;
using GrabAViscan.Classes;

namespace GrabAViscan.LogIntro
{
    public partial class ChangePass : Form
    {
        private LogIn log;
        private DatabaseManagement db = new DatabaseManagement();
        private string email;
        private string otp;
        public ChangePass(string email, LogIn log,string otp)
        {
            InitializeComponent();
            this.Owner = log;
            this.email = email;    
            this.log = log;
            this.otp = otp; 
            this.Show();
        }

        private void changePass_btn_Click(object sender, EventArgs e)
        {
            try
            {
                if(codeTxt.Text==this.otp && newPassTxt.Text==confirmTxt.Text)
                {
                    
                    
                    if(db.changePass(this.email, db.getPass(this.email), newPassTxt.Text) && ValidatePassword(newPassTxt.Text) && newPassTxt.Text == confirmTxt.Text)
                    {
                        SucMessage mess = new SucMessage("Your password has been reset sucessfully!");
                        this.Close();
                    }
                   
                    
                }
                else
                {
                    if(codeTxt.Text != this.otp)
                    {
                        ErrorMessage err = new ErrorMessage("OTP code did not match");
                    }
                    else if(newPassTxt.Text == db.getPass(this.email)) 
                    {
                        ErrorMessage err = new ErrorMessage("Password already in use");
                    }
                    
                    else if (ValidatePassword(newPassTxt.Text) == false)
                    {
                        ErrorMessage error = new ErrorMessage("The password should be 8 character and contain an Uppercase, special character and a number");
                    }
                    else if(newPassTxt.Text!=confirmTxt.Text)
                    {
                        ErrorMessage error = new ErrorMessage("Confirm password did not match");
                    }
                }
                
            }
            catch(Exception ex) 
            {
            
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

        private void Close_btn_Click(object sender, EventArgs e)
        {
            ForgotPass pass = new ForgotPass(log);
            this.Close();
        }

       
    }
}
