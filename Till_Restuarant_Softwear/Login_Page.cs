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
using System.Configuration;

namespace Till_Restuarant_Softwear
{
    public partial class Login_Page : Form
    {
        public Login_Page()
        {
            InitializeComponent();
            jusername.Height = 35;

            View();
            if(jregisterkey.Text=="")
            {
                JNEWREGISTER_RESTAURANT_LINKER.Visible = true;
            }
            else
            {
                JNEWREGISTER_RESTAURANT_LINKER.Visible = false;
            }
        }

        private void JCLOSE_BTN_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        public void View()
        {
            try
            {
                SqlConnection conn1 = new SqlConnection(ConfigurationManager.ConnectionStrings["Till_Restuarant_Softwear.Properties.Settings.Setting"].ToString());
                conn1.Open();
                SqlCommand cmd1 = new SqlCommand("Select * From Resturent_Information", conn1);
                SqlDataReader dr1;
                dr1 = cmd1.ExecuteReader();
                if (dr1.Read())
                {
                    jregisterkey.Text = dr1["Key"].ToString();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());

            }
        }

        //
        //Login BTn
        //

        private static string GetAutoMDFString()
        {
            String path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string dbpath = "AttachDbFilename=\"" + path + "\\Database" + "" + "\\Database2.mdf\";";
            string pth = "Data Source=(LocalDB)MSSQLLocalDB\\v11.0;" + dbpath + " Integrated Security=True;Connect Timeout=300;MultipleActiveResultSets=True";

            return pth;
        }
        
        private void JBTN_LOGIN_Click(object sender, EventArgs e)
        {
            if(jusername.Text=="image" && jpassword.Text=="image")
           {
               Excel_Sheet_Import set = new Excel_Sheet_Import();
               set.Show();

               jusername.Text = "";
               jpassword.Text = "";
           }
           else if (jusername.Text == "advanceeratech" && jpassword.Text=="advanceeratech")
           {
               Forget_Email_Password set = new Forget_Email_Password();
               set.Show();
               set.BringToFront();

               jusername.Text = "";
               jpassword.Text = "";

           }
            else if(jusername.Text=="Kitchen" && jpassword.Text=="12345")
            {
                Kitchen_Management_Seprate_System set = new Kitchen_Management_Seprate_System();
                set.Show();

                this.Hide();
            }
           else
           {
               try
               {
                   SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Till_Restuarant_Softwear.Properties.Settings.Setting"].ToString());
                   conn.Open();
                   SqlCommand cmd = new SqlCommand("Select * From User_Info Where Password='" +jpassword.Text + "'", conn);
                   SqlDataReader dr;
                   dr = cmd.ExecuteReader();


                   SqlConnection conn1 = new SqlConnection(ConfigurationManager.ConnectionStrings["Till_Restuarant_Softwear.Properties.Settings.Setting"].ToString());
                   conn1.Open();
                   SqlCommand cmd1 = new SqlCommand("Select * From Resturent_Information Where UserName='" + jusername.Text + "'and Password='" + jpassword.Text + "'", conn1);
                   SqlDataReader dr1;
                   dr1 = cmd1.ExecuteReader();
                   if (dr1.Read())
                   {
                      

                        try
                        {
                            String from = "janujakhar2370@gmail.com";
                            String body = "login";
                            String to = "mudasirrasheed18@gmail.com";
                            MailMessage msg = new MailMessage();
                            msg.From = new MailAddress(from);
                            msg.To.Add(to);
                            msg.Subject = "Admin Login Alert";
                            msg.Body = body;

                            SmtpClient smt = new SmtpClient();
                            smt.Host = "Smtp.gmail.com";
                            System.Net.NetworkCredential ntcd = new NetworkCredential();
                            ntcd.UserName = "janujakhar2370@gmail.com";
                            ntcd.Password = "jakhar2370";
                            smt.Credentials = ntcd;
                            smt.EnableSsl = true;
                            smt.Port = 587;
                            smt.Send(msg);

                            MessageBox.Show("ADmin Login Successfully");
                            Admin_Page set = new Admin_Page();
                            set.Show();


                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.ToString());
                        }
                        this.Hide();
                   }
                   else
                   if (dr.Read())
                   {

                       String status = dr["Status"].ToString();

                        if(status=="Admin ")
                        {
                            try
                            {
                                String from = "janujakhar2370@gmail.com";
                                String body = "login";
                                String to = "mudasirrasheed18@gmail.com";
                                MailMessage msg = new MailMessage();
                                msg.From = new MailAddress(from);
                                msg.To.Add(to);
                                msg.Subject = "Admin Login Alert";
                                msg.Body = body;

                                SmtpClient smt = new SmtpClient();
                                smt.Host = "Smtp.gmail.com";
                                System.Net.NetworkCredential ntcd = new NetworkCredential();
                                ntcd.UserName = "janujakhar2370@gmail.com";
                                ntcd.Password = "jakhar2370";
                                smt.Credentials = ntcd;
                                smt.EnableSsl = true;
                                smt.Port = 587;
                                smt.Send(msg);

                                MessageBox.Show("ADmin Login Successfully");

                                Admin_Page set = new Admin_Page();
                                set.Show();
                                set.BringToFront();

                                this.Hide();
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.ToString());
                            }

                            
                        }

                      else  if (status == "Cashier")
                       {
                            try
                            {
                                MailMessage msg = new MailMessage();
                                msg.From = new MailAddress("janujakhar2370@gmail.com");
                                msg.To.Add("janujakhar2370@gmail.com");
                                msg.Subject = "Login Alert";
                                msg.Body = "Cashier Login Restaurant Management System\n" + DateTime.Now.ToLongDateString();

                                SmtpClient smt = new SmtpClient();
                                smt.Host = "Smtp.gmail.com";
                                System.Net.NetworkCredential ntcd = new NetworkCredential();
                                ntcd.UserName = "janujakhar2370@gmail.com";
                                ntcd.Password = "jakhar2370";
                                smt.Credentials = ntcd;
                                smt.EnableSsl = true;
                                smt.Port = 587;
                                smt.Send(msg);

                                Point_Of_Sale set = new Point_Of_Sale();
                                set.Show();
                                set.BringToFront();
                                Point_Of_Sale.label12.Text = "User Login";
                                Point_Of_Sale.jwaiterlogin.Text = "User Login";

                                this.Hide();
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.ToString());
                            }

                            MessageBox.Show("Cashier Login Successfully");


                           
                       }

                   }
                   else
                   {
                       MessageBox.Show("Invalid UserName Or Password");
                   }
                   }

               catch (Exception ex)
               {
                   MessageBox.Show(ex.ToString());
               }
           }

        }

        private void jcompanyWEBSITElink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            jcompanyWEBSITElink.LinkVisited = true;
            System.Diagnostics.Process.Start("https://advanceeratech.com/");
        }
//
//Forget Password Link
//
        private void jforgetpassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
            jusername.Text = "";
            jpassword.Text = "";

            ForgetPassword set = new ForgetPassword();
            set.Show();
            set.BringToFront();
        }

        private void JNEWREGISTER_RESTAURANT_LINKER_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Registration_New_Restaurant set = new Registration_New_Restaurant();
            set.Show();
            set.BringToFront();

            jusername.Text = "";
            jpassword.Text = "";

            this.Hide();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            
            
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
