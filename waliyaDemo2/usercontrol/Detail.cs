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
    public partial class Detail : UserControl
    {
        public Detail()
        {
            InitializeComponent();
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

            if (checkBox1.Checked == true)
            {
                btnsend.Enabled = true;
            }

            if (checkBox1.Checked == false)
            {
                btnsend.Enabled = false;
            }
        }
        

       
    }
}
