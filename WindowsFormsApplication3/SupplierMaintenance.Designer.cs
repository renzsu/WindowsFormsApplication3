namespace WindowsFormsApplication3
{
    partial class SupplierMaintenance
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
            this.txt_search = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_searchby = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_leadT = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_emailadd = new System.Windows.Forms.TextBox();
            this.txt_mobNo = new System.Windows.Forms.TextBox();
            this.txt_telNo = new System.Windows.Forms.TextBox();
            this.txt_compAdd = new System.Windows.Forms.TextBox();
            this.txt_suppName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_contactperson = new System.Windows.Forms.TextBox();
            this.txt_SuppID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.close_btn = new System.Windows.Forms.Button();
            this.del_btn = new System.Windows.Forms.Button();
            this.update_btn = new System.Windows.Forms.Button();
            this.add_btn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(19, 33);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(158, 16);
            this.label8.TabIndex = 13;
            this.label8.Text = "Supplier Maintenance";
            this.label8.Click += new System.EventHandler(this.label8_Click);
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
            this.txt_search.TabIndex = 9;
            this.txt_search.TextChanged += new System.EventHandler(this.txt_search_TextChanged);
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
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // cb_searchby
            // 
            this.cb_searchby.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cb_searchby.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_searchby.FormattingEnabled = true;
            this.cb_searchby.Items.AddRange(new object[] {
            "",
            "Supplier ID",
            "Supplier Name",
            "Contact Person",
            "Company Address"});
            this.cb_searchby.Location = new System.Drawing.Point(133, 17);
            this.cb_searchby.Name = "cb_searchby";
            this.cb_searchby.Size = new System.Drawing.Size(281, 24);
            this.cb_searchby.TabIndex = 8;
            this.cb_searchby.SelectedIndexChanged += new System.EventHandler(this.cb_searchby_SelectedIndexChanged);
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
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.txt_search);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cb_searchby);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(22, 56);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(949, 48);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Black;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.Color.Black;
            this.dataGridView1.Location = new System.Drawing.Point(20, 116);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(955, 240);
            this.dataGridView1.StandardTab = true;
            this.dataGridView1.TabIndex = 15;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.txt_leadT);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txt_emailadd);
            this.groupBox2.Controls.Add(this.txt_mobNo);
            this.groupBox2.Controls.Add(this.txt_telNo);
            this.groupBox2.Controls.Add(this.txt_compAdd);
            this.groupBox2.Controls.Add(this.txt_suppName);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txt_contactperson);
            this.groupBox2.Controls.Add(this.txt_SuppID);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(22, 371);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(949, 196);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(537, 164);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(82, 16);
            this.label11.TabIndex = 18;
            this.label11.Text = "Lead Time";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(510, 26);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(109, 16);
            this.label10.TabIndex = 17;
            this.label10.Text = "Email Address";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // txt_leadT
            // 
            this.txt_leadT.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_leadT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_leadT.Location = new System.Drawing.Point(629, 159);
            this.txt_leadT.Name = "txt_leadT";
            this.txt_leadT.Size = new System.Drawing.Size(139, 22);
            this.txt_leadT.TabIndex = 7;
            this.txt_leadT.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(23, 159);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 16);
            this.label9.TabIndex = 14;
            this.label9.Text = "Mobile No.";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // txt_emailadd
            // 
            this.txt_emailadd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_emailadd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_emailadd.Location = new System.Drawing.Point(629, 25);
            this.txt_emailadd.Name = "txt_emailadd";
            this.txt_emailadd.Size = new System.Drawing.Size(299, 22);
            this.txt_emailadd.TabIndex = 5;
            this.txt_emailadd.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // txt_mobNo
            // 
            this.txt_mobNo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_mobNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_mobNo.Location = new System.Drawing.Point(174, 155);
            this.txt_mobNo.Name = "txt_mobNo";
            this.txt_mobNo.Size = new System.Drawing.Size(299, 22);
            this.txt_mobNo.TabIndex = 4;
            this.txt_mobNo.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            this.txt_mobNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_mobNo_KeyPress);
            // 
            // txt_telNo
            // 
            this.txt_telNo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_telNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_telNo.Location = new System.Drawing.Point(174, 122);
            this.txt_telNo.Name = "txt_telNo";
            this.txt_telNo.Size = new System.Drawing.Size(299, 22);
            this.txt_telNo.TabIndex = 3;
            this.txt_telNo.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            this.txt_telNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_mobNo_KeyPress);
            // 
            // txt_compAdd
            // 
            this.txt_compAdd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_compAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_compAdd.Location = new System.Drawing.Point(629, 57);
            this.txt_compAdd.Multiline = true;
            this.txt_compAdd.Name = "txt_compAdd";
            this.txt_compAdd.Size = new System.Drawing.Size(299, 92);
            this.txt_compAdd.TabIndex = 6;
            this.txt_compAdd.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txt_suppName
            // 
            this.txt_suppName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_suppName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_suppName.Location = new System.Drawing.Point(174, 57);
            this.txt_suppName.Name = "txt_suppName";
            this.txt_suppName.Size = new System.Drawing.Size(299, 22);
            this.txt_suppName.TabIndex = 1;
            this.txt_suppName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(488, 76);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(135, 16);
            this.label7.TabIndex = 8;
            this.label7.Text = "Company Address";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(23, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 16);
            this.label6.TabIndex = 7;
            this.label6.Text = "Supplier Name";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // txt_contactperson
            // 
            this.txt_contactperson.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_contactperson.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_contactperson.Location = new System.Drawing.Point(174, 89);
            this.txt_contactperson.Name = "txt_contactperson";
            this.txt_contactperson.Size = new System.Drawing.Size(299, 22);
            this.txt_contactperson.TabIndex = 2;
            this.txt_contactperson.TextChanged += new System.EventHandler(this.txt_prodname_TextChanged);
            // 
            // txt_SuppID
            // 
            this.txt_SuppID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_SuppID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_SuppID.Location = new System.Drawing.Point(174, 25);
            this.txt_SuppID.Name = "txt_SuppID";
            this.txt_SuppID.Size = new System.Drawing.Size(299, 22);
            this.txt_SuppID.TabIndex = 0;
            this.txt_SuppID.TextChanged += new System.EventHandler(this.txt_prodID_TextChanged);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(23, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 16);
            this.label5.TabIndex = 3;
            this.label5.Text = "Telephone No.";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(23, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Contact Person";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(23, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Supplier ID";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // close_btn
            // 
            this.close_btn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.close_btn.BackColor = System.Drawing.Color.White;
            this.close_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close_btn.Image = global::WindowsFormsApplication3.Properties.Resources.close2;
            this.close_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.close_btn.Location = new System.Drawing.Point(873, 580);
            this.close_btn.Name = "close_btn";
            this.close_btn.Size = new System.Drawing.Size(108, 37);
            this.close_btn.TabIndex = 20;
            this.close_btn.Text = "    Close";
            this.close_btn.UseVisualStyleBackColor = false;
            this.close_btn.Click += new System.EventHandler(this.close_btn_Click);
            // 
            // del_btn
            // 
            this.del_btn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.del_btn.BackColor = System.Drawing.Color.White;
            this.del_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.del_btn.Image = global::WindowsFormsApplication3.Properties.Resources.delete1;
            this.del_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.del_btn.Location = new System.Drawing.Point(759, 580);
            this.del_btn.Name = "del_btn";
            this.del_btn.Size = new System.Drawing.Size(108, 37);
            this.del_btn.TabIndex = 19;
            this.del_btn.Text = "    Delete";
            this.del_btn.UseVisualStyleBackColor = false;
            this.del_btn.Click += new System.EventHandler(this.del_btn_Click);
            // 
            // update_btn
            // 
            this.update_btn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.update_btn.BackColor = System.Drawing.Color.White;
            this.update_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update_btn.Image = global::WindowsFormsApplication3.Properties.Resources.update1;
            this.update_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.update_btn.Location = new System.Drawing.Point(645, 580);
            this.update_btn.Name = "update_btn";
            this.update_btn.Size = new System.Drawing.Size(108, 37);
            this.update_btn.TabIndex = 18;
            this.update_btn.Text = "   Update";
            this.update_btn.UseVisualStyleBackColor = false;
            this.update_btn.Click += new System.EventHandler(this.update_btn_Click);
            // 
            // add_btn
            // 
            this.add_btn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.add_btn.BackColor = System.Drawing.Color.White;
            this.add_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.add_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_btn.Image = global::WindowsFormsApplication3.Properties.Resources.add1;
            this.add_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.add_btn.Location = new System.Drawing.Point(532, 580);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(108, 37);
            this.add_btn.TabIndex = 17;
            this.add_btn.Text = "      Add";
            this.add_btn.UseVisualStyleBackColor = false;
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click);
            // 
            // SupplierMaintenance
            // 
            this.AcceptButton = this.add_btn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApplication3.Properties.Resources.background_modal;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(998, 648);
            this.Controls.Add(this.close_btn);
            this.Controls.Add(this.del_btn);
            this.Controls.Add(this.update_btn);
            this.Controls.Add(this.add_btn);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label8);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SupplierMaintenance";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SupplierMaintenance";
            this.Load += new System.EventHandler(this.SupplierMaintenance_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb_searchby;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_emailadd;
        private System.Windows.Forms.TextBox txt_leadT;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_mobNo;
        private System.Windows.Forms.TextBox txt_telNo;
        private System.Windows.Forms.TextBox txt_compAdd;
        private System.Windows.Forms.TextBox txt_suppName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_contactperson;
        private System.Windows.Forms.TextBox txt_SuppID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button close_btn;
        private System.Windows.Forms.Button del_btn;
        private System.Windows.Forms.Button update_btn;
        private System.Windows.Forms.Button add_btn;
    }
}