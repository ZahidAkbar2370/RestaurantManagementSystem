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
    public partial class Add_User : Form
    {
        private readonly View_User frm1; //readonly is optional (For safety purposes)

        public Add_User(View_User frm)
        {
            InitializeComponent();

            SetValues();
            frm1 = frm;
            //this.adduser = add_User_Form;
        }
        public void SetValues()
        {
            jid.Text = View_User.column_id;
            jname.Text = View_User.column_name;
            jemail.Text = View_User.column_email;
            jaddress.Text = View_User.column_address;
            jcontactno.Text = View_User.column_contactno;
            jstatus.Text = View_User.column_status;
        }
 //
 //Save Button Coding
 //
        private void JBTN_Save_Click(object sender, EventArgs e)
        {
            if (jid.Text == "ID")
               {
                   String id = DateTime.Now.ToString("mdyyhms");
                   try
                   {
                    SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Till_Restuarant_Softwear.Properties.Settings.Setting"].ToString());
                    //SqlConnection conn = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Integrated Security=True");
                    conn.Open();
                       if (jname.Text == "" || jcontactno.Text == "" || jemail.Text == "" || jaddress.Text == "" || jstatus.Text == "" || jpassword.Text == "")
                       {
                           MessageBox.Show("All Fields Required");
                       }
                       else if (jpassword.Text != jretrypassword.Text)
                       {
                           MessageBox.Show("Password Mis-Match");
                       }
                        else if (!this.jemail.Text.Contains('@') || !this.jemail.Text.Contains('.'))
                        {
                            MessageBox.Show("Please Enter A Valid Email\n\n example@gmail.com", "Invalid Email", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    else
                       {

                           DialogResult dialogResult = MessageBox.Show("Please Check Detail", "Conform Message", MessageBoxButtons.YesNo);
                           if (dialogResult == DialogResult.Yes)
                           {
                               //Values Inserted into User_Info
                               String query = "insert into User_Info values (@a,@b,@c,@d,@e,@f,@g)";
                               SqlCommand cmd = new SqlCommand(query, conn);
                               cmd.Parameters.AddWithValue("@a", id);
                               cmd.Parameters.AddWithValue("@b", jname.Text);
                               cmd.Parameters.AddWithValue("@c", jcontactno.Text);
                               cmd.Parameters.AddWithValue("@d", jemail.Text);
                               cmd.Parameters.AddWithValue("@e", jstatus.Text);
                               cmd.Parameters.AddWithValue("@f", jpassword.Text);
                               cmd.Parameters.AddWithValue("@g", jaddress.Text);
                               cmd.ExecuteNonQuery();
                               conn.Close();

                               frm1.RefreshGrid();
                            

                            //Reset All Fields
                            jid.Text = "ID";
                            jname.Text = "";
                            jcontactno.Text = "";
                            jemail.Text = "";
                            jaddress.Text = "";
                            jstatus.Text = "";
                            jpassword.Text = "";
                            jretrypassword.Text = "";
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "Error");
                }
            }
            else
            {
                MessageBox.Show("Please Press Update Button");
            }
     }
//
//Update Button Coding
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
                    String query = "UPDATE User_Info SET Name='" + jname.Text + "',Address='" + jaddress.Text + "',Email='" + jemail.Text + "',ContactNo='" + jcontactno.Text + "',Status='" + jstatus.Text +"'WHERE ID='" + jid.Text + "'";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Updated");

                    frm1.RefreshGrid();
                    //Reset All
                    jid.Text = "ID";
                    jname.Text = "";
                    jcontactno.Text = "";
                    jemail.Text = "";
                    jaddress.Text = "";
                    jstatus.Text = "";
                    jpassword.Text = "";
                    jretrypassword.Text = "";

                    View_User.column_id="ID";
                    View_User.column_name="";
                    View_User.column_email = "";
                    View_User.column_address = "";
                    View_User.column_contactno = "";
                    View_User.column_status = "";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            else
            {
                MessageBox.Show("Please Press Save Button");
            }
        }
//
//Reset Button
//
        private void JRESET_BTN_Click(object sender, EventArgs e)
        {
            jid.Text = "ID";
            jname.Text = "";
            jcontactno.Text = "";
            jemail.Text = "";
            jaddress.Text = "";
            jstatus.Text = "";
            jpassword.Text = "";
            jretrypassword.Text = "";
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

        private void JCLOSE_BTN_Click(object sender, EventArgs e)
        {
            this.Hide();

            View_User set = new View_User();
            set.Update();

            View_User.column_id = "ID";
            View_User.column_name = "";
            View_User.column_email = "";
            View_User.column_address = "";
            View_User.column_contactno = "";
            View_User.column_status = "";

        }
//
//Email Validation
//
        private void jemail_TextChanged(object sender, EventArgs e)
        {
            //if (!this.jemail.Text.Contains('@') || !this.jemail.Text.Contains('.'))
           // {
           //     MessageBox.Show("Please Enter A Valid Email\n\n example@gmail.com", "Invalid Email", MessageBoxButtons.OK, MessageBoxIcon.Error);
           // }
        }

//
//Delete B
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
                    String query = "Delete  User_Info WHERE ID='" + jid.Text + "'";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Deleted");

                    frm1.RefreshGrid();
                    //Reset All
                    jid.Text = "ID";
                    jname.Text = "";
                    jcontactno.Text = "";
                    jemail.Text = "";
                    jaddress.Text = "";
                    jstatus.Text = "";
                    jpassword.Text = "";
                    jretrypassword.Text = "";

                    View_User.column_id = "ID";
                    View_User.column_name = "";
                    View_User.column_email = "";
                    View_User.column_address = "";
                    View_User.column_contactno = "";
                    View_User.column_status = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
