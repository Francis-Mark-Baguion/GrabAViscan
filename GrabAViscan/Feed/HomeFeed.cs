using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GrabAViscan.Classes;

namespace GrabAViscan
{
    public partial class HomeFeed : UserControl
    {
        Posting post;
        public HomeFeed(Posting post)
        {
            InitializeComponent();
            this.post = post; 

        }


    }
}
