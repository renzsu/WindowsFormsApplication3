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
    public partial class Supplier_Inquiry : Form
    {
        public Supplier_Inquiry()
        {
            InitializeComponent();
        }
        //SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-3IB33KC2;Initial Catalog=SalesAndInventoryforSustenaEMC;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        SqlConnection con = new SqlConnection(@"Data Source=WRENZO;Initial Catalog=SalesAndInventorySEMC;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");


        private void close_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Supplier_Inquiry_Load(object sender, EventArgs e)
        {
            loadtodatagrid();
            SetFontAndColors();
            SetGridViewProperties();
            
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
        public void loadtodatagrid()
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select Supplier_ID, Supplier_Name, Contact_Person, Telephone_No, Cellphone_No, Address, Supplier_Email, Lead_Time from supplier_tbl", con);
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string search = txt_search.Text;
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("Select Supplier_ID, Supplier_Name, Contact_Person, Telephone_No, Cellphone_No, Address, Supplier_Email, Lead_Time from supplier_tbl WHERE (Supplier_ID LIKE '%"+search+"%' OR Supplier_Name LIKE '%" + search + "%' OR Contact_Person LIKE '%"+search+"%' OR Address LIKE '%"+search+"%' OR Supplier_Email LIKE '%"+search+"%' OR Lead_Time LIKE '%"+search +"%')", con);
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
