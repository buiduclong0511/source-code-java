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
    public partial class formBai43Cach2 : Form
    {
        public formBai43Cach2()
        {
            InitializeComponent();
        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            TienDien tienDien = new TienDien();
            tienDien.ChiSoCu = double.Parse(txtChiSoCu.Text);
            tienDien.ChiSoMoi = double.Parse(txtChiSoMoi.Text);
            tienDien.HoTenKhachHang = txtTenKhachHang.Text;

            txtTien.Text = tienDien.tien().ToString();
            double kWTieuThu = tienDien.ChiSoMoi - tienDien.ChiSoCu;

            txtKWTieuThu.Text = kWTieuThu.ToString();
            txtKWTrongDinhMuc.Text = (kWTieuThu <= 50) ? (kWTieuThu).ToString() : 50.ToString();
            txtKWVuotDinhMuc.Text = (kWTieuThu <= 50) ? 0.ToString() : (kWTieuThu - 50).ToString();
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            TienDien tienDien = new TienDien();
            tienDien.ChiSoCu = double.Parse(txtChiSoCu.Text);
            tienDien.ChiSoMoi = double.Parse(txtChiSoMoi.Text);
            tienDien.HoTenKhachHang = txtTenKhachHang.Text;
            double kWTieuThu = tienDien.ChiSoMoi - tienDien.ChiSoCu;

            lstIn.Items.Add(tienDien.HoTenKhachHang);
            lstIn.Items.Add("Số kW tiêu thụ: " + kWTieuThu.ToString());
            lstIn.Items.Add("Tổng tiền: " + tienDien.tien());
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
