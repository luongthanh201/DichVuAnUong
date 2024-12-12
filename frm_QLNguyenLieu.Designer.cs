namespace QuanLyDichVuAnUong
{
    partial class frm_QLNguyenLieu
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
            this.components = new System.ComponentModel.Container();
            this.grb_NL = new System.Windows.Forms.GroupBox();
            this.pnl_1 = new System.Windows.Forms.Panel();
            this.btn_TimKiem = new System.Windows.Forms.Button();
            this.btn_Xóa = new System.Windows.Forms.Button();
            this.btn_CapNhat = new System.Windows.Forms.Button();
            this.grv_NLieu = new System.Windows.Forms.DataGridView();
            this.txt_TimKiem = new System.Windows.Forms.TextBox();
            this.btn_Them = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.grb_NL.SuspendLayout();
            this.pnl_1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grv_NLieu)).BeginInit();
            this.SuspendLayout();
            // 
            // grb_NL
            // 
            this.grb_NL.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.grb_NL.Controls.Add(this.pnl_1);
            this.grb_NL.Controls.Add(this.btn_Them);
            this.grb_NL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grb_NL.Location = new System.Drawing.Point(28, 28);
            this.grb_NL.Name = "grb_NL";
            this.grb_NL.Size = new System.Drawing.Size(943, 449);
            this.grb_NL.TabIndex = 0;
            this.grb_NL.TabStop = false;
            this.grb_NL.Text = "Danh Sách Nguyên Liệu";
            this.grb_NL.Enter += new System.EventHandler(this.grb_NL_Enter);
            // 
            // pnl_1
            // 
            this.pnl_1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pnl_1.Controls.Add(this.btn_TimKiem);
            this.pnl_1.Controls.Add(this.btn_Xóa);
            this.pnl_1.Controls.Add(this.btn_CapNhat);
            this.pnl_1.Controls.Add(this.grv_NLieu);
            this.pnl_1.Controls.Add(this.txt_TimKiem);
            this.pnl_1.Location = new System.Drawing.Point(23, 60);
            this.pnl_1.Name = "pnl_1";
            this.pnl_1.Size = new System.Drawing.Size(914, 362);
            this.pnl_1.TabIndex = 1;
            // 
            // btn_TimKiem
            // 
            this.btn_TimKiem.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_TimKiem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_TimKiem.Location = new System.Drawing.Point(97, 12);
            this.btn_TimKiem.Name = "btn_TimKiem";
            this.btn_TimKiem.Size = new System.Drawing.Size(135, 44);
            this.btn_TimKiem.TabIndex = 4;
            this.btn_TimKiem.Text = "Tìm Kiếm";
            this.btn_TimKiem.UseVisualStyleBackColor = false;
            this.btn_TimKiem.Click += new System.EventHandler(this.btn_TimKiem_Click);
            // 
            // btn_Xóa
            // 
            this.btn_Xóa.BackColor = System.Drawing.Color.Red;
            this.btn_Xóa.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btn_Xóa.Location = new System.Drawing.Point(694, 307);
            this.btn_Xóa.Name = "btn_Xóa";
            this.btn_Xóa.Size = new System.Drawing.Size(121, 42);
            this.btn_Xóa.TabIndex = 3;
            this.btn_Xóa.Text = "Xóa";
            this.btn_Xóa.UseVisualStyleBackColor = false;
            this.btn_Xóa.Click += new System.EventHandler(this.btn_Xóa_Click);
            // 
            // btn_CapNhat
            // 
            this.btn_CapNhat.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_CapNhat.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btn_CapNhat.Location = new System.Drawing.Point(556, 307);
            this.btn_CapNhat.Name = "btn_CapNhat";
            this.btn_CapNhat.Size = new System.Drawing.Size(121, 42);
            this.btn_CapNhat.TabIndex = 2;
            this.btn_CapNhat.Text = "Cập Nhật";
            this.btn_CapNhat.UseVisualStyleBackColor = false;
            this.btn_CapNhat.Click += new System.EventHandler(this.btn_CapNhat_Click);
            // 
            // grv_NLieu
            // 
            this.grv_NLieu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grv_NLieu.Location = new System.Drawing.Point(20, 92);
            this.grv_NLieu.Name = "grv_NLieu";
            this.grv_NLieu.RowHeadersWidth = 62;
            this.grv_NLieu.RowTemplate.Height = 28;
            this.grv_NLieu.Size = new System.Drawing.Size(870, 179);
            this.grv_NLieu.TabIndex = 1;
            // 
            // txt_TimKiem
            // 
            this.txt_TimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TimKiem.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txt_TimKiem.Location = new System.Drawing.Point(238, 12);
            this.txt_TimKiem.Multiline = true;
            this.txt_TimKiem.Name = "txt_TimKiem";
            this.txt_TimKiem.Size = new System.Drawing.Size(596, 44);
            this.txt_TimKiem.TabIndex = 0;
            // 
            // btn_Them
            // 
            this.btn_Them.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_Them.Location = new System.Drawing.Point(816, 12);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(121, 42);
            this.btn_Them.TabIndex = 0;
            this.btn_Them.Text = "Thêm Mới";
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // frm_QLNguyenLieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1010, 478);
            this.Controls.Add(this.grb_NL);
            this.Name = "frm_QLNguyenLieu";
            this.Text = "frm_QLNguyenLieu";
            this.Load += new System.EventHandler(this.frm_QLNguyenLieu_Load);
            this.grb_NL.ResumeLayout(false);
            this.pnl_1.ResumeLayout(false);
            this.pnl_1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grv_NLieu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grb_NL;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.Panel pnl_1;
        private System.Windows.Forms.TextBox txt_TimKiem;
        private System.Windows.Forms.DataGridView grv_NLieu;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button btn_Xóa;
        private System.Windows.Forms.Button btn_CapNhat;
        private System.Windows.Forms.Button btn_TimKiem;
    }
}