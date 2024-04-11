using GrabAViscan.Feed;
using GrabAViscan.Popup;
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
                                user = new User((int)reader["user_id"], (string)reader["email"], (string)reader["Username"], (int)reader["School_id"], (DateTime)reader["DateOfBirth"], (string)reader["Address"] , (byte[])reader["Profile_pic"], (string)reader["PhoneNum"], (string)reader["Bio"]);
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


        public void Information_upload(User user)
        {
            using (MySqlConnection conConn = Connect()) // Use a using block for connection
            {
                try
                {
                    string insertSql = "INSERT INTO grab.user_information (user_id,Username, School_id, DateOfBirth, Address, email, Profile_pic, PhoneNum, Bio) VALUES (?, ?, ?, ?, ?, ?, ?, ?,?)";
                    MySqlCommand insertCmd = new MySqlCommand(insertSql, conConn);

                    // Use parameters to prevent SQL injection vulnerabilities
                    insertCmd.Parameters.AddWithValue("@user_id", user.User_id);
                    insertCmd.Parameters.AddWithValue("@Username", user.Username);
                    insertCmd.Parameters.AddWithValue("@School_id", user.School_id);
                    insertCmd.Parameters.AddWithValue("@DateOfBirth", user.DOB);
                    insertCmd.Parameters.AddWithValue("@Address", user.Address);
                    insertCmd.Parameters.AddWithValue("@email", user.Email); // Assuming your User class has an Email property
                    if (user.Profile_pic != null && user.Profile_pic.Length > 0)
                    {
                        insertCmd.Parameters.AddWithValue("@Profile_pic", user.Profile_pic);
                    }
                    else
                    {
                        insertCmd.Parameters.AddWithValue("@Profile_pic", DBNull.Value); // Set to null if no image
                    }
                    

                    insertCmd.Parameters.AddWithValue("@PhoneNum", user.PhoneNumber); // Assuming your User class has a Phone property
                    insertCmd.Parameters.AddWithValue("@Bio", user.Bio); // Assuming your User class has a Bio 
                    
                    MessageBox.Show("Here at info upload");
                    insertCmd.ExecuteNonQuery();

                }
                catch (MySqlException ex)
                {
                    // Handle database-related exceptions (e.g., connection errors, duplicate entries)
                    Console.WriteLine("An error occurred: " + ex.Message);
                    // Consider showing a more user-friendly error message
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

                    // Assuming Category ID (category_id) and Location IDs (pickUp_id, etc.) exist
                    string sql = "INSERT INTO grab.post (User_id, Requested, Quantity, Fee, Description, Date_posted, Deadline, Category, Image, Pick_location,Near_pickUp_id,Delivery_location,Near_delivery_id,isAvailable) VALUES (?,?,?,?,?,?,?,?,?,?,?,?,?,?)";

                    MySqlCommand cmd = new MySqlCommand(sql, conConn);


                    cmd.Parameters.AddWithValue("@User_id", post.User_id);
                    cmd.Parameters.AddWithValue("@Requested", post.Requested);
                    cmd.Parameters.AddWithValue("@Quantity", post.Quantity);
                    cmd.Parameters.AddWithValue("@Fee", post.Fee);
                    cmd.Parameters.AddWithValue("@Description", post.Description);
                    cmd.Parameters.AddWithValue("@Date_posted", post.Date_posted);
                    cmd.Parameters.AddWithValue("@Deadline", post.Deadline);

                    // Assuming you have a method to get the category ID based on the Category object
                    cmd.Parameters.AddWithValue("@Category", post.Category);

                    // Handle image data (consider validation and potential pre-processing)
                    if (post.image != null && post.image.Length > 0)
                    {
                        cmd.Parameters.AddWithValue("@Image", post.image);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@Image", DBNull.Value); // Set to null if no image
                    }

                    // Assuming you have methods to get Location IDs based on Location objects
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
                    // Handle database-related exceptions (e.g., connection errors, query issues)
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

                    // Assuming LocationName uniquely identifies a location in your table
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
                            // Handle case where location not found (e.g., insert a new location or return -1)
                            Console.WriteLine("Location not found: " + location);
                            return -1; // Or insert a new location and return its ID
                        }
                    }
                }
                catch (MySqlException ex)
                {
                    // Handle database-related exceptions
                    Console.WriteLine("An error occurred (getLocationId): " + ex.Message);
                    return -1; // Or handle the error differently
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

                            // Assuming you have a Category class with Id and Name properties
                            Category category = new Category(categoryId, categoryName);
                            categories.Add(category);
                        }
                    }
                }
                catch (MySqlException ex)
                {
                    Console.WriteLine("An error occurred: " + ex.Message);
                    // Handle database exceptions appropriately
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

                            // Assuming you have a Category class with Id and Name properties
                            Location location = new Location(LocationId, LocationName);
                            locations.Add(location);
                        }
                    }
                }
                catch (MySqlException ex)
                {
                    Console.WriteLine("An error occurred: " + ex.Message);
                    // Handle database exceptions appropriately
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

                    // Get only posts where isAvailable = 0
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
                                reader["Category"].ToString(), // Assuming Category is stored as a string

                                // Handle potential null value for Image
                                reader["Image"] != DBNull.Value ? (byte[])reader["Image"] : null,

                                reader["Pick_location"].ToString(), // Assuming Pick_location is a string property
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
                    // Handle database-related exceptions
                    Console.WriteLine("An error occurred: " + ex.Message);
                }
            }

            return posts;
        }




        public User getUserById(int id)
        {
            using (MySqlConnection conConn = Connect()) // Use a using block for connection
            {
                try
                {
                    string sql = "SELECT * FROM grab.user_information WHERE user_id = @id";
                    MySqlCommand cmd = new MySqlCommand(sql, conConn);

                    // Add parameter to prevent SQL injection
                    cmd.Parameters.AddWithValue("@id", id);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            byte[] profilePic = reader["Profile_pic"] != DBNull.Value ? (byte[])reader["Profile_pic"] : null;

                            // Create a User object with data from the database row
                            return new User(
                                (int)reader["user_id"],
                                (string)reader["email"],
                                (string)reader["Username"],
                                (int)reader["School_id"],
                                (DateTime)reader["DateOfBirth"],
                                (string)reader["Address"],
                                profilePic,
                                (string)reader["PhoneNum"],
                                (string)reader["Bio"]
                            );
                        }
                        else
                        {
                            // User not found, consider throwing a custom exception
                            return null; // Or throw new UserNotFoundException("User with ID " + id + " not found");
                        }
                    }
                }
                catch (MySqlException ex)
                {
                    Console.WriteLine("An error occurred (getUserById): " + ex.Message);
                    return null; // Or handle the error differently
                }
            }
        }

    }



}
