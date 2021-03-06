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
    public partial class formMenu : Form
    {
        public formMenu()
        {
            InitializeComponent();
        }

        private void toolStripItemGiaiPTB2_Click(object sender, EventArgs e)
        {
            var frm = new formGiaiPTB2();
            frm.MdiParent = this;
            frm.Show();
        }

        private void cách1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new formBai43Cach1();
            frm.MdiParent = this;
            frm.Show();
        }

        private void cách2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new formBai43Cach2();
            frm.MdiParent = this;
            frm.Show();
        }

        private void bài45ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new formBai45();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}
