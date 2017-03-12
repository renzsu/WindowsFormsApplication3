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
    public partial class AdminMenu : Form
    {
        //SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-3IB33KC2;Initial Catalog=SalesAndInventoryforSustenaEMC;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        SqlConnection con = new SqlConnection(@"Data Source=WRENZO;Initial Catalog=SalesAndInventorySEMC;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");


        public AdminMenu()
        {
            InitializeComponent();
            

            timer1.Start();
            

            
        }
        int counter = 0;
        int len = 0;
        string txt;

        private void button1_Click(object sender, EventArgs e)
        {
              
        }

        private void button5_Click(object sender, EventArgs e)
        {
          
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void maintenanceToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void casheringToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {

        }

        private void toolStripContainer1_LeftToolStripPanel_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to logout ?", "Logout", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                try
                {
                    con.Open();
                    DateTime time = DateTime.Now;
                    SqlCommand cmd = new SqlCommand("UPDATE audit_tbl SET Log_out = '" + time + "' WHERE auditID = (SELECT MAX(auditID) FROM audit_tbl)", con);
                    SqlDataReader sdr = cmd.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(sdr);
                    con.Close();
                }
                catch
                {

                }
                LoginForm LF = new LoginForm();
                LF.Show();
                this.Close();
            }
        }

        private void fileSystemWatcher1_Changed(object sender, System.IO.FileSystemEventArgs e)
        {

        }

        private void productToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            if (this.MdiChildren.Length < 1)
            {
                try
                {
                    Product_Maintenance PM = new Product_Maintenance();
                    PM.MdiParent = this;
                    PM.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error:" + ex);
                }
            }
            else
            {
                ModuleWarning MW = new ModuleWarning();
                MW.Show();
            }


            /*AdminMenu.MdiParent = me
            AdminMenu.formporderstyle = Windows.Forms.FormBorderStyle.None;
            AdminMenu.ControlBox = false;
            AdminMenu.MaximizeBox = false;
            AdminMenu.MinimizeBox = false;
            AdminMenu.text = "";
            AdminMenu.dock = DockStyle.Fill;*/

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AdminMenu_Load(object sender, EventArgs e)
        {
            txt = label3.Text;
            len = txt.Length;
            label3.Text = "";
            timer2.Start();
            label6.Text = LoginForm.usernam;
        }

        private void productLineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            if (this.MdiChildren.Length < 1)
            {
                try
                {
                    ProductLine_Maintenance PLM = new ProductLine_Maintenance();
                    PLM.MdiParent = this;
                    PLM.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error:" + ex);
                }
            }
            else
            {
                ModuleWarning MW = new ModuleWarning();
                MW.Show();
            }

        }

        private void unitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            if (this.MdiChildren.Length < 1)
            {
                try
                {
                    UnitDescription_Maintenance UDM = new UnitDescription_Maintenance();
                    UDM.MdiParent = this;
                    UDM.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error:" + ex);
                }
            }
            else
            {
                ModuleWarning MW = new ModuleWarning();
                MW.Show();
            }



        }

        private void toolStripDropDownButton1_Click(object sender, EventArgs e)
        {

        }

        private void supplierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length < 1)
            {
                try
                {
                    SupplierMaintenance SM = new SupplierMaintenance();
                    SM.MdiParent = this;
                    SM.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error:" + ex);
                }
            }
            else
            {
                ModuleWarning MW = new ModuleWarning();
                MW.Show();
            }
        }

        private void productSupplierToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
}

        private void purchaseOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length < 1)
            {
                try
                {
                    PurchaseOrder PO = new PurchaseOrder();
                    PO.MdiParent = this;
                    PO.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error:" + ex);
                }
            }
            else
            {
                ModuleWarning MW = new ModuleWarning();
                MW.Show();
            }
        }

        private void receiveDeliveryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length < 1)
            {
                try
                {
                    ReceiveDelivery RD = new ReceiveDelivery();
                    RD.MdiParent = this;
                    RD.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error:" + ex);
                }
            }
            else
            {
                ModuleWarning MW = new ModuleWarning();
                MW.Show();
            }

        }

        private void backOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length < 1)
            {
                try
                {
                    ReceiveBackOrder RBO =  new ReceiveBackOrder();
                    RBO.MdiParent = this;
                    RBO.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error:" + ex);
                }
            }
            else
            {
                ModuleWarning MW = new ModuleWarning();
                MW.Show();
            }

        }

        private void toolStripDropDownButton5_Click(object sender, EventArgs e)
        {

        }

        private void casheringToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length < 1)
            {
                try
                {
                    Cashiering Csh = new Cashiering();
                    Csh.MdiParent = this;
                    Csh.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error:" + ex);
                }
            }
            else
            {
                ModuleWarning MW = new ModuleWarning();
                MW.Show();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime time = DateTime.Now;
            this.label2.Text = time.ToString("hh:mm:ss tt");
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            counter++;
            if (counter > len)
            {
                counter = 0;
                label3.Text = "";
            }
            else
            {
                label3.Text = txt.Substring(0, counter);

                label3.ForeColor = Color.White;
                 

            }
        }

        private void vatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length < 1)
            {
                try
                {
                    Vat_Maintenance VM = new Vat_Maintenance();
                    VM.MdiParent = this;
                    VM.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error:" + ex);
                }
            }
            else
            {
                ModuleWarning MW = new ModuleWarning();
                MW.Show();
            }
        }

        private void stockAdjustmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length < 1)
            {
                try
                {
                    Stock_Adjustment SA = new Stock_Adjustment();
                    SA.MdiParent = this;
                    SA.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error:" + ex);
                }
            }
            else
            {
                ModuleWarning MW = new ModuleWarning();
                MW.Show();
            }
        }

        private void productsInCriticalLevelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length < 1)
            {
                try
                {
                    Critical_Level_of_Products CLP = new Critical_Level_of_Products();
                    CLP.MdiParent = this;
                    CLP.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error:" + ex);
                }
            }
            else
            {
                ModuleWarning MW = new ModuleWarning();
                MW.Show();
            }
        }

        private void stockOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length < 1)
            {
                try
                {
                    Stock_Out SO = new Stock_Out();
                    SO.MdiParent = this;
                    SO.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error:" + ex);
                }
            }
            else
            {
                ModuleWarning MW = new ModuleWarning();
                MW.Show();
            }
        }

        private void userMaintenanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length < 1)
            {
                try
                {
                    User_Maintenance UM = new User_Maintenance();
                    UM.MdiParent = this;
                    UM.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error:" + ex);
                }
            }
            else
            {
                ModuleWarning MW = new ModuleWarning();
                MW.Show();
            }
        }

        private void logHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length < 1)
            {
                try
                {
                    Log_History LH = new Log_History();
                    LH.MdiParent = this;
                    LH.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error:" + ex);
                }
            }
            else
            {
                ModuleWarning MW = new ModuleWarning();
                MW.Show();
            }
        }

        private void productToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length < 1)
            {
                try
                {
                    Product_Inquiry PI = new Product_Inquiry();
                    PI.MdiParent = this;
                    PI.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error:" + ex);
                }
            }
            else
            {
                ModuleWarning MW = new ModuleWarning();
                MW.Show();
            }
        }

        private void supplierListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length < 1)
            {
                try
                {
                    Supplier_Inquiry SI = new Supplier_Inquiry();
                    SI.MdiParent = this;
                    SI.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error:" + ex);
                }
            }
            else
            {
                ModuleWarning MW = new ModuleWarning();
                MW.Show();
            }
        }

        private void productSupplierListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length < 1)
            {
                try
                {
                    ProductSupplier_Inquiry PSI = new ProductSupplier_Inquiry();
                    PSI.MdiParent = this;
                    PSI.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error:" + ex);
                }
            }
            else
            {
                ModuleWarning MW = new ModuleWarning();
                MW.Show();
            }
        }

        private void priceListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length < 1)
            {
                try
                {
                    Price_Inquiry PSI = new Price_Inquiry();
                    PSI.MdiParent = this;
                    PSI.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error:" + ex);
                }
            }
            else
            {
                ModuleWarning MW = new ModuleWarning();
                MW.Show();
            }
        
    }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Exit_Form EF = new Exit_Form();
            EF.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}
