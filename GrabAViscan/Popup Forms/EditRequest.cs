using GrabAViscan.Classes;
using Guna.UI.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GrabAViscan.Popup
{
    public partial class EditRequest : Form
    {
        DatabaseManagement db = new DatabaseManagement();
        User user;
        int Post_id;
        Home home;
        public EditRequest(Home home,Posting post)
        {
            InitializeComponent();
            this.Owner = home;
            categoryCombo.DataSource = db.categories;
            categoryCombo.ValueMember = "ID";
            categoryCombo.DisplayMember = "Name";

            pickNearCombo.DataSource = db.locations;
            pickNearCombo.ValueMember = "LocationName";
            pickNearCombo.DisplayMember = "LocationName";

            deliverNearCombo.DataSource = db.CopyLocationData(db.locations);
            deliverNearCombo.ValueMember = "LocationName";
            deliverNearCombo.DisplayMember = "LocationName";
            this.home = home;
            this.Post_id = post.Post_id;
            this.user = db.getUserById(post.User_id);
            this.requestTxt.Text = post.Requested;
            this.quantityTxt.Text = post.Quantity;
            this.TimePicker.Value = post.Deadline;
            this.categoryCombo.Text = post.Category;
            this.pickUpTxt.Text = post.Pick_up;
            this.pickNearCombo.Text = post.Near_pickUp;
            this.deliveryTxt.Text = post.Delivery_location;
            this.deliverNearCombo.Text = post.Near_deliveryLocation;
            this.feeTxt.Text = post.Fee + "";
            this.CommentTxt.Text = post.Description;
            if(post.image != null)
            {
                SetImageFromByteArray1(picture, post.image);
            }
            else
            {
                picture.Image = null;
                picture.Refresh();
            }
            


        }
        public void homeSetter(Home home)
        {
            this.home = home;
        }

        public EditRequest(Posting post,Home home)
        {
            InitializeComponent();
            this.home = home;
            this.Owner = home;
            categoryCombo.DataSource = db.categories;
            categoryCombo.ValueMember = "ID";
            categoryCombo.DisplayMember = "Name";

            pickNearCombo.DataSource = db.locations;
            pickNearCombo.ValueMember = "LocationName";
            pickNearCombo.DisplayMember = "LocationName";

            deliverNearCombo.DataSource = db.CopyLocationData(db.locations);
            deliverNearCombo.ValueMember = "LocationName";
            deliverNearCombo.DisplayMember = "LocationName";
            
            this.Post_id = post.Post_id;
            this.user = db.getUserById(post.User_id);
            this.requestTxt.Text = post.Requested;
            this.quantityTxt.Text = post.Quantity;
            this.TimePicker.Value = post.Deadline;
            this.categoryCombo.Text = post.Category;
            this.pickUpTxt.Text = post.Pick_up;
            this.pickNearCombo.Text = post.Near_pickUp;
            this.deliveryTxt.Text = post.Delivery_location;
            this.deliverNearCombo.Text = post.Near_deliveryLocation;
            this.feeTxt.Text = post.Fee + "";
            this.CommentTxt.Text = post.Description;
            if (post.image != null)
            {
                SetImageFromByteArray1(picture, post.image);
            }
            else
            {
                picture.Image = null;
                picture.Refresh();
            }
            upload_btn.Text = "Repost";
            this.Show();

        }



        public void SetImageFromByteArray1(GunaPictureBox Image_cont, byte[] byteArray)
        {
            if (byteArray != null)
            {
                using (MemoryStream ms = new MemoryStream(byteArray))
                {
                    Image image = Image.FromStream(ms);
                    Image_cont.Image = image;
                }
            }
            else  Image_cont.Image = null;
        }


        private void upload_btn_Click(object sender, EventArgs e)
        {
            


            int User_id = user.User_id;
            string Requested = requestTxt.Text;
            string Quantity = quantityTxt.Text;
            int Fee = 0;
            if (feeTxt.Text == "")
            {
                feeTxt.Text = "0";
            }
            try
            {

                if (!Regex.IsMatch(feeTxt.Text, @"^-?\d+(\.\d*)?$"))
                {
                    ErrorMessage err = new ErrorMessage("Invalid fee format. Please enter a valid number.");
                    this.Close();
                }
                Fee = Convert.ToInt32(feeTxt.Text);

            }
            catch (FormatException ex)
            {
                ErrorMessage err = new ErrorMessage("Invalid fee format. Please enter a valid number." + ex);

            }
            catch (OverflowException ex)
            {
                ErrorMessage mess = new ErrorMessage("The entered fee value is too large or too small for an integer. Please enter a value within the valid range.");

            }
            Fee += 10;
            string Description = CommentTxt.Text;
            DateTime Date_posted = DateTime.Now;
            DateTime Deadline = TimePicker.Value;
            string Category = categoryCombo.Text;
            byte[] image = null;
              
            if (this.getPhoto() != null)
            {
                image  = this.getPhoto();
            }
               

            string Pick_up = pickUpTxt.Text;
            string Near_pickUp = pickNearCombo.Text;
            string Delivery_location = deliveryTxt.Text;
            string Near_deliveryLocation = deliverNearCombo.Text;
            int Available = 0;
            
            Posting post = null;
            post = new Posting(Post_id, User_id, Requested, Quantity, Fee, Description, Date_posted, Deadline, Category, image, Pick_up, Near_pickUp, Delivery_location, Near_deliveryLocation, Available);
            db.updatePostingInformation(post);
            home.My_Request_click(sender, e);
            this.Hide();
        }





        private byte[] getPhoto()
        {
            MemoryStream stream = new MemoryStream();
            if (picture.Image != null) // Check if picture.Image exists
            {
                picture.Image.Save(stream, picture.Image.RawFormat);
                return stream.GetBuffer();
            }
            return null;
           
        }

        private void uploadImage_btn_Click(object sender, EventArgs e)
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

        private void discard_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void gunaShadowPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
