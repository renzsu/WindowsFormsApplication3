namespace WindowsFormsApplication3
{
    partial class Purchase_Product_Information
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
            this.button1 = new System.Windows.Forms.Button();
            this.close_btn = new System.Windows.Forms.Button();
            this.txt_supplier = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_productID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_datereceive = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.dud_unitquantity = new System.Windows.Forms.DomainUpDown();
            this.txt_totalprice = new System.Windows.Forms.TextBox();
            this.txt_totalitems = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_unitprice = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label_unitprice = new System.Windows.Forms.Label();
            this.txt_unit = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_orderno = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.txt_product = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = global::WindowsFormsApplication3.Properties.Resources.Receive2;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(125, 228);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 37);
            this.button1.TabIndex = 55;
            this.button1.Text = "    Receive";
            this.button1.UseVisualStyleBackColor = false;
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
            this.close_btn.Location = new System.Drawing.Point(239, 228);
            this.close_btn.Name = "close_btn";
            this.close_btn.Size = new System.Drawing.Size(108, 37);
            this.close_btn.TabIndex = 52;
            this.close_btn.Text = "    Close";
            this.close_btn.UseVisualStyleBackColor = false;
            this.close_btn.Click += new System.EventHandler(this.close_btn_Click);
            // 
            // txt_supplier
            // 
            this.txt_supplier.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_supplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_supplier.Location = new System.Drawing.Point(-68, 321);
            this.txt_supplier.Name = "txt_supplier";
            this.txt_supplier.ReadOnly = true;
            this.txt_supplier.Size = new System.Drawing.Size(234, 22);
            this.txt_supplier.TabIndex = 56;
            this.txt_supplier.Visible = false;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(16, 324);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 16);
            this.label6.TabIndex = 55;
            this.label6.Text = "Supplier";
            this.label6.Visible = false;
            // 
            // txt_productID
            // 
            this.txt_productID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_productID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_productID.Location = new System.Drawing.Point(-68, 321);
            this.txt_productID.Name = "txt_productID";
            this.txt_productID.ReadOnly = true;
            this.txt_productID.Size = new System.Drawing.Size(234, 22);
            this.txt_productID.TabIndex = 54;
            this.txt_productID.Visible = false;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(9, 324);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 16);
            this.label4.TabIndex = 53;
            this.label4.Text = "Product ID";
            this.label4.Visible = false;
            // 
            // txt_datereceive
            // 
            this.txt_datereceive.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_datereceive.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_datereceive.Location = new System.Drawing.Point(-68, 321);
            this.txt_datereceive.Name = "txt_datereceive";
            this.txt_datereceive.ReadOnly = true;
            this.txt_datereceive.Size = new System.Drawing.Size(234, 22);
            this.txt_datereceive.TabIndex = 51;
            this.txt_datereceive.Visible = false;
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label14.Location = new System.Drawing.Point(-2, 324);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(103, 16);
            this.label14.TabIndex = 48;
            this.label14.Text = "Date Receive";
            this.label14.Visible = false;
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
            this.dud_unitquantity.Location = new System.Drawing.Point(197, 176);
            this.dud_unitquantity.Name = "dud_unitquantity";
            this.dud_unitquantity.Size = new System.Drawing.Size(62, 38);
            this.dud_unitquantity.TabIndex = 0;
            this.dud_unitquantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_totalprice
            // 
            this.txt_totalprice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_totalprice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_totalprice.Location = new System.Drawing.Point(-75, 321);
            this.txt_totalprice.Name = "txt_totalprice";
            this.txt_totalprice.ReadOnly = true;
            this.txt_totalprice.Size = new System.Drawing.Size(227, 22);
            this.txt_totalprice.TabIndex = 47;
            this.txt_totalprice.Visible = false;
            // 
            // txt_totalitems
            // 
            this.txt_totalitems.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_totalitems.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_totalitems.Location = new System.Drawing.Point(-63, 321);
            this.txt_totalitems.Name = "txt_totalitems";
            this.txt_totalitems.Size = new System.Drawing.Size(227, 22);
            this.txt_totalitems.TabIndex = 46;
            this.txt_totalitems.Visible = false;
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label12.Location = new System.Drawing.Point(8, 324);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(84, 16);
            this.label12.TabIndex = 45;
            this.label12.Text = "Total Price";
            this.label12.Visible = false;
            // 
            // txt_unitprice
            // 
            this.txt_unitprice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_unitprice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_unitprice.Location = new System.Drawing.Point(-63, 321);
            this.txt_unitprice.Name = "txt_unitprice";
            this.txt_unitprice.ReadOnly = true;
            this.txt_unitprice.Size = new System.Drawing.Size(227, 22);
            this.txt_unitprice.TabIndex = 44;
            this.txt_unitprice.Visible = false;
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label11.Location = new System.Drawing.Point(8, 324);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(85, 16);
            this.label11.TabIndex = 43;
            this.label11.Text = "Total Items";
            this.label11.Visible = false;
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label10.Location = new System.Drawing.Point(181, 142);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(97, 16);
            this.label10.TabIndex = 42;
            this.label10.Text = "Unit Receive";
            // 
            // label_unitprice
            // 
            this.label_unitprice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_unitprice.AutoSize = true;
            this.label_unitprice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_unitprice.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_unitprice.Location = new System.Drawing.Point(13, 324);
            this.label_unitprice.Name = "label_unitprice";
            this.label_unitprice.Size = new System.Drawing.Size(75, 16);
            this.label_unitprice.TabIndex = 41;
            this.label_unitprice.Text = "Unit Price";
            this.label_unitprice.Visible = false;
            // 
            // txt_unit
            // 
            this.txt_unit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_unit.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txt_unit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_unit.Location = new System.Drawing.Point(-61, 321);
            this.txt_unit.Name = "txt_unit";
            this.txt_unit.ReadOnly = true;
            this.txt_unit.Size = new System.Drawing.Size(227, 22);
            this.txt_unit.TabIndex = 40;
            this.txt_unit.Visible = false;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(23, 321);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 16);
            this.label8.TabIndex = 39;
            this.label8.Text = "Unit";
            this.label8.Visible = false;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(198, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 16);
            this.label5.TabIndex = 37;
            this.label5.Text = "Product";
            // 
            // txt_orderno
            // 
            this.txt_orderno.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_orderno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_orderno.Location = new System.Drawing.Point(-68, 321);
            this.txt_orderno.Name = "txt_orderno";
            this.txt_orderno.ReadOnly = true;
            this.txt_orderno.Size = new System.Drawing.Size(234, 22);
            this.txt_orderno.TabIndex = 58;
            this.txt_orderno.Visible = false;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(12, 324);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 16);
            this.label7.TabIndex = 57;
            this.label7.Text = "Order No.";
            this.label7.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // txt_product
            // 
            this.txt_product.BackColor = System.Drawing.Color.Transparent;
            this.txt_product.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_product.ForeColor = System.Drawing.Color.White;
            this.txt_product.Location = new System.Drawing.Point(15, 82);
            this.txt_product.Name = "txt_product";
            this.txt_product.Size = new System.Drawing.Size(432, 31);
            this.txt_product.TabIndex = 59;
            this.txt_product.Text = "Product";
            this.txt_product.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Maroon;
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(457, 10);
            this.panel1.TabIndex = 60;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Maroon;
            this.panel2.Location = new System.Drawing.Point(455, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 355);
            this.panel2.TabIndex = 61;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Maroon;
            this.panel3.Location = new System.Drawing.Point(1, 351);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(457, 10);
            this.panel3.TabIndex = 61;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Maroon;
            this.panel4.Location = new System.Drawing.Point(-6, 1);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(10, 355);
            this.panel4.TabIndex = 62;
            // 
            // Purchase_Product_Information
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
            this.Controls.Add(this.txt_product);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.close_btn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txt_unit);
            this.Controls.Add(this.dud_unitquantity);
            this.Controls.Add(this.label_unitprice);
            this.Controls.Add(this.txt_totalprice);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txt_totalitems);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txt_unitprice);
            this.Controls.Add(this.txt_orderno);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_supplier);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_productID);
            this.Controls.Add(this.txt_datereceive);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label14);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Purchase_Product_Information";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Purchase_Product_Information";
            this.Load += new System.EventHandler(this.Purchase_Product_Information_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button close_btn;
        private System.Windows.Forms.TextBox txt_supplier;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_productID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_datereceive;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DomainUpDown dud_unitquantity;
        private System.Windows.Forms.TextBox txt_totalprice;
        private System.Windows.Forms.TextBox txt_totalitems;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txt_unitprice;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label_unitprice;
        private System.Windows.Forms.TextBox txt_unit;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_orderno;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label txt_product;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
    }
}