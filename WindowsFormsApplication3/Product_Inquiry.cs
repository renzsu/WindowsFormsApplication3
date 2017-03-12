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
    public partial class Product_Inquiry : Form
    {
        public Product_Inquiry()
        {
            InitializeComponent();
        }
        //SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-3IB33KC2;Initial Catalog=SalesAndInventoryforSustenaEMC;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        SqlConnection con = new SqlConnection(@"Data Source=WRENZO;Initial Catalog=SalesAndInventorySEMC;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");


        private void close_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Product_Inquiry_Load(object sender, EventArgs e)
        {
            loadtodatagrid();
            SetGridViewProperties();
            SetFontAndColors();
            productlinetocombobox();
            


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
            dataGridView1.Columns[0].Width = 220;
            dataGridView1.Columns[1].Width = 320;
            dataGridView1.Columns[2].Width = 300;
          

            dataGridView1.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            foreach (DataGridViewColumn col in dataGridView1.Columns)
            {
                col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                col.HeaderCell.Style.Font = new Font("Century Gothic", 12F, GraphicsUnit.Pixel);
            }
        }
        public void loadtodatagrid()
        {
            try
            {
                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("Select product_tbl.Product_ID, product_tbl.Product_Name, productline_tbl.Product_Line FROM product_tbl INNER JOIN productline_tbl on productline_tbl.ProductLineID = product_tbl.ProductLineID ",con);
                DataSet ds = new DataSet();
                sda.Fill(ds, "Products_Table");
                con.Close();
                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = "Products_Table";


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        void productlinetocombobox()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select product_line from productline_tbl", con);
            SqlDataReader sdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Rows.Add();
            dt.Columns.Add("Product_Line", typeof(string));
            dt.Load(sdr);
            con.Close();
            cb_prodline.ValueMember = "Product_Line";
            cb_prodline.DataSource = dt;
            
        }


        private void radiobutton(object sender, KeyPressEventArgs e)
        {
            
        }

        private void rb_prodline_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_prodline.Checked == true)
            {
                label_prod.Visible = false;
                txt_product.Visible = false;
                label_prodline.Visible = true;
                cb_prodline.Visible = true;
            }
            else if (rb_product.Checked == true)
            {

                label_prod.Visible = true;
                txt_product.Visible = true;
                label_prodline.Visible = false;
                cb_prodline.Visible = false;
                
            }


        }

        private void rb_product_CheckedChanged(object sender, EventArgs e)
        {
            
            if (rb_prodline.Checked == true)
            {
                label_prod.Visible = false;
                txt_product.Visible = false;
                label_prodline.Visible = true;
                cb_prodline.Visible = true;
             
            }
            else if (rb_product.Checked == true)
            {
                label_prod.Visible = true;
                txt_product.Visible = true;
                label_prodline.Visible = false;
                cb_prodline.Visible = false;
             
            }

        }

        private void txt_product_TextChanged(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("Select product_tbl.Product_ID, product_tbl.Product_Name, productline_tbl.Product_Line FROM product_tbl INNER JOIN productline_tbl on productline_tbl.ProductLineID = product_tbl.ProductLineID  WHERE Product_ID LIKE '%"+ txt_product.Text+ "%' OR Product_Name LIKE '%" + txt_product.Text + "%'", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                con.Close();
                dataGridView1.DataSource = dt;
             
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            SetGridViewProperties();
            SetFontAndColors();
        }

        private void cb_prodline_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("Select product_tbl.Product_ID, product_tbl.Product_Name, productline_tbl.Product_Line FROM product_tbl INNER JOIN productline_tbl on productline_tbl.ProductLineID = product_tbl.ProductLineID  WHERE Product_Line LIKE '%" + cb_prodline.Text + "%'", con);
                SqlDataReader sdr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(sdr);
                con.Close();
                dataGridView1.DataSource = dt;
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            SetGridViewProperties();
            SetFontAndColors();
        }
        Bitmap bmp;
        private void print_btn_Click(object sender, EventArgs e)
        {
            int height = dataGridView1.Height;
            dataGridView1.Height = dataGridView1.RowCount * dataGridView1.RowTemplate.Height * 2;
            bmp = new Bitmap(dataGridView1.Width, dataGridView1.Height);
            dataGridView1.DrawToBitmap(bmp, new Rectangle(0, 0, dataGridView1.Width, dataGridView1.Height));
            dataGridView1.Height = height;
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bmp, 0, 0);
        }
    }
}
