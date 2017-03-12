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
    public partial class Price_Inquiry : Form
    {
        public Price_Inquiry()
        {
            InitializeComponent();
        }
        //SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-3IB33KC2;Initial Catalog=SalesAndInventoryforSustenaEMC;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        SqlConnection con = new SqlConnection(@"Data Source=WRENZO;Initial Catalog=SalesAndInventorySEMC;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

        private void Price_Inquiry_Load(object sender, EventArgs e)
        {
            loadtodatagrid();
            SetFontAndColors();
            SetGridViewProperties();
        }
        public void loadtodatagrid()
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("Select Product_ID, Product_Name, Price_per_piece as Price FROM product_tbl",con);
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

        private void close_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_product_TextChanged(object sender, EventArgs e)
        {
            string search = txt_product.Text;
            try
            {
                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("Select Product_ID, Product_Name, Price_per_piece as Price FROM product_tbl WHERE (Product_ID LIKE '%" + search + "%' OR Product_Name LIKE '%" + search + "%' OR Price_per_piece LIKE '%"+search+"%')", con);
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
