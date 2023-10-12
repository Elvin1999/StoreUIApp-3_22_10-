using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StoreUIApp.UserControls
{
    public partial class ProductUC : UserControl
    {
        public string Name
        {
            get
            {
                return nameLbl.Text;
            }
            set
            {
                nameLbl.Text = value;   
            }
        }


        public string Price
        {
            get
            {
                return priceLbl.Text;
            }
            set { priceLbl.Text = $"${value}"; }
        }

        public Image ProductImage
        {
            get
            {
                return pictureBox1.Image;
            }
            set
            {
                pictureBox1.Image = value;
            }
        }
        public ProductUC()
        {
            InitializeComponent();
        }
    }
}
