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
    public partial class Delivery_Customer : Form
    {
        public Delivery_Customer()
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
                SqlCommand cmd = new SqlCommand("Select* From DeliveryCustomer ", conn);
                SqlDataReader dr;
                dr = cmd.ExecuteReader();

                
                while(dr.Read())
                {

                    String column_getid = dr["Id"].ToString();
                    String column_getname = dr["Name"].ToString();
                    String column_getmobileno = dr["MobileNo"].ToString();
                    String column_getcity = dr["City"].ToString();
                    String column_getaddress = dr["Address"].ToString();

                    jtable.Rows.Add(column_getid, column_getname, column_getmobileno, column_getcity, column_getaddress,"Select");
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error");
            }
        }
//
//Save Btn
//
        private void JSAVEBTN_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Till_Restuarant_Softwear.Properties.Settings.Setting"].ToString());
                conn.Open();
                if (jname.Text == "" || jmobileno.Text == "" || jcity.Text == "" || jaddress.Text == "")
                {
                    MessageBox.Show("All Fields Require");
                }
                else
                {
                    String id = DateTime.Now.ToString("dmyyhms");
                    DialogResult dialogResult = MessageBox.Show("Please Check Detail", "Conform Message", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        //Values Inserted into All_Stock_Record
                        String query = "insert into DeliveryCustomer values (@e,@a,@b,@c,@d)";
                        SqlCommand cmd = new SqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@e", id);
                        cmd.Parameters.AddWithValue("@a", jname.Text);
                        cmd.Parameters.AddWithValue("@b", jmobileno.Text);
                        cmd.Parameters.AddWithValue("@c", jcity.Text);
                        cmd.Parameters.AddWithValue("@d", jaddress.Text);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Register");

                        View();

                        /*try
                        {
                            SqlConnection conn1 = new SqlConnection(ConfigurationManager.ConnectionStrings["Till_Restuarant_Softwear.Properties.Settings.Setting"].ToString());
                            conn1.Open();
                            SqlDataAdapter sqlDA = new SqlDataAdapter("Select* From DeliveryCustomer ", conn1);
                            DataTable dt = new DataTable();
                            sqlDA.Fill(dt);
                            jtable.DataSource = dt;

                            dataGridView1.Rows.Clear();

                            int items = jtable.Rows.Count;
                            int i = 0;
                            while (i < items)
                            {
                                dataGridView1.Rows.Add("Select");
                                i++;
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.ToString(), "Error");
                        }*/

                        jcity.Text = "";
                        jname.Text = "";
                        jmobileno.Text = "";
                        jaddress.Text = "";
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
//
//Reset Btn
//
        private void JRESET_BTN_Click(object sender, EventArgs e)
        {
            jcity.Text = "";
            jname.Text = "";
            jmobileno.Text = "";
            jaddress.Text = "";
        }
//
//Number Validation
//
        private void jmobileno_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(jmobileno.Text, "[^0-9]"))
            {
                jmobileno.Text = jmobileno.Text.Remove(jmobileno.Text.Length - 1);
                MessageBox.Show("Enter Valid Number", "Error");
            }
            else
            {
                if (jmobileno.Text == "")
                {
                    /*try
                    {
                        SqlConnection conn1 = new SqlConnection(ConfigurationManager.ConnectionStrings["Till_Restuarant_Softwear.Properties.Settings.Setting"].ToString());
                        conn1.Open();
                        SqlDataAdapter sqlDA = new SqlDataAdapter("Select* From DeliveryCustomer ", conn1);
                        DataTable dt = new DataTable();
                        sqlDA.Fill(dt);
                        jtable.DataSource = dt;

                        dataGridView1.Rows.Clear();

                        int items = jtable.Rows.Count;
                        int i = 0;
                        while (i < items)
                        {
                            dataGridView1.Rows.Add("Select");
                            i++;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString(), "Error");
                    }*/
                    View();
                }
                else
                {
                    try
                    {
                        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Till_Restuarant_Softwear.Properties.Settings.Setting"].ToString());
                        conn.Open();
                        SqlDataAdapter sqlDA = new SqlDataAdapter("Select* From DeliveryCustomer Where MobileNo like'" + "%" + jmobileno.Text + "%" + "'", conn);
                        DataTable dt = new DataTable();
                        sqlDA.Fill(dt);
                        jtable.DataSource = dt;

                       /* dataGridView1.Rows.Clear();

                        int items = jtable.Rows.Count;
                        int i = 0;
                        while (i < items)
                        {
                            dataGridView1.Rows.Add("Select");
                            i++;
                        }*/
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }

        private void jname_TextChanged(object sender, EventArgs e)
        {
            if (jname.Text == "")
            {
                try
                {
                    /* SqlConnection conn1 = new SqlConnection(ConfigurationManager.ConnectionStrings["Till_Restuarant_Softwear.Properties.Settings.Setting"].ToString());
                     conn1.Open();
                     SqlDataAdapter sqlDA = new SqlDataAdapter("Select* From DeliveryCustomer ", conn1);
                     DataTable dt = new DataTable();
                     sqlDA.Fill(dt);
                     jtable.DataSource = dt;

                     dataGridView1.Rows.Clear();

                     int items = jtable.Rows.Count;
                     int i = 0;
                     while (i < items)
                     {
                         dataGridView1.Rows.Add("Select");
                         i++;
                     }*/
                    View();
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
                    SqlDataAdapter sqlDA = new SqlDataAdapter("Select* From DeliveryCustomer Where Name like'" + "%" + jname.Text + "%" + "'", conn);
                    DataTable dt = new DataTable();
                    sqlDA.Fill(dt);
                    jtable.DataSource = dt;

                    /*dataGridView1.Rows.Clear();

                    int items = jtable.Rows.Count;
                    int i = 0;
                    while (i < items)
                    {
                        dataGridView1.Rows.Add("Select");
                        i++;
                    }*/
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }
//
//Export To Excel
//
        private void JEXPORTTOEXCEL_BTN_Click(object sender, EventArgs e)
        {
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

        private void jtable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = jtable.CurrentCell.RowIndex;
            //get column values
            if (Point_Of_Sale.jcustomerid.Text == "")
            {
                String Column_ID = jtable.Rows[rowIndex].Cells[0].Value.ToString();
                Point_Of_Sale.jcustomerid.Text = Column_ID;

                this.Hide();
            }
            else
            {
                MessageBox.Show("Already Select Customer_ID" + Point_Of_Sale.jcustomerid.Text);
            }
        }
    }
}
