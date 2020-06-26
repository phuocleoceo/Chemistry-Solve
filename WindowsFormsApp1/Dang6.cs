using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Dang6 : Form
    {
        public Dang6()
        {
            InitializeComponent();
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
