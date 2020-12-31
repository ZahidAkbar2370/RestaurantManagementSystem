namespace Till_Restuarant_Softwear
{
    partial class Add_Menu_Category
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.JBTN_CANCLE = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.jcategory = new System.Windows.Forms.TextBox();
            this.JADD_BTN = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.JBTN_CANCLE);
            this.panel1.Location = new System.Drawing.Point(3, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(357, 36);
            this.panel1.TabIndex = 24;
            this.panel1.Visible = false;
            // 
            // JBTN_CANCLE
            // 
            this.JBTN_CANCLE.BackColor = System.Drawing.Color.Red;
            this.JBTN_CANCLE.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.JBTN_CANCLE.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.JBTN_CANCLE.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JBTN_CANCLE.ForeColor = System.Drawing.Color.Snow;
            this.JBTN_CANCLE.Location = new System.Drawing.Point(327, 4);
            this.JBTN_CANCLE.Name = "JBTN_CANCLE";
            this.JBTN_CANCLE.Size = new System.Drawing.Size(26, 28);
            this.JBTN_CANCLE.TabIndex = 19;
            this.JBTN_CANCLE.Text = "X";
            this.JBTN_CANCLE.UseVisualStyleBackColor = false;
            this.JBTN_CANCLE.Visible = false;
            this.JBTN_CANCLE.Click += new System.EventHandler(this.JBTN_CANCLE_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(89, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(208, 33);
            this.label2.TabIndex = 20;
            this.label2.Text = "Add Menu Category";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(19, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 18);
            this.label1.TabIndex = 23;
            this.label1.Text = "Category";
            // 
            // jcategory
            // 
            this.jcategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jcategory.Location = new System.Drawing.Point(111, 71);
            this.jcategory.Name = "jcategory";
            this.jcategory.Size = new System.Drawing.Size(215, 24);
            this.jcategory.TabIndex = 22;
            // 
            // JADD_BTN
            // 
            this.JADD_BTN.BackColor = System.Drawing.Color.DarkOrange;
            this.JADD_BTN.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.JADD_BTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JADD_BTN.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.JADD_BTN.Location = new System.Drawing.Point(111, 118);
            this.JADD_BTN.Name = "JADD_BTN";
            this.JADD_BTN.Size = new System.Drawing.Size(115, 39);
            this.JADD_BTN.TabIndex = 21;
            this.JADD_BTN.Text = "Add";
            this.JADD_BTN.UseVisualStyleBackColor = false;
            this.JADD_BTN.Click += new System.EventHandler(this.JADD_BTN_Click);
            // 
            // Add_Menu_Category
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.CancelButton = this.JBTN_CANCLE;
            this.ClientSize = new System.Drawing.Size(357, 205);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.jcategory);
            this.Controls.Add(this.JADD_BTN);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Add_Menu_Category";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add_Menu_Category";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button JBTN_CANCLE;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox jcategory;
        private System.Windows.Forms.Button JADD_BTN;
        private System.Windows.Forms.Label label2;
    }
}