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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
            feed();
            
            
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void feed()
        {
            flow1.Controls.Clear();
            string con = "server=127.0.0.1;uid=root;pwd=Testing123;database=grab";
            MySqlConnection conConn = new MySqlConnection(con);
            conConn.Open();
            string sql = "SELECT * FROM grab.accounts;";
            MySqlCommand cmd = new MySqlCommand(sql, conConn);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {

                int ctr = 0;
                string name = (string)reader["username"];

                HomeFeed home = new HomeFeed(name);
                flow1.Controls.Add(home);


            }
        }

        private void gunaButton2_Click(object sender, EventArgs e)
        {
            flow1.Controls.Clear();
            feed();

        }

        private void gunaButton3_Click(object sender, EventArgs e)
        {
            flow1.Controls.Clear();
        }

        private void emailTxt_Click(object sender, EventArgs e)
        {

        }

        private void gunaTextBox1_Click(object sender, EventArgs e)
        {
            SearchBar.Text = "";
        }

        private void gunaButton10_Click(object sender, EventArgs e)
        {

        }

        private void gunaPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
