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
    public partial class View_Stock : Form
    {
        public static string column_id="ID";
        public static string column_name = "";
        public static string column_quantity = "";
        public static string column_price = "";
        public static string column_expirydate = "";
        public static string column_barcode = "";
        public static string column_purchasedate = "";

        public View_Stock()
        {
            InitializeComponent();
            View();
        }
        public void RefreshGrid()
        {
            View();
        }
//
// View Table
//

        public void View()
        {
            try
            {
                jdataviewtable.Rows.Clear();

                SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Till_Restuarant_Softwear.Properties.Settings.Setting"].ToString());
                conn.Open();
                SqlCommand cmd = new SqlCommand("Select * from Stock ", conn);
                SqlDataReader dr;
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {

                    String column_getid = dr["ID"].ToString();
                    String column_getname = dr["Name"].ToString();
                    String column_getquantity = dr["Quantity"].ToString();
                    String column_getprice = dr["Price"].ToString();
                    String column_getexpirydate = dr["ExpiryDate"].ToString();
                    String column_getbarcode = dr["Barcode"].ToString();
                    String column_getpurchasedate = dr["PurchaseDate"].ToString();

                    jdataviewtable.Rows.Add(column_getid, column_getname, column_getquantity, column_getprice, column_getexpirydate, column_getbarcode, column_getpurchasedate, "Edit/Delete");
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error");
            }
        }
//
//Search Coding
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
                        SqlCommand cmd = new SqlCommand("Select* From Stock Where Name Like'" + "%" + jsearch.Text + "%" + "'", conn);
                        SqlDataReader dr;
                        dr = cmd.ExecuteReader();
                        while (dr.Read())
                        {

                            String column_getid = dr["ID"].ToString();
                            String column_getname = dr["Name"].ToString();
                            String column_getquantity = dr["Quantity"].ToString();
                            String column_getprice = dr["Price"].ToString();
                            String column_getexpirydate = dr["ExpiryDate"].ToString();
                            String column_getbarcode = dr["Barcode"].ToString();
                            String column_getpurchasedate = dr["PurchaseDate"].ToString();

                            jdataviewtable.Rows.Add(column_getid, column_getname, column_getquantity, column_getprice, column_getexpirydate, column_getbarcode, column_getpurchasedate, "Edit/Delete");
                        }
                        conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error");
            }
        }

        private void jedittable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
        private void jdeletetable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }
//
//Add New Btn
//
        private void JADDNEW_BTN_Click(object sender, EventArgs e)
        {
            column_id = "ID";
            column_name = "";
            column_quantity = "";
            column_price = "";
            column_barcode = "";

            Add_Stock set=new Add_Stock(this);
            set.Show();
            set.BringToFront();
        }
//Close Btn
        private void JCLOSE_BTN_Click(object sender, EventArgs e)
        {

            this.Hide();

            Admin_Page set = new Admin_Page();
            set.Show();
            set.BringToFront();
        }
//
//Issue Stock
//
        private void JBTN_ISSUESTOCK_Click(object sender, EventArgs e)
        {
            Issue_Stock set = new Issue_Stock();
            set.Show();
            set.BringToFront();
        }
//
//View Purchase Stock History FOrm
//
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();

            View_Purchase_Stock_History set = new View_Purchase_Stock_History();
            set.Show();
            set.BringToFront();
        }
//
//Export To Exel
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
//
//Data View TAble Action Perform
//

        private void jdataviewtable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            int rowIndex = jdataviewtable.CurrentCell.RowIndex;
            //get column values
            String Column_ID = jdataviewtable.Rows[rowIndex].Cells[0].Value.ToString();
            String Column_Name = jdataviewtable.Rows[rowIndex].Cells[1].Value.ToString();
            String Column_Quantity = jdataviewtable.Rows[rowIndex].Cells[2].Value.ToString();
            String Column_Price = jdataviewtable.Rows[rowIndex].Cells[3].Value.ToString();
            String Column_ExpirayDate = jdataviewtable.Rows[rowIndex].Cells[4].Value.ToString();
            String Column_Barcode = jdataviewtable.Rows[rowIndex].Cells[5].Value.ToString();
            String Column_PurchaseDate = jdataviewtable.Rows[rowIndex].Cells[6].Value.ToString();

            column_id = Column_ID;
            column_name = Column_Name;
            column_quantity = Column_Quantity;
            column_price = Column_Price;
            column_expirydate = Column_ExpirayDate;
            column_barcode = Column_Barcode;
            column_purchasedate = Column_PurchaseDate;

            Add_Stock set = new Add_Stock(this);
            set.Show();
            set.BringToFront();
        }
    }
}
