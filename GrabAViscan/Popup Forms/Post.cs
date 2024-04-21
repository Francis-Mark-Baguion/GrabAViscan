﻿using GrabAViscan.Classes;
using Org.BouncyCastle.Asn1.Ocsp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using Image = System.Drawing.Image;

namespace GrabAViscan.Popup
{
    public partial class Post : Form
    {

        DatabaseManagement db = new DatabaseManagement();
        public User user;
        public string email;
        Home home;
        public Post()
        {
            InitializeComponent();
            categoryCombo.DataSource = db.categories;
            categoryCombo.ValueMember = "ID";
            categoryCombo.DisplayMember = "Name";

            pickNearCombo.DataSource = db.locations;
            pickNearCombo.ValueMember = "LocationName";
            pickNearCombo.DisplayMember = "LocationName";
            
            deliverNearCombo.DataSource = db.CopyLocationData(db.locations);
            deliverNearCombo.ValueMember = "LocationName";
            deliverNearCombo.DisplayMember = "LocationName";


        }

        

        public void setter(string email,Home home)
        {
            user = db.InitializeUser(email);
            this.email = email;
            this.home = home;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Category cat = categoryCombo.SelectedItem as Category;
            if (cat != null) 
            { 
                categoryCombo.Text = cat.Name;
            }
        }

        private void pickNearCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            Location loc = pickNearCombo.SelectedItem as Location;
            if (loc != null)
            {
                pickNearCombo.Text = loc.LocationName;
            }
        }

        private void deliverNearCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            Location loc = deliverNearCombo.SelectedItem as Location;
            if (loc != null)
            {
                deliverNearCombo.Text = loc.LocationName;
            }
        }

        private void gunaButton1_Click(object sender, EventArgs e)
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

        private void picture_Click(object sender, EventArgs e)
        {

        }

        private void upload_btn_Click(object sender, EventArgs e)
        {
            
            Image originalImage = picture.Image;

            int Post_id = 0;
            int User_id = user.User_id;
            string Requested = requestTxt.Text;
            string Quantity = quantityTxt.Text;
            int Fee = 0;

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

            try
            {
                string Description = CommentTxt.Text;
                DateTime Date_posted = DateTime.Now;
                
                DateTime Deadline = TimePicker.Value;
                string Category = categoryCombo.Text;
                byte[] image = this.getPhoto();
                if (this.getPhoto() != null)
                {
                    image = this.getPhoto();
                }

                string Pick_up = pickUpTxt.Text;
                string Near_pickUp = pickNearCombo.Text;
                string Delivery_location = deliveryTxt.Text;
                string Near_deliveryLocation = deliverNearCombo.Text;
                int Available = 0;
                
                Posting post = null;


                
                string ded = Deadline.ToString("M");
                string start = Date_posted.ToString("M");
                if(ded==start)
                {
                    throw new Exception("The deadline must be a future date");
                }


                if ( Requested != "" && Fee != 0 && Category != "" && Pick_up != "" && Delivery_location != "" && Near_deliveryLocation!="")
                {
                    post = new Posting(Post_id, User_id, Requested, Quantity, Fee, Description, Date_posted, Deadline, Category, image, Pick_up, Near_pickUp, Delivery_location, Near_deliveryLocation, Available);
                    db.Post_upload(post);
                    requestTxt.Text = "";
                    quantityTxt.Text = "";
                    categoryCombo.Text = "";
                    pickUpTxt.Text = "";
                    pickNearCombo.Text = "";
                    deliveryTxt.Text = "";
                    deliverNearCombo.Text = "";
                    picture.Image  = null;
                    feeTxt.Text = "";
                    CommentTxt.Text = "";
                    TimePicker.Value = DateTime.Today;


                }
                else 
                {
                    this.Hide();
                    ErrorMessage err = new ErrorMessage("Invalid Information");
                }
                
                this.Hide();
            }
            catch(Exception ex)
            {
                ErrorMessage err = new ErrorMessage(ex.Message);
                this.Hide();
            }
            
           
        }



        private byte[] getPhoto()
        {
            MemoryStream stream = new MemoryStream();
            if (picture.Image != null) // Check if picture.Image exists
            {
                picture.Image.Save(stream, picture.Image.RawFormat);
            }

            return stream.GetBuffer();
        }

        private void requestTxt_Click(object sender, EventArgs e)
        {

        }

        private void discard_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}