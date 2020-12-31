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
    public partial class Add_Other_Contact : Form
    {
        private readonly View_Other_Contact frm1;
        public Add_Other_Contact(View_Other_Contact frm)
        {
            InitializeComponent();
            SetValues();

            frm1 = frm;
        }
        public void SetValues()
        {
            jid.Text = View_Other_Contact.column_id;
            jname.Text = View_Other_Contact.column_name;
            jmobileno.Text = View_Other_Contact.column_mobileno;
            jdescription.Text = View_Other_Contact.column_description;
        }
//
//Add Btn
//
        private void JBTN_ADD_Click(object sender, EventArgs e)
        {
            if (jid.Text == "ID")
            {
                try
                {
                    //SqlConnection conn = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Integrated Security=True");
                    SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Till_Restuarant_Softwear.Properties.Settings.Setting"].ToString());
                    conn.Open();
                    if (jname.Text == "" || jmobileno.Text == "" || jdescription.Text == "")
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
                            String query = "insert into Other_Contact values (@a,@b,@c,@d)";
                            SqlCommand cmd = new SqlCommand(query, conn);
                            cmd.Parameters.AddWithValue("@a", id);
                            cmd.Parameters.AddWithValue("@b", jname.Text);
                            cmd.Parameters.AddWithValue("@c", jmobileno.Text);
                            cmd.Parameters.AddWithValue("@d", jdescription.Text);
                            cmd.ExecuteNonQuery();
                            conn.Close();

                            MessageBox.Show("Data Inserted");
                            frm1.RefreshGrid();
                           

                            jid.Text = "ID";
                            jname.Text = "";
                            jmobileno.Text = "";
                            jdescription.Text = "";
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
//Update Btn
//
        private void UPDATE_JBTN_Click(object sender, EventArgs e)
        {
            try
            {
                if (jid.Text != "ID")
                {
                    SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Till_Restuarant_Softwear.Properties.Settings.Setting"].ToString());
                    //SqlConnection conn = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Integrated Security=True");
                    conn.Open();
                    String query = "UPDATE Other_Contact SET MobileNo='" + jmobileno.Text + "',Name='" + jname.Text + "',Discription='" + jdescription.Text + "'WHERE ID='" + jid.Text + "'";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Updated");
                    conn.Close();

                    frm1.RefreshGrid();


                    jid.Text = "ID";
                    jname.Text = "";
                    jmobileno.Text = "";
                    jdescription.Text = "";

                    View_Other_Contact.column_id = "ID";
                    View_Other_Contact.column_name = "";
                    View_Other_Contact.column_mobileno = "";
                    View_Other_Contact.column_description = "";
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
        private void JREST_BTN_Click(object sender, EventArgs e)
        {
            jid.Text = "ID";
            jname.Text = "";
            jmobileno.Text = "";
            jdescription.Text = "";
        }
//
//Close Btn
//
        private void JBTN_CANCLE_Click(object sender, EventArgs e)
        {
            this.Hide();

            View_Other_Contact.column_id = "ID";
            View_Other_Contact.column_name = "";
            View_Other_Contact.column_mobileno = "";
            View_Other_Contact.column_description = "";
        }
//
//Number Validation
//
        private void jmobileno_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(jmobileno.Text, "[^0-9]"))
            {
                jmobileno.Text = jmobileno.Text.Remove(jmobileno.Text.Length - 1);
            }
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
                    String query = "Delete Other_Contact WHERE ID='" + jid.Text + "'";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Deleted");
                    conn.Close();

                    frm1.RefreshGrid();


                    jid.Text = "ID";
                    jname.Text = "";
                    jmobileno.Text = "";
                    jdescription.Text = "";

                    View_Other_Contact.column_id = "ID";
                    View_Other_Contact.column_name = "";
                    View_Other_Contact.column_mobileno = "";
                    View_Other_Contact.column_description = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }
    }
}
