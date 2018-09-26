using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Text;
using waliyaDemo2.forms;
using System.Drawing;

namespace waliyaDemo2.usercontrol
{
    public partial class VehicleInsurance : UserControl
    {
       
        public VehicleInsurance()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btngetQuote_Click(object sender, EventArgs e)
        {
            foreach (Control cob in groupBox1.Controls)
            {

                if ( cob is ComboBox)
                {
                    int find = Name.ToString().IndexOf("_required");
                    if (find > 0 && cob.Text == "")
                    {
                        cob.BackColor = Color.Red;
                        label2.Text = "Mandatory Field";
                        label2.ForeColor = Color.Red;
                        label2.Visible = true;

                    }
                    else
                    {
                        GetQuotes obj = new GetQuotes();
                        obj.Show();
                        Hide();
                    }

                }


            }
        }  
               
        private void VehicleInsurance_Load(object sender, EventArgs e)
        {
            FillCombobox();
        }

        protected void FillCombobox()
        {
            string conString = @"Data Source=ELIAS\SQLEXPRESS;Initial Catalog=waliya;Integrated Security=True";

            SqlConnection conn = new SqlConnection(conString);
            DataSet ds = new DataSet();
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("select ZipCode from countrylist", conn);
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                da.Fill(ds);
                comboBox1.DisplayMember = "Zipcode";
                comboBox1.ValueMember = "ID";
                comboBox1.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {
                //Exception Message
            }
            finally
            {
                conn.Close();
                conn.Dispose();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }
    }

   
}