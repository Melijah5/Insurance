using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using waliyaDemo2.forms;
using System.Diagnostics;

namespace waliyaDemo2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           
        }

        private void btnjoin_Click(object sender, EventArgs e)
        {
            Homepage obj = new Homepage();
            obj.Show();
            Hide();
        }

       

        private void button5_Click(object sender, EventArgs e)
        {
            Process.Start("www.twitter.com"); 
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Process.Start("www.Facebook.com");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Process.Start("www.Instagram.com");
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
