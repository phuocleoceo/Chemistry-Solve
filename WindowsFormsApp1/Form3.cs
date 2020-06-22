using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void btndang1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dang1 a = new Dang1();            
            a.Closed += (s, args) => this.Close();
            a.Show();
        }

        private void btndang2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dang2 b = new Dang2();
            b.Closed += (s, args) => this.Close();
            b.Show();
        }
    }
}
