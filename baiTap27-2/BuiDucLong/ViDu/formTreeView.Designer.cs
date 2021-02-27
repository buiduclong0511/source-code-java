
namespace ViDu
{
    partial class formTreeView
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
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.btnXoaNode = new System.Windows.Forms.Button();
            this.btnXoaTatCa = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(12, 12);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(468, 306);
            this.treeView1.TabIndex = 0;
            // 
            // btnXoaNode
            // 
            this.btnXoaNode.Location = new System.Drawing.Point(158, 338);
            this.btnXoaNode.Name = "btnXoaNode";
            this.btnXoaNode.Size = new System.Drawing.Size(75, 23);
            this.btnXoaNode.TabIndex = 1;
            this.btnXoaNode.Text = "Xóa Node";
            this.btnXoaNode.UseVisualStyleBackColor = true;
            this.btnXoaNode.Click += new System.EventHandler(this.btnXoaNode_Click);
            // 
            // btnXoaTatCa
            // 
            this.btnXoaTatCa.Location = new System.Drawing.Point(277, 338);
            this.btnXoaTatCa.Name = "btnXoaTatCa";
            this.btnXoaTatCa.Size = new System.Drawing.Size(75, 23);
            this.btnXoaTatCa.TabIndex = 2;
            this.btnXoaTatCa.Text = "Xóa tất cả";
            this.btnXoaTatCa.UseVisualStyleBackColor = true;
            this.btnXoaTatCa.Click += new System.EventHandler(this.btnXoaTatCa_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(382, 338);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 3;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // formTreeView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 387);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXoaTatCa);
            this.Controls.Add(this.btnXoaNode);
            this.Controls.Add(this.treeView1);
            this.Name = "formTreeView";
            this.Text = "formTreeView";
            this.Load += new System.EventHandler(this.formTreeView_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Button btnXoaNode;
        private System.Windows.Forms.Button btnXoaTatCa;
        private System.Windows.Forms.Button btnThoat;
    }
}