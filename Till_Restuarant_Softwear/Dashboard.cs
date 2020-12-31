using System;using System.Configuration;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Till_Restuarant_Softwear
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
            TotalUsers();
            TotalCustomers();
            TotalEmployees();
            TotalExpenses();
            TodaySale();
            TotalSale();
            Sale_By_Dine_In();
            Sale_By_Take_Away();
            Sale_By_Delivery();
        }
//
//Today Sale
//
        public void TodaySale()
        {
            //Today Sale By Dine_In
            try
            {
                String todayDate = DateTime.Now.ToString("dd/MM/yyyy");

                SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Till_Restuarant_Softwear.Properties.Settings.Setting"].ToString());
                conn.Open();
                SqlCommand cmd = new SqlCommand("Select * From Dine_In  Where Date='" + todayDate + "'", conn);
                SqlDataReader dr;
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Double getAmount = Convert.ToDouble(dr["TotalPrice"].ToString());
                    Double price = Convert.ToDouble(jtodaysaleprice.Text);
                    Double total = getAmount + price;
                    String t1 = Convert.ToString(total);
                    jtodaysaleprice.Text = t1;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            //Today Sale By Take_away
            try
            {

                String todayDate1 = DateTime.Now.ToString("dd/MM/yyyy");

                SqlConnection conn1 = new SqlConnection(ConfigurationManager.ConnectionStrings["Till_Restuarant_Softwear.Properties.Settings.Setting"].ToString());
                conn1.Open();
                SqlCommand cmd1 = new SqlCommand("Select * From Take_Away  Where Date='" + todayDate1 + "'", conn1);
                SqlDataReader dr1;
                dr1 = cmd1.ExecuteReader();
                while (dr1.Read())
                {
                    Double getAmount1 = Convert.ToDouble(dr1["TotalPrice"].ToString());
                    Double price1 = Convert.ToDouble(jtodaysaleprice.Text);
                    Double total1 = getAmount1 + price1;
                    String t11 = Convert.ToString(total1);
                    jtodaysaleprice.Text = t11;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            //Today Sale By Delivery
            try
            {

                String todayDate2 = DateTime.Now.ToString("dd/MM/yyyy");

                SqlConnection conn2 = new SqlConnection(ConfigurationManager.ConnectionStrings["Till_Restuarant_Softwear.Properties.Settings.Setting"].ToString());
                conn2.Open();
                SqlCommand cmd2 = new SqlCommand("Select * From Take_Away  Where Date='" + todayDate2 + "'", conn2);
                SqlDataReader dr2;
                dr2 = cmd2.ExecuteReader();
                while (dr2.Read())
                {
                    Double getAmount2 = Convert.ToDouble(dr2["TotalPrice"].ToString());
                    Double price2 = Convert.ToDouble(jtodaysaleprice.Text);
                    Double total2 = getAmount2 + price2;
                    String t12 = Convert.ToString(total2);
                    jtodaysaleprice.Text = t12;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

//
//Total Sale
//
        public void TotalSale()
        {
            //Total Sale By Dine_In
            try
            {
                SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Till_Restuarant_Softwear.Properties.Settings.Setting"].ToString());
                conn.Open();
                SqlCommand cmd = new SqlCommand("Select * From Dine_In", conn);
                SqlDataReader dr;
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Double getAmount = Convert.ToDouble(dr["TotalPrice"].ToString());
                    Double price = Convert.ToDouble(jtotalsale.Text);
                    Double total = getAmount + price;
                    String t1 = Convert.ToString(total);
                    jtotalsale.Text = t1;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            //Total Sale By Take_away
            try
            {

                SqlConnection conn1 = new SqlConnection(ConfigurationManager.ConnectionStrings["Till_Restuarant_Softwear.Properties.Settings.Setting"].ToString());
                conn1.Open();
                SqlCommand cmd1 = new SqlCommand("Select * From Take_Away", conn1);
                SqlDataReader dr1;
                dr1 = cmd1.ExecuteReader();
                while (dr1.Read())
                {
                    Double getAmount1 = Convert.ToDouble(dr1["TotalPrice"].ToString());
                    Double price1 = Convert.ToDouble(jtotalsale.Text);
                    Double total1 = getAmount1 + price1;
                    String t11 = Convert.ToString(total1);
                    jtotalsale.Text = t11;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            //Total Sale By Delivery
            try
            {

                SqlConnection conn2 = new SqlConnection(ConfigurationManager.ConnectionStrings["Till_Restuarant_Softwear.Properties.Settings.Setting"].ToString());
                conn2.Open();
                SqlCommand cmd2 = new SqlCommand("Select * From Delivery", conn2);
                SqlDataReader dr2;
                dr2 = cmd2.ExecuteReader();
                while (dr2.Read())
                {
                    Double getAmount2 = Convert.ToDouble(dr2["TotalPrice"].ToString());
                    Double price2 = Convert.ToDouble(jtotalsale.Text);
                    Double total2 = getAmount2 + price2;
                    String t12 = Convert.ToString(total2);
                    jtotalsale.Text = t12;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

//
//Total Users
//
        public void TotalUsers()
        {
            try
            {
                SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Till_Restuarant_Softwear.Properties.Settings.Setting"].ToString());
                conn.Open();
                SqlCommand cmd = new SqlCommand("Select Count(*) from User_Info", conn);
                Int32 dr = (Int32)cmd.ExecuteScalar();
                jusers.Text = dr.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
//
//Total Customers
//
        public void TotalCustomers()
        {
            try
            {
               SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Till_Restuarant_Softwear.Properties.Settings.Setting"].ToString());
                conn.Open();
                SqlCommand cmd = new SqlCommand("Select Count(*) from Customer", conn);
                Int32 dr = (Int32)cmd.ExecuteScalar();
                jcustomers.Text = dr.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
//
//Total Employees
//
        public void TotalEmployees()
        {
            try
            {
                SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Till_Restuarant_Softwear.Properties.Settings.Setting"].ToString());
                conn.Open();
                SqlCommand cmd = new SqlCommand("Select Count(*) from Employee", conn);
                Int32 dr = (Int32)cmd.ExecuteScalar();
                jemployees.Text = dr.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

//
//Total Expenses
//
        public void TotalExpenses()
        {
            try
            {
                SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Till_Restuarant_Softwear.Properties.Settings.Setting"].ToString());
                conn.Open();
                SqlCommand cmd = new SqlCommand("Select * from Expenses", conn);
                SqlDataReader dr;
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Double getAmount = Convert.ToDouble(dr["Amount"].ToString());
                    Double price = Convert.ToDouble(jtotalexpenses.Text);
                    Double total = getAmount + price;
                    String t1 = Convert.ToString(total);
                    jtotalexpenses.Text = t1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }    
//
//Total Sale by Dine-In
//
        public void Sale_By_Dine_In()
        {
            try
            {
               SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Till_Restuarant_Softwear.Properties.Settings.Setting"].ToString());
                conn.Open();
                SqlCommand cmd = new SqlCommand("Select Count(*) from Dine_In Where Status='" + "Cash" + "'", conn);
                Int32 dr = (Int32)cmd.ExecuteScalar();
                jsalebydinein.Text = dr.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
//
//Total Sale by Take-away
//
        public void Sale_By_Take_Away()
        {
            try
            {
                SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Till_Restuarant_Softwear.Properties.Settings.Setting"].ToString());
                conn.Open();
                SqlCommand cmd = new SqlCommand("Select Count(*) from Take_Away Where Status='" + "Cash" + "'", conn);
                Int32 dr = (Int32)cmd.ExecuteScalar();
                jsalebytakeaway.Text = dr.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
//
//Total Sale by Delivery
//
        public void Sale_By_Delivery()
        {
            try
            {
                SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Till_Restuarant_Softwear.Properties.Settings.Setting"].ToString());
                conn.Open();
                SqlCommand cmd = new SqlCommand("Select Count(*) from Delivery Where Status='" + "Cash" + "'", conn);
                Int32 dr = (Int32)cmd.ExecuteScalar();
                jsalebydelivery.Text = dr.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
//
//Close Btn
//
        private void JBTN_CLOSE_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin_Page set = new Admin_Page();
            set.Show();
            set.BringToFront();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }
    }
}
