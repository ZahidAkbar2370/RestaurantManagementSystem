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
    public partial class View_Expenses_Tracking : Form
    {
        public static string column_id = "ID";
        public static string column_amount = "";
        public static string column_category = "";
        public static string column_description = "";

        public View_Expenses_Tracking()
        {
            InitializeComponent();

            View();

            TodayExpenses();
            ThisMonthExpenses();
            ThisYearExpenses();
            TotalExpenses();
        }
        public void RefreshGrid()
        {
            View();
            jprice.Text = "00";
            jprice1.Text = "00";
            jprice2.Text = "00";
            jprice3.Text = "00";

            TodayExpenses();
            ThisMonthExpenses();
            ThisYearExpenses();
            TotalExpenses();
        }
        public void View()
        {
            try
            {
                jdataviewtable.Rows.Clear();

                SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Till_Restuarant_Softwear.Properties.Settings.Setting"].ToString());
                conn.Open();
                SqlCommand cmd = new SqlCommand("Select * from Expenses ", conn);
                SqlDataReader dr;
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    
                    String column_id = dr["ID"].ToString();
                    String column_description = dr["Discription"].ToString();
                    String column_amount = dr["Amount"].ToString();
                    String column_date = dr["Date"].ToString();
                    String column_category = dr["Category"].ToString();
                    String column_month = dr["Month"].ToString();
                    String column_year = dr["Year"].ToString();

                    jdataviewtable.Rows.Add(column_id, column_description, column_amount, column_date, column_category, column_month, column_year, "Edit/Delete");
                }
                conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        //
        //Today Expense Calculate
        //
        public void TodayExpenses()
        {
            try
            {
                String todayDate = DateTime.Now.ToString("dd/MM/yyyy");
                SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Till_Restuarant_Softwear.Properties.Settings.Setting"].ToString());
                conn.Open();
                SqlCommand cmd = new SqlCommand("Select Amount From Expenses Where Date='" + todayDate + "'", conn);
                SqlDataReader dr;
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Double getAmount = Convert.ToDouble(dr["Amount"].ToString());
                    Double price = Convert.ToDouble(jprice.Text);
                    Double total = getAmount + price;
                    String t1 = Convert.ToString(total);
                    jprice.Text = t1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }


        //
        //This Month Expense Calculate
        //
        public void ThisMonthExpenses()
        {
            try
            {
                String thisMonth = DateTime.Now.ToString("MM/yyyy");
                SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Till_Restuarant_Softwear.Properties.Settings.Setting"].ToString());
                conn.Open();
                SqlCommand cmd = new SqlCommand("Select Amount From Expenses Where Month='" + thisMonth + "'", conn);
                SqlDataReader dr;
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Double getAmount = Convert.ToDouble(dr["Amount"].ToString());
                    Double price = Convert.ToDouble(jprice1.Text);
                    Double total = getAmount + price;
                    String t1 = Convert.ToString(total);
                    jprice1.Text = t1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        //
        //ThisYear Expense Calculate
        //
        public void ThisYearExpenses()
        {
            try
            {
                String thisYear = DateTime.Now.ToString("yyyy");
                SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Till_Restuarant_Softwear.Properties.Settings.Setting"].ToString());
                conn.Open();
                SqlCommand cmd = new SqlCommand("Select Amount From Expenses Where Year='" + thisYear + "'", conn);
                SqlDataReader dr;
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Double getAmount = Convert.ToDouble(dr["Amount"].ToString());
                    Double price = Convert.ToDouble(jprice2.Text);
                    Double total = getAmount + price;
                    String t1 = Convert.ToString(total);
                    jprice2.Text = t1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        //
        //Total Expense Calculate
        //
        public void TotalExpenses()
        {
            try
            {
                SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Till_Restuarant_Softwear.Properties.Settings.Setting"].ToString());
                conn.Open();
                SqlCommand cmd = new SqlCommand("Select Amount From Expenses", conn);
                SqlDataReader dr;
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Double getAmount = Convert.ToDouble(dr["Amount"].ToString());
                    Double price = Convert.ToDouble(jprice3.Text);
                    Double total = getAmount + price;
                    String t1 = Convert.ToString(total);
                    jprice3.Text = t1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }
//
//Add New Btn
//
        private void JADDNEW_BTN_Click(object sender, EventArgs e)
        {
            column_id = "ID";
            column_amount = "";
            column_category = "";
            column_description = "";

            Add_Expenses_Tracking set = new Add_Expenses_Tracking(this);
            set.Show();
            set.BringToFront();
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
                    SqlCommand cmd = new SqlCommand("Select* From Expenses Where Discription Like'" + "%" + jsearch.Text + "%" + "'", conn);
                    SqlDataReader dr;
                    dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {

                        String column_id = dr["ID"].ToString();
                        String column_description = dr["Discription"].ToString();
                        String column_amount = dr["Amount"].ToString();
                        String column_date = dr["Date"].ToString();
                        String column_category = dr["Category"].ToString();
                        String column_month = dr["Month"].ToString();
                        String column_year = dr["Year"].ToString();

                        jdataviewtable.Rows.Add(column_id, column_description, column_amount, column_date, column_category, column_month, column_year, "Edit/Delete");
                    }
                    conn.Close();
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void jedittable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void jdeletetable_CellContentClick(object sender, DataGridViewCellEventArgs e)
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
//
//Data View Table Perform Action
//
        private void jdataviewtable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = jdataviewtable.CurrentCell.RowIndex;
            //get column values
            String Column_ID = jdataviewtable.Rows[rowIndex].Cells[0].Value.ToString();
            String Column_Discription = jdataviewtable.Rows[rowIndex].Cells[1].Value.ToString();
            String Column_Amount = jdataviewtable.Rows[rowIndex].Cells[2].Value.ToString();
            String Column_Category = jdataviewtable.Rows[rowIndex].Cells[4].Value.ToString();

            column_id = Column_ID;
            column_amount = Column_Amount;
            column_category = Column_Category;
            column_description = Column_Discription;

            Add_Expenses_Tracking set = new Add_Expenses_Tracking(this);
            set.Show();
            set.BringToFront();
        }
    }
}
