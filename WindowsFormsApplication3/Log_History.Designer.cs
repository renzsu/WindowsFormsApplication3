namespace WindowsFormsApplication3
{
    partial class Log_History
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Log_History));
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.cb_username = new System.Windows.Forms.RadioButton();
            this.cb_all = new System.Windows.Forms.RadioButton();
            this.close_btn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.gb_username = new System.Windows.Forms.GroupBox();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.label_user = new System.Windows.Forms.Label();
            this.gb_position = new System.Windows.Forms.GroupBox();
            this.cb_position = new System.Windows.Forms.ComboBox();
            this.label_position = new System.Windows.Forms.Label();
            this.gb_date = new System.Windows.Forms.GroupBox();
            this.label_to = new System.Windows.Forms.Label();
            this.dt_to = new System.Windows.Forms.DateTimePicker();
            this.dt_from = new System.Windows.Forms.DateTimePicker();
            this.label_from = new System.Windows.Forms.Label();
            this.print_btn = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.gb_username.SuspendLayout();
            this.gb_position.SuspendLayout();
            this.gb_date.SuspendLayout();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(13, 13);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 16);
            this.label8.TabIndex = 14;
            this.label8.Text = "Log History";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.radioButton4);
            this.groupBox1.Controls.Add(this.radioButton3);
            this.groupBox1.Controls.Add(this.cb_username);
            this.groupBox1.Controls.Add(this.cb_all);
            this.groupBox1.Location = new System.Drawing.Point(16, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(531, 48);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton4.ForeColor = System.Drawing.Color.White;
            this.radioButton4.Location = new System.Drawing.Point(409, 19);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(55, 19);
            this.radioButton4.TabIndex = 3;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Date";
            this.radioButton4.UseVisualStyleBackColor = true;
            this.radioButton4.CheckedChanged += new System.EventHandler(this.cb_all_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton3.ForeColor = System.Drawing.Color.White;
            this.radioButton3.Location = new System.Drawing.Point(278, 19);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(77, 19);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Position";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.cb_all_CheckedChanged);
            // 
            // cb_username
            // 
            this.cb_username.AutoSize = true;
            this.cb_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_username.ForeColor = System.Drawing.Color.White;
            this.cb_username.Location = new System.Drawing.Point(147, 19);
            this.cb_username.Name = "cb_username";
            this.cb_username.Size = new System.Drawing.Size(91, 19);
            this.cb_username.TabIndex = 1;
            this.cb_username.TabStop = true;
            this.cb_username.Text = "Username";
            this.cb_username.UseVisualStyleBackColor = true;
            this.cb_username.CheckedChanged += new System.EventHandler(this.cb_all_CheckedChanged);
            // 
            // cb_all
            // 
            this.cb_all.AutoSize = true;
            this.cb_all.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_all.ForeColor = System.Drawing.Color.White;
            this.cb_all.Location = new System.Drawing.Point(22, 19);
            this.cb_all.Name = "cb_all";
            this.cb_all.Size = new System.Drawing.Size(41, 19);
            this.cb_all.TabIndex = 0;
            this.cb_all.TabStop = true;
            this.cb_all.Text = "All";
            this.cb_all.UseVisualStyleBackColor = true;
            this.cb_all.CheckedChanged += new System.EventHandler(this.cb_all_CheckedChanged);
            // 
            // close_btn
            // 
            this.close_btn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.close_btn.BackColor = System.Drawing.Color.White;
            this.close_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close_btn.Image = global::WindowsFormsApplication3.Properties.Resources.close2;
            this.close_btn.Location = new System.Drawing.Point(922, 45);
            this.close_btn.Name = "close_btn";
            this.close_btn.Size = new System.Drawing.Size(45, 40);
            this.close_btn.TabIndex = 27;
            this.close_btn.Text = "    ";
            this.close_btn.UseVisualStyleBackColor = false;
            this.close_btn.Click += new System.EventHandler(this.close_btn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Black;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.Color.Black;
            this.dataGridView1.Location = new System.Drawing.Point(12, 150);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(955, 437);
            this.dataGridView1.StandardTab = true;
            this.dataGridView1.TabIndex = 28;
            // 
            // gb_username
            // 
            this.gb_username.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gb_username.BackColor = System.Drawing.Color.Transparent;
            this.gb_username.Controls.Add(this.txt_search);
            this.gb_username.Controls.Add(this.label_user);
            this.gb_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_username.ForeColor = System.Drawing.Color.White;
            this.gb_username.Location = new System.Drawing.Point(38, 91);
            this.gb_username.Name = "gb_username";
            this.gb_username.Size = new System.Drawing.Size(416, 53);
            this.gb_username.TabIndex = 39;
            this.gb_username.TabStop = false;
            this.gb_username.Text = "Search";
            this.gb_username.Visible = false;
            // 
            // txt_search
            // 
            this.txt_search.Location = new System.Drawing.Point(132, 18);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(257, 21);
            this.txt_search.TabIndex = 22;
            this.txt_search.TextChanged += new System.EventHandler(this.txt_product_TextChanged);
            // 
            // label_user
            // 
            this.label_user.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_user.AutoSize = true;
            this.label_user.BackColor = System.Drawing.Color.Transparent;
            this.label_user.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_user.ForeColor = System.Drawing.Color.White;
            this.label_user.Location = new System.Drawing.Point(24, 22);
            this.label_user.Name = "label_user";
            this.label_user.Size = new System.Drawing.Size(73, 15);
            this.label_user.TabIndex = 21;
            this.label_user.Text = "Username";
            // 
            // gb_position
            // 
            this.gb_position.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gb_position.BackColor = System.Drawing.Color.Transparent;
            this.gb_position.Controls.Add(this.cb_position);
            this.gb_position.Controls.Add(this.label_position);
            this.gb_position.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_position.ForeColor = System.Drawing.Color.White;
            this.gb_position.Location = new System.Drawing.Point(37, 91);
            this.gb_position.Name = "gb_position";
            this.gb_position.Size = new System.Drawing.Size(416, 53);
            this.gb_position.TabIndex = 40;
            this.gb_position.TabStop = false;
            this.gb_position.Text = "Search";
            this.gb_position.Visible = false;
            // 
            // cb_position
            // 
            this.cb_position.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cb_position.FormattingEnabled = true;
            this.cb_position.Items.AddRange(new object[] {
            "",
            "Administrator",
            "Cashier",
            "Merchandiser",
            "Checker"});
            this.cb_position.Location = new System.Drawing.Point(126, 18);
            this.cb_position.Name = "cb_position";
            this.cb_position.Size = new System.Drawing.Size(256, 23);
            this.cb_position.TabIndex = 22;
            this.cb_position.SelectedIndexChanged += new System.EventHandler(this.cb_position_SelectedIndexChanged);
            // 
            // label_position
            // 
            this.label_position.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_position.AutoSize = true;
            this.label_position.BackColor = System.Drawing.Color.Transparent;
            this.label_position.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_position.ForeColor = System.Drawing.Color.White;
            this.label_position.Location = new System.Drawing.Point(24, 22);
            this.label_position.Name = "label_position";
            this.label_position.Size = new System.Drawing.Size(59, 15);
            this.label_position.TabIndex = 21;
            this.label_position.Text = "Position";
            // 
            // gb_date
            // 
            this.gb_date.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gb_date.BackColor = System.Drawing.Color.Transparent;
            this.gb_date.Controls.Add(this.label_to);
            this.gb_date.Controls.Add(this.dt_to);
            this.gb_date.Controls.Add(this.dt_from);
            this.gb_date.Controls.Add(this.label_from);
            this.gb_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_date.ForeColor = System.Drawing.Color.White;
            this.gb_date.Location = new System.Drawing.Point(37, 95);
            this.gb_date.Name = "gb_date";
            this.gb_date.Size = new System.Drawing.Size(560, 53);
            this.gb_date.TabIndex = 41;
            this.gb_date.TabStop = false;
            this.gb_date.Text = "Search";
            this.gb_date.Visible = false;
            // 
            // label_to
            // 
            this.label_to.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_to.AutoSize = true;
            this.label_to.BackColor = System.Drawing.Color.Transparent;
            this.label_to.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_to.ForeColor = System.Drawing.Color.White;
            this.label_to.Location = new System.Drawing.Point(305, 22);
            this.label_to.Name = "label_to";
            this.label_to.Size = new System.Drawing.Size(23, 15);
            this.label_to.TabIndex = 23;
            this.label_to.Text = "To";
            // 
            // dt_to
            // 
            this.dt_to.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dt_to.CustomFormat = "";
            this.dt_to.Location = new System.Drawing.Point(343, 20);
            this.dt_to.Name = "dt_to";
            this.dt_to.Size = new System.Drawing.Size(200, 21);
            this.dt_to.TabIndex = 24;
            // 
            // dt_from
            // 
            this.dt_from.CustomFormat = "";
            this.dt_from.Location = new System.Drawing.Point(78, 20);
            this.dt_from.Name = "dt_from";
            this.dt_from.Size = new System.Drawing.Size(200, 21);
            this.dt_from.TabIndex = 22;
            // 
            // label_from
            // 
            this.label_from.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_from.AutoSize = true;
            this.label_from.BackColor = System.Drawing.Color.Transparent;
            this.label_from.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_from.ForeColor = System.Drawing.Color.White;
            this.label_from.Location = new System.Drawing.Point(15, 22);
            this.label_from.Name = "label_from";
            this.label_from.Size = new System.Drawing.Size(40, 15);
            this.label_from.TabIndex = 21;
            this.label_from.Text = "From";
            // 
            // print_btn
            // 
            this.print_btn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.print_btn.BackColor = System.Drawing.Color.White;
            this.print_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.print_btn.Image = global::WindowsFormsApplication3.Properties.Resources.print1;
            this.print_btn.Location = new System.Drawing.Point(873, 45);
            this.print_btn.Name = "print_btn";
            this.print_btn.Size = new System.Drawing.Size(45, 40);
            this.print_btn.TabIndex = 42;
            this.print_btn.Text = "    ";
            this.print_btn.UseVisualStyleBackColor = false;
            this.print_btn.Click += new System.EventHandler(this.print_btn_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // Log_History
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApplication3.Properties.Resources.background_modal;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(998, 648);
            this.Controls.Add(this.print_btn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.close_btn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.gb_position);
            this.Controls.Add(this.gb_date);
            this.Controls.Add(this.gb_username);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(998, 648);
            this.MinimumSize = new System.Drawing.Size(998, 648);
            this.Name = "Log_History";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Log_History";
            this.Load += new System.EventHandler(this.Log_History_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.gb_username.ResumeLayout(false);
            this.gb_username.PerformLayout();
            this.gb_position.ResumeLayout(false);
            this.gb_position.PerformLayout();
            this.gb_date.ResumeLayout(false);
            this.gb_date.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button close_btn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton cb_username;
        private System.Windows.Forms.RadioButton cb_all;
        private System.Windows.Forms.GroupBox gb_username;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.GroupBox gb_position;
        private System.Windows.Forms.ComboBox cb_position;
        private System.Windows.Forms.Label label_position;
        private System.Windows.Forms.Label label_user;
        private System.Windows.Forms.GroupBox gb_date;
        private System.Windows.Forms.DateTimePicker dt_to;
        private System.Windows.Forms.Label label_to;
        private System.Windows.Forms.DateTimePicker dt_from;
        private System.Windows.Forms.Label label_from;
        private System.Windows.Forms.Button print_btn;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    }
}