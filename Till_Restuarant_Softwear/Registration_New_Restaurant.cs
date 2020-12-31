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
    public partial class Registration_New_Restaurant : Form
    {
        public Registration_New_Restaurant()
        {
            InitializeComponent();
            fetchkey();

            Random rand1 = new Random();
            int num1 = rand1.Next(1, 5005435);
            int num2 = rand1.Next(1, 5012324);
            int answer = num1 + num2;
            jrendumkey.Text = answer.ToString();

           // mail();
        }
//
//fetch already present key if not found then new register
//
        public void fetchkey()
        {
            try
            {
                SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Till_Restuarant_Softwear.Properties.Settings.Setting"].ToString());
                //SqlConnection conn = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Integrated Security=True");
                conn.Open();
                SqlCommand cmd = new SqlCommand("Select * From Resturent_Information", conn);
                SqlDataReader dr;
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    jkey2.Text = dr["Key"].ToString();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
//
//Random Key Gernate and Sent TO mail
//
        public void mail()
        {
            try
            {

                MailMessage msg = new MailMessage();
                msg.From = new MailAddress("advanceeratech@gmail.com");
                msg.To.Add("advanceeratech@gmail.com");
                msg.Subject = "Registration Key";
                msg.Body = jrendumkey.Text;

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
//Register Btn
//
        private void JREGISTER_BTN_Click(object sender, EventArgs e)
        {
            if (jkey2.Text != "Key1")
            {
                MessageBox.Show("Resturent Aleady Register", "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
            }
            else if (jresturentname.Text == "" || jcontactno.Text == "" || jmail.Text == "" || jaddress.Text == "")
            {
                MessageBox.Show("All Fields Required");
            }
            else if (!this.jmail.Text.Contains('@') || !this.jmail.Text.Contains('.'))
            {
                MessageBox.Show("Please Enter A Valid Email\n\n example@gmail.com", "Invalid Email", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (jregistrationkey.Text == "234"+jrendumkey.Text+"432")
            {
                try
                {
                    //SqlConnection conn = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Integrated Security=True");
                    SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Till_Restuarant_Softwear.Properties.Settings.Setting"].ToString());
                    conn.Open();
                    DialogResult dialogResult = MessageBox.Show("Please Check Detail", "Conform Message", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (dialogResult == DialogResult.Yes)
                    {
                        //Values Inserted into All_Stock_Record
                        String query = "insert into Resturent_Information values(@a,@b,@c,@d,@e,@f,@g)";
                        SqlCommand cmd = new SqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@a", jresturentname.Text);
                        cmd.Parameters.AddWithValue("@b", jcontactno.Text);
                        cmd.Parameters.AddWithValue("@c", jaddress.Text);
                        cmd.Parameters.AddWithValue("@d", jmail.Text);
                        cmd.Parameters.AddWithValue("@e", jregistrationkey.Text);
                        cmd.Parameters.AddWithValue("@f", jpassword.Text);
                        cmd.Parameters.AddWithValue("@g", jusername.Text);
                        cmd.ExecuteNonQuery();
                        conn.Close();
                        

                        jkey2.Text = jregistrationkey.Text;

                        

                        /*try
                        {
                            MailMessage msg = new MailMessage();
                            msg.From = new MailAddress("advanceeratech@gmail.com");
                            msg.To.Add("advanceeratech@gmail.com");
                            msg.To.Add(jmail.Text);
                            msg.Subject = "RMS Register Alert";
                            msg.Body = "Hi " + "\n\nNew Resturant Registered" + "\nResturant Name:" + jresturentname.Text + "\nContact:" + jcontactno.Text + "\nMail: " + jmail.Text + "\nUser Name:" + jusername.Text+ "\nPassword:" + jpassword.Text+ "\nAddress:" + jaddress.Text + "\n\nFor More Detail Visit Our Site: advanceeratech.com";
                            
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

                            MessageBox.Show(ex.ToString());
                        }*/
                        MessageBox.Show("Resturent Registerds\nThanks For Registration");

                        this.Hide();

                        jresturentname.Text = "";
                        jcontactno.Text = "";
                        jaddress.Text = "";
                        jmail.Text = "";
                        jregistrationkey.Text = "";
                        jpassword.Text = "";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }

            }
            else
            {
                MessageBox.Show("Key Invalid");
            }
        }
//
//Close Btn
//
        private void JBTN_CLOSE_Click(object sender, EventArgs e)
        {
            this.Hide();

            Login_Page set = new Login_Page();
            set.Show();
            set.BringToFront();
        }
//
//Reset Btn
//
        private void button2_Click(object sender, EventArgs e)
        {
            jresturentname.Text = "";
            jcontactno.Text = "";
            jaddress.Text = "";
            jmail.Text = "";
            jregistrationkey.Text = "";
            jpassword.Text = "";
        }
//
//Company website link
//
        private void jcompanyWEBSITElink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            jcompanyWEBSITElink.LinkVisited = true;
            System.Diagnostics.Process.Start("https://advanceeratech.com/");
        }
    }
}
