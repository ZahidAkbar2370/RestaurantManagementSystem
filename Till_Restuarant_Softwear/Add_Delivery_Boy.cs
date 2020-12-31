using System;using System.Configuration;using System.Configuration;
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
    public partial class Add_Delivery_Boy : Form
    {
        private readonly View_Delivery_Boy frm1;
        public Add_Delivery_Boy(View_Delivery_Boy frm)
        {
            InitializeComponent();
            SetValues();

            frm1 = frm;
        }
        public void SetValues()
        {
            jid.Text = View_Delivery_Boy.column_id;
            jname.Text = View_Delivery_Boy.column_name;
            jmobileno.Text = View_Delivery_Boy.column_mobileno;
            jaddress.Text = View_Delivery_Boy.column_address;
            jsalary.Text = View_Delivery_Boy.column_salary;
            jshift.Text = View_Delivery_Boy.column_shift;
            jjoindate.Text = View_Delivery_Boy.column_joindate;
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
                    if (jname.Text == "" || jmobileno.Text == "" || jaddress.Text == "" || jsalary.Text == "" || jshift.Text == "")
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
                            String query = "insert into Delivery_Boy values (@a,@b,@c,@d,@e,@f,@g)";
                            SqlCommand cmd = new SqlCommand(query, conn);
                            cmd.Parameters.AddWithValue("@a", id);
                            cmd.Parameters.AddWithValue("@b", jname.Text);
                            cmd.Parameters.AddWithValue("@c", jmobileno.Text);
                            cmd.Parameters.AddWithValue("@d", jaddress.Text);
                            cmd.Parameters.AddWithValue("@e", jsalary.Text);
                            cmd.Parameters.AddWithValue("@f", jshift.Text);
                            cmd.Parameters.AddWithValue("@g", jjoindate.Text);
                            cmd.ExecuteNonQuery();
                            conn.Close();

                            frm1.RefreshGrid();
                            MessageBox.Show("Data Inserted");
                            //Reset All Fields
                            jid.Text = "ID";
                            jname.Text = "";
                            jmobileno.Text = "";
                            jaddress.Text = "";
                            jsalary.Text = "";
                            jshift.Text = "";
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
                    //SqlConnection conn = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Integrated Security=True");
                    SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Till_Restuarant_Softwear.Properties.Settings.Setting"].ToString());
                    conn.Open();
                    String query = "UPDATE Delivery_Boy SET MobileNo='" + jmobileno.Text + "',Address='" + jaddress.Text + "',Salary='" + jsalary.Text + "',Shift='" + jshift.Text + "',Name='" + jname.Text + "'WHERE ID='" + jid.Text + "'";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.ExecuteNonQuery();
                    conn.Close();

                    MessageBox.Show("Updated");
                    frm1.RefreshGrid();
                    

                    jid.Text = "ID";
                    jname.Text = "";
                    jmobileno.Text = "";
                    jaddress.Text = "";
                    jsalary.Text = "";
                    jshift.Text = "";

                    View_Delivery_Boy.column_id="ID";
                    View_Delivery_Boy.column_name = "";
                    View_Delivery_Boy.column_mobileno = "";
                    View_Delivery_Boy.column_address = "";
                    View_Delivery_Boy.column_salary = "";
                    View_Delivery_Boy.column_shift = "";
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
            jname.Text = "";
            jmobileno.Text = "";
            jaddress.Text = "";
            jsalary.Text = "";
            jshift.Text = "";
        }
//
//number validation
//
        private void jmobileno_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(jmobileno.Text, "[^0-9]"))
            {
                jmobileno.Text = jmobileno.Text.Remove(jmobileno.Text.Length - 1);
                MessageBox.Show("Enter Valid Number", "Error");
            }
        }
//
//number validation
//
        private void jsalary_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(jsalary.Text, "[^0-9]"))
            {
                jsalary.Text = jsalary.Text.Remove(jsalary.Text.Length - 1);
                MessageBox.Show("Enter Valid Number", "Error");
            }
        }

        private void JBTN_CLOSE_Click(object sender, EventArgs e)
        {
            this.Hide();

            View_Delivery_Boy.column_id = "ID";
            View_Delivery_Boy.column_name = "";
            View_Delivery_Boy.column_mobileno = "";
            View_Delivery_Boy.column_address = "";
            View_Delivery_Boy.column_salary = "";
            View_Delivery_Boy.column_shift = "";
        }

//
//Delete BTN Coding
//

        private void jdelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (jid.Text != "ID")
                {
                    SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Till_Restuarant_Softwear.Properties.Settings.Setting"].ToString());
                    conn.Open();
                    String query = "Delete Delivery_Boy WHERE ID='" + jid.Text + "'";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Deleted");
                    conn.Close();

                    frm1.RefreshGrid();


                    jid.Text = "ID";
                    jname.Text = "";
                    jmobileno.Text = "";
                    jaddress.Text = "";
                    jsalary.Text = "";
                    jshift.Text = "";

                    View_Delivery_Boy.column_id = "ID";
                    View_Delivery_Boy.column_name = "";
                    View_Delivery_Boy.column_mobileno = "";
                    View_Delivery_Boy.column_address = "";
                    View_Delivery_Boy.column_salary = "";
                    View_Delivery_Boy.column_shift = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error");

            }
        }
    }
}
