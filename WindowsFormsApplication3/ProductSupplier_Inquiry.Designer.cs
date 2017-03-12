namespace WindowsFormsApplication3
{
    partial class ProductSupplier_Inquiry
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductSupplier_Inquiry));
            this.label8 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rb_supplier = new System.Windows.Forms.RadioButton();
            this.rb_product = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label_supp = new System.Windows.Forms.Label();
            this.txt_product = new System.Windows.Forms.TextBox();
            this.label_prod = new System.Windows.Forms.Label();
            this.cb_supplier = new System.Windows.Forms.ComboBox();
            this.close_btn = new System.Windows.Forms.Button();
            this.print_btn = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
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
            this.label8.Size = new System.Drawing.Size(151, 16);
            this.label8.TabIndex = 15;
            this.label8.Text = "Product Supplier List";
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Black;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.Color.Black;
            this.dataGridView1.Location = new System.Drawing.Point(16, 170);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(955, 432);
            this.dataGridView1.StandardTab = true;
            this.dataGridView1.TabIndex = 33;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.rb_supplier);
            this.groupBox2.Controls.Add(this.rb_product);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(16, 80);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(369, 60);
            this.groupBox2.TabIndex = 34;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "View By";
            // 
            // rb_supplier
            // 
            this.rb_supplier.AutoSize = true;
            this.rb_supplier.Location = new System.Drawing.Point(199, 23);
            this.rb_supplier.Name = "rb_supplier";
            this.rb_supplier.Size = new System.Drawing.Size(71, 19);
            this.rb_supplier.TabIndex = 1;
            this.rb_supplier.Text = "Supplier";
            this.rb_supplier.UseVisualStyleBackColor = true;
            this.rb_supplier.CheckedChanged += new System.EventHandler(this.rb_product_CheckedChanged);
            // 
            // rb_product
            // 
            this.rb_product.AutoSize = true;
            this.rb_product.Location = new System.Drawing.Point(56, 23);
            this.rb_product.Name = "rb_product";
            this.rb_product.Size = new System.Drawing.Size(67, 19);
            this.rb_product.TabIndex = 0;
            this.rb_product.Text = "Product";
            this.rb_product.UseVisualStyleBackColor = true;
            this.rb_product.CheckedChanged += new System.EventHandler(this.rb_product_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.label_supp);
            this.groupBox3.Controls.Add(this.txt_product);
            this.groupBox3.Controls.Add(this.label_prod);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(413, 80);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(377, 60);
            this.groupBox3.TabIndex = 35;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Search";
            // 
            // label_supp
            // 
            this.label_supp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_supp.AutoSize = true;
            this.label_supp.BackColor = System.Drawing.Color.Transparent;
            this.label_supp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_supp.ForeColor = System.Drawing.Color.White;
            this.label_supp.Location = new System.Drawing.Point(22, 25);
            this.label_supp.Name = "label_supp";
            this.label_supp.Size = new System.Drawing.Size(61, 15);
            this.label_supp.TabIndex = 23;
            this.label_supp.Text = "Supplier";
            // 
            // txt_product
            // 
            this.txt_product.Location = new System.Drawing.Point(97, 24);
            this.txt_product.Name = "txt_product";
            this.txt_product.Size = new System.Drawing.Size(257, 21);
            this.txt_product.TabIndex = 22;
            this.txt_product.TextChanged += new System.EventHandler(this.txt_product_TextChanged);
            // 
            // label_prod
            // 
            this.label_prod.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_prod.AutoSize = true;
            this.label_prod.BackColor = System.Drawing.Color.Transparent;
            this.label_prod.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_prod.ForeColor = System.Drawing.Color.White;
            this.label_prod.Location = new System.Drawing.Point(22, 24);
            this.label_prod.Name = "label_prod";
            this.label_prod.Size = new System.Drawing.Size(56, 15);
            this.label_prod.TabIndex = 21;
            this.label_prod.Text = "Product";
            // 
            // cb_supplier
            // 
            this.cb_supplier.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cb_supplier.FormattingEnabled = true;
            this.cb_supplier.Location = new System.Drawing.Point(510, 104);
            this.cb_supplier.Name = "cb_supplier";
            this.cb_supplier.Size = new System.Drawing.Size(257, 21);
            this.cb_supplier.TabIndex = 24;
            this.cb_supplier.SelectedIndexChanged += new System.EventHandler(this.cb_supplier_SelectedIndexChanged);
            // 
            // close_btn
            // 
            this.close_btn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.close_btn.BackColor = System.Drawing.Color.White;
            this.close_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close_btn.Image = global::WindowsFormsApplication3.Properties.Resources.close2;
            this.close_btn.Location = new System.Drawing.Point(926, 94);
            this.close_btn.Name = "close_btn";
            this.close_btn.Size = new System.Drawing.Size(45, 40);
            this.close_btn.TabIndex = 36;
            this.close_btn.Text = "    ";
            this.close_btn.UseVisualStyleBackColor = false;
            this.close_btn.Click += new System.EventHandler(this.close_btn_Click);
            // 
            // print_btn
            // 
            this.print_btn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.print_btn.BackColor = System.Drawing.Color.White;
            this.print_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.print_btn.Image = global::WindowsFormsApplication3.Properties.Resources.print1;
            this.print_btn.Location = new System.Drawing.Point(875, 94);
            this.print_btn.Name = "print_btn";
            this.print_btn.Size = new System.Drawing.Size(45, 40);
            this.print_btn.TabIndex = 37;
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
            // ProductSupplier_Inquiry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApplication3.Properties.Resources.background_modal;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(998, 648);
            this.Controls.Add(this.print_btn);
            this.Controls.Add(this.cb_supplier);
            this.Controls.Add(this.close_btn);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label8);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(998, 648);
            this.MinimumSize = new System.Drawing.Size(998, 648);
            this.Name = "ProductSupplier_Inquiry";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProductSupplier_Inquiry";
            this.Load += new System.EventHandler(this.ProductSupplier_Inquiry_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rb_supplier;
        private System.Windows.Forms.RadioButton rb_product;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txt_product;
        private System.Windows.Forms.Label label_prod;
        private System.Windows.Forms.ComboBox cb_supplier;
        private System.Windows.Forms.Label label_supp;
        private System.Windows.Forms.Button close_btn;
        private System.Windows.Forms.Button print_btn;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    }
}