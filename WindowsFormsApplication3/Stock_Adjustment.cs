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
    public partial class Stock_Adjustment : Form
    {

        public Stock_Adjustment()
        {
            InitializeComponent();
        }
        //SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-3IB33KC2;Initial Catalog=SalesAndInventoryforSustenaEMC;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        SqlConnection con = new SqlConnection(@"Data Source=WRENZO;Initial Catalog=SalesAndInventorySEMC;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

        private void close_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Stock_Adjustment_Load(object sender, EventArgs e)
        {
            loadodatagrid();
            SetFontAndColors();
            SetGridViewProperties();

        }
        public void loadodatagrid()
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("Select Product_ID, Product_Name, Warehouse_Quantity, Store_Quantity FROM product_tbl",con);
                SqlDataReader sdr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(sdr);
                con.Close();
                dataGridView1.DataSource = dt;
            }
            catch
            {

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
            dataGridView1.Columns[0].Width = 200;
            dataGridView1.Columns[1].Width = 200;
            dataGridView1.Columns[2].Width = 200;
            dataGridView1.Columns[3].Width = 200;

            dataGridView1.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            foreach (DataGridViewColumn col in dataGridView1.Columns)
            {
                col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                col.HeaderCell.Style.Font = new Font("Century Gothic", 12F, GraphicsUnit.Pixel);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string wh = dud_warehouse.Text;
            string sq = dud_displayed.Text;
            string pn = txt_product.Text;
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("UPDATE product_tbl SET Warehouse_Quantity =  '"+wh+"', Store_Quantity = '"+sq+"' WHERE Product_Name = '"+pn+"'",con);
                SqlDataReader sdr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(sdr);
                con.Close();
            }
            catch { }
            loadodatagrid();
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            try
            {
                txt_product.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                dud_warehouse.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                dud_displayed.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            }
            catch { }
        }
    }
}
