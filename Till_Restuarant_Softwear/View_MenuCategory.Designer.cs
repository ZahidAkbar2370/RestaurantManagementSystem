namespace Till_Restuarant_Softwear
{
    partial class View_MenuCategory
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.jdataviewtable = new System.Windows.Forms.DataGridView();
            this.jdeletetable = new System.Windows.Forms.DataGridView();
            this.Column2 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.JADDNEW_BTN = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.jsearch = new System.Windows.Forms.TextBox();
            this.JEXPORTTOEXCLE_BTN = new System.Windows.Forms.Button();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.jdataviewtable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jdeletetable)).BeginInit();
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
            this.Column3,
            this.Column4});
            this.jdataviewtable.GridColor = System.Drawing.SystemColors.ControlLight;
            this.jdataviewtable.Location = new System.Drawing.Point(3, 131);
            this.jdataviewtable.Name = "jdataviewtable";
            this.jdataviewtable.ReadOnly = true;
            this.jdataviewtable.Size = new System.Drawing.Size(1004, 496);
            this.jdataviewtable.TabIndex = 21;
            this.jdataviewtable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.jdataviewtable_CellContentClick);
            // 
            // jdeletetable
            // 
            this.jdeletetable.AllowUserToAddRows = false;
            this.jdeletetable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.jdeletetable.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.jdeletetable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.jdeletetable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2});
            this.jdeletetable.GridColor = System.Drawing.SystemColors.ControlLight;
            this.jdeletetable.Location = new System.Drawing.Point(876, 131);
            this.jdeletetable.Name = "jdeletetable";
            this.jdeletetable.Size = new System.Drawing.Size(105, 496);
            this.jdeletetable.TabIndex = 23;
            this.jdeletetable.Visible = false;
            this.jdeletetable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.jdeletetable_CellContentClick);
            // 
            // Column2
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.Column2.DefaultCellStyle = dataGridViewCellStyle4;
            this.Column2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Column2.HeaderText = "Delete";
            this.Column2.Name = "Column2";
            this.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(403, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 33);
            this.label1.TabIndex = 17;
            this.label1.Text = "View Menu Category";
            // 
            // JADDNEW_BTN
            // 
            this.JADDNEW_BTN.BackColor = System.Drawing.Color.DarkOrange;
            this.JADDNEW_BTN.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.JADDNEW_BTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.JADDNEW_BTN.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.JADDNEW_BTN.Location = new System.Drawing.Point(906, 64);
            this.JADDNEW_BTN.Name = "JADDNEW_BTN";
            this.JADDNEW_BTN.Size = new System.Drawing.Size(95, 46);
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
            this.label2.Location = new System.Drawing.Point(9, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 18);
            this.label2.TabIndex = 26;
            this.label2.Text = "Search By Name";
            // 
            // jsearch
            // 
            this.jsearch.Location = new System.Drawing.Point(152, 79);
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
            this.JEXPORTTOEXCLE_BTN.Location = new System.Drawing.Point(786, 64);
            this.JEXPORTTOEXCLE_BTN.Name = "JEXPORTTOEXCLE_BTN";
            this.JEXPORTTOEXCLE_BTN.Size = new System.Drawing.Size(114, 46);
            this.JEXPORTTOEXCLE_BTN.TabIndex = 30;
            this.JEXPORTTOEXCLE_BTN.Text = "Export To Excel";
            this.JEXPORTTOEXCLE_BTN.UseVisualStyleBackColor = false;
            this.JEXPORTTOEXCLE_BTN.Click += new System.EventHandler(this.JEXPORTTOEXCLE_BTN_Click);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ID";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Category";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            this.Column4.DefaultCellStyle = dataGridViewCellStyle3;
            this.Column4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Column4.HeaderText = "Delete";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // View_MenuCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(1008, 629);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.JEXPORTTOEXCLE_BTN);
            this.Controls.Add(this.jdataviewtable);
            this.Controls.Add(this.jdeletetable);
            this.Controls.Add(this.JADDNEW_BTN);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.jsearch);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "View_MenuCategory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View_MenuCategory";
            ((System.ComponentModel.ISupportInitialize)(this.jdataviewtable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jdeletetable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView jdataviewtable;
        public System.Windows.Forms.DataGridView jdeletetable;
        private System.Windows.Forms.DataGridViewButtonColumn Column2;
        private System.Windows.Forms.Button JADDNEW_BTN;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox jsearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button JEXPORTTOEXCLE_BTN;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewButtonColumn Column4;
    }
}