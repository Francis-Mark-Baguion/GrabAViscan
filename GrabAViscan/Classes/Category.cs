using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrabAViscan.Classes
{
    public class Category
    {
        public int Id { get; set; } 
        public string Name { get; set; }

        public Category(int Id,string name) 
        {
        this.Id = Id;
        this.Name = name;
        }
    }
}
