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
    public partial class PurchaseOrdertoSupplier : Form
    {
        public PurchaseOrdertoSupplier(string Product_ID, string Product_Description, string Unit_Price)
        {
            InitializeComponent();
            
            txt_productID.Text = Product_ID;
            txt_product.Text = Product_Description;
            txt_unitprice.Text = Unit_Price;
            timer1.Start();
        }
        //SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-3IB33KC2;Initial Catalog=SalesAndInventoryforSustenaEMC;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        SqlConnection con = new SqlConnection(@"Data Source=WRENZO;Initial Catalog=SalesAndInventorySEMC;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

        public bool IsPostBack { get; private set; }

        private void close_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PurchaseOrdertoSupplier_Load(object sender, EventArgs e)
        {
            
                loadtotextbox();
            
        }

        private void txt_dateorder_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            txt_dateorder.Text = dt.ToString("MMMMMMMMM dd yyyy");
        }
        public void loadtotextbox()
        {
            
            
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT supplier_tbl.Supplier_Name  FROM product_tbl INNER JOIN supplier_tbl on supplier_tbl.SupplierID = product_tbl.SupplierID WHERE Product_ID = '"+txt_productID.Text+"'",con);
                SqlCommand cmd1 = new SqlCommand("SELECT unit_tbl.Unit_Description  FROM product_tbl INNER JOIN unit_tbl on unit_tbl.unitID = product_tbl.unitID WHERE Product_ID = '" + txt_productID.Text + "'", con);
                string supplier = (string)cmd.ExecuteScalar();
                string unit = (string)cmd1.ExecuteScalar();
                SqlDataReader sdr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(sdr);
                con.Close();
                txt_unit.Text = unit;
                txt_supplier.Text = supplier;
            }
            catch { }
        }
        public void totalitemscomputation()
        {
            try
            {
                string unitNumbers = string.Join("", txt_unit.Text.ToArray().Where(Char.IsDigit));
                int unitquantity = Convert.ToInt32(dud_unitquantity.Text);
                decimal unitNumbersnumber = Decimal.Parse(unitNumbers);
                decimal totalitem = unitNumbersnumber * unitquantity;
                txt_totalitems.Text = totalitem.ToString();
            }
            catch { }
        }
        public void totalPrice()
        {
            try
            {
                decimal unitprice = Convert.ToInt32(txt_unitprice.Text);
                decimal unitquantity = Convert.ToInt32(dud_unitquantity.Text);
                decimal totalprice = unitprice * unitquantity;
                txt_totalprice.Text = totalprice.ToString();
            }
            catch { }
        }

        private void txt_unit_TextChanged(object sender, EventArgs e)
        {
            totalitemscomputation();
        }

        private void txt_unit_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void txt_productID_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txt_unitprice_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txt_totalitems_TextChanged(object sender, EventArgs e)
        {
            totalitemscomputation();
        }

        private void dud_unitquantity_SelectedItemChanged(object sender, EventArgs e)
        {
            totalitemscomputation();
            totalPrice();
        }

        private void txt_totalprice_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string prodid = txt_productID.Text;
            string dateOrder = txt_dateorder.Text;
            string dateDue = dtp_datedue.Text;
            string unit = dud_unitquantity.Text;
            string price = txt_totalprice.Text;
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO purchaseorder_tbl (ProductID, Date_Order, Date_Due, Unit_Quantity, Total_Price) VALUES((SELECT ProductID FROM product_tbl WHERE Product_ID = '"+prodid+"' ), '"+dateOrder+"','"+dateDue+"','"+unit+"','"+price+"')",con);
                SqlDataReader sdr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(sdr);
                con.Close();
            }
            catch { }
            this.Close();
        }

        private void txt_totalprice_Click(object sender, EventArgs e)
        {

        }

        private void txt_totalprice_TextChanged_1(object sender, EventArgs e)
        {
            totalPrice();
        }

        private void dud_unitquantity_TextChanged(object sender, EventArgs e)
        {
            totalPrice();
        }
    }
}
