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

namespace GrabAViscan.LogIntro
{
    
    public partial class SignUpInformation : Form
    {

        string email;
        string pass;
        GunaTextBox mail;
        GunaTextBox passwordTxt;
        SignUp signUp;

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
            signUp.Hide();
            this.Hide();
            LogIn log = new LogIn();
            log.Show();
            this.Hide();

            MessageBox.Show("Success");

            
        }

        public void Sign_in_method()
        {
            mail.Text = "";
            passwordTxt.Text = "";

            MySqlConnection conConn = db.connect();


            string insertSql = "INSERT INTO grab.accounts (email, password) VALUES (?, ?)";
            MySqlCommand insertCmd = new MySqlCommand(insertSql, conConn);


            insertCmd.Parameters.AddWithValue("@email", email);
            insertCmd.Parameters.AddWithValue("@password", pass);
            try
            {
                insertCmd.ExecuteNonQuery();
                conConn.Close();
            }
            catch (Exception ex)
            {
                this.Close();
                MessageBox.Show(ex.Message);
            }
        }
    }
}
