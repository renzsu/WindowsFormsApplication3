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
    public partial class Splash : Form
    {
        public Splash()
        {
            InitializeComponent();
        }
        Timer s;
        private void Splash_Load(object sender, EventArgs e)
        {
            s = new Timer();
            s.Interval = 5000;
            s.Start();
            s.Tick += new EventHandler(s_Tick);
        }
        void s_Tick(object sender, EventArgs e)
        {
            s.Stop();
            LoginForm LF = new LoginForm();
            LF.Show();
            this.Hide();
        }
    }
}
