using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace waliyaDemo2.forms
{
    public partial class Homepage : Form
    {
        public Homepage()
        {
            InitializeComponent();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            vehicleInsurance1.BringToFront();
            vehicleInsurance1.Text = "vehicle Insurance";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            myAccount1.BringToFront();
            myAccount1.Text = "My Account";
        }

        private void myAccount1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            claims_and_incidents1.BringToFront();
            claims_and_incidents1.Text = "claims and incidents1";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            aboutWaliya1.BringToFront();
            aboutWaliya1.Text = "About Waliya";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            contactUs1.BringToFront();
            contactUs1.Text = "Contact Us";
        }

        private void Homepage_Load(object sender, EventArgs e)
        {
            
        }
    }
}
