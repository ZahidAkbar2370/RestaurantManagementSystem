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
    public partial class Add_Item_Menu : Form
    {
        private readonly View_Item_Menu frm1; //readonly is optional (For safety purposes)

        public Add_Item_Menu(View_Item_Menu frm)
        {
            InitializeComponent();
            frm1 = frm;
            SetValues();
            View();
        }
        public void View()
        {
           try
            {
                //SqlConnection conn = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Integrated Security=True");
                SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Till_Restuarant_Softwear.Properties.Settings.Setting"].ToString());
                conn.Open();
                SqlDataAdapter sqlDA = new SqlDataAdapter("Select* From Menu_Category ", conn);
                DataTable dt = new DataTable();
                sqlDA.Fill(dt);
                jcategory.DataSource = dt;
                jcategory.DisplayMember = "Category";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error");
            }
        }
        public void SetValues()
        {
            jid.Text = View_Item_Menu.column_id;
            jname.Text = View_Item_Menu.column_name;
            jcategory.Text = View_Item_Menu.column_category;
            jprice.Text = View_Item_Menu.column_price;
            jdiscount.Text = View_Item_Menu.column_discount;
            jmrp.Text = View_Item_Menu.column_mrp;
        }
        //
        //Add Btn
        //
        private void JADD_BTN_Click(object sender, EventArgs e)
        {
            if(jid.Text == "ID")
            {
                try
                {
                    SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Till_Restuarant_Softwear.Properties.Settings.Setting"].ToString());
                    //SqlConnection conn = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Integrated Security=True");
                    conn.Open();
                    if ( jname.Text == "" || jcategory.Text == "" || jprice.Text == ""  || jdiscount.Text == "")
                    {
                        MessageBox.Show("All Fields Required");
                    }
                    else
                    {
                        String id = DateTime.Now.ToString("mdyyhms");

                        DialogResult dialogResult = MessageBox.Show("Please Check Detail", "Conform Message", MessageBoxButtons.YesNo);
                        if (dialogResult == DialogResult.Yes)
                        {
                            //Values Inserted into Vendor
                            String query = "insert into Item_Menu values (@a,@b,@c,@e,@f,@g)";
                            SqlCommand cmd = new SqlCommand(query, conn);
                            cmd.Parameters.AddWithValue("@a", id);
                            cmd.Parameters.AddWithValue("@b", jname.Text);
                            cmd.Parameters.AddWithValue("@c", jcategory.Text);
                            cmd.Parameters.AddWithValue("@e", jprice.Text);
                            cmd.Parameters.AddWithValue("@f", jmrp.Text);
                            cmd.Parameters.AddWithValue("@g", jdiscount.Text);
                            cmd.ExecuteNonQuery();
                            conn.Close();

                            frm1.RefreshGrid();
                            //Reset
                            jid.Text="ID";
                            jname.Text = "";
                            jcategory.Text = "";
                            jprice.Text = "";
                            jmrp.Text = "";
                            jdiscount.Text = "";

                            View();
                            View_Item_Menu.column_id = "ID";
                            View_Item_Menu.column_name = "";
                            View_Item_Menu.column_category = "";
                            View_Item_Menu.column_price = "";
                            View_Item_Menu.column_mrp = "";
                            View_Item_Menu.column_discount = "";
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }
//
//Form Load
//
        private void Add_Item_Menu_Load(object sender, EventArgs e)
        {

        }
//
//Update Btn
//
        private void UPDATE_JBTN_Click(object sender, EventArgs e)
        {
            if (jid.Text != "ID")
            {
                try
                {
                    SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Till_Restuarant_Softwear.Properties.Settings.Setting"].ToString());
                    //SqlConnection conn = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Integrated Security=True");
                    conn.Open();
                    String query = "UPDATE Item_Menu SET Name='" + jname.Text + "',Category='" + jcategory.Text  + "',Price='" + jprice.Text + "',MRP='" + jmrp.Text + "',Discount='" + jdiscount.Text + "'WHERE ID='" + jid.Text + "'";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Updated");
                    frm1.RefreshGrid();

                    jid.Text = "ID";
                    jname.Text = "";
                    jcategory.Text = "";
                    jprice.Text = "";
                    jmrp.Text = "";
                    jdiscount.Text = "";

                    View();

                    View_Item_Menu.column_id = "ID";
                    View_Item_Menu.column_name = "";
                    View_Item_Menu.column_category = "";
                    View_Item_Menu.column_price = "";
                    View_Item_Menu.column_mrp = "";
                    View_Item_Menu.column_discount = "";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }
//
//Reset Btn
//
        private void button1_Click(object sender, EventArgs e)
        {
            jid.Text = "ID";
            jname.Text = "";
            jcategory.Text = "";
            jprice.Text = "";
            jmrp.Text = "";
            jdiscount.Text = "";

            View_Item_Menu.column_id = "ID";
            View_Item_Menu.column_name = "";
            View_Item_Menu.column_category = "";
            View_Item_Menu.column_price = "";
            View_Item_Menu.column_mrp = "";
            View_Item_Menu.column_discount = "";
        }
//
//Close Btn
//
        private void JBTN_CLOSE_Click(object sender, EventArgs e)
        {
            this.Close();
            View_Item_Menu.column_id = "ID";
            View_Item_Menu.column_name = "";
            View_Item_Menu.column_category = "";
            View_Item_Menu.column_price = "";
            View_Item_Menu.column_mrp = "";
            View_Item_Menu.column_discount = "";
        }
//
//Only Number Enter Validation
//
        private void jprice_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(jprice.Text, "^[a-zA-Z ]"))
            {
                jprice.Text = jprice.Text.Remove(jprice.Text.Length - 1);
                MessageBox.Show("Please Enter Only Number");
            }
        }
//
//Only number Validation
//
        private void jdiscount_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(jdiscount.Text, "[^0-9]"))
            {
                jdiscount.Text = jdiscount.Text.Remove(jdiscount.Text.Length - 1);
            }

        }
//
//Add Category Run Time
//
        private void JADDCATEGORY_Click(object sender, EventArgs e)
        {
            this.Hide();

            View_MenuCategory set = new View_MenuCategory();
            set.Show();
            set.BringToFront();
        }

//
//Delete BTN
//

        private void jdelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (jid.Text != "ID")
                {
                    SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Till_Restuarant_Softwear.Properties.Settings.Setting"].ToString());
                    //SqlConnection conn = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Integrated Security=True");
                    conn.Open();
                    String query = "Delete Item_Menu WHERE ID='" + jid.Text + "'";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Deleted");
                    frm1.RefreshGrid();

                    jid.Text = "ID";
                    jname.Text = "";
                    jcategory.Text = "";
                    jprice.Text = "";
                    jmrp.Text = "";
                    jdiscount.Text = "";

                    View();

                    View_Item_Menu.column_id = "ID";
                    View_Item_Menu.column_name = "";
                    View_Item_Menu.column_category = "";
                    View_Item_Menu.column_price = "";
                    View_Item_Menu.column_mrp = "";
                    View_Item_Menu.column_discount = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
