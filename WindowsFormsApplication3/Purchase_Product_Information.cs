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
    public partial class Purchase_Product_Information : Form
    {
        public Purchase_Product_Information(string Order_No, string Product_ID, string Product_Description, string Unit_Quantity)
        {
            InitializeComponent();
            txt_orderno.Text = Order_No;
            txt_productID.Text = Product_ID;
            txt_product.Text = Product_Description;
            dud_unitquantity.Text = Unit_Quantity;
           
            timer1.Start();
            
        }
       // SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-3IB33KC2;Initial Catalog=SalesAndInventoryforSustenaEMC;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
               SqlConnection con = new SqlConnection(@"Data Source=WRENZO;Initial Catalog=SalesAndInventorySEMC;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

        private void close_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Purchase_Product_Information_Load(object sender, EventArgs e)
        {
            loadtotextbox();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            txt_datereceive.Text = dt.ToString("MMMMMMMMM dd yyyy");
        }
        public void loadtotextbox()
        {
            string orderid = txt_orderno.Text;
            string prodid = txt_productID.Text;
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("Select supplier_tbl.Supplier_Name FROM product_tbl INNER JOIN supplier_tbl on supplier_tbl.SupplierID = product_tbl.SupplierID WHERE Product_ID = '"+prodid+"'",con);
                SqlCommand cmd1 = new SqlCommand("Select unit_tbl.Unit_Description FROM product_tbl INNER JOIN unit_tbl ON unit_tbl.UnitID = product_tbl.UnitID WHERE Product_ID = '"+prodid+"'",con);
                //SqlCommand cmd2 = new SqlCommand("SELECT product_tbl.Price FROM purchaseorder_tbl INNER JOIN product_tbl ON product_tbl.ProductID = purchaseorder_tbl.ProductID WHERE Order_ID = '"+orderid+"'",con);
                string supplier = (string)cmd.ExecuteScalar();
                string unit = (string)cmd1.ExecuteScalar();
                //string price = (string)cmd2.ExecuteScalar();
                SqlDataReader sdr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(sdr);
                con.Close();
                txt_supplier.Text = supplier;
                txt_unit.Text = unit;
                //txt_unitprice.Text = price;
            }
            catch { }
        }
    }
}
