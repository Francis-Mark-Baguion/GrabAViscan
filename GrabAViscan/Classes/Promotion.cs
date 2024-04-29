using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrabAViscan.Classes
{
    public class Promotion
    {
        public int Promotion_id { get; set; }
        public string Promotion_name { get; set; } 
        public string Promotion_location { get; set; }
        public byte[] Promotion_image { get; set; }


        public Promotion(int promotion_id, string promotion_name, string promotion_location, byte[] promotion_image)
        {
            Promotion_id = promotion_id;
            Promotion_name = promotion_name;
            Promotion_location = promotion_location;
            Promotion_image = promotion_image;
        }

        public Promotion() { }


    }
}
