using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrabAViscan.Classes
{
    public class Credentials
    {

        public string email {  get; set; }
        public string password { get; set; }

        public bool IsValid()
        {
            if (this.email == null || this.password == null)
            {
                return false;
            }
            return true;
        }

    }

    
}
