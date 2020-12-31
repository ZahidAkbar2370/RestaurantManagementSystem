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
    public partial class Check_Sales : Form
    {
        public Check_Sales()
        {
            InitializeComponent();

            jstatus.Text = "Sale By Dine-In";
            JDINEIN_BTN.BackColor = Color.Yellow;
            JDINEIN_BTN.ForeColor = Color.Black;
            try
            {
                SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Till_Restuarant_Softwear.Properties.Settings.Setting"].ToString());
                conn.Open();
                SqlDataAdapter sqlDA = new SqlDataAdapter("Select* From Dine_In ", conn);
                DataTable dt = new DataTable();
                sqlDA.Fill(dt);
                dataGridView1.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void JDINEIN_BTN_Click(object sender, EventArgs e)
        {
            jstatus.Text = "Sale By Dine-In";

            JDINEIN_BTN.BackColor = Color.Yellow;
            JTAKEAWAY_BTN.BackColor = Color.DarkOrange;
            JDELIVERY_BTN.BackColor = Color.DarkOrange;

            JDINEIN_BTN.ForeColor = Color.Black;
            JTAKEAWAY_BTN.ForeColor = Color.White;
            JDELIVERY_BTN.ForeColor = Color.White;

            try
            {
                SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Till_Restuarant_Softwear.Properties.Settings.Setting"].ToString());
                conn.Open();
                SqlDataAdapter sqlDA = new SqlDataAdapter("Select* From Dine_In ", conn);
                DataTable dt = new DataTable();
                sqlDA.Fill(dt);
                dataGridView1.DataSource = dt;
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void JTAKEAWAY_BTN_Click(object sender, EventArgs e)
        {
            JDELIVERY_BTN.BackColor = Color.DarkOrange;
            JTAKEAWAY_BTN.BackColor = Color.Yellow;
            JDINEIN_BTN.BackColor = Color.DarkOrange;

            JDELIVERY_BTN.ForeColor = Color.White;
            JTAKEAWAY_BTN.ForeColor = Color.Black;
            JDINEIN_BTN.ForeColor = Color.White;

            jstatus.Text = "Sale By Take-Away";
            try
            {
                SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Till_Restuarant_Softwear.Properties.Settings.Setting"].ToString());
                conn.Open();
                SqlDataAdapter sqlDA = new SqlDataAdapter("Select* From Take_Away ", conn);
                DataTable dt = new DataTable();
                sqlDA.Fill(dt);
                dataGridView1.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void JDELIVERY_BTN_Click(object sender, EventArgs e)
        {
            JDINEIN_BTN.BackColor = Color.DarkOrange;
            JTAKEAWAY_BTN.BackColor = Color.DarkOrange;
            JDELIVERY_BTN.BackColor = Color.Yellow;

            JDINEIN_BTN.ForeColor = Color.White;
            JTAKEAWAY_BTN.ForeColor = Color.White;
            JDELIVERY_BTN.ForeColor = Color.Black;

            jstatus.Text = "Sale By Delivery";
            try
            {
                SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Till_Restuarant_Softwear.Properties.Settings.Setting"].ToString());
                conn.Open();
                SqlDataAdapter sqlDA = new SqlDataAdapter("Select* From Delivery ", conn);
                DataTable dt = new DataTable();
                sqlDA.Fill(dt);
                dataGridView1.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void JCLOSE_BTN_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin_Page set = new Admin_Page();
            set.Show();
            set.BringToFront();
            
        }
//
//Export To Excel
//
        private void JEXPORTTOEXCEL_BTN_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                try
                {
                    Microsoft.Office.Interop.Excel.Application excle = new Microsoft.Office.Interop.Excel.Application();
                    excle.Application.Workbooks.Add(Type.Missing);
                    for (int i = 1; i < dataGridView1.Columns.Count + 1; i++)

                    {
                        excle.Cells[1, i] = dataGridView1.Columns[i - 1].HeaderText;
                    }
                    for (int i = 0; i < dataGridView1.Rows.Count; i++)
                    {
                        for (int j = 0; j < dataGridView1.Columns.Count; j++)
                        {
                            excle.Cells[i + 2, j + 1] = dataGridView1.Rows[i].Cells[j].Value.ToString();
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

        private void BTN_ALLSALE_Click(object sender, EventArgs e)
        {
            JDINEIN_BTN.BackColor = Color.DarkOrange;
            JTAKEAWAY_BTN.BackColor = Color.DarkOrange;
            JDELIVERY_BTN.BackColor = Color.Yellow;

            JDINEIN_BTN.ForeColor = Color.White;
            JTAKEAWAY_BTN.ForeColor = Color.White;
            JDELIVERY_BTN.ForeColor = Color.White;
            BTN_ALLSALE.ForeColor = Color.Black;

            jstatus.Text = "All Sales";
            try
            {
                SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Till_Restuarant_Softwear.Properties.Settings.Setting"].ToString());
                conn.Open();
                SqlDataAdapter sqlDA = new SqlDataAdapter("Select* From All_Sale ", conn);
                DataTable dt = new DataTable();
                sqlDA.Fill(dt);
                dataGridView1.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
