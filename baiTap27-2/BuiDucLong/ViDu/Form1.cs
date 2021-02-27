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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Xin chào";
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Xảy ra sự kiện Click");
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            string width = "Chiều rộng của form: " + this.Width.ToString();
            string height = "Chiều cao của form: " + this.Height.ToString();
            MessageBox.Show(width + height);
        }
    }
}
