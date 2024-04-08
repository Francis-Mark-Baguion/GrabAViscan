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

namespace GrabAViscan
{
    public partial class LogIn : Form
    {
        DatabaseManagement databaseManagement;
        public LogIn()
        {
            InitializeComponent();
            databaseManagement = new DatabaseManagement();
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

            MySqlConnection conConn = databaseManagement.connect();
            string email = emailTxt.Text;
            string password = passwordTxt.Text;

            
            string sql = "SELECT email, password FROM grab.accounts WHERE email=@email AND password=@password";
            MySqlCommand cmd = new MySqlCommand(sql, conConn);
            cmd.Parameters.AddWithValue("@email", email);
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
