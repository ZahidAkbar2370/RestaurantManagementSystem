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
    public partial class View_Customer : Form
    {
        public static string column_id="ID";
        public static string column_name = "";
        public static string column_fathername = "";
        public static string column_contactno = "";
        public static string column_email = "";
        public static string column_address = "";
        public View_Customer()
        {
            InitializeComponent();
            View();
        }

//
// View Data Table
//      
        public void View()
        {
            try
            {
                jdataviewtable.Rows.Clear();

                SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Till_Restuarant_Softwear.Properties.Settings.Setting"].ToString());
                conn.Open();
                SqlCommand cmd = new SqlCommand("Select * from Customer ", conn);
                SqlDataReader dr;
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    String column_id = dr["ID"].ToString();
                    String column_name = dr["Name"].ToString();
                    String column_fathername = dr["FatherName"].ToString();
                    String column_contact = dr["ContactNo"].ToString();
                    String column_email = dr["Email"].ToString();
                    String column_address = dr["Address"].ToString();

                    jdataviewtable.Rows.Add(column_id, column_name, column_fathername, column_contact, column_email, column_address, "Edit/Delete");
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
                    SqlCommand cmd = new SqlCommand("Select* From Customer Where Name Like'" + "%" + jsearch.Text + "%" + "'", conn);
                    SqlDataReader dr;
                    dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        String column_id = dr["ID"].ToString();
                        String column_name = dr["Name"].ToString();
                        String column_fathername = dr["FatherName"].ToString();
                        String column_contact = dr["ContactNo"].ToString();
                        String column_email = dr["Email"].ToString();
                        String column_address = dr["Address"].ToString();

                        jdataviewtable.Rows.Add(column_id, column_name, column_fathername, column_contact, column_email, column_address, "Edit/Delete");
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
            View_Customer.column_id = "ID";
            View_Customer.column_name = "";
            View_Customer.column_fathername = "";
            View_Customer.column_contactno = "";
            View_Customer.column_email = "";
            View_Customer.column_address = "";

            Add_Customer set = new Add_Customer(this);
            set.Show();
            set.BringToFront();
        }

        public void RefreshGrid()
        {
            View();
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
// Data View Table Action Perform
//
        private void jdataviewtable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = jdataviewtable.CurrentCell.RowIndex;

            String Column_ID = jdataviewtable.Rows[rowIndex].Cells[0].Value.ToString();
            String Column_Name = jdataviewtable.Rows[rowIndex].Cells[1].Value.ToString();
            String Column_FatherName = jdataviewtable.Rows[rowIndex].Cells[2].Value.ToString();
            String Column_ContactNo = jdataviewtable.Rows[rowIndex].Cells[3].Value.ToString();
            String Column_Email = jdataviewtable.Rows[rowIndex].Cells[4].Value.ToString();
            String Column_Address = jdataviewtable.Rows[rowIndex].Cells[5].Value.ToString();

            column_id = Column_ID;
             column_name = Column_Name;
            column_fathername = Column_FatherName;
            column_contactno = Column_ContactNo;
            column_email = Column_Email;
            column_address = Column_Address;

            Add_Customer set = new Add_Customer(this);
            set.Show();
            set.BringToFront();
        }
    }
}
