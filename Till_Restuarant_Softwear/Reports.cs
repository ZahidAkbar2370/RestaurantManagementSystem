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
    public partial class Reports : Form
    {
        public Reports()
        {
            InitializeComponent();
            View();
            panel2.Hide();
        }
        //
        //Employee Set Into Select Employee Combo
        //
        public void View()
        {
            jmonth.Text = DateTime.Now.ToString("MM/yyyy");
            try
            {
                SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Till_Restuarant_Softwear.Properties.Settings.Setting"].ToString());
                //SqlConnection conn = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Integrated Security=True");
                conn.Open();
                SqlDataAdapter sqlDA = new SqlDataAdapter("Select * From Employee", conn);
                DataTable dt = new DataTable();
                sqlDA.Fill(dt);
                comboBox1.DataSource = dt;
                comboBox1.DisplayMember = "Name";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            try
            {
                SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Till_Restuarant_Softwear.Properties.Settings.Setting"].ToString());
                //SqlConnection conn = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Integrated Security=True");
                conn.Open();
                SqlDataAdapter sqlDA = new SqlDataAdapter("Select * From Item_Menu", conn);
                DataTable dt = new DataTable();
                sqlDA.Fill(dt);
                jselectmenu.DataSource = dt;
                jselectmenu.DisplayMember = "Name";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        //
        //Today Sale Invoice
        //
        private void JTODAYSALE_BTN_Click(object sender, EventArgs e)
        {
//
//Today Sale By DineIn
 //
            DialogResult dialog = MessageBox.Show("Do You Want To Make Today Sale Invoice?", "Confirm Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                try
                {
                    //SqlConnection conn = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Integrated Security=True");
                    SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Till_Restuarant_Softwear.Properties.Settings.Setting"].ToString());
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("Select * From Dine_In Where Date='" + jtodaydate.Text + "'", conn);
                    SqlDataReader dr;
                    dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        Double getAmount = Convert.ToDouble(dr["TotalPrice"].ToString());
                        Double price = Convert.ToDouble(jprice.Text);
                        Double total = getAmount + price;
                        String t1 = Convert.ToString(total);
                        jprice.Text = t1;
                        conn.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }

//
//Today Sale By TakeAway
//
                try
                {
                    // SqlConnection conn = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Integrated Security=True");
                    SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Till_Restuarant_Softwear.Properties.Settings.Setting"].ToString());
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("Select * From Take_Away Where Date='" + jtodaydate.Text + "'", conn);
                    SqlDataReader dr;
                    dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        Double getAmount = Convert.ToDouble(dr["TotalPrice"].ToString());
                        Double price = Convert.ToDouble(jtakeawayprice.Text);
                        Double total = getAmount + price;
                        String t1 = Convert.ToString(total);
                        jtakeawayprice.Text = t1;
                        conn.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }

//
//Today Sale By Delivery
//
                try
                {
                    //SqlConnection conn = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Integrated Security=True");
                    SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Till_Restuarant_Softwear.Properties.Settings.Setting"].ToString());
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("Select * From Delivery Where Date='" + jtodaydate.Text + "'", conn);
                    SqlDataReader dr;
                    dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        Double getAmount = Convert.ToDouble(dr["TotalPrice"].ToString());
                        Double price = Convert.ToDouble(jdeliveryprice.Text);
                        Double total = getAmount + price;
                        String t1 = Convert.ToString(total);
                        jdeliveryprice.Text = t1;
                        conn.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }

                //
                //Today Total Sale
                //

                int Sale_By_Dine_In = Convert.ToInt32(jprice.Text);
                int Sale_By_Take_Away = Convert.ToInt32(jtakeawayprice.Text);
                int Sale_By_Delivery = Convert.ToInt32(jdeliveryprice.Text);
                int total_Sale = Sale_By_Take_Away + Sale_By_Dine_In + Sale_By_Delivery;
                jtotaltotaysale.Text = total_Sale.ToString();

                printPreviewDialog1.Document = Today_Sale_Invoice;
                printPreviewDialog1.ShowDialog();



                /* try
                 {

                     //SqlConnection conn = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|Database1.mdf;Integrated Security=True;User Instance=True");
                     //SqlConnection conn = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Nouman\Music\10\Resturent_Management_System_Project\Resturent_Management_System_Project\Database1.mdf;Integrated Security=True;User Instance=True");
                     SqlConnection conn = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Integrated Security=True");
                     conn.Open();
                     SqlCommand cmd = new SqlCommand("Select * From AllSale Where Date='" + jtodaydate.Text + "'", conn);
                     SqlDataReader dr;
                     dr = cmd.ExecuteReader();
                     while (dr.Read())
                     {
                         Double getAmount = Convert.ToDouble(dr["Amount"].ToString());
                         Double price = Convert.ToDouble(jtotaltotaysale.Text);
                         Double total = getAmount + price;
                         String t1 = Convert.ToString(total);
                         jtotaltotaysale.Text = t1;

                     }
                     printPreviewDialog1.Document = Today_Sale_Invoice;
                     printPreviewDialog1.ShowDialog();
                 }
                 catch (Exception ex)
                 {
                     MessageBox.Show(ex.ToString());
                 }*/
            }
        }
//
//Today Sale Invoice Design
//
        private void Today_Sale_Invoice_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
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
                    //e.Graphics.DrawString("TIMBER GARDENS RESTURANT", new Font("Arial", 20, FontStyle.Bold), Brushes.Red, new Point(75, 50));
                    e.Graphics.DrawString(dr["ResturentName"].ToString(), new Font("Arial", 20, FontStyle.Bold), Brushes.Red, new Point(75, 50));
                    e.Graphics.DrawString("Today Sale Report", new Font("Arial", 20, FontStyle.Regular), Brushes.Black, new Point(75, 90));
                    e.Graphics.DrawString("Date :" + DateTime.Now.ToString("dd/MM/yyyy"), new Font("Arial", 17, FontStyle.Regular), Brushes.Black, new Point(75, 130));
                    e.Graphics.DrawString("Invoice #: ", new Font("Arial", 17, FontStyle.Bold), Brushes.Black, new Point(550, 90));
                    e.Graphics.DrawString("____________________________________-", new Font("Arial", 20, FontStyle.Regular), Brushes.Black, new Point(75, 160));
                    e.Graphics.DrawString("Dine-In Sale:      " + jprice.Text + "\n\nTake-Away Sale: " + jtakeawayprice.Text + "\n\nDelivery Sale:    " + jdeliveryprice.Text, new Font("Arial", 15, FontStyle.Bold), Brushes.Black, new Point(85, 215));
                    e.Graphics.DrawString("Total Today Sale :" + jtotaltotaysale.Text, new Font("Arial", 20, FontStyle.Bold), Brushes.Red, new Point(310, 380));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
//
//Purchase Invoice Design
//
        private void Purchase_Invoice_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Till_Restuarant_Softwear.Properties.Settings.Setting"].ToString());
                conn.Open();
                SqlCommand cmd = new SqlCommand("Select * From Resturent_Information", conn);
                SqlDataReader dr;
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    e.Graphics.DrawString(dr["ResturentName"].ToString(), new Font("Arial", 25, FontStyle.Bold), Brushes.Red, new Point(60, 20));
                    e.Graphics.DrawString("Email:"+ dr["Mail"].ToString(), new Font("Arial", 17, FontStyle.Regular), Brushes.Black, new Point(60, 80));
                    e.Graphics.DrawString("Phone:"+dr["ContactNo"].ToString(), new Font("Arial", 17, FontStyle.Regular), Brushes.Black, new Point(60, 130));
                    e.Graphics.DrawString("Address:"+ dr["Address"].ToString(), new Font("Arial", 17, FontStyle.Regular), Brushes.Black, new Point(60, 170));
                }
                e.Graphics.DrawString("Invoice #:"+DateTime.Now.ToString("dMyyhms"), new Font("Arial", 17, FontStyle.Bold), Brushes.Black, new Point(590, 80));
                e.Graphics.DrawString("Date:" + DateTime.Now.ToString("dd/MM/yyyy"), new Font("Arial", 17, FontStyle.Regular), Brushes.Black, new Point(590, 130));
                e.Graphics.DrawString("__________________________________________", new Font("Arial", 20, FontStyle.Bold), Brushes.Gray, new Point(55, 195));
                e.Graphics.DrawString("Items", new Font("Arial", 15, FontStyle.Regular), Brushes.Red, new Point(55, 230));
                e.Graphics.DrawString("Product Name", new Font("Arial", 15, FontStyle.Regular), Brushes.Red, new Point(130, 230));
                e.Graphics.DrawString("Qty", new Font("Arial", 15, FontStyle.Regular), Brushes.Red, new Point(420, 230));
                e.Graphics.DrawString("TotalPrice", new Font("Arial", 15, FontStyle.Regular), Brushes.Red, new Point(530, 230));
                e.Graphics.DrawString("Purchase Date", new Font("Arial", 15, FontStyle.Regular), Brushes.Red, new Point(625, 230));

                //Values Fetch and set into Invoice
                int items = dataGridView1.Rows.Count;
                int y_axis = 280;
                int x_axis = 55;
                for (int i = 0; i < items - 1; i++)
                {
                    //Values Fetch From DataGridView
                    // String Column_item = dataGridView1.Rows[i].Cells[1].Value.ToString();
                    String Column_Product = dataGridView1.Rows[i].Cells[1].Value.ToString();
                    String Column_TotalPrice = dataGridView1.Rows[i].Cells[7].Value.ToString();
                    String Column_Quantity = dataGridView1.Rows[i].Cells[2].Value.ToString();
                    String Column_Date = dataGridView1.Rows[i].Cells[6].Value.ToString();

                    //Values Set Into Invoice
                    e.Graphics.DrawString(i.ToString(), new Font("Arial", 13, FontStyle.Regular), Brushes.Black, new Point(x_axis, y_axis));
                    e.Graphics.DrawString(Column_Product, new Font("Arial", 13, FontStyle.Regular), Brushes.Black, new Point(140, y_axis));
                    e.Graphics.DrawString(Column_Quantity, new Font("Arial", 13, FontStyle.Regular), Brushes.Black, new Point(425, y_axis));
                    e.Graphics.DrawString(Column_TotalPrice, new Font("Arial", 13, FontStyle.Regular), Brushes.Black, new Point(530, y_axis));
                    e.Graphics.DrawString(Column_Date, new Font("Arial", 13, FontStyle.Regular), Brushes.Black, new Point(640, y_axis));
                    y_axis += 45;
                }

                //Total Price Calculated
                Double totalPrice = 0;
                for (int j = 0; j < items - 1; j++)
                {
                    String Column_TotalPrice1 = dataGridView1.Rows[j].Cells[7].Value.ToString();
                    Double TotalPrice = Convert.ToDouble(Column_TotalPrice1);
                    totalPrice += TotalPrice;
                }
                int l = 30 + y_axis;
                e.Graphics.DrawString("__________________________________________", new Font("Arial", 20, FontStyle.Bold), Brushes.Gray, new Point(55, y_axis));
                e.Graphics.DrawString("\nTotal: " + totalPrice.ToString(), new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(420, l));

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
//
//Purchase Invoice Button
//
        private void JPURCHASE_INVOICE_BTN_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialog = MessageBox.Show("Do You Want To Make Purchase Invoice?", "Confirm Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialog == DialogResult.Yes)
                {
                    try
                    {
                        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Till_Restuarant_Softwear.Properties.Settings.Setting"].ToString());
                        conn.Open();
                        SqlDataAdapter sqlDA = new SqlDataAdapter("Select * From Purchase_Stock Where PurchaseDate Between'" + jfrompurchasedate.Text + "'and'" + jtopurchasedate.Text + "'", conn);
                        DataTable dt = new DataTable();
                        sqlDA.Fill(dt);
                        dataGridView1.DataSource = dt;

                        printPreviewDialog1.Document = Purchase_Invoice;
                        printPreviewDialog1.ShowDialog();
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
//
//Expenses Invoice Button
//
        private void JEXPENSES_BTN_INVOICE_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialog = MessageBox.Show("Do You Want To Make Expenses Invoice?", "Confirm Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialog == DialogResult.Yes)
                {
                    SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Till_Restuarant_Softwear.Properties.Settings.Setting"].ToString());
                    conn.Open();
                    SqlDataAdapter sqlDA = new SqlDataAdapter("Select * From Expenses Where Date Between'" + jexpensesdatefrom.Text + "'and'" + jexpensesdateto.Text + "'", conn);
                    DataTable dt = new DataTable();
                    sqlDA.Fill(dt);
                    dataGridView1.DataSource = dt;

                    printPreviewDialog1.Document = Expenses_Invoice;
                    printPreviewDialog1.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
//
//Expenses Invoice Design
//
        private void Expenses_Invoice_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            try
            {
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
                //header
                /*e.Graphics.DrawString("TIMBER GARDENS RESTURANT", new Font("Arial", 25, FontStyle.Bold), Brushes.Red, new Point(60, 20));
                e.Graphics.DrawString("Email:  Douglasdanso@gmail.com", new Font("Arial", 17, FontStyle.Regular), Brushes.Black, new Point(60, 80));
                e.Graphics.DrawString("Phone: +447897864996", new Font("Arial", 17, FontStyle.Regular), Brushes.Black, new Point(60, 130));
                e.Graphics.DrawString("Address: Croydon, United Kingdom", new Font("Arial", 17, FontStyle.Regular), Brushes.Black, new Point(60, 170));
                */
                e.Graphics.DrawString("Invoice #:", new Font("Arial", 17, FontStyle.Bold), Brushes.Black, new Point(590, 80));
                e.Graphics.DrawString("Date:" + DateTime.Now.ToString("dd/MM/yyyy"), new Font("Arial", 17, FontStyle.Regular), Brushes.Black, new Point(590, 130));
                e.Graphics.DrawString("__________________________________________", new Font("Arial", 20, FontStyle.Bold), Brushes.Gray, new Point(55, 195));
                e.Graphics.DrawString("No", new Font("Arial", 15, FontStyle.Regular), Brushes.Red, new Point(55, 230));
                e.Graphics.DrawString("Discription", new Font("Arial", 15, FontStyle.Regular), Brushes.Red, new Point(130, 230));
                e.Graphics.DrawString("Category", new Font("Arial", 15, FontStyle.Regular), Brushes.Red, new Point(420, 230));
                e.Graphics.DrawString("Amount", new Font("Arial", 15, FontStyle.Regular), Brushes.Red, new Point(535, 230));
                e.Graphics.DrawString("Date", new Font("Arial", 15, FontStyle.Regular), Brushes.Red, new Point(645, 230));

                //Values Fetch and set into Invoice
                int items = dataGridView1.Rows.Count;
                int y_axis = 280;
                int x_axis = 55;
                for (int i = 0; i < items - 1; i++)
                {
                    //Values Fetch From DataGridView
                    String Column_Description = dataGridView1.Rows[i].Cells[1].Value.ToString();
                    String Column_Amount = dataGridView1.Rows[i].Cells[2].Value.ToString();
                    String Column_Date = dataGridView1.Rows[i].Cells[3].Value.ToString();
                    String Column_Category = dataGridView1.Rows[i].Cells[4].Value.ToString();
                    //String Column_Date = dataGridView1.Rows[i].Cells[4].Value.ToString();

                    //Values Set Into Invoice
                    e.Graphics.DrawString(i.ToString(), new Font("Arial", 13, FontStyle.Regular), Brushes.Black, new Point(x_axis, y_axis));
                    e.Graphics.DrawString(Column_Description, new Font("Arial", 13, FontStyle.Regular), Brushes.Black, new Point(140, y_axis));
                    e.Graphics.DrawString(Column_Category, new Font("Arial", 13, FontStyle.Regular), Brushes.Black, new Point(425, y_axis));
                    e.Graphics.DrawString(Column_Amount, new Font("Arial", 13, FontStyle.Regular), Brushes.Black, new Point(540, y_axis));
                    e.Graphics.DrawString(Column_Date, new Font("Arial", 13, FontStyle.Regular), Brushes.Black, new Point(650, y_axis));
                    y_axis += 45;
                }

                //Total Price Calculated
                Double totalPrice = 0;
                for (int j = 0; j < items - 1; j++)
                {
                    String Column_TotalPrice1 = dataGridView1.Rows[j].Cells[2].Value.ToString();
                    Double TotalPrice = Convert.ToDouble(Column_TotalPrice1);
                    totalPrice += TotalPrice;
                }
                int l = 30 + y_axis;
                e.Graphics.DrawString("___________" + "Total Amount: " + totalPrice.ToString() + "______________", new Font("Arial", 20, FontStyle.Bold), Brushes.Gray, new Point(55, y_axis));
                e.Graphics.DrawString("\nThanks For Visting Here", new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(280, l));

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
//
//Employee Salary Invoice Button
//
        private void Employee_INvoice_BTN_Click(object sender, EventArgs e)
        {
            try
            {
                // SqlConnection conn = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Integrated Security=True");
                SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Till_Restuarant_Softwear.Properties.Settings.Setting"].ToString());
                conn.Open();
                    SqlDataAdapter sqlDA = new SqlDataAdapter("Select * From Employee Where Name='" + comboBox1.Text + "'", conn);
                    DataTable dt = new DataTable();
                    sqlDA.Fill(dt);
                    dataGridView1.DataSource = dt;
                    conn.Close();

                //SqlConnection conn1 = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Integrated Security=True");
                SqlConnection conn1 = new SqlConnection(ConfigurationManager.ConnectionStrings["Till_Restuarant_Softwear.Properties.Settings.Setting"].ToString());
                conn1.Open();
                    SqlCommand cmd = new SqlCommand("Select * from Employee Where Name='"+comboBox1.Text+"'",conn1);
                    SqlDataReader dr;
                    dr = cmd.ExecuteReader();
                    if(dr.Read())
                    {
                        panel2.Show();
                        panel2.BringToFront();

                        jname.Text = dr["Name"].ToString();
                        jstatus.Text= dr["Status"].ToString();
                        jbasicsalary.Text= dr["Salary"].ToString();
                    }

                   
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
//
//Employee Invoice design
//
        private void Employee_Saleary_Invoice_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
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
                    /*e.Graphics.DrawString(dr["ResturentName"].ToString(), new Font("Arial", 25, FontStyle.Bold), Brushes.Red, new Point(60, 20));
                    e.Graphics.DrawString("Email:" + dr["Mail"].ToString(), new Font("Arial", 17, FontStyle.Regular), Brushes.Black, new Point(60, 70));
                    e.Graphics.DrawString("Phone:" + dr["ContactNo"].ToString(), new Font("Arial", 17, FontStyle.Regular), Brushes.Black, new Point(60, 120));
               */
                    e.Graphics.DrawString("Emplloyee Name", new Font("Arial", 15, FontStyle.Bold), Brushes.Black, new Point(0, 10));
                    e.Graphics.DrawString("Status", new Font("Arial", 15, FontStyle.Bold), Brushes.Black, new Point(290, 10));
                    e.Graphics.DrawString("Date", new Font("Arial", 15, FontStyle.Bold), Brushes.Black, new Point(520, 10));

                    e.Graphics.DrawString(jname.Text, new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(0, 40));
                    e.Graphics.DrawString(jstatus.Text, new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(290, 40));
                    e.Graphics.DrawString(DateTime.Now.ToString("dd/MM/yyyy"), new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(520, 40));

                    e.Graphics.DrawString("__________________________________________________________________________________", new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(0, 60));

                    ///
                    //Payments
                    //
                    e.Graphics.DrawString("Payments", new Font("Arial", 20, FontStyle.Bold), Brushes.Black, new Point(20, 95));


                    e.Graphics.DrawString("Basic Salary", new Font("Arial", 15, FontStyle.Bold), Brushes.Black, new Point(0, 150));
                    e.Graphics.DrawString("Over Time", new Font("Arial", 15, FontStyle.Bold), Brushes.Black, new Point(0, 190));
                    e.Graphics.DrawString("SSP", new Font("Arial", 15, FontStyle.Bold), Brushes.Black, new Point(0, 220));

                    e.Graphics.DrawString(jbasicsalary.Text, new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(290, 150));
                    e.Graphics.DrawString(jovertime.Text, new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(290, 190));
                    e.Graphics.DrawString(jssp.Text, new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(290, 220));

                    e.Graphics.DrawString("_____________________________________________________________________________________________", new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(0, 245));

                    int totalPayment = Convert.ToInt32(jbasicsalary.Text) + Convert.ToInt32(jovertime.Text) + Convert.ToInt32(jssp.Text);
                    e.Graphics.DrawString("Total Payment", new Font("Arial", 15, FontStyle.Bold), Brushes.Black, new Point(0, 270));
                    e.Graphics.DrawString(totalPayment.ToString(), new Font("Arial", 15, FontStyle.Bold), Brushes.Black, new Point(290, 270));

                    //
                    //Deduction
                    //
                    e.Graphics.DrawString("Deduction", new Font("Arial", 20, FontStyle.Bold), Brushes.Black, new Point(420, 95));


                    e.Graphics.DrawString("Income Tax", new Font("Arial", 15, FontStyle.Bold), Brushes.Black, new Point(410, 150));
                    e.Graphics.DrawString("National Insurance", new Font("Arial", 15, FontStyle.Bold), Brushes.Black, new Point(410, 190));

                    e.Graphics.DrawString(jincometax.Text, new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(650, 150));
                    e.Graphics.DrawString(jinsurance.Text, new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(650, 190));

                    
                    int totalDeduction = Convert.ToInt32(jincometax.Text) + Convert.ToInt32(jinsurance.Text);
                    e.Graphics.DrawString("Total Deduction", new Font("Arial", 15, FontStyle.Bold), Brushes.Black, new Point(420, 270));
                    e.Graphics.DrawString(totalDeduction.ToString(), new Font("Arial", 15, FontStyle.Bold), Brushes.Black, new Point(650, 270));

                    e.Graphics.DrawString("_____________________________________________________________________________________________", new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(0, 290));

                    e.Graphics.DrawString(dr["ResturentName"].ToString(), new Font("Arial", 15, FontStyle.Bold), Brushes.Black, new Point(20, 330));

                    e.Graphics.DrawString("Total Payment", new Font("Arial", 20, FontStyle.Bold), Brushes.Red, new Point(420, 330));

                    e.Graphics.DrawString("Total Payment", new Font("Arial", 15, FontStyle.Bold), Brushes.Black, new Point(420, 370));
                    e.Graphics.DrawString("Total Deduction", new Font("Arial", 15, FontStyle.Bold), Brushes.Black, new Point(420, 400));

                    e.Graphics.DrawString(totalPayment.ToString(), new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(590, 370));
                    e.Graphics.DrawString(totalDeduction.ToString(), new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(590, 400));

                    e.Graphics.DrawString("___________________________________________________________________________________", new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(0, 420));

                    int totalAmount = totalPayment - totalDeduction;
                    e.Graphics.DrawString("Total:", new Font("Arial", 15, FontStyle.Bold), Brushes.Black, new Point(430, 460));
                    e.Graphics.DrawString(totalAmount.ToString(), new Font("Arial", 15, FontStyle.Bold), Brushes.Black, new Point(590, 460));
                }
                /*
                //header
                /*e.Graphics.DrawString("TIMBER GARDENS RESTURANT", new Font("Arial", 25, FontStyle.Bold), Brushes.Red, new Point(60, 20));
                e.Graphics.DrawString("Email: Douglasdanso@gmail.com", new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(60, 70));
                e.Graphics.DrawString("Phone: +447897864996", new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(60, 120));
                e.Graphics.DrawString("Employee Salary Invoice", new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(60, 170));
                e.Graphics.DrawString("Invoice #:", new Font("Arial", 17, FontStyle.Bold), Brushes.Black, new Point(590, 80));
                e.Graphics.DrawString("Date:" + DateTime.Now.ToString("dd/MM/yyyy"), new Font("Arial", 17, FontStyle.Regular), Brushes.Black, new Point(590, 130));
                e.Graphics.DrawString("__________________________________________", new Font("Arial", 20, FontStyle.Bold), Brushes.Gray, new Point(55, 195));
                e.Graphics.DrawString("Name", new Font("Arial", 15, FontStyle.Regular), Brushes.Red, new Point(55, 230));
                e.Graphics.DrawString("Salary", new Font("Arial", 15, FontStyle.Regular), Brushes.Red, new Point(290, 230));
                e.Graphics.DrawString("Status", new Font("Arial", 15, FontStyle.Regular), Brushes.Red, new Point(450, 230));
                e.Graphics.DrawString("Shift", new Font("Arial", 15, FontStyle.Regular), Brushes.Red, new Point(565, 230));
                e.Graphics.DrawString("Month", new Font("Arial", 15, FontStyle.Regular), Brushes.Red, new Point(645, 230));

                //Values Fetch and set into Invoice
                int items = dataGridView1.Rows.Count;
                int y_axis = 280;
                int x_axis = 55;
                for (int i = 0; i < items - 1; i++)
                {
                    //Values Fetch From DataGridView
                    String Column_Description = dataGridView1.Rows[i].Cells[1].Value.ToString();
                    String Column_Salary = dataGridView1.Rows[i].Cells[4].Value.ToString();
                    String Column_Status = dataGridView1.Rows[i].Cells[5].Value.ToString();
                    String Column_Shift = dataGridView1.Rows[i].Cells[6].Value.ToString();
                    //String Column_Date = dataGridView1.Rows[i].Cells[4].Value.ToString();

                    //Values Set Into Invoice
                    e.Graphics.DrawString(Column_Description, new Font("Arial", 13, FontStyle.Regular), Brushes.Black, new Point(x_axis, y_axis));
                    e.Graphics.DrawString(Column_Salary, new Font("Arial", 13, FontStyle.Regular), Brushes.Black, new Point(290, y_axis));
                    e.Graphics.DrawString(Column_Status, new Font("Arial", 13, FontStyle.Regular), Brushes.Black, new Point(450, y_axis));
                    e.Graphics.DrawString(Column_Shift, new Font("Arial", 13, FontStyle.Regular), Brushes.Black, new Point(565, y_axis));
                    e.Graphics.DrawString(jmonth.Text, new Font("Arial", 13, FontStyle.Regular), Brushes.Black, new Point(650, y_axis));
                    y_axis += 45;
                }

                //Total Price Calculated
                Double totalPrice = 0;
                for (int j = 0; j < items - 1; j++)
                {
                    String Column_TotalPrice1 = dataGridView1.Rows[j].Cells[4].Value.ToString();
                    Double TotalPrice = Convert.ToDouble(Column_TotalPrice1);
                    totalPrice += TotalPrice;
                }
                int l = 30 + y_axis;
                e.Graphics.DrawString("_________________________________________", new Font("Arial", 20, FontStyle.Bold), Brushes.Gray, new Point(55, y_axis));
                e.Graphics.DrawString("                           " + "Total Amount: " + totalPrice.ToString() + "", new Font("Arial", 17, FontStyle.Bold), Brushes.Gray, new Point(55, y_axis));
                e.Graphics.DrawString("\nThanks For Visting Here", new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(280, l));
                */
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
           // Application.Exit();
        }

        private void jbasicsalary_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(jbasicsalary.Text, "[^0-9]"))
            {
                jbasicsalary.Text = jbasicsalary.Text.Remove(jbasicsalary.Text.Length - 1);
            }
        }

        private void jovertime_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(jovertime.Text, "[^0-9]"))
            {
                jovertime.Text = jovertime.Text.Remove(jovertime.Text.Length - 1);
            }
        }

        private void jssp_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(jbasicsalary.Text, "[^0-9]"))
            {
                jssp.Text = jssp.Text.Remove(jssp.Text.Length - 1);
            }
        }

        private void jincometax_TextChanged(object sender, EventArgs e)
        {
             if (System.Text.RegularExpressions.Regex.IsMatch(jincometax.Text, "[^0-9]"))
            {
                jincometax.Text = jincometax.Text.Remove(jincometax.Text.Length - 1);
            }
        }

        private void jinsurance_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(jinsurance.Text, "[^0-9]"))
            {
                jinsurance.Text = jinsurance.Text.Remove(jinsurance.Text.Length - 1);
            }
        }
//
//
//
        private void JINVOICEBTN_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = Employee_Saleary_Invoice;
            printPreviewDialog1.ShowDialog();

            panel2.Hide();
            
                
            
        }
//
//Today Summary Invoice
//
        private void Today_Summary_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            try
            {
                String todayDate = DateTime.Now.ToString("dd/MM/yyyy");

                SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Till_Restuarant_Softwear.Properties.Settings.Setting"].ToString());
                conn.Open();
                SqlCommand cmd = new SqlCommand("Select * From Resturent_Information", conn);
                SqlDataReader dr;
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    e.Graphics.DrawString(dr["ResturentName"].ToString(), new Font("Arial", 30, FontStyle.Regular), Brushes.Black, new Point(10, 10));

                }
                conn.Close();

                e.Graphics.DrawString("TODAY SUMMARY", new Font("Arial", 20, FontStyle.Bold), Brushes.Black, new Point(280, 70));
                e.Graphics.DrawString("_____________________________________________________________________________________________", new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(0, 90));
                conn.Close();
                e.Graphics.DrawString("Sale By Dine", new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(150, 150));

                SqlConnection conn1 = new SqlConnection(ConfigurationManager.ConnectionStrings["Till_Restuarant_Softwear.Properties.Settings.Setting"].ToString());
                conn1.Open();
                SqlCommand cmd1 = new SqlCommand("Select * From Dine_In Where Date='"+ todayDate+"'", conn1);
                SqlDataReader dr1;
                dr1 = cmd1.ExecuteReader();
                while (dr1.Read())
                {
                    Double getAmount = Convert.ToDouble(dr1["TotalPrice"].ToString());
                    Double price = Convert.ToDouble(jdineinsale.Text);
                    Double total = getAmount + price;
                    String t1 = Convert.ToString(total);
                    jdineinsale.Text = t1;
                }
                e.Graphics.DrawString(jdineinsale.Text, new Font("Arial", 15, FontStyle.Bold), Brushes.Black, new Point(150, 185));
                conn1.Close();


                e.Graphics.DrawString("Sale By Take-Away", new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(430, 150));


                SqlConnection conn2 = new SqlConnection(ConfigurationManager.ConnectionStrings["Till_Restuarant_Softwear.Properties.Settings.Setting"].ToString());
                conn2.Open();
                SqlCommand cmd2 = new SqlCommand("Select * From Take_Away Where Date='" + todayDate + "'", conn2);
                SqlDataReader dr2;
                dr2 = cmd2.ExecuteReader();
                if (dr2.Read())
                {
                    Double getAmount1 = Convert.ToDouble(dr2["TotalPrice"].ToString());
                    Double price1 = Convert.ToDouble(jtakeawaysale.Text);
                    Double total1 = getAmount1 + price1;
                    String t11 = Convert.ToString(total1);
                    jtakeawaysale.Text = t11;
                    
                }
                e.Graphics.DrawString(jtakeawaysale.Text, new Font("Arial", 15, FontStyle.Bold), Brushes.Black, new Point(430, 185));

                e.Graphics.DrawString("Sale By Delivery", new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(150, 220));
                conn2.Close();

                SqlConnection conn3 = new SqlConnection(ConfigurationManager.ConnectionStrings["Till_Restuarant_Softwear.Properties.Settings.Setting"].ToString());
                conn3.Open();
                SqlCommand cmd3 = new SqlCommand("Select * From Delivery Where Date='" + todayDate + "'", conn3);
                SqlDataReader dr3;
                dr3 = cmd3.ExecuteReader();
                if (dr3.Read())
                {
                    Double getAmount1 = Convert.ToDouble(dr3["TotalPrice"].ToString());
                    Double price1 = Convert.ToDouble(jdeliverysale.Text);
                    Double total1 = getAmount1 + price1;
                    String t11 = Convert.ToString(total1);
                    jdeliverysale.Text = t11;
                    
                }
                e.Graphics.DrawString(jdeliverysale.Text, new Font("Arial", 15, FontStyle.Bold), Brushes.Black, new Point(150, 250));
                conn3.Close();
                e.Graphics.DrawString("Total Sale", new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(430, 220));

                Double saleByDineIn = Convert.ToDouble(jdineinsale.Text);
                Double saleByTakeAway = Convert.ToDouble(jtakeawaysale.Text);
                Double saleByDelivery = Convert.ToDouble(jdeliverysale.Text);
                Double totalSale = saleByDineIn + saleByTakeAway + saleByDelivery;

                e.Graphics.DrawString(totalSale.ToString(), new Font("Arial", 15, FontStyle.Bold), Brushes.Black, new Point(430, 250));
                
                e.Graphics.DrawString("Total Purchase", new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(150, 290));


                SqlConnection conn5 = new SqlConnection(ConfigurationManager.ConnectionStrings["Till_Restuarant_Softwear.Properties.Settings.Setting"].ToString());
                conn5.Open();
                SqlCommand cmd5 = new SqlCommand("Select * From Purchase_Stock Where PurchaseDate='" + todayDate + "'", conn5);
                SqlDataReader dr5;
                dr5 = cmd5.ExecuteReader();
                if (dr5.Read())
                {
                    Double getAmount1 = Convert.ToDouble(dr5["TotalPrice"].ToString());
                    Double price1 = Convert.ToDouble(jpurchase.Text);
                    Double total1 = getAmount1 + price1;
                    String t11 = Convert.ToString(total1);
                    jpurchase.Text = t11;
                    
                }
                e.Graphics.DrawString(jpurchase.Text, new Font("Arial", 15, FontStyle.Bold), Brushes.Black, new Point(150, 320));
                e.Graphics.DrawString("Total Expenses", new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(430, 290));
                conn5.Close();

                SqlConnection conn6 = new SqlConnection(ConfigurationManager.ConnectionStrings["Till_Restuarant_Softwear.Properties.Settings.Setting"].ToString());
                conn6.Open();
                SqlCommand cmd6 = new SqlCommand("Select * From Expenses  Where Date='" + todayDate + "'", conn6);
                SqlDataReader dr6;
                dr6 = cmd6.ExecuteReader();
                if (dr6.Read())
                {
                    Double getAmount1 = Convert.ToDouble(dr6["Amount"].ToString());
                    Double price1 = Convert.ToDouble(jexpenses.Text);
                    Double total1 = getAmount1 + price1;
                    String t11 = Convert.ToString(total1);
                    jexpenses.Text = t11;
                    
                }
                e.Graphics.DrawString(jexpenses.Text, new Font("Arial", 15, FontStyle.Bold), Brushes.Black, new Point(430, 320));
                conn6.Close();

                SqlConnection conn7 = new SqlConnection(ConfigurationManager.ConnectionStrings["Till_Restuarant_Softwear.Properties.Settings.Setting"].ToString());
                conn7.Open();
                SqlCommand cmd7 = new SqlCommand("Select * From Payment_Method Where Type='" + "Cash" +"'and Date='"+DateTime.Now.ToString("dd/MM/yyyy")+ "'", conn7);
                SqlDataReader dr7;
                dr7 = cmd7.ExecuteReader();
                while (dr7.Read())
                {
                    Double getAmount1 = Convert.ToDouble(dr7["TotalPrice"].ToString());
                    Double price1 = Convert.ToDouble(jcashpayment1.Text);
                    Double total1 = getAmount1 + price1;
                    String t11 = Convert.ToString(total1);
                    jcashpayment1.Text = t11;

                }
                e.Graphics.DrawString("Today Cash Payment", new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(150, 360));
                e.Graphics.DrawString(jcashpayment1.Text, new Font("Arial", 15, FontStyle.Bold), Brushes.Black, new Point(150, 390));
                conn7.Close();

                SqlConnection conn8 = new SqlConnection(ConfigurationManager.ConnectionStrings["Till_Restuarant_Softwear.Properties.Settings.Setting"].ToString());
                conn8.Open();
                SqlCommand cmd8 = new SqlCommand("Select * From Payment_Method Where Type='" + "Credit Card" + "'and Date='" + DateTime.Now.ToString("dd/MM/yyyy") + "'", conn8);
                SqlDataReader dr8;
                dr8 = cmd8.ExecuteReader();
                while (dr8.Read())
                {
                    Double getAmount1 = Convert.ToDouble(dr8["TotalPrice"].ToString());
                    Double price1 = Convert.ToDouble(jcreditcardpayment.Text);
                    Double total1 = getAmount1 + price1;
                    String t11 = Convert.ToString(total1);
                    jcreditcardpayment.Text = t11;
                }

                e.Graphics.DrawString("Today Credit Card Payment", new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(430, 360));
                e.Graphics.DrawString(jcreditcardpayment.Text, new Font("Arial", 15, FontStyle.Bold), Brushes.Black, new Point(430, 390));


                e.Graphics.DrawString("_____________________________________________________________________________________________", new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(0, 420));

                e.Graphics.DrawString("For more detailed information, please visit your BackOffice Dashboard.", new Font("Arial", 15, FontStyle.Bold), Brushes.Black, new Point(40, 450));

                

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
//
//Today Summary Btn
//
        private void JTODAYSUMMARY_BTN_Click(object sender, EventArgs e)
        {
            jdeliverysale.Text = "0";
            jtakeawayprice.Text = "0";
            jdineinsale.Text = "0";

            jpurchase.Text = "0";
            jexpenses.Text = "0";
            jtotalsale.Text = "0";

            jcashpayment1.Text = "0";
            jcreditcardpayment.Text = "0";

            printPreviewDialog1.Document = Today_Summary;
            printPreviewDialog1.ShowDialog();
        }

        private void groupBox6_Enter(object sender, EventArgs e)
        {

        }
//
//Total Summary Invoice Design
//
        private void Total_Summary_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            try
            {
                //  SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Till_Restuarant_Softwear.Properties.Settings.Setting"].ToString());

                SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Till_Restuarant_Softwear.Properties.Settings.Setting"].ToString());
                conn.Open();
                SqlCommand cmd = new SqlCommand("Select * From Resturent_Information", conn);
                SqlDataReader dr;
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    e.Graphics.DrawString(dr["ResturentName"].ToString(), new Font("Arial", 30, FontStyle.Regular), Brushes.Black, new Point(10, 10));

                }
                conn.Close();

                e.Graphics.DrawString("TOTAL SUMMARY", new Font("Arial", 20, FontStyle.Bold), Brushes.Black, new Point(280, 70));
                e.Graphics.DrawString("_____________________________________________________________________________________________", new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(0, 90));

                e.Graphics.DrawString("Sale By Dine", new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(150, 150));

                SqlConnection conn1 = new SqlConnection(ConfigurationManager.ConnectionStrings["Till_Restuarant_Softwear.Properties.Settings.Setting"].ToString());
                conn1.Open();
                SqlCommand cmd1 = new SqlCommand("Select * From Dine_In", conn1);
                SqlDataReader dr1;
                dr1 = cmd1.ExecuteReader();
                while (dr1.Read())
                {
                    Double getAmount = Convert.ToDouble(dr1["TotalPrice"].ToString());
                    Double price = Convert.ToDouble(jdineinsale.Text);
                    Double total = getAmount + price;
                    String t1 = Convert.ToString(total);
                    jdineinsale.Text = t1;


                }
                e.Graphics.DrawString(jdineinsale.Text, new Font("Arial", 15, FontStyle.Bold), Brushes.Black, new Point(150, 185));

                e.Graphics.DrawString("Sale By Take-Away", new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(430, 150));

                SqlConnection conn2 = new SqlConnection(ConfigurationManager.ConnectionStrings["Till_Restuarant_Softwear.Properties.Settings.Setting"].ToString());
                conn2.Open();
                SqlCommand cmd2 = new SqlCommand("Select * From Take_Away", conn2);
                SqlDataReader dr2;
                dr2 = cmd2.ExecuteReader();
                while (dr2.Read())
                {
                    Double getAmount1 = Convert.ToDouble(dr2["TotalPrice"].ToString());
                    Double price1 = Convert.ToDouble(jtakeawaysale.Text);
                    Double total1 = getAmount1 + price1;
                    String t11 = Convert.ToString(total1);
                    jtakeawaysale.Text = t11;

                }
                e.Graphics.DrawString(jtakeawaysale.Text, new Font("Arial", 15, FontStyle.Bold), Brushes.Black, new Point(430, 185));

                e.Graphics.DrawString("Sale By Delivery", new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(150, 220));

                SqlConnection conn3 = new SqlConnection(ConfigurationManager.ConnectionStrings["Till_Restuarant_Softwear.Properties.Settings.Setting"].ToString());
                conn3.Open();
                SqlCommand cmd3 = new SqlCommand("Select * From Delivery", conn3);
                SqlDataReader dr3;
                dr3 = cmd3.ExecuteReader();
                while (dr3.Read())
                {
                    Double getAmount1 = Convert.ToDouble(dr3["TotalPrice"].ToString());
                    Double price1 = Convert.ToDouble(jdeliverysale.Text);
                    Double total1 = getAmount1 + price1;
                    String t11 = Convert.ToString(total1);
                    jdeliverysale.Text = t11;

                }
                e.Graphics.DrawString(jdeliverysale.Text, new Font("Arial", 15, FontStyle.Bold), Brushes.Black, new Point(150, 250));

                e.Graphics.DrawString("Total Sale", new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(430, 220));

                Double saleByDineIn = Convert.ToDouble(jdineinsale.Text);
                Double saleByTakeAway = Convert.ToDouble(jtakeawaysale.Text);
                Double saleByDelivery = Convert.ToDouble(jdeliverysale.Text);
                Double totalSale = saleByDineIn + saleByTakeAway + saleByDelivery;

                e.Graphics.DrawString(totalSale.ToString(), new Font("Arial", 15, FontStyle.Bold), Brushes.Black, new Point(430, 250));


                e.Graphics.DrawString("Total Purchase", new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(150, 290));


                SqlConnection conn5 = new SqlConnection(ConfigurationManager.ConnectionStrings["Till_Restuarant_Softwear.Properties.Settings.Setting"].ToString());
                conn5.Open();
                SqlCommand cmd5 = new SqlCommand("Select * From Purchase_Stock", conn5);
                SqlDataReader dr5;
                dr5 = cmd5.ExecuteReader();
                while (dr5.Read())
                {
                    Double getAmount1 = Convert.ToDouble(dr5["TotalPrice"].ToString());
                    Double price1 = Convert.ToDouble(jpurchase.Text);
                    Double total1 = getAmount1 + price1;
                    String t11 = Convert.ToString(total1);
                    jpurchase.Text = t11;

                }
                e.Graphics.DrawString(jpurchase.Text, new Font("Arial", 15, FontStyle.Bold), Brushes.Black, new Point(150, 320));
                e.Graphics.DrawString("Total Expenses", new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(430, 290));

                SqlConnection conn6 = new SqlConnection(ConfigurationManager.ConnectionStrings["Till_Restuarant_Softwear.Properties.Settings.Setting"].ToString());
                conn6.Open();
                SqlCommand cmd6 = new SqlCommand("Select * From Expenses", conn6);
                SqlDataReader dr6;
                dr6 = cmd6.ExecuteReader();
                while (dr6.Read())
                {
                    Double getAmount1 = Convert.ToDouble(dr6["Amount"].ToString());
                    Double price1 = Convert.ToDouble(jexpenses.Text);
                    Double total1 = getAmount1 + price1;
                    String t11 = Convert.ToString(total1);
                    jexpenses.Text = t11;

                }
                e.Graphics.DrawString(jexpenses.Text, new Font("Arial", 15, FontStyle.Bold), Brushes.Black, new Point(430, 320));

                SqlConnection conn7 = new SqlConnection(ConfigurationManager.ConnectionStrings["Till_Restuarant_Softwear.Properties.Settings.Setting"].ToString());
                conn7.Open();
                SqlCommand cmd7 = new SqlCommand("Select * From Payment_Method Where Type='" + "Cash"+ "'", conn7);
                SqlDataReader dr7;
                dr7 = cmd7.ExecuteReader();
                while (dr7.Read())
                {
                    Double getAmount1 = Convert.ToDouble(dr7["TotalPrice"].ToString());
                    Double price1 = Convert.ToDouble(jcashpayment1.Text);
                    Double total1 = getAmount1 + price1;
                    String t11 = Convert.ToString(total1);
                    jcashpayment1.Text = t11;

                }
                e.Graphics.DrawString("Total Cash Payment", new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(150, 360));
                e.Graphics.DrawString(jcashpayment1.Text, new Font("Arial", 15, FontStyle.Bold), Brushes.Black, new Point(150, 390));

                SqlConnection conn8 = new SqlConnection(ConfigurationManager.ConnectionStrings["Till_Restuarant_Softwear.Properties.Settings.Setting"].ToString());
                conn8.Open();
                SqlCommand cmd8 = new SqlCommand("Select * From Payment_Method Where Type='" + "Credit Card" + "'", conn8);
                SqlDataReader dr8;
                dr8 = cmd8.ExecuteReader();
                while (dr8.Read())
                {
                    Double getAmount1 = Convert.ToDouble(dr8["TotalPrice"].ToString());
                    Double price1 = Convert.ToDouble(jcreditcardpayment.Text);
                    Double total1 = getAmount1 + price1;
                    String t11 = Convert.ToString(total1);
                    jcreditcardpayment.Text = t11;

                }

                e.Graphics.DrawString("Total Credit Card Payment", new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(430, 360));
                e.Graphics.DrawString(jcreditcardpayment.Text, new Font("Arial", 15, FontStyle.Bold), Brushes.Black, new Point(430, 390));

                e.Graphics.DrawString("_____________________________________________________________________________________________", new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(0, 420));

                e.Graphics.DrawString("For more detailed information, please visit your BackOffice Dashboard.", new Font("Arial", 15, FontStyle.Bold), Brushes.Black, new Point(40, 450));



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
//
//Total Summary Btn
//
        private void button1_Click(object sender, EventArgs e)
        {
            jdeliverysale.Text = "0";
            jtakeawayprice.Text = "0";
            jdineinsale.Text = "0";

            jpurchase.Text = "0";
            jexpenses.Text = "0";
            jtotalsale.Text = "0";

            jcashpayment1.Text = "0";
            jcreditcardpayment.Text = "0";

            printPreviewDialog1.Document = Total_Summary;
            printPreviewDialog1.ShowDialog();
        }

        private void Cash_Payment_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            try
            {
                //  SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Till_Restuarant_Softwear.Properties.Settings.Setting"].ToString());

                SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Till_Restuarant_Softwear.Properties.Settings.Setting"].ToString());
                conn.Open();
                SqlCommand cmd = new SqlCommand("Select * From Resturent_Information", conn);
                SqlDataReader dr;
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    e.Graphics.DrawString(dr["ResturentName"].ToString(), new Font("Arial", 30, FontStyle.Regular), Brushes.Black, new Point(10, 10));

                    String date = DateTime.Now.ToString("dd/MM/yyyy");
                
                    SqlConnection conn1 = new SqlConnection(ConfigurationManager.ConnectionStrings["Till_Restuarant_Softwear.Properties.Settings.Setting"].ToString());
                    conn1.Open();
                    SqlCommand cmd1 = new SqlCommand("Select * From Dine_In Where MenuName='" + jselectmenu.Text + "'and Date Between'" + dateTimePicker1.Text+"'and'"+dateTimePicker2.Text + "'", conn1);
                    SqlDataReader dr1;
                    dr1 = cmd1.ExecuteReader();
                    while (dr1.Read())
                    {
                        Double getAmount1 = Convert.ToDouble(dr1["TotalPrice"].ToString());
                        Double price1 = Convert.ToDouble(jcategorydinein.Text);
                        Double total1 = getAmount1 + price1;
                        String t11 = Convert.ToString(total1);
                        jcategorydinein.Text = t11;
                       

                    }
                    conn1.Close();

                    e.Graphics.DrawString("SALE BY CATEGORY", new Font("Arial", 20, FontStyle.Bold), Brushes.Black, new Point(265, 70));
                    e.Graphics.DrawString("_____________________________________________________________________________________________", new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(0, 90));


                    e.Graphics.DrawString("Menu Sale By Dine_In", new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(150, 120));
                    e.Graphics.DrawString(jcategorydinein.Text, new Font("Arial", 15, FontStyle.Bold), Brushes.Black, new Point(160, 150));

                    SqlConnection conn2 = new SqlConnection(ConfigurationManager.ConnectionStrings["Till_Restuarant_Softwear.Properties.Settings.Setting"].ToString());
                    conn2.Open();
                    SqlCommand cmd2 = new SqlCommand("Select * From Take_Away Where MenuName='" + jselectmenu.Text + "'and Date Between'" + dateTimePicker1.Text + "'and'" + dateTimePicker2.Text + "'", conn2);
                    SqlDataReader dr2;
                    dr2 = cmd2.ExecuteReader();
                    while (dr2.Read())
                    {
                        Double getAmount1 = Convert.ToDouble(dr2["TotalPrice"].ToString());
                        Double price1 = Convert.ToDouble(jcategorytakeaway.Text);
                        Double total1 = getAmount1 + price1;
                        String t11 = Convert.ToString(total1);
                        jcategorytakeaway.Text = t11;
                       
                    }
                    conn2.Close();
                    e.Graphics.DrawString("Menu Sale By Take-Away", new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(420, 120));
                    e.Graphics.DrawString(jcategorytakeaway.Text, new Font("Arial", 15, FontStyle.Bold), Brushes.Black, new Point(420, 150));

                    SqlConnection conn3 = new SqlConnection(ConfigurationManager.ConnectionStrings["Till_Restuarant_Softwear.Properties.Settings.Setting"].ToString());
                    conn3.Open();
                    SqlCommand cmd3 = new SqlCommand("Select * From Delivery Where MenuName='" + jselectmenu.Text + "'and Date Between'" + dateTimePicker1.Text + "'and'" + dateTimePicker2.Text + "'", conn3);
                    SqlDataReader dr3;
                    dr3 = cmd3.ExecuteReader();
                    while (dr3.Read())
                    {
                        Double getAmount1 = Convert.ToDouble(dr3["TotalPrice"].ToString());
                        Double price1 = Convert.ToDouble(jcategorydelivery.Text);
                        Double total1 = getAmount1 + price1;
                        String t11 = Convert.ToString(total1);
                        jcategorydelivery.Text = t11;
                        

                    }
                    conn3.Close();
                    e.Graphics.DrawString("Menu Sale By Delivery", new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(150, 190));
                    e.Graphics.DrawString(jcategorydelivery.Text, new Font("Arial", 15, FontStyle.Bold), Brushes.Black, new Point(160, 220));

                    e.Graphics.DrawString("Menu Total Sale", new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(420, 190));

                    Double categoryDineIn = Convert.ToDouble(jcategorydinein.Text);
                    Double categoryTakeAway = Convert.ToDouble(jcategorytakeaway.Text);
                    Double categoryDelivery = Convert.ToDouble(jcategorydelivery.Text);
                    Double categoryTotalSale = categoryDineIn + categoryTakeAway + categoryDelivery;

                    e.Graphics.DrawString(categoryTotalSale.ToString(), new Font("Arial", 15, FontStyle.Bold), Brushes.Black, new Point(420, 220));

                    e.Graphics.DrawString("_____________________________________________________________________________________________", new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(0, 250));

                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void JCASHPAYMENT_Click(object sender, EventArgs e)
        {
            //printPreviewDialog1.Document = Cash_Payment;
            //printPreviewDialog1.ShowDialog();
        }

        private void Cradit_payment_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            /*String date = DateTime.Now.ToString("MM/dd/yyyy");

            try
            {
                //  SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Till_Restuarant_Softwear.Properties.Settings.Setting"].ToString());

                SqlConnection conn = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Integrated Security=True"); conn.Open();
                SqlCommand cmd = new SqlCommand("Select * From Resturent_Information", conn);
                SqlDataReader dr;
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {



                    SqlConnection conn1 = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Integrated Security=True");
                    conn1.Open();
                    SqlCommand cmd1 = new SqlCommand("Select * From Payment_Method Where Type='" + "Credit Card" + "'and Date='" + date + "'", conn1);
                    SqlDataReader dr1;
                    dr1 = cmd1.ExecuteReader();
                    while (dr1.Read())
                    {
                        Double getAmount1 = Convert.ToDouble(dr1["TotalPrice"].ToString());
                        Double price1 = Convert.ToDouble(jcreditcardpayment.Text);
                        Double total1 = getAmount1 + price1;
                        String t11 = Convert.ToString(total1);
                        jcreditcardpayment.Text = t11;

                    }

                    e.Graphics.DrawString("Date: " + date, new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(620, 120));
                    e.Graphics.DrawString(dr["ResturentName"].ToString(), new Font("Arial", 30, FontStyle.Regular), Brushes.Black, new Point(10, 10));
                    e.Graphics.DrawString("TOTAL CREDIT CARD PAYMENT", new Font("Arial", 20, FontStyle.Bold), Brushes.Black, new Point(265, 70));
                    e.Graphics.DrawString("_____________________________________________________________________________________________", new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(0, 90));

                    e.Graphics.DrawString("Today Credit Card Payment:", new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(250, 120));
                    e.Graphics.DrawString(jcreditcardpayment.Text, new Font("Arial", 15, FontStyle.Bold), Brushes.Black, new Point(280, 150));
                    e.Graphics.DrawString("_____________________________________________________________________________________________", new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(0, 170));

                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }*/

        
    }

        private void JCREDITPAYMENT_Click(object sender, EventArgs e)
        {
           // printPreviewDialog1.Document = Cradit_payment;
           // printPreviewDialog1.ShowDialog();
        }

        private void JSALECATEGORY_INVOICE_Click(object sender, EventArgs e)
        {
            jcategorydinein.Text = "0";
            jcategorytakeaway.Text = "0";
            jcategorydelivery.Text = "0";

            printPreviewDialog1.Document = Cash_Payment;
            printPreviewDialog1.ShowDialog();
        }
    }
}
