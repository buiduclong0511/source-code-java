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
    public partial class formListView : Form
    {
        public formListView()
        {
            InitializeComponent();
        }

        int row;

        private void btnThem_Click(object sender, EventArgs e)
        {
            row = listView1.Items.Count;
            listView1.Items.Add(txtHoTen.Text);
            listView1.Items[row].SubItems.Add(txtNgaySinh.Text);
            listView1.Items[row].SubItems.Add(txtQueQuan.Text);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                listView1.Items.RemoveAt(row);
                row--;
            }
            catch
            {
                MessageBox.Show("Không có dữ liệu để xóa!");
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
