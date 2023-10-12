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
    public partial class HomeUC : UserControl
    {
        public EventHandler<EventArgs> GoProductHandler { get; set; }
        public HomeUC()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            GoProductHandler?.Invoke(sender,e);
        }
    }
}
