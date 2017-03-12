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
    public partial class Product_Maintenance : Form
    {
        //SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-3IB33KC2;Initial Catalog=SalesAndInventoryforSustenaEMC;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        SqlConnection con = new SqlConnection(@"Data Source=WRENZO;Initial Catalog=SalesAndInventorySEMC;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        SqlDataAdapter sda;

        DataTable dt;
        DataSet ds = new DataSet();
        public static string bcodesn;
        public Product_Maintenance()
        {
            InitializeComponent();

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
            dataGridView1.Columns[2].Width = 200;
            dataGridView1.Columns[3].Width = 220;
            dataGridView1.Columns[4].Width = 220;
            dataGridView1.Columns[5].Width = 0;
            dataGridView1.Columns[6].Width = 220;
            dataGridView1.Columns[7].Width = 220;

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
            sda = new SqlDataAdapter("Select product_tbl.Product_ID, product_tbl.Product_Name, productline_tbl.Product_Line, unit_tbl.Unit_Description, supplier_tbl.Supplier_Name, product_tbl.Mark_Up, product_tbl.Price, product_tbl.Price_per_piece From product_tbl Inner Join productline_tbl on productline_tbl.ProductLineID = product_tbl.ProductLineID Inner Join unit_tbl on unit_tbl.UnitID = product_tbl.UnitID Inner Join supplier_tbl on supplier_tbl.SupplierID = product_tbl.SupplierID", con);
            DataSet ds = new DataSet();
            sda.Fill(ds, "Products_Table");
            con.Close();
            dataGridView1.DataSource = ds;

            dataGridView1.DataMember = "Products_Table";
        }
        void productlinetocombobox()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select product_line from productline_tbl", con);
            SqlDataReader sdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Rows.Add();
            dt.Columns.Add("Product_Line", typeof(string));
            dt.Load(sdr);

            cb_ProdLine.ValueMember = "Product_Line";
            cb_ProdLine.DataSource = dt;
            con.Close();
        }
        void unittocombobox()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select Unit_Description from unit_tbl", con);
            SqlDataReader sdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Rows.Add();
            dt.Columns.Add("Unit_Description", typeof(string));
            dt.Load(sdr);
            con.Close();
            cb_unit.ValueMember = "Unit_Description";
            cb_unit.DataSource = dt;

        }
        void suppliertocombobox()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select Supplier_Name from supplier_tbl", con);
            SqlDataReader sdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Rows.Add();
            dt.Columns.Add("Supplier_Name", typeof(string));
            dt.Load(sdr);
            con.Close();
            cb_supplier.ValueMember = "Supplier_Name";
            cb_supplier.DataSource = dt;

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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            try
            {
                if (cb_searchby.Text == "ProductID")
                {
                    SqlDataAdapter sda = new SqlDataAdapter("Select product_tbl.Product_ID, product_tbl.Product_Name, productline_tbl.Product_Line, unit_tbl.Unit_Description, supplier_tbl.Supplier_Name, product_tbl.Mark_Up, product_tbl.Price, product_tbl.Price_per_piece From product_tbl Inner Join productline_tbl on productline_tbl.ProductLineID = product_tbl.ProductLineID Inner Join unit_tbl on unit_tbl.UnitID = product_tbl.UnitID Inner Join supplier_tbl on supplier_tbl.SupplierID = product_tbl.SupplierID  where Product_ID LIKE '%" + txt_search.Text + "%'", con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
                else if (cb_searchby.Text == "ProductName")
                {
                    SqlDataAdapter sda = new SqlDataAdapter("Select product_tbl.Product_ID, product_tbl.Product_Name, productline_tbl.Product_Line, unit_tbl.Unit_Description, supplier_tbl.Supplier_Name, product_tbl.Mark_Up, product_tbl.Price, product_tbl.Price_per_piece From product_tbl Inner Join productline_tbl on productline_tbl.ProductLineID = product_tbl.ProductLineID Inner Join unit_tbl on unit_tbl.UnitID = product_tbl.UnitID Inner Join supplier_tbl on supplier_tbl.SupplierID = product_tbl.SupplierID where Product_Name LIKE '" + txt_search.Text + "%'", con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
                else if (cb_searchby.Text == "ProductLine")
                {
                    SqlDataAdapter sda = new SqlDataAdapter("Select product_tbl.Product_ID, product_tbl.Product_Name, productline_tbl.Product_Line, unit_tbl.Unit_Description, supplier_tbl.Supplier_Name, product_tbl.Mark_Up, product_tbl.Price, product_tbl.Price_per_piece From product_tbl Inner Join productline_tbl on productline_tbl.ProductLineID = product_tbl.ProductLineID Inner Join unit_tbl on unit_tbl.UnitID = product_tbl.UnitID Inner Join supplier_tbl on supplier_tbl.SupplierID = product_tbl.SupplierID where Product_Line LIKE '" + txt_search.Text + "%'", con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
                else if (cb_searchby.Text == "Unit")
                {
                    SqlDataAdapter sda = new SqlDataAdapter("Select product_tbl.Product_ID, product_tbl.Product_Name, productline_tbl.Product_Line, unit_tbl.Unit_Description, supplier_tbl.Supplier_Name, product_tbl.Mark_Up, product_tbl.Price, product_tbl.Price_per_piece From product_tbl Inner Join productline_tbl on productline_tbl.ProductLineID = product_tbl.ProductLineID Inner Join unit_tbl on unit_tbl.UnitID = product_tbl.UnitID Inner Join supplier_tbl on supplier_tbl.SupplierID = product_tbl.SupplierID where Unit_Description LIKE '" + txt_search.Text + "%'", con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
                else if (cb_searchby.Text == "Supplier")
                {
                    SqlDataAdapter sda = new SqlDataAdapter("Select product_tbl.Product_ID, product_tbl.Product_Name, productline_tbl.Product_Line, unit_tbl.Unit_Description, supplier_tbl.Supplier_Name, product_tbl.Mark_Up, product_tbl.Price, product_tbl.Price_per_piece From product_tbl Inner Join productline_tbl on productline_tbl.ProductLineID = product_tbl.ProductLineID Inner Join unit_tbl on unit_tbl.UnitID = product_tbl.UnitID Inner Join supplier_tbl on supplier_tbl.SupplierID = product_tbl.SupplierID where Supplier LIKE '" + txt_search.Text + "%'", con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
                else if (cb_searchby.Text == "Price")
                {
                    SqlDataAdapter sda = new SqlDataAdapter("Select product_tbl.Product_ID, product_tbl.Product_Name, productline_tbl.Product_Line, unit_tbl.Unit_Description, supplier_tbl.Supplier_Name, product_tbl.Mark_Up, product_tbl.Price, product_tbl.Price_per_piece From product_tbl Inner Join productline_tbl on productline_tbl.ProductLineID = product_tbl.ProductLineID Inner Join unit_tbl on unit_tbl.UnitID = product_tbl.UnitID Inner Join supplier_tbl on supplier_tbl.SupplierID = product_tbl.SupplierID where Price LIKE '" + txt_search.Text + "%'", con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            SetGridViewProperties();
            SetFontAndColors();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string prodname = txt_prodname.Text + cb_netwt.Text;
            string price = txt_Price.Text;
            string pp = txt_perpiece.Text;
            string prodline = cb_ProdLine.Text;
            string unit = cb_unit.Text;
            double mrkup = Convert.ToDouble(nud_markUp.Value);
            string mrkupt = mrkup.ToString();
            string supp = cb_supplier.Text;


            if (txt_prodname.Text == "" || cb_ProdLine.Text == "" || cb_unit.Text == "" || cb_supplier.Text == "" || txt_Price.Text == "")
            {
                Invalid inv = new Invalid();
                inv.Show();
            }

            else
            {
                try
                {
                    bcodesn = txt_prodname.Text + cb_netwt.Text;
                    con.Open();
                    sda = new SqlDataAdapter("INSERT INTO product_tbl (Product_Name, ProductLineID, UnitID, SupplierID, warehouse_quantity, store_quantity, Mark_Up, Price, Price_per_piece)" + "values ('" + prodname + "',(Select ProductLineID from productline_tbl where Product_Line = '" + prodline + "'),(Select UnitID from unit_tbl where Unit_Description = '" + unit + "'),(Select SupplierID from supplier_tbl where Supplier_Name = '" + supp + "'), '"+ "0" +"', '"+ "0" +"', '" +mrkupt+ "', '" + price + "', '" + pp + "')", con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    con.Close();
                    BarcodeSerialNumber bcsn = new BarcodeSerialNumber();
                    bcsn.MdiParent = this.ParentForm;
                    bcsn.Show();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                txt_prodID.Clear();
                txt_prodname.Clear();
                cb_netwt.ResetText();
                cb_ProdLine.ResetText();
                cb_unit.ResetText();
                cb_supplier.ResetText();
                txt_Price.Clear();
                txt_perpiece.Clear();
                loadtabletodatagridview();

            }
        }

        private void edit_btn_Click(object sender, EventArgs e)
        {


        }

        private void Product_Maintenance_Load(object sender, EventArgs e)
        {
            nud_markUp.Maximum = 10;
            nud_markUp.Minimum = 1;
            SetFontAndColors();
            try
            {
                loadtabletodatagridview();
                SetGridViewProperties();
                productlinetocombobox();
                unittocombobox();
                suppliertocombobox();
                txt_prodID.ReadOnly = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        //public static string sendtext = ;
        private void del_btn_Click(object sender, EventArgs e)
        {
            string prodid = txt_prodID.Text;

            if (txt_prodID.Text == "")
            {
                Warning W = new Warning();
                W.Show();
            }

            else
            {
                DeleteYesorNo DYN = new DeleteYesorNo(txt_prodID.Text);
                DYN.ShowDialog();




                txt_prodID.Clear();
                txt_prodname.Clear();
                cb_netwt.ResetText();
                cb_ProdLine.ResetText();
                cb_unit.ResetText();
                cb_supplier.ResetText();
                txt_Price.Clear();
                txt_perpiece.Clear();
                loadtabletodatagridview();

            }
        }

        private void updatedata_Click(object sender, EventArgs e)
        {
            string prodid = txt_prodID.Text;
            string prodname = txt_prodname.Text + cb_netwt.Text;
            string prodline = cb_ProdLine.Text;
            string produnit = cb_unit.Text;
            string prodsupp = cb_supplier.Text;
            int mrkup = Convert.ToInt32(nud_markUp.Value);
            string price = txt_Price.Text;
            string pp = txt_perpiece.Text;
            

            if (txt_prodID.Text == "" /*|| txt_prodname.Text == "" || cb_ProdLine.Text == "" || cb_netwt.Text == "" || cb_unit.Text == ""*/)
            {
                NoRecordstoUpdate NRU = new NoRecordstoUpdate();
                NRU.Show();
            }

            else
            {
                try
                {


                    con.Open();
                    sda = new SqlDataAdapter("UPDATE product_tbl SET Product_Name = '" + prodname + "', ProductLineID = (Select ProductLineID from productline_tbl where Product_Line = '" + prodline + "'), UnitID = (Select UnitID from unit_tbl where Unit_Description = '" + produnit + "'), SupplierID = (Select SupplierID from supplier_tbl where Supplier_Name = '" + prodsupp + "'),Mark_Up = '"+mrkup+"', Price = '" + price + "', Price_per_piece = '" + pp + "'  where Product_ID = '" + prodid + "'", con);


                    dt = new DataTable();
                    sda.Fill(dt);
                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                txt_prodID.Clear();
                txt_prodname.Clear();
                cb_netwt.ResetText();
                cb_ProdLine.ResetText();
                cb_unit.ResetText();
                cb_supplier.ResetText();
                txt_Price.Clear();
                txt_perpiece.Clear();
                loadtabletodatagridview();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void dataGridView(object sender, MouseEventArgs e)
        {
            try
            {

                txt_prodID.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                txt_prodname.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                cb_ProdLine.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                cb_unit.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                cb_supplier.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                txt_Price.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
                txt_perpiece.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
                nud_markUp.Text = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
                txt_Price.Text = dataGridView1.SelectedRows[0].Cells[8].Value.ToString();
                txt_perpiece.Text = dataGridView1.SelectedRows[0].Cells[9].Value.ToString();
            }
            catch
            {

            }
        }

        private void cb_searchby_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cb_ProdLine_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txt_Price_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
            txt_Price.MaxLength = 6;
            txt_perpiece.MaxLength = 6;
        }

        private void cb_supplier_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
        public void markupcomputation()
        {
            try
            {
                if (txt_Price.Text == "" && cb_unit.Text == "")
                {
                    decimal markUp = Convert.ToDecimal(nud_markUp.Value);
                    decimal markUppercent = markUp / 100;
                    decimal unitPrice = 0;
                    string unitNumbers = string.Join("", cb_unit.Text.ToArray().Where(Char.IsDigit));
                    decimal unitNumbersnumber = 1;
                    decimal piecePricebm = unitPrice / unitNumbersnumber;
                    decimal finalresult = piecePricebm * markUppercent + piecePricebm;
                    decimal finalresultfinal = Decimal.Round(finalresult, 2, MidpointRounding.AwayFromZero);
                    txt_perpiece.Text = finalresultfinal.ToString();
                }
                else if (txt_Price.Text == "")
                {
                    decimal markUp = Convert.ToDecimal(nud_markUp.Value);
                    decimal markUppercent = markUp / 100;
                    decimal unitPrice = 0;
                    string unitNumbers = string.Join("", cb_unit.Text.ToArray().Where(Char.IsDigit));
                    decimal unitNumbersnumber = Decimal.Parse(unitNumbers);
                    decimal piecePricebm = unitPrice / unitNumbersnumber;
                    decimal finalresult = piecePricebm * markUppercent + piecePricebm;
                    decimal finalresultfinal = Decimal.Round(finalresult, 2, MidpointRounding.AwayFromZero);
                    txt_perpiece.Text = finalresultfinal.ToString();
                }
                else if (cb_unit.Text == "")
                {
                    decimal markUp = Convert.ToDecimal(nud_markUp.Value);
                    decimal markUppercent = markUp / 100;
                    decimal unitPrice = Convert.ToInt32(txt_Price.Text);
                    //string unitNumbers = string.Join("", cb_unit.Text.ToArray().Where(Char.IsDigit));
                    decimal unitNumbersnumber = 1;
                    decimal piecePricebm = unitPrice / unitNumbersnumber;
                    decimal finalresult = piecePricebm * markUppercent + piecePricebm;
                    decimal finalresultfinal = Decimal.Round(finalresult, 2, MidpointRounding.AwayFromZero);
                    txt_perpiece.Text = finalresultfinal.ToString();
                }
                else
                {
                    decimal markUp = Convert.ToDecimal(nud_markUp.Value);
                    decimal markUppercent = markUp / 100;
                    decimal unitPrice = Convert.ToInt32(txt_Price.Text);
                    string unitNumbers = string.Join("", cb_unit.Text.ToArray().Where(Char.IsDigit));
                    decimal unitNumbersnumber = Decimal.Parse(unitNumbers);
                    decimal piecePricebm = unitPrice / unitNumbersnumber;
                    decimal finalresult = piecePricebm * markUppercent + piecePricebm;
                    decimal finalresultfinal = Decimal.Round(finalresult, 2, MidpointRounding.AwayFromZero);
                    txt_perpiece.Text = finalresultfinal.ToString();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }
        private void nud_markUp_ValueChanged(object sender, EventArgs e)
        {
            markupcomputation();

        }

        private void txt_Price_TextChanged(object sender, EventArgs e)
        {
            markupcomputation();
        }

        private void cb_unit_SelectedIndexChanged(object sender, EventArgs e)
        {
            markupcomputation();
        }

        private void addsupp_btn_Click(object sender, EventArgs e)
        {
            SupplierMaintenance sm = new SupplierMaintenance();
            sm.MdiParent = this.ParentForm;
            sm.Show();
        }

        private void addpline_btn_Click(object sender, EventArgs e)
        {
            ProductLine_Maintenance PLM = new ProductLine_Maintenance();
            PLM.MdiParent = this.ParentForm;
            PLM.Show();
        }

        private void addunit_btn_Click(object sender, EventArgs e)
        {
            UnitDescription_Maintenance UDM = new UnitDescription_Maintenance();
            UDM.MdiParent = this.ParentForm;
            UDM.Show();
        }
    }
}
