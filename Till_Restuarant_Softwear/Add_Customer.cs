using System;
using System.Configuration;
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
    public partial class Add_Customer : Form
    {
        private readonly View_Customer frm1;
        public Add_Customer(View_Customer frm)
        {
            InitializeComponent();
            SetValues();

            frm1 = frm;
        }
//
//Values Fetch From dataViewTable
//
        public void SetValues()
        {
            jid.Text=View_Customer.column_id;
            jname.Text = View_Customer.column_name;
            jfathername.Text = View_Customer.column_fathername ;
            jcontactno.Text = View_Customer.column_contactno ;
            jemail.Text = View_Customer.column_email;
            jaddress.Text = View_Customer.column_address;
        }
//
//Close Btn
//
        private void JCLOSE_BTN_Click(object sender, EventArgs e)
        {
            this.Hide();

            //Reset All Date
            View_Customer.column_id = "ID";
            View_Customer.column_name = "ID";
            View_Customer.column_fathername = "ID";
            View_Customer.column_contactno = "ID";
            View_Customer.column_email = "ID";
            View_Customer.column_address = "ID";
        }
//
//Save Btn
//
        private void JBTN_Save_Click(object sender, EventArgs e)
        {
            if (jid.Text == "ID")
            {
                try
                {
                    SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Till_Restuarant_Softwear.Properties.Settings.Setting"].ToString());
                    conn.Open();
                    if (jname.Text == "" || jfathername.Text == "" || jcontactno.Text == "" || jemail.Text == "" || jaddress.Text == "")
                    {
                        MessageBox.Show("All Fields Required");
                    }
                    else if (!this.jemail.Text.Contains('@') || !this.jemail.Text.Contains('.'))
                    {
                        MessageBox.Show("Please Enter A Valid Email\n\n example@gmail.com", "Invalid Email", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        String id = DateTime.Now.ToString("mdyyhms");

                        DialogResult dialogResult = MessageBox.Show("Please Check Detail", "Conform Message", MessageBoxButtons.YesNo);
                        if (dialogResult == DialogResult.Yes)
                        {
                            //Values Inserted into All_Stock_Record
                            String query = "insert into Customer values (@f,@a,@b,@c,@d,@e)";
                            SqlCommand cmd = new SqlCommand(query, conn);
                            cmd.Parameters.AddWithValue("@f", id);
                            cmd.Parameters.AddWithValue("@a", jname.Text);
                            cmd.Parameters.AddWithValue("@b", jfathername.Text);
                            cmd.Parameters.AddWithValue("@c", jcontactno.Text);
                            cmd.Parameters.AddWithValue("@d", jemail.Text);
                            cmd.Parameters.AddWithValue("@e", jaddress.Text);
                            cmd.ExecuteNonQuery();
                            conn.Close();

                            frm1.RefreshGrid();
                            MessageBox.Show("Data Inserted");
                            
                            //Reset All Fields
                            jid.Text = "ID";
                            jname.Text = "";
                            jfathername.Text = "";
                            jcontactno.Text = "";
                            jemail.Text = "";
                            jaddress.Text = "";

                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "Error");
                }
            }
        }
//
//Update Btn Coding
//
        private void UPDATE_JBTN_Click(object sender, EventArgs e)
        {
            if (jid.Text != "ID")
            {
                try
                {
                    SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Till_Restuarant_Softwear.Properties.Settings.Setting"].ToString());
                    conn.Open();
                    String query = "UPDATE Customer SET Name='" + jname.Text + "',FatherName='" + jfathername.Text + "',ContactNo='" + jcontactno.Text + "',Email='" + jemail.Text + "',Address='" + jaddress.Text + "'WHERE ID='" + jid.Text + "'";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Updated");
                    conn.Close();

                    frm1.RefreshGrid();
                   
                    //Reset All Fields
                    jid.Text = "ID";
                    jname.Text = "";
                    jfathername.Text = "";
                    jcontactno.Text = "";
                    jemail.Text = "";
                    jaddress.Text = "";

                    View_Customer.column_id="ID";
                    View_Customer.column_name = "";
                    View_Customer.column_fathername = "";
                    View_Customer.column_contactno = "";
                    View_Customer.column_email = "";
                    View_Customer.column_address = "";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "Error");

                }

            }
        }
//
//Reset Btn
//
        private void JRESET_BTN_Click(object sender, EventArgs e)
        {
            jid.Text = "ID";
            jname.Text = "";
            jfathername.Text = "";
            jcontactno.Text = "";
            jemail.Text = "";
            jaddress.Text = "";
        }
//
//Only Enter Number Validation
//
        private void jcontactno_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(jcontactno.Text, "[^0-9]"))
            {
                jcontactno.Text = jcontactno.Text.Remove(jcontactno.Text.Length - 1);
            }
        }

        private void jemail_TextChanged(object sender, EventArgs e)
        {
        }
//
//Delete Btn
//
        private void JDELETE_BTN_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Till_Restuarant_Softwear.Properties.Settings.Setting"].ToString());
                conn.Open();
                String query = "Delete Customer WHERE ID='" + jid.Text + "'";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Deleted");
                conn.Close();

                frm1.RefreshGrid();

                //Reset All Fields
                jid.Text = "ID";
                jname.Text = "";
                jfathername.Text = "";
                jcontactno.Text = "";
                jemail.Text = "";
                jaddress.Text = "";

                View_Customer.column_id = "ID";
                View_Customer.column_name = "";
                View_Customer.column_fathername = "";
                View_Customer.column_contactno = "";
                View_Customer.column_email = "";
                View_Customer.column_address = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error");

            }
        }
    }
}
