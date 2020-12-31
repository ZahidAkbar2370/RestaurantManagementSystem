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
    public partial class View_User : Form
    {
        public static string column_id="ID";
        public static string column_name="";
        public static string column_contactno = "";
        public static string column_email = "";
        public static string column_status = "";
        public static string column_address = "";
            
        public View_User()
        {
            InitializeComponent();
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
                    String column_getid = dr["ID"].ToString();
                    String column_getname = dr["Name"].ToString();
                    String column_getcontact = dr["ContactNo"].ToString();
                    String column_getemail = dr["Email"].ToString();
                    String column_getstatus = dr["Status"].ToString();
                    String column_getaddress = dr["Address"].ToString();

                    jdataviewtable.Rows.Add(column_getid, column_getname, column_getcontact, column_getemail, column_getstatus, column_getaddress, "Edit/Delete");
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
                if (jsearch.Text != "")
                {
                    /*SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Till_Restuarant_Softwear.Properties.Settings.Setting"].ToString());
                    conn.Open();
                    Sql sqlDA = new SqlDataAdapter(", conn);
                    DataTable dt = new DataTable();
                    sqlDA.Fill(dt);
                    jdataviewtable.DataSource = dt;*/

                    try
                    {
                        jdataviewtable.Rows.Clear();

                        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Till_Restuarant_Softwear.Properties.Settings.Setting"].ToString());
                        conn.Open();
                        SqlCommand cmd = new SqlCommand("Select * From User_Info Where Name Like'" + "%" + jsearch.Text + "%" + "'", conn);
                        SqlDataReader dr;
                        dr = cmd.ExecuteReader();
                        while (dr.Read())
                        {
                            String column_getid = dr["ID"].ToString();
                            String column_getname = dr["Name"].ToString();
                            String column_getcontact = dr["ContactNo"].ToString();
                            String column_getemail = dr["Email"].ToString();
                            String column_getstatus = dr["Status"].ToString();
                            String column_getaddress = dr["Address"].ToString();

                            jdataviewtable.Rows.Add(column_getid, column_getname, column_getcontact, column_getemail, column_getstatus, column_getaddress, "Edit/Delete");
                        }
                        conn.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString(), "Error");
                    }
                }
                else
                {
                    View();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error");
            }
        }
//
//Edit table Coding
//
        public void RefreshGrid()
        {
            View();
        }
        
//
//Add New Button
//
        private void JADDNEW_BTN_Click(object sender, EventArgs e)
        {
            //reset static variable values
            View_User.column_id = "ID";
            View_User.column_name = "";
            View_User.column_email = "";
            View_User.column_address = "";
            View_User.column_contactno = "";
            View_User.column_status = "";

            //add user form open
            Add_User set = new Add_User(this);
            set.Show();
            set.BringToFront();

        }
//
//View Data Table Action PerForm
//

        private void jdataviewtable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            int rowIndex = jdataviewtable.CurrentCell.RowIndex;

            //column data get from table
            String Column_ID = jdataviewtable.Rows[rowIndex].Cells[0].Value.ToString();
            String Column_Name = jdataviewtable.Rows[rowIndex].Cells[1].Value.ToString();
            String Column_ContactNo = jdataviewtable.Rows[rowIndex].Cells[2].Value.ToString();
            String Column_Email = jdataviewtable.Rows[rowIndex].Cells[3].Value.ToString();
            String Column_Status = jdataviewtable.Rows[rowIndex].Cells[4].Value.ToString();
            String Column_Address = jdataviewtable.Rows[rowIndex].Cells[5].Value.ToString();

            //data give to static valiable
            column_id = Column_ID;
            column_name = Column_Name;
            column_contactno = Column_ContactNo;
            column_email = Column_Email;
            column_status = Column_Status;
            column_address = Column_Address;

            //Addn user Form Open
            Add_User set = new Add_User(this);
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

        private void View_User_Load(object sender, EventArgs e)
        {

        }
    }
}
