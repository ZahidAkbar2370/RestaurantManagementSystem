namespace Till_Restuarant_Softwear
{
    partial class View_Vendor_Management
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.jdataviewtable = new System.Windows.Forms.DataGridView();
            this.JADDNEW_BTN = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.jsearch = new System.Windows.Forms.TextBox();
            this.JEXPORTTOEXCLE_BTN = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.jdataviewtable)).BeginInit();
            this.SuspendLayout();
            // 
            // jdataviewtable
            // 
            this.jdataviewtable.AllowUserToAddRows = false;
            this.jdataviewtable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.jdataviewtable.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.jdataviewtable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.jdataviewtable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8});
            this.jdataviewtable.GridColor = System.Drawing.SystemColors.ControlLight;
            this.jdataviewtable.Location = new System.Drawing.Point(1, 144);
            this.jdataviewtable.Name = "jdataviewtable";
            this.jdataviewtable.ReadOnly = true;
            this.jdataviewtable.Size = new System.Drawing.Size(991, 484);
            this.jdataviewtable.TabIndex = 21;
            this.jdataviewtable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.jdataviewtable_CellContentClick);
            // 
            // JADDNEW_BTN
            // 
            this.JADDNEW_BTN.BackColor = System.Drawing.Color.DarkOrange;
            this.JADDNEW_BTN.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.JADDNEW_BTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.JADDNEW_BTN.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.JADDNEW_BTN.Location = new System.Drawing.Point(885, 69);
            this.JADDNEW_BTN.Name = "JADDNEW_BTN";
            this.JADDNEW_BTN.Size = new System.Drawing.Size(95, 44);
            this.JADDNEW_BTN.TabIndex = 27;
            this.JADDNEW_BTN.Text = "Add New";
            this.JADDNEW_BTN.UseVisualStyleBackColor = false;
            this.JADDNEW_BTN.Click += new System.EventHandler(this.JADDNEW_BTN_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(10, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 18);
            this.label2.TabIndex = 26;
            this.label2.Text = "Search By Name";
            // 
            // jsearch
            // 
            this.jsearch.Location = new System.Drawing.Point(153, 83);
            this.jsearch.Name = "jsearch";
            this.jsearch.Size = new System.Drawing.Size(204, 20);
            this.jsearch.TabIndex = 25;
            this.jsearch.TextChanged += new System.EventHandler(this.jsearch_TextChanged);
            // 
            // JEXPORTTOEXCLE_BTN
            // 
            this.JEXPORTTOEXCLE_BTN.BackColor = System.Drawing.Color.DarkOrange;
            this.JEXPORTTOEXCLE_BTN.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.JEXPORTTOEXCLE_BTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.JEXPORTTOEXCLE_BTN.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.JEXPORTTOEXCLE_BTN.Location = new System.Drawing.Point(765, 69);
            this.JEXPORTTOEXCLE_BTN.Name = "JEXPORTTOEXCLE_BTN";
            this.JEXPORTTOEXCLE_BTN.Size = new System.Drawing.Size(114, 44);
            this.JEXPORTTOEXCLE_BTN.TabIndex = 29;
            this.JEXPORTTOEXCLE_BTN.Text = "Export To Excel";
            this.JEXPORTTOEXCLE_BTN.UseVisualStyleBackColor = false;
            this.JEXPORTTOEXCLE_BTN.Click += new System.EventHandler(this.JEXPORTTOEXCLE_BTN_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(457, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 33);
            this.label3.TabIndex = 18;
            this.label3.Text = "View Vendor";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ID";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Name";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Contact";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Email";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Business Name";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Address";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "GST Number";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column8
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.Column8.DefaultCellStyle = dataGridViewCellStyle1;
            this.Column8.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Column8.HeaderText = "Action";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // View_Vendor_Management
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(994, 631);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.JEXPORTTOEXCLE_BTN);
            this.Controls.Add(this.jdataviewtable);
            this.Controls.Add(this.JADDNEW_BTN);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.jsearch);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "View_Vendor_Management";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View_Vendor_Management";
            ((System.ComponentModel.ISupportInitialize)(this.jdataviewtable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView jdataviewtable;
        private System.Windows.Forms.Button JADDNEW_BTN;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox jsearch;
        private System.Windows.Forms.Button JEXPORTTOEXCLE_BTN;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewButtonColumn Column8;
    }
}