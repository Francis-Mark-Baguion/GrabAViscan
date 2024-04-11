using System;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace GrabAViscan.Classes
{


    
    public class User
    {
        

        
        
        public int User_id  { get ;set ;}

        public string Email { get; set; }  
        public string Username { get; set; }
        public int School_id { get; set; }
        public DateTime DOB { get; set; }
        public string Address { get; set; }

        public string PhoneNumber { get; set; }
        public byte[] Profile_pic { get; set; }

        public string Bio {  get; set; }


        DatabaseManagement db = new DatabaseManagement();
        private User()
        {

        }

        public User(int user_id, string email, string username, int school_id, DateTime dOB, string address, byte[] profile_pic, string phoneNumber, string bio)
        {
            this.User_id = user_id;
            this.Email = email;
            this.Username = username;
            this.School_id = school_id;
            this.DOB = dOB;
            this.Address = address;
            this.PhoneNumber = phoneNumber;
            this.Profile_pic = profile_pic;
            this.Bio = bio;
        }




    }
}
