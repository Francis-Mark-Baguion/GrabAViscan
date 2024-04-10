using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZstdSharp.Unsafe;

namespace GrabAViscan.Classes
{
    public class Posting
    {
        public int Post_id {  get; set; }
        public int User_id { get; set; }

        public string Requested {  get; set; }
        public string Quantity { get; set; }
        public int Fee { get; set; }
        public string Description { get; set; }
        public DateTime Date_posted  { get; set;}
        public DateTime Deadline { get;}
        public string Category { get; set; }
        public byte[] image { get; set; }
        public string Pick_up { get; set; }
        public string Near_pickUp { get; set; }
        public string Delivery_location { get; set; }
        public string Near_deliveryLocation { get; set; }
        public int Available { get; set; }
        public Posting(int Post_id, int User_id, string Requested,string Quantity, int Fee,string Description, DateTime Date_posted, DateTime Deadline, string category,
            byte[] image, string Pick_up, string Near_pickUp, string Delivery_location, string Near_deliveryLocation, int Available)

        {
            this.Post_id = Post_id;
            this.User_id = User_id;
            this.Requested = Requested;
            this.Quantity = Quantity;
            this.Fee = Fee;
            this.Description = Description;
            this.Date_posted = Date_posted;
            this.Deadline = Deadline;
            this.Category = category;
            this.image = image;
            this.Pick_up = Pick_up;
            this.Near_pickUp = Near_pickUp;
            this.Delivery_location = Delivery_location;
            this.Near_deliveryLocation = Near_deliveryLocation;
            this.Available = Available;
        }

        public Posting() { }


        
    }
}
