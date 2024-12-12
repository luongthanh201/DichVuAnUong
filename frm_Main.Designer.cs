namespace quanlydichvuanuong
{
    partial class frm_Main
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
            this.quanLyMonĂnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quanLyNhâpKhoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quanLyNahHangToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quanLyNhânSưToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.banToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.khuVưcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nhaCungCâpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nhàCcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.khuVựcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quanLyMonĂnToolStripMenuItem,
            this.quanLyNhâpKhoToolStripMenuItem,
            this.quanLyNahHangToolStripMenuItem,
            this.quanLyNhânSưToolStripMenuItem,
            this.banToolStripMenuItem,
            this.khuVưcToolStripMenuItem,
            this.nhaCungCâpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(807, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // quanLyMonĂnToolStripMenuItem
            // 
            this.quanLyMonĂnToolStripMenuItem.Name = "quanLyMonĂnToolStripMenuItem";
            this.quanLyMonĂnToolStripMenuItem.Size = new System.Drawing.Size(127, 24);
            this.quanLyMonĂnToolStripMenuItem.Text = "Quản lý món ăn";
            // 
            // quanLyNhâpKhoToolStripMenuItem
            // 
            this.quanLyNhâpKhoToolStripMenuItem.Name = "quanLyNhâpKhoToolStripMenuItem";
            this.quanLyNhâpKhoToolStripMenuItem.Size = new System.Drawing.Size(138, 24);
            this.quanLyNhâpKhoToolStripMenuItem.Text = "Quản lý nhập kho";
            // 
            // quanLyNahHangToolStripMenuItem
            // 
            this.quanLyNahHangToolStripMenuItem.Name = "quanLyNahHangToolStripMenuItem";
            this.quanLyNahHangToolStripMenuItem.Size = new System.Drawing.Size(138, 24);
            this.quanLyNahHangToolStripMenuItem.Text = "Quản lý nhà hàng";
            // 
            // quanLyNhânSưToolStripMenuItem
            // 
            this.quanLyNhânSưToolStripMenuItem.Name = "quanLyNhânSưToolStripMenuItem";
            this.quanLyNhânSưToolStripMenuItem.Size = new System.Drawing.Size(128, 24);
            this.quanLyNhânSưToolStripMenuItem.Text = "Quản lý nhân sự";
            // 
            // banToolStripMenuItem
            // 
            this.banToolStripMenuItem.Name = "banToolStripMenuItem";
            this.banToolStripMenuItem.Size = new System.Drawing.Size(48, 24);
            this.banToolStripMenuItem.Text = "Bàn";
            // 
            // khuVưcToolStripMenuItem
            // 
            this.khuVưcToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.khuVựcToolStripMenuItem});
            this.khuVưcToolStripMenuItem.Name = "khuVưcToolStripMenuItem";
            this.khuVưcToolStripMenuItem.Size = new System.Drawing.Size(75, 24);
            this.khuVưcToolStripMenuItem.Text = "Khu vực";
            // 
            // nhaCungCâpToolStripMenuItem
            // 
            this.nhaCungCâpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nhàCcToolStripMenuItem});
            this.nhaCungCâpToolStripMenuItem.Name = "nhaCungCâpToolStripMenuItem";
            this.nhaCungCâpToolStripMenuItem.Size = new System.Drawing.Size(114, 24);
            this.nhaCungCâpToolStripMenuItem.Text = "Nhà cung cấp";
            // 
            // nhàCcToolStripMenuItem
            // 
            this.nhàCcToolStripMenuItem.Name = "nhàCcToolStripMenuItem";
            this.nhàCcToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.nhàCcToolStripMenuItem.Text = "Nhà cc";
            this.nhàCcToolStripMenuItem.Click += new System.EventHandler(this.nhàCcToolStripMenuItem_Click);
            // 
            // khuVựcToolStripMenuItem
            // 
            this.khuVựcToolStripMenuItem.Name = "khuVựcToolStripMenuItem";
            this.khuVựcToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.khuVựcToolStripMenuItem.Text = "Khu Vực";
            this.khuVựcToolStripMenuItem.Click += new System.EventHandler(this.khuVựcToolStripMenuItem_Click);
            // 
            // frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frm_Main";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frm_Main_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem quanLyMonĂnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quanLyNhâpKhoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quanLyNahHangToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quanLyNhânSưToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem banToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem khuVưcToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nhaCungCâpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem khuVựcToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nhàCcToolStripMenuItem;
    }
}

