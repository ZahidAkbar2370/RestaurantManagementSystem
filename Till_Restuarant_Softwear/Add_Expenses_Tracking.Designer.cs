namespace Till_Restuarant_Softwear
{
    partial class Add_Expenses_Tracking
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
            this.UPDATE_JBTN = new System.Windows.Forms.Button();
            this.jid = new System.Windows.Forms.Label();
            this.JRESET_BTN = new System.Windows.Forms.Button();
            this.jdescription = new System.Windows.Forms.RichTextBox();
            this.JBTN_ADD = new System.Windows.Forms.Button();
            this.jcategory = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.jamount = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.jdate = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.jdelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UPDATE_JBTN
            // 
            this.UPDATE_JBTN.BackColor = System.Drawing.Color.DarkOrange;
            this.UPDATE_JBTN.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.UPDATE_JBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UPDATE_JBTN.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.UPDATE_JBTN.Location = new System.Drawing.Point(141, 300);
            this.UPDATE_JBTN.Name = "UPDATE_JBTN";
            this.UPDATE_JBTN.Size = new System.Drawing.Size(88, 40);
            this.UPDATE_JBTN.TabIndex = 47;
            this.UPDATE_JBTN.Text = "Update";
            this.UPDATE_JBTN.UseVisualStyleBackColor = false;
            this.UPDATE_JBTN.Click += new System.EventHandler(this.UPDATE_JBTN_Click);
            // 
            // jid
            // 
            this.jid.AutoSize = true;
            this.jid.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jid.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.jid.Location = new System.Drawing.Point(33, 39);
            this.jid.Name = "jid";
            this.jid.Size = new System.Drawing.Size(22, 18);
            this.jid.TabIndex = 46;
            this.jid.Text = "ID";
            this.jid.Visible = false;
            // 
            // JRESET_BTN
            // 
            this.JRESET_BTN.BackColor = System.Drawing.Color.DarkOrange;
            this.JRESET_BTN.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.JRESET_BTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JRESET_BTN.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.JRESET_BTN.Location = new System.Drawing.Point(316, 300);
            this.JRESET_BTN.Name = "JRESET_BTN";
            this.JRESET_BTN.Size = new System.Drawing.Size(75, 40);
            this.JRESET_BTN.TabIndex = 45;
            this.JRESET_BTN.Text = "Reset";
            this.JRESET_BTN.UseVisualStyleBackColor = false;
            this.JRESET_BTN.Click += new System.EventHandler(this.JRESET_BTN_Click);
            // 
            // jdescription
            // 
            this.jdescription.Location = new System.Drawing.Point(154, 203);
            this.jdescription.Name = "jdescription";
            this.jdescription.Size = new System.Drawing.Size(228, 75);
            this.jdescription.TabIndex = 44;
            this.jdescription.Text = "";
            // 
            // JBTN_ADD
            // 
            this.JBTN_ADD.BackColor = System.Drawing.Color.DarkOrange;
            this.JBTN_ADD.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.JBTN_ADD.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JBTN_ADD.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.JBTN_ADD.Location = new System.Drawing.Point(60, 300);
            this.JBTN_ADD.Name = "JBTN_ADD";
            this.JBTN_ADD.Size = new System.Drawing.Size(75, 40);
            this.JBTN_ADD.TabIndex = 43;
            this.JBTN_ADD.Text = "Add";
            this.JBTN_ADD.UseVisualStyleBackColor = false;
            this.JBTN_ADD.Click += new System.EventHandler(this.JBTN_ADD_Click);
            // 
            // jcategory
            // 
            this.jcategory.FormattingEnabled = true;
            this.jcategory.Items.AddRange(new object[] {
            "Khana",
            "Kiraya",
            "Chay",
            "Other"});
            this.jcategory.Location = new System.Drawing.Point(153, 165);
            this.jcategory.Name = "jcategory";
            this.jcategory.Size = new System.Drawing.Size(228, 21);
            this.jcategory.TabIndex = 42;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(37, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 18);
            this.label4.TabIndex = 41;
            this.label4.Text = "Category";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(36, 220);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 18);
            this.label3.TabIndex = 40;
            this.label3.Text = "Description";
            // 
            // jamount
            // 
            this.jamount.Location = new System.Drawing.Point(153, 112);
            this.jamount.Name = "jamount";
            this.jamount.Size = new System.Drawing.Size(228, 20);
            this.jamount.TabIndex = 39;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(39, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 18);
            this.label2.TabIndex = 38;
            this.label2.Text = "Amount";
            // 
            // jdate
            // 
            this.jdate.Enabled = false;
            this.jdate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.jdate.Location = new System.Drawing.Point(154, 64);
            this.jdate.Name = "jdate";
            this.jdate.Size = new System.Drawing.Size(228, 20);
            this.jdate.TabIndex = 37;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(40, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 18);
            this.label5.TabIndex = 36;
            this.label5.Text = "Date";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(147, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 33);
            this.label1.TabIndex = 48;
            this.label1.Text = "Add Expenses";
            // 
            // jdelete
            // 
            this.jdelete.BackColor = System.Drawing.Color.DarkOrange;
            this.jdelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.jdelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jdelete.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.jdelete.Location = new System.Drawing.Point(235, 300);
            this.jdelete.Name = "jdelete";
            this.jdelete.Size = new System.Drawing.Size(75, 40);
            this.jdelete.TabIndex = 49;
            this.jdelete.Text = "Delete";
            this.jdelete.UseVisualStyleBackColor = false;
            this.jdelete.Click += new System.EventHandler(this.button1_Click);
            // 
            // Add_Expenses_Tracking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(419, 368);
            this.Controls.Add(this.jdelete);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UPDATE_JBTN);
            this.Controls.Add(this.jid);
            this.Controls.Add(this.JRESET_BTN);
            this.Controls.Add(this.jdescription);
            this.Controls.Add(this.JBTN_ADD);
            this.Controls.Add(this.jcategory);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.jamount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.jdate);
            this.Controls.Add(this.label5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Add_Expenses_Tracking";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add_Expenses_Tracking";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button UPDATE_JBTN;
        public System.Windows.Forms.Label jid;
        private System.Windows.Forms.Button JRESET_BTN;
        public System.Windows.Forms.RichTextBox jdescription;
        private System.Windows.Forms.Button JBTN_ADD;
        public System.Windows.Forms.ComboBox jcategory;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox jamount;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.DateTimePicker jdate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button jdelete;
    }
}