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
    public partial class Issue_Stock : Form
    {
        public Issue_Stock()
        {
            InitializeComponent();
            View();
            View1();
            View2();
        }
//
//Fetch Employee Name
//
        public void View()
        {
            try
            {
               SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Till_Restuarant_Softwear.Properties.Settings.Setting"].ToString());
                conn.Open();
                SqlDataAdapter sqlDA = new SqlDataAdapter("Select* From Employee ", conn);
                DataTable dt = new DataTable();
                sqlDA.Fill(dt);
                jselectemployee.DataSource = dt;
                jselectemployee.DisplayMember = "Name";
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
//
//Fetch Stock Name
//
        public void View1()
        {
            try
            {
                SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Till_Restuarant_Softwear.Properties.Settings.Setting"].ToString());
                conn.Open();
                SqlDataAdapter sqlDA = new SqlDataAdapter("Select* From Stock ", conn);
                DataTable dt = new DataTable();
                sqlDA.Fill(dt);
                jselectproduct.DataSource = dt;
                jselectproduct.DisplayMember = "Name";
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
//
//Fetch Issue Stock
//
        public void View2()
        {
            try
            {
               // SqlConnection conn = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Integrated Security=True");
                SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Till_Restuarant_Softwear.Properties.Settings.Setting"].ToString());
                conn.Open();
                SqlDataAdapter sqlDA = new SqlDataAdapter("Select* From Issue_Stock ", conn);
                DataTable dt = new DataTable();
                sqlDA.Fill(dt);
                dataGridView1.DataSource = dt;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
//
//Number Validation
//
        private void jissuequantity_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(jissuequantity.Text, "[^0-9]"))
            {
                jissuequantity.Text = jissuequantity.Text.Remove(jissuequantity.Text.Length - 1);
                MessageBox.Show("Enter Valid Number", "Error");
            }
        }

        private void JIssueBTN_Click(object sender, EventArgs e)
        {
            if (jissuequantity.Text == "" || jissuequantity.Text == "0")
            {
                MessageBox.Show("Please Enter Quantity");
            }
            else
            {
                try
                {
                    String date = DateTime.Now.ToString("dd/MM/yyyy");

                    SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Till_Restuarant_Softwear.Properties.Settings.Setting"].ToString());
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("Select * from Stock Where Name='" + jselectproduct.Text + "'", conn);
                    SqlDataReader dr;
                    dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        String quantity = dr["Quantity"].ToString();
                        int quantityI = Convert.ToInt32(quantity);
                        int issueQuantity = Convert.ToInt32(jissuequantity.Text);

                        if (quantityI >= issueQuantity)
                        {
                            int remQuantity = quantityI - issueQuantity;
                            conn.Close();

                            SqlConnection conn1 = new SqlConnection(ConfigurationManager.ConnectionStrings["Till_Restuarant_Softwear.Properties.Settings.Setting"].ToString());
                            conn1.Open();
                            SqlCommand cmd1 = new SqlCommand("UPDATE Stock SET Quantity='" + remQuantity.ToString() + "'Where Name='" + jselectproduct.Text + "'", conn1);
                            cmd1.ExecuteNonQuery();
                            conn1.Close();

                            MessageBox.Show("Issued");

                            String id = DateTime.Now.ToString("dMyyhms");
                            conn1.Open();
                            SqlCommand cmd2 = new SqlCommand("Insert Into Issue_Stock values(@a,@b,@c,@d,@e)", conn1);
                            cmd2.Parameters.AddWithValue("@a", id);
                            cmd2.Parameters.AddWithValue("@b", jselectproduct.Text);
                            cmd2.Parameters.AddWithValue("@c", jselectemployee.Text);
                            cmd2.Parameters.AddWithValue("@d", jissuequantity.Text);
                            cmd2.Parameters.AddWithValue("@e", date);
                            cmd2.ExecuteNonQuery();
                            conn1.Close();

                            try
                            {
                                SqlConnection conn2 = new SqlConnection(ConfigurationManager.ConnectionStrings["Till_Restuarant_Softwear.Properties.Settings.Setting"].ToString());
                                conn2.Open();
                                SqlDataAdapter sqlDA = new SqlDataAdapter("Select* From Issue_Stock ", conn2);
                                DataTable dt = new DataTable();
                                sqlDA.Fill(dt);
                                dataGridView1.DataSource = dt;
                                conn2.Close();


                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.ToString());
                            }

                        }
                        else
                        {
                            MessageBox.Show("Product Has Stock" + quantity);

                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }
//
//Close Btn
//
        private void JBTN_CLOSE_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
//
//Export To Excel
//
        private void JEXPORTTOEXCLE_BTN_Click(object sender, EventArgs e)
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
        
        private void JBARCODESCANNER_START_BTN_Click(object sender, EventArgs e)
        {
            
        }

        private void jbarcode_TextChanged(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Till_Restuarant_Softwear.Properties.Settings.Setting"].ToString());
                conn.Open();
                SqlCommand cmd = new SqlCommand("Select * from Stock Where Barcode='" + jbarcode.Text + "'", conn);
                SqlDataReader dr;
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    jselectproduct.Text = dr["Name"].ToString();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
