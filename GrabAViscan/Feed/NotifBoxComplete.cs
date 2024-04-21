using GrabAViscan.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GrabAViscan.Feed
{
    public partial class NotifBoxComplete : UserControl
    {
        private DatabaseManagement db = new DatabaseManagement();
        private int User_id;
        public NotifBoxComplete(int User_id)
        {
            InitializeComponent();
            nameHolder.Text = db.getUserById(User_id).FirstName + " " + db.getUserById(User_id).LastName;

        }
    }
}
