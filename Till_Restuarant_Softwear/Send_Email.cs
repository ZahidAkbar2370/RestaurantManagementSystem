using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Windows.Forms;

namespace Till_Restuarant_Softwear
{
    public partial class Send_Email : Form
    {
        public Send_Email()
        {
            InitializeComponent();
        }

        private void BTN_RESET_Click(object sender, EventArgs e)
        {
            selectreceiver.Text = "";
            jentermessage.Text = "";
        }

        private void BTN_Submit_Click(object sender, EventArgs e)
        {
            if (selectreceiver.Text == "Employees")
            {
                try
                {

                    SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Till_Restuarant_Softwear.Properties.Settings.Setting"].ToString());
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("Select * FROM Employee", conn);
                    SqlDataReader dr;
                    dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        try
                        {
                            MailMessage msg = new MailMessage();
                            msg.From = new MailAddress(jenteryouremail.Text);
                            msg.To.Add(dr["email"].ToString());
                            msg.Subject = "Info";
                            msg.Body = jentermessage.Text;

                            SmtpClient smt = new SmtpClient();
                            smt.Host = "Smtp.gmail.com";
                            System.Net.NetworkCredential ntcd = new NetworkCredential();
                            ntcd.UserName = "janujakhar2370@gmail.com";
                            ntcd.Password = "jakhar2370";
                            smt.Credentials = ntcd;
                            smt.EnableSsl = true;
                            smt.Port = 587;
                            smt.Send(msg);
                        }
                        catch(Exception ex)
                        {
                            MessageBox.Show(ex.ToString());
                        }

                    }
                    
                    MessageBox.Show("Email Sent To Employees", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    jentermessage.Text = "";
                    selectreceiver.Text = "";
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }
            else if(selectreceiver.Text=="Customers")
            {
                try
                {

                    SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Till_Restuarant_Softwear.Properties.Settings.Setting"].ToString());
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("Select * FROM Customer", conn);
                    SqlDataReader dr;
                    dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        try
                        {
                            MailMessage msg = new MailMessage();
                            msg.From = new MailAddress(jenteryouremail.Text);
                            msg.To.Add(dr["email"].ToString());
                            msg.Subject = "Info";
                            msg.Body = jentermessage.Text;

                            SmtpClient smt = new SmtpClient();
                            smt.Host = "Smtp.gmail.com";
                            System.Net.NetworkCredential ntcd = new NetworkCredential();
                            ntcd.UserName = "janujakhar2370@gmail.com";
                            ntcd.Password = "jakhar2370";
                            smt.Credentials = ntcd;
                            smt.EnableSsl = true;
                            smt.Port = 587;
                            smt.Send(msg);
                        }
                        catch(Exception ex)
                        {
                            MessageBox.Show(ex.ToString());
                        }
                    }

                    MessageBox.Show("Email Sent To Customers", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    jentermessage.Text = "";
                    selectreceiver.Text = "";

                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Receiver Invalid");
            }
            
           
        }
    }
}
