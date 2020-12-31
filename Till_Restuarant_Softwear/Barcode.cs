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
    public partial class Barcode : Form
    {
        public Barcode()
        {
            InitializeComponent();
            View();
        }
        public void View()
        {
            try
            {
                SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["Till_Restuarant_Softwear.Properties.Settings.Setting"].ToString());
                conn.Open();
                SqlDataAdapter sqlDA = new SqlDataAdapter("Select* From Stock ", conn);
                DataTable dt = new DataTable();
                sqlDA.Fill(dt);
                jselectproduct.DataSource = dt;
                jselectproduct.DisplayMember = "Barcode";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
                //
                //Invoice Design
                //
                private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            try
            {

                if (jenterlabel.Text == "")
                {
                    MessageBox.Show("Labels Required");
                }
                //Document invoice making
                else
                {
                    String barcode = jenterlabel.Text.ToString();
                    Zen.Barcode.Code128BarcodeDraw brcode = Zen.Barcode.BarcodeDrawFactory.Code128WithChecksum;
                    pictureBox1.Image = brcode.Draw(barcode, 60);
                    Double quantity = Convert.ToDouble(jenterlabel.Text.ToString());

                    e.Graphics.DrawString("ADVANCE ERA TECH BARCODE GENERATOR", new Font("Arial", 20, FontStyle.Bold), Brushes.Red, new Point(50, 15));

                    int y_axis = 60;
                    int x_axis = 5;
                    for (int i = 0; i <= quantity; i++)
                    {

                        if (x_axis < 600)
                        {
                            e.Graphics.DrawImage(pictureBox1.Image, x_axis, y_axis);
                            x_axis += 280;
                        }
                        else
                        {
                            x_axis = 10;
                            y_axis += 100;
                            e.Graphics.DrawImage(pictureBox1.Image, x_axis, y_axis);
                        }

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
//
//Gernate Btn
//
        private void JBTN_GERNATE_Click(object sender, EventArgs e)
        {
             String barcode = jselectproduct.Text.ToString();
           try
           {
               Zen.Barcode.Code128BarcodeDraw brcode = Zen.Barcode.BarcodeDrawFactory.Code128WithChecksum;
               pictureBox1.Image = brcode.Draw(barcode, 60);
                DialogResult dialogResult = MessageBox.Show("Do you Want To Save Barcode?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(dialogResult==DialogResult.Yes)
                {
                    SaveFileDialog sfd = new SaveFileDialog();
                    sfd.Filter = "*.jpg|*.jpg";
                    DialogResult dr = sfd.ShowDialog();
                    if (dr == DialogResult.OK)
                    {
                        pictureBox1.Image.Save(sfd.FileName, System.Drawing.Imaging.ImageFormat.Jpeg);
                        MessageBox.Show("Image Saved successfully.");
                    }
                }

           }
           catch (Exception ex)
           {
               MessageBox.Show(ex.ToString());
           }
        }
//
//Print Btn
//
        private void JBTNPRINT_Click(object sender, EventArgs e)
        {
            if (jenterlabel.Text == "")
            {
                MessageBox.Show("Enter Lables");
            }
            else
            {

                printPreviewDialog1.Document = printDocument1;
                printPreviewDialog1.ShowDialog();

                jenterlabel.Text = "";
                pictureBox1.Image = null;
                pictureBox1.Invalidate();
            }
        }
//
//Enter Only Number Validation
//
        private void jenterlabel_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(jenterlabel.Text, "[^0-9]"))
            {
                jenterlabel.Text = jenterlabel.Text.Remove(jenterlabel.Text.Length - 1);
                MessageBox.Show("Enter Only Number");
            }
        }
//
//Close Btn
//
        private void JBTN_Close_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin_Page set = new Admin_Page();
            set.Show();
            set.BringToFront();
        }
    }
}
