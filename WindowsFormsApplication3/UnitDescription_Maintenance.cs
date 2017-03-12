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
    public partial class UnitDescription_Maintenance : Form
    {
        //SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-3IB33KC2;Initial Catalog=SalesAndInventoryforSustenaEMC;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        SqlConnection con = new SqlConnection(@"Data Source=WRENZO;Initial Catalog=SalesAndInventorySEMC;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        SqlDataAdapter sda;

        DataTable dt;
        DataSet ds = new DataSet();
        public UnitDescription_Maintenance()
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
            dataGridView1.Columns[0].Width = 200;
            dataGridView1.Columns[1].Width = 200;
            

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
            sda = new SqlDataAdapter("select Unit_ID, Unit_Description from unit_tbl", con);
            DataSet ds = new DataSet();
            sda.Fill(ds, "Products_Table");
            con.Close();
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "Products_Table";
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            if (cb_container.Text == "" || dud_quantity.Text == "" || cb_desc.Text == "")
            {
                Invalid inv = new Invalid();
                inv.Show();
            }

            else
            {
                try
                {


                    con.Open();
                    sda = new SqlDataAdapter("INSERT INTO unit_tbl (Unit_Description, Quantity)" + "values ('" + cb_container.Text + " (" + dud_quantity.Text + cb_desc.Text + " )" + "', '"+dud_quantity.Text+"' )", con);


                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                txt_unitID.Clear();
                cb_container.ResetText();
                dud_quantity.ResetText();
                cb_desc.ResetText();
                loadtabletodatagridview();

            }
        }

        private void UnitDescription_Maintenance_Load(object sender, EventArgs e)
        {
            SetFontAndColors();
            try
            {
                loadtabletodatagridview();
                SetGridViewProperties();
                txt_unitID.ReadOnly = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void update_btn_Click(object sender, EventArgs e)
        {

            if (txt_unitID.Text == "" /*|| txt_prodname.Text == "" || cb_ProdLine.Text == "" || cb_netwt.Text == "" || cb_unit.Text == ""*/)
            {
                /*Invalid inv = new Invalid();
                inv.Show();*/
            }

            else
            {
                try
                {


                    con.Open();
                    sda = new SqlDataAdapter("UPDATE unit_tbl SET Unit_Description = '" + cb_container.Text + " (" + dud_quantity.Text + cb_desc.Text + " )" + "', Quantity = '" + dud_quantity.Text + "' where Unit_ID = '" + txt_unitID.Text + "'", con);


                    dt = new DataTable();
                    sda.Fill(dt);
                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                txt_unitID.Clear();
                txt_unitID.Clear();
                cb_container.ResetText();
                dud_quantity.ResetText();
                cb_desc.ResetText();
                loadtabletodatagridview();
                
            }
        }

        private void dataGridView(object sender, MouseEventArgs e)
        {
            try
            {

                txt_unitID.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                
               
            }
            catch
            {
                
            }
        }

        private void del_btn_Click(object sender, EventArgs e)
        {


            if (txt_unitID.Text == "")
            {
                MessageBox.Show("Specify product to delete");
            }

            else
            {
                DelYesNo DYN = new DelYesNo(txt_unitID.Text);
                DYN.ShowDialog();



                txt_unitID.Clear();
                cb_container.ResetText();
                dud_quantity.ResetText();
                cb_desc.ResetText();
                loadtabletodatagridview();

            }
        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (cb_searchby.Text == "Unit_ID")
                {
                    SqlDataAdapter sda = new SqlDataAdapter("Select Unit_ID, Unit_Description, Quantity from Unit_tbl where Unit_ID LIKE '" + txt_search.Text + "%'", con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
                else if (cb_searchby.Text == "Quantity")
                {
                    SqlDataAdapter sda = new SqlDataAdapter("Select Unit_ID, Unit_Description, Quantity from Unit_tbl where Quantity LIKE '" + txt_search.Text + "%'", con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
                else if (cb_searchby.Text == "Description")
                {
                    SqlDataAdapter sda = new SqlDataAdapter("Select Unit_ID, Unit_Description, Quantity from Unit_tbl where Description LIKE '" + txt_search.Text + "%'", con);
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

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void combobox(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}

