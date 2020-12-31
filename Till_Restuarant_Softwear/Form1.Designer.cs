namespace Till_Restuarant_Softwear
{
    partial class Form1
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
            this.jBTN_CLOSE = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // jBTN_CLOSE
            // 
            this.jBTN_CLOSE.BackColor = System.Drawing.Color.Red;
            this.jBTN_CLOSE.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.jBTN_CLOSE.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jBTN_CLOSE.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.jBTN_CLOSE.Location = new System.Drawing.Point(995, 1);
            this.jBTN_CLOSE.Name = "jBTN_CLOSE";
            this.jBTN_CLOSE.Size = new System.Drawing.Size(27, 29);
            this.jBTN_CLOSE.TabIndex = 0;
            this.jBTN_CLOSE.Text = "X";
            this.jBTN_CLOSE.UseVisualStyleBackColor = false;
            this.jBTN_CLOSE.Click += new System.EventHandler(this.jBTN_CLOSE_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(830, 768);
            this.Controls.Add(this.jBTN_CLOSE);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Point Of Sale";
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Button jBTN_CLOSE;
    }
}

