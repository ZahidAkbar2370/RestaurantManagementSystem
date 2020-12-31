namespace Till_Restuarant_Softwear
{
    partial class View_Employee
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.jdataviewtable = new System.Windows.Forms.DataGridView();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.jedittable = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.jdeletetable = new System.Windows.Forms.DataGridView();
            this.Column2 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.JADDNEW_BTN = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.jsearch = new System.Windows.Forms.TextBox();
            this.JEXPORTTOEXCLE_BTN = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.jdataviewtable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jedittable)).BeginInit();
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
            this.Column3,
            this.Column4,
            this.Column6,
            this.Column8,
            this.Column5,
            this.Column11,
            this.Column7,
            this.Column10,
            this.Column9,
            this.Column12});
            this.jdataviewtable.GridColor = System.Drawing.SystemColors.ControlLight;
            this.jdataviewtable.Location = new System.Drawing.Point(-8, 146);
            this.jdataviewtable.Name = "jdataviewtable";
            this.jdataviewtable.ReadOnly = true;
            this.jdataviewtable.Size = new System.Drawing.Size(1014, 481);
            this.jdataviewtable.TabIndex = 14;
            this.jdataviewtable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.jdataviewtable_CellContentClick);
            // 
            // Column3
            // 
            this.Column3.HeaderText = "ID";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Name";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Contact";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Email";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Status";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column11
            // 
            this.Column11.HeaderText = "Address";
            this.Column11.Name = "Column11";
            this.Column11.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Shift";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column10
            // 
            this.Column10.HeaderText = "Salery";
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Join Date";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            // 
            // Column12
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.Column12.DefaultCellStyle = dataGridViewCellStyle1;
            this.Column12.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Column12.HeaderText = "Action";
            this.Column12.Name = "Column12";
            this.Column12.ReadOnly = true;
            // 
            // jedittable
            // 
            this.jedittable.AllowUserToAddRows = false;
            this.jedittable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.jedittable.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.jedittable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.jedittable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.jedittable.GridColor = System.Drawing.SystemColors.ControlLight;
            this.jedittable.Location = new System.Drawing.Point(837, 146);
            this.jedittable.Name = "jedittable";
            this.jedittable.Size = new System.Drawing.Size(105, 496);
            this.jedittable.TabIndex = 15;
            this.jedittable.Visible = false;
            this.jedittable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.jedittable_CellContentClick);
            // 
            // Column1
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DodgerBlue;
            this.Column1.DefaultCellStyle = dataGridViewCellStyle2;
            this.Column1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Column1.HeaderText = "Edit";
            this.Column1.Name = "Column1";
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
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
            this.jdeletetable.Location = new System.Drawing.Point(874, 146);
            this.jdeletetable.Name = "jdeletetable";
            this.jdeletetable.Size = new System.Drawing.Size(105, 496);
            this.jdeletetable.TabIndex = 16;
            this.jdeletetable.Visible = false;
            this.jdeletetable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.jdeletetable_CellContentClick);
            // 
            // Column2
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            this.Column2.DefaultCellStyle = dataGridViewCellStyle3;
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
            this.label1.Location = new System.Drawing.Point(426, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 33);
            this.label1.TabIndex = 17;
            this.label1.Text = "View Employee";
            // 
            // JADDNEW_BTN
            // 
            this.JADDNEW_BTN.BackColor = System.Drawing.Color.DarkOrange;
            this.JADDNEW_BTN.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.JADDNEW_BTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.JADDNEW_BTN.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.JADDNEW_BTN.Location = new System.Drawing.Point(901, 68);
            this.JADDNEW_BTN.Name = "JADDNEW_BTN";
            this.JADDNEW_BTN.Size = new System.Drawing.Size(95, 45);
            this.JADDNEW_BTN.TabIndex = 20;
            this.JADDNEW_BTN.Text = "Add New";
            this.JADDNEW_BTN.UseVisualStyleBackColor = false;
            this.JADDNEW_BTN.Click += new System.EventHandler(this.JADDNEW_BTN_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(8, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 18);
            this.label2.TabIndex = 19;
            this.label2.Text = "Search By Name";
            // 
            // jsearch
            // 
            this.jsearch.Location = new System.Drawing.Point(151, 82);
            this.jsearch.Name = "jsearch";
            this.jsearch.Size = new System.Drawing.Size(204, 20);
            this.jsearch.TabIndex = 18;
            this.jsearch.TextChanged += new System.EventHandler(this.jsearch_TextChanged);
            // 
            // JEXPORTTOEXCLE_BTN
            // 
            this.JEXPORTTOEXCLE_BTN.BackColor = System.Drawing.Color.DarkOrange;
            this.JEXPORTTOEXCLE_BTN.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.JEXPORTTOEXCLE_BTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.JEXPORTTOEXCLE_BTN.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.JEXPORTTOEXCLE_BTN.Location = new System.Drawing.Point(781, 68);
            this.JEXPORTTOEXCLE_BTN.Name = "JEXPORTTOEXCLE_BTN";
            this.JEXPORTTOEXCLE_BTN.Size = new System.Drawing.Size(114, 45);
            this.JEXPORTTOEXCLE_BTN.TabIndex = 29;
            this.JEXPORTTOEXCLE_BTN.Text = "Export To Excel";
            this.JEXPORTTOEXCLE_BTN.UseVisualStyleBackColor = false;
            this.JEXPORTTOEXCLE_BTN.Click += new System.EventHandler(this.JEXPORTTOEXCLE_BTN_Click);
            // 
            // View_Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(1008, 629);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.JEXPORTTOEXCLE_BTN);
            this.Controls.Add(this.jdataviewtable);
            this.Controls.Add(this.jedittable);
            this.Controls.Add(this.jdeletetable);
            this.Controls.Add(this.JADDNEW_BTN);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.jsearch);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "View_Employee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View_Employee";
            this.Load += new System.EventHandler(this.View_Employee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.jdataviewtable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jedittable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jdeletetable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView jdataviewtable;
        public System.Windows.Forms.DataGridView jedittable;
        private System.Windows.Forms.DataGridViewButtonColumn Column1;
        public System.Windows.Forms.DataGridView jdeletetable;
        private System.Windows.Forms.DataGridViewButtonColumn Column2;
        private System.Windows.Forms.Button JADDNEW_BTN;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox jsearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button JEXPORTTOEXCLE_BTN;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewButtonColumn Column12;
    }
}