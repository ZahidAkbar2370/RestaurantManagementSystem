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
    
    public partial class Add_Vendor : Form
    {
        private readonly View_Vendor_Management frm1;
        public Add_Vendor(View_Vendor_Management frm)
        {
            InitializeComponent();
            SetValues();

            frm1 = frm;
        }
        public void SetValues()
        {
            jid.Text =View_Vendor_Management.column_id;
            jname.Text = View_Vendor_Management.column_name;
            jcontactno.Text = View_Vendor_Management.column_contactno;
            jmail.Text = View_Vendor_Management.column_mail;
            jbussinessname.Text = View_Vendor_Management.column_bussinessname;
            jaddress.Text = View_Vendor_Management.column_address;
            jgstnumber.Text = View_Vendor_Management.column_gstno;
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
                    if (jname.Text == "" || jcontactno.Text == "" || jmail.Text == "" || jaddress.Text == "" || jbussinessname.Text == "" || jgstnumber.Text == "")
                    {
                        MessageBox.Show("All Fields Required");
                    }
                    else if (!this.jmail.Text.Contains('@') || !this.jmail.Text.Contains('.'))
                    {
                        MessageBox.Show("Please Enter A Valid Email\n\n example@gmail.com", "Invalid Email", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        DialogResult dialogResult = MessageBox.Show("Please Check Detail", "Conform Message", MessageBoxButtons.YesNo);
                        if (dialogResult == DialogResult.Yes)
                        {
                            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Till_Restuarant_Softwear.Properties.Settings.Setting"].ToString());
                           // SqlConnection conn = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Integrated Security=True");
                            conn.Open();
                            String date = DateTime.Now.ToString("dmyyHMS");
                            SqlCommand cmd = new SqlCommand("insert into Vendor values (@a,@b,@c,@d,@e,@f,@g)", conn);
                            cmd.Parameters.AddWithValue("@a", date);
                            cmd.Parameters.AddWithValue("@b", jname.Text);
                            cmd.Parameters.AddWithValue("@c", jcontactno.Text);
                            cmd.Parameters.AddWithValue("@d", jmail.Text);
                            cmd.Parameters.AddWithValue("@e", jbussinessname.Text);
                            cmd.Parameters.AddWithValue("@f", jaddress.Text);
                            cmd.Parameters.AddWithValue("@g", jgstnumber.Text);
                            cmd.ExecuteNonQuery();
                            conn.Close();

                            MessageBox.Show("Data Inserted");
                            frm1.RefreshGrid();
                           

                            //Reset All Fields
                            jid.Text = "ID";
                            jname.Text = "";
                            jcontactno.Text = "";
                            jgstnumber.Text = "";
                            jaddress.Text = "";
                            jmail.Text = "";
                            jbussinessname.Text = "";
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
                    String query = "UPDATE Vendor SET ContactNo='" + jcontactno.Text + "',Address='" + jaddress.Text + "',Name='" + jname.Text + "',Mail='" + jmail.Text + "',BussinessName='" + jbussinessname.Text + "'WHERE ID='" + jid.Text + "'";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Updated");

                    frm1.RefreshGrid();
                    SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["Till_Restuarant_Softwear.Properties.Settings.Setting"].ToString());

                    //Reset All Fields
                    jid.Text = "ID";
                    jname.Text = "";
                    jcontactno.Text = "";
                    jgstnumber.Text = "";
                    jaddress.Text = "";
                    jmail.Text = "";
                    jbussinessname.Text = "";

                    View_Vendor_Management.column_id="ID";
                    View_Vendor_Management.column_name = "";
                    View_Vendor_Management.column_contactno = "";
                    View_Vendor_Management.column_mail = "";
                    View_Vendor_Management.column_bussinessname = "";
                    View_Vendor_Management.column_address = "";
                    View_Vendor_Management.column_gstno = "";
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
        private void button1_Click(object sender, EventArgs e)
        {
            //Reset All Fields
            jid.Text = "ID";
            jname.Text = "";
            jcontactno.Text = "";
            jgstnumber.Text = "";
            jaddress.Text = "";
            jmail.Text = "";
            jbussinessname.Text = "";
        }
//
//Only Number enter Validation
//
        private void jcontactno_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(jcontactno.Text, "[^0-9]"))
            {
                jcontactno.Text = jcontactno.Text.Remove(jcontactno.Text.Length - 1);
            }
        }
//
//Only Number Validation
//

        private void jgstnumber_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(jgstnumber.Text, "[^0-9]"))
            {
                jgstnumber.Text = jgstnumber.Text.Remove(jgstnumber.Text.Length - 1);
            }
        }
//
//Close Btn
//
        private void JCLOSE_BTN_Click(object sender, EventArgs e)
        {
            this.Hide();

            View_Vendor_Management.column_id = "ID";
            View_Vendor_Management.column_name = "";
            View_Vendor_Management.column_contactno = "";
            View_Vendor_Management.column_mail = "";
            View_Vendor_Management.column_bussinessname = "";
            View_Vendor_Management.column_address = "";
            View_Vendor_Management.column_gstno = "";
        }

        private void jmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
//
//DELETE BTN
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
                    String query = "DELETE Vendor WHERE ID='" + jid.Text + "'";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Deleted");

                    frm1.RefreshGrid();
                    SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["Till_Restuarant_Softwear.Properties.Settings.Setting"].ToString());

                    //Reset All Fields
                    jid.Text = "ID";
                    jname.Text = "";
                    jcontactno.Text = "";
                    jgstnumber.Text = "";
                    jaddress.Text = "";
                    jmail.Text = "";
                    jbussinessname.Text = "";

                    View_Vendor_Management.column_id = "ID";
                    View_Vendor_Management.column_name = "";
                    View_Vendor_Management.column_contactno = "";
                    View_Vendor_Management.column_mail = "";
                    View_Vendor_Management.column_bussinessname = "";
                    View_Vendor_Management.column_address = "";
                    View_Vendor_Management.column_gstno = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
