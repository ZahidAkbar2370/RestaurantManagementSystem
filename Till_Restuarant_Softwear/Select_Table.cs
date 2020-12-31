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
    public partial class Select_Table : Form
    {
        public Select_Table()
        {
            InitializeComponent();
        }

        private void Select_Table_Load(object sender, EventArgs e)
        {
            try
            {
                //SqlConnection conn = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Integrated Security=True");
                SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Till_Restuarant_Softwear.Properties.Settings.Setting"].ToString());
                conn.Open();
                SqlCommand cmd = new SqlCommand("Select * From Table_Manage", conn);
                SqlDataReader dr;
                dr = cmd.ExecuteReader();
                int x = 20, y = 40;
                while (dr.Read())
                {
                    //Checking Teble Reserved Or Not
                    if ( Point_Of_Sale.jtable1.Text== dr["TableNo"].ToString())
                    {
                        Label l = tableLabel(x, y);
                        l.TextAlign = ContentAlignment.BottomCenter;
                        l.Text = dr["TableNo"].ToString();
                        l.ImageAlign = ContentAlignment.TopCenter;
                        l.BackColor = Color.Gray;
                       // l.Image = Image.FromFile(@"C:\Users\Muhammad\Downloads\table2.png");
                        // l.Enabled = false;
                        tablepanel.Controls.Add(l);
                        l.Click += new EventHandler(this.table);
                        x += 170;
                        if (x >= 550)
                        {
                            y += 130;
                            x = 20;
                        }
                    }
                    else
                        if (dr["Status"].ToString() == "Reserved")
                    {
                        Label l = tableLabel(x, y);
                        l.TextAlign = ContentAlignment.BottomCenter;
                        l.Text = dr["TableNo"].ToString();
                        l.ImageAlign = ContentAlignment.TopCenter;
                        l.BackColor = Color.Red;
                       // l.Enabled = false;
                        tablepanel.Controls.Add(l);
                        l.Click += new EventHandler(this.table);
                        x += 170;
                        if (x >= 550)
                        {
                            y += 130;
                            x = 20;
                        }
                    }
                    else
                    {
                        Label l = tableLabel(x, y);
                        l.TextAlign = ContentAlignment.BottomCenter;
                        l.Text = dr["TableNo"].ToString();
                        //l.ForeColor = Color.White;
                        l.BackColor = Color.Green;
                        l.ImageAlign = ContentAlignment.TopCenter;
                        //l.Image = Image.FromFile(@"C:\Users\Muhammad\Downloads\table1.png");
                        tablepanel.Controls.Add(l);
                        l.Click += new EventHandler(this.table);
                        x += 170;
                        if (x >= 550)
                        {
                            y += 130;
                            x = 20;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error");
            }
        }
        public String waiter;
        Label tableLabel(int a, int c)
        {
            Label l = new Label();
            l.Width = 160;
            l.Height = 120;
            l.BackColor = Color.Green;
            l.ForeColor = Color.Black;
            l.TextAlign = ContentAlignment.MiddleCenter;
            l.Location = new Point(a, c);
            return l;
        }
        void table(object sender, EventArgs e)
        {
            Label l = (Label)sender;
            //SqlConnection conn = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Integrated Security=True");
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Till_Restuarant_Softwear.Properties.Settings.Setting"].ToString());
            conn.Open();
            SqlCommand cmd = new SqlCommand("Select * From Table_Manage Where TableNo='" + l.Text + "'and Status='" + "Reserved" + "'", conn);
            SqlDataReader dr;
            dr = cmd.ExecuteReader();

            /*SqlConnection conn5 = new SqlConnection(ConfigurationManager.ConnectionStrings["Till_Restuarant_Softwear.Properties.Settings.Setting"].ToString());
            conn5.Open();
            SqlDataAdapter sqlDA = new SqlDataAdapter("Select * From Dine_In Where TableNo='" + l.Text + "'and Status='" + "Pending" + "'", conn5);
            DataTable dt = new DataTable();
            sqlDA.Fill(dt);
            dataGridView1.DataSource = dt;*/

            SqlConnection conn5 = new SqlConnection(ConfigurationManager.ConnectionStrings["Till_Restuarant_Softwear.Properties.Settings.Setting"].ToString());
            conn5.Open();
            SqlCommand sqlDA = new SqlCommand("Select MenuName,WaiterName,TableNo From Dine_In Where TableNo='" + l.Text + "'and Status='" + "Pending" + "'", conn5);
            SqlDataReader dr5;
            dr5 = sqlDA.ExecuteReader();

//int x = 20, y = 40;
            if (dr.Read())
            {
                
                String table=l.Text;
                jalreadypresentMenu.Text = ".";
                while (dr5.Read())
                {
                    waiter = dr5["WaiterName"].ToString();
                    
                    String menuName= dr5["MenuName"].ToString();
                    jalreadypresentMenu.Text += "\n" + menuName;
                }
                DialogResult dialogResult = MessageBox.Show("Do You Add More Order On This Table?" + "\n\n" + "Already Booked Order Of This Table #" + table+" and WaiterName is " + waiter + "\n\n" + jalreadypresentMenu.Text, "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                    {
                        Point_Of_Sale.jtable1.Text = l.Text;

                        SqlConnection conn3 = new SqlConnection(ConfigurationManager.ConnectionStrings["Till_Restuarant_Softwear.Properties.Settings.Setting"].ToString());
                        conn3.Open();
                        SqlCommand cmd3 = new SqlCommand("Select * From Dine_In Where TableNo='" + l.Text + "'and Status='" + "Pending" + "'", conn3);
                        SqlDataReader dr3;
                        dr3 = cmd3.ExecuteReader();
                        if (dr3.Read())
                        {
                            Point_Of_Sale.label12.Text = dr3["InvoiceNo"].ToString();
                            Point_Of_Sale.jwaiter1.Text = dr3["WaiterName"].ToString();
                        }
                        this.Hide();

                    }
                    else
                    {
                        MessageBox.Show("Table Reserved");
                    }
                
            }
            //
            else if (Point_Of_Sale.jtable1.Text == l.Text)
            {
                l.BackColor = Color.Green;
                l.ImageAlign = ContentAlignment.TopCenter;
                //l.Image = Image.FromFile(@"C:\Users\Muhammad\Downloads\table1.png");
                Point_Of_Sale.jtable1.Text = "";
            }
            //
            else
                if (Point_Of_Sale.jtable1.Text != "")
            {
                MessageBox.Show("Table" + Point_Of_Sale.jtable1.Text + " Already Selected");
            }
            //
            else
                    if (l.BackColor == Color.Green)
            {
                l.ImageAlign = ContentAlignment.TopCenter;
                //l.Image = Image.FromFile(@"C:\Users\Muhammad\Downloads\table2.png");
                l.BackColor = Color.Gray;
                Point_Of_Sale.jtable1.Text = l.Text;
            }
            //
            else
            {
                l.ImageAlign = ContentAlignment.TopCenter;
                //l.Image = Image.FromFile(@"C:\Users\Muhammad\Downloads\table1.png");
                l.BackColor = Color.Green;
            }
        }

        private void JCONFIRM_BTN_Click(object sender, EventArgs e)
        {
            if (Point_Of_Sale.jtable1.Text != "")
            {
                
                if(Point_Of_Sale.jwaiterlogin.Text!="")
                {
                    Point_Of_Sale.jwaiter1.Text = Point_Of_Sale.jwaiterlogin.Text;
                    this.Hide();
                }
                else
                {
                    this.Hide();
                    Select_Waiter f = new Select_Waiter();
                    f.Show();
                }
                
            }
            else
            {
                MessageBox.Show("Select Table");
            }
        }
//
//
//
        private void JCanCEL_BTN_Click(object sender, EventArgs e)
        {
            if (Point_Of_Sale.jtable1.Text == "")
            {
                this.Hide();
            }
            else
            {
                MessageBox.Show("First Un_Select Table");
            }
        }
    }
}
