using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace waliyaDemo2.usercontrol
{
    public partial class custo : UserControl
    {
        int index = 0;
        List<Vehicle> customers = new List<Vehicle>();

        public custo()
        {
            InitializeComponent();
           
        }

       
       
        private void custo_Load(object sender, EventArgs e)
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
          
            string conString = "Data Source=ELIAS\\SQLEXPRESS;Initial Catalog=waliya;Integrated Security=True";
            string Query = " select zipcode,PlaceName,State,county from waliya.dbo.countrylists where zipcode= '" +comboBox1.Text+ "';" ;
            SqlConnection conn = new SqlConnection(conString);
            SqlCommand cmdDataBase = new SqlCommand(Query, conn);
            SqlDataReader myreader;
            
            try
            {
                conn.Open();
                myreader = cmdDataBase.ExecuteReader();

                while (myreader.Read())
                {
                   // string Zipcode = myreader["zipcode"].ToString();
                    string SplaceName = myreader["PlaceName"].ToString();
                    string Sstate = myreader["State"].ToString();
                    string Scounty = myreader["county"].ToString();
                   // comboBox1.Text = Zipcode.ToString();
                    txtPlaceName.Text = SplaceName;
                    txtState.Text = Sstate;
                    txtCounty.Text = Scounty;
                }
                
            }
            catch (Exception ex)
            {
                //Exception Message

                MessageBox.Show(ex.Message);
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            Vehicle obj = new Vehicle();
            
            obj.Show();
            Hide();
           
        }

        private void txtApt_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtApt_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void txtFirstName_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsLetter(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void txtLastName_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsLetter(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }
    }
}

