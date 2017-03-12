using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApplication3
{
    public partial class SupplierMaintenance : Form
    {
        //SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-3IB33KC2;Initial Catalog=SalesAndInventoryforSustenaEMC;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        SqlConnection con = new SqlConnection(@"Data Source=WRENZO;Initial Catalog=SalesAndInventorySEMC;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        SqlDataAdapter sda;

        DataTable dt;
        DataSet ds = new DataSet();

        public SupplierMaintenance()
        {
            InitializeComponent();
        }
        private void SetFontAndColors()
        {
            this.dataGridView1.DefaultCellStyle.Font = new Font("Century Gothic", 10, FontStyle.Bold);
            this.dataGridView1.DefaultCellStyle.ForeColor = Color.White;
            this.dataGridView1.DefaultCellStyle.BackColor = Color.Black;
            this.dataGridView1.DefaultCellStyle.SelectionForeColor = Color.Black;
            this.dataGridView1.DefaultCellStyle.SelectionBackColor = Color.White;

        }
        private void SetGridViewProperties()
        {
            dataGridView1.Columns[0].Width = 180;
            dataGridView1.Columns[1].Width = 180;
            dataGridView1.Columns[2].Width = 180;
            dataGridView1.Columns[3].Width = 180;
            dataGridView1.Columns[4].Width = 180;
            dataGridView1.Columns[5].Width = 180;
            dataGridView1.Columns[6].Width = 180;
            dataGridView1.Columns[7].Width = 180;

            dataGridView1.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            foreach (DataGridViewColumn col in dataGridView1.Columns)
            {
                col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                col.HeaderCell.Style.Font = new Font("Century Gothic", 12F, GraphicsUnit.Pixel);
            }
        }
        public void loadtabletodatagridview()
        {
            con.Open();
            sda = new SqlDataAdapter("select Supplier_ID, Supplier_Name, Contact_Person, Telephone_No, Cellphone_No, Address, Supplier_Email, Lead_Time from supplier_tbl", con);
            DataSet ds = new DataSet();
            sda.Fill(ds, "Products_Table");
            con.Close();
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "Products_Table";
        }
        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (cb_searchby.Text == "Supplier ID")
                {
                    SqlDataAdapter sda = new SqlDataAdapter("Select Supplier_ID, Supplier_Name, Contact_Person, Telephone_No, Cellphone_No, Address, Supplier_Email, Lead_Time from supplier_tbl where Supplier_ID LIKE '" + txt_search.Text + "%'", con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
                else if (cb_searchby.Text == "Supplier Name")
                {
                    SqlDataAdapter sda = new SqlDataAdapter("Select Supplier_ID, Supplier_Name, Contact_Person, Telephone_No, Cellphone_No, Address, Supplier_Email, Lead_Time from supplier_tbl where Supplier_Name LIKE '" + txt_search.Text + "%'", con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
                else if (cb_searchby.Text == "Contact Person")
                {
                    SqlDataAdapter sda = new SqlDataAdapter("Select Supplier_ID, Supplier_Name, Contact_Person, Telephone_No, Cellphone_No, Address, Supplier_Email, Lead_Time from supplier_tbl where Contact_Person LIKE '" + txt_search.Text + "%'", con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
                else if (cb_searchby.Text == "Company Address")
                {
                    SqlDataAdapter sda = new SqlDataAdapter("Select Supplier_ID, Supplier_Name, Contact_Person, Telephone_No, Cellphone_No, Address, Supplier_Email, Lead_Time from supplier_tbl where Address LIKE '" + txt_search.Text + "%'", con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            SetGridViewProperties();
            SetFontAndColors();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void cb_searchby_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txt_prodname_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_prodID_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void close_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SupplierMaintenance_Load(object sender, EventArgs e)
        {
            SetFontAndColors();
            try
            {
                loadtabletodatagridview();
                SetGridViewProperties();
                txt_SuppID.ReadOnly = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            if (txt_contactperson.Text == ""  || txt_suppName.Text == "" || txt_compAdd.Text == "" || txt_leadT.Text == "")
            {
                Invalid inv = new Invalid();
                inv.Show();
            }

            else
            {
                try
                {
                    con.Open();
                    sda = new SqlDataAdapter("INSERT INTO supplier_tbl (Supplier_Name, Contact_Person, Telephone_No, Cellphone_No, Address, Supplier_Email, Lead_Time)" + "values ('" + txt_suppName.Text + "','" + txt_contactperson.Text + "','" + txt_telNo.Text + "', '" + txt_mobNo.Text+ "', '" + txt_compAdd.Text + "', '" + txt_emailadd.Text + "', '" + txt_leadT.Text+ "')", con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                txt_SuppID.Clear();
                txt_contactperson.Clear();
                txt_telNo.Clear();
                txt_mobNo.Clear();
                txt_emailadd.Clear();
                txt_suppName.Clear();
                txt_compAdd.Clear();
                txt_leadT.Clear();
                loadtabletodatagridview();

            }
        }

        private void update_btn_Click(object sender, EventArgs e)
        {
            if (txt_SuppID.Text == "" /*|| txt_prodname.Text == "" || cb_ProdLine.Text == "" || cb_netwt.Text == "" || cb_unit.Text == ""*/)
            {
                Invalid inv = new Invalid();
                inv.Show();
            }

            else
            {
                try
                {


                    con.Open();
                    sda = new SqlDataAdapter("UPDATE supplier_tbl SET Contact_Person = '" + txt_contactperson.Text + "', Telephone_No = '" + txt_telNo.Text + "', Cellphone_No = '" + txt_mobNo.Text + "', Address = '" +txt_compAdd.Text + "', Supplier_Name = '" +txt_suppName.Text+ "', Supplier_Email = '"+ txt_emailadd.Text +"', Lead_Time = '"+txt_leadT.Text+"'  where Supplier_ID = '" + txt_SuppID.Text + "'", con);


                    dt = new DataTable();
                    sda.Fill(dt);
                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                txt_SuppID.Clear();
                txt_contactperson.Clear();
                txt_telNo.Clear();
                txt_mobNo.Clear();
                txt_emailadd.Clear();
                txt_suppName.Clear();
                txt_compAdd.Clear();
                txt_leadT.Clear();
                loadtabletodatagridview();
            }
        }

        private void dataGridView(object sender, MouseEventArgs e)
        {
            try
            {
                txt_SuppID.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                txt_suppName.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                txt_contactperson.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                txt_telNo.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                txt_mobNo.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                txt_compAdd.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
                txt_emailadd.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
                txt_leadT.Text = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
            }
            catch
            {

            }
        }

        private void del_btn_Click(object sender, EventArgs e)
        {
            
            if (txt_SuppID.Text == "")
            {
                MessageBox.Show("Specify product to delete");
            }

            else
            {
                if (MessageBox.Show("Are you sure you want to Delete?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        con.Open();
                        sda = new SqlDataAdapter("DELETE FROM supplier_tbl where Supplier_ID = '" + txt_SuppID.Text + "'", con);
                        dt = new DataTable();
                        sda.Fill(dt);
                        con.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                {
                    
                }

                txt_SuppID.Clear();
                txt_contactperson.Clear();
                txt_telNo.Clear();
                txt_mobNo.Clear();
                txt_emailadd.Clear();
                txt_suppName.Clear();
                txt_compAdd.Clear();
                txt_leadT.Clear();
                loadtabletodatagridview();

            }
        }

        private void txt_mobNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
            txt_mobNo.MaxLength = 11;
            txt_telNo.MaxLength = 11;
        }
    }
    }

