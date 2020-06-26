using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Dang4 : Form
    {
        public Dang4()
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
            double molAl3 = double.Parse(txtAl.Text);
            double molOH = double.Parse(txtOH.Text);
            double T = molOH / molAl3;
            if (T < 3)
            {
                txtNhanXet.Text = "Al3+ dư, OH- hết , tạo Al(OH)3 kết tủa";
                txtAlOH3.Text = (molOH / 3).ToString();
                txtAldu.Text = (molAl3 - molOH / 3).ToString();
                txtAlO2.Text = "0";
                txtOHdu.Text = "0";
            }
            else if (T == 3)
            {
                txtNhanXet.Text = "Al3+ và OH- phản ứng vừa đủ, tạo Al(OH)3 kết tủa cực đại";
                txtAlOH3.Text = (molOH / 3).ToString();
                txtAldu.Text = "0";
                txtAlO2.Text = "0";
                txtOHdu.Text = "0";
            }
            else if (T < 4)
            {
                txtNhanXet.Text = "OH- dư hoà tan 1 phần Al(OH)3 tạo AlO2- rồi mới hết";
                double molAlOH3 = 4 * molAl3 - molOH;
                txtAlOH3.Text = molAlOH3.ToString();
                txtAldu.Text = "0";
                txtAlO2.Text = (molAl3 - molAlOH3).ToString();
                txtOHdu.Text = "0";
            }
            else if (T == 4)
            {
                txtNhanXet.Text = "OH- dư hoà tan hết Al(OH)3 thành AlO2- rồi hết";
                txtAlOH3.Text = "0";
                txtAldu.Text = "0";
                txtAlO2.Text = molAl3.ToString();
                txtOHdu.Text = "0";
            }
            else
            {
                txtNhanXet.Text = "OH- dư hoà tan hết Al(OH)3 thành AlO2- và vẫn dư";              
                txtAlOH3.Text = "0";
                txtAldu.Text = "0";
                txtAlO2.Text = molAl3.ToString();
                txtOHdu.Text = (molOH - 4*molAl3).ToString();
            }
        }
    }
}
