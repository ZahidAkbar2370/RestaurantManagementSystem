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
    public partial class Add_Stock : Form
    {
        private readonly View_Stock frm1;
        public Add_Stock(View_Stock frm)
        {
            InitializeComponent();
            SetValues();

            frm1 = frm;
        }
        public void SetValues()
        {
            jid.Text=View_Stock.column_id;
            jproductname.Text = View_Stock.column_name;
            jquantity.Text = View_Stock.column_quantity;
            jprice.Text = View_Stock.column_price;
            jbarcode.Text = View_Stock.column_barcode;
        }
//
//Add Btn
//
        private void JADD_BTN_Click(object sender, EventArgs e)
        {
            String purchaseDate1 = DateTime.Now.ToString("dd/MM/yyyy");
           
            if (jid.Text == "ID")
            {
                if (jproductname.Text == "" || jprice.Text == "" || jquantity.Text == "")
                {
                    MessageBox.Show("All Fields Required", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Till_Restuarant_Softwear.Properties.Settings.Setting"].ToString());
                    //SqlConnection conn = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Integrated Security=True");
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("Select* From Stock Where Name='" + jproductname.Text + "'", conn);
                    SqlDataReader dr;
                    dr = cmd.ExecuteReader();
                    if (dr.HasRows)
                    {
                        MessageBox.Show("Product ALready Present", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        String id = DateTime.Now.ToString("dMyyhms");
                        SqlConnection conn1 = new SqlConnection(ConfigurationManager.ConnectionStrings["Till_Restuarant_Softwear.Properties.Settings.Setting"].ToString());
                        //SqlConnection conn1 = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Integrated Security=True");
                        conn1.Open();
                        SqlCommand cmd1 = new SqlCommand("insert Into Stock values(@a,@b,@c,@d,@e,@f,@g)", conn1);
                        cmd1.Parameters.AddWithValue("@a", id);
                        cmd1.Parameters.AddWithValue("@b", jproductname.Text);
                        cmd1.Parameters.AddWithValue("@c", jquantity.Text);
                        cmd1.Parameters.AddWithValue("@d", jprice.Text);
                        cmd1.Parameters.AddWithValue("@e", jexpirydate.Text);
                        cmd1.Parameters.AddWithValue("@f", jbarcode.Text);
                        cmd1.Parameters.AddWithValue("@g", purchaseDate1);
                        cmd1.ExecuteNonQuery();
                        conn1.Close();

                        MessageBox.Show("Data Inserted");
                        frm1.RefreshGrid();

                        String id1 = DateTime.Now.ToString("dMyyhms");
                        String PurcahseDate = DateTime.Now.ToString("dd/MM/yyyy");

                        // SqlConnection con = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Integrated Security=True");
                        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["Till_Restuarant_Softwear.Properties.Settings.Setting"].ToString());
                        con.Open();
                        SqlCommand cm = new SqlCommand("insert Into Purchase_Stock values(@a,@b,@c,@d,@e,@f,@g,@h)", con);
                        cm.Parameters.AddWithValue("@a", id1);
                        cm.Parameters.AddWithValue("@b", jproductname.Text);
                        cm.Parameters.AddWithValue("@c", jquantity.Text);
                        cm.Parameters.AddWithValue("@d", jprice.Text);
                        cm.Parameters.AddWithValue("@e", jexpirydate.Text);
                        cm.Parameters.AddWithValue("@f", jbarcode.Text);
                        cm.Parameters.AddWithValue("@g", PurcahseDate);
                        cm.Parameters.AddWithValue("@h", jtotalprice.Text);
                        cm.ExecuteNonQuery();
                        con.Close();
                        

                        jid.Text = "ID";
                        jproductname.Text = "";
                        jprice.Text = "";
                        jquantity.Text = "";
                        jbarcode.Text = "";
                    }
                }

            }
        }
//
//Update Btn
//
        private void JUPDATE_BTN_Click(object sender, EventArgs e)
        {
            try
            {
                if (jid.Text != "ID")
                {
                    SqlConnection conn1 = new SqlConnection(ConfigurationManager.ConnectionStrings["Till_Restuarant_Softwear.Properties.Settings.Setting"].ToString());
                    //SqlConnection conn1 = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Integrated Security=True");
                    conn1.Open();
                    SqlCommand cmd1 = new SqlCommand("Select* From Stock Where ID='" + jid.Text + "'", conn1);
                    SqlDataReader dr;
                    dr = cmd1.ExecuteReader();
                    if (dr.Read())
                    {
                        int quantity = Convert.ToInt32(dr["Quantity"].ToString());
                        int preQuantity = Convert.ToInt32(jquantity.Text);
                        if (quantity <= preQuantity)
                        {

                            if (jbarcode.Text == "")
                            {
                                if(quantity<preQuantity)
                                {
                                    String id = DateTime.Now.ToString("dMyyhms");
                                    String PurcahseDate = DateTime.Now.ToString("dd/MM/yyyy");
                                    //SqlConnection con = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Integrated Security=True");
                                    SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["Till_Restuarant_Softwear.Properties.Settings.Setting"].ToString());
                                    con.Open();

                                    int enterQuantity = preQuantity - quantity;

                                    SqlCommand cm = new SqlCommand("insert Into Purchase_Stock values(@a,@b,@c,@d,@e,@f,@g,@h)", con);
                                    cm.Parameters.AddWithValue("@a",id);
                                    cm.Parameters.AddWithValue("@b",jproductname.Text);
                                    cm.Parameters.AddWithValue("@c",enterQuantity.ToString());
                                    cm.Parameters.AddWithValue("@d",jprice.Text);
                                    cm.Parameters.AddWithValue("@e",jexpirydate.Text);
                                    cm.Parameters.AddWithValue("@f",jbarcode.Text);
                                    cm.Parameters.AddWithValue("@g", PurcahseDate);
                                    cm.Parameters.AddWithValue("@h", jtotalprice.Text);
                                    cm.ExecuteNonQuery();
                                    con.Close();
                                }

                                SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Till_Restuarant_Softwear.Properties.Settings.Setting"].ToString());
                                //SqlConnection conn = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Integrated Security=True");
                                conn.Open();
                                String query = "UPDATE Stock SET Name='" + jproductname.Text + "',Quantity='" + jquantity.Text + "',Price='" + jprice.Text + "'WHERE ID='" + jid.Text + "'";
                                SqlCommand cmd = new SqlCommand(query, conn);
                                cmd.ExecuteNonQuery();
                                conn.Close();
                                frm1.RefreshGrid();
                            }
                            else
                            {
                                if (quantity < preQuantity)
                                {
                                    String id = DateTime.Now.ToString("dMyyhms");
                                    String PurcahseDate = DateTime.Now.ToString("dd/MM/yyyy");
                                    //SqlConnection con = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Integrated Security=True");
                                    SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["Till_Restuarant_Softwear.Properties.Settings.Setting"].ToString());
                                    con.Open();

                                    int enterQuantity = preQuantity - quantity;

                                    SqlCommand cm = new SqlCommand("insert Into Purchase_Stock values(@a,@b,@c,@d,@e,@f,@g,@h)", con);
                                    cm.Parameters.AddWithValue("@a", id);
                                    cm.Parameters.AddWithValue("@b", jproductname.Text);
                                    cm.Parameters.AddWithValue("@c", enterQuantity.ToString());
                                    cm.Parameters.AddWithValue("@d", jprice.Text);
                                    cm.Parameters.AddWithValue("@e", jexpirydate.Text);
                                    cm.Parameters.AddWithValue("@f", jbarcode.Text);
                                    cm.Parameters.AddWithValue("@g", PurcahseDate);
                                    cm.Parameters.AddWithValue("@h", jtotalprice.Text);
                                    cm.ExecuteNonQuery();
                                    con.Close();
                                }

                                SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Till_Restuarant_Softwear.Properties.Settings.Setting"].ToString());
                                //SqlConnection conn = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Integrated Security=True");
                                conn.Open();
                                String query = "UPDATE Stock SET Name='" + jproductname.Text + "',Quantity='" + jquantity.Text + "',Price='" + jprice.Text + "',Barcode='" + jbarcode.Text + "'WHERE ID='" + jid.Text + "'";
                                SqlCommand cmd = new SqlCommand(query, conn);
                                cmd.ExecuteNonQuery();
                                conn.Close();
                                frm1.RefreshGrid();
                            }
                            MessageBox.Show("Updated");

                            jid.Text = "ID";
                            jproductname.Text = "";
                            jprice.Text = "";
                            jquantity.Text = "";
                            jbarcode.Text = "";

                            View_Stock.column_id="ID";
                            View_Stock.column_name="";
                            View_Stock.column_quantity = "";
                            View_Stock.column_price = "";
                            View_Stock.column_barcode = "";
                        }
                        else
                        {
                            MessageBox.Show("Product Has Already Quantity :" + dr["Quantity"].ToString());
                        }
                    }
                    conn1.Close();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
//
//Reset Btn
//
        private void JRESET_BTN_Click(object sender, EventArgs e)
        {
            jid.Text = "ID";
            jproductname.Text = "";
            jprice.Text = "";
            jquantity.Text = "";
            jbarcode.Text = "";
        }
//
//Close Btn
//
        private void JCLOSE_BTN_Click(object sender, EventArgs e)
        {
            this.Hide();

            View_Stock.column_id = "ID";
            View_Stock.column_name = "";
            View_Stock.column_quantity = "";
            View_Stock.column_price = "";
            View_Stock.column_barcode = "";
        }
//
//Number validation
//
        private void jquantity_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(jquantity.Text, "[^0-9]"))
            {
                jquantity.Text = jquantity.Text.Remove(jquantity.Text.Length - 1);
            }
            else
            if(jquantity.Text!="" && jprice.Text!="")
            {
                int quantityCon = Convert.ToInt32(jquantity.Text);
                int priceCon = Convert.ToInt32(jprice.Text);
                jtotalprice.Text = (quantityCon * priceCon).ToString();
            }

        }
//
//Auto Barcode Gernate
//
        private void jproductname_TextChanged(object sender, EventArgs e)
        {
           /* if (jproductname.Text != "")
            {
                jbarcode.Text = jproductname.Text + "2345" + jprice.Text;
            }
            else
            {
                jbarcode.Text = "2345" + jprice.Text;
            }*/
        }
//
//Number Validation and auto barcode gernator
//
        private void jprice_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(jprice.Text, "[^0-9]"))
            {
                jprice.Text = jprice.Text.Remove(jprice.Text.Length - 1);
            }
            else
            if (jprice.Text != "")
            {
                if (jquantity.Text == "")
                {
                    jtotalprice.Text = jprice.Text;
                }
                else
                {
                    int quantityCon = Convert.ToInt32(jquantity.Text);
                    int priceCon = Convert.ToInt32(jprice.Text);
                    jtotalprice.Text = (quantityCon * priceCon).ToString();
                }
            }
        }

        private void jdelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (jid.Text != "ID")
                {
                    SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Till_Restuarant_Softwear.Properties.Settings.Setting"].ToString());
                    conn.Open();
                    String query = "Delete Stock WHERE ID='" + jid.Text + "'";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    frm1.RefreshGrid();

                    MessageBox.Show("Deleted");

                    jid.Text = "ID";
                    jproductname.Text = "";
                    jprice.Text = "";
                    jquantity.Text = "";
                    jbarcode.Text = "";

                    View_Stock.column_id = "ID";
                    View_Stock.column_name = "";
                    View_Stock.column_quantity = "";
                    View_Stock.column_price = "";
                    View_Stock.column_barcode = "";
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
