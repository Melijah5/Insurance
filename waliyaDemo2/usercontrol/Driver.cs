using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace waliyaDemo2.usercontrol
{
    public partial class Driver : UserControl
    {
        public Driver()
        {
            InitializeComponent();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            Detail obj = new Detail();

            obj.Show();
            this.Hide();
        }
    }
}
