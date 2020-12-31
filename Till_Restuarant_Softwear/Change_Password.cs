using System;using System.Configuration;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Till_Restuarant_Softwear
{
    public partial class Change_Password : Form
    {
        public Change_Password()
        {
            InitializeComponent();
        }
//
//Change Btn
//
        private void JCHANGEPASSWORD_BTN_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Till_Restuarant_Softwear.Properties.Settings.Setting"].ToString());
                conn.Open();
                String query1 = "Select * from Resturent_Information Where Password='" + joldpassword.Text + "'";
                SqlCommand cmd1 = new SqlCommand(query1, conn);
                SqlDataReader dr;
                dr = cmd1.ExecuteReader();
                if (dr.Read())
                {
                    conn.Close();
                    if (jnewpassword.Text == jretrypassword.Text)
                    {
                        conn.Open();
                        String query = "UPDATE Resturent_Information SET Password='" + jnewpassword.Text + "'WHERE Password='" + joldpassword.Text + "'";
                        SqlCommand cmd = new SqlCommand(query, conn);
                        cmd.ExecuteNonQuery();
                        conn.Close();

                        MessageBox.Show("Password Changed");
                        jnewpassword.Text = "";
                        joldpassword.Text = "";
                        jretrypassword.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Password Mis-Match");
                    }

                    try
                    {

                       /* MailMessage msg = new MailMessage();
                        msg.From = new MailAddress("advanceeratech@gmail.com");
                        msg.To.Add(dr["Mail"].ToString());
                        msg.Subject = "RMS Change Password Alert";
                        msg.Body = "Hi " + "\n\nYour Password Changed\nYour Password Is:" + jnewpassword.Text + "\n\nFor More Detail Visit Our Site: advanceeratech.com";
                        //msg.Body = "UserName: " + dr["UserName"].ToString() + "\nPassword: " + dr["Password"].ToString();

                        SmtpClient smt = new SmtpClient();
                        smt.Host = "Smtp.gmail.com";
                        System.Net.NetworkCredential ntcd = new NetworkCredential();
                        ntcd.UserName = "advanceeratech@gmail.com";
                        ntcd.Password = "shaban66";
                        smt.Credentials = ntcd;
                        smt.EnableSsl = true;
                        smt.Port = 587;
                        smt.Send(msg);*/
                        //MessageBox.Show("Password Changed", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        joldpassword.Text = "";
                        jnewpassword.Text = "";
                        jretrypassword.Text = "";

                        this.Hide();

                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show(ex.ToString());
                    }
                }
                else
                {
                    MessageBox.Show("Invalid Previous Information");
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
        private void JBTN_RESET_Click(object sender, EventArgs e)
        {
            joldpassword.Text = "";
            jnewpassword.Text = "";
            jretrypassword.Text = "";
        }
//
//Close Btn
//
        private void JBTN_CLOSE_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
