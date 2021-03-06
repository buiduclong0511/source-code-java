using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTap
{
    public partial class formBai43Cach1 : Form
    {
        public formBai43Cach1()
        {
            InitializeComponent();
        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            double chiSoCu = double.Parse(txtChiSoCu.Text);
            double chiSoMoi = double.Parse(txtChiSoMoi.Text);
            double kWTieuThu = chiSoMoi - chiSoCu;

            txtKWTieuThu.Text = kWTieuThu.ToString();
            txtKWTrongDinhMuc.Text = (kWTieuThu <= 50) ? kWTieuThu.ToString() : 50.ToString();
            txtKWVuotDinhMuc.Text = (kWTieuThu <= 50) ? 0.ToString() : (kWTieuThu - 50).ToString();

            double tien = (kWTieuThu <= 50) ? (kWTieuThu * 500) : (50 * 500 + (kWTieuThu - 50) * 1000);
            txtTien.Text = tien.ToString();
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            lstIn.Items.Add(txtTenKhachHang.Text);
            lstIn.Items.Add("Số kW tiêu thụ: " + txtKWTieuThu.Text);
            lstIn.Items.Add("Tổng tiền: " + txtTien.Text);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
