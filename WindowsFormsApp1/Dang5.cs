using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Dang5 : Form
    {
        public Dang5()
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
            double molAlO2 = double.Parse(txtAlO2.Text);
            double molH = double.Parse(txtH.Text);
            double T = molH / molAlO2;
            if (T < 1)
            {
                txtNhanXet.Text = "AlO2- dư, H+ hết, tạo Al(OH)3 kết tủa";
                txtAlOH3.Text = molH.ToString();
                txtAlO2du.Text = (molAlO2 - molH).ToString();
                txtAl3.Text = "0";
                txtHdu.Text = "0";
            }
            else if (T == 1)
            {
                txtNhanXet.Text = "AlO2- và H+ phản ứng vừa đủ, tạo Al(OH)3 kết tủa cực đại";
                txtAlOH3.Text = molH.ToString();
                txtAlO2du.Text = "0";
                txtAl3.Text = "0";
                txtHdu.Text = "0";
            }
            else if (T < 4)
            {
                txtNhanXet.Text = "H+ dư hoà tan 1 phần kết tủa Al(OH)3 thành Al3+ rồi hết";
                double molAlOH3 = (4 * molAlO2 - molH) / 3;
                txtAlOH3.Text = molAlOH3.ToString();
                txtAlO2du.Text = "0";
                txtAl3.Text = (molAlO2 - molAlOH3).ToString();
                txtHdu.Text = "0";
            }
            else if (T == 4)
            {
                txtNhanXet.Text = "H+ dư hoà tan hết Al(OH)3 thành Al3+ rồi hết";
                txtAlOH3.Text = "0";
                txtAlO2du.Text = "0";
                txtAl3.Text = molAlO2.ToString();
                txtHdu.Text = "0";
            }
            else
            {
                txtNhanXet.Text = "H+ dư hoà tan hết Al(OH)3 thành Al3+ và vẫn dư";
                txtAlOH3.Text = "0";
                txtAlO2du.Text = "0";
                txtAl3.Text = molAlO2.ToString();
                txtHdu.Text = (molH - 4 * molAlO2).ToString();
            }
        }
    }
}
