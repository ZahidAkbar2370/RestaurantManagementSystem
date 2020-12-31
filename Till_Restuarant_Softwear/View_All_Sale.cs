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
    public partial class View_All_Sale : Form
    {
        public View_All_Sale()
        {
            InitializeComponent();
            takeawar();
        }
        public void takeawar()
        {
            jstatus.Text = "Take_Away";
            try
            {
                String date = DateTime.Now.ToString("dd/MM/yyyy");

               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
//
//Search Sale By Invoice
//
        private void jsearchbyinvoice_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (jsearchbyinvoice.Text != "")
                {
                    if (jstatus.Text == "Take_Away")
                    {
                        String date = DateTime.Now.ToString("dd/MM/yyyy");
                        if (jsearchbyinvoice.Text == "")
                        {
                            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Till_Restuarant_Softwear.Properties.Settings.Setting"].ToString());
                            conn.Open();
                            SqlDataAdapter sqlDA = new SqlDataAdapter("Select* From Take_Away Where Date='" + date + "'", conn);
                            DataTable dt = new DataTable();
                            sqlDA.Fill(dt);
                            jtable.DataSource = dt;
                        }
                        else
                        {
                            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Till_Restuarant_Softwear.Properties.Settings.Setting"].ToString());
                            conn.Open();
                            SqlDataAdapter sqlDA = new SqlDataAdapter("Select* From Take_Away Where InvoiceNo='" + jsearchbyinvoice.Text + "'Date='" + date + "'", conn);
                            DataTable dt = new DataTable();
                            sqlDA.Fill(dt);
                            jtable.DataSource = dt;
                        }
                    }
                    else
                    if (jstatus.Text == "Dine_In")
                    {
                        String date = DateTime.Now.ToString("dd/MM/yyyy");
                        if (jsearchbyinvoice.Text == "")
                        {
                            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Till_Restuarant_Softwear.Properties.Settings.Setting"].ToString());
                            conn.Open();
                            SqlDataAdapter sqlDA = new SqlDataAdapter("Select* From Dine_In Where Date='" + date + "'", conn);
                            DataTable dt = new DataTable();
                            sqlDA.Fill(dt);
                            jtable.DataSource = dt;
                        }
                        else
                        {
                            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Till_Restuarant_Softwear.Properties.Settings.Setting"].ToString());
                            conn.Open();
                            SqlDataAdapter sqlDA = new SqlDataAdapter("Select* From Dine_In Where InvoiceNo='" + jsearchbyinvoice.Text + "'Date='" + date + "'", conn);
                            DataTable dt = new DataTable();
                            sqlDA.Fill(dt);
                            jtable.DataSource = dt;
                        }
                    }
                    else
                    if (jstatus.Text == "Delivery")
                    {
                        String date = DateTime.Now.ToString("dd/MM/yyyy");
                        if (jsearchbyinvoice.Text == "")
                        {
                            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Till_Restuarant_Softwear.Properties.Settings.Setting"].ToString());
                            conn.Open();
                            SqlDataAdapter sqlDA = new SqlDataAdapter("Select* From Delivery Where Date='"+date+"'", conn);
                            DataTable dt = new DataTable();
                            sqlDA.Fill(dt);
                            jtable.DataSource = dt;
                        }
                        else
                        {
                            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Till_Restuarant_Softwear.Properties.Settings.Setting"].ToString());
                            conn.Open();
                            SqlDataAdapter sqlDA = new SqlDataAdapter("Select* From Delivery Where InvoiceNo='" + jsearchbyinvoice.Text+"'Date='"+date + "'", conn);
                            DataTable dt = new DataTable();
                            sqlDA.Fill(dt);
                            jtable.DataSource = dt;
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
//Today Sale Btn
//
        private void JTODAYSALE_BTN_Click(object sender, EventArgs e)
        {
        }

        private void TODAYSALEBYTAKEAWAY_BTn_Click(object sender, EventArgs e)
        {
            jstatus.Text = "Take_Away";
            try
            {
                String date = DateTime.Now.ToString("dd/MM/yyyy");

                SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Till_Restuarant_Softwear.Properties.Settings.Setting"].ToString());
                conn.Open();
                SqlDataAdapter sqlDA = new SqlDataAdapter("Select* From Take_Away Where Date ='" + date + "'", conn);
                DataTable dt = new DataTable();
                sqlDA.Fill(dt);
                jtable.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void TODAYSALEBYDINEIN_BTN_Click(object sender, EventArgs e)
        {
            jstatus.Text = "Dine_In";
            try
            {
                String date = DateTime.Now.ToString("dd/MM/yyyy");

                SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Till_Restuarant_Softwear.Properties.Settings.Setting"].ToString());
                conn.Open();
                SqlDataAdapter sqlDA = new SqlDataAdapter("Select* From Dine_In Where Date ='" + date + "'", conn);
                DataTable dt = new DataTable();
                sqlDA.Fill(dt);
                jtable.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void JTODAYSALEBY_DELIVERYBTN_Click(object sender, EventArgs e)
        {
            jstatus.Text = "Delivery";
            try
            {
                String date = DateTime.Now.ToString("dd/MM/yyyy");
                SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Till_Restuarant_Softwear.Properties.Settings.Setting"].ToString());
                conn.Open();
                SqlDataAdapter sqlDA = new SqlDataAdapter("Select* From Delivery Where Date ='" + date + "'", conn);
                DataTable dt = new DataTable();
                sqlDA.Fill(dt);
                jtable.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
//
//Export To Excel
//
        private void JEXPORTTOEXCLE_BTN_Click(object sender, EventArgs e)
        {
            /*   if (jtable.Rows.Count > 0)
               {
                   Microsoft.Office.Interop.Excel.Application excle = new Microsoft.Office.Interop.Excel.Application();
                   excle.Application.Workbooks.Add(Type.Missing);
                   for (int i = 0; i < jtable.Columns.Count; i++)

                   {
                       excle.Cells[1, i] = jtable.Columns[i - 1].HeaderText;
                   }
                   for (int i = 1; i < jtable.Rows.Count; i++)
                   {
                       for (int j = 0; j < jtable.Columns.Count; j++)
                       {
                           excle.Cells[i + 2, j + 1] = jtable.Rows[i].Cells[j].Value.ToString();
                       }
                   }
                   excle.Columns.AutoFit();
                   excle.Visible = true;
               }*/
            if (jtable.Rows.Count > 0)
            {
                try
                {
                    Microsoft.Office.Interop.Excel.Application excle = new Microsoft.Office.Interop.Excel.Application();
                    excle.Application.Workbooks.Add(Type.Missing);
                    for (int i = 1; i < jtable.Columns.Count + 1; i++)

                    {
                        excle.Cells[1, i] = jtable.Columns[i - 1].HeaderText;
                    }
                    for (int i = 0; i < jtable.Rows.Count; i++)
                    {
                        for (int j = 0; j < jtable.Columns.Count; j++)
                        {
                            excle.Cells[i + 2, j + 1] = jtable.Rows[i].Cells[j].Value.ToString();
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
    }
}
