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

        private void btntinh_Click(object sender, EventArgs e)
        {
            //Trường hợp 1 :
            // H+ + CO3(2-) => HCO3-
            // H+ + HCO3-   => CO2 + H20   HCO3- tổng của phản ứng 1 với đề bài cho
            if (rdbTH1.Checked)
            {
                double nH = double.Parse(txtH.Text);
                double nHCO3 = double.Parse(txtHCO3.Text);
                double nCO3 = double.Parse(txtCO3.Text);
                if (nH < nCO3)
                {
                    txtketqua.Text = "H+ hết, CO3(2-) dư, không có khí CO2 thoát ra";
                    txtCO2.Text = "0";
                    txtHdu.Text = "0";
                    txtHCO3final.Text = (nH + nHCO3).ToString();
                    txtCO3final.Text = (nCO3 - nH).ToString();
                }
                if (nH == nCO3)
                {
                    txtketqua.Text = "H+ p/ứ vừa đủ CO3(2-), không có CO2 thoát ra";
                    txtCO2.Text = "0";
                    txtHdu.Text = "0";
                    txtHCO3final.Text = (nH + nHCO3).ToString();
                    txtCO3final.Text = (nCO3 - nH).ToString();
                }
                nH = nH - nCO3;  // trừ đi phần H+ đã pu với CO3(2-)
                nHCO3 = nHCO3 + nCO3; // CO3(2-) chuyển hết thành HCO3-
                if (nH < nHCO3) //CO3(2-) đã chuyển hoá hết thành HCO3-
                {
                    txtketqua.Text = "H+ p/ứ hết CO3(2-) và 1 phần HCO3-, tạo CO2";
                    txtCO2.Text = nH.ToString();  // 99.99% nH+ dư < nHCO3- 
                    txtHdu.Text = "0";
                    txtHCO3final.Text = (nHCO3 - nH).ToString();
                    txtCO3final.Text = "0";
                }
                if (nH == nHCO3)
                {
                    txtketqua.Text = "H+(hết) p/ứ hết CO3(2-) và HCO3-, CO2 cực đại";
                    txtCO2.Text = nHCO3.ToString();
                    txtHdu.Text = "0";
                    txtHCO3final.Text = "0";
                    txtCO3final.Text = "0";
                }
                if (nH > (nHCO3 + nCO3))
                {
                    txtketqua.Text = "H+(dư) p/ứ hết CO3(2-) và HCO3-, CO2 cực đại";
                    txtCO2.Text = nHCO3.ToString();
                    txtHdu.Text = (nH - nHCO3).ToString();
                    txtHCO3final.Text = "0";
                    txtCO3final.Text = "0";
                }
            }
            //Trường hợp 2: Xảy ra đồng thời 2 phản ứng
            // HCO3- + H+ => CO2 + H2O
            // CO3(2-) + 2H+ => CO2 + H2O
            // Gọi số mol HCO3- phản ứng là a, CO3(2-) phản ứng là b ta có
            // a/b = nHCO3- / nCO3(2-)  =>  a = b * nHCO3-/nCO3(2-)
            // a + 2b = nH+; =>  b*nHCO3-/nCO3(2-) + 2b = nH+
            // giải tìm b và a => nCO2 = a + b
            if (rdbTH2.Checked)
            {
                double nH = double.Parse(txtH.Text);
                double nHCO3 = double.Parse(txtHCO3.Text);
                double nCO3 = double.Parse(txtCO3.Text);
                if (nH < (nHCO3 + 2 * nCO3))
                {
                    txtketqua.Text = "H+ p/ứ với cả CO3(2-) và HCO3-, CO2 thoát ra";
                    double nCO3pu = nH / (nHCO3 / nCO3 + 2);
                    double nHCO3pu = nCO3pu * nHCO3 / nCO3;
                    txtCO2.Text = (nHCO3pu + nCO3pu).ToString();
                    txtHdu.Text = "0";
                    txtHCO3final.Text = (nHCO3 - nHCO3pu).ToString();
                    txtCO3final.Text = (nCO3 - nCO3pu).ToString();
                }
                if (nH == (nHCO3 + 2 * nCO3))
                {
                    txtketqua.Text = "H+(hết) p/ứ hết CO3(2-) và HCO3-, CO2 cực đại";
                    txtCO2.Text = (nHCO3 + nCO3).ToString();
                    txtHdu.Text = "0";
                    txtHCO3final.Text = "0";
                    txtCO3final.Text = "0";
                }
                if (nH > (nHCO3 + 2 * nCO3))
                {
                    txtketqua.Text = "H+(dư) p/ứ hết CO3(2-) và HCO3-, CO2 cực đại";
                    txtCO2.Text = (nHCO3 + nCO3).ToString();
                    txtHdu.Text = (nH - (nHCO3 + 2 * nCO3)).ToString();
                    txtHCO3final.Text = "0";
                    txtCO3final.Text = "0";
                }
            }
        }
    }
}
