namespace Till_Restuarant_Softwear
{
    partial class Issue_Stock
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
            this.label5 = new System.Windows.Forms.Label();
            this.jissuedate = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.JIssueBTN = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.jissuequantity = new System.Windows.Forms.TextBox();
            this.jselectproduct = new System.Windows.Forms.ComboBox();
            this.jselectemployee = new System.Windows.Forms.ComboBox();
            this.JEXPORTTOEXCLE_BTN = new System.Windows.Forms.Button();
            this.jbarcode = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(314, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 18);
            this.label5.TabIndex = 21;
            this.label5.Text = "All Issued Stock";
            // 
            // jissuedate
            // 
            this.jissuedate.Enabled = false;
            this.jissuedate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.jissuedate.Location = new System.Drawing.Point(1, 51);
            this.jissuedate.Name = "jissuedate";
            this.jissuedate.Size = new System.Drawing.Size(100, 20);
            this.jissuedate.TabIndex = 29;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(1, 191);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(741, 291);
            this.dataGridView1.TabIndex = 28;
            // 
            // JIssueBTN
            // 
            this.JIssueBTN.BackColor = System.Drawing.Color.DarkOrange;
            this.JIssueBTN.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.JIssueBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JIssueBTN.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.JIssueBTN.Location = new System.Drawing.Point(508, 111);
            this.JIssueBTN.Name = "JIssueBTN";
            this.JIssueBTN.Size = new System.Drawing.Size(97, 27);
            this.JIssueBTN.TabIndex = 27;
            this.JIssueBTN.Text = "Issue";
            this.JIssueBTN.UseVisualStyleBackColor = false;
            this.JIssueBTN.Click += new System.EventHandler(this.JIssueBTN_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(388, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 15);
            this.label4.TabIndex = 26;
            this.label4.Text = "Issue Quantity";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(259, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 15);
            this.label3.TabIndex = 25;
            this.label3.Text = "Select Product";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(119, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 15);
            this.label2.TabIndex = 24;
            this.label2.Text = "Select Employee";
            // 
            // jissuequantity
            // 
            this.jissuequantity.Location = new System.Drawing.Point(387, 118);
            this.jissuequantity.Name = "jissuequantity";
            this.jissuequantity.Size = new System.Drawing.Size(100, 20);
            this.jissuequantity.TabIndex = 23;
            this.jissuequantity.TextChanged += new System.EventHandler(this.jissuequantity_TextChanged);
            // 
            // jselectproduct
            // 
            this.jselectproduct.FormattingEnabled = true;
            this.jselectproduct.Location = new System.Drawing.Point(255, 117);
            this.jselectproduct.Name = "jselectproduct";
            this.jselectproduct.Size = new System.Drawing.Size(121, 21);
            this.jselectproduct.TabIndex = 22;
            // 
            // jselectemployee
            // 
            this.jselectemployee.FormattingEnabled = true;
            this.jselectemployee.Location = new System.Drawing.Point(119, 117);
            this.jselectemployee.Name = "jselectemployee";
            this.jselectemployee.Size = new System.Drawing.Size(126, 21);
            this.jselectemployee.TabIndex = 20;
            // 
            // JEXPORTTOEXCLE_BTN
            // 
            this.JEXPORTTOEXCLE_BTN.BackColor = System.Drawing.Color.DarkOrange;
            this.JEXPORTTOEXCLE_BTN.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.JEXPORTTOEXCLE_BTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JEXPORTTOEXCLE_BTN.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.JEXPORTTOEXCLE_BTN.Location = new System.Drawing.Point(619, 51);
            this.JEXPORTTOEXCLE_BTN.Name = "JEXPORTTOEXCLE_BTN";
            this.JEXPORTTOEXCLE_BTN.Size = new System.Drawing.Size(114, 36);
            this.JEXPORTTOEXCLE_BTN.TabIndex = 30;
            this.JEXPORTTOEXCLE_BTN.Text = "Export To Excel";
            this.JEXPORTTOEXCLE_BTN.UseVisualStyleBackColor = false;
            this.JEXPORTTOEXCLE_BTN.Click += new System.EventHandler(this.JEXPORTTOEXCLE_BTN_Click);
            // 
            // jbarcode
            // 
            this.jbarcode.Location = new System.Drawing.Point(10, 117);
            this.jbarcode.Name = "jbarcode";
            this.jbarcode.Size = new System.Drawing.Size(103, 20);
            this.jbarcode.TabIndex = 31;
            this.jbarcode.TextChanged += new System.EventHandler(this.jbarcode_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(12, 97);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 15);
            this.label6.TabIndex = 32;
            this.label6.Text = "Barcode";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(311, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 33);
            this.label1.TabIndex = 33;
            this.label1.Text = "Issue Stock";
            // 
            // Issue_Stock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(742, 485);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.jbarcode);
            this.Controls.Add(this.JEXPORTTOEXCLE_BTN);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.jissuedate);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.JIssueBTN);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.jissuequantity);
            this.Controls.Add(this.jselectproduct);
            this.Controls.Add(this.jselectemployee);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Issue_Stock";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Issue_Stock";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker jissuedate;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button JIssueBTN;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox jissuequantity;
        public System.Windows.Forms.ComboBox jselectproduct;
        public System.Windows.Forms.ComboBox jselectemployee;
        private System.Windows.Forms.Button JEXPORTTOEXCLE_BTN;
        private System.Windows.Forms.TextBox jbarcode;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
    }
}