using GrabAViscan.Classes;
using GrabAViscan.Feed;
using GrabAViscan.Popup;
using Guna.UI.WinForms;
using Org.BouncyCastle.Asn1.Cmp;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;

namespace GrabAViscan.Homepage
{
    public partial class Settings : UserControl
    {
        private DatabaseManagement db = new DatabaseManagement();
        private ChangePass changePass;
        private User user;
        string email;
        private bool flag = false;
        private bool flag1 = false;
        private int id;
        private Home home;
        public Settings(String email,Home home)
        {
            InitializeComponent();
            this.home = home;
            user = db.InitializeUser(email);
            this.id = user.User_id;
            this.email = email;
            this.nameHolder.Text = user.FirstName + " " + user.LastName;
            
            this.firstNameTxt.Text = user.FirstName;
            this.lastNameTxt.Text = user.LastName;
            this.addressTxt.Text = user.Address;
            this.phoneTxt.Text = user.PhoneNumber;
            
            this.statusTxt.Text = user.Status;
            this.DescriptionTxt.Text = user.Bio;
            this.emailDisplay.Text = user.Email;
            SetImageFromByteArrayProfile(this.profile_pic, user.Profile_pic);
            changePass = new ChangePass(this.email,home);
            changePass.Hide();
            setctr();
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

        private void changePass_click(object sender, EventArgs e)
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

        private void update_click(object sender, EventArgs e)
        {
            try
            {
                if(ValidatePhoneNumber(phoneTxt.Text) && firstNameTxt.Text != "" && lastNameTxt.Text != "" && addressTxt.Text != "" && statusTxt.Text != "")
                {
                    string username = "";
                    User use = new User(user.User_id, email, username, user.School_id, user.DOB, addressTxt.Text, user.Profile_pic, phoneTxt.Text, DescriptionTxt.Text, firstNameTxt.Text, lastNameTxt.Text, statusTxt.Text);
                    db.updateUserInformation(use);
                    user = db.InitializeUser(email);

                    this.nameHolder.Text = user.FirstName + " " + user.LastName;
                    
                    this.firstNameTxt.Text = user.FirstName;
                    this.lastNameTxt.Text = user.LastName;
                    this.addressTxt.Text = user.Address;
                    this.phoneTxt.Text = user.PhoneNumber;
                    
                    this.statusTxt.Text = user.Status;
                    this.DescriptionTxt.Text = user.Bio;
                    SetImageFromByteArrayProfile(this.profile_pic, user.Profile_pic);
                }
                else
                {
                    if(firstNameTxt.Text == "" || lastNameTxt.Text == "")
                    {
                        ErrorMessage err = new ErrorMessage("Name should not be blank");
                    }
                    else if(addressTxt.Text == "")
                    {
                        ErrorMessage err = new ErrorMessage("Address should not be blank");
                    }
                    else if(ValidatePhoneNumber(phoneTxt.Text)==false) 
                    {
                        ErrorMessage err = new ErrorMessage("Invalid Phone number format");
                    }
                    else if(statusTxt.Text =="")
                    {
                        ErrorMessage err = new ErrorMessage("Invalid Status");
                    }
                }
                
            }
            catch (Exception ex)
            {
                ErrorMessage err = new ErrorMessage(ex.Message);
            }
            
        }

        private void discard_btn_Click(object sender, EventArgs e)
        {
            try
            {
                user = db.InitializeUser(email);

                this.nameHolder.Text = user.FirstName + " " + user.LastName;
                
                this.firstNameTxt.Text = user.FirstName;
                this.lastNameTxt.Text = user.LastName;
                this.addressTxt.Text = user.Address;
                this.phoneTxt.Text = user.PhoneNumber;
                
                this.statusTxt.Text = user.Status;
                this.DescriptionTxt.Text = user.Bio;
                SetImageFromByteArrayProfile(this.profile_pic, user.Profile_pic);
            }
            catch (Exception ex) 
            {
                ErrorMessage errorMessage = new ErrorMessage(ex.Message);
            }
           
        }
        
        
        private void changeProfile_click(object sender, EventArgs e)
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
                    user = db.getUserById(id);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("An error occurred (ChangeUserProfile): " + ex.Message);
                    MessageBox.Show("An unexpected error occurred. Please try again later.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }




        }


        private byte[] getPhoto()
        {
            try
            {
                if (profile_pic.Image != null)
                {
                    
                    string fileName = Path.Combine(Path.GetTempPath(), Path.GetRandomFileName() + ".jpg");

                    
                    profile_pic.Image.Save(fileName, ImageFormat.Jpeg); 

                   
                    byte[] imageData;
                    using (FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read))
                    {
                        imageData = new byte[fs.Length];
                        fs.Read(imageData, 0, (int)fs.Length);
                    }

                   
                    File.Delete(fileName);

                    return imageData;
                }
            }
            catch (Exception ex)
            {
                
                Console.WriteLine("Error getting photo: " + ex.Message);
            }

            return null;
        }

        private void ClickAll(object sender, EventArgs e)
        {
            
        }

        private int reqCtr()
        {
            List<Posting> posts = db.getAllPost();
            int ctr = 0;

            foreach (Posting post in posts )
            {
                if (post.User_id == this.id)
                {

                    ctr++;
                    
                }
            }
            
            return ctr;
        }

        private int delCtr()
        {
            int ctr = 0;
            List<Deliver> deliveries = db.GetDeliveriesById(this.id);


            foreach (Deliver delivery in deliveries)
            {
                Posting post = db.getPostById(delivery.Post_Id);
                if (post.Available == 4)
                {

                    ctr++;


                }
                else if (post.Available == 3)
                {
                    ctr++;
                }
                else if (post.Available == 5 || post.Available == 10)
                {
                    ctr++;
                }

                

            }

            return ctr;
        }

        public void setctr()
        {
            this.request.Text = reqCtr()+"";
            this.deliveryCtr.Text = delCtr() + "";
            int total = reqCtr() + delCtr();
            this.completedCtr.Text = total +"";
        }

        private void EmailDisplay_Click(object sender, EventArgs e)
        {

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
    }
}
