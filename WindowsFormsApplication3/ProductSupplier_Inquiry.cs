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
    public partial class ProductSupplier_Inquiry : Form
    {
        public ProductSupplier_Inquiry()
        {
            InitializeComponent();
        }
        //SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-3IB33KC2;Initial Catalog=SalesAndInventoryforSustenaEMC;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        SqlConnection con = new SqlConnection(@"Data Source=WRENZO;Initial Catalog=SalesAndInventorySEMC;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

        private void close_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ProductSupplier_Inquiry_Load(object sender, EventArgs e)
        {
            loadtodatagrid();
            SetFontAndColors();
            SetGridViewProperties();
            SuppliertoComboBox();
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
            dataGridView1.Columns[3].Width = 220;
            dataGridView1.Columns[4].Width = 320;
            dataGridView1.Columns[5].Width = 300;


            dataGridView1.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            foreach (DataGridViewColumn col in dataGridView1.Columns)
            {
                col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                col.HeaderCell.Style.Font = new Font("Century Gothic", 12F, GraphicsUnit.Pixel);
            }
        }
        public void radiobutton()
        {
            if (rb_product.Checked == true)
            {
                label_supp.Hide();
                cb_supplier.Hide();
                label_prod.Show();
                txt_product.Show();
            }
            else if (rb_supplier.Checked == true)
            {
                label_prod.Hide();
                txt_product.Hide();
                label_supp.Show();
                cb_supplier.Show();
            }
        }
        public void loadtodatagrid()
        {
            try
            {
                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("Select product_tbl.Product_ID, product_tbl.Product_Name, supplier_tbl.Supplier_Name, unit_tbl.Unit_Description, product_tbl.Price_per_piece, product_tbl.Price FROM product_tbl INNER JOIN supplier_tbl on supplier_tbl.SupplierID = product_tbl.SupplierID INNER JOIN unit_tbl on unit_tbl.UnitID = product_tbl.UnitID ", con);
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
        public void SuppliertoComboBox()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select Supplier_Name from supplier_tbl", con);
            SqlDataReader sdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Rows.Add();
            dt.Columns.Add("Supplier_Name", typeof(string));
            dt.Load(sdr);
            con.Close();
            cb_supplier.ValueMember = "Supplier_Name";
            cb_supplier.DataSource = dt;
            
        }

        private void rb_product_CheckedChanged(object sender, EventArgs e)
        {
            radiobutton();
        }

        private void txt_product_TextChanged(object sender, EventArgs e)
        {
            string search = txt_product.Text;
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("Select product_tbl.Product_ID, product_tbl.Product_Name, supplier_tbl.Supplier_Name, unit_tbl.Unit_Description, product_tbl.Price_per_piece, product_tbl.Price FROM product_tbl INNER JOIN supplier_tbl on supplier_tbl.SupplierID = product_tbl.SupplierID INNER JOIN unit_tbl on unit_tbl.UnitID = product_tbl.UnitID WHERE (Product_ID LIKE '%" + search + "%' OR Product_Name LIKE '%" + search + "%')", con);
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
            SetFontAndColors();
            SetGridViewProperties();
        }

        private void cb_supplier_SelectedIndexChanged(object sender, EventArgs e)
        {
            string search = cb_supplier.Text;
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("Select product_tbl.Product_ID, product_tbl.Product_Name, supplier_tbl.Supplier_Name, unit_tbl.Unit_Description, product_tbl.Price_per_piece, product_tbl.Price FROM product_tbl INNER JOIN supplier_tbl on supplier_tbl.SupplierID = product_tbl.SupplierID INNER JOIN unit_tbl on unit_tbl.UnitID = product_tbl.UnitID WHERE Supplier_Name LIKE '%" + search + "%'", con);
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
            SetFontAndColors();
            SetGridViewProperties();
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
