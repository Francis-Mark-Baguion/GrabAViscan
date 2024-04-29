using GrabAViscan.Classes;
using Guna.UI.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;




namespace GrabAViscan.Feed
{
    public partial class Recommended : UserControl
    {
        public Recommended(Promotion promotion)
        {
            InitializeComponent();

            this.nameTxt.Text = promotion.Promotion_name;
            this.locationTxt.Text = promotion.Promotion_location;
            SetImageFromByteArray1(Pic, promotion.Promotion_image);

        }
        public void SetImageFromByteArray1(GunaPictureBox Image_cont, byte[] byteArray)
        {
            if (byteArray != null)
            {
                using (MemoryStream ms = new MemoryStream(byteArray))
                {
                    Image image = Image.FromStream(ms);
                    Pic.Image = image;
                }
            }
        }

    }
}
