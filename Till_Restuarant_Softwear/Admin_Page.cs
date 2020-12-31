using System;using System.Configuration;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Till_Restuarant_Softwear
{
    public partial class Admin_Page : Form
    {
        public Admin_Page()
        {
            InitializeComponent();

            SETIMAGE();
           video();

        }
        public void video()
        {
            axWindowsMediaPlayer1.URL = @"C:\Users\mudas\Downloads\resturent.mp4";
        }
        public void SETIMAGE()
        {
            try
            {
                for (int i = 1; i < 22; i++)
                {
                    //SqlConnection conn = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Integrated Security=True");
                    SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Till_Restuarant_Softwear.Properties.Settings.Setting"].ToString());
                    conn.Open();
                    SqlDataAdapter da = new SqlDataAdapter("Select Image from Image Where ID='" + i.ToString() + "'", conn);
                    DataSet ds = new DataSet();
                    da.Fill(ds);

                    byte[] image01 = new byte[0];
                    image01 = (byte[])ds.Tables[0].Rows[0]["Image"];
                    MemoryStream stream = new MemoryStream(image01);
                    pictureBox1.Image = Image.FromStream(stream);
                    Bitmap resized = new Bitmap(pictureBox1.Image, new Size(123, 60));

                    if(i==1)
                    {
                        JDASHBOARD_BTN.Image = resized;
                    }
                    else
                    if(i==2)
                    {
                        JUSER_BTN.Image = resized;
                    }
                    else
                    if (i == 3)
                    {
                        JEMPLOYEE_BTN.Image = resized;
                    }
                    else
                    if (i == 4)
                    {
                        JCUSTOMER_BTN.Image = resized;
                    }
                    else
                    if (i == 5)
                    {
                        JSTOCK_BTN.Image = resized;
                    }
                    else
                    if (i == 6)
                    {
                        JMENUMANAGEMENT_BTN.Image = resized;
                    }
                    else
                    if (i == 7)
                    {
                        JMENUCATEGORY_BTN.Image = resized;
                    }
                    else
                    if (i == 8)
                    {
                        JDELIVERYBOY_BTN.Image = resized;
                    }
                    else
                    if (i == 9)
                    {
                        JTABLEMANAGEMENT_BTN.Image = resized;
                    }
                    else
                    if (i == 10)
                    {
                        JEXPENSESTRACKING_BTN.Image = resized;
                    }
                    else
                    if (i == 11)
                    {
                        JVENDOR_BTN.Image = resized;
                    }
                    else
                    if (i == 12)
                    {
                        JOTHERCONTAACT_BTN.Image = resized;
                    }
                    else
                    if (i == 13)
                    {
                        JPOINTOFSALE_BTN.Image = resized;
                    }
                    else
                    if (i == 14)
                    {
                        JBARCODEGERNATOR_BTn.Image = resized;
                    }
                    else
                    if (i == 15)
                    {
                        JREPORTS_BTN.Image = resized;
                    }
                    else
                    if (i == 16)
                    {
                        JCHANGEPASSORD_BTN.Image = resized;
                    }
                    else
                    if (i == 17)
                    {
                        JVIEWALLSALES_BTN.Image = resized;
                    }
                    else
                    if (i == 18)
                    {
                        JEXPORTTOEXCEL_BTN.Image = resized;
                    }
                    else
                    if (i == 19)
                    {
                        JHELP_BTN.Image = resized;
                    }
                    else
                    if (i == 20)
                    {
                        JCLOSE_BTN.Image = resized;
                    }
                    else
                    {
                        Bitmap resized19 = new Bitmap(pictureBox1.Image, new Size(40, 30));
                        JALERT_BTN.Image = resized19;
                    }
                    
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }/*
                Bitmap image = Bitmap.FromFile(@"C:\Users\Nouman\Documents\Visual Studio 2017\Projects\Icons\Dashboard.jpg") as Bitmap;
                Bitmap resized = new Bitmap(image, new Size(123, 60));
                JDASHBOARD_BTN.Image = resized;

                Bitmap image1 = Bitmap.FromFile(@"C:\Users\Nouman\Documents\Visual Studio 2017\Projects\Icons\User.png") as Bitmap;
                Bitmap resized1 = new Bitmap(image1, new Size(123, 60));
                JUSER_BTN.Image = resized1;

                Bitmap image2 = Bitmap.FromFile(@"C:\Users\Nouman\Documents\Visual Studio 2017\Projects\Icons\Customer.jpg") as Bitmap;
                Bitmap resized2 = new Bitmap(image2, new Size(123, 60));
                JCUSTOMER_BTN.Image = resized2;

                Bitmap image3 = Bitmap.FromFile(@"C:\Users\Nouman\Documents\Visual Studio 2017\Projects\Icons\Employee.jpg") as Bitmap;
                Bitmap resized3 = new Bitmap(image3, new Size(123, 60));
                JEMPLOYEE_BTN.Image = resized3;

                Bitmap image4 = Bitmap.FromFile(@"C:\Users\Nouman\Documents\Visual Studio 2017\Projects\Icons\StockManagement.png") as Bitmap;
                Bitmap resized4 = new Bitmap(image4, new Size(123, 60));
                JSTOCK_BTN.Image = resized4;

                Bitmap image5 = Bitmap.FromFile(@"C:\Users\Nouman\Documents\Visual Studio 2017\Projects\Icons\MenuManagement.png") as Bitmap;
                Bitmap resized5 = new Bitmap(image5, new Size(123, 60));
                JMENUMANAGEMENT_BTN.Image = resized5;

                Bitmap image6 = Bitmap.FromFile(@"C:\Users\Nouman\Documents\Visual Studio 2017\Projects\Icons\TableManagement.jpg") as Bitmap;
                Bitmap resized6 = new Bitmap(image6, new Size(123, 60));
                JTABLEMANAGEMENT_BTN.Image = resized6;

                Bitmap image7 = Bitmap.FromFile(@"C:\Users\Nouman\Documents\Visual Studio 2017\Projects\Icons\DeliveryBoy.jpg") as Bitmap;
                Bitmap resized7 = new Bitmap(image7, new Size(123, 60));
                JDELIVERYBOY_BTN.Image = resized7;

                Bitmap image8 = Bitmap.FromFile(@"C:\Users\Nouman\Documents\Visual Studio 2017\Projects\Icons\Vendor.jpg") as Bitmap;
                Bitmap resized8 = new Bitmap(image8, new Size(123, 60));
                JVENDOR_BTN.Image = resized8;

                Bitmap image9 = Bitmap.FromFile(@"C:\Users\Nouman\Documents\Visual Studio 2017\Projects\Icons\OtherContacts.jpg") as Bitmap;
                Bitmap resized9 = new Bitmap(image9, new Size(123, 60));
                JOTHERCONTAACT_BTN.Image = resized9;

                Bitmap image10 = Bitmap.FromFile(@"C:\Users\Nouman\Documents\Visual Studio 2017\Projects\Icons\Expenses.png") as Bitmap;
                Bitmap resized10 = new Bitmap(image10, new Size(123, 60));
                JEXPENSESTRACKING_BTN.Image = resized10;

                Bitmap image11 = Bitmap.FromFile(@"C:\Users\Nouman\Documents\Visual Studio 2017\Projects\Icons\Barcode.png") as Bitmap;
                Bitmap resized11 = new Bitmap(image11, new Size(123, 60));
                JBARCODEGERNATOR_BTn.Image = resized11;

                Bitmap image12 = Bitmap.FromFile(@"C:\Users\Nouman\Documents\Visual Studio 2017\Projects\Icons\Invoices.png") as Bitmap;
                Bitmap resized12 = new Bitmap(image12, new Size(123, 60));
                JREPORTS_BTN.Image = resized12;

                Bitmap image13 = Bitmap.FromFile(@"C:\Users\Nouman\Documents\Visual Studio 2017\Projects\Icons\ChangePassword.jpg") as Bitmap;
                Bitmap resized13 = new Bitmap(image13, new Size(123, 60));
                JCHANGEPASSORD_BTN.Image = resized13;

                Bitmap image14 = Bitmap.FromFile(@"C:\Users\Nouman\Documents\Visual Studio 2017\Projects\Icons\PointOFSALE.jpg") as Bitmap;
                Bitmap resized14 = new Bitmap(image14, new Size(123, 60));
                JPOINTOFSALE_BTN.Image = resized14;

                Bitmap image15 = Bitmap.FromFile(@"C:\Users\Nouman\Documents\Visual Studio 2017\Projects\Icons\Logout.png") as Bitmap;
                Bitmap resized15 = new Bitmap(image15, new Size(123, 60));
                JCLOSE_BTN.Image = resized15;

                Bitmap image16 = Bitmap.FromFile(@"C:\Users\Nouman\Documents\Visual Studio 2017\Projects\Icons\AllSale.png") as Bitmap;
                Bitmap resized16 = new Bitmap(image16, new Size(123, 60));
                JVIEWALLSALES_BTN.Image = resized16;

                Bitmap image17 = Bitmap.FromFile(@"C:\Users\Nouman\Documents\Visual Studio 2017\Projects\Icons\Excel.png") as Bitmap;
                Bitmap resized17 = new Bitmap(image17, new Size(123, 60));
                JEXPORTTOEXCEL_BTN.Image = resized17;

                Bitmap image18 = Bitmap.FromFile(@"C:\Users\Nouman\Documents\Visual Studio 2017\Projects\Icons\MenuCategory1.jpg") as Bitmap;
                Bitmap resized18 = new Bitmap(image18, new Size(123, 60));
                JMENUCATEGORY_BTN.Image = resized18;

                Bitmap image19 = Bitmap.FromFile(@"C:\Users\Nouman\Documents\Visual Studio 2017\Projects\Icons\Notification.png") as Bitmap;
                Bitmap resized19 = new Bitmap(image19, new Size(40, 30));
                JALERT_BTN.Image = resized19;

                Bitmap image20 = Bitmap.FromFile(@"C:\Users\Nouman\Documents\Visual Studio 2017\Projects\Icons\Help.jpg") as Bitmap;
                Bitmap resized20 = new Bitmap(image20, new Size(123, 60));
                JHELP_BTN.Image = resized20;*/
            
        }
//
//Dashboard Coding
//
        private void button1_Click(object sender, EventArgs e)
        {
            Dashboard set = new Dashboard();
            set.Show();
            set.BringToFront();

            //this.Hide();
        }
//
//Alert Btn
//
        private void JALERT_BTN_Click(object sender, EventArgs e)
        {
            Notification_Alert set = new Notification_Alert();
            set.Show();
            set.BringToFront();
            //this.Hide();
        }
//
//Close Btn
//
        private void JCLOSE_BTN_Click(object sender, EventArgs e)
        {
            //Application.Exit();
            DialogResult dialogResult = MessageBox.Show("Do You Want to Logout?","Message",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                this.Close();

                Login_Page set = new Login_Page();
                set.Show();
                set.BringToFront();

                
            }
        }
//
//User Btn
//
        private void JUSER_BTN_Click(object sender, EventArgs e)
        {
            View_User set = new View_User();
            set.Show();
            set.BringToFront();
            //this.Hide();
        }
        //
        //Employee Btn
        //
        private void JEMPLOYEE_BTN_Click(object sender, EventArgs e)
        {
            View_Employee set = new View_Employee();
            set.Show();
            set.BringToFront();
            //this.Hide();
        }
        //
        //Customer Btn
        //
        private void JCUSTOMER_BTN_Click(object sender, EventArgs e)
        {
            View_Customer set = new View_Customer();
            set.Show();
            set.BringToFront();
            // this.Hide();
        }
        
//
//Stock Btn
//
        private void JSTOCK_BTN_Click(object sender, EventArgs e)
        {
            View_Stock set = new View_Stock();
            set.Show();
            set.BringToFront();
            //this.Hide();
        }
        //
        //Menu Management Btn
        //
        private void JMENUMANAGEMENT_BTN_Click(object sender, EventArgs e)
        {
            View_Item_Menu set = new View_Item_Menu();
            set.Show();
            set.BringToFront();

            //this.Hide();
        }
        //
        //Add_Menu_Category Btn
        //
        private void JMENUCATEGORY_BTN_Click(object sender, EventArgs e)
        {
            View_MenuCategory set = new View_MenuCategory();
            set.Show();
            set.BringToFront();

            //this.Hide();
        }
        //
        //View_Table_Management Btn
        //
        private void JTABLEMANAGEMENT_BTN_Click(object sender, EventArgs e)
        {
            View_Table_Management set = new View_Table_Management();
            set.Show();
            set.BringToFront();
            //this.Hide();
        }
        //
        //View_Expenses_Tracking Btn
        //
        private void JEXPENSESTRACKING_BTN_Click(object sender, EventArgs e)
        {
            View_Expenses_Tracking set = new View_Expenses_Tracking();
            set.Show();
            set.BringToFront();
            //this.Hide();
        }
        //
        //Menu Management Btn
        //
        private void JDELIVERYBOY_BTN_Click(object sender, EventArgs e)
        {
            View_Delivery_Boy set = new View_Delivery_Boy();
            set.Show();
            set.BringToFront();
            //this.Hide();
        }
        //
        //View_Vendor_Management Btn
        //
        private void JVENDOR_BTN_Click(object sender, EventArgs e)
        {
            View_Vendor_Management set = new View_Vendor_Management();
            set.Show();
            set.BringToFront();
            //this.Hide();
        }
        //
        //other Contact Btn
        //
        private void JOTHERCONTAACT_BTN_Click(object sender, EventArgs e)
        {
            View_Other_Contact set = new View_Other_Contact();
            set.Show();
            set.BringToFront();
            //this.Hide();
        }
        //
        //Barcode Btn
        //
        private void JBARCODEGERNATOR_BTn_Click(object sender, EventArgs e)
        {
            Barcode set = new Barcode();
            set.Show();
            set.BringToFront();
            //this.Hide();
        }
        //
        //Reports Btn
        //
        private void JREPORTS_BTN_Click(object sender, EventArgs e)
        {
            Reports set = new Reports();
            set.Show();
            set.BringToFront();
            //this.Hide();
        }
        //
        //Change_Password Btn
        //
        private void JCHANGEPASSORD_BTN_Click(object sender, EventArgs e)
        {
            Change_Password set = new Change_Password();
            set.Show();
            set.BringToFront();
           // this.Hide();
        }
//
//Point Of Sale
//
        private void JPOINTOFSALE_BTN_Click(object sender, EventArgs e)
        {
            Point_Of_Sale set = new Point_Of_Sale();
            set.Show();
            set.BringToFront();

            //        this.Hide();
        }

        private void JVIEWALLSALES_BTN_Click(object sender, EventArgs e)
        {
            Check_Sales set = new Check_Sales();
            set.Show();
            set.BringToFront();

            //this.Hide();
        }

        private void JEXPORTTOEXCEL_BTN_Click(object sender, EventArgs e)
        {
            Send_Email set = new Send_Email();
            set.Show();
            set.BringToFront();
            /* if(dataGridView1.Rows.Count>0)
            {
                Microsoft.Office.Interop.Excel.Application excle = new Microsoft.Office.Interop.Excel.Application();
                excle.Application.Workbooks.Add(Type.Missing);
                for(int i=0;i<dataGridView1.Columns.Count;i++)
                {
                    excle.Cells[1, i] = dataGridView1.Columns[i-1].HeaderText;
                }
                for(int i = 0; i < dataGridView1.Rows.Count ; i++)
                {
                    for (int j = 0; j < dataGridView1.Columns.Count; j++)
                    {
                        excle.Cells[i + 2, j + 1] = dataGridView1.Rows[i].Cells[j].Value.ToString();
                    }
                }
                excle.Columns.AutoFit();
                excle.Visible = true;
            }*/
            //MessageBox.Show("Code Done\n\nMS Excel Not Parasent In This PC");
        }
//
//Help Btn
//
        private void JHELP_BTN_Click(object sender, EventArgs e)
        {
           System.Diagnostics.Process.Start("https://www.youtube.com/watch?v=K3qk3GcKSTM");

        }
//
//Screen Keyboard Btn
//
        private void JSCREENKEYBOARD_BTN_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("osk.exe");
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BTN_BROWSER_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "(mp3,wav,mp4,mov,wmv,mpg)|*.mp3;*.wav;*.mp4;*.mov;*.wmv;*.mpg|all files|*.*";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
                axWindowsMediaPlayer1.URL = openFileDialog1.FileName;
        }
    }
}
