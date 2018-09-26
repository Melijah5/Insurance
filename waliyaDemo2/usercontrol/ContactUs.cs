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
    public partial class ContactUs : UserControl
    {
        public ContactUs()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsLetter(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked==true)
            {
                btnsend.Enabled = true;
            }

            if (checkBox1.Checked == false)
            {
                btnsend.Enabled = false;
            }

        }

        private void btnsend_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thank You! we will contact you soon!!");
        }
    }
}
