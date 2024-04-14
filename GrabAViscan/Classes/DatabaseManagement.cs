 using GrabAViscan.Feed;
using GrabAViscan.Popup;
using MySql.Data.MySqlClient;
using Mysqlx.Crud;
using MySqlX.XDevAPI.Relational;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
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
                    ErrorMessage error = new ErrorMessage("There was an error while retrieving user");
                    
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
                reader.Close();
                conConn.Close();
                return false;
            }
            else
            {
                reader.Close();
                conConn.Close();
                return true;
            }

            
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
                ErrorMessage error = new ErrorMessage(ex.Message + " SignUp Function");
                
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

                    
                    SucMessage error = new SucMessage("Account Created!" );
                    insertCmd.ExecuteNonQuery();

                }
                catch (MySqlException ex)
                {
                    
                    ErrorMessage error = new ErrorMessage(ex.Message);
                    
                    
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
                    SucMessage error = new SucMessage("Post Successful");
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
                            

                            
                            Category category = new Category(reader.GetInt32("categoryId"), reader.GetString("name"), reader["categoryImage"] != DBNull.Value ? (byte[])reader["categoryImage"] : null);
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



        public List<Posting> getAllPost()
        {
            List<Posting> posts = new List<Posting>();

            using (MySqlConnection conConn = new MySqlConnection("server=127.0.0.1;uid=root;pwd=Testing123;database=grab"))
            {
                try
                {
                    conConn.Open();


                    string sql = "SELECT * FROM grab.post";
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
                    ErrorMessage error = new ErrorMessage(ex.Message);
                    
                    return null; 
                }
            }
        }


        public bool updateUserInformation(User user)
        {
            using (MySqlConnection conConn = Connect()) 
            {
                try
                {
                   
                    string sql = "UPDATE grab.user_information SET Username = @Username, School_id = @School_id, DateOfBirth = @DateOfBirth, Address = @Address,email = @Email ,Profile_pic = @ProfilePic, PhoneNum = @PhoneNum, Bio = @Bio, FirstName = @FirstName, LastName = @LastName, Status = @Status WHERE user_id = @user_id;";



                    MySqlCommand cmd = new MySqlCommand(sql, conConn);

                   
                    cmd.Parameters.AddWithValue("@user_id", user.User_id);
                    cmd.Parameters.AddWithValue("@Username", user.Username);
                    cmd.Parameters.AddWithValue("@School_id", user.School_id);
                    cmd.Parameters.AddWithValue("@DateOfBirth", user.DOB);
                    cmd.Parameters.AddWithValue("@Address", user.Address);
                    cmd.Parameters.AddWithValue("@Email", user.Email);


                    
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
                    SucMessage erro = new SucMessage("Changes has been saved");
                    
                    int rowsAffected = cmd.ExecuteNonQuery();

                    
                    return rowsAffected > 0;
                }
                catch (MySqlException ex)
                {
                    ErrorMessage error = new ErrorMessage("An error occurred(updateUserInformation): " + ex.Message);
                    
                    return false; 
                }
            }
        }

        public bool changeUserProfile(Byte[] image, int user_id)
        
        {
            using (MySqlConnection conConn = Connect())
            {
                try
                {
                    
                    string sql = "UPDATE grab.user_information SET Profile_pic = @ProfilePic WHERE user_id = @user_id;";



                    MySqlCommand cmd = new MySqlCommand(sql, conConn);

                    
                    cmd.Parameters.AddWithValue("@user_id",user_id);
                    


                    
                    if (image != null)
                    {
                        cmd.Parameters.AddWithValue("@ProfilePic", image);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@ProfilePic", DBNull.Value);
                    }

                    
                    SucMessage mess = new SucMessage("Profile Picture Updated");
                    
                    
                    int rowsAffected = cmd.ExecuteNonQuery();

                    
                    return rowsAffected > 0;
                }
                catch (MySqlException ex)
                {
                    ErrorMessage error = new ErrorMessage("An error occurred (updateUserInformation): " + ex.Message);    
                    
                    return false; 
                }
            }
        }

        public bool changePass(string email,string oldPass,string newPass)
        {

            string oldPassVerify = getPass(email);
            MySqlConnection conConn = Connect();
            if(oldPass != oldPassVerify)
            {
                ErrorMessage mess = new ErrorMessage("old password did not match"); 
                
                return false;
            }
               

            string insertSql = "UPDATE grab.accounts SET password = @newPass WHERE email = @email AND password=@password;";
            MySqlCommand insertCmd = new MySqlCommand(insertSql, conConn);
            
            if(newPass == "")
            {
                ErrorMessage mess = new ErrorMessage("Password Should not be Empty");
                return false;
            }
            else if (newPass == oldPassVerify)
            {
                ErrorMessage mess = new ErrorMessage("New Password Shoul be Different from old Password");
                return false;
            }

            insertCmd.Parameters.AddWithValue("@email", email);
            insertCmd.Parameters.AddWithValue("@password", oldPass);
            insertCmd.Parameters.AddWithValue("@newPass", newPass);
            
            try
            {

                
                insertCmd.ExecuteNonQuery();
                
                SucMessage mess = new SucMessage("Password Changed");
                conConn.Close();
                return true;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                conConn.Close();
                return false;

            }
        }


        public string getPass(string email) 
        
        {
            using (MySqlConnection conConn = this.Connect())
            {
                string sql = "SELECT * FROM grab.accounts WHERE email=@email";
                MySqlCommand cmd = new MySqlCommand(sql, conConn);

                cmd.Parameters.AddWithValue("@email", email);
               

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return reader.GetString(2);
                    }
                    else
                    {

                        return "";
                    }
                }
            }
        }




        public bool updateAvailability(int Post_id, int value)
        {

            SucMessage mess = new SucMessage("Here at updatingPostingInformation");
            using (MySqlConnection conConn = this.Connect())
            {
                try
                {

                    string sql = "UPDATE grab.post SET isAvailable = @isAvailable WHERE Post_id = @Post_id;";



                    MySqlCommand cmd = new MySqlCommand(sql, conConn);
                    cmd.Parameters.AddWithValue("@Post_id",Post_id);
                    cmd.Parameters.AddWithValue("@isAvailable", value);

                    


                    int rowsAffected = cmd.ExecuteNonQuery();


                    return rowsAffected > 0;
                }
                catch (MySqlException ex)
                {
                    ErrorMessage error = new ErrorMessage("An error occurred (updateUserInformation): " + ex.Message);

                    return false;
                }
            }
        }



        public bool updatePostingInformation(Posting posting)
        {
            using (MySqlConnection conConn = this.Connect())
            {
                try
                {
                    string sql = "UPDATE grab.post SET Requested = @Requested, Quantity = @Quantity, Fee = @Fee, Description = @Description, Deadline = @Deadline, Category = @Category, image = @image ,Pick_location = @Pick_up, Near_pickUp_id = @Near_pickUp, Delivery_location = @Delivery_location, Near_delivery_id = @Near_deliveryLocation, isAvailable = @Available WHERE Post_id = @Post_id;";

                    MySqlCommand cmd = new MySqlCommand(sql, conConn);

                    cmd.Parameters.AddWithValue("@Post_id", posting.Post_id);
                    cmd.Parameters.AddWithValue("@Requested", posting.Requested);
                    cmd.Parameters.AddWithValue("@Quantity", posting.Quantity);
                    cmd.Parameters.AddWithValue("@Fee", posting.Fee);
                    cmd.Parameters.AddWithValue("@Description", posting.Description);
                    cmd.Parameters.AddWithValue("@Deadline", posting.Deadline);
                    cmd.Parameters.AddWithValue("@Category", posting.Category);

                   
                    if (posting.image != null)
                    {
                        cmd.Parameters.AddWithValue("@image", posting.image);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@image", DBNull.Value);
                    }

                    cmd.Parameters.AddWithValue("@Pick_up", posting.Pick_up);
                    cmd.Parameters.AddWithValue("@Near_pickUp", GetLocationID(posting.Near_pickUp));
                    cmd.Parameters.AddWithValue("@Delivery_location", posting.Delivery_location);
                    cmd.Parameters.AddWithValue("@Near_deliveryLocation", GetLocationID(posting.Near_pickUp));
                    cmd.Parameters.AddWithValue("@Available", posting.Available);

                    SucMessage erro = new SucMessage("Changes has been saved");

                    int rowsAffected = cmd.ExecuteNonQuery();


                    return rowsAffected > 0;
                }
                catch (MySqlException ex)
                {

                    ErrorMessage error = new ErrorMessage("An error occurred(updatePostingInformation): " + ex.Message);

                    return false;
                }
            }
        }





        public Posting getPostById(int Post_id)
        {

            using (MySqlConnection conConn = this.Connect())
            {
                try
                {
                    string sql = "SELECT * FROM grab.post WHERE Post_id = @Post_id";
                    MySqlCommand cmd = new MySqlCommand(sql, conConn);
                    cmd.Parameters.AddWithValue("@Post_id", Post_id);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            reader.Read(); 
                            return new Posting(
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
                        }
                        else
                        {
                            
                            return null; 
                        }
                    }
                }
                catch (MySqlException ex)
                {

                    ErrorMessage mess = new ErrorMessage("An error occurred while getting post by ID: " + ex.Message);
                   
                }
            }

            return null;
        }



        public Category GetCategoryByName(string categoryString)
        {
            Category foundCategory = null;

            using (MySqlConnection conConn = Connect())
            {
                try
                {
                    

                    // Build the SQL query with parameter for category
                    string sql = "SELECT * FROM grab.category WHERE name = @category";
                    MySqlCommand cmd = new MySqlCommand(sql, conConn);

                    // Add parameter for category
                    cmd.Parameters.AddWithValue("@category", categoryString);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            foundCategory = new Category(reader.GetInt32("categoryId"), reader.GetString("name"),
                                                          reader["categoryImage"] != DBNull.Value ? (byte[])reader["categoryImage"] : null);
                        }
                    }
                }
                catch (MySqlException ex)
                {
                    Console.WriteLine("An error occurred: " + ex.Message);
                }
            }

            return foundCategory;
        }


        public Location GetLocationById(int locationId)
        {
            Location foundLocation = null;

            using (MySqlConnection conConn = Connect())  // Assuming Connect() establishes the connection
            {
                try
                {
                    string sql = "SELECT * FROM grab.location WHERE idLocation = @locationId;";
                    MySqlCommand cmd = new MySqlCommand(sql, conConn);
                    cmd.Parameters.AddWithValue("@locationId", locationId);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Directly return the new Location object
                            return new Location(reader.GetInt32("idLocation"), reader.GetString("locationName"));
                        }
                    }
                }
                catch (MySqlException ex)
                {
                    Console.WriteLine("An error occurred: " + ex.Message);
                }
            }

            return foundLocation; // Still return null if no location is found
        }


        public Location GetLocationByMatchingId(List<Location> locations, int locationId)
        {
            foreach (Location location in locations)
            {
                if (location.Location_id == locationId)
                {
                    return location;
                }
            }

            return null; // If no match is found
        }
    }



}
