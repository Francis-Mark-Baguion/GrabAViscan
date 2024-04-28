using GrabAViscan.Classes;
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

using GrabAViscan.Popup;
using System.IO;

namespace GrabAViscan.LogIntro
{
    
    public partial class SignUpInformation : Form
    {

        private string email;
        private string pass;
        private GunaTextBox mail;
        private GunaTextBox passwordTxt;
        private SignUp signUp;

        DatabaseManagement db;
        public SignUpInformation(SignUp signup)
        {
            InitializeComponent();
            db = new DatabaseManagement();
            this.Owner = signup;    
            
        }

        private void SignUpInformation_Load(object sender, EventArgs e)
        {

        }

        

        public void Signup_info(string email, string pass , GunaTextBox mail, GunaTextBox passwordTxt, SignUp signUp) 
        {
            this.email = email;
            this.pass = pass;
            this.mail= mail;
            this.passwordTxt = passwordTxt;
            this.signUp= signUp;
            
        }

        

        private void gunaButton1_Click(object sender, EventArgs e)
        {

            string bio = "";
            string username = "";
            byte[] photo = null;
            passwordTxt.Text = "";

            try
            {
                if (!string.IsNullOrEmpty(school_id.Text) && int.Parse(school_id.Text) != 0 && Address.Text != "" && firstNameTxt.Text != "" && lastNameTxt.Text != "" && ValidatePhoneNumber(phoneTxt.Text)  && statusCombo.Text != "" )
                {
                    db.SignUp(email, pass);
                    MessageBox.Show(db.get_id(email, pass)+"");
                    User user = new User(db.get_id(email, pass), email, username, int.Parse(school_id.Text), DOB.Value, Address.Text, photo, phoneTxt.Text, bio, firstNameTxt.Text, lastNameTxt.Text, statusCombo.Text);
                    
                    db.Information_upload(user);
                    signUp.Hide();
                    this.Hide();
                    LogIn log = new LogIn();
                    log.Show();
                    this.Hide();
                    SucMessage error = new SucMessage("Account Created");

                }
                else
                {
                    if(string.IsNullOrEmpty(school_id.Text))
                    {
                        ErrorMessage err1 = new ErrorMessage("School Id should not be empty");
                    }
                    else if(Address.Text == "")
                    {
                        ErrorMessage err1 = new ErrorMessage("adress should not be empty");
                    }
                    else if (firstNameTxt.Text == "" || lastNameTxt.Text == "")
                    {
                        ErrorMessage err1 = new ErrorMessage("Name should not be empty");
                    }
                    else if (statusCombo.Text == "")
                    {
                        ErrorMessage err1 = new ErrorMessage("Status should not be empty");
                    }
                    else if(ValidatePhoneNumber(phoneTxt.Text)==false) 
                    {
                        ErrorMessage err1 = new ErrorMessage("Invalid format of Phone number");
                    }
                    
                        
                   
                    
                }
            }
            catch (Exception ex) 
            {
                ErrorMessage arr = new ErrorMessage(ex.Message);
            }
               
            

            
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

        public void Sign_in_method()
        {
            
        }

        private void Close_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
