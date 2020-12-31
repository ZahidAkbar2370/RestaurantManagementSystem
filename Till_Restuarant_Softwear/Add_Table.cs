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
    public partial class Add_Table : Form
    {
        private readonly View_Table_Management frm1;
        public Add_Table(View_Table_Management frm)
        {
            InitializeComponent();
            Setvalues();

            frm1 = frm;
        }
        public void Setvalues()
        {
            jid.Text = View_Table_Management.column_id;
            jtableno.Text = View_Table_Management.column_tableno;
            jfloorno.Text = View_Table_Management.column_floorno;
            jstatus.Text = View_Table_Management.column_status;
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
                    SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Till_Restuarant_Softwear.Properties.Settings.Setting"].ToString());
                    //SqlConnection conn = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Integrated Security=True");
                    conn.Open();
                    if (jtableno.Text == "" || jfloorno.Text == "")
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
                            String query = "insert into Table_Manage values (@d,@a,@b,@c)";
                            SqlCommand cmd = new SqlCommand(query, conn);
                            cmd.Parameters.AddWithValue("@d", id);
                            cmd.Parameters.AddWithValue("@a", jtableno.Text);
                            cmd.Parameters.AddWithValue("@b", jfloorno.Text);
                            cmd.Parameters.AddWithValue("@c", jstatus.Text);
                            cmd.ExecuteNonQuery();
                            conn.Close();

                            MessageBox.Show("Data Inserted");
                            frm1.RefreshGrid();
                            

                            //Reset All Fields
                            jid.Text = "ID";
                            jtableno.Text = "";
                            jfloorno.Text = "";
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
            try
            {
                if (jid.Text != "ID")
                {
                    SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Till_Restuarant_Softwear.Properties.Settings.Setting"].ToString());
                    //SqlConnection conn = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Integrated Security=True");
                    conn.Open();
                    String query = "UPDATE Table_Manage SET TableNo='" + jtableno.Text + "',FloorNo='" + jfloorno.Text + "',Status='" + jstatus.Text + "'WHERE ID='" + jid.Text + "'";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Updated");
                    conn.Close();

                    frm1.RefreshGrid();
                   

                    jid.Text = "ID";
                    jtableno.Text = "";
                    jfloorno.Text = "";

                    View_Table_Management.column_id="ID";
                    View_Table_Management.column_tableno="";
                    View_Table_Management.column_floorno = "";
                    View_Table_Management.column_status = "Free";
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
            jtableno.Text = "";
            jfloorno.Text = "";
        }
//
//Close Btn
//
        private void JCLOSE_BTN_Click(object sender, EventArgs e)
        {
            this.Hide();

            View_Table_Management.column_id = "ID";
            View_Table_Management.column_tableno = "";
            View_Table_Management.column_floorno = "";
            View_Table_Management.column_status = "Free";
        }
//
//Number Validation
//
        private void jtableno_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(jtableno.Text, "[^0-9]"))
            {
                jtableno.Text = jtableno.Text.Remove(jtableno.Text.Length - 1);
            }
        }
//
//Number Validation
//
        private void jfloorno_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(jfloorno.Text, "[^0-9]"))
            {
                jfloorno.Text = jfloorno.Text.Remove(jfloorno.Text.Length - 1);
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

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
                    String query = "Delete Table_Manage WHERE ID='" + jid.Text + "'";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Deleted");
                    conn.Close();

                    frm1.RefreshGrid();


                    jid.Text = "ID";
                    jtableno.Text = "";
                    jfloorno.Text = "";

                    View_Table_Management.column_id = "ID";
                    View_Table_Management.column_tableno = "";
                    View_Table_Management.column_floorno = "";
                    View_Table_Management.column_status = "Free";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
