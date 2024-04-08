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

namespace GrabAViscan.LogIntro
{
    public partial class SignUpInformation : Form
    {

        string email;
        string pass;
        GunaTextBox mail;
        GunaTextBox passwordTxt;
        SignUp signUp;
        public SignUpInformation()
        {
            InitializeComponent();
            
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
            string con = "server=127.0.0.1;uid=root;pwd=Testing123;database=grab";
            MySqlConnection conConn = new MySqlConnection(con);
            conConn.Open();

            string insertSql = "INSERT INTO grab.accounts (email, password) VALUES (?, ?)";
            MySqlCommand insertCmd = new MySqlCommand(insertSql, conConn);


            insertCmd.Parameters.AddWithValue("@email", email);
            insertCmd.Parameters.AddWithValue("@password", pass);

            insertCmd.ExecuteNonQuery();

            conConn.Close();


            signUp.Hide();
            this.Hide();
            LogIn log = new LogIn();
            log.Show();
            this.Hide();

            MessageBox.Show("Success");
        }
    }
}
