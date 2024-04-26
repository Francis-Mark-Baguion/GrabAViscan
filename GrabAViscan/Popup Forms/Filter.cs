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
            this.Owner = home;
            home.filterBox.Text = "";
            category.Text = "";
            place.Text = "";
            
        }


        public Filter() { }

        public List<Posting> returnFilter()
        {
            List<Posting> filterPost;

            filterPost = new List<Posting>();
            string location_id = "";
            List<Location> locations = new List<Location>();
            foreach (Location location in db.locations)
            {
                if (location.LocationName == place.Text)
                {
                    location_id = location.Location_id + "";
                }
            }

            List<Posting> allPost = db.GetAvailablePosts();


            if (place.Text != "" && category.Text == "")
            {
                foreach (Posting post in allPost)
                {
                    
                    if (post.Near_deliveryLocation == location_id)
                    {
                        filterPost.Add(post);
                    }
                }
            }
            else if (place.Text == "" && category.Text != "")
            {
                foreach (Posting post in allPost)
                {
                    if (post.Category == category.Text)
                    {
                        filterPost.Add(post);
                    }
                }
            }
            else if (place.Text != "" && category.Text != "")
            {
                foreach (Posting post in allPost)
                {
                    if (post.Near_deliveryLocation == location_id && post.Category == category.Text)
                    {
                        filterPost.Add(post);
                    }
                }
            }


            return filterPost;








        }
        
        private void gunaComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Filter_Load(object sender, EventArgs e)
        {
            
        }

        private void category_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void place_SelectedIndexChanged(object sender, EventArgs e)
        {
            home.filterBox.Text = place.Text + ", " + category.Text;
        }

        private void category_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            home.filterBox.Text = place.Text + ", " + category.Text;
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            home.filterBox.Text = "";
            category.Text = "";
            place.Text = "";
        }

        private void Close_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
