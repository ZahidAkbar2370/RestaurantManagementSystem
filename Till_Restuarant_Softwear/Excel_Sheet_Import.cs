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
    public partial class Excel_Sheet_Import : Form
    {
        public Excel_Sheet_Import()
        {
            InitializeComponent();
            View();
        }
        public void View()
        {
            try
            {
                SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Till_Restuarant_Softwear.Properties.Settings.Setting"].ToString());
                //SqlConnection conn = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Integrated Security=True");
                conn.Open();
                SqlDataAdapter sqlDA = new SqlDataAdapter("Select ID From Image ", conn);
                DataTable dt = new DataTable();
                sqlDA.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void JEXPORT_BTn_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < 10; i++)
                {
                    dataGridView1.Rows.Add(i.ToString(), i.ToString(), i.ToString());

                }
                Microsoft.Office.Interop.Excel.Application excle = new Microsoft.Office.Interop.Excel.Application();
                excle.Application.Workbooks.Add(Type.Missing);
                for (int i = 1; i < dataGridView1.Columns.Count+1; i++)

                    {
                        excle.Cells[1, i] = dataGridView1.Columns[i - 1].HeaderText;
                    }
                    for (int i = 0; i < dataGridView1.Rows.Count; i++)
                    {
                        for (int j = 0; j < dataGridView1.Columns.Count; j++)
                        {
                            excle.Cells[i + 2, j + 1] = dataGridView1.Rows[i].Cells[j].Value.ToString();
                        }
                    }
                    excle.Columns.AutoFit();
                    excle.Visible = true;
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count < 22)
            {
                try
                {
                    OpenFileDialog open = new OpenFileDialog();
                    open.Filter = "Image File(*.jpeg;*.png;*.jpg)|*.jpeg;*.bmp;*.png;*.jpg";
                    if (open.ShowDialog() == DialogResult.OK)
                    {
                        textBox1.Text = open.FileName;



                        String image = textBox1.Text;
                        Bitmap bmp = new Bitmap(image);
                        FileStream fs = new FileStream(image, FileMode.Open, FileAccess.Read);
                        byte[] bimage = new byte[fs.Length];
                        fs.Read(bimage, 0, Convert.ToInt32(fs.Length));
                        fs.Close();

                        int No = Convert.ToInt32(label1.Text);
                        int Nos = No + 1;
                        label1.Text = Nos.ToString();

                        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Till_Restuarant_Softwear.Properties.Settings.Setting"].ToString());
                        //SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database2.mdf;Integrated Security=True;Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\Nouman\Documents\Visual Studio 2017\Projects\Till_Restuarant_Softwear\Till_Restuarant_Softwear\Database2.mdf; Integrated Security = True");
                        conn.Open();

                        SqlCommand cmd = new SqlCommand("insert into Image values(@a,@b)", conn);
                        cmd.Parameters.AddWithValue("@a", label1.Text);
                        cmd.Parameters.AddWithValue("@b", SqlDbType.Image).Value = bimage;
                        cmd.ExecuteNonQuery();
                        conn.Close();

                        MessageBox.Show("Inserted");
                        textBox1.Text = "";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            else
            {
                MessageBox.Show("Icons Already Register");
            }
            
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("Emplloyee Name", new Font("Arial", 15, FontStyle.Bold), Brushes.Black, new Point(0, 10));
            e.Graphics.DrawString("Status", new Font("Arial", 15, FontStyle.Bold), Brushes.Black, new Point(290, 10));
            e.Graphics.DrawString("Date", new Font("Arial", 15, FontStyle.Bold), Brushes.Black, new Point(520, 10));

            e.Graphics.DrawString("Emplloyee Name", new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(0, 40));
            e.Graphics.DrawString("Status", new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(290, 40));
            e.Graphics.DrawString("Date", new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(520, 40));

            e.Graphics.DrawString("__________________________________________________________________________________", new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(0, 60));

            ///
            //Payments
            //
            e.Graphics.DrawString("Payments", new Font("Arial", 20, FontStyle.Bold), Brushes.Black, new Point(20, 95));


            e.Graphics.DrawString("Basic Salary", new Font("Arial", 15, FontStyle.Bold), Brushes.Black, new Point(0, 150));
            e.Graphics.DrawString("Over Time", new Font("Arial", 15, FontStyle.Bold), Brushes.Black, new Point(0, 190));
            e.Graphics.DrawString("SSP", new Font("Arial", 15, FontStyle.Bold), Brushes.Black, new Point(0, 220));

            e.Graphics.DrawString("500", new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(290, 150));
            e.Graphics.DrawString("00", new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(290, 190));
            e.Graphics.DrawString("00", new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(290, 220));

            e.Graphics.DrawString("_____________________________________________________________________________________________", new Font("Arial", 10, FontStyle.Regular), Brushes.Black, new Point(0, 245));


            e.Graphics.DrawString("Total Payment", new Font("Arial", 15, FontStyle.Bold), Brushes.Black, new Point(0, 270));
            e.Graphics.DrawString("00", new Font("Arial", 15, FontStyle.Bold), Brushes.Black, new Point(290, 270));

            //
            //Deduction
            //
            e.Graphics.DrawString("Deduction", new Font("Arial", 20, FontStyle.Bold), Brushes.Black, new Point(420, 95));


            e.Graphics.DrawString("Income Tax", new Font("Arial", 15, FontStyle.Bold), Brushes.Black, new Point(410, 150));
            e.Graphics.DrawString("National Insurance", new Font("Arial", 15, FontStyle.Bold), Brushes.Black, new Point(410, 190));

            e.Graphics.DrawString("500", new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(650, 150));
            e.Graphics.DrawString("00", new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(650, 190));

            e.Graphics.DrawString("Total Deduction", new Font("Arial", 15, FontStyle.Bold), Brushes.Black, new Point(420, 270));
            e.Graphics.DrawString("00", new Font("Arial", 15, FontStyle.Bold), Brushes.Black, new Point(650, 270));

            e.Graphics.DrawString("_____________________________________________________________________________________________", new Font("Arial", 10, FontStyle.Bold), Brushes.Black, new Point(0, 290));

            e.Graphics.DrawString("Hotal Name and address", new Font("Arial", 15, FontStyle.Bold), Brushes.Black, new Point(20, 330));

            e.Graphics.DrawString("Total Payment", new Font("Arial", 15, FontStyle.Bold), Brushes.Red, new Point(420, 330));

            e.Graphics.DrawString("Total Deduction", new Font("Arial", 15, FontStyle.Bold), Brushes.Black, new Point(420, 370));
            e.Graphics.DrawString("Total Payment", new Font("Arial", 15, FontStyle.Bold), Brushes.Black, new Point(420, 400));

            e.Graphics.DrawString("00", new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(590, 370));
            e.Graphics.DrawString("00", new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(590, 400));

            e.Graphics.DrawString("___________________________________________________________________________________", new Font("Arial", 15, FontStyle.Regular), Brushes.Black, new Point(0, 420));

            e.Graphics.DrawString("Total:", new Font("Arial", 15, FontStyle.Bold), Brushes.Black, new Point(430, 460));
            e.Graphics.DrawString("0000", new Font("Arial", 15, FontStyle.Bold), Brushes.Black, new Point(590, 460));
        }

        private void JEXPORTUSERDATA_BTN_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }
    }
}
