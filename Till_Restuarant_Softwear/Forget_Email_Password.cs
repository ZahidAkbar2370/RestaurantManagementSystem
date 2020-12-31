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
    public partial class Forget_Email_Password : Form
    {
        public Forget_Email_Password()
        {
            InitializeComponent();

            fetchkey();
        }
        //
        //Fetch Already register Key
        //
        public void fetchkey()
        {
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Till_Restuarant_Softwear.Properties.Settings.Setting"].ToString());
            conn.Open();
            SqlCommand cmd = new SqlCommand("Select * From Resturent_Information", conn);
            SqlDataReader dr;
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                jcode.Text = dr["Key"].ToString();
            }
        }
        //
        //Gernate Code
        //
        public void mail()
        {
            try
            {

                MailMessage msg = new MailMessage();
                msg.From = new MailAddress("advanceeratech@gmail.com");
                msg.To.Add("advanceeratech@gmail.com");
                msg.Subject = "Key";
                msg.Body = jcode.Text;

                SmtpClient smt = new SmtpClient();
                smt.Host = "Smtp.gmail.com";
                System.Net.NetworkCredential ntcd = new NetworkCredential();
                ntcd.UserName = "advanceeratech@gmail.com";
                ntcd.Password = "shaban66";
                smt.Credentials = ntcd;
                smt.EnableSsl = true;
                smt.Port = 587;
                smt.Send(msg);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
//
//Update Button Coding
//
        private void JUPDATEBTN_Click(object sender, EventArgs e)
        {
            try
            {
                if (jcode.Text == jentercodegetfromadvancereratech.Text)
                {
                    SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Till_Restuarant_Softwear.Properties.Settings.Setting"].ToString());
                    conn.Open();
                    String query = "UPDATE Resturent_Information SET Password='" + jenternewpassword.Text + "', Mail='" + jenternewemail.Text + "', UserName='" + jenternewusername.Text+ "'";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.ExecuteNonQuery();
                    conn.Close();

                    try
                    {

                        MailMessage msg = new MailMessage();
                        msg.From = new MailAddress("advanceeratech@gmail.com");
                        msg.To.Add("advanceeratech@gmail.com");
                        msg.Subject = "System Secured";
                        msg.Body ="Hi\nNow Your Software Is Recovered\n\nYour New Email is :"+jenternewemail.Text+"\nNew Password Is :"+jenternewpassword.Text;

                        SmtpClient smt = new SmtpClient();
                        smt.Host = "Smtp.gmail.com";
                        System.Net.NetworkCredential ntcd = new NetworkCredential();
                        ntcd.UserName = "advanceeratech@gmail.com";
                        ntcd.Password = "shaban66";
                        smt.Credentials = ntcd;
                        smt.EnableSsl = true;
                        smt.Port = 587;
                        smt.Send(msg);
                        MessageBox.Show("Now Your System Secured\n\nNow Your UserName And Password Is..." + "\n\nUserName:" + jenternewusername.Text + "\nPassword:" + jenternewpassword.Text);

                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show(ex.Message);
                    }

                   


                    jenternewemail.Text = "";
                    jenternewpassword.Text = "";
                    jenternewusername.Text = "";
                    jcode.Text = jentercodegetfromadvancereratech.Text;
                    jentercodegetfromadvancereratech.Text = "";

                    this.Hide();

                }
                else
                {
                    MessageBox.Show("Invalid Code");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
//
//Reset Btn
//
        private void jRESETBTN_Click(object sender, EventArgs e)
        {
            jenternewemail.Text = "";
            jenternewpassword.Text = "";
            jenternewusername.Text = "";
            jentercodegetfromadvancereratech.Text = "";
        }
    }
}
