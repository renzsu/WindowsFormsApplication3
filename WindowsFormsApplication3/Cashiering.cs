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
    public partial class Cashiering : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=WRENZO;Initial Catalog=SalesAndInventorySEMC;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        int total = 0;
        private InputQuantity iq;
        public Cashiering()
        {
            InitializeComponent();
        }

        private void close_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Cashiering_Load(object sender, EventArgs e)
        {
            listView1.View = View.Details;
            listView1.Columns.Add("Product Name", listView1.Width / 3, HorizontalAlignment.Right);
            listView1.Columns.Add("Price", listView1.Width / 3, HorizontalAlignment.Left);
            listView1.Columns.Add("Quantity", listView1.Width / 3, HorizontalAlignment.Left);
           
        }

        private void button7_Click(object sender, EventArgs e)
        {
            iq = new InputQuantity();
            iq.MdiParent = this.ParentForm;
            iq.Closed += quantityevent;
            iq.Show();
            
        }
        private void quantityevent(object sender, EventArgs e)
        {
            textBox1.Text = InputQuantity.qty;
            try
            {
                listView1.View = View.Details;
                SqlCommand cmd = new SqlCommand("select product_name from product_tbl where barcode_sn = '" + textBox4.Text + "'", con);
                SqlCommand cmd1 = new SqlCommand("select price_per_piece from product_tbl where barcode_sn = '" + textBox4.Text + "'", con);
                SqlCommand cmd2 = new SqlCommand("select product_name, price_per_piece from product_tbl where barcode_sn = '" + textBox4.Text + "'", con);
                SqlCommand cmdquantity = new SqlCommand("select store_quantity from product_tbl where barcode_sn = '" + textBox4.Text + "'", con);
                con.Open();
                int strqunatity = (int)cmdquantity.ExecuteScalar();
                con.Close();


                if (int.Parse(textBox1.Text) <= strqunatity)
                {
                    con.Open();
                    SqlDataReader sdr = cmd2.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(sdr);
                    string prodname = (string)cmd.ExecuteScalar();
                    decimal price = (decimal)cmd1.ExecuteScalar() * int.Parse(textBox1.Text) ;
                    con.Close();

                    
                    string pricep = price.ToString();
                    label12.Text = prodname;
                    label13.Text = pricep;
                    textBox4.Clear();
                    textBox4.Focus();
                    decimal totalprice = decimal.Parse(label18.Text);
                    decimal pieceprice = Convert.ToDecimal(label13.Text) * decimal.Parse(textBox1.Text);

                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        DataRow dr = dt.Rows[i];
                        ListViewItem listitem = new ListViewItem(dr["Product_name"].ToString());
                        listitem.SubItems.Add(label13.Text);
                        listitem.SubItems.Add(textBox1.Text);
                        listView1.Items.Add(listitem);
                    }
                    totalprice += decimal.Parse(label13.Text);
                    label18.Text = totalprice.ToString();
                }
                else
                {
                    MessageBox.Show("Not enough stocks");
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
                con.Close();
            }
        }
        private void Cashiering_Load_1(object sender, EventArgs e)
        {
                   
            listView1.View = View.Details;
            listView1.Columns.Add("Product Name", listView1.Width / 3, HorizontalAlignment.Right);
            listView1.Columns.Add("Price", listView1.Width / 3, HorizontalAlignment.Left);
            listView1.Columns.Add("Quantity", listView1.Width / 3 - 1, HorizontalAlignment.Left);
            
            

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }
    }
}