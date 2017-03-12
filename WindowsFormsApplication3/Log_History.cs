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
using DGVPrinterHelper;

namespace WindowsFormsApplication3
{
    public partial class Log_History : Form
    {
        public Log_History()
        {
            InitializeComponent();
        }
        //SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-3IB33KC2;Initial Catalog=SalesAndInventoryforSustenaEMC;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        SqlConnection con = new SqlConnection(@"Data Source=WRENZO;Initial Catalog=SalesAndInventorySEMC;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

        private void close_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void radio_button(object sender, EventArgs e)
        {

        }
        public void loadtodatagrid()
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("Select audit_tbl.Audit_ID, user_tbl.Username, userlevel_tbl.User_Level, audit_tbl.Log_In, audit_tbl.Log_Out FROM audit_tbl INNER JOIN user_tbl on user_tbl.UserID = audit_tbl.UserID INNER JOIN userlevel_tbl on userlevel_tbl.UserLevelID = user_tbl.UserLevelID",con);
                SqlDataReader sdr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(sdr);
                con.Close();
                dataGridView1.DataSource = dt;
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
            dataGridView1.Columns[0].Width = 120;
            dataGridView1.Columns[1].Width = 120;
            dataGridView1.Columns[2].Width = 150;
            dataGridView1.Columns[3].Width = 200;
            dataGridView1.Columns[4].Width = 200;


            dataGridView1.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            foreach (DataGridViewColumn col in dataGridView1.Columns)
            {
                col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                col.HeaderCell.Style.Font = new Font("Century Gothic", 12F, GraphicsUnit.Pixel);
            }
        }

        private void cb_all_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_all.Checked == true)
            {
                gb_username.Visible = false;
                gb_position.Visible = false;
                gb_date.Visible = false;

            }
            else if (cb_username.Checked == true)
            {
                gb_username.Visible = true;
                gb_position.Visible = false;
                gb_date.Visible = false;
            }
            else if (radioButton3.Checked == true)
            {
                gb_username.Visible = false;
                gb_position.Visible = true;
                gb_date.Visible = false;
            }
            else if (radioButton4.Checked == true)
            {
                gb_username.Visible = false;
                gb_position.Visible = false;
                gb_date.Visible = true;
            }
        
    }

        private void txt_product_TextChanged(object sender, EventArgs e)
        {
            string search = txt_search.Text;
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("Select audit_tbl.Audit_ID, user_tbl.Username, userlevel_tbl.User_Level, audit_tbl.Log_In, audit_tbl.Log_Out FROM audit_tbl INNER JOIN user_tbl on user_tbl.UserID = audit_tbl.UserID INNER JOIN userlevel_tbl on userlevel_tbl.UserLevelID = user_tbl.UserLevelID WHERE Username LIKE '%"+search+"%'", con);
                SqlDataReader sdr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(sdr);
                con.Close();
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            SetFontAndColors();
            SetGridViewProperties();
        }

        private void Log_History_Load(object sender, EventArgs e)
        {
            loadtodatagrid();
            SetFontAndColors();
            SetGridViewProperties();
           
            
        }

        private void cb_position_SelectedIndexChanged(object sender, EventArgs e)
        {
            string search = cb_position.Text;
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("Select audit_tbl.Audit_ID, user_tbl.Username, userlevel_tbl.User_Level, audit_tbl.Log_In, audit_tbl.Log_Out FROM audit_tbl INNER JOIN user_tbl on user_tbl.UserID = audit_tbl.UserID INNER JOIN userlevel_tbl on userlevel_tbl.UserLevelID = user_tbl.UserLevelID WHERE User_Level LIKE '%" + search + "%'", con);
                SqlDataReader sdr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(sdr);
                con.Close();
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            SetFontAndColors();
            SetGridViewProperties();
        }
       // Bitmap bmp;
        private void print_btn_Click(object sender, EventArgs e)
        {
            DGVPrinter printer = new DGVPrinter();
            printer.Title = "Log History";
            printer.SubTitle = string.Format("Date: {0}", DateTime.Now.Date);
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            

            /*int height = dataGridView1.Height;
            dataGridView1.Height = dataGridView1.RowCount * dataGridView1.RowTemplate.Height * 2;
            bmp = new Bitmap(dataGridView1.Width, dataGridView1.Height);
            dataGridView1.DrawToBitmap(bmp, new Rectangle(0, 0, dataGridView1.Width, dataGridView1.Height));
            dataGridView1.Height = height;
            printPreviewDialog1.ShowDialog();*/
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
           //e.Graphics.DrawImage(bmp, 0, 0);
        }
    }

}