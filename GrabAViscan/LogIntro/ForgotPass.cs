using GrabAViscan.Classes;
using GrabAViscan.Popup;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace GrabAViscan.LogIntro
{
    public partial class ForgotPass : Form
    {
        private DatabaseManagement db = new DatabaseManagement();
        private LogIn log;
        public ForgotPass(LogIn log)
        {
            InitializeComponent();
            this.Owner = log;
            this.log = log; 
            this.Show();
        }

        private void changePass_btn_Click(object sender, EventArgs e)
        {
            try
            {
                if(db.emailExist(emailTxt.Text))
                {
                    SendOTPCode(emailTxt.Text);
                    
                }
                else
                {
                    ErrorMessage error = new ErrorMessage("Email does not exist");
                }
               
            }
            catch (Exception ex)
            
            {
                ErrorMessage err = new ErrorMessage(ex.Message);
            }
            
        }

        private void Close_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SendOTPCode(String email)
        {

            String OTPCode = GenerateOTP(6);
            MailMessage mail = new MailMessage();
            mail.From = new MailAddress("22-1-00745@vsu.edu.ph");
            mail.To.Add(email);
            mail.Subject = "OTP Code Verification [Grab A Viscan]";
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
              <p>Thank you!</p>
            </body>
            </html>";
            mail.Body = htmlBody;
            SmtpClient smtp = new SmtpClient();
            smtp.Host = "smtp.gmail.com";
            smtp.EnableSsl = true;
            NetworkCredential NetworkCred = new NetworkCredential();
            NetworkCred.UserName = "22-1-00745@vsu.edu.ph";
            NetworkCred.Password = "";//Left empty for data privacy
            smtp.UseDefaultCredentials = true;
            smtp.Credentials = NetworkCred;
            smtp.Port = 587;
            MessageBox.Show("Sending email...\nThis may take a while.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            try
            {
                smtp.Send(mail);
                ChangePass changePass = new ChangePass(emailTxt.Text, log, OTPCode);
                this.Close();
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
    }
}
