using GrabAViscan.Classes;
using GrabAViscan.Popup;
using Guna.UI.WinForms;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace GrabAViscan.Homepage
{
    public partial class Settings : UserControl
    {
        DatabaseManagement db = new DatabaseManagement();
        ChangePass changePass;
        User user;
        string email;
        private bool flag = false;
        private bool flag1 = false;

        public Settings(String email)
        {
            InitializeComponent();
            user = db.InitializeUser(email);
            this.email = email;
            this.nameHolder.Text = user.FirstName + " " + user.LastName;
            this.statusHolder.Text = user.Status;
            this.firstNameTxt.Text = user.FirstName;
            this.lastNameTxt.Text = user.LastName;
            this.addressTxt.Text = user.Address;
            this.phoneTxt.Text = user.PhoneNumber;
            this.schoolTxt.Text = user.School_id + "";
            this.emailTxt.Text = user.Email;
            this.statusTxt.Text = user.Status;
            this.DescriptionTxt.Text = user.Bio;
            SetImageFromByteArrayProfile(this.profile_pic, user.Profile_pic);
            changePass = new ChangePass(this.email);
            changePass.Hide();

        }


        public void setter(string email)
        {
           

        }



        public void SetImageFromByteArrayProfile(GunaCirclePictureBox profile, byte[] byteArray)
        {
            if(byteArray != null)
            using (MemoryStream ms = new MemoryStream(byteArray))
            {
                Image image = Image.FromStream(ms);
                profile.Image = image;
            }
        }


        public void SetImageFromByteArray(GunaPictureBox Image_cont, byte[] byteArray)
        {
            using (MemoryStream ms = new MemoryStream(byteArray))
            {
                Image image = Image.FromStream(ms);
                Image_cont.Image = image;
            }
        }


        private void Settings_Load(object sender, EventArgs e)
        {

        }

        private void gunaPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gunaButton4_Click(object sender, EventArgs e)
        {
            if(flag1)
            {
                changePass.Hide();
                flag1 = false;
            }
            else
            {
                changePass.Show();
                flag1 = true;
            }
            

           
        }

        

        private void emailTxt_Click(object sender, EventArgs e)
        {

        }

        private void upload_btn_Click(object sender, EventArgs e)
        {

            string username = "";
            User use = new User(user.User_id, email,username , int.Parse(schoolTxt.Text), user.DOB, addressTxt.Text, user.Profile_pic, phoneTxt.Text, DescriptionTxt.Text, firstNameTxt.Text, lastNameTxt.Text, statusTxt.Text);
            db.updateUserInformation(use);
            user = db.InitializeUser(email);
            //this.emailTxt.Text = this.email;
            this.nameHolder.Text = user.FirstName + " " + user.LastName;
            this.statusHolder.Text = user.Status;
            this.firstNameTxt.Text = user.FirstName;
            this.lastNameTxt.Text = user.LastName;
            this.addressTxt.Text = user.Address;
            this.phoneTxt.Text = user.PhoneNumber;
            this.schoolTxt.Text = user.School_id + "";
            this.emailTxt.Text = user.Email;
            this.statusTxt.Text = user.Status;
            this.DescriptionTxt.Text = user.Bio;
            SetImageFromByteArrayProfile(this.profile_pic, user.Profile_pic);
        }

        private void discard_btn_Click(object sender, EventArgs e)
        {
            user = db.InitializeUser(email);
            //this.emailTxt.Text = this.email;
            this.nameHolder.Text = user.FirstName + " " + user.LastName;
            this.statusHolder.Text = user.Status;
            this.firstNameTxt.Text = user.FirstName;
            this.lastNameTxt.Text = user.LastName;
            this.addressTxt.Text = user.Address;
            this.phoneTxt.Text = user.PhoneNumber;
            this.schoolTxt.Text = user.School_id + "";
            this.emailTxt.Text = user.Email;
            this.statusTxt.Text = user.Status;
            this.DescriptionTxt.Text = user.Bio;
            SetImageFromByteArrayProfile(this.profile_pic, user.Profile_pic);
        }
        
        
        private void gunaButton3_Click(object sender, EventArgs e)
        {


            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files (*.bmp;*.jpg;*.jpeg;*.png;*.gif)|*.bmp;*.jpg;*.jpeg;*.png;*.gif";
            openFileDialog.Title = "Select Profile Picture";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    
                    byte[] imageData;
                    using (FileStream fs = new FileStream(openFileDialog.FileName, FileMode.Open, FileAccess.Read))
                    {
                        imageData = new byte[fs.Length];
                        fs.Read(imageData, 0, (int)fs.Length);
                    }

                   

                    
                    using (MemoryStream ms = new MemoryStream(imageData))
                    {
                        Image image = Image.FromStream(ms);

                        
                        profile_pic.Image = image;
                    }

                    
                    db.changeUserProfile(imageData, user.User_id);
                }
                catch (Exception ex) 
                {
                    Console.WriteLine("An error occurred (ChangeUserProfile): " + ex.Message);
                    MessageBox.Show("An unexpected error occurred. Please try again later.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    
                }
            }

            
        }

        private void ClickAll(object sender, EventArgs e)
        {
            
        }
    }
}
