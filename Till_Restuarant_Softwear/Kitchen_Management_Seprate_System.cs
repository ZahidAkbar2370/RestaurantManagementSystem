using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Till_Restuarant_Softwear
{
    public partial class Kitchen_Management_Seprate_System : Form
    {
        private int timers;
        public Kitchen_Management_Seprate_System()
        {
            InitializeComponent();
            View();
        }
        public void View()
        {
            jviewtable.Rows.Clear();

            this.Text = "Kitchen Management System";
            jstatus.Text = "New Order";

            JNEWORDER_BTN.BackColor = Color.Yellow;
            JNEWORDER_BTN.ForeColor = Color.Black;
            try
            {
                /* SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Till_Restuarant_Softwear.Properties.Settings.Setting"].ToString());
                 conn.Open();
                 SqlDataAdapter sqlDA = new SqlDataAdapter("Select* From Menu_Order Where Status='" + "New Order" + "'", conn);
                 DataTable dt = new DataTable();
                 sqlDA.Fill(dt);
                 jviewtable.DataSource = dt;

                 //Edit table and Delete Table Rows Control
                 jbtntable.Rows.Clear();
                 int i = 1;
                 int rows = jviewtable.Rows.Count;
                 while (i <= rows)
                 {
                     jbtntable.Rows.Add("Prepare");
                     i++;
                 }*/

                /*SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Till_Restuarant_Softwear.Properties.Settings.Setting"].ToString());
                conn.Open();
                SqlCommand cmd = new SqlCommand("Select* From Menu_Order Where Status='" + "New Order" + "'", conn);
                SqlDataReader dr;
                dr = cmd.ExecuteReader();
                while(dr.Read())
                {

                    String column_getorderid = dr["Order_Id"].ToString();
                    String column_getinvoiceno = dr["InvoiceNo"].ToString();
                    String column_getmenuname = dr["MenuName"].ToString();
                    String column_getquantity = dr["Quantity"].ToString();
                    String column_getstatus = dr["Status"].ToString();

                    jviewtable.Rows.Add(column_getinvoiceno,column_getorderid,column_getmenuname,column_getquantity,column_getstatus,"Prepare");
                }*/
                jviewtable.Rows.Clear();

                SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Till_Restuarant_Softwear.Properties.Settings.Setting"].ToString());
                conn.Open();
                SqlCommand cmd = new SqlCommand("Select* From Menu_Order Where Status='" + "New Order" + "'", conn);
                SqlDataReader dr;
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    String column_getorderno = dr["Order_Id"].ToString();
                    String column_getinvoiceno = dr["InvoiceNo"].ToString();
                    String column_getquantityno = dr["Quantity"].ToString();
                    String column_getmenuname = dr["MenuName"].ToString();
                    String column_gestatus = dr["Status"].ToString();

                    SqlConnection conn1 = new SqlConnection(ConfigurationManager.ConnectionStrings["Till_Restuarant_Softwear.Properties.Settings.Setting"].ToString());
                    conn1.Open();
                    SqlCommand cmd1 = new SqlCommand("Select* From Dine_In Where InvoiceNo='" + column_getinvoiceno + "'", conn1);
                    SqlDataReader dr1;
                    dr1 = cmd1.ExecuteReader();
                    if (dr1.Read())
                    {
                        String tableNo = dr1["TableNo"].ToString();
                        String waiterName = dr1["WaiterName"].ToString();

                        jviewtable.Rows.Add(column_getorderno, column_getinvoiceno, column_getmenuname, column_getquantityno, column_gestatus, tableNo, waiterName, "Prepare");
                    }
                    else
                    {
                        jviewtable.Rows.Add(column_getorderno, column_getinvoiceno, column_getmenuname, column_getquantityno, column_gestatus, "None", "None", "Prepare");
                    }
                }
                }
            catch (Exception ex)
            {
                this.Text = "Internet Conntection Not Found";
                //MessageBox.Show(, "Error");
            }
        }

        public void PreparingOrder()
        {
            try
            {
                jviewtable.Rows.Clear();

                this.Text = "Kitchen Management System";

                /*SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Till_Restuarant_Softwear.Properties.Settings.Setting"].ToString());
                conn.Open();
                SqlDataAdapter sqlDA = new SqlDataAdapter("Select* From Menu_Order Where Status='" + "Preparing Order" + "'", conn);
                DataTable dt = new DataTable();
                sqlDA.Fill(dt);
                jviewtable.DataSource = dt;

                //Edit table and Delete Table Rows Control
                jbtntable.Rows.Clear();
                int i = 1;
                int rows = jviewtable.Rows.Count;
                while (i <= rows)
                {
                    jbtntable.Rows.Add("Complete");
                    i++;
                }*/

                /* SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Till_Restuarant_Softwear.Properties.Settings.Setting"].ToString());
                 conn.Open();
                 SqlCommand cmd = new SqlCommand("Select* From Menu_Order Where Status='" + "Preparing Order" + "'", conn);
                 SqlDataReader dr;
                 dr = cmd.ExecuteReader();
                 while(dr.Read())
                 {

                     String column_getorderid = dr["Order_Id"].ToString();
                     String column_getinvoiceno = dr["InvoiceNo"].ToString();
                     String column_getmenuname = dr["MenuName"].ToString();
                     String column_getquantity = dr["Quantity"].ToString();
                     String column_getstatus = dr["Status"].ToString();

                     jviewtable.Rows.Add(column_getinvoiceno, column_getorderid, column_getmenuname, column_getquantity, column_getstatus, "Complete");

                 }*/
                jviewtable.Rows.Clear();

                SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Till_Restuarant_Softwear.Properties.Settings.Setting"].ToString());
                conn.Open();
                SqlCommand cmd = new SqlCommand("Select* From Menu_Order Where Status='" + "Preparing Order" + "'", conn);
                SqlDataReader dr;
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    String column_getorderno = dr["Order_Id"].ToString();
                    String column_getinvoiceno = dr["InvoiceNo"].ToString();
                    String column_getquantityno = dr["Quantity"].ToString();
                    String column_getmenuname = dr["MenuName"].ToString();
                    String column_gestatus = dr["Status"].ToString();

                    SqlConnection conn1 = new SqlConnection(ConfigurationManager.ConnectionStrings["Till_Restuarant_Softwear.Properties.Settings.Setting"].ToString());
                    conn1.Open();
                    SqlCommand cmd1 = new SqlCommand("Select* From Dine_In Where InvoiceNo='" + column_getinvoiceno + "'", conn1);
                    SqlDataReader dr1;
                    dr1 = cmd1.ExecuteReader();
                    if (dr1.Read())
                    {
                        String tableNo = dr1["TableNo"].ToString();
                        String waiterName = dr1["WaiterName"].ToString();

                        jviewtable.Rows.Add(column_getorderno, column_getinvoiceno, column_getmenuname, column_getquantityno, column_gestatus, tableNo, waiterName, "Complete");
                    }
                    else
                    {
                        jviewtable.Rows.Add(column_getorderno, column_getinvoiceno, column_getmenuname, column_getquantityno, column_gestatus, "None", "None", "Complete");
                    }
                }
                }
            catch (Exception ex)
            {
                String message = ex.ToString();
                this.Text = "Internet Conntection Not Found";
                //MessageBox.Show(ex.ToString(), "Error");
            }
        }
        private void JNEWORDER_BTN_Click(object sender, EventArgs e)
        {
            jstatus.Text = "New Order";

            JNEWORDER_BTN.BackColor = Color.Yellow;
            JPREPARINGORDER_BTN.BackColor = Color.DarkOrange;

            JNEWORDER_BTN.ForeColor = Color.Black;
            JPREPARINGORDER_BTN.ForeColor = Color.White;

            View();
        }

        private void JPREPARINGORDER_BTN_Click(object sender, EventArgs e)
        {
            jstatus.Text = "Preparing Order";
            
            JNEWORDER_BTN.BackColor = Color.DarkOrange;
            JPREPARINGORDER_BTN.BackColor = Color.Yellow;

            JNEWORDER_BTN.ForeColor = Color.White;
            JPREPARINGORDER_BTN.ForeColor = Color.Black;

            PreparingOrder();
        }

        private void jbtntable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void Kitchen_Management_Seprate_System_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timers++;
            jtimer.Text = timers.ToString();
            if(jtimer.Text=="10")
            {
                timers = 0;
                jtimer.Text = "0";
                if(jstatus.Text=="New Order")
                {
                    View();
                }
                else
                {
                    PreparingOrder();
                }
            }
        }

        private void JLOWSTOCKNOTIFICATION_BTN_Click(object sender, EventArgs e)
        {
            
            Notification_Alert set = new Notification_Alert();

            set.Show();
            set.BringToFront();
        }
//
//View Data Table Action Perform
//
        private void jviewtable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (jstatus.Text == "New Order")
            {
                try
                {
                    int rowIndex = jviewtable.CurrentCell.RowIndex;
                    //get column values
                    String Column_OrderNo = jviewtable.Rows[rowIndex].Cells[0].Value.ToString();

                    //SqlConnection conn = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Integrated Security=True");
                    SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Till_Restuarant_Softwear.Properties.Settings.Setting"].ToString());

                    conn.Open();
                    String query = "UPDATE Menu_Order SET Status='" + "Preparing Order" + "'WHERE Order_Id='" + Column_OrderNo + "'";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.ExecuteNonQuery();

                    
                    //MessageBox.Show("Prepared");
                    View();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            else
            if (jstatus.Text == "Preparing Order")
            {
                try
                {
                    int rowIndex = jviewtable.CurrentCell.RowIndex;
                    //get column values
                    String Column_InvoiceNo = jviewtable.Rows[rowIndex].Cells[0].Value.ToString();

                    SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Till_Restuarant_Softwear.Properties.Settings.Setting"].ToString());
                    conn.Open();
                    String query = "UPDATE Menu_Order SET Status='" + "Completed Order" + "'WHERE Order_Id='" + Column_InvoiceNo + "'";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.ExecuteNonQuery();

                    PreparingOrder();
                    //MessageBox.Show("Prepared");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }
    }
}
