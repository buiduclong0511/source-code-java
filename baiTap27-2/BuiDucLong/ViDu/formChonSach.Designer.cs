
namespace ViDu
{
    partial class formChonSach
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lstDanhSach = new System.Windows.Forms.ListBox();
            this.lstSachChon = new System.Windows.Forms.ListBox();
            this.btnThemDonLe = new System.Windows.Forms.Button();
            this.btnThemToanBo = new System.Windows.Forms.Button();
            this.btnXoaDonLe = new System.Windows.Forms.Button();
            this.btnXoaToanBo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Danh sách";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(469, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Danh sách đã chọn";
            // 
            // lstDanhSach
            // 
            this.lstDanhSach.FormattingEnabled = true;
            this.lstDanhSach.ItemHeight = 16;
            this.lstDanhSach.Location = new System.Drawing.Point(39, 54);
            this.lstDanhSach.Name = "lstDanhSach";
            this.lstDanhSach.Size = new System.Drawing.Size(273, 308);
            this.lstDanhSach.TabIndex = 2;
            // 
            // lstSachChon
            // 
            this.lstSachChon.FormattingEnabled = true;
            this.lstSachChon.ItemHeight = 16;
            this.lstSachChon.Location = new System.Drawing.Point(472, 54);
            this.lstSachChon.Name = "lstSachChon";
            this.lstSachChon.Size = new System.Drawing.Size(273, 308);
            this.lstSachChon.TabIndex = 3;
            // 
            // btnThemDonLe
            // 
            this.btnThemDonLe.Location = new System.Drawing.Point(351, 108);
            this.btnThemDonLe.Name = "btnThemDonLe";
            this.btnThemDonLe.Size = new System.Drawing.Size(75, 23);
            this.btnThemDonLe.TabIndex = 4;
            this.btnThemDonLe.Text = ">";
            this.btnThemDonLe.UseVisualStyleBackColor = true;
            this.btnThemDonLe.Click += new System.EventHandler(this.btnThemDonLe_Click);
            // 
            // btnThemToanBo
            // 
            this.btnThemToanBo.Location = new System.Drawing.Point(351, 153);
            this.btnThemToanBo.Name = "btnThemToanBo";
            this.btnThemToanBo.Size = new System.Drawing.Size(75, 23);
            this.btnThemToanBo.TabIndex = 5;
            this.btnThemToanBo.Text = ">>";
            this.btnThemToanBo.UseVisualStyleBackColor = true;
            this.btnThemToanBo.Click += new System.EventHandler(this.btnThemToanBo_Click);
            // 
            // btnXoaDonLe
            // 
            this.btnXoaDonLe.Location = new System.Drawing.Point(351, 198);
            this.btnXoaDonLe.Name = "btnXoaDonLe";
            this.btnXoaDonLe.Size = new System.Drawing.Size(75, 23);
            this.btnXoaDonLe.TabIndex = 6;
            this.btnXoaDonLe.Text = "<";
            this.btnXoaDonLe.UseVisualStyleBackColor = true;
            this.btnXoaDonLe.Click += new System.EventHandler(this.btnXoaDonLe_Click);
            // 
            // btnXoaToanBo
            // 
            this.btnXoaToanBo.Location = new System.Drawing.Point(351, 249);
            this.btnXoaToanBo.Name = "btnXoaToanBo";
            this.btnXoaToanBo.Size = new System.Drawing.Size(75, 23);
            this.btnXoaToanBo.TabIndex = 7;
            this.btnXoaToanBo.Text = "<<";
            this.btnXoaToanBo.UseVisualStyleBackColor = true;
            this.btnXoaToanBo.Click += new System.EventHandler(this.btnXoaToanBo_Click);
            // 
            // formChonSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnXoaToanBo);
            this.Controls.Add(this.btnXoaDonLe);
            this.Controls.Add(this.btnThemToanBo);
            this.Controls.Add(this.btnThemDonLe);
            this.Controls.Add(this.lstSachChon);
            this.Controls.Add(this.lstDanhSach);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "formChonSach";
            this.Text = "formChonSach";
            this.Load += new System.EventHandler(this.formChonSach_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lstDanhSach;
        private System.Windows.Forms.ListBox lstSachChon;
        private System.Windows.Forms.Button btnThemDonLe;
        private System.Windows.Forms.Button btnThemToanBo;
        private System.Windows.Forms.Button btnXoaDonLe;
        private System.Windows.Forms.Button btnXoaToanBo;
    }
}