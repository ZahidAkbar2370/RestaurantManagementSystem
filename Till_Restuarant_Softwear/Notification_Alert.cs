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
    public partial class Notification_Alert : Form
    {
        public Notification_Alert()
        {
            InitializeComponent();
            view();
        }
        public void view()
        {
            lownotificationpanel.BackColor = Color.Gainsboro;
            int x = 20, y = 10;

            try
            {
                SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Till_Restuarant_Softwear.Properties.Settings.Setting"].ToString());
                conn.Open();
                SqlCommand cmd = new SqlCommand("Select Name,Quantity From Stock Where Quantity='" + "1" + "'Or Quantity='" + "2" + "'Or Quantity='" +"0" + "'Or Quantity='" + "3" + "'Or Quantity='" + "4" + "'Or Quantity='" + "5" + "'Or Quantity='" + "6" + "'Or Quantity='" + "7" + "'Or Quantity='" + "8" + "'Or Quantity='" + "9" + "'Or Quantity='" + "10" + "'", conn);
                SqlDataReader dr;
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    label2.Visible = false;
                    Label l = new Label();
                    l.Text = "This  " + "[" + dr["Name"].ToString() + "]  Has  [" + dr["Quantity"].ToString() + "]  Quantities Remaining ";
                    l.Width = 210;
                    l.Height = 40;
                    l.BackColor = Color.White;
                    l.ForeColor = Color.Red;
                    l.Location = new Point(x, y);
                    lownotificationpanel.Controls.Add(l);
                    y += 50;
                }

                try
                {
                    SqlConnection conn1 = new SqlConnection(ConfigurationManager.ConnectionStrings["Till_Restuarant_Softwear.Properties.Settings.Setting"].ToString());
                    conn1.Open();
                    SqlCommand cmd1 = new SqlCommand("Select Name From Stock Where ExpiryDate='" + DateTime.Now.ToString("dd/MM/yyyy") + "'", conn1);
                    SqlDataReader dr1;
                    dr1 = cmd1.ExecuteReader();
                    int y1 = y;
                    while (dr1.Read())
                    {
                        label2.Visible = false;
                        Label l = new Label();
                        l.Text = "This  " + "[" + dr1["Name"].ToString() + "] Is Expired ";
                        l.Width = 210;
                        l.Height = 40;
                        l.BackColor = Color.White;
                        l.ForeColor = Color.Red;
                        l.Location = new Point(x, y);
                        lownotificationpanel.Controls.Add(l);
                        y += 50;
                    }
                }catch(Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void JBTN_CLOSE_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void lownotificationpanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
