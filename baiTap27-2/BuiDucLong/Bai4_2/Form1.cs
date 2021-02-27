using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai4_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnNhap_Click(object sender, EventArgs e)
        {
            double diem1 = double.Parse(txtDiem1.Text);
            double diem2 = double.Parse(txtDiem2.Text);
            double diem3 = double.Parse(txtDiem3.Text);
            double diem4 = double.Parse(txtDiem4.Text);
            double diem5 = double.Parse(txtDiem5.Text);

            double tbc = (diem1 + diem2 + diem3 + diem4 + diem5) / 5;
            txtTBC.Text = tbc.ToString();

            string xepLoai = "";
            if (tbc >= 9)
            {
                xepLoai += "Xuất sắc";
            }
            else if (tbc >= 8.5)
            {
                xepLoai += "Giỏi";
            }
            else if (tbc >= 6)
            {
                xepLoai += "Khá";
            }
            else if (tbc >= 4)
            {
                xepLoai += "Trung bình";
            }
            else
            {
                xepLoai += "Kém";
            }

            lstKetQua.Items.Add(txtHoTen.Text);
            lstKetQua.Items.Add("Xếp loại: " + xepLoai);

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtHoTen.Text = "";
            txtDiem1.Text = "";
            txtDiem2.Text = "";
            txtDiem3.Text = "";
            txtDiem4.Text = "";
            txtDiem5.Text = "";
            txtTBC.Text = "";
            lstKetQua.Items.Clear();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
