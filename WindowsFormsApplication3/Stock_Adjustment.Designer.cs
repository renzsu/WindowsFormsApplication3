namespace WindowsFormsApplication3
{
    partial class Stock_Adjustment
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
            this.label8 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dud_displayed = new System.Windows.Forms.DomainUpDown();
            this.dud_warehouse = new System.Windows.Forms.DomainUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_product = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.close_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(38, 10);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(127, 16);
            this.label8.TabIndex = 13;
            this.label8.Text = "Stock Adjustment";
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Black;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.Color.Black;
            this.dataGridView1.Location = new System.Drawing.Point(20, 97);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(955, 324);
            this.dataGridView1.StandardTab = true;
            this.dataGridView1.TabIndex = 14;
            this.dataGridView1.Click += new System.EventHandler(this.dataGridView1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.dud_displayed);
            this.groupBox1.Controls.Add(this.dud_warehouse);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_product);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(20, 446);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(955, 111);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            // 
            // dud_displayed
            // 
            this.dud_displayed.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dud_displayed.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dud_displayed.Items.Add("1");
            this.dud_displayed.Items.Add("2");
            this.dud_displayed.Items.Add("3");
            this.dud_displayed.Items.Add("4");
            this.dud_displayed.Items.Add("5");
            this.dud_displayed.Items.Add("6");
            this.dud_displayed.Items.Add("7");
            this.dud_displayed.Items.Add("8");
            this.dud_displayed.Items.Add("9");
            this.dud_displayed.Items.Add("10");
            this.dud_displayed.Items.Add("11");
            this.dud_displayed.Items.Add("12");
            this.dud_displayed.Items.Add("13");
            this.dud_displayed.Items.Add("14");
            this.dud_displayed.Items.Add("15");
            this.dud_displayed.Items.Add("16");
            this.dud_displayed.Items.Add("17");
            this.dud_displayed.Items.Add("18");
            this.dud_displayed.Items.Add("19");
            this.dud_displayed.Items.Add("20");
            this.dud_displayed.Location = new System.Drawing.Point(756, 66);
            this.dud_displayed.Name = "dud_displayed";
            this.dud_displayed.Size = new System.Drawing.Size(120, 22);
            this.dud_displayed.TabIndex = 46;
            this.dud_displayed.Text = "1";
            // 
            // dud_warehouse
            // 
            this.dud_warehouse.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dud_warehouse.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dud_warehouse.Items.Add("1");
            this.dud_warehouse.Items.Add("2");
            this.dud_warehouse.Items.Add("3");
            this.dud_warehouse.Items.Add("4");
            this.dud_warehouse.Items.Add("5");
            this.dud_warehouse.Items.Add("6");
            this.dud_warehouse.Items.Add("7");
            this.dud_warehouse.Items.Add("8");
            this.dud_warehouse.Items.Add("9");
            this.dud_warehouse.Items.Add("10");
            this.dud_warehouse.Items.Add("11");
            this.dud_warehouse.Items.Add("12");
            this.dud_warehouse.Items.Add("13");
            this.dud_warehouse.Items.Add("14");
            this.dud_warehouse.Items.Add("15");
            this.dud_warehouse.Items.Add("16");
            this.dud_warehouse.Items.Add("17");
            this.dud_warehouse.Items.Add("18");
            this.dud_warehouse.Items.Add("19");
            this.dud_warehouse.Items.Add("20");
            this.dud_warehouse.Location = new System.Drawing.Point(756, 30);
            this.dud_warehouse.Name = "dud_warehouse";
            this.dud_warehouse.Size = new System.Drawing.Size(120, 22);
            this.dud_warehouse.TabIndex = 45;
            this.dud_warehouse.Text = "1";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(553, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 16);
            this.label3.TabIndex = 44;
            this.label3.Text = "Displayed Stocks";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(553, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 16);
            this.label2.TabIndex = 43;
            this.label2.Text = "Warehouse Stocks";
            // 
            // txt_product
            // 
            this.txt_product.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_product.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_product.Location = new System.Drawing.Point(164, 29);
            this.txt_product.Name = "txt_product";
            this.txt_product.Size = new System.Drawing.Size(280, 22);
            this.txt_product.TabIndex = 40;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(41, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 16);
            this.label4.TabIndex = 39;
            this.label4.Text = "Product Name";
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::WindowsFormsApplication3.Properties.Resources.saveicon;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(756, 575);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 37);
            this.button1.TabIndex = 64;
            this.button1.Text = "   Save";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // close_btn
            // 
            this.close_btn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.close_btn.BackColor = System.Drawing.Color.White;
            this.close_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close_btn.Image = global::WindowsFormsApplication3.Properties.Resources.close2;
            this.close_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.close_btn.Location = new System.Drawing.Point(870, 575);
            this.close_btn.Name = "close_btn";
            this.close_btn.Size = new System.Drawing.Size(108, 37);
            this.close_btn.TabIndex = 63;
            this.close_btn.Text = "    Close";
            this.close_btn.UseVisualStyleBackColor = false;
            this.close_btn.Click += new System.EventHandler(this.close_btn_Click);
            // 
            // Stock_Adjustment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApplication3.Properties.Resources.background_modal;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(998, 648);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.close_btn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label8);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(998, 648);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(998, 648);
            this.Name = "Stock_Adjustment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stock_Adjustment";
            this.Load += new System.EventHandler(this.Stock_Adjustment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button close_btn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_product;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DomainUpDown dud_displayed;
        private System.Windows.Forms.DomainUpDown dud_warehouse;
    }
}