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
    public partial class ReceiveDelivery : Form
    {
        public ReceiveDelivery()
        {
            InitializeComponent();
        }
        //SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-3IB33KC2;Initial Catalog=SalesAndInventoryforSustenaEMC;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        SqlConnection con = new SqlConnection(@"Data Source=WRENZO;Initial Catalog=SalesAndInventorySEMC;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

        private void close_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void del_btn_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listView1.CheckedItems)
            {

                Purchase_Product_Information PPI = new Purchase_Product_Information(item.SubItems[0].Text, item.SubItems[1].Text, item.SubItems[2].Text, item.SubItems[3].Text);
                PPI.Show();

            }


        }

        private void ReceiveDelivery_Load(object sender, EventArgs e)
        {
            loadtodatagrid();
            SetFontAndColors();
            SetGridViewProperties();
            loadtolistview();
        }
        public void loadtodatagrid()
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT supplier_tbl.Supplier_ID, supplier_tbl.Supplier_Name, purchaseorder_tbl.Date_Order, purchaseorder_tbl.Date_Due FROM purchaseorder_tbl INNER JOIN product_tbl ON product_tbl.ProductID = purchaseorder_tbl.ProductID INNER JOIN supplier_tbl ON supplier_tbl.SupplierID = product_tbl.SupplierID GROUP BY Supplier_ID, Supplier_Name, Date_Order, Date_Due", con);
                SqlDataReader sdr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(sdr);
                con.Close();
                dataGridView1.DataSource = dt;
            }
            catch { }
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
            dataGridView1.Columns[1].Width = 220;
            dataGridView1.Columns[2].Width = 250;
            dataGridView1.Columns[3].Width = 250;


            dataGridView1.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            foreach (DataGridViewColumn col in dataGridView1.Columns)
            {
                col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                col.HeaderCell.Style.Font = new Font("Century Gothic", 12F, GraphicsUnit.Pixel);
            }
        }
        public void loadtolistview()
        {
            listView1.Items.Clear();

            try
            {
                string sr = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                string dateOrder = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                con.Open();
                listView1.View = View.Details;
                SqlDataAdapter sda = new SqlDataAdapter("Select purchaseorder_tbl.Order_ID, product_tbl.Product_ID, product_tbl.Product_Name, purchaseorder_tbl.Unit_Quantity, purchaseorder_tbl.Total_Price From purchaseorder_tbl INNER JOIN product_tbl on product_tbl.ProductID = purchaseorder_tbl.ProductID INNER JOIN supplier_tbl ON supplier_tbl.SupplierID = product_tbl.SupplierID  where (Supplier_ID =  '" + sr + "' AND Date_Order = '" + dateOrder + "') ", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                con.Close();

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    DataRow dr = dt.Rows[i];
                    ListViewItem LI = new ListViewItem(dr["Order_ID"].ToString());
                    LI.SubItems.Add(dr["Product_ID"].ToString());
                    LI.SubItems.Add(dr["Product_Name"].ToString());
                    LI.SubItems.Add(dr["Unit_Quantity"].ToString());
                    LI.SubItems.Add(dr["Total_Price"].ToString());
                    listView1.Items.Add(LI);

                }

            }
            catch
            { }
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            loadtolistview();
        }
    }
}
