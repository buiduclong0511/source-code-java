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
    public partial class formQuanLyNhanVien : Form
    {
        public formQuanLyNhanVien()
        {
            InitializeComponent();
        }

        private void formQuanLyNhanVien_Load(object sender, EventArgs e)
        {
            cboGioiTinh.Items.Add("Nam");
            cboGioiTinh.Items.Add("Nữ");
            cboPhongBan.Items.Add("Phòng tài vụ");
            cboPhongBan.Items.Add("Phòng hành chính");
            cboPhongBan.Items.Add("Phòng kinh doanh");
            cboPhongBan.Items.Add("Phòng kỹ thuật");
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string thongTin = txtHoTen.Text + " - " + cboGioiTinh.Text + " - " + cboPhongBan.Text;
            lstDanhSach.Items.Add(thongTin);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
