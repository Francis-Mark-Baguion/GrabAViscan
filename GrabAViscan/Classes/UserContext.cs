using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GrabAViscan.Classes
{
    public class UserContext
    {

        public static User CurrentUser
        {
            get { return _userLocal.Value; }
            set { _userLocal.Value = value; }
        }

            private static readonly ThreadLocal<User> _userLocal = new ThreadLocal<User>();
        
    
    }
}
