using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrabAViscan.Classes
{
    public class Deliver
    {

        public int Post_Id { get; set; }
        public int User_Id { get; set; }
        public Deliver(int Post_id, int User_id)
        {
            this.Post_Id = Post_id;
            this.User_Id = User_id;
        }    
    }
}
