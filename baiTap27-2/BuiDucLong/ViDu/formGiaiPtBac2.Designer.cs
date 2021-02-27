
namespace ViDu
{
    partial class formGiaiPtBac2
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
            this.label3 = new System.Windows.Forms.Label();
            this.hsbTxt = new System.Windows.Forms.TextBox();
            this.hsaTxt = new System.Windows.Forms.TextBox();
            this.nghiemTxt = new System.Windows.Forms.TextBox();
            this.thoatBtn = new System.Windows.Forms.Button();
            this.giaiPtBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.hscTxt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "a = ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "b = ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nghiệm = ";
            // 
            // hsbTxt
            // 
            this.hsbTxt.Location = new System.Drawing.Point(173, 116);
            this.hsbTxt.Name = "hsbTxt";
            this.hsbTxt.Size = new System.Drawing.Size(538, 22);
            this.hsbTxt.TabIndex = 3;
            // 
            // hsaTxt
            // 
            this.hsaTxt.Location = new System.Drawing.Point(173, 62);
            this.hsaTxt.Name = "hsaTxt";
            this.hsaTxt.Size = new System.Drawing.Size(538, 22);
            this.hsaTxt.TabIndex = 4;
            // 
            // nghiemTxt
            // 
            this.nghiemTxt.Location = new System.Drawing.Point(173, 206);
            this.nghiemTxt.Name = "nghiemTxt";
            this.nghiemTxt.Size = new System.Drawing.Size(538, 22);
            this.nghiemTxt.TabIndex = 5;
            // 
            // thoatBtn
            // 
            this.thoatBtn.Location = new System.Drawing.Point(616, 272);
            this.thoatBtn.Name = "thoatBtn";
            this.thoatBtn.Size = new System.Drawing.Size(75, 23);
            this.thoatBtn.TabIndex = 6;
            this.thoatBtn.Text = "Thoát";
            this.thoatBtn.UseVisualStyleBackColor = true;
            this.thoatBtn.Click += new System.EventHandler(this.thoatBtn_Click);
            // 
            // giaiPtBtn
            // 
            this.giaiPtBtn.Location = new System.Drawing.Point(414, 272);
            this.giaiPtBtn.Name = "giaiPtBtn";
            this.giaiPtBtn.Size = new System.Drawing.Size(140, 23);
            this.giaiPtBtn.TabIndex = 7;
            this.giaiPtBtn.Text = "Giải phương trình";
            this.giaiPtBtn.UseVisualStyleBackColor = true;
            this.giaiPtBtn.Click += new System.EventHandler(this.giaiPtBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "c = ";
            // 
            // hscTxt
            // 
            this.hscTxt.Location = new System.Drawing.Point(173, 163);
            this.hscTxt.Name = "hscTxt";
            this.hscTxt.Size = new System.Drawing.Size(538, 22);
            this.hscTxt.TabIndex = 9;
            // 
            // formGiaiPtBac2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.hscTxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.giaiPtBtn);
            this.Controls.Add(this.thoatBtn);
            this.Controls.Add(this.nghiemTxt);
            this.Controls.Add(this.hsaTxt);
            this.Controls.Add(this.hsbTxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "formGiaiPtBac2";
            this.Text = "Giải phương trình bậc 2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox hsbTxt;
        private System.Windows.Forms.TextBox hsaTxt;
        private System.Windows.Forms.TextBox nghiemTxt;
        private System.Windows.Forms.Button thoatBtn;
        private System.Windows.Forms.Button giaiPtBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox hscTxt;
    }
}