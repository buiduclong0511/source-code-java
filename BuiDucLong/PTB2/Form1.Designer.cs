
namespace BaiTap
{
    partial class formGiaiPTB2
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
            this.txtHsA = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtHsB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtHsC = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNghiem = new System.Windows.Forms.TextBox();
            this.btnGiaiPT = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "a =";
            // 
            // txtHsA
            // 
            this.txtHsA.Location = new System.Drawing.Point(106, 18);
            this.txtHsA.Name = "txtHsA";
            this.txtHsA.Size = new System.Drawing.Size(376, 22);
            this.txtHsA.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "b =";
            // 
            // txtHsB
            // 
            this.txtHsB.Location = new System.Drawing.Point(106, 49);
            this.txtHsB.Name = "txtHsB";
            this.txtHsB.Size = new System.Drawing.Size(376, 22);
            this.txtHsB.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "c =";
            // 
            // txtHsC
            // 
            this.txtHsC.Location = new System.Drawing.Point(106, 79);
            this.txtHsC.Name = "txtHsC";
            this.txtHsC.Size = new System.Drawing.Size(376, 22);
            this.txtHsC.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Nghiệm:";
            // 
            // txtNghiem
            // 
            this.txtNghiem.Location = new System.Drawing.Point(106, 132);
            this.txtNghiem.Name = "txtNghiem";
            this.txtNghiem.Size = new System.Drawing.Size(376, 22);
            this.txtNghiem.TabIndex = 7;
            // 
            // btnGiaiPT
            // 
            this.btnGiaiPT.Location = new System.Drawing.Point(144, 190);
            this.btnGiaiPT.Name = "btnGiaiPT";
            this.btnGiaiPT.Size = new System.Drawing.Size(136, 23);
            this.btnGiaiPT.TabIndex = 8;
            this.btnGiaiPT.Text = "Giải phương trình";
            this.btnGiaiPT.UseVisualStyleBackColor = true;
            this.btnGiaiPT.Click += new System.EventHandler(this.btnGiaiPT_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(350, 190);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 9;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // formGiaiPTB2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 241);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnGiaiPT);
            this.Controls.Add(this.txtNghiem);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtHsC);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtHsB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtHsA);
            this.Controls.Add(this.label1);
            this.Name = "formGiaiPTB2";
            this.Text = "Giải phương trình bậc 2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtHsA;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtHsB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtHsC;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNghiem;
        private System.Windows.Forms.Button btnGiaiPT;
        private System.Windows.Forms.Button btnThoat;
    }
}

