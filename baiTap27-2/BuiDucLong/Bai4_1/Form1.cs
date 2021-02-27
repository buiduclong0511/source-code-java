using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai4_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCong_Click(object sender, EventArgs e)
        {
            double a;
            double b;
            a = double.Parse(txtA.Text);
            b = double.Parse(txtB.Text);

            txtKetQua.Text = (a + b).ToString();
        }

        private void btnTru_Click(object sender, EventArgs e)
        {
            double a;
            double b;
            a = double.Parse(txtA.Text);
            b = double.Parse(txtB.Text);

            txtKetQua.Text = (a - b).ToString();
        }

        private void btnNhan_Click(object sender, EventArgs e)
        {
            double a;
            double b;
            a = double.Parse(txtA.Text);
            b = double.Parse(txtB.Text);

            txtKetQua.Text = (a * b).ToString();
        }

        private void btnChia_Click(object sender, EventArgs e)
        {
            double a;
            double b;
            a = double.Parse(txtA.Text);
            b = double.Parse(txtB.Text);

            if (b == 0)
            {
                MessageBox.Show("Không chia được cho 0!");
                txtKetQua.Text = "";
            }
            else
            {
                txtKetQua.Text = (a / b).ToString();
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtA.Text = "";
            txtB.Text = "";
            txtKetQua.Text = "";
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
