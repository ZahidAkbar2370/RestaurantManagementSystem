namespace Till_Restuarant_Softwear
{
    partial class View_All_Sale
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
            this.jsearchbyinvoice = new System.Windows.Forms.TextBox();
            this.JTODAYSALE_BTN = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.jtable = new System.Windows.Forms.DataGridView();
            this.jtodaydate = new System.Windows.Forms.DateTimePicker();
            this.TODAYSALEBYTAKEAWAY_BTn = new System.Windows.Forms.Button();
            this.TODAYSALEBYDINEIN_BTN = new System.Windows.Forms.Button();
            this.JTODAYSALEBY_DELIVERYBTN = new System.Windows.Forms.Button();
            this.jstatus = new System.Windows.Forms.Label();
            this.JEXPORTTOEXCLE_BTN = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.jtable)).BeginInit();
            this.SuspendLayout();
            // 
            // jsearchbyinvoice
            // 
            this.jsearchbyinvoice.Location = new System.Drawing.Point(755, 126);
            this.jsearchbyinvoice.Name = "jsearchbyinvoice";
            this.jsearchbyinvoice.Size = new System.Drawing.Size(205, 20);
            this.jsearchbyinvoice.TabIndex = 10;
            this.jsearchbyinvoice.TextChanged += new System.EventHandler(this.jsearchbyinvoice_TextChanged);
            // 
            // JTODAYSALE_BTN
            // 
            this.JTODAYSALE_BTN.BackColor = System.Drawing.Color.DarkOrange;
            this.JTODAYSALE_BTN.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.JTODAYSALE_BTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JTODAYSALE_BTN.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.JTODAYSALE_BTN.Location = new System.Drawing.Point(704, 57);
            this.JTODAYSALE_BTN.Name = "JTODAYSALE_BTN";
            this.JTODAYSALE_BTN.Size = new System.Drawing.Size(129, 48);
            this.JTODAYSALE_BTN.TabIndex = 9;
            this.JTODAYSALE_BTN.Text = "Today Sale";
            this.JTODAYSALE_BTN.UseVisualStyleBackColor = false;
            this.JTODAYSALE_BTN.Visible = false;
            this.JTODAYSALE_BTN.Click += new System.EventHandler(this.JTODAYSALE_BTN_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(623, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 18);
            this.label1.TabIndex = 7;
            this.label1.Text = "Search By Invoice";
            // 
            // jtable
            // 
            this.jtable.AllowUserToAddRows = false;
            this.jtable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.jtable.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.jtable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.jtable.Location = new System.Drawing.Point(3, 163);
            this.jtable.Name = "jtable";
            this.jtable.Size = new System.Drawing.Size(984, 384);
            this.jtable.TabIndex = 6;
            // 
            // jtodaydate
            // 
            this.jtodaydate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.jtodaydate.Location = new System.Drawing.Point(846, 57);
            this.jtodaydate.Name = "jtodaydate";
            this.jtodaydate.Size = new System.Drawing.Size(108, 20);
            this.jtodaydate.TabIndex = 35;
            this.jtodaydate.Visible = false;
            // 
            // TODAYSALEBYTAKEAWAY_BTn
            // 
            this.TODAYSALEBYTAKEAWAY_BTn.BackColor = System.Drawing.Color.DarkOrange;
            this.TODAYSALEBYTAKEAWAY_BTn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.TODAYSALEBYTAKEAWAY_BTn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.TODAYSALEBYTAKEAWAY_BTn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TODAYSALEBYTAKEAWAY_BTn.Location = new System.Drawing.Point(11, 57);
            this.TODAYSALEBYTAKEAWAY_BTn.Name = "TODAYSALEBYTAKEAWAY_BTn";
            this.TODAYSALEBYTAKEAWAY_BTn.Size = new System.Drawing.Size(129, 48);
            this.TODAYSALEBYTAKEAWAY_BTn.TabIndex = 36;
            this.TODAYSALEBYTAKEAWAY_BTn.Text = "Today Take_Away Sale";
            this.TODAYSALEBYTAKEAWAY_BTn.UseVisualStyleBackColor = false;
            this.TODAYSALEBYTAKEAWAY_BTn.Click += new System.EventHandler(this.TODAYSALEBYTAKEAWAY_BTn_Click);
            // 
            // TODAYSALEBYDINEIN_BTN
            // 
            this.TODAYSALEBYDINEIN_BTN.BackColor = System.Drawing.Color.DarkOrange;
            this.TODAYSALEBYDINEIN_BTN.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.TODAYSALEBYDINEIN_BTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.TODAYSALEBYDINEIN_BTN.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TODAYSALEBYDINEIN_BTN.Location = new System.Drawing.Point(147, 57);
            this.TODAYSALEBYDINEIN_BTN.Name = "TODAYSALEBYDINEIN_BTN";
            this.TODAYSALEBYDINEIN_BTN.Size = new System.Drawing.Size(129, 48);
            this.TODAYSALEBYDINEIN_BTN.TabIndex = 37;
            this.TODAYSALEBYDINEIN_BTN.Text = "Today Dine_In Sale";
            this.TODAYSALEBYDINEIN_BTN.UseVisualStyleBackColor = false;
            this.TODAYSALEBYDINEIN_BTN.Click += new System.EventHandler(this.TODAYSALEBYDINEIN_BTN_Click);
            // 
            // JTODAYSALEBY_DELIVERYBTN
            // 
            this.JTODAYSALEBY_DELIVERYBTN.BackColor = System.Drawing.Color.DarkOrange;
            this.JTODAYSALEBY_DELIVERYBTN.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.JTODAYSALEBY_DELIVERYBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.JTODAYSALEBY_DELIVERYBTN.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.JTODAYSALEBY_DELIVERYBTN.Location = new System.Drawing.Point(285, 57);
            this.JTODAYSALEBY_DELIVERYBTN.Name = "JTODAYSALEBY_DELIVERYBTN";
            this.JTODAYSALEBY_DELIVERYBTN.Size = new System.Drawing.Size(129, 48);
            this.JTODAYSALEBY_DELIVERYBTN.TabIndex = 38;
            this.JTODAYSALEBY_DELIVERYBTN.Text = "Today Delivery Sale";
            this.JTODAYSALEBY_DELIVERYBTN.UseVisualStyleBackColor = false;
            this.JTODAYSALEBY_DELIVERYBTN.Click += new System.EventHandler(this.JTODAYSALEBY_DELIVERYBTN_Click);
            // 
            // jstatus
            // 
            this.jstatus.AutoSize = true;
            this.jstatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jstatus.ForeColor = System.Drawing.Color.Red;
            this.jstatus.Location = new System.Drawing.Point(13, 99);
            this.jstatus.Name = "jstatus";
            this.jstatus.Size = new System.Drawing.Size(0, 16);
            this.jstatus.TabIndex = 39;
            // 
            // JEXPORTTOEXCLE_BTN
            // 
            this.JEXPORTTOEXCLE_BTN.BackColor = System.Drawing.Color.DarkOrange;
            this.JEXPORTTOEXCLE_BTN.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.JEXPORTTOEXCLE_BTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.JEXPORTTOEXCLE_BTN.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.JEXPORTTOEXCLE_BTN.Location = new System.Drawing.Point(846, 56);
            this.JEXPORTTOEXCLE_BTN.Name = "JEXPORTTOEXCLE_BTN";
            this.JEXPORTTOEXCLE_BTN.Size = new System.Drawing.Size(114, 49);
            this.JEXPORTTOEXCLE_BTN.TabIndex = 40;
            this.JEXPORTTOEXCLE_BTN.Text = "Export To Excel";
            this.JEXPORTTOEXCLE_BTN.UseVisualStyleBackColor = false;
            this.JEXPORTTOEXCLE_BTN.Click += new System.EventHandler(this.JEXPORTTOEXCLE_BTN_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(432, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 33);
            this.label2.TabIndex = 2;
            this.label2.Text = "Today All Sales";
            // 
            // View_All_Sale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(988, 549);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.JEXPORTTOEXCLE_BTN);
            this.Controls.Add(this.jstatus);
            this.Controls.Add(this.JTODAYSALEBY_DELIVERYBTN);
            this.Controls.Add(this.TODAYSALEBYDINEIN_BTN);
            this.Controls.Add(this.TODAYSALEBYTAKEAWAY_BTn);
            this.Controls.Add(this.jtodaydate);
            this.Controls.Add(this.jsearchbyinvoice);
            this.Controls.Add(this.JTODAYSALE_BTN);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.jtable);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "View_All_Sale";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Today_All_Sale";
            ((System.ComponentModel.ISupportInitialize)(this.jtable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox jsearchbyinvoice;
        private System.Windows.Forms.Button JTODAYSALE_BTN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView jtable;
        private System.Windows.Forms.DateTimePicker jtodaydate;
        private System.Windows.Forms.Button TODAYSALEBYTAKEAWAY_BTn;
        private System.Windows.Forms.Button TODAYSALEBYDINEIN_BTN;
        private System.Windows.Forms.Button JTODAYSALEBY_DELIVERYBTN;
        private System.Windows.Forms.Label jstatus;
        private System.Windows.Forms.Button JEXPORTTOEXCLE_BTN;
        private System.Windows.Forms.Label label2;
    }
}