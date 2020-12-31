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
    public partial class Kitchen_Management_System_Control : Form
    {
        private readonly Point_Of_Sale frm1;
        public Kitchen_Management_System_Control(Point_Of_Sale frm)
        {
            InitializeComponent();
            View();

           
            Check_Table_No();
            frm1 = frm;
        }
        public void View()
        {
            jviewtable.Rows.Clear();

            JEXPORTTOEXCLE_BTN.Visible = false;
            jstatus.Text = "New Order";
            JNEWORDER_BTN.BackColor = Color.Yellow;
            JNEWORDER_BTN.ForeColor = Color.Black;
            try
            {

                SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Till_Restuarant_Softwear.Properties.Settings.Setting"].ToString());
                conn.Open();
                SqlCommand cmd = new SqlCommand("Select* From Menu_Order Where Status='" + "New Order" + "'", conn);
                SqlDataReader dr;
                dr = cmd.ExecuteReader();
                while(dr.Read() )
                {
                    String column_getorderno = dr["Order_Id"].ToString();
                    String column_getinvoiceno = dr["InvoiceNo"].ToString();
                    String column_getquantityno = dr["Quantity"].ToString();
                    String column_getmenuname = dr["MenuName"].ToString();
                    String column_gestatus = dr["Status"].ToString();

                    SqlConnection conn1 = new SqlConnection(ConfigurationManager.ConnectionStrings["Till_Restuarant_Softwear.Properties.Settings.Setting"].ToString());
                    conn1.Open();
                    SqlCommand cmd1 = new SqlCommand("Select* From Dine_In Where InvoiceNo='" +column_getinvoiceno + "'", conn1);
                    SqlDataReader dr1;
                    dr1 = cmd1.ExecuteReader();
                    if(dr1.Read())
                    {
                        String tableNo = dr1["TableNo"].ToString();
                        String waiterName = dr1["WaiterName"].ToString();

                        jviewtable.Rows.Add(column_getorderno, column_getinvoiceno, column_getmenuname, column_getquantityno, column_gestatus, tableNo, waiterName,"Prepare");
                    }
                    else
                    {
                        jviewtable.Rows.Add(column_getorderno, column_getinvoiceno, column_getmenuname, column_getquantityno, column_gestatus, "None", "None", "Prepare");
                    }
                }
                
                /*SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Till_Restuarant_Softwear.Properties.Settings.Setting"].ToString());
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
                }
                */
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error");
            }
        }

        public void PreparingOrder()
        {
            try
            {
                /* SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Till_Restuarant_Softwear.Properties.Settings.Setting"].ToString());
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
                MessageBox.Show(ex.ToString(), "Error");
            }
        }
        public String table_no;
        public String waiter_name;

        public void CompletedOrder()
        {

            try
            {
                /*SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Till_Restuarant_Softwear.Properties.Settings.Setting"].ToString());

                conn.Open();
                SqlDataAdapter sqlDA = new SqlDataAdapter("Select* From Menu_Order Where Status='" + "Completed Order" + "'", conn);
                DataTable dt = new DataTable();
                sqlDA.Fill(dt);
                jviewtable.DataSource = dt;

                //Edit table and Delete Table Rows Control
                jbtntable.Rows.Clear();
                int i = 1;
                int rows = jviewtable.Rows.Count;
                while (i <= rows)
                {
                    jbtntable.Rows.Add("Cash");
                    i++;
                }*/
                jviewtable.Rows.Clear();

                SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Till_Restuarant_Softwear.Properties.Settings.Setting"].ToString());
                conn.Open();
                SqlCommand cmd = new SqlCommand("Select* From Menu_Order Where Status='" + "Completed Order" + "'", conn);
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

                        jviewtable.Rows.Add(column_getorderno, column_getinvoiceno, column_getmenuname, column_getquantityno, column_gestatus, tableNo, waiterName, "Cash");
                    }
                    else
                    {
                        jviewtable.Rows.Add(column_getorderno, column_getinvoiceno, column_getmenuname, column_getquantityno, column_gestatus, "None", "None", "Cash");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error");
            }
        }


        public void Check_Table_No()
        {

            try
            {
                dataGridView1.Rows.Clear();
                int items = jviewtable.Rows.Count;
                for (int i = 0; i < items; i++)
                {
                    String invoiceNo = jviewtable.Rows[i].Cells[1].Value.ToString();

                    SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Till_Restuarant_Softwear.Properties.Settings.Setting"].ToString());
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("Select* From Dine_In Where InvoiceNo='" +invoiceNo + "'", conn);
                    SqlDataReader dr;
                    dr = cmd.ExecuteReader();
                    if(dr.Read())
                    {
                        String tableNo = dr["TableNo"].ToString();
                        String waiterName = dr["WaiterName"].ToString();
                        dataGridView1.Rows.Add("Table:"+tableNo,"Waiter:"+ waiterName);
                    }
                    else
                    {
                        dataGridView1.Rows.Add("None","None");
                    }
                   
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error");
            }
        }


        private void JNEWORDER_BTN_Click(object sender, EventArgs e)
        {
           // dataGridView1.Visible = true;
            jstatus.Text = "New Order";

            JEXPORTTOEXCLE_BTN.Visible = false;
            /*jviewtable.Location = new Point(174, 116);
            jbtntable.Location = new Point(848, 116);
            dataGridView1.Location = new Point(-41, 116);*/
            JNEWORDER_BTN.BackColor = Color.Yellow;
            JPREPARINGORDER_BTN.BackColor = Color.DarkOrange;
            JCOMPLETEORDER.BackColor = Color.DarkOrange;
            JORDER_HISTORY.BackColor = Color.DarkOrange;

            JNEWORDER_BTN.ForeColor = Color.Black;
            JPREPARINGORDER_BTN.ForeColor = Color.White;
            JCOMPLETEORDER.ForeColor = Color.White;
            JORDER_HISTORY.ForeColor = Color.White;

            jsearchneworderinvoice.Enabled = true;
           // jbtntable.Visible = true;
           // jviewtable.Width = 715;
            View();
            Check_Table_No();
        }

        private void jbtntable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            /*if(jstatus.Text=="New Order")
            {
                try
                {
                    int rowIndex = jbtntable.CurrentCell.RowIndex;
                    //get column values
                    String Column_OrderNo = jviewtable.Rows[rowIndex].Cells[0].Value.ToString();

                     SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Till_Restuarant_Softwear.Properties.Settings.Setting"].ToString());

                    conn.Open();
                    String query = "UPDATE Menu_Order SET Status='" + "Preparing Order" + "'WHERE Order_Id='" + Column_OrderNo + "'";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.ExecuteNonQuery();

                    View();
                    Check_Table_No();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            else
            if(jstatus.Text=="Preparing Order")
            {
                try
                {
                    int rowIndex = jbtntable.CurrentCell.RowIndex;
                    //get column values
                    String Column_InvoiceNo = jviewtable.Rows[rowIndex].Cells[0].Value.ToString();

                    //SqlConnection conn = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Integrated Security=True");
                    SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Till_Restuarant_Softwear.Properties.Settings.Setting"].ToString());
                    conn.Open();
                    String query = "UPDATE Menu_Order SET Status='" + "Completed Order" + "'WHERE Order_Id='" + Column_InvoiceNo + "'";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.ExecuteNonQuery();

                    PreparingOrder();
                    Check_Table_No();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            else
            if(jstatus.Text=="Completed Order")
            {
                String DeliverTime = DateTime.Now.ToString("hh:mm:ss");
                if (Point_Of_Sale.jinvoiceno.Text == "Invoice")
                {
                    try
                    {
                        int rowIndex = jbtntable.CurrentCell.RowIndex;
                        //get column values
                        String Column_OrderID = jviewtable.Rows[rowIndex].Cells[0].Value.ToString();
                        String Column_InvoiceNo = jviewtable.Rows[rowIndex].Cells[1].Value.ToString();
                        String Column_TotalPrice = jviewtable.Rows[rowIndex].Cells[2].Value.ToString();
                        String Column_Quantity = jviewtable.Rows[rowIndex].Cells[3].Value.ToString();
                        String Column_Status = jviewtable.Rows[rowIndex].Cells[4].Value.ToString();

                       SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Till_Restuarant_Softwear.Properties.Settings.Setting"].ToString());
                        conn.Open();
                        String query = "Select Count(*) from Menu_Order WHERE InvoiceNo='" + Column_InvoiceNo + "'";
                        SqlCommand cmd = new SqlCommand(query, conn);
                        Int32 dr = (Int32)cmd.ExecuteScalar();


                        SqlConnection conn1 = new SqlConnection(ConfigurationManager.ConnectionStrings["Till_Restuarant_Softwear.Properties.Settings.Setting"].ToString());
                        conn1.Open();
                        String query1 = "Select Count(*) from Menu_Order WHERE InvoiceNo='" + Column_InvoiceNo + "'and Status='" + "Completed Order" + "'";
                        SqlCommand cmd1 = new SqlCommand(query1, conn1);
                        Int32 dr1 = (Int32)cmd1.ExecuteScalar();
                        if (dr == dr1)
                        {
                            SqlConnection conn2 = new SqlConnection(ConfigurationManager.ConnectionStrings["Till_Restuarant_Softwear.Properties.Settings.Setting"].ToString());
                            conn2.Open();
                            String query2 = "UPDATE Menu_Order SET Status='" + "Cash" + "'WHERE InvoiceNo='" + Column_InvoiceNo + "'";
                            SqlCommand cmd2 = new SqlCommand(query2, conn2);
                            cmd2.ExecuteNonQuery();
                            conn2.Close();

                            SqlConnection conn3 = new SqlConnection(ConfigurationManager.ConnectionStrings["Till_Restuarant_Softwear.Properties.Settings.Setting"].ToString());
                            conn3.Open();
                            String query3 = "UPDATE Take_Away SET Status='" + "Cash" + "'WHERE InvoiceNo='" + Column_InvoiceNo + "'";
                            SqlCommand cmd3 = new SqlCommand(query3, conn3);
                            cmd3.ExecuteNonQuery();
                            conn3.Close();
                            
                            //Delivery Update
                            SqlConnection conn4 = new SqlConnection(ConfigurationManager.ConnectionStrings["Till_Restuarant_Softwear.Properties.Settings.Setting"].ToString());
                            conn4.Open();
                            String query4 = "UPDATE Delivery SET Status='" + "Cash"+"',DeliveryTime='"+ DeliverTime + "'WHERE InvoiceNo='" + Column_InvoiceNo + "'";
                            SqlCommand cmd4 = new SqlCommand(query4, conn4);
                            cmd4.ExecuteNonQuery();
                            conn4.Close();
                            
                            //DineIn Update
                            SqlConnection conn5 = new SqlConnection(ConfigurationManager.ConnectionStrings["Till_Restuarant_Softwear.Properties.Settings.Setting"].ToString());
                            conn5.Open();
                            String query5 = "UPDATE Dine_In SET Status='" + "Cash" + "'WHERE InvoiceNo='" + Column_InvoiceNo + "'";
                            SqlCommand cmd5 = new SqlCommand(query5, conn5);
                            cmd5.ExecuteNonQuery();
                            conn5.Close();

                            Point_Of_Sale.jinvoiceno.Text = Column_InvoiceNo;

                            //Refresh
                            frm1.GetDataOfInvoice();

                            frm1.GetDataOfInvoice1();
                            CompletedOrder();
                            Check_Table_No();

                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("This InvoiceNo Order Not Completed Please Wait");
                        }
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                }
                else
                {
                    MessageBox.Show("Already One Order Ready For Deliver");
                }

            }*/
        }

        private void JPREPARINGORDER_BTN_Click(object sender, EventArgs e)
        {


            //dataGridView1.Visible = true;
            jstatus.Text = "Preparing Order";

            JEXPORTTOEXCLE_BTN.Visible = false;
            //jviewtable.Location = new Point(174, 116);
            //jbtntable.Location = new Point(848, 116);
            //dataGridView1.Location = new Point(-41, 116);
            jsearchneworderinvoice.Enabled = true;

            JNEWORDER_BTN.BackColor = Color.DarkOrange;
            JPREPARINGORDER_BTN.BackColor = Color.Yellow;
            JCOMPLETEORDER.BackColor = Color.DarkOrange;
            JORDER_HISTORY.BackColor = Color.DarkOrange;

            JNEWORDER_BTN.ForeColor = Color.White;
            JPREPARINGORDER_BTN.ForeColor = Color.Black;
            JCOMPLETEORDER.ForeColor = Color.White;
            JORDER_HISTORY.ForeColor = Color.White;

            //jbtntable.Visible = true;
            //jviewtable.Width = 715;
            PreparingOrder();
            Check_Table_No();
        }

        private void JCOMPLETEORDER_Click(object sender, EventArgs e)
        {
            //dataGridView1.Visible = true;
            jstatus.Text = "Completed Order";

            //jviewtable.Location = new Point(174, 116);
            //jbtntable.Location = new Point(848, 116);
            //dataGridView1.Location = new Point(-41, 116);


            JEXPORTTOEXCLE_BTN.Visible = false;

            JNEWORDER_BTN.BackColor = Color.DarkOrange;
            JPREPARINGORDER_BTN.BackColor = Color.DarkOrange;
            JCOMPLETEORDER.BackColor = Color.Yellow;

            JNEWORDER_BTN.ForeColor = Color.White;
            JPREPARINGORDER_BTN.ForeColor = Color.White;
            JCOMPLETEORDER.ForeColor = Color.Black;
            JORDER_HISTORY.ForeColor = Color.White;

            jsearchneworderinvoice.Enabled = true;
            JORDER_HISTORY.BackColor = Color.DarkOrange;

            //jbtntable.Visible = true;
            //jviewtable.Width = 715;

            CompletedOrder();
            Check_Table_No();
        }

        private void jsearchneworderinvoice_TextChanged(object sender, EventArgs e)
        {
            if (jsearchneworderinvoice.Text == "")
            {
                try
                {
                    /*SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Till_Restuarant_Softwear.Properties.Settings.Setting"].ToString());
                    //SqlConnection conn = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Integrated Security=True");
                    conn.Open();
                    SqlDataAdapter sqlDA = new SqlDataAdapter("Select* From Menu_Order Where Status='" + jstatus.Text + "'", conn);
                    DataTable dt = new DataTable();
                    sqlDA.Fill(dt);
                    jviewtable.DataSource = dt;

                    if(jstatus.Text=="New Order")
                    {
                        //Edit table and Delete Table Rows Control
                        jbtntable.Rows.Clear();
                        int i = 1;
                        int rows = jviewtable.Rows.Count;
                        while (i <= rows)
                        {
                            jbtntable.Rows.Add("Prepare");
                            i++;
                        }
                        Check_Table_No();
                    }
                    else 
                    if(jstatus.Text== "Preparing Order")
                    {
                        jbtntable.Rows.Clear();
                        int i = 1;
                        int rows = jviewtable.Rows.Count;
                        while (i <= rows)
                        {
                            jbtntable.Rows.Add("Complete");
                            i++;
                        }
                        Check_Table_No();
                    }
                    else
                    {
                        jbtntable.Rows.Clear();
                        int i = 1;
                        int rows = jviewtable.Rows.Count;
                        while (i <= rows)
                        {
                            jbtntable.Rows.Add("Cash");
                            i++;
                        }
                        Check_Table_No();
                    }
                    */
                    if (jstatus.Text == "New Order")
                    {
                        View();
                    }
                    else
                     if (jstatus.Text == "Preparing Order")
                    {
                        PreparingOrder();
                    }
                    else
                    {
                        CompletedOrder();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "Error");
                }
            }
            else
            {
                try
                {
                    SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Till_Restuarant_Softwear.Properties.Settings.Setting"].ToString());
                    //SqlConnection conn = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Integrated Security=True");
                    conn.Open();
                    SqlDataAdapter sqlDA = new SqlDataAdapter("Select* From Menu_Order Where Status='" + jstatus.Text + "'and InvoiceNo like'" + "%" + jsearchneworderinvoice.Text + "%" + "'", conn);
                    DataTable dt = new DataTable();
                    sqlDA.Fill(dt);
                    jviewtable.DataSource = dt;

                    if (jstatus.Text == "New Order")
                    {
                        //Edit table and Delete Table Rows Control
                        jbtntable.Rows.Clear();
                        int i = 1;
                        int rows = jviewtable.Rows.Count;
                        while (i <= rows)
                        {
                            jbtntable.Rows.Add("Prepare");
                            i++;
                        }
                    }
                    else
                    if (jstatus.Text == "Preparing Order")
                    {
                        jbtntable.Rows.Clear();
                        int i = 1;
                        int rows = jviewtable.Rows.Count;
                        while (i <= rows)
                        {
                            jbtntable.Rows.Add("Complete");
                            i++;
                        }
                    }
                    else
                    {
                        jbtntable.Rows.Clear();
                        int i = 1;
                        int rows = jviewtable.Rows.Count;
                        while (i <= rows)
                        {
                            jbtntable.Rows.Add("Cash");
                            i++;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "Error");
                }
            }
        }

        private void JORDER_HISTORY_Click(object sender, EventArgs e)
        {
            jviewtable.Rows.Clear();
            // dataGridView1.Visible = false;
            jstatus.Text = "Order History";

            JEXPORTTOEXCLE_BTN.Visible = true;

            jsearchneworderinvoice.Enabled = false;
            //jbtntable.Visible = false;
            //jviewtable.Width = 967;
            //jviewtable.Location = new Point(5,116);

            JNEWORDER_BTN.BackColor = Color.DarkOrange;
            JPREPARINGORDER_BTN.BackColor = Color.DarkOrange;
            JCOMPLETEORDER.BackColor = Color.DarkOrange;
            JORDER_HISTORY.BackColor = Color.Yellow;

            JNEWORDER_BTN.ForeColor = Color.White;
            JPREPARINGORDER_BTN.ForeColor = Color.White;
            JCOMPLETEORDER.ForeColor = Color.White;
            JORDER_HISTORY.ForeColor = Color.Black;


            try
            {
                /*SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Till_Restuarant_Softwear.Properties.Settings.Setting"].ToString());
                conn.Open();
                SqlDataAdapter sqlDA = new SqlDataAdapter("Select* From Menu_Order", conn);
                DataTable dt = new DataTable();
                sqlDA.Fill(dt);
                jviewtable.DataSource = dt;

                jbtntable.Rows.Clear();

               int i = 1;
               int rows = jviewtable.Rows.Count;
               while (i <= rows)
               {
                  jbtntable.Rows.Add("Cash");
                  i++;
               }*/

                SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Till_Restuarant_Softwear.Properties.Settings.Setting"].ToString());
                conn.Open();
                SqlCommand cmd = new SqlCommand("Select* From Menu_Order", conn);
                SqlDataReader dr;
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    String column_getorderno = dr["Order_Id"].ToString();
                    String column_getinvoiceno = dr["InvoiceNo"].ToString();
                    String column_getquantityno = dr["Quantity"].ToString();
                    String column_getmenuname = dr["Quantity"].ToString();
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

                        jviewtable.Rows.Add(column_getorderno, column_getinvoiceno, column_getmenuname, column_getquantityno, column_gestatus, tableNo, waiterName, "None");
                    }
                    else
                    {
                        jviewtable.Rows.Add(column_getorderno, column_getinvoiceno, column_getmenuname, column_getquantityno, column_gestatus, "None", "None", "None");
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error");
            }
        }
//
//Export To Excel
//
        private void JEXPORTTOEXCLE_BTN_Click(object sender, EventArgs e)
        {
            if (jviewtable.Rows.Count > 0)
            {
                try
                {
                    Microsoft.Office.Interop.Excel.Application excle = new Microsoft.Office.Interop.Excel.Application();
                    excle.Application.Workbooks.Add(Type.Missing);
                    for (int i = 1; i < jviewtable.Columns.Count + 1; i++)

                    {
                        excle.Cells[1, i] = jviewtable.Columns[i - 1].HeaderText;
                    }
                    for (int i = 0; i < jviewtable.Rows.Count; i++)
                    {
                        for (int j = 0; j < jviewtable.Columns.Count; j++)
                        {
                            excle.Cells[i + 2, j + 1] = jviewtable.Rows[i].Cells[j].Value.ToString();
                        }
                    }
                    excle.Columns.AutoFit();
                    excle.Visible = true;

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
//
//Data View Table Action Perform
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

                    SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Till_Restuarant_Softwear.Properties.Settings.Setting"].ToString());

                    conn.Open();
                    String query = "UPDATE Menu_Order SET Status='" + "Preparing Order" + "'WHERE Order_Id='" + Column_OrderNo + "'";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.ExecuteNonQuery();

                    View();
                    Check_Table_No();
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

                    //SqlConnection conn = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Integrated Security=True");
                    SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Till_Restuarant_Softwear.Properties.Settings.Setting"].ToString());
                    conn.Open();
                    String query = "UPDATE Menu_Order SET Status='" + "Completed Order" + "'WHERE Order_Id='" + Column_InvoiceNo + "'";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.ExecuteNonQuery();

                    PreparingOrder();
                    Check_Table_No();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            else
            if (jstatus.Text == "Completed Order")
            {
                String DeliverTime = DateTime.Now.ToString("hh:mm:ss");
                if (Point_Of_Sale.jinvoiceno.Text == "Invoice")
                {
                    try
                    {
                        int rowIndex = jviewtable.CurrentCell.RowIndex;
                        //get column values
                        String Column_OrderID = jviewtable.Rows[rowIndex].Cells[0].Value.ToString();
                        String Column_InvoiceNo = jviewtable.Rows[rowIndex].Cells[1].Value.ToString();
                        String Column_TotalPrice = jviewtable.Rows[rowIndex].Cells[2].Value.ToString();
                        String Column_Quantity = jviewtable.Rows[rowIndex].Cells[3].Value.ToString();
                        String Column_Status = jviewtable.Rows[rowIndex].Cells[4].Value.ToString();

                        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Till_Restuarant_Softwear.Properties.Settings.Setting"].ToString());
                        conn.Open();
                        String query = "Select Count(*) from Menu_Order WHERE InvoiceNo='" + Column_InvoiceNo + "'";
                        SqlCommand cmd = new SqlCommand(query, conn);
                        Int32 dr = (Int32)cmd.ExecuteScalar();


                        SqlConnection conn1 = new SqlConnection(ConfigurationManager.ConnectionStrings["Till_Restuarant_Softwear.Properties.Settings.Setting"].ToString());
                        conn1.Open();
                        String query1 = "Select Count(*) from Menu_Order WHERE InvoiceNo='" + Column_InvoiceNo + "'and Status='" + "Completed Order" + "'";
                        SqlCommand cmd1 = new SqlCommand(query1, conn1);
                        Int32 dr1 = (Int32)cmd1.ExecuteScalar();
                        if (dr == dr1)
                        {
                            SqlConnection conn2 = new SqlConnection(ConfigurationManager.ConnectionStrings["Till_Restuarant_Softwear.Properties.Settings.Setting"].ToString());
                            conn2.Open();
                            String query2 = "UPDATE Menu_Order SET Status='" + "Cash" + "'WHERE InvoiceNo='" + Column_InvoiceNo + "'";
                            SqlCommand cmd2 = new SqlCommand(query2, conn2);
                            cmd2.ExecuteNonQuery();
                            conn2.Close();

                            SqlConnection conn3 = new SqlConnection(ConfigurationManager.ConnectionStrings["Till_Restuarant_Softwear.Properties.Settings.Setting"].ToString());
                            conn3.Open();
                            String query3 = "UPDATE Take_Away SET Status='" + "Cash" + "'WHERE InvoiceNo='" + Column_InvoiceNo + "'";
                            SqlCommand cmd3 = new SqlCommand(query3, conn3);
                            cmd3.ExecuteNonQuery();
                            conn3.Close();

                            //Delivery Update
                            SqlConnection conn4 = new SqlConnection(ConfigurationManager.ConnectionStrings["Till_Restuarant_Softwear.Properties.Settings.Setting"].ToString());
                            conn4.Open();
                            String query4 = "UPDATE Delivery SET Status='" + "Cash" + "',DeliveryTime='" + DeliverTime + "'WHERE InvoiceNo='" + Column_InvoiceNo + "'";
                            SqlCommand cmd4 = new SqlCommand(query4, conn4);
                            cmd4.ExecuteNonQuery();
                            conn4.Close();

                            //DineIn Update
                            SqlConnection conn5 = new SqlConnection(ConfigurationManager.ConnectionStrings["Till_Restuarant_Softwear.Properties.Settings.Setting"].ToString());
                            conn5.Open();
                            String query5 = "UPDATE Dine_In SET Status='" + "Cash" + "'WHERE InvoiceNo='" + Column_InvoiceNo + "'";
                            SqlCommand cmd5 = new SqlCommand(query5, conn5);
                            cmd5.ExecuteNonQuery();
                            conn5.Close();

                            Point_Of_Sale.jinvoiceno.Text = Column_InvoiceNo;

                            //Refresh
                            frm1.GetDataOfInvoice();

                            frm1.GetDataOfInvoice1();
                            CompletedOrder();
                            Check_Table_No();

                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("This InvoiceNo Order Not Completed Please Wait");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                }
                else
                {
                    MessageBox.Show("Already One Order Ready For Deliver");
                }

            }
            
        }
    }
}
