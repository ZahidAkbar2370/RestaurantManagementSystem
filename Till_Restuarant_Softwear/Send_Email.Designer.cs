namespace Till_Restuarant_Softwear
{
    partial class Send_Email
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
            this.label2 = new System.Windows.Forms.Label();
            this.BTN_Submit = new System.Windows.Forms.Button();
            this.jenteryouremail = new System.Windows.Forms.TextBox();
            this.BTN_RESET = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.selectreceiver = new System.Windows.Forms.ComboBox();
            this.jentermessage = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 18);
            this.label2.TabIndex = 26;
            this.label2.Text = "Enter Your Email";
            // 
            // BTN_Submit
            // 
            this.BTN_Submit.BackColor = System.Drawing.Color.DarkOrange;
            this.BTN_Submit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BTN_Submit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.BTN_Submit.Location = new System.Drawing.Point(200, 362);
            this.BTN_Submit.Name = "BTN_Submit";
            this.BTN_Submit.Size = new System.Drawing.Size(102, 43);
            this.BTN_Submit.TabIndex = 27;
            this.BTN_Submit.Text = "Send";
            this.BTN_Submit.UseVisualStyleBackColor = false;
            this.BTN_Submit.Click += new System.EventHandler(this.BTN_Submit_Click);
            // 
            // jenteryouremail
            // 
            this.jenteryouremail.Location = new System.Drawing.Point(181, 72);
            this.jenteryouremail.Name = "jenteryouremail";
            this.jenteryouremail.ReadOnly = true;
            this.jenteryouremail.Size = new System.Drawing.Size(313, 20);
            this.jenteryouremail.TabIndex = 28;
            this.jenteryouremail.Text = "janujakhar2370@gmail.com";
            // 
            // BTN_RESET
            // 
            this.BTN_RESET.BackColor = System.Drawing.Color.DarkOrange;
            this.BTN_RESET.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BTN_RESET.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.BTN_RESET.Location = new System.Drawing.Point(313, 362);
            this.BTN_RESET.Name = "BTN_RESET";
            this.BTN_RESET.Size = new System.Drawing.Size(102, 43);
            this.BTN_RESET.TabIndex = 29;
            this.BTN_RESET.Text = "Reset";
            this.BTN_RESET.UseVisualStyleBackColor = false;
            this.BTN_RESET.Click += new System.EventHandler(this.BTN_RESET_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 18);
            this.label3.TabIndex = 30;
            this.label3.Text = "Select Receiver";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(24, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 18);
            this.label4.TabIndex = 31;
            this.label4.Text = "Enter Message";
            // 
            // selectreceiver
            // 
            this.selectreceiver.FormattingEnabled = true;
            this.selectreceiver.Items.AddRange(new object[] {
            "Customers",
            "Employees"});
            this.selectreceiver.Location = new System.Drawing.Point(181, 123);
            this.selectreceiver.Name = "selectreceiver";
            this.selectreceiver.Size = new System.Drawing.Size(313, 21);
            this.selectreceiver.TabIndex = 32;
            // 
            // jentermessage
            // 
            this.jentermessage.Location = new System.Drawing.Point(181, 180);
            this.jentermessage.Name = "jentermessage";
            this.jentermessage.Size = new System.Drawing.Size(313, 151);
            this.jentermessage.TabIndex = 33;
            this.jentermessage.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(219, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 33);
            this.label1.TabIndex = 34;
            this.label1.Text = "Send Email";
            // 
            // Send_Email
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(549, 433);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.jentermessage);
            this.Controls.Add(this.selectreceiver);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BTN_RESET);
            this.Controls.Add(this.jenteryouremail);
            this.Controls.Add(this.BTN_Submit);
            this.Controls.Add(this.label2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Send_Email";
            this.Text = "Send_Email";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BTN_Submit;
        private System.Windows.Forms.TextBox jenteryouremail;
        private System.Windows.Forms.Button BTN_RESET;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox selectreceiver;
        private System.Windows.Forms.RichTextBox jentermessage;
        private System.Windows.Forms.Label label1;
    }
}