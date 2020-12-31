namespace Till_Restuarant_Softwear
{
    partial class Kitchen_Management_Seprate_System
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.JPREPARINGORDER_BTN = new System.Windows.Forms.Button();
            this.JNEWORDER_BTN = new System.Windows.Forms.Button();
            this.jviewtable = new System.Windows.Forms.DataGridView();
            this.jbtntable = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.jstatus = new System.Windows.Forms.Label();
            this.jtimer = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.JLOWSTOCKNOTIFICATION_BTN = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.jviewtable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jbtntable)).BeginInit();
            this.SuspendLayout();
            // 
            // JPREPARINGORDER_BTN
            // 
            this.JPREPARINGORDER_BTN.BackColor = System.Drawing.Color.DarkOrange;
            this.JPREPARINGORDER_BTN.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.JPREPARINGORDER_BTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JPREPARINGORDER_BTN.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.JPREPARINGORDER_BTN.Location = new System.Drawing.Point(186, 43);
            this.JPREPARINGORDER_BTN.Name = "JPREPARINGORDER_BTN";
            this.JPREPARINGORDER_BTN.Size = new System.Drawing.Size(118, 37);
            this.JPREPARINGORDER_BTN.TabIndex = 33;
            this.JPREPARINGORDER_BTN.Text = "Preparing Order";
            this.JPREPARINGORDER_BTN.UseVisualStyleBackColor = false;
            this.JPREPARINGORDER_BTN.Click += new System.EventHandler(this.JPREPARINGORDER_BTN_Click);
            // 
            // JNEWORDER_BTN
            // 
            this.JNEWORDER_BTN.BackColor = System.Drawing.Color.DarkOrange;
            this.JNEWORDER_BTN.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.JNEWORDER_BTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JNEWORDER_BTN.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.JNEWORDER_BTN.Location = new System.Drawing.Point(34, 43);
            this.JNEWORDER_BTN.Name = "JNEWORDER_BTN";
            this.JNEWORDER_BTN.Size = new System.Drawing.Size(125, 37);
            this.JNEWORDER_BTN.TabIndex = 32;
            this.JNEWORDER_BTN.Text = "New Order";
            this.JNEWORDER_BTN.UseVisualStyleBackColor = false;
            this.JNEWORDER_BTN.Click += new System.EventHandler(this.JNEWORDER_BTN_Click);
            // 
            // jviewtable
            // 
            this.jviewtable.AllowUserToAddRows = false;
            this.jviewtable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.jviewtable.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.jviewtable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.jviewtable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column3,
            this.Column2,
            this.Column9,
            this.Column4,
            this.Column5,
            this.Column7,
            this.Column8,
            this.Column6});
            this.jviewtable.Location = new System.Drawing.Point(4, 116);
            this.jviewtable.Name = "jviewtable";
            this.jviewtable.Size = new System.Drawing.Size(978, 563);
            this.jviewtable.TabIndex = 36;
            this.jviewtable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.jviewtable_CellContentClick);
            // 
            // jbtntable
            // 
            this.jbtntable.AllowUserToAddRows = false;
            this.jbtntable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.jbtntable.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.jbtntable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.jbtntable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.jbtntable.Location = new System.Drawing.Point(863, 116);
            this.jbtntable.Name = "jbtntable";
            this.jbtntable.Size = new System.Drawing.Size(119, 563);
            this.jbtntable.TabIndex = 37;
            this.jbtntable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.jbtntable_CellContentClick);
            // 
            // Column1
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Blue;
            this.Column1.DefaultCellStyle = dataGridViewCellStyle2;
            this.Column1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Column1.HeaderText = "Action";
            this.Column1.Name = "Column1";
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // jstatus
            // 
            this.jstatus.AutoSize = true;
            this.jstatus.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jstatus.ForeColor = System.Drawing.Color.Red;
            this.jstatus.Location = new System.Drawing.Point(12, 92);
            this.jstatus.Name = "jstatus";
            this.jstatus.Size = new System.Drawing.Size(100, 21);
            this.jstatus.TabIndex = 38;
            this.jstatus.Text = "New Order";
            // 
            // jtimer
            // 
            this.jtimer.AutoSize = true;
            this.jtimer.Location = new System.Drawing.Point(957, 43);
            this.jtimer.Name = "jtimer";
            this.jtimer.Size = new System.Drawing.Size(13, 13);
            this.jtimer.TabIndex = 39;
            this.jtimer.Text = "0";
            this.jtimer.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // JLOWSTOCKNOTIFICATION_BTN
            // 
            this.JLOWSTOCKNOTIFICATION_BTN.BackColor = System.Drawing.Color.DarkOrange;
            this.JLOWSTOCKNOTIFICATION_BTN.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.JLOWSTOCKNOTIFICATION_BTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JLOWSTOCKNOTIFICATION_BTN.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.JLOWSTOCKNOTIFICATION_BTN.Location = new System.Drawing.Point(863, 43);
            this.JLOWSTOCKNOTIFICATION_BTN.Name = "JLOWSTOCKNOTIFICATION_BTN";
            this.JLOWSTOCKNOTIFICATION_BTN.Size = new System.Drawing.Size(88, 37);
            this.JLOWSTOCKNOTIFICATION_BTN.TabIndex = 40;
            this.JLOWSTOCKNOTIFICATION_BTN.Text = "Notification";
            this.JLOWSTOCKNOTIFICATION_BTN.UseVisualStyleBackColor = false;
            this.JLOWSTOCKNOTIFICATION_BTN.Click += new System.EventHandler(this.JLOWSTOCKNOTIFICATION_BTN_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(370, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(294, 33);
            this.label1.TabIndex = 41;
            this.label1.Text = "Kitchen Management System";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "OrderNo";
            this.Column3.Name = "Column3";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Invoice No";
            this.Column2.Name = "Column2";
            // 
            // Column9
            // 
            this.Column9.HeaderText = "MenuName";
            this.Column9.Name = "Column9";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Quantity";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Status";
            this.Column5.Name = "Column5";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "TableNo";
            this.Column7.Name = "Column7";
            // 
            // Column8
            // 
            this.Column8.HeaderText = "WaiterName";
            this.Column8.Name = "Column8";
            // 
            // Column6
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.Column6.DefaultCellStyle = dataGridViewCellStyle1;
            this.Column6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Column6.HeaderText = "Action";
            this.Column6.Name = "Column6";
            this.Column6.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Kitchen_Management_Seprate_System
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(982, 681);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.JLOWSTOCKNOTIFICATION_BTN);
            this.Controls.Add(this.jtimer);
            this.Controls.Add(this.JPREPARINGORDER_BTN);
            this.Controls.Add(this.JNEWORDER_BTN);
            this.Controls.Add(this.jviewtable);
            this.Controls.Add(this.jbtntable);
            this.Controls.Add(this.jstatus);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Kitchen_Management_Seprate_System";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Kitchen_Management_Seprate_System";
            this.Load += new System.EventHandler(this.Kitchen_Management_Seprate_System_Load);
            ((System.ComponentModel.ISupportInitialize)(this.jviewtable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jbtntable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button JPREPARINGORDER_BTN;
        private System.Windows.Forms.Button JNEWORDER_BTN;
        private System.Windows.Forms.DataGridView jviewtable;
        private System.Windows.Forms.DataGridView jbtntable;
        private System.Windows.Forms.DataGridViewButtonColumn Column1;
        private System.Windows.Forms.Label jstatus;
        private System.Windows.Forms.Label jtimer;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button JLOWSTOCKNOTIFICATION_BTN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewButtonColumn Column6;
    }
}