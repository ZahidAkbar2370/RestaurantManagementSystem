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
    public partial class View_Item_Menu : Form
    {
        public static String column_id="ID";
        public static String column_name="";
        public static String column_category = "";
        public static String column_price = "";
        public static String column_mrp = "";
        public static String column_discount = "";
        public View_Item_Menu()
        {
            InitializeComponent();
            View();
        }
        public void RefreshGrid()
        {
            View();
        }
        public void View()
        {
            try
            {
                jdataviewtable.Rows.Clear();

                SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Till_Restuarant_Softwear.Properties.Settings.Setting"].ToString());
                conn.Open();
                SqlCommand cmd = new SqlCommand("Select * from Item_Menu ", conn);
                SqlDataReader dr;
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    String column_getid = dr["ID"].ToString();
                    String column_getname = dr["Name"].ToString();
                    String column_getcategory = dr["Category"].ToString();
                    String column_getprice = dr["Price"].ToString();
                    String column_getmrp = dr["MRP"].ToString();
                    String column_getdiscount = dr["Discount"].ToString();

                    jdataviewtable.Rows.Add(column_getid, column_getname, column_getcategory, column_getprice, column_getmrp, column_getdiscount, "Edit/Delete");
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
//
//Search textBox
//
        private void jsearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (jsearch.Text == "")
                {
                    View();
                }
                else
                {
                    jdataviewtable.Rows.Clear();

                    SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Till_Restuarant_Softwear.Properties.Settings.Setting"].ToString());
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("Select* From Item_Menu Where Name Like'" + "%" + jsearch.Text + "%" + "'", conn);
                    SqlDataReader dr;
                    dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        String column_getid = dr["ID"].ToString();
                        String column_getname = dr["Name"].ToString();
                        String column_getcategory = dr["Category"].ToString();
                        String column_getprice = dr["Price"].ToString();
                        String column_getmrp = dr["MRP"].ToString();
                        String column_getdiscount = dr["Discount"].ToString();

                        jdataviewtable.Rows.Add(column_getid, column_getname, column_getcategory, column_getprice, column_getmrp, column_getdiscount, "Edit/Delete");
                    }
                    conn.Close();
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error");
            }
        }
        private void jdeletetable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {}
//
//Add New Btn
//
        private void JADDNEW_BTN_Click(object sender, EventArgs e)
        {
            column_id = "ID";
            column_name = "";
            column_category = "";
            column_price = "";
            column_mrp = "";
            column_discount = "";

            Add_Item_Menu set = new Add_Item_Menu(this);
            set.Show();
            set.BringToFront();
           
        }

        private void jedittable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
//
//Export To Excel
//
        private void JEXPORTTOEXCLE_BTN_Click(object sender, EventArgs e)
        {
            if (jdataviewtable.Rows.Count > 0)
            {
                try
                {
                    Microsoft.Office.Interop.Excel.Application excle = new Microsoft.Office.Interop.Excel.Application();
                    excle.Application.Workbooks.Add(Type.Missing);
                    for (int i = 1; i < jdataviewtable.Columns.Count + 1; i++)

                    {
                        excle.Cells[1, i] = jdataviewtable.Columns[i - 1].HeaderText;
                    }
                    for (int i = 0; i < jdataviewtable.Rows.Count; i++)
                    {
                        for (int j = 0; j < jdataviewtable.Columns.Count; j++)
                        {
                            excle.Cells[i + 2, j + 1] = jdataviewtable.Rows[i].Cells[j].Value.ToString();
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

        private void JADDSERVICETAX_BTN_Click(object sender, EventArgs e)
        {
            Service_Tax set = new Service_Tax();
            set.Show();
        }
//
// Data View Table Action Perform
//

        private void jdataviewtable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = jdataviewtable.CurrentCell.RowIndex;
            //get column values
            String Column_ID = jdataviewtable.Rows[rowIndex].Cells[0].Value.ToString();
            String Column_Name = jdataviewtable.Rows[rowIndex].Cells[1].Value.ToString();
            String Column_Category = jdataviewtable.Rows[rowIndex].Cells[2].Value.ToString();
            // String Column_SubCategory = jdataviewtable.Rows[rowIndex].Cells[3].Value.ToString();
            String Column_Price = jdataviewtable.Rows[rowIndex].Cells[3].Value.ToString();
            String Column_MRP = jdataviewtable.Rows[rowIndex].Cells[4].Value.ToString();
            String Column_Discount = jdataviewtable.Rows[rowIndex].Cells[5].Value.ToString();

            column_id = Column_ID;
            column_name = Column_Name;
            column_category = Column_Category;
            column_price = Column_Price;
            column_mrp = Column_MRP;
            column_discount = Column_Discount;

            Add_Item_Menu set = new Add_Item_Menu(this);
            set.Show();
            set.BringToFront();
        }
    }
}
