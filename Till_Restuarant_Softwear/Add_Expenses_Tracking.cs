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
    public partial class Add_Expenses_Tracking : Form
    {
        private readonly View_Expenses_Tracking frm1;
        public Add_Expenses_Tracking(View_Expenses_Tracking frm)
        {
            InitializeComponent();

            frm1 = frm;
            SetValues();
        }
        public void SetValues()
        {
            jid.Text = View_Expenses_Tracking.column_id;
            jamount.Text = View_Expenses_Tracking.column_amount;
            jcategory.Text = View_Expenses_Tracking.column_category;
            jdescription.Text = View_Expenses_Tracking.column_description;
        }
//
//Add Btn Coding
//
        private void JBTN_ADD_Click(object sender, EventArgs e)
        {
            if (jid.Text == "ID")
            {
                try
                {
                    String thisMonth = DateTime.Now.ToString("MM/yyyy");
                    String thisYear = DateTime.Now.ToString("yyyy");

                    // SqlConnection conn = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Integrated Security=True");
                    SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Till_Restuarant_Softwear.Properties.Settings.Setting"].ToString());
                    conn.Open();
                    if (jdate.Text == "" || jamount.Text == "" || jcategory.Text == "" || jdescription.Text == "")
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
                            String query = "insert into Expenses values (@g,@a,@b,@c,@d,@e,@f)";
                            SqlCommand cmd = new SqlCommand(query, conn);
                            cmd.Parameters.AddWithValue("@g", id);
                            cmd.Parameters.AddWithValue("@a", jdescription.Text);
                            cmd.Parameters.AddWithValue("@b", jamount.Text);
                            cmd.Parameters.AddWithValue("@c", jdate.Text);
                            cmd.Parameters.AddWithValue("@d", jcategory.Text);
                            cmd.Parameters.AddWithValue("@e", thisMonth);
                            cmd.Parameters.AddWithValue("@f", thisYear);
                            cmd.ExecuteNonQuery();
                            conn.Close();
                            MessageBox.Show("Data Inserted");

                            frm1.RefreshGrid();
                            
                            //Reset All Fields
                            jid.Text = "ID";
                            jdate.Text = "";
                            jamount.Text = "";
                            jcategory.Text = "";
                            jdescription.Text = "";
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
                    // SqlConnection conn = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Integrated Security=True");
                    SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Till_Restuarant_Softwear.Properties.Settings.Setting"].ToString());
                    conn.Open();
                    String query = "UPDATE Expenses SET Amount='" + jamount.Text + "',Category='" + jcategory.Text + "',Discription='" + jdescription.Text + "'WHERE ID='" + jid.Text + "'";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.ExecuteNonQuery();
                    conn.Close();

                    MessageBox.Show("Updated");
                    frm1.RefreshGrid();
                    
                    jid.Text = "ID";
                    jdate.Text = "";
                    jamount.Text = "";
                    jcategory.Text = "";
                    jdescription.Text = "";
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
            jdate.Text = "";
            jamount.Text = "";
            jcategory.Text = "";
            jdescription.Text = "";
        }
//
//Close Btn
//
        private void JBTN_CLOSE_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

//
// Delete BTN
//
  
      private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (jid.Text != "ID")
                {
                    // SqlConnection conn = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Integrated Security=True");
                    SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Till_Restuarant_Softwear.Properties.Settings.Setting"].ToString());
                    conn.Open();
                    String query = "Delete Expenses WHERE ID='" + jid.Text + "'";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.ExecuteNonQuery();
                    conn.Close();

                    MessageBox.Show("Deleted");
                    frm1.RefreshGrid();

                    jid.Text = "ID";
                    jdate.Text = "";
                    jamount.Text = "";
                    jcategory.Text = "";
                    jdescription.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
