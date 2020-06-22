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
    public partial class Dang1 : Form
    {
        public Dang1()
        {
            InitializeComponent();
        }

        private void btntinh_Click(object sender, EventArgs e)
        {
            double KhoiLuongKimLoai = double.Parse(txtkimloai.Text);
            double MolH2 = double.Parse(txth2.Text)/22.4;
            double KhoiLuongAxit=0;
            if (rdbhcl.Checked) KhoiLuongAxit = MolH2 * 2 * 36.5;
            if (rdbh2so4.Checked) KhoiLuongAxit = MolH2 * 98;
            txtmuoi.Text = (KhoiLuongKimLoai + KhoiLuongAxit - MolH2 * 2).ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Closed += (s, args) => this.Close();
            home.Show();
            this.Hide();
        }
    }
}
