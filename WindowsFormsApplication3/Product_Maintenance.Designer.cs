namespace WindowsFormsApplication3
{
    partial class Product_Maintenance
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Product_Maintenance));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_searchby = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.addsupp_btn = new System.Windows.Forms.Button();
            this.addpline_btn = new System.Windows.Forms.Button();
            this.addunit_btn = new System.Windows.Forms.Button();
            this.nud_markUp = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_perpiece = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_Price = new System.Windows.Forms.TextBox();
            this.cb_supplier = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cb_unit = new System.Windows.Forms.ComboBox();
            this.cb_ProdLine = new System.Windows.Forms.ComboBox();
            this.cb_netwt = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_prodname = new System.Windows.Forms.TextBox();
            this.txt_prodID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.add_btn = new System.Windows.Forms.Button();
            this.update_btn = new System.Windows.Forms.Button();
            this.del_btn = new System.Windows.Forms.Button();
            this.close_btn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_markUp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.txt_search);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cb_searchby);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(16, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(949, 48);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // txt_search
            // 
            this.txt_search.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_search.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txt_search.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txt_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_search.Location = new System.Drawing.Point(588, 18);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(320, 22);
            this.txt_search.TabIndex = 3;
            this.txt_search.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(525, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Search";
            // 
            // cb_searchby
            // 
            this.cb_searchby.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cb_searchby.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_searchby.FormattingEnabled = true;
            this.cb_searchby.Items.AddRange(new object[] {
            "ProductID",
            "ProductName",
            "ProductLine",
            "Unit"});
            this.cb_searchby.Location = new System.Drawing.Point(156, 18);
            this.cb_searchby.Name = "cb_searchby";
            this.cb_searchby.Size = new System.Drawing.Size(281, 24);
            this.cb_searchby.TabIndex = 1;
            this.cb_searchby.SelectedIndexChanged += new System.EventHandler(this.cb_searchby_SelectedIndexChanged);
            this.cb_searchby.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBox);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(33, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Search by";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.addsupp_btn);
            this.groupBox2.Controls.Add(this.addpline_btn);
            this.groupBox2.Controls.Add(this.addunit_btn);
            this.groupBox2.Controls.Add(this.nud_markUp);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.txt_perpiece);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.txt_Price);
            this.groupBox2.Controls.Add(this.cb_supplier);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.cb_unit);
            this.groupBox2.Controls.Add(this.cb_ProdLine);
            this.groupBox2.Controls.Add(this.cb_netwt);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txt_prodname);
            this.groupBox2.Controls.Add(this.txt_prodID);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(13, 416);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(958, 181);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            // 
            // addsupp_btn
            // 
            this.addsupp_btn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.addsupp_btn.BackColor = System.Drawing.Color.White;
            this.addsupp_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.addsupp_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addsupp_btn.Image = global::WindowsFormsApplication3.Properties.Resources.add1;
            this.addsupp_btn.Location = new System.Drawing.Point(906, 26);
            this.addsupp_btn.Name = "addsupp_btn";
            this.addsupp_btn.Size = new System.Drawing.Size(35, 28);
            this.addsupp_btn.TabIndex = 30;
            this.addsupp_btn.UseVisualStyleBackColor = false;
            this.addsupp_btn.Click += new System.EventHandler(this.addsupp_btn_Click);
            // 
            // addpline_btn
            // 
            this.addpline_btn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.addpline_btn.BackColor = System.Drawing.Color.White;
            this.addpline_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.addpline_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addpline_btn.Image = global::WindowsFormsApplication3.Properties.Resources.add1;
            this.addpline_btn.Location = new System.Drawing.Point(906, 59);
            this.addpline_btn.Name = "addpline_btn";
            this.addpline_btn.Size = new System.Drawing.Size(35, 28);
            this.addpline_btn.TabIndex = 29;
            this.addpline_btn.UseVisualStyleBackColor = false;
            this.addpline_btn.Click += new System.EventHandler(this.addpline_btn_Click);
            // 
            // addunit_btn
            // 
            this.addunit_btn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.addunit_btn.BackColor = System.Drawing.Color.White;
            this.addunit_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.addunit_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addunit_btn.Image = global::WindowsFormsApplication3.Properties.Resources.add1;
            this.addunit_btn.Location = new System.Drawing.Point(906, 92);
            this.addunit_btn.Name = "addunit_btn";
            this.addunit_btn.Size = new System.Drawing.Size(35, 28);
            this.addunit_btn.TabIndex = 28;
            this.addunit_btn.UseVisualStyleBackColor = false;
            this.addunit_btn.Click += new System.EventHandler(this.addunit_btn_Click);
            // 
            // nud_markUp
            // 
            this.nud_markUp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nud_markUp.DecimalPlaces = 1;
            this.nud_markUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nud_markUp.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nud_markUp.Location = new System.Drawing.Point(556, 133);
            this.nud_markUp.Name = "nud_markUp";
            this.nud_markUp.Size = new System.Drawing.Size(120, 21);
            this.nud_markUp.TabIndex = 26;
            this.nud_markUp.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nud_markUp.ValueChanged += new System.EventHandler(this.nud_markUp_ValueChanged);
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(483, 135);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(67, 16);
            this.label12.TabIndex = 25;
            this.label12.Text = "Mark-Up";
            // 
            // txt_perpiece
            // 
            this.txt_perpiece.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_perpiece.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_perpiece.Location = new System.Drawing.Point(771, 132);
            this.txt_perpiece.Name = "txt_perpiece";
            this.txt_perpiece.Size = new System.Drawing.Size(100, 22);
            this.txt_perpiece.TabIndex = 17;
            this.txt_perpiece.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Price_KeyPress);
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(691, 135);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(74, 16);
            this.label11.TabIndex = 16;
            this.label11.Text = "per piece";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(259, 135);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 16);
            this.label10.TabIndex = 15;
            this.label10.Text = "Price";
            // 
            // txt_Price
            // 
            this.txt_Price.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_Price.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Price.Location = new System.Drawing.Point(309, 134);
            this.txt_Price.Name = "txt_Price";
            this.txt_Price.Size = new System.Drawing.Size(105, 22);
            this.txt_Price.TabIndex = 14;
            this.txt_Price.Text = "0";
            this.txt_Price.TextChanged += new System.EventHandler(this.txt_Price_TextChanged);
            this.txt_Price.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Price_KeyPress);
            // 
            // cb_supplier
            // 
            this.cb_supplier.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cb_supplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_supplier.FormattingEnabled = true;
            this.cb_supplier.Location = new System.Drawing.Point(629, 28);
            this.cb_supplier.Name = "cb_supplier";
            this.cb_supplier.Size = new System.Drawing.Size(268, 24);
            this.cb_supplier.TabIndex = 13;
            this.cb_supplier.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cb_supplier_KeyPress);
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(537, 31);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 16);
            this.label9.TabIndex = 12;
            this.label9.Text = "Supplier";
            // 
            // cb_unit
            // 
            this.cb_unit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cb_unit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_unit.FormattingEnabled = true;
            this.cb_unit.Location = new System.Drawing.Point(629, 94);
            this.cb_unit.Name = "cb_unit";
            this.cb_unit.Size = new System.Drawing.Size(268, 24);
            this.cb_unit.TabIndex = 11;
            this.cb_unit.SelectedIndexChanged += new System.EventHandler(this.cb_unit_SelectedIndexChanged);
            this.cb_unit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBox);
            // 
            // cb_ProdLine
            // 
            this.cb_ProdLine.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cb_ProdLine.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_ProdLine.FormattingEnabled = true;
            this.cb_ProdLine.Location = new System.Drawing.Point(629, 61);
            this.cb_ProdLine.Name = "cb_ProdLine";
            this.cb_ProdLine.Size = new System.Drawing.Size(268, 24);
            this.cb_ProdLine.TabIndex = 10;
            this.cb_ProdLine.SelectedIndexChanged += new System.EventHandler(this.cb_ProdLine_SelectedIndexChanged);
            this.cb_ProdLine.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBox);
            // 
            // cb_netwt
            // 
            this.cb_netwt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cb_netwt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_netwt.FormattingEnabled = true;
            this.cb_netwt.Items.AddRange(new object[] {
            "",
            "10g",
            "20g",
            "30g",
            "10L",
            "20L",
            "30L"});
            this.cb_netwt.Location = new System.Drawing.Point(200, 94);
            this.cb_netwt.Name = "cb_netwt";
            this.cb_netwt.Size = new System.Drawing.Size(299, 24);
            this.cb_netwt.TabIndex = 9;
            this.cb_netwt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBox);
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(568, 95);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 16);
            this.label7.TabIndex = 8;
            this.label7.Text = "Unit";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(509, 63);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 16);
            this.label6.TabIndex = 7;
            this.label6.Text = "Product Line";
            // 
            // txt_prodname
            // 
            this.txt_prodname.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_prodname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_prodname.Location = new System.Drawing.Point(200, 61);
            this.txt_prodname.Name = "txt_prodname";
            this.txt_prodname.Size = new System.Drawing.Size(299, 22);
            this.txt_prodname.TabIndex = 5;
            // 
            // txt_prodID
            // 
            this.txt_prodID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_prodID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_prodID.Location = new System.Drawing.Point(200, 28);
            this.txt_prodID.Name = "txt_prodID";
            this.txt_prodID.Size = new System.Drawing.Size(299, 22);
            this.txt_prodID.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(99, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 16);
            this.label5.TabIndex = 3;
            this.label5.Text = "Net Wt.";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(47, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Product Name ";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(77, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Product ID";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // add_btn
            // 
            this.add_btn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.add_btn.BackColor = System.Drawing.Color.White;
            this.add_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.add_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_btn.Image = global::WindowsFormsApplication3.Properties.Resources.add1;
            this.add_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.add_btn.Location = new System.Drawing.Point(513, 603);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(108, 37);
            this.add_btn.TabIndex = 3;
            this.add_btn.Text = "      Add";
            this.add_btn.UseVisualStyleBackColor = false;
            this.add_btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // update_btn
            // 
            this.update_btn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.update_btn.BackColor = System.Drawing.Color.White;
            this.update_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update_btn.Image = global::WindowsFormsApplication3.Properties.Resources.update1;
            this.update_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.update_btn.Location = new System.Drawing.Point(626, 603);
            this.update_btn.Name = "update_btn";
            this.update_btn.Size = new System.Drawing.Size(108, 37);
            this.update_btn.TabIndex = 4;
            this.update_btn.Text = "   Update";
            this.update_btn.UseVisualStyleBackColor = false;
            this.update_btn.Click += new System.EventHandler(this.updatedata_Click);
            // 
            // del_btn
            // 
            this.del_btn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.del_btn.BackColor = System.Drawing.Color.White;
            this.del_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.del_btn.Image = global::WindowsFormsApplication3.Properties.Resources.delete1;
            this.del_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.del_btn.Location = new System.Drawing.Point(739, 603);
            this.del_btn.Name = "del_btn";
            this.del_btn.Size = new System.Drawing.Size(108, 37);
            this.del_btn.TabIndex = 6;
            this.del_btn.Text = "    Delete";
            this.del_btn.UseVisualStyleBackColor = false;
            this.del_btn.Click += new System.EventHandler(this.del_btn_Click);
            // 
            // close_btn
            // 
            this.close_btn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.close_btn.BackColor = System.Drawing.Color.White;
            this.close_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close_btn.Image = global::WindowsFormsApplication3.Properties.Resources.close2;
            this.close_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.close_btn.Location = new System.Drawing.Point(852, 603);
            this.close_btn.Name = "close_btn";
            this.close_btn.Size = new System.Drawing.Size(108, 37);
            this.close_btn.TabIndex = 7;
            this.close_btn.Text = "    Close";
            this.close_btn.UseVisualStyleBackColor = false;
            this.close_btn.Click += new System.EventHandler(this.button5_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Black;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.Color.Black;
            this.dataGridView1.Location = new System.Drawing.Point(16, 86);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(955, 324);
            this.dataGridView1.StandardTab = true;
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView);
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
            this.label8.Size = new System.Drawing.Size(153, 16);
            this.label8.TabIndex = 12;
            this.label8.Text = "Product Maintenance";
            // 
            // Product_Maintenance
            // 
            this.AcceptButton = this.add_btn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApplication3.Properties.Resources.background_modal;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(998, 648);
            this.ControlBox = false;
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.close_btn);
            this.Controls.Add(this.del_btn);
            this.Controls.Add(this.update_btn);
            this.Controls.Add(this.add_btn);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.Location = new System.Drawing.Point(165, 15);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Product_Maintenance";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Product_Maintenance_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_markUp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb_searchby;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_prodname;
        private System.Windows.Forms.TextBox txt_prodID;
        private System.Windows.Forms.Button add_btn;
        private System.Windows.Forms.Button update_btn;
        private System.Windows.Forms.Button del_btn;
        private System.Windows.Forms.Button close_btn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cb_unit;
        private System.Windows.Forms.ComboBox cb_ProdLine;
        private System.Windows.Forms.ComboBox cb_netwt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cb_supplier;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_perpiece;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_Price;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.NumericUpDown nud_markUp;
        private System.Windows.Forms.Button addsupp_btn;
        private System.Windows.Forms.Button addpline_btn;
        private System.Windows.Forms.Button addunit_btn;
    }
}