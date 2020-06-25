using System;
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

        private void btndang3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dang3 c = new Dang3();
            c.Closed += (s, args) => this.Close();
            c.Show();
        }

        private void btndang4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dang4 d = new Dang4();
            d.Closed += (s, args) => this.Close();
            d.Show();
        }

        private void btndang5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dang5 g = new Dang5();
            g.Closed += (s, args) => this.Close();
            g.Show();
        }

        private void btndang6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dang6 f = new Dang6();
            f.Closed += (s, args) => this.Close();
            f.Show();
        }
    }
}
