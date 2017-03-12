namespace WindowsFormsApplication3
{
    partial class PurchaseOrdertoSupplier
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
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txt_dateorder = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_unit = new System.Windows.Forms.TextBox();
            this.label_unitprice = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_unitprice = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_totalitems = new System.Windows.Forms.TextBox();
            this.txt_productID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.txt_supplier = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dtp_datedue = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.close_btn = new System.Windows.Forms.Button();
            this.txt_product = new System.Windows.Forms.Label();
            this.dud_unitquantity = new System.Windows.Forms.DomainUpDown();
            this.txt_totalprice = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label14.Location = new System.Drawing.Point(-167, 231);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(84, 16);
            this.label14.TabIndex = 22;
            this.label14.Text = "Date Order";
            this.label14.Visible = false;
            // 
            // label15
            // 
            this.label15.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label15.Location = new System.Drawing.Point(-181, 232);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(110, 16);
            this.label15.TabIndex = 23;
            this.label15.Text = "Date Expected";
            this.label15.Visible = false;
            // 
            // txt_dateorder
            // 
            this.txt_dateorder.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_dateorder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_dateorder.Location = new System.Drawing.Point(-243, 225);
            this.txt_dateorder.Name = "txt_dateorder";
            this.txt_dateorder.ReadOnly = true;
            this.txt_dateorder.Size = new System.Drawing.Size(234, 22);
            this.txt_dateorder.TabIndex = 25;
            this.txt_dateorder.Visible = false;
            this.txt_dateorder.TextChanged += new System.EventHandler(this.txt_dateorder_TextChanged);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(193, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "Product";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(-118, 231);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 16);
            this.label8.TabIndex = 12;
            this.label8.Text = "Unit";
            this.label8.Visible = false;
            // 
            // txt_unit
            // 
            this.txt_unit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_unit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_unit.Location = new System.Drawing.Point(-236, 229);
            this.txt_unit.Name = "txt_unit";
            this.txt_unit.ReadOnly = true;
            this.txt_unit.Size = new System.Drawing.Size(227, 22);
            this.txt_unit.TabIndex = 13;
            this.txt_unit.Visible = false;
            this.txt_unit.TextChanged += new System.EventHandler(this.txt_unit_TextChanged);
            this.txt_unit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_unit_KeyPress);
            // 
            // label_unitprice
            // 
            this.label_unitprice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_unitprice.AutoSize = true;
            this.label_unitprice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_unitprice.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_unitprice.Location = new System.Drawing.Point(-177, 231);
            this.label_unitprice.Name = "label_unitprice";
            this.label_unitprice.Size = new System.Drawing.Size(75, 16);
            this.label_unitprice.TabIndex = 14;
            this.label_unitprice.Text = "Unit Price";
            this.label_unitprice.Visible = false;
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label10.Location = new System.Drawing.Point(180, 111);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(95, 16);
            this.label10.TabIndex = 15;
            this.label10.Text = "Unit Quantity";
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label11.Location = new System.Drawing.Point(-121, 231);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(85, 16);
            this.label11.TabIndex = 16;
            this.label11.Text = "Total Items";
            this.label11.Visible = false;
            // 
            // txt_unitprice
            // 
            this.txt_unitprice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_unitprice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_unitprice.Location = new System.Drawing.Point(-243, 222);
            this.txt_unitprice.Name = "txt_unitprice";
            this.txt_unitprice.ReadOnly = true;
            this.txt_unitprice.Size = new System.Drawing.Size(227, 22);
            this.txt_unitprice.TabIndex = 17;
            this.txt_unitprice.Visible = false;
            this.txt_unitprice.TextChanged += new System.EventHandler(this.txt_unitprice_TextChanged);
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label12.Location = new System.Drawing.Point(191, 203);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(84, 16);
            this.label12.TabIndex = 18;
            this.label12.Text = "Total Price";
            // 
            // txt_totalitems
            // 
            this.txt_totalitems.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_totalitems.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_totalitems.Location = new System.Drawing.Point(-225, 225);
            this.txt_totalitems.Name = "txt_totalitems";
            this.txt_totalitems.Size = new System.Drawing.Size(227, 22);
            this.txt_totalitems.TabIndex = 19;
            this.txt_totalitems.Visible = false;
            this.txt_totalitems.TextChanged += new System.EventHandler(this.txt_totalitems_TextChanged);
            // 
            // txt_productID
            // 
            this.txt_productID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_productID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_productID.Location = new System.Drawing.Point(-243, 223);
            this.txt_productID.Name = "txt_productID";
            this.txt_productID.ReadOnly = true;
            this.txt_productID.Size = new System.Drawing.Size(234, 22);
            this.txt_productID.TabIndex = 30;
            this.txt_productID.Visible = false;
            this.txt_productID.TextChanged += new System.EventHandler(this.txt_productID_TextChanged);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(-165, 231);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 16);
            this.label4.TabIndex = 29;
            this.label4.Text = "Product ID";
            this.label4.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // txt_supplier
            // 
            this.txt_supplier.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_supplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_supplier.Location = new System.Drawing.Point(-232, 225);
            this.txt_supplier.Name = "txt_supplier";
            this.txt_supplier.ReadOnly = true;
            this.txt_supplier.Size = new System.Drawing.Size(234, 22);
            this.txt_supplier.TabIndex = 32;
            this.txt_supplier.Visible = false;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(-167, 227);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 16);
            this.label6.TabIndex = 31;
            this.label6.Text = "Supplier";
            this.label6.Visible = false;
            // 
            // dtp_datedue
            // 
            this.dtp_datedue.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtp_datedue.CustomFormat = "MMMMMMMMM dd  yyy";
            this.dtp_datedue.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_datedue.Location = new System.Drawing.Point(-245, 236);
            this.dtp_datedue.Name = "dtp_datedue";
            this.dtp_datedue.Size = new System.Drawing.Size(234, 20);
            this.dtp_datedue.TabIndex = 33;
            this.dtp_datedue.Visible = false;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = global::WindowsFormsApplication3.Properties.Resources.close2;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(124, 293);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 37);
            this.button1.TabIndex = 27;
            this.button1.Text = "    Done";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // close_btn
            // 
            this.close_btn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.close_btn.BackColor = System.Drawing.Color.Black;
            this.close_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close_btn.ForeColor = System.Drawing.Color.White;
            this.close_btn.Image = global::WindowsFormsApplication3.Properties.Resources.close2;
            this.close_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.close_btn.Location = new System.Drawing.Point(247, 293);
            this.close_btn.Name = "close_btn";
            this.close_btn.Size = new System.Drawing.Size(108, 37);
            this.close_btn.TabIndex = 24;
            this.close_btn.Text = "    Close";
            this.close_btn.UseVisualStyleBackColor = false;
            this.close_btn.Click += new System.EventHandler(this.close_btn_Click);
            // 
            // txt_product
            // 
            this.txt_product.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_product.BackColor = System.Drawing.Color.Transparent;
            this.txt_product.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_product.ForeColor = System.Drawing.Color.White;
            this.txt_product.Location = new System.Drawing.Point(9, 54);
            this.txt_product.Name = "txt_product";
            this.txt_product.Size = new System.Drawing.Size(432, 31);
            this.txt_product.TabIndex = 60;
            this.txt_product.Text = "Product";
            this.txt_product.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dud_unitquantity
            // 
            this.dud_unitquantity.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dud_unitquantity.BackColor = System.Drawing.Color.Black;
            this.dud_unitquantity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dud_unitquantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dud_unitquantity.ForeColor = System.Drawing.Color.White;
            this.dud_unitquantity.Items.Add("1");
            this.dud_unitquantity.Items.Add("10");
            this.dud_unitquantity.Items.Add("2");
            this.dud_unitquantity.Items.Add("3");
            this.dud_unitquantity.Items.Add("4");
            this.dud_unitquantity.Items.Add("5");
            this.dud_unitquantity.Items.Add("6");
            this.dud_unitquantity.Items.Add("7");
            this.dud_unitquantity.Items.Add("8");
            this.dud_unitquantity.Items.Add("9");
            this.dud_unitquantity.Location = new System.Drawing.Point(196, 138);
            this.dud_unitquantity.Name = "dud_unitquantity";
            this.dud_unitquantity.Size = new System.Drawing.Size(62, 38);
            this.dud_unitquantity.TabIndex = 61;
            this.dud_unitquantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.dud_unitquantity.TextChanged += new System.EventHandler(this.dud_unitquantity_TextChanged);
            // 
            // txt_totalprice
            // 
            this.txt_totalprice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_totalprice.BackColor = System.Drawing.Color.Transparent;
            this.txt_totalprice.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_totalprice.ForeColor = System.Drawing.Color.White;
            this.txt_totalprice.Location = new System.Drawing.Point(9, 236);
            this.txt_totalprice.Name = "txt_totalprice";
            this.txt_totalprice.Size = new System.Drawing.Size(432, 31);
            this.txt_totalprice.TabIndex = 62;
            this.txt_totalprice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.txt_totalprice.TextChanged += new System.EventHandler(this.txt_totalprice_TextChanged_1);
            this.txt_totalprice.Click += new System.EventHandler(this.txt_totalprice_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.Maroon;
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(457, 10);
            this.panel1.TabIndex = 63;
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.BackColor = System.Drawing.Color.Maroon;
            this.panel2.Location = new System.Drawing.Point(453, 6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 355);
            this.panel2.TabIndex = 64;
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel3.BackColor = System.Drawing.Color.Maroon;
            this.panel3.Location = new System.Drawing.Point(-5, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(10, 355);
            this.panel3.TabIndex = 62;
            // 
            // panel4
            // 
            this.panel4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel4.BackColor = System.Drawing.Color.Maroon;
            this.panel4.Location = new System.Drawing.Point(2, 351);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(457, 10);
            this.panel4.TabIndex = 64;
            // 
            // PurchaseOrdertoSupplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = global::WindowsFormsApplication3.Properties.Resources.background_modal;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(459, 355);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txt_totalprice);
            this.Controls.Add(this.dud_unitquantity);
            this.Controls.Add(this.txt_product);
            this.Controls.Add(this.dtp_datedue);
            this.Controls.Add(this.txt_supplier);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_productID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_dateorder);
            this.Controls.Add(this.close_btn);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txt_totalitems);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txt_unitprice);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label_unitprice);
            this.Controls.Add(this.txt_unit);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PurchaseOrdertoSupplier";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PurchaseOrdertoSupplier";
            this.Load += new System.EventHandler(this.PurchaseOrdertoSupplier_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button close_btn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txt_dateorder;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_unit;
        private System.Windows.Forms.Label label_unitprice;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_unitprice;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txt_totalitems;
        private System.Windows.Forms.TextBox txt_productID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox txt_supplier;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtp_datedue;
        private System.Windows.Forms.Label txt_product;
        private System.Windows.Forms.DomainUpDown dud_unitquantity;
        private System.Windows.Forms.Label txt_totalprice;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
    }
}