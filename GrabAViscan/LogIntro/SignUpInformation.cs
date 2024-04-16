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
        public SignUpInformation()
        {
            InitializeComponent();
            db = new DatabaseManagement();
            
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
            if(db.SignUp(email,pass))
            {

                User user = new User(db.get_id(email,pass), email, username, int.Parse(school_id.Text), DOB.Value, Address.Text, photo, phoneTxt.Text, bio,firstNameTxt.Text, lastNameTxt.Text, statusCombo.Text);
                db.Information_upload(user);
                signUp.Hide();
                this.Hide();
                LogIn log = new LogIn();
                log.Show();
                this.Hide();
                SucMessage error = new SucMessage("Account Created");
                
            }
            

            
        }

        public void Sign_in_method()
        {
            
        }




        
    }
}
