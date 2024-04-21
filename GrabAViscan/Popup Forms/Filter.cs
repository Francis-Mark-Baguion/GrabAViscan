using GrabAViscan.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GrabAViscan.Popup_Forms
{
    public partial class Filter : Form
    {
        private DatabaseManagement db = new DatabaseManagement();
        private Home home;
        public Filter(Home home)
        {
            InitializeComponent();
            this.home = home;  
            place.DataSource = db.locations;
            place.ValueMember = "LocationName";
            place.DisplayMember = "LocationName";

            category.DataSource = db.categories;
            category.ValueMember = "Name";
            category.DisplayMember = "Name";
            this.Show();
            
        }

        public Dictionary<string, string> returnFilter()
        {
            
            int location_id = 0;
            List<Location> locations = new List<Location>();
            foreach (Location location in db.locations)
            {
                if(location.LocationName == place.Text)
                {
                    location_id = location.Location_id;
                }
            }
            MessageBox.Show(location_id + " " + category.Text);
            Dictionary<string, string> filters = new Dictionary<string, string>();
            if (place.ValueMember != null)
            {
                filters.Add("Near_delivery_id", location_id+""); // Filter by place "Cebu City"}
            }
            if(category.Text != "")
            {
                filters.Add("Category", category.Text);  // Filter by category "Books"
            }
                

            return filters;
        }
        
        private void gunaComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Filter_Load(object sender, EventArgs e)
        {
            home.filterBox.Text = place.Text +" "+ category.Text;
        }

        private void category_SelectedIndexChanged(object sender, EventArgs e)
        {
            home.filterBox.Text = place.Text +" "+ category.Text;
        }
    }
}
