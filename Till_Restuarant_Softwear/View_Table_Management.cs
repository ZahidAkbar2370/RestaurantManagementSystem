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
    public partial class View_Table_Management : Form
    {
        public static string column_id="ID";
        public static string column_tableno = "";
        public static string column_floorno = "";
        public static string column_status = "Free";
        public View_Table_Management()
        {
            InitializeComponent();
            View();
        }
        public void RefreshGrid()
        {
            View();
        }
//
//Fetch data From database
//
        public void View()
        {
            try
            {            
                jdataviewtable.Rows.Clear();

                SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Till_Restuarant_Softwear.Properties.Settings.Setting"].ToString());
                conn.Open();
                SqlCommand cmd = new SqlCommand("Select * from Table_Manage ", conn);
                SqlDataReader dr;
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    String column_getid = dr["ID"].ToString();
                    String column_gettableno = dr["TableNo"].ToString();
                    String column_getfloorno = dr["FloorNo"].ToString();
                    String column_getstatus = dr["Status"].ToString();
                    

                    jdataviewtable.Rows.Add(column_getid, column_gettableno, column_getfloorno, column_getstatus, "Edit/Delete");
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
            column_tableno = "";
            column_floorno = "";
            column_status = "Free";


            Add_Table set = new Add_Table(this);
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
//Export TO Excel
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
//Data View Table Action Perform
//
        private void jdataviewtable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = jdataviewtable.CurrentCell.RowIndex;
            //get column values
            String Column_ID = jdataviewtable.Rows[rowIndex].Cells[0].Value.ToString();
            String Column_TableNo = jdataviewtable.Rows[rowIndex].Cells[1].Value.ToString();
            String Column_FloorNo = jdataviewtable.Rows[rowIndex].Cells[2].Value.ToString();
            String Column_Status = jdataviewtable.Rows[rowIndex].Cells[3].Value.ToString();

            column_id = Column_ID;
            column_tableno = Column_TableNo;
            column_floorno = Column_FloorNo;
            column_status = Column_Status;

            Add_Table set = new Add_Table(this);
            set.Show();
            set.BringToFront();
        }
    }
}
