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
    public partial class PurchaseOrder : Form
    {
        //SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-3IB33KC2;Initial Catalog=SalesAndInventoryforSustenaEMC;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        SqlConnection con = new SqlConnection(@"Data Source=WRENZO;Initial Catalog=SalesAndInventorySEMC;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        SqlDataAdapter sda;

        //DataTable dt;
        DataSet ds = new DataSet();
        public PurchaseOrder()
        {
            InitializeComponent();
        }

        private void PurchaseOrder_Load(object sender, EventArgs e)
        {
            SetFontAndColors();
            try
            {
                loadtabletodatagridview();
                SetGridViewProperties();
                loadtolistview();
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
            dataGridView1.Columns[0].Width = 150;
            dataGridView1.Columns[1].Width = 150;
            dataGridView1.Columns[2].Width = 100;


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
            sda = new SqlDataAdapter("select Supplier_ID , Supplier_Name, Lead_Time from supplier_tbl", con);
            DataSet ds = new DataSet();
            sda.Fill(ds, "Products_Table");
            con.Close();
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "Products_Table";
        }
        private void close_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void del_btn_Click(object sender, EventArgs e)
        {

            foreach (ListViewItem item in listView1.CheckedItems)
            {

                PurchaseOrdertoSupplier POS = new PurchaseOrdertoSupplier(item.SubItems[0].Text, item.SubItems[1].Text, item.SubItems[2].Text);
                POS.Show();
               
            }

        }
        public void loadtolistview()
        {
            listView1.Items.Clear();
            
            try
            {
                string sr = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                con.Open();
                listView1.View = View.Details;
                SqlDataAdapter sda = new SqlDataAdapter("Select product_tbl.Product_ID, product_tbl.Product_Name, product_tbl.Price From product_tbl INNER JOIN supplier_tbl on supplier_tbl.SupplierID = product_tbl.SupplierID  where Supplier_ID = '"+sr+"'  ", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                con.Close();

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    DataRow dr = dt.Rows[i];
                    ListViewItem LI = new ListViewItem(dr["Product_ID"].ToString());
                    LI.SubItems.Add(dr["Product_Name"].ToString());
                    LI.SubItems.Add(dr["Price"].ToString());
                    listView1.Items.Add(LI);

                }
                             
            }
            catch
            {}
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            /*try
            {
                SqlCommand cmd = new SqlCommand("select SupplierID, Supplier_Name, Lead_Time from supplier_tbl", con);
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);
                con.Close();
                if (dt.Rows.Count > 0)
                {
                    string supplierstring = (dt.Rows[0]["supplier_name"].ToString());
                    SqlCommand cmdd = new SqlCommand("select Product_ID, Product_Name, Unit_Description, Supplier, Price, Price_per_piece from product_tbl", con);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }*/
        }

        private void datagridview(object sender, MouseEventArgs e)
        {
           // textBox1.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            loadtolistview();
        }
    }
}
