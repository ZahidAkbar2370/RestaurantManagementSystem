using System;using System.Configuration;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Till_Restuarant_Softwear
{
    public partial class View_Vendor_Management : Form
    {
        public static string column_id="ID";
        public static string column_name="";
        public static string column_contactno = "";
        public static string column_mail = "";
        public static string column_bussinessname = "";
        public static string column_address = "";
        public static string column_gstno = "";
        public View_Vendor_Management()
        {
            InitializeComponent();
            View();
        }
        public void RefreshGrid()
        {
            View();
        }
//
//View Data
//
        public void View()
        {
            try
            {
                jdataviewtable.Rows.Clear();

                SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Till_Restuarant_Softwear.Properties.Settings.Setting"].ToString());
                conn.Open();
                SqlCommand cmd = new SqlCommand("Select * from User_Info ", conn);
                SqlDataReader dr;
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    String column_id = dr["ID"].ToString();
                    String column_name = dr["Name"].ToString();
                    String column_contact = dr["ContactNo"].ToString();
                    String column_email = dr["Email"].ToString();
                   // String column_status = dr["BussinessName"].ToString();
                    String column_address = dr["Address"].ToString();
                   // String column_gstnumber= dr["gstnumber"].ToString();

                    jdataviewtable.Rows.Add(column_id, column_name, column_contact, column_email, "", column_address, "Edit/Delete");
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
                    SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Till_Restuarant_Softwear.Properties.Settings.Setting"].ToString());
                    conn.Open();
                    SqlDataAdapter sqlDA = new SqlDataAdapter("Select* From Vendor ", conn);
                    DataTable dt = new DataTable();
                    sqlDA.Fill(dt);
                    jdataviewtable.DataSource = dt;
                }
                else
                {
                    SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Till_Restuarant_Softwear.Properties.Settings.Setting"].ToString());
                    conn.Open();
                    SqlDataAdapter sqlDA = new SqlDataAdapter("Select* From Vendor Where Name Like'" + "%" + jsearch.Text + "%" + "'", conn);
                    DataTable dt = new DataTable();
                    sqlDA.Fill(dt);
                    jdataviewtable.DataSource = dt;
                    
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
            View_Vendor_Management.column_id = "ID";
            View_Vendor_Management.column_name = "";
            View_Vendor_Management.column_contactno = "";
            View_Vendor_Management.column_mail = "";
            View_Vendor_Management.column_bussinessname = "";
            View_Vendor_Management.column_address = "";
            View_Vendor_Management.column_gstno = "";


            Add_Vendor set = new Add_Vendor(this);
            set.Show();
            set.BringToFront();
        }

        private void JCLOSE_BTN_Click(object sender, EventArgs e)
        {
            this.Hide();

           /* Admin_Page set = new Admin_Page();
            set.Show();
            set.BringToFront();*/

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
//View Data Table Action perform
//
        private void jdataviewtable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = jdataviewtable.CurrentCell.RowIndex;
            //get column values
            String Column_ID = jdataviewtable.Rows[rowIndex].Cells[0].Value.ToString();
            String Column_Name = jdataviewtable.Rows[rowIndex].Cells[1].Value.ToString();
            String Column_ContactNo = jdataviewtable.Rows[rowIndex].Cells[2].Value.ToString();
            String Column_Mail = jdataviewtable.Rows[rowIndex].Cells[3].Value.ToString();
            String Column_BussinessName = jdataviewtable.Rows[rowIndex].Cells[4].Value.ToString();
            String Column_Address = jdataviewtable.Rows[rowIndex].Cells[5].Value.ToString();
            String Column_GSTNo = jdataviewtable.Rows[rowIndex].Cells[6].Value.ToString();

            column_id = Column_ID;
            column_name = Column_Name;
            column_contactno = Column_ContactNo;
            column_mail = Column_Mail;
            column_bussinessname = Column_BussinessName;
            column_address = Column_Address;
            column_gstno = Column_GSTNo;

            Add_Vendor set = new Add_Vendor(this);
            set.Show();
            set.BringToFront();
        }
    }
}
