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

namespace GrabAViscan
{
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignUp sign = new SignUp();
            sign.Show();
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string con = "server=127.0.0.1;uid=root;pwd=Testing123;database=grab";
            MySqlConnection conConn = new MySqlConnection(con);
            conConn.Open();
            
            string username = emailTxt.Text;
            string password = passwordTxt.Text;

            
            string sql = "SELECT username, password FROM grab.accounts WHERE username=@username AND password=@password";
            MySqlCommand cmd = new MySqlCommand(sql, conConn);
            cmd.Parameters.AddWithValue("@username", username);
            cmd.Parameters.AddWithValue("@password", password);

            MySqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                MessageBox.Show("Account exists");
                Home hom = new Home();
                hom.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid username or password");
            }

            reader.Close();
            conConn.Close();
        }

        

        private void gunaTextBox1_Click(object sender, EventArgs e)
        {
            emailTxt.Text = "";
        }

        private void passwordTxt_Click(object sender, EventArgs e)
        {
            passwordTxt.Text = "";
        }
    }
}
