 using GrabAViscan.Feed;
using GrabAViscan.Popup;
using MySql.Data.MySqlClient;
using Mysqlx.Crud;
using MySqlX.XDevAPI.Relational;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;




namespace GrabAViscan.Classes
{
    public class DatabaseManagement
    {
        public List<Category> categories;
        public List<Location>  locations;

        public DatabaseManagement() 
        {
            GetCategories();
            GetLocations();
        }

        

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
                                byte[] profilePic = reader["Profile_pic"] != DBNull.Value ? (byte[])reader["Profile_pic"] : null;
                                user = new User((int)reader["user_id"], (string)reader["email"], (string)reader["Username"], (int)reader["School_id"], (DateTime)reader["DateOfBirth"], (string)reader["Address"] , profilePic, (string)reader["PhoneNum"], (string)reader["Bio"], (string)reader["FirstName"], (string)reader["LastName"], (string)reader["Status"]);
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
                ErrorMessage error = new ErrorMessage("Email account already exist");
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

                MessageBox.Show(ex.Message + " SignUp Function");
                conConn.Close();
                return false;

            }


        }

        public int get_id(string email, string pass)
        {
            using (MySqlConnection conConn = this.Connect())
            {
                string sql = "SELECT * FROM grab.accounts WHERE email=@email AND password=@password";
                MySqlCommand cmd = new MySqlCommand(sql, conConn);

                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@password", pass);

                using (MySqlDataReader reader = cmd.ExecuteReader()) 
                {
                    if (reader.Read())
                    {
                        return reader.GetInt32(0); 
                    }
                    else
                    {
                        
                        return -1; 
                    }
                }
            }
        }


        public void Information_upload(User user)
        {
            using (MySqlConnection conConn = Connect()) 
            {
                try
                {
                    string insertSql = "INSERT INTO grab.user_information (user_id,Username, School_id, DateOfBirth, Address, email, Profile_pic, PhoneNum, Bio,FirstName,LastName,Status) VALUES (?, ?, ?, ?, ?, ?, ?, ?,?, ?, ?,?)";
                    MySqlCommand insertCmd = new MySqlCommand(insertSql, conConn);

                    
                    insertCmd.Parameters.AddWithValue("@user_id", user.User_id);
                    insertCmd.Parameters.AddWithValue("@Username", user.Username);
                    insertCmd.Parameters.AddWithValue("@School_id", user.School_id);
                    insertCmd.Parameters.AddWithValue("@DateOfBirth", user.DOB);
                    insertCmd.Parameters.AddWithValue("@Address", user.Address);
                    insertCmd.Parameters.AddWithValue("@email", user.Email); 
                    if (user.Profile_pic != null && user.Profile_pic.Length > 0)
                    {
                        insertCmd.Parameters.AddWithValue("@Profile_pic", user.Profile_pic);
                    }
                    else
                    {
                        insertCmd.Parameters.AddWithValue("@Profile_pic", DBNull.Value); 
                    }
                    

                    insertCmd.Parameters.AddWithValue("@PhoneNum", user.PhoneNumber); 
                    insertCmd.Parameters.AddWithValue("@Bio", user.Bio);
                    insertCmd.Parameters.AddWithValue("@FirstName", user.FirstName);
                    insertCmd.Parameters.AddWithValue("@LastName", user.LastName);
                    insertCmd.Parameters.AddWithValue("@Status", user.Status);


                    ErrorMessage error = new ErrorMessage("Account Created!");
                    insertCmd.ExecuteNonQuery();

                }
                catch (MySqlException ex)
                {
                    
                    Console.WriteLine("An error occurred: " + ex.Message);
                    
                }
            }
        }


        public void Post_upload(Posting post)
        {
            
            using (MySqlConnection conConn = new MySqlConnection("server=127.0.0.1;uid=root;pwd=Testing123;database=grab"))
            {
                try
                {
                    conConn.Open();

                    
                    string sql = "INSERT INTO grab.post (User_id, Requested, Quantity, Fee, Description, Date_posted, Deadline, Category, Image, Pick_location,Near_pickUp_id,Delivery_location,Near_delivery_id,isAvailable) VALUES (?,?,?,?,?,?,?,?,?,?,?,?,?,?)";

                    MySqlCommand cmd = new MySqlCommand(sql, conConn);


                    cmd.Parameters.AddWithValue("@User_id", post.User_id);
                    cmd.Parameters.AddWithValue("@Requested", post.Requested);
                    cmd.Parameters.AddWithValue("@Quantity", post.Quantity);
                    cmd.Parameters.AddWithValue("@Fee", post.Fee);
                    cmd.Parameters.AddWithValue("@Description", post.Description);
                    cmd.Parameters.AddWithValue("@Date_posted", post.Date_posted);
                    cmd.Parameters.AddWithValue("@Deadline", post.Deadline);

                    
                    cmd.Parameters.AddWithValue("@Category", post.Category);

                    
                    if (post.image != null && post.image.Length > 0)
                    {
                        cmd.Parameters.AddWithValue("@Image", post.image);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@Image", DBNull.Value); 
                    }

                    
                    cmd.Parameters.AddWithValue("@Pick_location", post.Pick_up);
                    cmd.Parameters.AddWithValue("@Near_pickUp_id", GetLocationID(post.Near_pickUp));
                    cmd.Parameters.AddWithValue("@Delivery_location", post.Delivery_location);
                    cmd.Parameters.AddWithValue("@Near_delivery_id", GetLocationID(post.Near_deliveryLocation));
                    cmd.Parameters.AddWithValue("@isAvailable", post.Available);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("it went here");
                }
                catch (MySqlException ex)
                {
                    
                    Console.WriteLine("An error occurred: " + ex.Message);
                }
            }
        }



        private int GetLocationID(string location)
        {

            using (MySqlConnection conConn = new MySqlConnection("server=127.0.0.1;uid=root;pwd=Testing123;database=grab"))
            {
                try
                {
                    conConn.Open();

                    
                    string sql = "SELECT * FROM grab.location WHERE LocationName = @LocationName";
                    MySqlCommand cmd = new MySqlCommand(sql, conConn);

                    cmd.Parameters.AddWithValue("@LocationName", location);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return reader.GetInt32("idLocation");
                        }
                        else
                        {
                            
                            Console.WriteLine("Location not found: " + location);
                            return -1; 
                        }
                    }
                }
                catch (MySqlException ex)
                {
                    
                    Console.WriteLine("An error occurred (getLocationId): " + ex.Message);
                    return -1; 
                }
            }
        }


        public void GetCategories()
        {
           categories = new List<Category>();

            using (MySqlConnection conConn = new MySqlConnection("server=127.0.0.1;uid=root;pwd=Testing123;database=grab"))
            {
                try
                {
                    conConn.Open();

                    string sql = "SELECT * FROM grab.category";
                    MySqlCommand cmd = new MySqlCommand(sql, conConn);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int categoryId = reader.GetInt32("categoryId");
                            string categoryName = reader.GetString("name");

                            
                            Category category = new Category(categoryId, categoryName);
                            categories.Add(category);
                        }
                    }
                }
                catch (MySqlException ex)
                {
                    Console.WriteLine("An error occurred: " + ex.Message);
                    
                }
            }

            
        }


        public void GetLocations()
        {
            locations = new List<Location>();

            using (MySqlConnection conConn = new MySqlConnection("server=127.0.0.1;uid=root;pwd=Testing123;database=grab"))
            {
                try
                {
                    conConn.Open();

                    string sql = "SELECT * FROM grab.location";
                    MySqlCommand cmd = new MySqlCommand(sql, conConn);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int LocationId = reader.GetInt32("idLocation");
                            string LocationName = reader.GetString("locationName");

                            
                            Location location = new Location(LocationId, LocationName);
                            locations.Add(location);
                        }
                    }
                }
                catch (MySqlException ex)
                {
                    Console.WriteLine("An error occurred: " + ex.Message);
                    
                }
            }


        }

        public List<Location> CopyLocationData(List<Location> loc)
        {
            return loc.ToList();
        }



        public List<Posting> GetAvailablePosts()
        {
            List<Posting> posts = new List<Posting>();

            using (MySqlConnection conConn = new MySqlConnection("server=127.0.0.1;uid=root;pwd=Testing123;database=grab"))
            {
                try
                {
                    conConn.Open();

                    
                    string sql = "SELECT * FROM grab.post WHERE isAvailable = 0";
                    MySqlCommand cmd = new MySqlCommand(sql, conConn);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.HasRows && reader.Read())
                        {
                            Posting post = new Posting(
                                Convert.ToInt32(reader["Post_id"]),
                                Convert.ToInt32(reader["User_id"]),
                                reader["Requested"].ToString(),
                                reader["Quantity"].ToString(),
                                Convert.ToInt32(reader["Fee"]),
                                reader["Description"].ToString(),
                                Convert.ToDateTime(reader["Date_posted"]),
                                Convert.ToDateTime(reader["Deadline"]),
                                reader["Category"].ToString(), 

                                
                                reader["Image"] != DBNull.Value ? (byte[])reader["Image"] : null,

                                reader["Pick_location"].ToString(),
                                reader["Near_pickUp_id"].ToString(),
                                reader["Delivery_location"].ToString(),
                                reader["Near_delivery_id"].ToString(),
                                Convert.ToInt32(reader["isAvailable"])
                            );

                            posts.Add(post);
                        }
                    }
                }
                catch (MySqlException ex)
                {
                    
                    Console.WriteLine("An error occurred: " + ex.Message);
                }
            }

            return posts;
        }




        public User getUserById(int id)
        {
            using (MySqlConnection conConn = Connect())
            {
                try
                {
                    string sql = "SELECT * FROM grab.user_information WHERE user_id = @id";
                    MySqlCommand cmd = new MySqlCommand(sql, conConn);

                    
                    cmd.Parameters.AddWithValue("@id", id);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            byte[] profilePic = reader["Profile_pic"] != DBNull.Value ? (byte[])reader["Profile_pic"] : null;

                            
                            return new User(
                                (int)reader["user_id"],
                                (string)reader["email"],
                                (string)reader["Username"],
                                (int)reader["School_id"],
                                (DateTime)reader["DateOfBirth"],
                                (string)reader["Address"],
                                profilePic,
                                (string)reader["PhoneNum"],
                                (string)reader["Bio"],
                                (string)reader["FirstName"],
                                (string)reader["LastName"],
                                (string)reader["Status"]

                            );
                        }
                        else
                        {
                            
                            return null; 
                        }
                    }
                }
                catch (MySqlException ex)
                {
                    Console.WriteLine("An error occurred (getUserById): " + ex.Message);
                    return null; 
                }
            }
        }


        public bool updateUserInformation(User user)
        {
            using (MySqlConnection conConn = Connect()) // Use a using block for connection
            {
                try
                {
                    // Build the UPDATE query with parameters to prevent SQL injection
                    string sql = "UPDATE grab.user_information SET Username = @Username, School_id = @School_id, DateOfBirth = @DateOfBirth, Address = @Address,email = @Email ,Profile_pic = @ProfilePic, PhoneNum = @PhoneNum, Bio = @Bio, FirstName = @FirstName, LastName = @LastName, Status = @Status WHERE user_id = @user_id;";



                    MySqlCommand cmd = new MySqlCommand(sql, conConn);

                    // Add user data as parameters
                    cmd.Parameters.AddWithValue("@user_id", user.User_id);
                    cmd.Parameters.AddWithValue("@Username", user.Username);
                    cmd.Parameters.AddWithValue("@School_id", user.School_id);
                    cmd.Parameters.AddWithValue("@DateOfBirth", user.DOB);
                    cmd.Parameters.AddWithValue("@Address", user.Address);
                    cmd.Parameters.AddWithValue("@Email", user.Email);


                    // Handle profile picture (null for no update)
                    if (user.Profile_pic != null)
                    {
                        cmd.Parameters.AddWithValue("@ProfilePic", user.Profile_pic);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@ProfilePic", DBNull.Value);
                    }

                    cmd.Parameters.AddWithValue("@PhoneNum", user.PhoneNumber);
                    cmd.Parameters.AddWithValue("@Bio", user.Bio);
                    cmd.Parameters.AddWithValue("@FirstName", user.FirstName);
                    cmd.Parameters.AddWithValue("@LastName", user.LastName);
                    cmd.Parameters.AddWithValue("@Status", user.Status);
                    MessageBox.Show(user.ToString());
                    // Execute the update query
                    int rowsAffected = cmd.ExecuteNonQuery();

                    // Return true if at least one row was affected (update successful)
                    return rowsAffected > 0;
                }
                catch (MySqlException ex)
                {
                    Console.WriteLine("An error occurred (updateUserInformation): " + ex.Message);
                    return false; // Or handle the error differently
                }
            }
        }

        public bool changeUserProfile(Byte[] image, int user_id)
        
        {
            using (MySqlConnection conConn = Connect()) // Use a using block for connection
            {
                try
                {
                    // Build the UPDATE query with parameters to prevent SQL injection
                    string sql = "UPDATE grab.user_information SET Profile_pic = @ProfilePic WHERE user_id = @user_id;";



                    MySqlCommand cmd = new MySqlCommand(sql, conConn);

                    // Add user data as parameters
                    cmd.Parameters.AddWithValue("@user_id",user_id);
                    


                    // Handle profile picture (null for no update)
                    if (image != null)
                    {
                        cmd.Parameters.AddWithValue("@ProfilePic", image);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@ProfilePic", DBNull.Value);
                    }

                   
                    MessageBox.Show("Profile Picture Updated");
                    // Execute the update query
                    int rowsAffected = cmd.ExecuteNonQuery();

                    // Return true if at least one row was affected (update successful)
                    return rowsAffected > 0;
                }
                catch (MySqlException ex)
                {
                    Console.WriteLine("An error occurred (updateUserInformation): " + ex.Message);
                    return false; // Or handle the error differently
                }
            }
        }


    }



}
