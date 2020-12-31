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
    public partial class Add_Menu_Category : Form
    {
        private readonly View_MenuCategory frm1;
        public Add_Menu_Category(View_MenuCategory frm)
        {
            InitializeComponent();

            frm1 = frm;
        }
//
//Add Btn
//
        private void JADD_BTN_Click(object sender, EventArgs e)
        {
            try
            {
                //SqlConnection conn = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Integrated Security=True");
                SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Till_Restuarant_Softwear.Properties.Settings.Setting"].ToString());
                conn.Open();
                if (jcategory.Text == "")
                {
                    MessageBox.Show("Enter Category");
                }
                else
                {
                    String id = DateTime.Now.ToString("mdyyhms");
                    DialogResult dialogResult = MessageBox.Show("Please Check Detail", "Conform Message", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        //Values Inserted into Vendor
                        String query = "insert into Menu_Category values (@a,@b)";
                        SqlCommand cmd = new SqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@a", id);
                        cmd.Parameters.AddWithValue("@b", jcategory.Text);
                        cmd.ExecuteNonQuery();
                        conn.Close();

                        MessageBox.Show("Data Inserted");
                        frm1.RefreshGrid();

                        jcategory.Text = "";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
//
//Close Btn
//

        private void JBTN_CANCLE_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
