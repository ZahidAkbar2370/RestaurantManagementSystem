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
    public partial class View_Other_Contact : Form
    {
        public static string column_id="ID";
        public static string column_name = "";
        public static string column_mobileno = "";
        public static string column_description = "";

        public View_Other_Contact()
        {
            InitializeComponent();
            View();
        }
        public void RefreshGrid()
        {
            View();
        }
        //
        //Fetch Values From Database for View
        //
        public void View()
        {
            try
            {
                jdataviewtable.Rows.Clear();

                SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Till_Restuarant_Softwear.Properties.Settings.Setting"].ToString());
                conn.Open();
                SqlCommand cmd = new SqlCommand("Select * from Other_Contact ", conn);
                SqlDataReader dr;
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {                    
                    String column_getid = dr["ID"].ToString();
                    String column_getname = dr["Name"].ToString();
                    String column_getmobileno = dr["MobileNo"].ToString();
                    String column_getdescription = dr["Discription"].ToString();
                       
                    jdataviewtable.Rows.Add(column_getid, column_getname, column_getmobileno, column_getdescription, "Edit/Delete");
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
                    SqlCommand cmd = new SqlCommand("Select* From Other_Contact Where Name Like'" + "%" + jsearch.Text + "%" + "'", conn);
                    SqlDataReader dr;
                    dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        String column_getid = dr["ID"].ToString();
                        String column_getname = dr["Name"].ToString();
                        String column_getmobileno = dr["MobileNo"].ToString();
                        String column_getdescription = dr["Discription"].ToString();

                        jdataviewtable.Rows.Add(column_getid, column_getname, column_getmobileno, column_getdescription, "Edit/Delete");
                    }
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
//
//Delet Table
//
        private void jdeletetable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = jdeletetable.CurrentCell.RowIndex;
            try
            {
                //get ID of selected row from dataGridView
                String Column_ID = jdataviewtable.Rows[rowIndex].Cells[0].Value.ToString();

                DialogResult dialogResult = MessageBox.Show("Do You Want To Delete Contact", "Confirm Message", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Till_Restuarant_Softwear.Properties.Settings.Setting"].ToString());
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("DELETE FROM Other_Contact WHERE ID='" + Column_ID + "'", conn);
                    int dr = cmd.ExecuteNonQuery();

                    //delete from dataGridView
                    jdataviewtable.Rows.RemoveAt(rowIndex);
                    MessageBox.Show("Deleted");


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
//
//Add New Btn
//
        private void JADDNEW_BTN_Click(object sender, EventArgs e)
        {
            column_id = "ID";
            column_name = "";
            column_mobileno = "";
            column_description = "";
            Add_Other_Contact set = new Add_Other_Contact(this);
            set.Show();
            set.BringToFront();

        }

        private void JCLOSE_BTN_Click(object sender, EventArgs e)
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
//Data View Table
//
        private void jdataviewtable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = jdataviewtable.CurrentCell.RowIndex;
            //get column values
            String Column_ID = jdataviewtable.Rows[rowIndex].Cells[0].Value.ToString();
            String Column_Name = jdataviewtable.Rows[rowIndex].Cells[1].Value.ToString();
            String Column_MobileNo = jdataviewtable.Rows[rowIndex].Cells[2].Value.ToString();
            String Column_Description = jdataviewtable.Rows[rowIndex].Cells[3].Value.ToString();

            column_id = Column_ID;
            column_name = Column_Name;
            column_mobileno = Column_MobileNo;
            column_description = Column_Description;

            Add_Other_Contact set = new Add_Other_Contact(this);
            set.Show();
            set.BringToFront();
        }
    }
}
