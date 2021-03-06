
namespace BaiTap
{
    partial class formMenu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripItemGiaiPTB2 = new System.Windows.Forms.ToolStripMenuItem();
            this.bai43ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cách1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cách2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bài45ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripItemGiaiPTB2,
            this.bai43ToolStripMenuItem,
            this.bài45ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripItemGiaiPTB2
            // 
            this.toolStripItemGiaiPTB2.Name = "toolStripItemGiaiPTB2";
            this.toolStripItemGiaiPTB2.Size = new System.Drawing.Size(179, 24);
            this.toolStripItemGiaiPTB2.Text = "Giải phương trinh bậc 2";
            this.toolStripItemGiaiPTB2.Click += new System.EventHandler(this.toolStripItemGiaiPTB2_Click);
            // 
            // bai43ToolStripMenuItem
            // 
            this.bai43ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cách1ToolStripMenuItem,
            this.cách2ToolStripMenuItem});
            this.bai43ToolStripMenuItem.Name = "bai43ToolStripMenuItem";
            this.bai43ToolStripMenuItem.Size = new System.Drawing.Size(67, 24);
            this.bai43ToolStripMenuItem.Text = "Bài 4.3";
            // 
            // cách1ToolStripMenuItem
            // 
            this.cách1ToolStripMenuItem.Name = "cách1ToolStripMenuItem";
            this.cách1ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.cách1ToolStripMenuItem.Text = "Cách 1";
            this.cách1ToolStripMenuItem.Click += new System.EventHandler(this.cách1ToolStripMenuItem_Click);
            // 
            // cách2ToolStripMenuItem
            // 
            this.cách2ToolStripMenuItem.Name = "cách2ToolStripMenuItem";
            this.cách2ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.cách2ToolStripMenuItem.Text = "Cách 2";
            this.cách2ToolStripMenuItem.Click += new System.EventHandler(this.cách2ToolStripMenuItem_Click);
            // 
            // bài45ToolStripMenuItem
            // 
            this.bài45ToolStripMenuItem.Name = "bài45ToolStripMenuItem";
            this.bài45ToolStripMenuItem.Size = new System.Drawing.Size(67, 24);
            this.bài45ToolStripMenuItem.Text = "Bài 4.5";
            this.bài45ToolStripMenuItem.Click += new System.EventHandler(this.bài45ToolStripMenuItem_Click);
            // 
            // formMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "formMenu";
            this.Text = "Menu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripItemGiaiPTB2;
        private System.Windows.Forms.ToolStripMenuItem bai43ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cách1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cách2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bài45ToolStripMenuItem;
    }
}