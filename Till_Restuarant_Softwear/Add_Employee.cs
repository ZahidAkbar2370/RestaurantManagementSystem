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
    
    public partial class Add_Employee : Form
    {
        private readonly View_Employee frm1;
        public Add_Employee(View_Employee frm)
        {
            InitializeComponent();
            SetValues();

            frm1 = frm;
        }
        public void SetValues()
        {
            jid.Text = View_Employee.column_id;
            jname.Text = View_Employee.column_name;
            jemail.Text = View_Employee.column_email;
            jaddress.Text = View_Employee.column_address;
            jcontactno.Text = View_Employee.column_contactno;
            jstatus.Text = View_Employee.column_status;
            jsalery.Text = View_Employee.column_salary;
            jshift.Text= View_Employee.column_shift;
            jjoindate.Text = View_Employee.column_joindate;
        }
//
//Save BTN
//
        private void JBTN_Save_Click(object sender, EventArgs e)
        {
            if (jid.Text == "ID")
            {
                try
                {
                    //SqlConnection conn = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Integrated Security=True");
                    SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Till_Restuarant_Softwear.Properties.Settings.Setting"].ToString());
                    conn.Open();
                    if (jname.Text == "" || jsalery.Text == "" || jcontactno.Text == "" || jemail.Text == "" || jaddress.Text == "" || jstatus.Text == "")
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
                            //Values Inserted into Employee
                            String query = "insert into Employee values (@i,@a,@b,@c,@d,@e,@f,@g,@h)";
                            SqlCommand cmd = new SqlCommand(query, conn);
                            cmd.Parameters.AddWithValue("@i", id);
                            cmd.Parameters.AddWithValue("@a", jname.Text);
                            cmd.Parameters.AddWithValue("@b", jcontactno.Text);
                            cmd.Parameters.AddWithValue("@c", jemail.Text);
                            cmd.Parameters.AddWithValue("@d", jsalery.Text);
                            cmd.Parameters.AddWithValue("@e", jstatus.Text);
                            cmd.Parameters.AddWithValue("@f", jshift.Text);
                            cmd.Parameters.AddWithValue("@g", jjoindate.Text);
                            cmd.Parameters.AddWithValue("@h", jaddress.Text);
                            cmd.ExecuteNonQuery();
                            conn.Close();

                    //Manage Waiter Data
                            if(jstatus.Text== "Waiter")
                            {
                                //SqlConnection conn1 = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Integrated Security=True");
                                SqlConnection conn1 = new SqlConnection(ConfigurationManager.ConnectionStrings["Till_Restuarant_Softwear.Properties.Settings.Setting"].ToString());
                                conn1.Open();
                                String query1 = "insert into Waiter values (@a,@b,@c)";
                                SqlCommand cmd1 = new SqlCommand(query1, conn1);
                                cmd1.Parameters.AddWithValue("@a", id);
                                cmd1.Parameters.AddWithValue("@b", jname.Text);
                                cmd1.Parameters.AddWithValue("@c", "Free");
                                cmd1.ExecuteNonQuery();
                            }
                            MessageBox.Show("Data Inserted");
                            frm1.RefreshGrid();
                            

                            //Reset All Fields
                            jid.Text = "ID";
                            jname.Text = "";
                            jsalery.Text = "";
                            jcontactno.Text = "";
                            jemail.Text = "";
                            jaddress.Text = "";
                            jstatus.Text = "";
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
//Update BTN
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
                    String query = "UPDATE Employee SET Name='" + jname.Text + "',Address='" + jaddress.Text + "',Salary='" + jsalery.Text + "',Shift='" + jshift.Text + "',Status='" + jstatus.Text + "',ContactNo='" + jcontactno.Text + "',Email='" + jemail.Text + "'WHERE ID='" + jid.Text + "'";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Updated");
                    frm1.RefreshGrid();

                    

                    jid.Text = "ID";
                    jname.Text = "";
                    jsalery.Text = "";
                    jcontactno.Text = "";
                    jemail.Text = "";
                    jaddress.Text = "";
                    jstatus.Text = "";
                    jshift.Text = "";

                    View_Employee.column_id="ID";
                    View_Employee.column_name = "";
                    View_Employee.column_email = "";
                    View_Employee.column_address = "";
                    View_Employee.column_contactno = "";
                    View_Employee.column_status = "";
                    View_Employee.column_salary = "";
                    View_Employee.column_shift = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
//
//Reset BTN
//
        private void JRESET_BTN_Click(object sender, EventArgs e)
        {
            jid.Text = "ID";
            jname.Text = "";
            jsalery.Text = "";
            jcontactno.Text = "";
            jemail.Text = "";
            jaddress.Text = "";
            jstatus.Text = "";
            jshift.Text = "";
        }
//
//Only Enter Num Validation
//
        private void jcontactno_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(jcontactno.Text, "[^0-9]"))
            {
                jcontactno.Text = jcontactno.Text.Remove(jcontactno.Text.Length - 1);
            }
        }
//
//Only Enter Num Validation
//
        private void jsalery_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(jsalery.Text, "[^0-9]"))
            {
                jsalery.Text = jsalery.Text.Remove(jsalery.Text.Length - 1);
            }
        }
//
//Close Btn
//
        private void JCLOSE_BTN_Click(object sender, EventArgs e)
        {
            this.Hide();

            View_Employee.column_id = "ID";
            View_Employee.column_name = "";
            View_Employee.column_email = "";
            View_Employee.column_address = "";
            View_Employee.column_contactno = "";
            View_Employee.column_status = "";
            View_Employee.column_salary = "";
            View_Employee.column_shift = "";

        }
//
//Email Validation
//
        private void jemail_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Add_Employee_Load(object sender, EventArgs e)
        {

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
                    //SqlConnection conn = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Integrated Security=True");
                    SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Till_Restuarant_Softwear.Properties.Settings.Setting"].ToString());
                    conn.Open();
                    String query = "Delete Employee WHERE ID='" + jid.Text + "'";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Deleted");
                    frm1.RefreshGrid();



                    jid.Text = "ID";
                    jname.Text = "";
                    jsalery.Text = "";
                    jcontactno.Text = "";
                    jemail.Text = "";
                    jaddress.Text = "";
                    jstatus.Text = "";
                    jshift.Text = "";

                    View_Employee.column_id = "ID";
                    View_Employee.column_name = "";
                    View_Employee.column_email = "";
                    View_Employee.column_address = "";
                    View_Employee.column_contactno = "";
                    View_Employee.column_status = "";
                    View_Employee.column_salary = "";
                    View_Employee.column_shift = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
