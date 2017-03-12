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
    public partial class LoginForm : Form
    {
        
        public static string usernam;
        public LoginForm()
        {
            InitializeComponent();
           
           
        }

        private void button1_Click(object sender, EventArgs e)
        {

            //SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-3IB33KC2;Initial Catalog=SalesAndInventoryforSustenaEMC;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            SqlConnection con = new SqlConnection(@"Data Source=WRENZO;Initial Catalog=SalesAndInventorySEMC;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

            try
            {
                usernam = textBox1.Text;
                SqlCommand cmd = new SqlCommand("Select UserLevelID From user_tbl where Username = '" + textBox1.Text + "' and Password = '" + textBox2.Text + "'", con);
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);
                con.Close();

                if (dt.Rows.Count > 0)
                {
                    con.Open();
                    DateTime dt1 = DateTime.Now;
                    dt1.ToString("MM/dd/yy hh:mm tt");
                    SqlCommand cmd1 = new SqlCommand("INSERT INTO audit_tbl(UserID, Log_In) values((Select UserID FROM user_tbl WHERE Username = '" + textBox1.Text + "'), '" + dt1 + "') ", con);
                    SqlDataReader sdr = cmd1.ExecuteReader();
                    DataTable datatable = new DataTable();
                    datatable.Load(sdr);
                    con.Close();

                    string usertype = dt.Rows[0]["USerLevelID"].ToString();
                    if (usertype.Equals("1"))
                    {
                        

                        AdminMenu frm2 = new AdminMenu();
                        frm2.Show();
                        this.Hide();
                        textBox1.Clear();
                        textBox2.Clear();
                    }
                    else if (usertype.Equals("2"))
                    {
                        testing tst = new testing();
                        tst.Show();
                        this.Hide();
                    }
                  
                }
                else if (textBox1.Text == "" && textBox2.Text == "")
                {
                        InputUserAndPass iuap = new InputUserAndPass();
                        iuap.Show();
                        button1.Enabled = false;                          
                }
                else if (textBox1.Text == "")
                {
                    MessageBox.Show("Input Username");
                }
                else if (textBox2.Text == "")
                {
                    MessageBox.Show("Input Password");
                }

                else
                {
                    InvalidUserOrPass iup = new InvalidUserOrPass();
                    iup.Show();
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Unexpected Error" + ex.Message);
            }
            



        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
        }
    }


}


