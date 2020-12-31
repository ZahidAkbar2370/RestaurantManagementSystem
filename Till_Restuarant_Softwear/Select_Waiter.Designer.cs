namespace Till_Restuarant_Softwear
{
    partial class Select_Waiter
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
            this.waiterpanel = new System.Windows.Forms.Panel();
            this.JCONFIRM_BTN = new System.Windows.Forms.Button();
            this.JCanCEL_BTN = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // waiterpanel
            // 
            this.waiterpanel.AutoScroll = true;
            this.waiterpanel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.waiterpanel.Location = new System.Drawing.Point(1, 47);
            this.waiterpanel.Name = "waiterpanel";
            this.waiterpanel.Size = new System.Drawing.Size(794, 352);
            this.waiterpanel.TabIndex = 0;
            // 
            // JCONFIRM_BTN
            // 
            this.JCONFIRM_BTN.BackColor = System.Drawing.Color.DarkOrange;
            this.JCONFIRM_BTN.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.JCONFIRM_BTN.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.JCONFIRM_BTN.Location = new System.Drawing.Point(85, 407);
            this.JCONFIRM_BTN.Name = "JCONFIRM_BTN";
            this.JCONFIRM_BTN.Size = new System.Drawing.Size(102, 31);
            this.JCONFIRM_BTN.TabIndex = 20;
            this.JCONFIRM_BTN.Text = "Confirm";
            this.JCONFIRM_BTN.UseVisualStyleBackColor = false;
            this.JCONFIRM_BTN.Click += new System.EventHandler(this.JCONFIRM_BTN_Click);
            // 
            // JCanCEL_BTN
            // 
            this.JCanCEL_BTN.BackColor = System.Drawing.Color.DarkOrange;
            this.JCanCEL_BTN.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.JCanCEL_BTN.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.JCanCEL_BTN.Location = new System.Drawing.Point(228, 407);
            this.JCanCEL_BTN.Name = "JCanCEL_BTN";
            this.JCanCEL_BTN.Size = new System.Drawing.Size(102, 31);
            this.JCanCEL_BTN.TabIndex = 19;
            this.JCanCEL_BTN.Text = "Cancel";
            this.JCanCEL_BTN.UseVisualStyleBackColor = false;
            this.JCanCEL_BTN.Click += new System.EventHandler(this.JCanCEL_BTN_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(325, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 33);
            this.label1.TabIndex = 23;
            this.label1.Text = "Select Waiter";
            // 
            // Select_Waiter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.JCONFIRM_BTN);
            this.Controls.Add(this.JCanCEL_BTN);
            this.Controls.Add(this.waiterpanel);
            this.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Select_Waiter";
            this.Text = "Select_Waiter";
            this.Load += new System.EventHandler(this.Select_Waiter_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel waiterpanel;
        private System.Windows.Forms.Button JCONFIRM_BTN;
        private System.Windows.Forms.Button JCanCEL_BTN;
        private System.Windows.Forms.Label label1;
    }
}