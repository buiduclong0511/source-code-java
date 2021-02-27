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
    public partial class formGiaiPtBac2 : Form
    {
        public formGiaiPtBac2()
        {
            InitializeComponent();
        }


        private void giaiPtBtn_Click(object sender, EventArgs e)
        {
            double a = double.Parse(hsaTxt.Text);
            double b = double.Parse(hsbTxt.Text);
            double c = double.Parse(hscTxt.Text);
            double delta = b * b - 4 * a * c;
            string nghiem = "";
            if (a != 0)
            {
                if (delta < 0)
                {
                    nghiem = "Phương trình vô nghiệm";
                }
                else if (delta > 0)
                {
                    double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                    double x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                    nghiem = "x1 = " + x1.ToString() + ", x2 = " + x2.ToString();
                }
                else
                {
                    nghiem = "x1 = x2 = " + (-b / (2 * a)).ToString();
                }
            }
            else
            {
                if (b != 0)
                {
                    nghiem = "x = " + (-c / b).ToString();
                } 
                else if (c == 0)
                {
                    nghiem = "Phương trình có vô số nghiệm";
                }
                else
                {
                    nghiem = "Phương trình vô nghiệm";
                }
            }
            nghiemTxt.Text = nghiem;
        }

        private void thoatBtn_Click(object sender, EventArgs e)
        {
            DialogResult dlr = MessageBox.Show("Bạn có thực sự muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo);
            if (dlr == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
