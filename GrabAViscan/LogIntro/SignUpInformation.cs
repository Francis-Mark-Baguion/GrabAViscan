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
using GrabAViscan.Classes;
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


            mail.Text = "";
            passwordTxt.Text = "";
            if(db.SignUp(email,pass))
            {

                User user = new User(db.get_id(email,pass), email, userName.Text, int.Parse(school_id.Text), DOB.Value, Address.Text, getPhoto(), phoneTxt.Text, bioTxt.Text);
                db.Information_upload(user);
                signUp.Hide();
                this.Hide();
                LogIn log = new LogIn();
                log.Show();
                this.Hide();
                ErrorMessage error = new ErrorMessage("Account Created");
                
            }
            

            
        }

        public void Sign_in_method()
        {
            
        }

        private void upload_btn_Click(object sender, EventArgs e)
        {
            String imageLoc = "";
            try
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Filter = "JPG Files(*.jpg)|*.jpg| PNG Files(*.png)|*.png| All Files(*.*)|*.*";

                if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    imageLoc = ofd.FileName;

                    picture.ImageLocation = imageLoc;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("An error occured", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private byte[] getPhoto()
        {
            MemoryStream stream = new MemoryStream();
            picture.Image.Save(stream, picture.Image.RawFormat);
            return stream.GetBuffer();
        }
    }
}
