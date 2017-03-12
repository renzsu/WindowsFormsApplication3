using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{

    public partial class InputQuantity : Form
    {
        public static string qty;
        public InputQuantity()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Equals(null))
            {
                MessageBox.Show("Input Desired Quantity.");
            }
            else
            {
                qty = textBox1.Text;
                this.Close();
            }
        }

        private void InputQuantity_Load(object sender, EventArgs e)
        {
            textBox1.Focus();
            textBox1.Text = "1";
            if (!String.IsNullOrEmpty(textBox1.Text))
            {
                textBox1.SelectionStart = 0;
                textBox1.SelectionLength = textBox1.Text.Length;
            }
        }
    }
}
