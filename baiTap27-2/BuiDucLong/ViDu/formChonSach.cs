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
    public partial class formChonSach : Form
    {
        public formChonSach()
        {
            InitializeComponent();
        }

        private void formChonSach_Load(object sender, EventArgs e)
        {
            lstDanhSach.Items.Add("Nhập môn tin học 1");
            lstDanhSach.Items.Add("Nhập môn tin học 2");
            lstDanhSach.Items.Add("Nhập môn tin học 3");
            lstDanhSach.Items.Add("Nhập môn tin học 4");
            lstDanhSach.Items.Add("Nhập môn tin học 5");
            lstDanhSach.Items.Add("Nhập môn tin học 6");
            lstDanhSach.Items.Add("Nhập môn tin học 7");
            lstDanhSach.Items.Add("Nhập môn tin học 8");
            lstDanhSach.Items.Add("Nhập môn tin học 9");
            lstDanhSach.Items.Add("Nhập môn tin học 10");
        }

        private void btnThemDonLe_Click(object sender, EventArgs e)
        {
            lstSachChon.Items.Add(lstDanhSach.SelectedItem);
        }

        private void btnThemToanBo_Click(object sender, EventArgs e)
        {
            foreach (string item in lstDanhSach.Items)
            {
                lstSachChon.Items.Add(item);
            }
        }

        private void btnXoaDonLe_Click(object sender, EventArgs e)
        {
            lstSachChon.Items.Remove(lstSachChon.SelectedItem);
        }

        private void btnXoaToanBo_Click(object sender, EventArgs e)
        {
            lstSachChon.Items.Clear();
        }
    }
}
