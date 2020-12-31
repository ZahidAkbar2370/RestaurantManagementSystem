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
    public partial class ForgetPassword : Form
    {
        public ForgetPassword()
        {
            InitializeComponent();
        }

        private void jregisteremail_TextChanged(object sender, EventArgs e)
        {
            
        }
//
//Forget Btn
//
        private void JFORGETBTN_Click(object sender, EventArgs e)
        {
            if (jregisteremail.Text == "")
            {
                MessageBox.Show("Enter Your Mail", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            if (!this.jregisteremail.Text.Contains('@') || !this.jregisteremail.Text.Contains('.'))
            {
                MessageBox.Show("Please Enter A Valid Email\n\n example@gmail.com", "Invalid Email", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                
                try
                {
                    SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Till_Restuarant_Softwear.Properties.Settings.Setting"].ToString());
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("Select * From Resturent_Information Where Mail='" + jregisteremail.Text + "'", conn);
                    SqlDataReader dr;
                    dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        jpassword.Text ="Your Password Is :  "+ dr["Password"].ToString();
                        
                        //gmail Connection
                       try
                        {

                            MailMessage msg = new MailMessage();
                            msg.From = new MailAddress("janujakhar2370@gmail.com");
                            msg.To.Add(jregisteremail.Text);
                            msg.Subject = "Recover password";
                            msg.Body = "Hi " +jpassword.Text + "\n\nFor More Detail Visit Our Site: https://advanceeratech.com/";

                            SmtpClient smt = new SmtpClient();
                            smt.Host = "Smtp.gmail.com";
                            System.Net.NetworkCredential ntcd = new NetworkCredential();
                            ntcd.UserName = "janujakhar2370@gmail.com";
                            ntcd.Password = "jakhar2370";
                            smt.Credentials = ntcd;
                            smt.EnableSsl = true;
                            smt.Port = 587;
                            smt.Send(msg);
                            MessageBox.Show("Password Sent To Your Mail", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                        catch (Exception ex)
                        {

                            MessageBox.Show(ex.Message);
                        }
                      
                        jregisteremail.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Please Enter Your Register Email");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }
//
//Close Btn
//
        private void JCLOSE_BTN_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
//
//reset Btn
//
        private void button1_Click(object sender, EventArgs e)
        {
            jpassword.Text = "";
            jregisteremail.Text = "";
        }
    }
}
