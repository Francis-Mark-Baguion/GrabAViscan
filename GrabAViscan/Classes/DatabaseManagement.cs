using GrabAViscan.Feed;
using MySql.Data.MySqlClient;
using Mysqlx.Crud;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;




namespace GrabAViscan.Classes
{
    public class DatabaseManagement
    {

        

        public MySqlConnection Connect()
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


        public User InitializeUser(string email)
        {


            using (MySqlConnection connection = Connect())
            {
                
                try
                {
                    using (MySqlCommand command = new MySqlCommand("SELECT * FROM grab.user_information WHERE email = @email", connection))
                    {
                        command.Parameters.AddWithValue("@email", email);
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            User user = null;
                            while (reader.Read())
                            {
                                user = new User((int)reader["user_id"], (string)reader["email"],(string)reader["Username"], (int)reader["School_id"], (DateTime)reader["DateOfBirth"], (string)reader["Address"]);
                            }

                            
                            return user;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("There was an error while retrieving user: " + ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
            return null;

        }

        








        public bool ValidateCredentials(string email, string password)
        {
            MySqlConnection conConn = this.Connect();
           


            string sql = "SELECT email, password FROM grab.accounts WHERE email=@email AND password=@password";
            MySqlCommand cmd = new MySqlCommand(sql, conConn);
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@password", password);

            MySqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                MessageBox.Show("Email account already exist");
                return false;
            }
            else
            {
                
                return true;
            }

            reader.Close();
            conConn.Close();
        }



        public bool SignUp(string email, string pass) 
        {
            MySqlConnection conConn = Connect();


            string insertSql = "INSERT INTO grab.accounts (email, password) VALUES (?, ?)";
            MySqlCommand insertCmd = new MySqlCommand(insertSql, conConn);


            insertCmd.Parameters.AddWithValue("@email", email);
            insertCmd.Parameters.AddWithValue("@password", pass);
            try
            {
                insertCmd.ExecuteNonQuery();

                conConn.Close();
                return true;
            }
            catch (Exception ex)
            {
                
                MessageBox.Show(ex.Message+ " SignUp Function");
                conConn.Close();
                return false;

            }

           
        }

        public int get_id(string email, string pass)
        {
            using (MySqlConnection conConn = this.Connect())
            {
                string sql = "SELECT account_id FROM grab.accounts WHERE email=@email AND password=@password";
                MySqlCommand cmd = new MySqlCommand(sql, conConn);

                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@password", pass);

                using (MySqlDataReader reader = cmd.ExecuteReader()) // Use a using block for reader
                {
                    if (reader.Read())
                    {
                        return reader.GetInt32(0); // Return account ID if found
                    }
                    else
                    {
                        // Handle case where no user found (return -1 or throw an exception?)
                        return -1; // Consider returning a specific value or throwing an exception
                    }
                }
            }
        }


        public void Information_upload(string email,string pass , string username, int school_id ,DateTime dob,string address ) 
        {
            MySqlConnection conConn = Connect();
            int user_id = get_id(email,pass);

            string insertSql = "INSERT INTO grab.user_information (user_id,Username,School_id,DateOfBirth,Address,email) VALUES (?,?,?,?,?,?)";
            MySqlCommand insertCmd = new MySqlCommand(insertSql, conConn);


            
            insertCmd.Parameters.AddWithValue("@user_id", user_id);
            insertCmd.Parameters.AddWithValue("@Username", username);
            insertCmd.Parameters.AddWithValue("@School_id", school_id);
            insertCmd.Parameters.AddWithValue("@DateOfBirth", dob);
            insertCmd.Parameters.AddWithValue("@Address", address);
            insertCmd.Parameters.AddWithValue("@email", email);
            
            try
            {
                insertCmd.ExecuteNonQuery();

                conConn.Close();
                
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                conConn.Close();
                

            }
        }
        
    }


    
}
