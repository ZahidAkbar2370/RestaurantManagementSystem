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
    public partial class Select_Waiter : Form
    {
        public Select_Waiter()
        {
            InitializeComponent();
        }

        private void Select_Waiter_Load(object sender, EventArgs e)
        {
            try
            {
                //SqlConnection conn = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Integrated Security=True");
                SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Till_Restuarant_Softwear.Properties.Settings.Setting"].ToString());
                conn.Open();
                SqlCommand cmd = new SqlCommand("Select * From Waiter", conn);
                SqlDataReader dr;
                dr = cmd.ExecuteReader();
                int x = 20, y = 40;
                while (dr.Read())
                {
                    if (Point_Of_Sale.jwaiter1.Text == dr["Name"].ToString())
                    {
                        Label l = waiterLabel(x, y);
                        l.Text = dr["Name"].ToString();
                        l.TextAlign = ContentAlignment.BottomCenter;
                        l.ImageAlign = ContentAlignment.TopCenter;
                        //l.Enabled = false;
                        l.BackColor = Color.Gray;
                        //l.Image = Image.FromFile(@"C:\Users\Muhammad\Downloads\12.png");
                        waiterpanel.Controls.Add(l);
                        l.Click += new EventHandler(this.waiter);
                        x += 170;
                        if (x >= 350)
                        {
                            y += 130;
                            x = 20;
                        }
                    }
                    else
                        if (dr["Status"].ToString() == "Busy")
                    {
                        Label l = waiterLabel(x, y);
                        l.Text = dr["Name"].ToString();
                        l.TextAlign = ContentAlignment.BottomCenter;
                        l.ImageAlign = ContentAlignment.TopCenter;
                        l.Enabled = false;
                        l.BackColor = Color.Red;
                       // l.Image = Image.FromFile(@"C:\Users\Muhammad\Downloads\waiter.png");
                        waiterpanel.Controls.Add(l);
                        l.Click += new EventHandler(this.waiter);
                        x += 170;
                        if (x >= 550)
                        {
                            y += 130;
                            x = 20;
                        }
                    }
                    else
                    {
                        Label l = waiterLabel(x, y);
                        l.Text = dr["Name"].ToString();
                        l.TextAlign = ContentAlignment.BottomCenter;
                        l.ImageAlign = ContentAlignment.TopCenter;
                        l.BackColor = Color.Green;
                        // l.Image = Image.FromFile(@"C:\Users\Muhammad\Downloads\waiter.png");
                        waiterpanel.Controls.Add(l);
                        l.Click += new EventHandler(this.waiter);
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
        Label waiterLabel(int a, int c)
        {
            Label l = new Label();
            l.Width = 160;
            l.Height = 120;
            l.BackColor = Color.Green;
            l.ForeColor = Color.Black;
            l.TextAlign = ContentAlignment.MiddleCenter;
            l.Location = new Point(a, c);
            waiterpanel.Controls.Add(l);

            Label l1 = new Label();
            l1.Width = 105;
            l1.Height = 90;
            return l;
        }
        void waiter(object sender, EventArgs e)
        {
            Label l = (Label)sender;
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Till_Restuarant_Softwear.Properties.Settings.Setting"].ToString());
            //SqlConnection conn = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Integrated Security=True");
            conn.Open();
            SqlCommand cmd = new SqlCommand("Select * From Waiter Where Name='" + l.Text + "'and Status='" + "Busy" + "'", conn);
            SqlDataReader dr;
            dr = cmd.ExecuteReader();
           // int x = 7, y = 40;
            if (dr.Read())
            {
                MessageBox.Show("Waiter Busy");
            }
            else
                if (Point_Of_Sale.jwaiter1.Text == l.Text)
            {
                l.BackColor = Color.Green;
                l.ImageAlign = ContentAlignment.TopCenter;
                //l.Image = Image.FromFile(@"C:\Users\Muhammad\Downloads\waiter.png");
                Point_Of_Sale.jwaiter1.Text = "";
            }
            else
                    if (Point_Of_Sale.jwaiter1.Text != "")
            {
                MessageBox.Show("Waiter " + Point_Of_Sale.jwaiter1.Text + "  Already Selected");
            }
            else
                        if (l.BackColor == Color.Green)
            {
                l.BackColor = Color.Gray;
                l.ImageAlign = ContentAlignment.TopCenter;
                //l.Image = Image.FromFile(@"C:\Users\Muhammad\Downloads\12.png");
                Point_Of_Sale.jwaiter1.Text = l.Text;
            }
            else
            {
                l.ImageAlign = ContentAlignment.TopCenter;
                // l.Image = Image.FromFile(@"C:\Users\Muhammad\Downloads\waiter.png");
                l.BackColor = Color.Green;
            }
        
        }

        private void JCanCEL_BTN_Click(object sender, EventArgs e)
        {
            if (Point_Of_Sale.jwaiter1.Text == "")
            {
                this.Hide();
            }
            else
            {
                MessageBox.Show("First Un_Select Waiter");
            }
        }

        private void JCONFIRM_BTN_Click(object sender, EventArgs e)
        {
            if (Point_Of_Sale.jwaiter1.Text != "")
            {
                this.Hide();
            }
            else
            {
                MessageBox.Show("Select Waiter");
            }
        }
    }
    }
