﻿using MySql.Data.MySqlClient;
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
using System.Xml.Linq;
using GrabAViscan.Popup;
using System.Net.Mail;
using System.Net;
using GrabAViscan.LogIntro;

namespace GrabAViscan
{
    public partial class LogIn : Form
    {
        private DatabaseManagement databaseManagement;
        public LogIn()
        {
            InitializeComponent();
            databaseManagement = new DatabaseManagement();
        }

        private void sigh_up_click(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignUp sign = new SignUp();
            sign.Show();
            this.Hide();
        }


        private void gunaTextBox1_Click(object sender, EventArgs e)
        {
            emailTxt.Text = "";
        }

        private void passwordTxt_Click(object sender, EventArgs e)
        {
            passwordTxt.Text = "";
        }

        private void Log_in_Click(object sender, EventArgs e)
        {
            string email = emailTxt.Text;
            string password = passwordTxt.Text;
            try
            {
                MySqlConnection conConn = databaseManagement.Connect();


                string sql = "SELECT email, password FROM grab.accounts WHERE email=@email AND password=@password";
                MySqlCommand cmd = new MySqlCommand(sql, conConn);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@password", password);

                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    conConn.Close();
                    Home hom = new Home(databaseManagement.get_id(email, password));
                    User user = databaseManagement.InitializeUser(email);
                    hom.setter(email);
                    hom.Show();
                    this.Hide();
                    SucMessage error = new SucMessage("Log In Successful");


                }
                else
                {
                    ErrorMessage error1 = new ErrorMessage("Invalid Email or Password");
                }
                reader.Close();
                conConn.Close();

            }
            catch (Exception ex) 
            {
                ErrorMessage error1 = new ErrorMessage(ex.Message);
            }
            

           
        }

        private void Close_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Minimize_btn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void forgotPassLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ForgotPass forgot = new ForgotPass(this);
        }


       
        /*
        private void SendOTPCode(String email)
        {

            String OTPCode = GenerateOTP(6);
            MailMessage mail = new MailMessage();
            mail.From = new MailAddress("22-1-00109@vsu.edu.ph");
            mail.To.Add(email);
            mail.Subject = "OTP Code Verification [Mabolo Dormitory System]";
            mail.IsBodyHtml = true;
            string htmlBody = $@"
            <html>
            <head>
            <style>
              body {{
                font-family: Arial, sans-serif; 
                font-size: 16px;
              }}
              b {{
                font-weight: bold;
              }}
            </style>
            </head>
            <body>
              <p>Hi,</p>
              <p>Your OTP code for verification is: <b>{OTPCode}</b></p>
              <p>Please enter this code to reset your password.</p>
              <p>This code is valid as long as this is the most recent code. Please do not share it with anyone.</p>
              <p>Thank you, and God bless!</p>
            </body>
            </html>";
            mail.Body = htmlBody;
            SmtpClient smtp = new SmtpClient();
            smtp.Host = "smtp.gmail.com";
            smtp.EnableSsl = true;
            NetworkCredential NetworkCred = new NetworkCredential();
            NetworkCred.UserName = "22-1-00109@vsu.edu.ph";
            NetworkCred.Password = "laurente1234";
            smtp.UseDefaultCredentials = true;
            smtp.Credentials = NetworkCred;
            smtp.Port = 587;
            MessageBox.Show("Sending email...\nThis may take a while.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            try
            {
                smtp.Send(mail);
                OTPForm oTPForm = new OTPForm(OTPCode, email, this);
                SetFormLocation(oTPForm);
                oTPForm.Owner = this;
                oTPForm.Show();
                MessageBox.Show("OTP code sent successfully to " + email, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error sending email: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private string GenerateOTP(int length)
        {
            Random random = new Random();
            StringBuilder otp = new StringBuilder();

            for (int i = 0; i < length; i++)
            {
                otp.Append(random.Next(0, 10));
            }
            return otp.ToString();
        }

        */
    }
}
