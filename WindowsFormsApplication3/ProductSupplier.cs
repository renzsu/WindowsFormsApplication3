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
    public partial class ProductSupplier : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=WRENZO;Initial Catalog=SalesAndInventorySEMC;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        SqlDataAdapter sda;
        //DataTable dt;
        public ProductSupplier()
        {
            InitializeComponent();
        }

        private void close_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void loaddatattotable()
        {
            con.Open();
            sda = new SqlDataAdapter("Select Product_ID, Product_Name, Product_Line from product_tbl", con);
            DataSet ds = new DataSet();
            sda.Fill(ds, "Products_Table");
            con.Close();
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "Products_Table";
        }
        private void ProductSupplier_Load(object sender, EventArgs e)
        {
            try
            {
                loaddatattotable();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
