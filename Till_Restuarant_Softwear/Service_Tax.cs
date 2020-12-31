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
    public partial class Service_Tax : Form
    {
        public Service_Tax()
        {
            InitializeComponent();
            View();
        }
        public void View()
        {
            try
            {

                SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Till_Restuarant_Softwear.Properties.Settings.Setting"].ToString());
                conn.Open();
                SqlDataAdapter sqlDA = new SqlDataAdapter("Select* From Tax ", conn);
                DataTable dt = new DataTable();
                sqlDA.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }
        private void JSAVEBTN_Click(object sender, EventArgs e)
        {
            try
            {
                if(dataGridView1.Rows.Count>0)
                {
                    SqlConnection conn1 = new SqlConnection(ConfigurationManager.ConnectionStrings["Till_Restuarant_Softwear.Properties.Settings.Setting"].ToString());
                    conn1.Open();
                    SqlCommand cmd1 = new SqlCommand("Update Tax SET ServiceTax='" + jservicetax.Text + "',Type='" + jselecttype.Text + "'",conn1);
                    cmd1.ExecuteNonQuery();

                    jservicetax.Text = "";
                    jselecttype.Text = "";
                    View();
                }
                else
                {
                    String id1 = DateTime.Now.ToString("dMyyhms");

                    SqlConnection conn1 = new SqlConnection(ConfigurationManager.ConnectionStrings["Till_Restuarant_Softwear.Properties.Settings.Setting"].ToString());
                    conn1.Open();
                    SqlCommand cmd1 = new SqlCommand("Insert Into Tax values(@a,@b,@c)", conn1);
                    cmd1.Parameters.AddWithValue("@a", id1);
                    cmd1.Parameters.AddWithValue("@b", jselecttype.Text);
                    cmd1.Parameters.AddWithValue("@c", jservicetax.Text);
                    cmd1.ExecuteNonQuery();

                    jservicetax.Text = "";
                    jselecttype.Text = "";
                    View();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void jselecttype_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(jselecttype.Text== "Persentage Of Sub-Total")
            {
                label1.Text = "Persentage";
            }
            else
            {
                label1.Text = "Service Tax";
            }
        }
    }
}
