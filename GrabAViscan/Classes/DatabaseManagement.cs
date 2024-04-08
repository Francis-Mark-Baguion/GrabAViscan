using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;




namespace GrabAViscan.Classes
{
    public class DatabaseManagement
    {



        public MySqlConnection connect()
        {
            string con = "server=127.0.0.1;uid=root;pwd=Testing123;database=grab";
            MySqlConnection conConn = new MySqlConnection(con);
            

            try
            {
                conConn.Open();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Connection Established" + ex);
            }

            return conConn;
        }


        
    }


    
}
