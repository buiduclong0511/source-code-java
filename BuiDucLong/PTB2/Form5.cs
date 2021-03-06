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
    public partial class formBai45 : Form
    {
        public formBai45()
        {
            InitializeComponent();
        }

        private void formBai45_Load(object sender, EventArgs e)
        {
            lstDanhSach.Items.Add("Bóng đá");
            lstDanhSach.Items.Add("Bóng bản");
            lstDanhSach.Items.Add("Nhảy dù");
            lstDanhSach.Items.Add("Bập bênh");
            lstDanhSach.Items.Add("Cầu lông");
            lstDanhSach.Items.Add("Bắn bi");
            DateTime dateTime = DateTime.Now;
            txtDate.Text = dateTime.ToString("dd/MM/yyy");
            txtTime.Text = dateTime.ToString("hh:mm:ss tt");
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lstDanhSach.Items.Count; i++)
            {
                lstChon.Items.Add(lstDanhSach.Items[i]);
            }
            lstDanhSach.Items.Clear();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            lstChon.Items.Add(lstDanhSach.SelectedItem);
            lstDanhSach.Items.Remove(lstDanhSach.SelectedItem);
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            lstDanhSach.Items.Add(lstChon.SelectedItem);
            lstChon.Items.Remove(lstChon.SelectedItem);
        }

        private void btnRemoveAll_Click(object sender, EventArgs e)
        {
            lstChon.Items.Clear();
            lstDanhSach.Items.Clear();
            lstDanhSach.Items.Add("Bóng đá");
            lstDanhSach.Items.Add("Bóng bản");
            lstDanhSach.Items.Add("Nhảy dù");
            lstDanhSach.Items.Add("Bập bênh");
            lstDanhSach.Items.Add("Cầu lông");
            lstDanhSach.Items.Add("Bắn bi");
        }

        private void btnNhap_Click(object sender, EventArgs e)
        {
            lstNhap.Items.Clear();
            lstNhap.Items.Add(txtHoTen.Text);
            lstNhap.Items.Add(txtDate.Text + " " + txtTime.Text);
            lstNhap.Items.Add("**Các môn đã chọn: ");
            for (int i = 0; i < lstChon.Items.Count; i++)
            {
                lstNhap.Items.Add(lstChon.Items[i]);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtHoTen.Text = ""; 
            lstChon.Items.Clear();
            lstDanhSach.Items.Clear();
            lstDanhSach.Items.Add("Bóng đá");
            lstDanhSach.Items.Add("Bóng bản");
            lstDanhSach.Items.Add("Nhảy dù");
            lstDanhSach.Items.Add("Bập bênh");
            lstDanhSach.Items.Add("Cầu lông");
            lstDanhSach.Items.Add("Bắn bi");
            lstNhap.Items.Clear();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
