namespace Till_Restuarant_Softwear
{
    partial class ForgetPassword
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
            this.jregisteremail = new System.Windows.Forms.TextBox();
            this.JFORGETBTN = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.jpassword = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // jregisteremail
            // 
            this.jregisteremail.Location = new System.Drawing.Point(47, 101);
            this.jregisteremail.Name = "jregisteremail";
            this.jregisteremail.Size = new System.Drawing.Size(284, 20);
            this.jregisteremail.TabIndex = 21;
            this.jregisteremail.TextChanged += new System.EventHandler(this.jregisteremail_TextChanged);
            // 
            // JFORGETBTN
            // 
            this.JFORGETBTN.BackColor = System.Drawing.Color.DarkOrange;
            this.JFORGETBTN.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.JFORGETBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.JFORGETBTN.Location = new System.Drawing.Point(47, 144);
            this.JFORGETBTN.Name = "JFORGETBTN";
            this.JFORGETBTN.Size = new System.Drawing.Size(140, 41);
            this.JFORGETBTN.TabIndex = 22;
            this.JFORGETBTN.Text = "Forget";
            this.JFORGETBTN.UseVisualStyleBackColor = false;
            this.JFORGETBTN.Click += new System.EventHandler(this.JFORGETBTN_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(44, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 17);
            this.label2.TabIndex = 23;
            this.label2.Text = "Enter Register Email";
            // 
            // jpassword
            // 
            this.jpassword.AutoSize = true;
            this.jpassword.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.jpassword.Location = new System.Drawing.Point(48, 126);
            this.jpassword.Name = "jpassword";
            this.jpassword.Size = new System.Drawing.Size(0, 13);
            this.jpassword.TabIndex = 24;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkOrange;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.button1.Location = new System.Drawing.Point(190, 144);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 41);
            this.button1.TabIndex = 25;
            this.button1.Text = "Reset";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(91, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 33);
            this.label1.TabIndex = 26;
            this.label1.Text = "Forget Password";
            // 
            // ForgetPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(366, 230);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.jpassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.JFORGETBTN);
            this.Controls.Add(this.jregisteremail);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ForgetPassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ForgetPassword";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox jregisteremail;
        private System.Windows.Forms.Button JFORGETBTN;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label jpassword;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
    }
}