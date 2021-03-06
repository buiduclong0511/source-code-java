using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap
{
    class TienDien
    {
        private String hoTenKhachHang;
        private double chiSoCu;
        private double chiSoMoi;

        public string HoTenKhachHang { get => hoTenKhachHang; set => hoTenKhachHang = value; }
        public double ChiSoCu { get => chiSoCu; set => chiSoCu = value; }
        public double ChiSoMoi { get => chiSoMoi; set => chiSoMoi = value; }

        public double tien()
        {
            double kWTieuThu = chiSoMoi - ChiSoCu;
            return (kWTieuThu <= 50) ? kWTieuThu * 500 : 50 * 500 + (kWTieuThu - 50) * 1000;
        }
    }
}
