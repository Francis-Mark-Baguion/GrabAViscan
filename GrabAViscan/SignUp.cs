using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using MySql.Data.MySqlClient;

namespace GrabAViscan
{
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }

        private void SignUp_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LogIn log = new LogIn();
            log.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            string user = usernameTxt.Text;
            string pass = passwordTxt.Text;

            usernameTxt.Text = "";
            passwordTxt.Text = "";
            string con = "server=127.0.0.1;uid=root;pwd=Testing123;database=grab";
            MySqlConnection conConn = new MySqlConnection(con);
            conConn.Open();

            string insertSql = "INSERT INTO grab.accounts (username, password) VALUES (?, ?)";
            MySqlCommand insertCmd = new MySqlCommand(insertSql, conConn);

            
            insertCmd.Parameters.AddWithValue("@username", user);
            insertCmd.Parameters.AddWithValue("@password", pass);

            insertCmd.ExecuteNonQuery();

            conConn.Close();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
