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
    public partial class Vehicle : UserControl
    {
        public Vehicle()
        {
            InitializeComponent();
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            commute1.BringToFront();
            commute1.Text = "Contact Us";
            //if (radioButton6.Checked == true)
            //{

            //    lblDay.Enabled = true;
            //    txtDay.Visible = true;
                
            //    lblMiles.Visible = true;
            //    CobMilage.Enabled = true;

            //    lblAMilage.Visible = true;
            //    cobAmilage.Enabled = true;
            //}
            //else
            //{
            //    lblDay.Enabled = false;
            //    txtDay.Visible = false;

            //    lblMiles.Visible = false;
            //    CobMilage.Enabled = false;

            //    lblAMilage.Visible = false;
            //    cobAmilage.Enabled = false;
            //}
        }
        //SqlConnection CON = new SqlConnection("Data Source = ELIAS\\SQLEXPRESS; Initial Catalog = waliya; Integrated Security = True");

        private void Vehicle_Load(object sender, EventArgs e)

        //{
        //    SqlDataAdapter sda = new SqlDataAdapter("select distinct make from listcar order by make Asc", CON);
        //    DataTable DT = new DataTable();
        //    sda.Fill(DT);
        //    cobMake.Items.Add("select ");
        //    foreach(DataRow Row in DT.Rows)
        //    {
        //        cobMake.Items.Add(Row["make"].ToString());
        //    }
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
                SqlCommand cmd = new SqlCommand("select distinct make from listcar order by make Asc", conn);
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                da.Fill(ds); 
                cobMake.DisplayMember = "Make";
                cobMake.ValueMember = "Make";
                cobMake.DataSource = ds.Tables[0];


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

        private void cobModel_SelectedIndexChanged(object sender, EventArgs e)
        {
          

        }

        private void cobMake_SelectedIndexChanged(object sender, EventArgs e)
        {
            //SqlDataAdapter sda = new SqlDataAdapter("select distinct model from listcar where make='" + cobMake.Text + "'", CON);
            //DataTable DT = new DataTable();
            //sda.Fill(DT);
            //foreach(DataRow AB in DT.Rows)
            //{
            //    cobModel.Items.Add(AB["Model"].ToString());
            //}

            string conString = "Data Source=ELIAS\\SQLEXPRESS;Initial Catalog=waliya;Integrated Security=True";
            string Query = " select distinct model from listcar where make = '" + cobMake.Text + "';";
            SqlConnection conn = new SqlConnection(conString);
            SqlCommand cmdDataBase = new SqlCommand(Query, conn);
            SqlDataReader myreader;


            try
            {
                conn.Open();
                myreader = cmdDataBase.ExecuteReader();

                while (myreader.Read())
                {

                    cobModel.Items.Add(myreader["Model"].ToString());
                    // string Make = myreader["Make"].ToString();
                    //string Model = myreader["model"].ToString();

                    // cobMake.Text = Make.ToString();
                    //cobModel.Text = Model.ToString();

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
            Driver obj = new Driver();

            obj.Show();
            Hide();
        }

        private void lblDay_Click(object sender, EventArgs e)
        {

        }
    }
}
    
