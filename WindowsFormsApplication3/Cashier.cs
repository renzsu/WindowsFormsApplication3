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
    public partial class Cashier : Form
    {
        bool isOperationPerformed = false;
        private TextBox focusedTextbox = null;
       
        public Cashier()
        {
            

            InitializeComponent();
            foreach (TextBox tb in this.Controls.OfType<TextBox>())
            {
                tb.Enter += textBox_Enter;
            }
        }

        private void Cashier_Load(object sender, EventArgs e)
        {
            textBox2.Enabled = false;
            textBox4.Enabled = false;
            textBox5.Enabled = false;
            textBox6.Enabled = false;
            textBox7.Enabled = false;

        }
        void textBox_Enter(object sender, EventArgs e)
        {
            focusedTextbox = (TextBox)sender;
        }

        private void numberclick(object sender, EventArgs e)
        {
            if (focusedTextbox != null)
            {
                if ((focusedTextbox.Text == "0") || (isOperationPerformed))
                    focusedTextbox.Clear();
                isOperationPerformed = false;
                Button button = (Button)sender;
                if (button.Text == ".")
                {
                    if (!focusedTextbox.Text.Contains("."))
                        focusedTextbox.Text = focusedTextbox.Text + button.Text;
                }
                else
                    focusedTextbox.Text = focusedTextbox.Text + button.Text;
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (focusedTextbox != null)
            {
                int length = focusedTextbox.TextLength - 1;
                string text = focusedTextbox.Text;
                focusedTextbox.Clear();
                for (int i = 0; i < length; i++)
                    focusedTextbox.Text = focusedTextbox.Text + text[i];
            }
     
        }

        private void button10_Click(object sender, EventArgs e)
        {
           /* AdminMenu frm1 = new AdminMenu();
            frm1.Show();
            this.Hide();*/
        }
    }
}
