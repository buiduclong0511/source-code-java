using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ViDu
{
    public partial class formCapNhatThanhVien : Form
    {
        public formCapNhatThanhVien()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string gioiTinh = "Giới tính: ";
            if (rdoNam.Checked)
            {
                gioiTinh += "Nam";
            }
            else if (rdoNu.Checked)
            {
                gioiTinh += "Nữ";
            }

            string honNhan = "Tình trạng hôn nhân: ";
            if (rdoDaKetHon.Checked)
            {
                honNhan += "Đã kết hôn";
            }
            else if (rdoChuaKetHon.Checked)
            {
                honNhan += "Chưa kết hôn";
            }

            string soThich = "Sở thích: ";
            if (chkBongDa.Checked)
            {
                soThich += "bóng đá, ";
            }
            if (chkAmNhac.Checked)
            {
                soThich += "âm nhạc, ";
            }
            if (chkBoiLoi.Checked)
            {
                soThich += "bơi lội, ";
            }
            if (chkLeoNui.Checked)
            {
                soThich += "leo núi,";
            }

            lstDanhSach.Items.Add("Họ tên: " + txtHoTen.Text);
            lstDanhSach.Items.Add(gioiTinh);
            lstDanhSach.Items.Add(honNhan);
            lstDanhSach.Items.Add(soThich);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
