using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Dang2 : Form
    {
        public Dang2()
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
            
            double molCO2 = double.Parse(txtco2.Text) / (double)22.4;

            double vBazo = double.Parse(txtbazo.Text);
            double molNaOH = double.Parse(txtnaoh.Text) * vBazo;
            double molKOH = double.Parse(txtkoh.Text) * vBazo;
            double molBaOH2 = double.Parse(txtbaoh2.Text) * vBazo;
            double molCaOH2 = double.Parse(txtcaoh2.Text) * vBazo;
            double molOH = molNaOH + molKOH + molCaOH2 * 2 + molBaOH2 * 2;

            txtketquaNa.Text = molNaOH.ToString();
            txtketquaBa.Text = molBaOH2.ToString();
            txtketquaK.Text = molKOH.ToString();
            txtketquaCa.Text = molCaOH2.ToString();

            double T = molOH / molCO2;
            //OH- + CO2 => HCO3- , OH- hết
            if (T <= 1)
            {
                txtketqua.Text = "Phản ứng chỉ tạo HCO3-, không kết tủa";
                txtketquaOHdu.Text = "0";
                txtketquaCO2du.Text = (molCO2 - molOH).ToString();
                txtketquaHCO3.Text = molOH.ToString();
                txtketquaCO3.Text = "0";
            }
            //OH- + CO2 => HCO3-
            //2OH- + CO2 => CO3(2-) + H2O
            else if (T < 2)
            {
                txtketqua.Text = "Phản ứng tạo hỗn hợp HCO3- và CO3(2-)";
                txtketquaOHdu.Text = "0";
                txtketquaCO2du.Text = "0";
                double molCO3 = molOH - molCO2;  //nCO3(2-) = (nOH-) - (nCO2) 
                txtketquaCO3.Text = molCO3.ToString();
                txtketquaHCO3.Text = (molCO2 - molCO3).ToString();
            }
            // 2OH- + CO2 => CO3(2-) + H2O
            else
            {
                txtketqua.Text = "Phản ứng chỉ tạo CO3(2-)";
                txtketquaOHdu.Text = (molOH - molCO2 * 2).ToString();
                txtketquaCO2du.Text = "0";
                txtketquaHCO3.Text = "0";
                txtketquaCO3.Text = molCO2.ToString();
            }
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtco2.Text = "0";
            txtbazo.Text = "0";
            txtnaoh.Text = "0";
            txtkoh.Text = "0";
            txtbaoh2.Text = "0";
            txtcaoh2.Text = "0";
            txtketqua.Text = "0";
            txtketquaBa.Text = "0";
            txtketquaCa.Text = "0";
            txtketquaK.Text = "0";
            txtketquaNa.Text = "0";
            txtketquaHCO3.Text = "0";
            txtketquaCO3.Text = "0";
            txtketquaOHdu.Text = "0";
            txtketquaCO2du.Text = "0";
        }
    }
}
