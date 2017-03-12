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
    
    public partial class User_Maintenance : Form
    {
        

        public User_Maintenance()
        {

            InitializeComponent();
            

        }

        // SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-3IB33KC2;Initial Catalog=SalesAndInventoryforSustenaEMC;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        SqlConnection con = new SqlConnection(@"Data Source=WRENZO;Initial Catalog=SalesAndInventorySEMC;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");



        private void close_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void User_Maintenance_Load(object sender, EventArgs e)
        {
            loadtodatagrid();
            SetFontAndColors();
            SetGridViewProperties();
            txt_userID.ReadOnly = true;
            
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
            dataGridView1.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            foreach (DataGridViewColumn col in dataGridView1.Columns)
            {
                col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                col.HeaderCell.Style.Font = new Font("Century Gothic", 12F, GraphicsUnit.Pixel);
            }
        }
        public void loadtodatagrid()
        {
            try
            {
                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("Select user_tbl.User_ID, userlevel_tbl.User_Level, user_tbl.Username, user_tbl.Password, user_tbl.Last_Name, user_tbl.First_Name, user_tbl.Address, user_tbl.Contact_No, user_tbl.Email_Address From user_tbl Inner Join userlevel_tbl on userlevel_tbl.UserLevelID = user_tbl.UserLevelID",con);
                DataSet ds = new DataSet();
                sda.Fill(ds, "User_table");
                con.Close();
                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = "User_table";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void cleartext()
        {
            txt_Lname.Clear();
            txt_Fname.Clear();
            txt_address.Clear();
            txt_contactno.Clear();
            txt_email.Clear();
            txt_userID.Clear();
            cb_pos.ResetText();
            txt_username.Clear();
            txt_pass.Clear();
            txt_REpass.Clear();
            loadtodatagrid();
        }


        private void add_btn_Click(object sender, EventArgs e)
        {
            string ln = txt_Lname.Text;
            string fn = txt_Fname.Text;
            string address = txt_address.Text;
            string contact = txt_contactno.Text;
            string ea = txt_email.Text;
            string un = txt_username.Text;
            string pass = txt_pass.Text;
            string rp = txt_REpass.Text;
            string pos = cb_pos.Text;
            if (ln == "" || fn == "" || address == "" || pos == "" || un == "" || pass == "" || rp == "")
            {
                MessageBox.Show("Some Fields are required");
            }
            else
            {
                if (txt_pass.Text == txt_REpass.Text)
                {
                    try
                    {
                        con.Open();
                        SqlCommand cmd = new SqlCommand("INSERT INTO user_tbl (UserLevelID, Last_Name, First_Name, Address, Contact_No, Email_Address, Username, Password) values((Select UserLevelID from userlevel_tbl where User_Level = '" + pos + "' ), '" + ln + "', '" + fn + "', '" + address + "', '" + contact + "', '" + ea + "', '" + un + "', '" + pass + "')", con);
                        SqlDataReader sdr = cmd.ExecuteReader();
                        DataTable dt = new DataTable();
                        dt.Load(sdr);
                        con.Close();
                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("Password Didn't Match");
                }
            }
            cleartext();



        }
        /*public void checkavailability()
        {
            try
            {
                con.Open();
                bool exist = false;
                SqlCommand cmd = new SqlCommand("Select * FROM user_tbl where Username = @username",con);
                cmd.Parameters.AddWithValue("username", txt_username.Text);
                exist = (int)cmd.ExecuteScalar() > 0;
                con.Close();
                if (exist)
                {
                    label14.Show();
                    add_btn.Enabled = false;
                }
                else
                {
                    label14.Hide();
                    add_btn.Enabled = true;
                }
                

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        */
        private void txt_REpass_TextChanged(object sender, EventArgs e)
        {
            if (txt_pass.Text != txt_REpass.Text)
            {
                label12.Show();
                add_btn.Enabled = false;
                update_btn.Enabled = false;
                del_btn.Enabled = false;
            }
            if (txt_pass.Text == txt_REpass.Text || txt_REpass.Text == "")
            {
                label12.Hide();
                add_btn.Enabled = true;
                update_btn.Enabled = true;
                del_btn.Enabled = true;
            }
        }

        private void cb_pos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void combobox(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void datagridview(object sender, EventArgs e)
        {
            try
            {
                txt_userID.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                cb_pos.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                txt_username.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                txt_pass.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                txt_Lname.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                txt_Fname.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
                txt_address.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
                txt_contactno.Text = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
                txt_email.Text = dataGridView1.SelectedRows[0].Cells[8].Value.ToString();
            }
            catch 
            {
                
            }
           
        }

        private void txt_contactno_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
            txt_contactno.MaxLength = 11;
            
        }

        private void update_btn_Click(object sender, EventArgs e)
        {
            string ln = txt_Lname.Text;
            string fn = txt_Fname.Text;
            string address = txt_address.Text;
            string contact = txt_contactno.Text;
            string ea = txt_email.Text;
            string un = txt_username.Text;
            string pass = txt_pass.Text;
            string rp = txt_REpass.Text;
            string pos = cb_pos.Text;
            string ui = txt_userID.Text;
            if (ln == "" || fn == "" || address == "" || pos == "" || un == "" || pass == "" || rp == "")
            {
                MessageBox.Show("Check Fields");
            }
            else
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("UPDATE user_tbl SET Last_Name = '" + ln + "', First_Name = '" + fn + "', Address = '" + address + "', Contact_No = '" + contact + "', Email_Address = '" + ea + "', UserLevelID = (Select UserLevelID from userlevel_tbl where User_Level = '" + pos + "' ), Username = '" + un + "', Password = '" + pass + "' where User_ID = '" + ui + "'", con);
                    SqlDataReader sdr = cmd.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(sdr);
                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                loadtodatagrid();
            }


        }
        public void delbtn()
        {
           
        }

        private void del_btn_Click(object sender, EventArgs e)
        {
            string ui = txt_userID.Text;

            if (txt_userID.Text == "")
            {
                Warning W = new Warning();
                W.Show();
            }

            else
            {
                if (txt_userID.Text == "USER001")
                {
                    MessageBox.Show("USER001 cannot be deleted", MessageBoxIcon.Warning.ToString());
                    
                }
                else if (MessageBox.Show("Are you sure you want to Delete?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        con.Open();
                        SqlCommand cmd = new SqlCommand("Delete from user_tbl where User_ID = '" + ui + "'", con);
                        SqlDataReader sdr = cmd.ExecuteReader();
                        DataTable dt = new DataTable();
                        dt.Load(sdr);
                        con.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    loadtodatagrid();
                }

                else { }
                }

            
        }

        private void txt_pass_TextChanged(object sender, EventArgs e)
        {
            if (txt_pass.Text == "")
            {
                label13.Hide();

            }
            if (txt_pass.Text.Length < 6)
            {
                label13.Show();
                add_btn.Enabled = false;
                update_btn.Enabled = false;
                del_btn.Enabled = false;
            }
            
            if (txt_pass.Text.Length == 0 || txt_pass.Text.Length >= 6)
            {
                label13.Hide();
                add_btn.Enabled = true;
                update_btn.Enabled = true;
                del_btn.Enabled = true;
            }
            
        }

        private void txt_username_TextChanged(object sender, EventArgs e)
        {
            //checkavailability();
        }
    }
}
