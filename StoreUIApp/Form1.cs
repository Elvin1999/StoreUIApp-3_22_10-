using StoreUIApp.Models;
using StoreUIApp.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StoreUIApp
{
    public partial class Form1 : Form
    {
        public List<Product> Products { get; set; }
        HomeUC homeUC = new HomeUC();
        public Form1()
        {
            InitializeComponent();
            this.MinimumSize = new Size(800, 450);
            this.MaximumSize = new Size(800, 450);
            GoProductHandler += guna2Button2_Click;
            homeUC.GoProductHandler = GoProductHandler;
            this.panel1.Controls.Add(homeUC);
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public EventHandler<EventArgs> GoProductHandler { get; set; }
        private void guna2Button2_Click(object sender, EventArgs e)
        {
            Products = new List<Product>
            {
                new Product
                {
                    Name="Mac",
                     Image=Properties.Resources.mac,
                      Price=2205
                },
                new Product
                {
                    Name="Acer",
                     Image=Properties.Resources.Acer,
                      Price=1838,
                },
                new Product
                {
                    Name="Lenovo",
                     Image=Properties.Resources.lenova,
                      Price=3200
                },
                new Product
                {
                    Name="Asus",
                     Image=Properties.Resources.Asus,
                      Price=2870,
                }
            };

            int x=0, y=0;
            this.panel1.Controls.Clear();
            foreach (var item in Products)
            {
                ProductUC uc = new ProductUC();
                uc.Name = item.Name;
                uc.Price = item.Price.ToString();
                uc.ProductImage = item.Image;
                uc.Location = new Point(x, y);
                y += 101;
                this.panel1.Controls.Add(uc);
            }
        }

        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
            this.panel1.Controls.Clear();
            this.panel1.Controls.Add(homeUC);
        }
    }
}
