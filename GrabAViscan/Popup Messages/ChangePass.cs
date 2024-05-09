using GrabAViscan.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GrabAViscan.Popup
{
    public partial class ChangePass : Form
    {
        private DatabaseManagement db = new DatabaseManagement();
        private string email;
        public ChangePass(string email,Home home)
        {
            InitializeComponent();
            this.Owner = home;
            this.email = email;
            this.Curr.Text = "";
            this.newPass.Text = "";
            this.conFirm.Text = "";

        }

        private void gunaLabel1_Click(object sender, EventArgs e)
        {

        }

        private void gunaButton4_Click(object sender, EventArgs e)
        {
            

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

        private void gunaButton4_Click_1(object sender, EventArgs e)
        {

            try
            {
                string pass = db.getPass(email);
                if (newPass.Text == conFirm.Text && ValidatePassword(newPass.Text) && pass==Curr.Text)
                {
                    db.changePass(email, this.Curr.Text, this.newPass.Text);
                    this.Curr.Text = ""; 
                    this.newPass.Text = "";
                    this.conFirm.Text = "";
                    this.Hide();
                }
                else
                {

                    if(pass!=Curr.Text)
                    {
                        ErrorMessage error = new ErrorMessage("Current password did not match");
                    }
                    else if(newPass.Text!= conFirm.Text)
                    {
                        ErrorMessage error = new ErrorMessage("Confirmation and new password did not match");
                    }
                    else if(ValidatePassword(newPass.Text)!=true)
                    {
                        ErrorMessage error = new ErrorMessage("The password should be 8 character and contain an Uppercase, special character and a number");
                    }
                }

            }
            catch (Exception ex) 
            {
                ErrorMessage error = new ErrorMessage(ex.Message);
            }
        }

        private void gunaButton3_Click(object sender, EventArgs e)
        {
            this.Curr.Text = "";
            this.newPass.Text = "";
            this.conFirm.Text = "";
            this.Hide();
        }
    }
}
