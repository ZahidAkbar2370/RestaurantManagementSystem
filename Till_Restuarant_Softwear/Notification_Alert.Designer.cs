namespace Till_Restuarant_Softwear
{
    partial class Notification_Alert
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
            this.lownotificationpanel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lownotificationpanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lownotificationpanel
            // 
            this.lownotificationpanel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lownotificationpanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lownotificationpanel.Controls.Add(this.label2);
            this.lownotificationpanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lownotificationpanel.Location = new System.Drawing.Point(0, 34);
            this.lownotificationpanel.Name = "lownotificationpanel";
            this.lownotificationpanel.Size = new System.Drawing.Size(297, 500);
            this.lownotificationpanel.TabIndex = 35;
            this.lownotificationpanel.Paint += new System.Windows.Forms.PaintEventHandler(this.lownotificationpanel_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(51, 200);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "No Notification Avaiable";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(92, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 33);
            this.label1.TabIndex = 36;
            this.label1.Text = "Notification";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(297, 34);
            this.panel1.TabIndex = 2;
            // 
            // Notification_Alert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(297, 534);
            this.Controls.Add(this.lownotificationpanel);
            this.Controls.Add(this.panel1);
            this.Location = new System.Drawing.Point(726, 65);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Notification_Alert";
            this.Text = "Notification_Alert";
            this.lownotificationpanel.ResumeLayout(false);
            this.lownotificationpanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel lownotificationpanel;
        public System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
    }
}