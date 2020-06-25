using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Dang3 : Form
    {
        public Dang3()
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

        private void btntinh_Click(object sender, EventArgs e)
        {
            double mFEOXIT = double.Parse(txtFeOxit.Text);
            double nNO = double.Parse(txtNO.Text)/ (double)22.4 ;
            double nNO2 = double.Parse(txtNO2.Text) / (double)22.4;
            double nN2O = double.Parse(txtN2O.Text) / (double)22.4;
            double nN2 = double.Parse(txtN2.Text) / (double)22.4;
            double nEkhi = nNO * 3 + nNO2 * 1 + nN2O * 8 + nN2 * 10;
            // gọi a là khối lượng Fe , m là của oxit
            // Bảo toàn e : 3a/56 = (m-a)/16 * 2 + Số mol e từ khí
            // => a = ( m/8 + MolEKhi )*28/5
            double mFe = (mFEOXIT / 8 + nEkhi) * 28 / 5;
            txtFe.Text = mFe.ToString();
            //
            double nHNO3 = (mFEOXIT - mFe) / 16 * 2 + nNO * 4 + nNO2 * 2 + nN2O * 10 + nN2 * 12;
            txtHNO3.Text = nHNO3.ToString();
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtFe.Text = "";
            txtFeOxit.Text = "";
            txtHNO3.Text = "";
            txtNO.Text = "0";
            txtNO2.Text = "0";
            txtN2O.Text = "0";
            txtN2.Text = "0";
        }        
    }
}
