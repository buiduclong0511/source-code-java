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
    public partial class formTreeView : Form
    {
        public formTreeView()
        {
            InitializeComponent();
        }

        private void formTreeView_Load(object sender, EventArgs e)
        {
            TreeNode nodeKhoa = treeView1.Nodes.Add("Khoa đào tạo");
            nodeKhoa.Nodes.Add("Khoa cơ khí");
            nodeKhoa.Nodes.Add("Khoa kế toán");
            TreeNode nodeCntt = nodeKhoa.Nodes.Add("Khoa công nghệ thông tin");
            nodeCntt.Nodes.Add("Tổ công nghệ đa phương tiện");
            nodeCntt.Nodes.Add("Tổ khoa học máy tính");
            nodeCntt.Nodes.Add("Tổ kỹ thuật phần mềm");
            nodeCntt.Nodes.Add("Tổ mạng - kỹ thuật máy tính");
            nodeCntt.Nodes.Add("Tổ kỹ thuật - hành chính");
            nodeKhoa.Nodes.Add("Khoa điện");
            nodeKhoa.Nodes.Add("Khoa điện tử");
        }

        private void btnXoaNode_Click(object sender, EventArgs e)
        {
            TreeNode tn = treeView1.SelectedNode;
            treeView1.Nodes.Remove(tn);
        }

        private void btnXoaTatCa_Click(object sender, EventArgs e)
        {
            treeView1.Nodes.Clear();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
