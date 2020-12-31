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
    public partial class View_Purchase_Stock_History : Form
    {
        public View_Purchase_Stock_History()
        {
            InitializeComponent();
            View();
        }
        public void View()
        {
            try
            {
                SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Till_Restuarant_Softwear.Properties.Settings.Setting"].ToString());
                conn.Open();
                SqlDataAdapter sqlDA = new SqlDataAdapter("Select* From Purchase_Stock ", conn);
                DataTable dt = new DataTable();
                sqlDA.Fill(dt);
                dataGridView1.DataSource = dt;
                
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void JBTN_CANCLE_Click(object sender, EventArgs e)
        {
            this.Hide();

            View_Stock set = new View_Stock();
            set.Show();
            set.BringToFront();
        }

        private void JSEARCH_BTn_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Till_Restuarant_Softwear.Properties.Settings.Setting"].ToString());
                conn.Open();
                SqlDataAdapter sqlDA = new SqlDataAdapter("Select* From Purchase_Stock Where PurchaseDate Between '"+dateFrom.Text.ToString()+"'and'"+dateTo.Text+"'", conn);
                DataTable dt = new DataTable();
                sqlDA.Fill(dt);
                dataGridView1.DataSource = dt;

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void JHISTORY_BTN_Click(object sender, EventArgs e)
        {
            View();
        }

        private void View_Purchase_Stock_History_Load(object sender, EventArgs e)
        {

        }
//
//Export To Excel
//
        private void JEXPORTTOEXCLE_BTN_Click(object sender, EventArgs e)
        {
            /*if (dataGridView1.Rows.Count > 0)
            {
                Microsoft.Office.Interop.Excel.Application excle = new Microsoft.Office.Interop.Excel.Application();
                excle.Application.Workbooks.Add(Type.Missing);
                for (int i = 0; i < dataGridView1.Columns.Count; i++)

                {
                    excle.Cells[1, i] = dataGridView1.Columns[i - 1].HeaderText;
                }
                for (int i = 1; i < dataGridView1.Rows.Count; i++)
                {
                    for (int j = 0; j < dataGridView1.Columns.Count; j++)
                    {
                        excle.Cells[i + 2, j + 1] = dataGridView1.Rows[i].Cells[j].Value.ToString();
                    }
                }
                excle.Columns.AutoFit();
                excle.Visible = true;
            }*/
            if (dataGridView1.Rows.Count > 0)
            {
                try
                {
                    Microsoft.Office.Interop.Excel.Application excle = new Microsoft.Office.Interop.Excel.Application();
                    excle.Application.Workbooks.Add(Type.Missing);
                    for (int i = 1; i < dataGridView1.Columns.Count + 1; i++)

                    {
                        excle.Cells[1, i] = dataGridView1.Columns[i - 1].HeaderText;
                    }
                    for (int i = 0; i < dataGridView1.Rows.Count; i++)
                    {
                        for (int j = 0; j < dataGridView1.Columns.Count; j++)
                        {
                            excle.Cells[i + 2, j + 1] = dataGridView1.Rows[i].Cells[j].Value.ToString();
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
    }
}
