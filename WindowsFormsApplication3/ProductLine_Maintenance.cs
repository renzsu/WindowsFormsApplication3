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
    public partial class ProductLine_Maintenance : Form
    {
        //SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-3IB33KC2;Initial Catalog=SalesAndInventoryforSustenaEMC;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        SqlConnection con = new SqlConnection(@"Data Source=WRENZO;Initial Catalog=SalesAndInventorySEMC;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        SqlDataAdapter sda;

        DataTable dt;
        DataSet ds = new DataSet();
        public ProductLine_Maintenance()
        {
            InitializeComponent();
        }

        private void close_btn_Click(object sender, EventArgs e)
        {
            this.Close();
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
            dataGridView1.Columns[0].Width = 320;
            dataGridView1.Columns[1].Width = 320;
          

            dataGridView1.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            foreach (DataGridViewColumn col in dataGridView1.Columns)
            {
                col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                col.HeaderCell.Style.Font = new Font("Century Gothic", 12F, GraphicsUnit.Pixel);
            }
        }
        public void loadtabletodatagridview()
        {
            try
            {
                con.Open();
                sda = new SqlDataAdapter("select ProductLine_ID, Product_Line from productline_tbl", con);
                DataSet ds = new DataSet();
                sda.Fill(ds, "Products_Table");
                
                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = "Products_Table";
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        public void search()
        {
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        private void add_btn_Click(object sender, EventArgs e)
        {
            if (txt_prodline.Text == "")
            {
                Invalid inv = new Invalid();
                inv.Show();
            }

            else
            {
                try
                {


                    con.Open();
                    sda = new SqlDataAdapter("INSERT INTO productline_tbl (Product_Line)" + "values ('" + txt_prodline.Text + "')", con);


                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                txt_prodlineID.Clear();
                txt_prodline.Clear();
                loadtabletodatagridview();

            }
        }

        private void ProductLine_Maintenance_Load(object sender, EventArgs e)
        {
            SetFontAndColors();
            try
            {
                loadtabletodatagridview();
                SetGridViewProperties();
                txt_prodlineID.ReadOnly = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void update_btn_Click(object sender, EventArgs e)
        {
            string prodlineid = txt_prodlineID.Text;
            string prodline = txt_prodline.Text;
          
            if (txt_prodlineID.Text == "" /*|| txt_prodname.Text == "" || cb_ProdLine.Text == "" || cb_netwt.Text == "" || cb_unit.Text == ""*/)
            {
                NoRecordstoUpdate NRU = new NoRecordstoUpdate();
                NRU.Show();
            }

            else
            {
                try
                {


                    con.Open();
                    sda = new SqlDataAdapter("UPDATE productline_tbl SET  Product_Line = '" + prodline + "' where ProductLine_ID = '" + prodlineid + "'", con);


                    dt = new DataTable();
                    sda.Fill(dt);
                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                txt_prodlineID.Clear();
                txt_prodline.Clear();
                loadtabletodatagridview();
            }
        }

        private void dataGridview(object sender, MouseEventArgs e)
        {
            try
            {

                txt_prodlineID.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                txt_prodline.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
             
            }
            catch
            {
                
            }
        }

        private void del_btn_Click(object sender, EventArgs e)
        {
            string prodlineid = txt_prodlineID.Text;

            if (txt_prodlineID.Text == "")
            {
                Warning W = new Warning();
                W.Show();
            }

            else
            {
                DeleteYN DYN = new DeleteYN(txt_prodlineID.Text);
                DYN.ShowDialog();
                
                txt_prodlineID.Clear();
                txt_prodline.Clear();
                loadtabletodatagridview();

            }
        }
    }
}
