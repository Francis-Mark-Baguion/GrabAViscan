using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrabAViscan.Classes
{

    

    public class User
    {

        public int User_id;
        public string Email;
        public string Information_id;
        public string Username;
        public string school_id;
        public string DOB;
        public string Address;



        public User()
        {

        }

        public User(int user_id, string email, string information_id, string username, string school_id, string dOB, string address)
        {
            User_id = user_id;
            Email = email;
            Information_id = information_id;
            Username = username;
            this.school_id = school_id;
            DOB = dOB;
            Address = address;
        }

        

    }
}
