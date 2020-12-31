namespace Till_Restuarant_Softwear
{
    partial class Select_Table
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
            this.tablepanel = new System.Windows.Forms.Panel();
            this.jalreadypresentMenu = new System.Windows.Forms.TextBox();
            this.jalreadypresentMenu1 = new System.Windows.Forms.Label();
            this.JCONFIRM_BTN = new System.Windows.Forms.Button();
            this.JCanCEL_BTN = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tablepanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // tablepanel
            // 
            this.tablepanel.AutoScroll = true;
            this.tablepanel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tablepanel.Controls.Add(this.jalreadypresentMenu);
            this.tablepanel.Controls.Add(this.jalreadypresentMenu1);
            this.tablepanel.Location = new System.Drawing.Point(3, 49);
            this.tablepanel.Name = "tablepanel";
            this.tablepanel.Size = new System.Drawing.Size(794, 352);
            this.tablepanel.TabIndex = 1;
            // 
            // jalreadypresentMenu
            // 
            this.jalreadypresentMenu.Location = new System.Drawing.Point(501, 29);
            this.jalreadypresentMenu.Name = "jalreadypresentMenu";
            this.jalreadypresentMenu.Size = new System.Drawing.Size(100, 20);
            this.jalreadypresentMenu.TabIndex = 1;
            this.jalreadypresentMenu.Visible = false;
            // 
            // jalreadypresentMenu1
            // 
            this.jalreadypresentMenu1.AutoSize = true;
            this.jalreadypresentMenu1.Location = new System.Drawing.Point(540, 13);
            this.jalreadypresentMenu1.Name = "jalreadypresentMenu1";
            this.jalreadypresentMenu1.Size = new System.Drawing.Size(35, 13);
            this.jalreadypresentMenu1.TabIndex = 0;
            this.jalreadypresentMenu1.Text = "label2";
            this.jalreadypresentMenu1.Visible = false;
            // 
            // JCONFIRM_BTN
            // 
            this.JCONFIRM_BTN.BackColor = System.Drawing.Color.DarkOrange;
            this.JCONFIRM_BTN.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.JCONFIRM_BTN.Location = new System.Drawing.Point(58, 410);
            this.JCONFIRM_BTN.Name = "JCONFIRM_BTN";
            this.JCONFIRM_BTN.Size = new System.Drawing.Size(102, 31);
            this.JCONFIRM_BTN.TabIndex = 6;
            this.JCONFIRM_BTN.Text = "Confirm";
            this.JCONFIRM_BTN.UseVisualStyleBackColor = false;
            this.JCONFIRM_BTN.Click += new System.EventHandler(this.JCONFIRM_BTN_Click);
            // 
            // JCanCEL_BTN
            // 
            this.JCanCEL_BTN.BackColor = System.Drawing.Color.DarkOrange;
            this.JCanCEL_BTN.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.JCanCEL_BTN.Location = new System.Drawing.Point(201, 410);
            this.JCanCEL_BTN.Name = "JCanCEL_BTN";
            this.JCanCEL_BTN.Size = new System.Drawing.Size(102, 31);
            this.JCanCEL_BTN.TabIndex = 5;
            this.JCanCEL_BTN.Text = "Cancel";
            this.JCanCEL_BTN.UseVisualStyleBackColor = false;
            this.JCanCEL_BTN.Click += new System.EventHandler(this.JCanCEL_BTN_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(339, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 33);
            this.label1.TabIndex = 23;
            this.label1.Text = "Select Table";
            // 
            // Select_Table
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.JCONFIRM_BTN);
            this.Controls.Add(this.JCanCEL_BTN);
            this.Controls.Add(this.tablepanel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Select_Table";
            this.Text = "Select_Table";
            this.Load += new System.EventHandler(this.Select_Table_Load);
            this.tablepanel.ResumeLayout(false);
            this.tablepanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel tablepanel;
        private System.Windows.Forms.Button JCONFIRM_BTN;
        private System.Windows.Forms.Button JCanCEL_BTN;
        private System.Windows.Forms.Label jalreadypresentMenu1;
        private System.Windows.Forms.TextBox jalreadypresentMenu;
        private System.Windows.Forms.Label label1;
    }
}