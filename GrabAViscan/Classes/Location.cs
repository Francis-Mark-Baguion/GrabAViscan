using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace GrabAViscan.Classes
{
    public class Location
    {
        public int Location_id { get; set; }
        public string LocationName { get; set; }

        public Location(int location_id, string locationName)
        {
            Location_id = location_id;
            LocationName = locationName;
        }

        public override string ToString()
        {
            return "Location: Location Id - " + Location_id + ", Location Name - " + LocationName;
        }

    }
}
