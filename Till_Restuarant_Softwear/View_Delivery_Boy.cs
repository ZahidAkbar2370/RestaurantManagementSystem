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
    public partial class View_Delivery_Boy : Form
    {
        public static string column_id = "ID";
        public static string column_name = "";
        public static string column_mobileno = "";
        public static string column_address = "";
        public static string column_salary = "";
        public static string column_shift = "";
        public static string column_joindate = "";
        public View_Delivery_Boy()
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
                SqlCommand cmd = new SqlCommand("Select * from Delivery_Boy ", conn);
                SqlDataReader dr;
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    
                    String column_id = dr["ID"].ToString();
                    String column_name = dr["Name"].ToString();
                    String column_mobileno = dr["MobileNo"].ToString();
                    String column_address = dr["Address"].ToString();
                    String column_salary = dr["Salary"].ToString();
                    String column_shift = dr["Shift"].ToString();
                    String column_joindate = dr["JoinDate"].ToString();

                    jdataviewtable.Rows.Add(column_id, column_name, column_mobileno, column_address, column_salary, column_shift,column_joindate, "Edit/Delete");
                }
                conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
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
                    SqlCommand cmd = new SqlCommand("Select* From Delivery_Boy Where Name  Like'" + "%" + jsearch.Text + "%" + "'", conn);
                    SqlDataReader dr;
                    dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {

                        String column_id = dr["ID"].ToString();
                        String column_name = dr["Name"].ToString();
                        String column_mobileno = dr["MobileNo"].ToString();
                        String column_address = dr["Address"].ToString();
                        String column_salary = dr["Salary"].ToString();
                        String column_shift = dr["Shift"].ToString();
                        String column_joindate = dr["JoinDate"].ToString();

                        jdataviewtable.Rows.Add(column_id, column_name, column_mobileno, column_address, column_salary, column_shift, column_joindate, "Edit/Delete");
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
//Add New Btn
//
        private void JADDNEW_BTN_Click(object sender, EventArgs e)
        {
            View_Delivery_Boy.column_id = "ID";
            View_Delivery_Boy.column_name = "";
            View_Delivery_Boy.column_mobileno = "";
            View_Delivery_Boy.column_address = "";
            View_Delivery_Boy.column_salary = "";
            View_Delivery_Boy.column_shift = "";
            Add_Delivery_Boy set = new Add_Delivery_Boy(this);
            set.Show();
            set.BringToFront();
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
// Data Table View Actio Perform
//
        private void jdataviewtable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = jdataviewtable.CurrentCell.RowIndex;

            String Column_ID = jdataviewtable.Rows[rowIndex].Cells[0].Value.ToString();
            String Column_Name = jdataviewtable.Rows[rowIndex].Cells[1].Value.ToString();
            String Column_MobileNo = jdataviewtable.Rows[rowIndex].Cells[2].Value.ToString();
            String Column_Address = jdataviewtable.Rows[rowIndex].Cells[3].Value.ToString();
            String Column_Salary = jdataviewtable.Rows[rowIndex].Cells[4].Value.ToString();
            String Column_Shift = jdataviewtable.Rows[rowIndex].Cells[5].Value.ToString();
            String Column_JoinDate = jdataviewtable.Rows[rowIndex].Cells[6].Value.ToString();

            column_id = Column_ID;
            column_name = Column_Name;
            column_mobileno = Column_MobileNo;
            column_address = Column_Address;
            column_salary = Column_Salary;
            column_shift = Column_Shift;
            column_joindate = Column_JoinDate;

            Add_Delivery_Boy set = new Add_Delivery_Boy(this);
            set.Show();
            set.BringToFront();
        }

        private void View_Delivery_Boy_Load(object sender, EventArgs e)
        {

        }
    }
}
