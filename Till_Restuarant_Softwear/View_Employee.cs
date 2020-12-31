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
    public partial class View_Employee : Form
    {
        public static string column_id="ID";
        public static string column_name = "";
        public static string column_contactno = "";
        public static string column_email = "";
        public static string column_status = "";
        public static string column_address = "";
        public static string column_shift = "";
        public static string column_salary = "";
        public static string column_joindate = "";
        public View_Employee()
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
                SqlCommand cmd = new SqlCommand("Select * from Employee ", conn);
                SqlDataReader dr;
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    String column_getid = dr["ID"].ToString();
                    String column_getname = dr["Name"].ToString();
                    String column_getcontactno = dr["ContactNo"].ToString();
                    String column_getemail = dr["Email"].ToString();
                    String column_getstatus = dr["Status"].ToString();
                    String column_getaddress = dr["Address"].ToString();
                    String column_getshift = dr["Shift"].ToString();
                    String column_getsalary = dr["Salary"].ToString();
                    String column_getjoindate = dr["JoinDate"].ToString();

                    jdataviewtable.Rows.Add(column_getid, column_getname, column_getcontactno, column_getemail, column_getstatus, column_getaddress, column_getshift, column_getsalary, column_getjoindate, "Edit/Delete");
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
                    SqlCommand cmd = new SqlCommand("Select* From Employee Where Name Like'" + "%" + jsearch.Text + "%" + "'", conn);
                    SqlDataReader dr;
                    dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        String column_getid = dr["ID"].ToString();
                        String column_getname = dr["Name"].ToString();
                        String column_getcontactno = dr["ContactNo"].ToString();
                        String column_getemail = dr["Email"].ToString();
                        String column_getstatus = dr["Status"].ToString();
                        String column_getaddress = dr["Address"].ToString();
                        String column_getshift = dr["Shift"].ToString();
                        String column_getsalary = dr["Salary"].ToString();
                        String column_getjoindate = dr["JoinDate"].ToString();

                        jdataviewtable.Rows.Add(column_getid, column_getname, column_getcontactno, column_getemail, column_getstatus, column_getaddress, column_getshift, column_getsalary, column_getjoindate, "Edit/Delete");
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
            column_email = "";
            column_address = "";
            column_contactno = "";
            column_status = "";
            column_salary = "";
            column_shift = "";

            Add_Employee set = new Add_Employee(this);
            set.Show();
            set.BringToFront();

            
        }

//
//Data Table View Action Perform
//
        private void jdataviewtable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = jdataviewtable.CurrentCell.RowIndex;
            //get column values
            String Column_ID = jdataviewtable.Rows[rowIndex].Cells[0].Value.ToString();
            String Column_Name = jdataviewtable.Rows[rowIndex].Cells[1].Value.ToString();
            String Column_ContactNo = jdataviewtable.Rows[rowIndex].Cells[2].Value.ToString();
            String Column_Email = jdataviewtable.Rows[rowIndex].Cells[3].Value.ToString();
            String Column_Status = jdataviewtable.Rows[rowIndex].Cells[4].Value.ToString();
            String Column_Address = jdataviewtable.Rows[rowIndex].Cells[5].Value.ToString();
            String Column_Shift = jdataviewtable.Rows[rowIndex].Cells[6].Value.ToString();
            String Column_Salary = jdataviewtable.Rows[rowIndex].Cells[7].Value.ToString();
            String Column_JoinDate = jdataviewtable.Rows[rowIndex].Cells[8].Value.ToString();

            column_id = Column_ID;
            column_name = Column_Name;
            column_contactno = Column_ContactNo;
            column_email = Column_Email;
            column_status = Column_Status;
            column_address = Column_Address;
            column_shift = Column_Shift;
            column_salary = Column_Salary;
            column_joindate = Column_JoinDate;

            Add_Employee set = new Add_Employee(this);
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

        private void View_Employee_Load(object sender, EventArgs e)
        {

        }
    }
}
