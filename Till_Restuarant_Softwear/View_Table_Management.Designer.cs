﻿namespace Till_Restuarant_Softwear
{
    partial class View_Table_Management
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
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.jdeletetable = new System.Windows.Forms.DataGridView();
            this.Column2 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.JADDNEW_BTN = new System.Windows.Forms.Button();
            this.Column1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.jedittable = new System.Windows.Forms.DataGridView();
            this.JEXPORTTOEXCLE_BTN = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.jdataviewtable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jdeletetable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jedittable)).BeginInit();
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
            this.Column5,
            this.Column6,
            this.Column7});
            this.jdataviewtable.GridColor = System.Drawing.SystemColors.ControlLight;
            this.jdataviewtable.Location = new System.Drawing.Point(1, 138);
            this.jdataviewtable.Name = "jdataviewtable";
            this.jdataviewtable.ReadOnly = true;
            this.jdataviewtable.Size = new System.Drawing.Size(991, 491);
            this.jdataviewtable.TabIndex = 21;
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
            this.Column4.HeaderText = "Table No.";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Floor No.";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Status";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.Column7.DefaultCellStyle = dataGridViewCellStyle1;
            this.Column7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Column7.HeaderText = "Action";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
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
            this.jdeletetable.Location = new System.Drawing.Point(903, 138);
            this.jdeletetable.Name = "jdeletetable";
            this.jdeletetable.Size = new System.Drawing.Size(55, 491);
            this.jdeletetable.TabIndex = 23;
            this.jdeletetable.Visible = false;
            this.jdeletetable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.jdeletetable_CellContentClick);
            // 
            // Column2
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.Column2.DefaultCellStyle = dataGridViewCellStyle2;
            this.Column2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Column2.HeaderText = "Delete";
            this.Column2.Name = "Column2";
            this.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // JADDNEW_BTN
            // 
            this.JADDNEW_BTN.BackColor = System.Drawing.Color.DarkOrange;
            this.JADDNEW_BTN.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.JADDNEW_BTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.JADDNEW_BTN.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.JADDNEW_BTN.Location = new System.Drawing.Point(880, 59);
            this.JADDNEW_BTN.Name = "JADDNEW_BTN";
            this.JADDNEW_BTN.Size = new System.Drawing.Size(95, 45);
            this.JADDNEW_BTN.TabIndex = 27;
            this.JADDNEW_BTN.Text = "Add New";
            this.JADDNEW_BTN.UseVisualStyleBackColor = false;
            this.JADDNEW_BTN.Click += new System.EventHandler(this.JADDNEW_BTN_Click);
            // 
            // Column1
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.DodgerBlue;
            this.Column1.DefaultCellStyle = dataGridViewCellStyle3;
            this.Column1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Column1.HeaderText = "Edit";
            this.Column1.Name = "Column1";
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
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
            this.jedittable.Location = new System.Drawing.Point(841, 138);
            this.jedittable.Name = "jedittable";
            this.jedittable.Size = new System.Drawing.Size(53, 491);
            this.jedittable.TabIndex = 22;
            this.jedittable.Visible = false;
            this.jedittable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.jedittable_CellContentClick);
            // 
            // JEXPORTTOEXCLE_BTN
            // 
            this.JEXPORTTOEXCLE_BTN.BackColor = System.Drawing.Color.DarkOrange;
            this.JEXPORTTOEXCLE_BTN.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.JEXPORTTOEXCLE_BTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.JEXPORTTOEXCLE_BTN.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.JEXPORTTOEXCLE_BTN.Location = new System.Drawing.Point(760, 59);
            this.JEXPORTTOEXCLE_BTN.Name = "JEXPORTTOEXCLE_BTN";
            this.JEXPORTTOEXCLE_BTN.Size = new System.Drawing.Size(114, 45);
            this.JEXPORTTOEXCLE_BTN.TabIndex = 29;
            this.JEXPORTTOEXCLE_BTN.Text = "Export To Excel";
            this.JEXPORTTOEXCLE_BTN.UseVisualStyleBackColor = false;
            this.JEXPORTTOEXCLE_BTN.Click += new System.EventHandler(this.JEXPORTTOEXCLE_BTN_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(447, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 33);
            this.label2.TabIndex = 30;
            this.label2.Text = "View Tables";
            // 
            // View_Table_Management
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(994, 631);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.JEXPORTTOEXCLE_BTN);
            this.Controls.Add(this.jdataviewtable);
            this.Controls.Add(this.jedittable);
            this.Controls.Add(this.jdeletetable);
            this.Controls.Add(this.JADDNEW_BTN);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "View_Table_Management";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View_Table_Management";
            ((System.ComponentModel.ISupportInitialize)(this.jdataviewtable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jdeletetable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jedittable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView jdataviewtable;
        public System.Windows.Forms.DataGridView jdeletetable;
        private System.Windows.Forms.DataGridViewButtonColumn Column2;
        private System.Windows.Forms.Button JADDNEW_BTN;
        private System.Windows.Forms.DataGridViewButtonColumn Column1;
        public System.Windows.Forms.DataGridView jedittable;
        private System.Windows.Forms.Button JEXPORTTOEXCLE_BTN;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewButtonColumn Column7;
    }
}