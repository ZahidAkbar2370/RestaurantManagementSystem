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
    public partial class Point_Of_Sale : Form
    {

        public Point_Of_Sale()
        {
            InitializeComponent();
            View();
            panel7.Hide();
            if(jwaiterlogin.Text!="")
            {
                JTODAYSALE_BTN.Enabled = false;
                JNEW_BUTTON.Enabled = true;
            }
        }
        public void GetDataOfInvoice1()
        {
            int items = dataGridView1.Rows.Count;

            jitems.Text = items.ToString();

            int i = 0;
            while(i<items)
            {
                String Column_TotalPrice = dataGridView1.Rows[i].Cells[3].Value.ToString();
                Double amount = Convert.ToDouble(jtotalamount.Text);
                Double amount1 =Convert.ToDouble(Column_TotalPrice);
               Double amount2 = amount1 + amount;
               String amount3 = Convert.ToString(amount2);
                jtotalamount.Text = amount3;
                i++;
            }
        }

            public void GetDataOfInvoice()
        {
            try
            {
                SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Till_Restuarant_Softwear.Properties.Settings.Setting"].ToString());
                conn.Open();
                SqlCommand cmd = new SqlCommand("Select MenuName, UnitPrice, Quantity, TotalPrice From Take_Away Where InvoiceNo = '"+jinvoiceno.Text+"'", conn);
                SqlDataReader dr;
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    dataGridView1.Rows.Add(dr["MenuName"].ToString(), dr["UnitPrice"].ToString(), dr["Quantity"].ToString(), dr["TotalPrice"].ToString());
                    dataGridView4.Rows.Add("Delete");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error");
            }

            try
            {
                //SqlConnection conn = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Integrated Security=True");
                SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Till_Restuarant_Softwear.Properties.Settings.Setting"].ToString());
                conn.Open();
                SqlCommand cmd = new SqlCommand("Select MenuName, Price, Quantity, TotalPrice From Dine_In Where InvoiceNo = '" + jinvoiceno.Text + "'", conn);
                SqlDataReader dr;
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    dataGridView1.Rows.Add(dr["MenuName"].ToString(), dr["Price"].ToString(), dr["Quantity"].ToString(), dr["TotalPrice"].ToString());
                    dataGridView4.Rows.Add("Delete");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error");
            }

            try
            {
                //SqlConnection conn = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Integrated Security=True");
                SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Till_Restuarant_Softwear.Properties.Settings.Setting"].ToString());
                conn.Open();
                SqlCommand cmd = new SqlCommand("Select MenuName, Price, Quantity, TotalPrice From Delivery Where InvoiceNo = '" + jinvoiceno.Text + "'", conn);
                SqlDataReader dr;
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    dataGridView1.Rows.Add(dr["MenuName"].ToString(), dr["Price"].ToString(), dr["Quantity"].ToString(), dr["TotalPrice"].ToString());
                    dataGridView4.Rows.Add("Delete");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error");
            }
        }
        public void View()
        {
            int x = 20, y = 10;
            try
            {
                SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Till_Restuarant_Softwear.Properties.Settings.Setting"].ToString());
                //SqlConnection conn = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Integrated Security=True");
                conn.Open();
                SqlCommand cmd = new SqlCommand("Select * From Menu_Category", conn);
                SqlDataReader dr;
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Label l = addLabel(x, y);
                    l.Text = dr["Category"].ToString();
                    l.Click += new EventHandler(this.items_click);
                    y += 60;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error");
            }
        }
        //
        //Creating Item Btn 
        //
        Label addLabel(int a, int c)
        {
            Label b = new Label();
            b.Text = "1";
            b.Width = 150;
            b.Height = 50;
            b.BackColor = Color.Red;
            b.ForeColor = Color.White;
            b.TextAlign = ContentAlignment.MiddleCenter;
            b.Location = new Point(a, c);
            panel3.Controls.Add(b);
            return b;
        }
        //
        //When Click On Item
        //
        void items_click(object sender, EventArgs e)
        {
            Label current = (Label)sender;

            panel2.Controls.Clear();
            BTN_JDINEIN.BackColor = Color.Blue;
            JBTN_TAKEAWAY.BackColor = Color.Blue;
            BTN_JDELIVERY.BackColor = Color.Blue;

            int x = 10, y = 20;
            try
            {
                jselecteditems.Text = current.Text;//Hiden search product label k nichy
                //SqlConnection conn = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Integrated Security=True");
                SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Till_Restuarant_Softwear.Properties.Settings.Setting"].ToString());
                conn.Open();
                SqlCommand cmd = new SqlCommand("Select * From Item_Menu Where Category='" + current.Text + "'", conn);
                SqlDataReader dr;
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Button b = new Button();
                    b.Text = dr["Name"].ToString();
                    b.Width = 150;
                    b.Height = 80;
                    b.ForeColor = Color.White;
                    b.BackColor = Color.Green;
                    b.Location = new Point(x, y);
                    panel2.Controls.Add(b);
                    b.Click += new EventHandler(this.product_Click);
                    x += 150;
                    if (x >= 400)
                    {
                        y += 90;
                        x = 10;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error");
            }
        }

        //
        //When Click On Product Event Perform  
        //
        void product_Click(object sender, EventArgs e)
        {
            Button current = (Button)sender;
            try
            {
                if (jstatus1.Text == "Dine-In")
                {
                    if (jtable1.Text == "" && jwaiter1.Text == "")
                    {
                        MessageBox.Show("Please Select Table & Waiter");
                    }
                    else
                        if (jtable1.Text == "")
                    {
                        MessageBox.Show("Please Select Table");
                    }
                    else if (jwaiter1.Text == "")
                    {
                        MessageBox.Show("Please Select Waiter");
                    }
                    else
                    {
                        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Till_Restuarant_Softwear.Properties.Settings.Setting"].ToString());
                        //SqlConnection conn = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Integrated Security=True");
                        conn.Open();
                        SqlCommand cmd = new SqlCommand("Select * From Item_Menu Where Name='" + current.Text + "'", conn);
                        SqlDataReader dr;
                        dr = cmd.ExecuteReader();

                        panel2.Controls.Add(panel7);
                        panel7.Show();
                        panel7.BringToFront();

                        while (dr.Read())
                        {
                            jquantity.Text = "1";
                            jproductname1.Text = current.Text;
                            String getPrice = dr["Price"].ToString();
                            Double price = Convert.ToDouble(getPrice);
                            Double total = Convert.ToDouble(jquantity.Text) * price;
                            jprice.Text = getPrice;
                            jtotalprice.Text = price.ToString();
                        }
                    }
                }
                else
                {
                    //SqlConnection conn = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Integrated Security=True");
                    SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Till_Restuarant_Softwear.Properties.Settings.Setting"].ToString());
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("Select * From Item_Menu Where Name='" + current.Text + "'", conn);
                    SqlDataReader dr;
                    dr = cmd.ExecuteReader();
                    panel2.Controls.Add(panel7);
                    panel7.Show();
                    panel7.BringToFront();
                    while (dr.Read())
                    {
                        jquantity.Text = "1";
                        jproductname1.Text = current.Text;
                        String getPrice = dr["Price"].ToString();
                        Double price = Convert.ToDouble(getPrice);
                        Double total = Convert.ToDouble(jquantity.Text) * price;
                        jprice.Text = getPrice;
                        jtotalprice.Text = price.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error");
            }


        }
//
//Quantity Required
//
        private void jquantity_TextChanged(object sender, EventArgs e)
        {
            if (jquantity.Text != "")
            {
                Double price = Convert.ToDouble(jprice.Text);
                Double quantity = Convert.ToDouble(jquantity.Text);
                Double total = quantity * price;
                jtotalprice.Text = total.ToString();
            }
            else
            {
                jtotalprice.Text = jprice.Text;
            }
        }
//
//Dine In Btn
//
        private void BTN_JDINEIN_Click(object sender, EventArgs e)
        {
            jstatus1.Text = "Dine-In";

            BTN_JDINEIN.BackColor = Color.Yellow;
            JBTN_TAKEAWAY.BackColor = Color.DarkOrange;
            BTN_JDELIVERY.BackColor = Color.DarkOrange;

            //jfastcashBTN.Text = "Order";

            jtable.Visible = true;
            jwaiter.Visible = true;

            Select_Table f = new Select_Table();
            f.Show();
            f.BringToFront();
        }
//
//Take Away Btn
//
        private void JBTN_TAKEAWAY_Click(object sender, EventArgs e)
        {
            jstatus1.Text = "Take-away";

            BTN_JDELIVERY.BackColor = Color.DarkOrange;
            JBTN_TAKEAWAY.BackColor = Color.Yellow;
            BTN_JDINEIN.BackColor = Color.DarkOrange;
            
            jtable.Visible = false;
            jwaiter.Visible = false;
            jtable1.Text = "";
            jwaiter1.Text = "";
        }
//
//Delivery Sale Btn
//
        private void BTN_JDELIVERY_Click(object sender, EventArgs e)
        {
            jstatus1.Text = "Delivery";
            jtable.Visible = false;
            jwaiter.Visible = false;

            BTN_JDINEIN.BackColor = Color.DarkOrange;
            JBTN_TAKEAWAY.BackColor = Color.DarkOrange;
            BTN_JDELIVERY.BackColor = Color.Yellow;

            Delivery_Customer f = new Delivery_Customer();
            f.Show();
            f.BringToFront();
        }
//
//Today Sale Btn
//
        private void JTODAYSALE_BTN_Click(object sender, EventArgs e)
        {
            View_All_Sale set = new View_All_Sale();
            set.Show();
            set.BringToFront();
        }
//
//Re-Print Btn
//
        private void jREPRINT_BTN_Click(object sender, EventArgs e)
        {
        }
        //
        //Close Btn
        //
        private void JBTN_CLOSE_Click(object sender, EventArgs e)
        {
            if (label12.Text == "User Login")
            {
                this.Hide();

                Login_Page set = new Login_Page();
                set.Show();
                set.BringToFront();
            }
            else
                if (label12.Text == "User Login" ||jwaiterlogin.Text=="User Login" ||jwaiterlogin.Text=="Waiter")
            {
                this.Hide();

                Login_Page set = new Login_Page();
                set.Show();
                set.BringToFront();
            }
            else
            {
                // Application.Exit();
                this.Hide();

                /*Admin_Page set = new Admin_Page();
                set.Show();
                set.BringToFront();*/
            }
        }
//
//Search Item TextBox
//

        private void jsearchitem_TextChanged(object sender, EventArgs e)
        {
            int x = 20, y = 10;
            try
            {
                //If SearchBox Not Empty
                if (jsearchitem.Text != "")
                {
                    //SqlConnection conn = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Integrated Security=True");
                    SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Till_Restuarant_Softwear.Properties.Settings.Setting"].ToString());
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("Select * From Menu_Category Where Category LIKE'" + "%" + jsearchitem.Text + "%" + "'", conn);
                    SqlDataReader dr;
                    panel3.Controls.Clear();
                    dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        Label l = addLabel(x, y);
                        l.Text = dr["Category"].ToString();
                        panel3.Controls.Add(l);
                        l.Click += new EventHandler(this.items_click);
                        y += 60;
                    }

                }
                //If SearchBox Empty all show
                else
                {
                    SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Till_Restuarant_Softwear.Properties.Settings.Setting"].ToString());
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("Select * From Menu_Category", conn);
                    SqlDataReader dr;
                    panel3.Controls.Clear();
                    dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        Label l = addLabel(x, y);
                        l.Text = dr["Category"].ToString();
                        panel3.Controls.Add(l);
                        l.Click += new EventHandler(this.items_click);
                        y += 60;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error");
            }
        }
//
//Search Product TextBox
//
        private void jsearchproduct_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (jsearchproduct.Text != "")
                {
                    int x = 10, y = 20;
                    panel2.Controls.Clear();

                    //SqlConnection conn = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Integrated Security=True");
                    SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Till_Restuarant_Softwear.Properties.Settings.Setting"].ToString());
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("Select * From Item_Menu Where Category='" + jselecteditems.Text + "' and Name Like'" + "%" + jsearchproduct.Text + "%" + "'", conn);
                    SqlDataReader dr;
                    dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        Button b = new Button();
                        b.Text = dr["Name"].ToString();
                        b.Width = 150;
                        b.Height = 80;
                        b.ForeColor = Color.White;
                        b.BackColor = Color.Green;
                        b.Location = new Point(x, y);
                        panel2.Controls.Add(b);
                        b.Click += new EventHandler(this.product_Click);
                        x += 150;
                        if (x >= 400)
                        {
                            y += 90;
                            x = 10;
                        }
                    }
                }
                else
                {
                    int x = 10, y = 20;
                    SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Till_Restuarant_Softwear.Properties.Settings.Setting"].ToString());
                    //SqlConnection conn = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Integrated Security=True");
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("Select * From Item_Menu Where Category='" + jselecteditems.Text + "'", conn);
                    SqlDataReader dr;
                    dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        Button b = new Button();
                        b.Text = dr["Name"].ToString();
                        b.Width = 150;
                        b.Height = 80;
                        b.ForeColor = Color.White;
                        b.BackColor = Color.Green;
                        b.Location = new Point(x, y);
                        panel2.Controls.Add(b);
                        b.Click += new EventHandler(this.product_Click);
                        x += 150;
                        if (x >= 400)
                        {
                            y += 90;
                            x = 10;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error");
            }
        }
        //
        //quantity require Done Button
        //
        public int id;
        private void JBTN_DONE_Click(object sender, EventArgs e)
        {
            if(jinvoiceno.Text!="Invoice")
            {
                MessageBox.Show("ALready Order Competed First Check out");
            }
            else
            if (jquantity.Text == "")
            {
                MessageBox.Show("Please Enter Quantity");
            }
            else
            {
                if (jid.Text == "ID")
                {
                    try
                    {
                        //SqlConnection conn = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Integrated Security=True");
                        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Till_Restuarant_Softwear.Properties.Settings.Setting"].ToString());
                        conn.Open();
                        SqlCommand cmd = new SqlCommand("Select * From Item_Menu Where Name='" + jproductname1.Text + "'", conn);
                        SqlDataReader dr;
                        dr = cmd.ExecuteReader();
                        if (dr.Read())
                        {
                            Double price = Convert.ToDouble(dr["Price"].ToString());
                            Double total = Convert.ToDouble(jquantity.Text) * price;

                            dataGridView1.Rows.Add(jproductname1.Text, price.ToString(), jquantity.Text, total.ToString());

                            Double totalAmount = Convert.ToDouble(jtotalamount.Text) + Convert.ToDouble(total);
                            jtotalamount.Text = totalAmount.ToString();

                            Double totalItem = Convert.ToDouble(jitems.Text) + 1;
                            jitems.Text = totalItem.ToString();


                           dataGridView4.Rows.Add("Delete");
                            panel7.Hide();

                           
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
                        conn.Open();
                        SqlCommand cmd = new SqlCommand("Select * From Item_Menu Where Name='" + jproductname1.Text + "'", conn);
                        SqlDataReader dr;
                        dr = cmd.ExecuteReader();
                        if (dr.Read())
                        {
                            Double price = Convert.ToDouble(dr["Price"].ToString());
                            Double total = Convert.ToDouble(jquantity.Text) * price;

                            dataGridView1.Rows.RemoveAt(id);
                            dataGridView4.Rows.RemoveAt(id);

                            dataGridView1.Rows.Add(jproductname1.Text, price.ToString(), jquantity.Text, total.ToString());

                            Double totalAmount = Convert.ToDouble(jtotalamount.Text) + Convert.ToInt32(total);
                            jtotalamount.Text = totalAmount.ToString();

                            Double totalItem = Convert.ToDouble(jitems.Text) + 1;
                            jitems.Text = totalItem.ToString();

                            panel7.Hide();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString(), "Error");
                    }
                }
            }
        }
//
//Quantity Require Cancle Button
//
        private void BTNJ_CANCEL_Click(object sender, EventArgs e)
        {
            panel7.Hide();
        }
//
//Edit Table
//
        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }
//
//Delete Table For delete Row
//
        private void dataGridView4_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (jinvoiceno.Text == "Invoice")
            {
                int rowIndex = dataGridView4.CurrentCell.RowIndex;

                String Column_TotalPrice = dataGridView1.Rows[rowIndex].Cells[3].Value.ToString();
                int totalAmount = Convert.ToInt32(jtotalamount.Text) - Convert.ToInt32(Column_TotalPrice);
                jtotalamount.Text = totalAmount.ToString();

                int totalItem = Convert.ToInt32(jitems.Text) - 1;
                jitems.Text = totalItem.ToString();

                dataGridView1.Rows.RemoveAt(rowIndex);
                dataGridView4.Rows.RemoveAt(rowIndex);
            }
        }
//
//Fast Cash Btn
//
        private void JFASTCASH_Click(object sender, EventArgs e)
        {
            
            if(checkBox1.Checked && checkBox2.Checked)
            {
                MessageBox.Show("Please Select One Payment Type", "", MessageBoxButtons.OK);
            }
            else if(!checkBox1.Checked && !checkBox2.Checked)
            {
                MessageBox.Show("Please Select Payment Type", "", MessageBoxButtons.OK);
            }
            else
            if (jinvoiceno.Text == "Invoice")
            {

                MessageBox.Show("Please Create Create Order", "", MessageBoxButtons.OK);
            }
            else
            {
                try
                {
                    if(checkBox1.Checked)
                    {
                        String id1=DateTime.Now.ToString("dMyyhms");
                        String Date = DateTime.Now.ToString("dd/MM/yyyy");

                        SqlConnection conn1 = new SqlConnection(ConfigurationManager.ConnectionStrings["Till_Restuarant_Softwear.Properties.Settings.Setting"].ToString());
                        conn1.Open();
                        SqlCommand cmd1 = new SqlCommand("Insert Into Payment_Method values(@a,@b,@c,@d)",conn1);
                        cmd1.Parameters.AddWithValue("@a",id1);
                        cmd1.Parameters.AddWithValue("@b","Cash");
                        cmd1.Parameters.AddWithValue("@c",Date);
                        cmd1.Parameters.AddWithValue("@d",jtotalamount.Text);
                        cmd1.ExecuteNonQuery();
                        conn1.Close();
                    }
                    else if(checkBox2.Checked)
                    {
                        String id1 = DateTime.Now.ToString("dMyyhms");
                        String Date = DateTime.Now.ToString("dd/MM/yyyy");

                        SqlConnection conn1 = new SqlConnection(ConfigurationManager.ConnectionStrings["Till_Restuarant_Softwear.Properties.Settings.Setting"].ToString());
                        conn1.Open();
                        SqlCommand cmd1 = new SqlCommand("Insert Into Payment_Method values(@a,@b,@c,@d)",conn1);
                        cmd1.Parameters.AddWithValue("@a", id1);
                        cmd1.Parameters.AddWithValue("@b", "Credit Card");
                        cmd1.Parameters.AddWithValue("@c", Date);
                        cmd1.Parameters.AddWithValue("@d", jtotalamount.Text);
                        cmd1.ExecuteNonQuery();
                        conn1.Close();
                    }


                    //SqlConnection conn = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Integrated Security=True");
                    SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Till_Restuarant_Softwear.Properties.Settings.Setting"].ToString());
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("Select * From Dine_In Where InvoiceNo='" + jinvoiceno.Text + "'", conn);
                    SqlDataReader dr;
                    dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        String tableNo = dr["TableNo"].ToString();
                        String waiterName = dr["WaiterName"].ToString();
                //
                //Table Status Update When Order Sent
                //
                        try
                        {
                            //SqlConnection conn1 = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Integrated Security=True");
                            SqlConnection conn1 = new SqlConnection(ConfigurationManager.ConnectionStrings["Till_Restuarant_Softwear.Properties.Settings.Setting"].ToString());
                            conn1.Open();
                            SqlCommand cmd1 = new SqlCommand("UPDATE Table_Manage SET Status='" + "Free" + "'WHERE TableNo='" + tableNo + "'", conn1);
                            cmd1.ExecuteNonQuery();
                            conn1.Close();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.ToString());
                        }

                //
                //Waiter Status Update When Order Sent
                //
                        try
                        {
                            //SqlConnection conn1 = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Integrated Security=True");
                            SqlConnection conn1 = new SqlConnection(ConfigurationManager.ConnectionStrings["Till_Restuarant_Softwear.Properties.Settings.Setting"].ToString());
                            conn1.Open();
                            SqlCommand cmd1 = new SqlCommand("UPDATE Waiter SET Status='" + "Free" + "'WHERE Name='" + waiterName + "'", conn1);
                            cmd1.ExecuteNonQuery();
                            conn1.Close();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.ToString());
                        }
                       
                    }
                    printPreviewDialog1.Document = printDocument1;
                    printPreviewDialog1.ShowDialog();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }

                jinvoiceno.Text = "Invoice";
                jtable1.Text = "";
                jwaiter1.Text = "";
                jitems.Text = "00";
                jtotalamount.Text = "00";
                jcustomerid.Text = "";

                dataGridView1.Rows.Clear();
                dataGridView4.Rows.Clear();
            }
        }
        //
        //Sale Invoice Design
        //
        public String Servicetax1;
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            try
            {
                //SqlConnection conn = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Integrated Security=True");
                SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Till_Restuarant_Softwear.Properties.Settings.Setting"].ToString());
                conn.Open();
                SqlCommand cmd = new SqlCommand("Select * From Resturent_Information", conn);
                SqlDataReader dr;
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    e.Graphics.DrawString(dr["ResturentName"].ToString(), new Font("Arial", 25, FontStyle.Bold), Brushes.Red, new Point(60, 20));
                    e.Graphics.DrawString("Email:" + dr["Mail"].ToString(), new Font("Arial", 17, FontStyle.Regular), Brushes.Black, new Point(60, 80));
                    e.Graphics.DrawString("Phone:" + dr["ContactNo"].ToString(), new Font("Arial", 17, FontStyle.Regular), Brushes.Black, new Point(60, 130));
                    e.Graphics.DrawString("Address:" + dr["Address"].ToString(), new Font("Arial", 17, FontStyle.Regular), Brushes.Black, new Point(60, 170));
                }
                /*e.Graphics.DrawString("Resturent Management System", new Font("Arial", 25, FontStyle.Bold), Brushes.Red, new Point(60, 20));
                e.Graphics.DrawString("Email: janujakhar2370@gmail.com", new Font("Arial", 17, FontStyle.Regular), Brushes.Black, new Point(60, 80));
                e.Graphics.DrawString("Phone: 03000000000000,30000000000", new Font("Arial", 17, FontStyle.Regular), Brushes.Black, new Point(60, 130));
                e.Graphics.DrawString("Address: City Thana,ward#5,Multan road,Layyah", new Font("Arial", 17, FontStyle.Regular), Brushes.Black, new Point(60, 170));
                */
                e.Graphics.DrawString("Invoice #:"+jinvoiceno.Text, new Font("Arial", 17, FontStyle.Bold), Brushes.Black, new Point(580, 80));
                e.Graphics.DrawString("Date:" + DateTime.Now.ToString("dd/MM/yyyy"), new Font("Arial", 17, FontStyle.Regular), Brushes.Black, new Point(590, 130));
                e.Graphics.DrawString("__________________________________________", new Font("Arial", 20, FontStyle.Bold), Brushes.Gray, new Point(55, 195));
                e.Graphics.DrawString("Items", new Font("Arial", 15, FontStyle.Regular), Brushes.Red, new Point(55, 230));
                e.Graphics.DrawString("Product Name", new Font("Arial", 15, FontStyle.Regular), Brushes.Red, new Point(130, 230));
                e.Graphics.DrawString("Qty", new Font("Arial", 15, FontStyle.Regular), Brushes.Red, new Point(440, 230));
                e.Graphics.DrawString("Rate", new Font("Arial", 15, FontStyle.Regular), Brushes.Red, new Point(540, 230));
                e.Graphics.DrawString("Total Price", new Font("Arial", 15, FontStyle.Regular), Brushes.Red, new Point(625, 230));

                int items = dataGridView1.Rows.Count;
                int y_axis = 280;
                int x_axis = 55;
                for (int i = 0; i < items; i++)
                {
                    //Values Fetch From DataGridView
                    String Column_TotalPrice = dataGridView1.Rows[i].Cells[3].Value.ToString();
                    String Column_Product = dataGridView1.Rows[i].Cells[0].Value.ToString();
                    String Column_Quantity = dataGridView1.Rows[i].Cells[2].Value.ToString();
                    String Column_Price = dataGridView1.Rows[i].Cells[1].Value.ToString();

                    //Values Set Into Document For Invoice
                    e.Graphics.DrawString(i.ToString(), new Font("Arial", 13, FontStyle.Regular), Brushes.Black, new Point(x_axis, y_axis));
                    e.Graphics.DrawString(Column_Product, new Font("Arial", 13, FontStyle.Regular), Brushes.Black, new Point(140, y_axis));
                    e.Graphics.DrawString(Column_Quantity, new Font("Arial", 13, FontStyle.Regular), Brushes.Black, new Point(445, y_axis));
                    e.Graphics.DrawString(Column_Price, new Font("Arial", 13, FontStyle.Regular), Brushes.Black, new Point(550, y_axis));
                    e.Graphics.DrawString(Column_TotalPrice, new Font("Arial", 13, FontStyle.Regular), Brushes.Black, new Point(640, y_axis));
                    y_axis += 45;
                }
                //Calculating y-axis after all items.
                int y = y_axis - 10;
                int l = 10 + y_axis;
                int m = l + 38;
                int n = m + 38;
                int o = n + 38;
                //after items totalprice,items and mesage

                e.Graphics.DrawString("__________________________________________", new Font("Arial", 20, FontStyle.Bold), Brushes.Gray, new Point(55, y));
                e.Graphics.DrawString("Items :" + jitems.Text, new Font("Arial", 20, FontStyle.Regular), Brushes.Black, new Point(40, m));

                Double subTotal = 0;
                for(int i=0;i<items;i++)
                {
                    String Column_TotalPrice = dataGridView1.Rows[i].Cells[3].Value.ToString();
                    Double Column_Total = Convert.ToDouble(Column_TotalPrice);
                    subTotal += Column_Total;
                    
                }
                e.Graphics.DrawString("Sub Total:" + subTotal.ToString(), new Font("Arial", 20, FontStyle.Regular), Brushes.Black, new Point(440, m));


                Double tax=0;
                //SqlConnection conn = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Integrated Security=True");
                SqlConnection conn3 = new SqlConnection(ConfigurationManager.ConnectionStrings["Till_Restuarant_Softwear.Properties.Settings.Setting"].ToString());
                conn3.Open();
                SqlCommand cmd3 = new SqlCommand("Select * From Tax", conn3);
                SqlDataReader dr3;
                dr3 = cmd3.ExecuteReader();
                if (dr3.Read())
                {
                    String type = dr3["Type"].ToString();
                   // MessageBox.Show(type);
                    if (type == "Per Item")
                    {
                        Double items1 = Convert.ToDouble(jitems.Text);

                        String Servicetax = dr3["ServiceTax"].ToString();
                        Double TaxD = Convert.ToDouble(Servicetax);

                        Double tax1 = TaxD * items1;
                        tax = tax1;
                    }
                    else
                    if(type == "Persentage of Sub-Total")
                    {
                        Double subTotal1 = Convert.ToDouble(jtotalamount.Text);
                        Double persentage = Convert.ToDouble(dr3["ServiceTax"].ToString());
                        Double subTotal2 = subTotal1/100.0;
                        Double subTotal3=subTotal2 * persentage;
                        tax = subTotal3;
                    }
                    else
                    {
                        String Servicetax = dr3["ServiceTax"].ToString();
                        tax = Convert.ToDouble(Servicetax);
                    }
                    
                }
                e.Graphics.DrawString("    VAT: " + tax.ToString(), new Font("Arial", 20, FontStyle.Regular), Brushes.Black, new Point(440, n));

                Double totalAmount = Convert.ToDouble(jtotalamount.Text);
                Double serviceTax = Convert.ToDouble(tax);
                Double Total = serviceTax + totalAmount;
                e.Graphics.DrawString("Total Amount: "+Total.ToString(), new Font("Arial", 20, FontStyle.Regular), Brushes.Black, new Point(440, o));
                e.Graphics.DrawString("Thanks For Visting Here", new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(280, o + 40));

                e.Graphics.DrawString("Advance Era Tech", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(340, o+85));

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
//
//K.D.T Kitchen Management System
//
        private void JK_D_T_BUTTON_Click(object sender, EventArgs e)
        {
            Kitchen_Management_System_Control set = new Kitchen_Management_System_Control(this);
            set.Show();
            set.BringToFront();
        }
        //
        //Order Btn
        //
        String InvoiceNo1;
        private void JORDER_BTN_Click(object sender, EventArgs e)
        {
            if (jstatus1.Text=="")
            {
                MessageBox.Show("Please Select Type Of Order\n\n Like Take_Away/Dine_In/Delivery");
            }
//TakeAway
            else
            if(jinvoiceno.Text=="Invoice")
            {
                if (jstatus1.Text == "Take-away")
                {
                    DialogResult dialog = MessageBox.Show("Please First Pay Cash  Then  your order Send to Kitchen", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dialog == DialogResult.Yes)
                    {
                        String date = DateTime.Now.ToString("dd/MM/yyyy");
                        String InvoiceNO = DateTime.Now.ToString("dMyyhms");
                        InvoiceNo1 = InvoiceNO;
                        try
                        {
                            int items = dataGridView1.Rows.Count;
                            int i = 0;
                            while (i < items)
                            {
                                //get data from dataGridView
                                String OrderNo = DateTime.Now.ToString("dMyyhms");
                                String Column_ProductName = dataGridView1.Rows[i].Cells[0].Value.ToString();
                                String Column_UnitPrice = dataGridView1.Rows[i].Cells[1].Value.ToString();
                                String Column_Quantity = dataGridView1.Rows[i].Cells[2].Value.ToString();
                                String Column_TotalPrice = dataGridView1.Rows[i].Cells[3].Value.ToString();

                                //Add Data Into Menu_Order
                                // SqlConnection conn = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Integrated Security=True");
                                SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Till_Restuarant_Softwear.Properties.Settings.Setting"].ToString());
                                conn.Open();
                                SqlCommand cmd = new SqlCommand("insert into Menu_Order Values(@a,@b,@c,@d,@f)", conn);
                                cmd.Parameters.AddWithValue("@a", OrderNo + i.ToString());
                                cmd.Parameters.AddWithValue("@b", InvoiceNO);
                                cmd.Parameters.AddWithValue("@c", Column_ProductName);
                                cmd.Parameters.AddWithValue("@d", Column_Quantity);
                                cmd.Parameters.AddWithValue("@f", "New Order");
                                cmd.ExecuteNonQuery();
                                conn.Close();

                                //Take Away Data Insert Into Take_Away Table
                                try
                                {
                                    //SqlConnection conn1 = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Integrated Security=True");
                                    SqlConnection conn1 = new SqlConnection(ConfigurationManager.ConnectionStrings["Till_Restuarant_Softwear.Properties.Settings.Setting"].ToString());
                                    conn1.Open();
                                    SqlCommand cmd1 = new SqlCommand("insert into Take_Away Values(@a,@b,@c,@d,@e,@f,@g,@h)", conn1);
                                    cmd1.Parameters.AddWithValue("@a", OrderNo + i.ToString());
                                    cmd1.Parameters.AddWithValue("@b", InvoiceNO);
                                    cmd1.Parameters.AddWithValue("@c", Column_ProductName);
                                    cmd1.Parameters.AddWithValue("@d", Column_Quantity);
                                    cmd1.Parameters.AddWithValue("@e", Column_UnitPrice);
                                    cmd1.Parameters.AddWithValue("@f", Column_TotalPrice);
                                    cmd1.Parameters.AddWithValue("@g", "Pending");
                                    cmd1.Parameters.AddWithValue("@h", date);
                                    cmd1.ExecuteNonQuery();
                                    conn1.Close();
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show(ex.ToString());
                                }
                                i++;

                            }

                            MessageBox.Show("Sent Order to Kitchen\n\nInvoice #:");

                            jinvoiceno.Text = InvoiceNo1;
                            printPreviewDialog1.Document = printDocument1;
                            printPreviewDialog1.ShowDialog();
                            jinvoiceno.Text = "Invoice";
                            

                            dataGridView1.Rows.Clear();
                            dataGridView4.Rows.Clear();

                            jitems.Text = "00";
                            jtotalamount.Text = "00";

                            if (jwaiterlogin.Text != "")
                            {
                                this.Hide();

                                Login_Page set11 = new Login_Page();
                                set11.Show();
                                set11.BringToFront();
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.ToString(), "Exception Error");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Your Order Not Sent To Kitchen");
                    }
                }
        //
        //DIne_In Order
        //
                else if (jstatus1.Text == "Dine-In")
                {
                    
                    if (jtable1.Text == "" || jwaiter1.Text == "")
                    {
                        MessageBox.Show("Please Select Both Table and Waiter");
                    }
                    else
                    if(label12.Text!= "Today Sale" && label12.Text!="User Login")
                    {
                        String date1 = DateTime.Now.ToString("dd/MM/yyyy");
                       // String InvoiceNO = DateTime.Now.ToString("dMyyhms");
                     //   InvoiceNo1 = InvoiceNO;

                       
                            int items = dataGridView1.Rows.Count;
                            int i = 0;
                            while (i < items)
                            {
                                //
                                String OrderNo = DateTime.Now.ToString("dMyyhms");
                                String Column_ProductName = dataGridView1.Rows[i].Cells[0].Value.ToString();
                                String Column_UnitPrice = dataGridView1.Rows[i].Cells[1].Value.ToString();
                                String Column_Quantity = dataGridView1.Rows[i].Cells[2].Value.ToString();
                                String Column_TotalPrice = dataGridView1.Rows[i].Cells[3].Value.ToString();

                                //Data Insert Into Menu_Order
                                //SqlConnection conn = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Integrated Security=True");
                                SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Till_Restuarant_Softwear.Properties.Settings.Setting"].ToString());
                                conn.Open();
                                SqlCommand cmd = new SqlCommand("insert into Menu_Order Values(@a,@b,@c,@d,@f)", conn);
                                cmd.Parameters.AddWithValue("@a", OrderNo + i.ToString());
                                cmd.Parameters.AddWithValue("@b", label12.Text);
                                cmd.Parameters.AddWithValue("@c", Column_ProductName);
                                cmd.Parameters.AddWithValue("@d", Column_Quantity);
                                cmd.Parameters.AddWithValue("@f", "New Order");
                                cmd.ExecuteNonQuery();
                                conn.Close();

                                //Order By Dine_In Insert Into Dine_In Table
                                try
                                {
                                    //SqlConnection conn1 = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Integrated Security=True");
                                    SqlConnection conn1 = new SqlConnection(ConfigurationManager.ConnectionStrings["Till_Restuarant_Softwear.Properties.Settings.Setting"].ToString());
                                    conn1.Open();
                                    SqlCommand cmd1 = new SqlCommand("insert into Dine_In Values(@a,@b,@c,@d,@e,@f,@g,@h,@i,@j)", conn1);
                                    cmd1.Parameters.AddWithValue("@a", OrderNo + i.ToString());
                                    cmd1.Parameters.AddWithValue("@b", label12.Text);
                                    cmd1.Parameters.AddWithValue("@c", Column_ProductName);
                                    cmd1.Parameters.AddWithValue("@d", Column_Quantity);
                                    cmd1.Parameters.AddWithValue("@e", Column_UnitPrice);
                                    cmd1.Parameters.AddWithValue("@f", Column_TotalPrice);
                                    cmd1.Parameters.AddWithValue("@g", jtable1.Text);
                                    cmd1.Parameters.AddWithValue("@h", jwaiter1.Text.ToString());
                                    cmd1.Parameters.AddWithValue("@i", "Pending");
                                    cmd1.Parameters.AddWithValue("@j", date1);
                                    cmd1.ExecuteNonQuery();
                                    conn1.Close();
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show(ex.ToString());
                                }
                                i++;

                            }
                            MessageBox.Show("Sent Order to Kitchen\n\nInvoice #:");
                            dataGridView1.Rows.Clear();
                            //  dataGridView3.Rows.Clear();
                            dataGridView4.Rows.Clear();

                            jitems.Text = "00";
                            jtotalamount.Text = "00";
                            jtable1.Text = "";
                            jwaiter1.Text = "";
                            label12.Text = "Today Sale";

                            if(jwaiterlogin.Text!="")
                            {
                                this.Hide();
                                Login_Page set11 = new Login_Page();
                                set11.Show();
                                set11.BringToFront();
                            }
                            
                    }
                    else
                    {

                        String date = DateTime.Now.ToString("dd/MM/yyyy");
                        String InvoiceNO = DateTime.Now.ToString("dMyyhms");
                        InvoiceNo1 = InvoiceNO;

                        try
                        {
                            int items = dataGridView1.Rows.Count;
                            int i = 0;
                            while (i < items)
                            {
                                //
                                String OrderNo = DateTime.Now.ToString("dMyyhms");

                                String Column_ProductName = dataGridView1.Rows[i].Cells[0].Value.ToString();
                                String Column_UnitPrice = dataGridView1.Rows[i].Cells[1].Value.ToString();
                                String Column_Quantity = dataGridView1.Rows[i].Cells[2].Value.ToString();
                                String Column_TotalPrice = dataGridView1.Rows[i].Cells[3].Value.ToString();

                                //Data Insert Into Menu_Order
                                //SqlConnection conn = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Integrated Security=True");
                                SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Till_Restuarant_Softwear.Properties.Settings.Setting"].ToString());
                                conn.Open();
                                SqlCommand cmd = new SqlCommand("insert into Menu_Order Values(@a,@b,@c,@d,@f)", conn);
                                cmd.Parameters.AddWithValue("@a", OrderNo + i.ToString());
                                cmd.Parameters.AddWithValue("@b", InvoiceNO);
                                cmd.Parameters.AddWithValue("@c", Column_ProductName);
                                cmd.Parameters.AddWithValue("@d", Column_Quantity);
                                cmd.Parameters.AddWithValue("@f", "New Order");
                                cmd.ExecuteNonQuery();
                                conn.Close();

                                //Order By Dine_In Insert Into Dine_In Table
                                try
                                {
                                    //SqlConnection conn1 = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Integrated Security=True");
                                    SqlConnection conn1 = new SqlConnection(ConfigurationManager.ConnectionStrings["Till_Restuarant_Softwear.Properties.Settings.Setting"].ToString());
                                    conn1.Open();
                                    SqlCommand cmd1 = new SqlCommand("insert into Dine_In Values(@a,@b,@c,@d,@e,@f,@g,@h,@i,@j)", conn1);
                                    cmd1.Parameters.AddWithValue("@a", OrderNo + i.ToString());
                                    cmd1.Parameters.AddWithValue("@b", InvoiceNO);
                                    cmd1.Parameters.AddWithValue("@c", Column_ProductName);
                                    cmd1.Parameters.AddWithValue("@d", Column_Quantity);
                                    cmd1.Parameters.AddWithValue("@e", Column_UnitPrice);
                                    cmd1.Parameters.AddWithValue("@f", Column_TotalPrice);
                                    cmd1.Parameters.AddWithValue("@g", jtable1.Text);
                                    cmd1.Parameters.AddWithValue("@h", jwaiter1.Text.ToString());
                                    cmd1.Parameters.AddWithValue("@i", "Pending");
                                    cmd1.Parameters.AddWithValue("@j", date);
                                    cmd1.ExecuteNonQuery();
                                    conn1.Close();
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show(ex.ToString());
                                }
                           //
                           //Table Status Update When Order Sent
                           //
                                try
                                {
                                    //SqlConnection conn1 = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Integrated Security=True");
                                    SqlConnection conn1 = new SqlConnection(ConfigurationManager.ConnectionStrings["Till_Restuarant_Softwear.Properties.Settings.Setting"].ToString());
                                    conn1.Open();
                                    SqlCommand cmd1 = new SqlCommand("UPDATE Table_Manage SET Status='" + "Reserved" + "'WHERE TableNo='" + jtable1.Text + "'", conn1);
                                    cmd1.ExecuteNonQuery();
                                    conn1.Close();
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show(ex.ToString());
                                }

                        //
                        //Waiter Status Update When Order Sent
                        //
                                try
                                {
                                    //SqlConnection conn1 = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Integrated Security=True");
                                    SqlConnection conn1 = new SqlConnection(ConfigurationManager.ConnectionStrings["Till_Restuarant_Softwear.Properties.Settings.Setting"].ToString());
                                    conn1.Open();
                                    SqlCommand cmd1 = new SqlCommand("UPDATE Waiter SET Status='" + "Busy" + "'WHERE Name='" + jwaiter1.Text + "'", conn1);
                                    cmd1.ExecuteNonQuery();
                                    conn1.Close();
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show(ex.ToString());
                                }
                                i++;

                            }
                            MessageBox.Show("Sent Order to Kitchen\n\nInvoice #:");

                            DialogResult dialog = MessageBox.Show("Do You Want To Create Invoice?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                            if (dialog == DialogResult.Yes)
                            {
                                jinvoiceno.Text = InvoiceNo1;
                                printPreviewDialog1.Document = printDocument1;
                                printPreviewDialog1.ShowDialog();
                                jinvoiceno.Text = "Invoice";
                            }

                            dataGridView1.Rows.Clear();
                            //  dataGridView3.Rows.Clear();
                            dataGridView4.Rows.Clear();

                            jitems.Text = "00";
                            jtotalamount.Text = "00";
                            jtable1.Text = "";
                            jwaiter1.Text = "";

                            if (jwaiterlogin.Text != "")
                            {
                                this.Hide();
                                Login_Page set11 = new Login_Page();
                                set11.Show();
                                set11.BringToFront();
                            }

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.ToString(), "Exception Error");
                        }
                    }
                }
//
//Delivery Order
//
                else if (jstatus1.Text == "Delivery")
                {
                    if (jcustomerid.Text == "")
                    {
                        MessageBox.Show("Please Select Customer");

                        Delivery_Customer set = new Delivery_Customer();
                        set.Show();
                        set.BringToFront();
                    }
                    else
                    {
                        String date = DateTime.Now.ToString("dd/MM/yyyy");
                        String InvoiceNO = DateTime.Now.ToString("dMyyhms");
                        InvoiceNo1 = InvoiceNO;
                        try
                        {
                            int items = dataGridView1.Rows.Count;
                            int i = 0;
                            while (i < items)
                            {
                                //data Select From DataGridView
                                String OrderNo = DateTime.Now.ToString("dMyyhms");
                                String Column_ProductName = dataGridView1.Rows[i].Cells[0].Value.ToString();
                                String Column_UnitPrice = dataGridView1.Rows[i].Cells[1].Value.ToString();
                                String Column_Quantity = dataGridView1.Rows[i].Cells[2].Value.ToString();
                                String Column_TotalPrice = dataGridView1.Rows[i].Cells[3].Value.ToString();


                                //
                                //Insert Order Into Menu_Order
                                //
                                //SqlConnection conn = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Integrated Security=True");
                                SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Till_Restuarant_Softwear.Properties.Settings.Setting"].ToString());
                                conn.Open();
                                SqlCommand cmd = new SqlCommand("insert into Menu_Order Values(@a,@b,@c,@d,@f)", conn);
                                cmd.Parameters.AddWithValue("@a", OrderNo + i.ToString());
                                cmd.Parameters.AddWithValue("@b", InvoiceNO);
                                cmd.Parameters.AddWithValue("@c", Column_ProductName);
                                cmd.Parameters.AddWithValue("@d", Column_Quantity);
                                cmd.Parameters.AddWithValue("@f", "New Order");
                                cmd.ExecuteNonQuery();
                                conn.Close();


                                //
                                //Insert data Into Delivery
                                //
                                try
                                {
                                    // SqlConnection conn1 = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Integrated Security=True");
                                    SqlConnection conn1 = new SqlConnection(ConfigurationManager.ConnectionStrings["Till_Restuarant_Softwear.Properties.Settings.Setting"].ToString());
                                    conn1.Open();
                                    SqlCommand cmd1 = new SqlCommand("insert into Delivery Values(@a,@b,@c,@d,@e,@f,@g,@h,@i,@j,@k,@l)", conn1);
                                    cmd1.Parameters.AddWithValue("@a", OrderNo + i.ToString());
                                    cmd1.Parameters.AddWithValue("@b", InvoiceNO);
                                    cmd1.Parameters.AddWithValue("@c", Column_ProductName);
                                    cmd1.Parameters.AddWithValue("@d", Column_Quantity);
                                    cmd1.Parameters.AddWithValue("@e", Column_UnitPrice);
                                    cmd1.Parameters.AddWithValue("@f", Column_TotalPrice);
                                    cmd1.Parameters.AddWithValue("@g", "Pending");
                                    cmd1.Parameters.AddWithValue("@h", "None");
                                    cmd1.Parameters.AddWithValue("@i", date);
                                    cmd1.Parameters.AddWithValue("@j", DateTime.Now.ToString("hh:mm:ss"));
                                    cmd1.Parameters.AddWithValue("@k", "Pending");
                                    cmd1.Parameters.AddWithValue("@l", jcustomerid.Text);
                                    cmd1.ExecuteNonQuery();
                                    conn1.Close();
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show(ex.ToString());
                                }
                                i++;

                            }
                            MessageBox.Show("Sent Order to Kitchen\n\nInvoice #:");

                            DialogResult dialog = MessageBox.Show("Do You Want To Create Invoice?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                            if (dialog == DialogResult.Yes)
                            {
                                jinvoiceno.Text = InvoiceNo1;
                                printPreviewDialog1.Document = printDocument1;
                                printPreviewDialog1.ShowDialog();
                                jinvoiceno.Text = "Invoice";
                            }

                            dataGridView1.Rows.Clear();
                            // dataGridView3.Rows.Clear();
                            dataGridView4.Rows.Clear();

                            jitems.Text = "00";
                            jtotalamount.Text = "00";
                            if(jwaiterlogin.Text!="Waiter")
                            {
                                this.Hide();
                                Login_Page set11 = new Login_Page();
                                set11.Show();
                                set11.BringToFront();
                            }

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.ToString(), "Exception Error");
                        }
                    }
                }
                
            }
            else
            {
                MessageBox.Show("Fast Cash\n\nOrder Completed Of Invoice #:");
            }
        }

        private void JNEW_BUTTON_Click(object sender, EventArgs e)
        {
            jinvoiceno.Text = "Invoice";
            jtable1.Text = "";
            jwaiter1.Text = "";
            jitems.Text = "00";
            jtotalamount.Text = "00";
            jcustomerid.Text = "";
            label12.Text = "Today Sale";

            dataGridView1.Rows.Clear();
            dataGridView4.Rows.Clear();
        }

        private void jbarcode_TextChanged(object sender, EventArgs e)
        {
            if (jbarcode.Text != "")
            {
                try
                {
                    int x = 10, y = 20;
                    //Hiden search product label k nichy
                    //SqlConnection conn = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Integrated Security=True");
                    SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Till_Restuarant_Softwear.Properties.Settings.Setting"].ToString());
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("Select * From Item_Menu Where MRP='" + jbarcode.Text + "'", conn);
                    SqlDataReader dr;
                    dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        String category = dr["Category"].ToString();
                        jselecteditems.Text = category;
                        String menu = dr["Name"].ToString();

                       // jsearchitem.Text = category;
                        jsearchproduct.Text = menu;

                        SqlConnection conn1 = new SqlConnection(ConfigurationManager.ConnectionStrings["Till_Restuarant_Softwear.Properties.Settings.Setting"].ToString());
                        //SqlConnection conn1 = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Integrated Security=True");
                        conn1.Open();
                        SqlCommand cmd1 = new SqlCommand("Select * From Item_Menu Where Name='" + menu + "'", conn1);
                        SqlDataReader dr1;
                        dr1 = cmd1.ExecuteReader();

                        panel2.Controls.Add(panel7);
                        panel7.Show();
                        panel7.BringToFront();

                        while (dr1.Read())
                        {
                            jquantity.Text = "1";
                            jproductname1.Text = menu;
                            String getPrice = dr1["Price"].ToString();
                            Double price = Convert.ToDouble(getPrice);
                            Double total = Convert.ToDouble(jquantity.Text) * price;
                            jprice.Text = getPrice;
                            jtotalprice.Text = price.ToString();
                        }

                    }
                    else
                    {
                        jsearchitem.Text = "";
                        jsearchproduct.Text = "";

                        panel7.Hide();
                    }
                        
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "Error");
                }
            }
            else
            {
                jsearchitem.Text = "";
                jsearchproduct.Text = "";

                panel7.Hide();
            }




        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
