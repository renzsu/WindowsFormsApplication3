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
    public partial class DeleteYesorNo : Form
    {
        //SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-3IB33KC2;Initial Catalog=SalesAndInventoryforSustenaEMC;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        SqlConnection con = new SqlConnection(@"Data Source=WRENZO;Initial Catalog=SalesAndInventorySEMC;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        SqlDataAdapter sda;

        DataTable dt;
        DataSet ds = new DataSet();

        public DeleteYesorNo(string Str_value)
        {
            InitializeComponent();
            textBox1.Text = Str_value;
        }

        private void DeleteYesorNo_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            try
            {
                con.Open();
                sda = new SqlDataAdapter("DELETE FROM product_tbl where Product_ID = '" + textBox1.Text + "'", con);
                dt = new DataTable();
                sda.Fill(dt);
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    }

