namespace Till_Restuarant_Softwear
{
    partial class Service_Tax
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
            this.label1 = new System.Windows.Forms.Label();
            this.jservicetax = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.jselecttype = new System.Windows.Forms.ComboBox();
            this.JSAVEBTN = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(41, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Service Tax";
            // 
            // jservicetax
            // 
            this.jservicetax.Location = new System.Drawing.Point(136, 50);
            this.jservicetax.Name = "jservicetax";
            this.jservicetax.Size = new System.Drawing.Size(133, 20);
            this.jservicetax.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(41, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Select Type";
            // 
            // jselecttype
            // 
            this.jselecttype.FormattingEnabled = true;
            this.jselecttype.Items.AddRange(new object[] {
            "Fix",
            "Per Item",
            "Persentage of Sub-Total"});
            this.jselecttype.Location = new System.Drawing.Point(136, 98);
            this.jselecttype.Name = "jselecttype";
            this.jselecttype.Size = new System.Drawing.Size(133, 21);
            this.jselecttype.TabIndex = 3;
            this.jselecttype.SelectedIndexChanged += new System.EventHandler(this.jselecttype_SelectedIndexChanged);
            // 
            // JSAVEBTN
            // 
            this.JSAVEBTN.BackColor = System.Drawing.Color.DarkOrange;
            this.JSAVEBTN.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.JSAVEBTN.Location = new System.Drawing.Point(136, 134);
            this.JSAVEBTN.Name = "JSAVEBTN";
            this.JSAVEBTN.Size = new System.Drawing.Size(75, 29);
            this.JSAVEBTN.TabIndex = 4;
            this.JSAVEBTN.Text = "Save";
            this.JSAVEBTN.UseVisualStyleBackColor = false;
            this.JSAVEBTN.Click += new System.EventHandler(this.JSAVEBTN_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(1, 180);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(344, 68);
            this.dataGridView1.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(102, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Add Service Tax";
            // 
            // Service_Tax
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(345, 250);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.JSAVEBTN);
            this.Controls.Add(this.jselecttype);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.jservicetax);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Service_Tax";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Service_Tax";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox jservicetax;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox jselecttype;
        private System.Windows.Forms.Button JSAVEBTN;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label3;
    }
}