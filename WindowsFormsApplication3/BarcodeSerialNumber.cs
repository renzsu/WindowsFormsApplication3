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
    public partial class BarcodeSerialNumber : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=WRENZO;Initial Catalog=SalesAndInventorySEMC;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        //SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-3IB33KC2;Initial Catalog=SalesAndInventoryforSustenaEMC;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

        SqlDataAdapter sda;
        public BarcodeSerialNumber()
        {
            InitializeComponent();
        }

        private void BarcodeSerialNumber_Load(object sender, EventArgs e)
        {
            textBox2.Text = Product_Maintenance.bcodesn;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
            con.Open();
            sda = new SqlDataAdapter("UPDATE product_tbl SET Barcode_SN = '"+textBox1.Text+"'  where Product_Name = '" + textBox2.Text + "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            con.Close();
            this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
