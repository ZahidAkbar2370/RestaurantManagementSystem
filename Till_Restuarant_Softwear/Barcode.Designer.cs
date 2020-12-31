namespace Till_Restuarant_Softwear
{
    partial class Barcode
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Barcode));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.JBTNPRINT = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.jenterlabel = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.jselectproduct = new System.Windows.Forms.ComboBox();
            this.JBTN_GERNATE = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(373, 221);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(361, 117);
            this.pictureBox1.TabIndex = 41;
            this.pictureBox1.TabStop = false;
            // 
            // JBTNPRINT
            // 
            this.JBTNPRINT.BackColor = System.Drawing.Color.DarkOrange;
            this.JBTNPRINT.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.JBTNPRINT.Location = new System.Drawing.Point(551, 162);
            this.JBTNPRINT.Name = "JBTNPRINT";
            this.JBTNPRINT.Size = new System.Drawing.Size(80, 23);
            this.JBTNPRINT.TabIndex = 40;
            this.JBTNPRINT.Text = "Print";
            this.JBTNPRINT.UseVisualStyleBackColor = false;
            this.JBTNPRINT.Click += new System.EventHandler(this.JBTNPRINT_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(336, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 16);
            this.label2.TabIndex = 39;
            this.label2.Text = "Select Product";
            // 
            // jenterlabel
            // 
            this.jenterlabel.Location = new System.Drawing.Point(453, 164);
            this.jenterlabel.Name = "jenterlabel";
            this.jenterlabel.Size = new System.Drawing.Size(84, 20);
            this.jenterlabel.TabIndex = 38;
            this.jenterlabel.TextChanged += new System.EventHandler(this.jenterlabel_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(370, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 37;
            this.label3.Text = "Enter Label";
            // 
            // jselectproduct
            // 
            this.jselectproduct.FormattingEnabled = true;
            this.jselectproduct.Location = new System.Drawing.Point(453, 107);
            this.jselectproduct.Name = "jselectproduct";
            this.jselectproduct.Size = new System.Drawing.Size(178, 21);
            this.jselectproduct.TabIndex = 36;
            // 
            // JBTN_GERNATE
            // 
            this.JBTN_GERNATE.BackColor = System.Drawing.Color.DarkOrange;
            this.JBTN_GERNATE.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.JBTN_GERNATE.Location = new System.Drawing.Point(654, 106);
            this.JBTN_GERNATE.Name = "JBTN_GERNATE";
            this.JBTN_GERNATE.Size = new System.Drawing.Size(80, 23);
            this.JBTN_GERNATE.TabIndex = 35;
            this.JBTN_GERNATE.Text = "Gernate";
            this.JBTN_GERNATE.UseVisualStyleBackColor = false;
            this.JBTN_GERNATE.Click += new System.EventHandler(this.JBTN_GERNATE_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Location = new System.Drawing.Point(6, 41);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(983, 463);
            this.panel2.TabIndex = 42;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(433, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 33);
            this.label1.TabIndex = 43;
            this.label1.Text = "Barcode Gernator";
            // 
            // Barcode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(994, 512);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.JBTNPRINT);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.jenterlabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.jselectproduct);
            this.Controls.Add(this.JBTN_GERNATE);
            this.Controls.Add(this.panel2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Barcode";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Barcode";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button JBTNPRINT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox jenterlabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox jselectproduct;
        private System.Windows.Forms.Button JBTN_GERNATE;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
    }
}