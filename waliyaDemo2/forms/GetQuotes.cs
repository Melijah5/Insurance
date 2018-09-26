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
    public partial class GetQuotes : Form
    {
        public GetQuotes()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Homepage obj = new Homepage();
            obj.Show();
            this.Hide();
        }
    }
}
