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
    public partial class formGiaiPTB2 : Form
    {
        public formGiaiPTB2()
        {
            InitializeComponent();
        }

        private void btnGiaiPT_Click(object sender, EventArgs e)
        {
            XuLy ptb2 = new XuLy(double.Parse(txtHsA.Text), double.Parse(txtHsB.Text), double.Parse(txtHsC.Text));
            txtNghiem.Text = ptb2.nghiem();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
