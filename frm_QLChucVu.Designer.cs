namespace QuanLyDichVuAnUong
{
    partial class frm_QLChucVu
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
            this.grb_Them = new System.Windows.Forms.GroupBox();
            this.lbl_IdCV = new System.Windows.Forms.Label();
            this.txt_IdCV = new System.Windows.Forms.TextBox();
            this.txt_TinhTrang = new System.Windows.Forms.TextBox();
            this.txt_TenCV = new System.Windows.Forms.TextBox();
            this.btn_Them = new System.Windows.Forms.Button();
            this.lbl_TinhTrang = new System.Windows.Forms.Label();
            this.lbl_TenCV = new System.Windows.Forms.Label();
            this.lbl_ThemMoi = new System.Windows.Forms.Label();
            this.grb_DS = new System.Windows.Forms.GroupBox();
            this.btn_Xóa = new System.Windows.Forms.Button();
            this.btn_CapNhat = new System.Windows.Forms.Button();
            this.txt_TimKiemCV = new System.Windows.Forms.TextBox();
            this.btn_TimKiem = new System.Windows.Forms.Button();
            this.grv_ChucVu = new System.Windows.Forms.DataGridView();
            this.lbl_DSachCV = new System.Windows.Forms.Label();
            this.grb_Them.SuspendLayout();
            this.grb_DS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grv_ChucVu)).BeginInit();
            this.SuspendLayout();
            // 
            // grb_Them
            // 
            this.grb_Them.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.grb_Them.Controls.Add(this.lbl_IdCV);
            this.grb_Them.Controls.Add(this.txt_IdCV);
            this.grb_Them.Controls.Add(this.txt_TinhTrang);
            this.grb_Them.Controls.Add(this.txt_TenCV);
            this.grb_Them.Controls.Add(this.btn_Them);
            this.grb_Them.Controls.Add(this.lbl_TinhTrang);
            this.grb_Them.Controls.Add(this.lbl_TenCV);
            this.grb_Them.Controls.Add(this.lbl_ThemMoi);
            this.grb_Them.Location = new System.Drawing.Point(12, 39);
            this.grb_Them.Name = "grb_Them";
            this.grb_Them.Size = new System.Drawing.Size(410, 448);
            this.grb_Them.TabIndex = 2;
            this.grb_Them.TabStop = false;
            // 
            // lbl_IdCV
            // 
            this.lbl_IdCV.AutoSize = true;
            this.lbl_IdCV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_IdCV.Location = new System.Drawing.Point(37, 84);
            this.lbl_IdCV.Name = "lbl_IdCV";
            this.lbl_IdCV.Size = new System.Drawing.Size(111, 22);
            this.lbl_IdCV.TabIndex = 15;
            this.lbl_IdCV.Text = "ID Chức Vụ";
            // 
            // txt_IdCV
            // 
            this.txt_IdCV.Location = new System.Drawing.Point(154, 83);
            this.txt_IdCV.Multiline = true;
            this.txt_IdCV.Name = "txt_IdCV";
            this.txt_IdCV.Size = new System.Drawing.Size(137, 40);
            this.txt_IdCV.TabIndex = 14;
            // 
            // txt_TinhTrang
            // 
            this.txt_TinhTrang.Location = new System.Drawing.Point(41, 277);
            this.txt_TinhTrang.Multiline = true;
            this.txt_TinhTrang.Name = "txt_TinhTrang";
            this.txt_TinhTrang.Size = new System.Drawing.Size(250, 40);
            this.txt_TinhTrang.TabIndex = 13;
            // 
            // txt_TenCV
            // 
            this.txt_TenCV.Location = new System.Drawing.Point(41, 176);
            this.txt_TenCV.Multiline = true;
            this.txt_TenCV.Name = "txt_TenCV";
            this.txt_TenCV.Size = new System.Drawing.Size(250, 40);
            this.txt_TenCV.TabIndex = 12;
            // 
            // btn_Them
            // 
            this.btn_Them.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_Them.Location = new System.Drawing.Point(270, 390);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(121, 42);
            this.btn_Them.TabIndex = 11;
            this.btn_Them.Text = "Thêm Mới";
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // lbl_TinhTrang
            // 
            this.lbl_TinhTrang.AutoSize = true;
            this.lbl_TinhTrang.Cursor = System.Windows.Forms.Cursors.No;
            this.lbl_TinhTrang.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TinhTrang.Location = new System.Drawing.Point(39, 235);
            this.lbl_TinhTrang.Name = "lbl_TinhTrang";
            this.lbl_TinhTrang.Size = new System.Drawing.Size(109, 22);
            this.lbl_TinhTrang.TabIndex = 10;
            this.lbl_TinhTrang.Text = "Tình Trạng";
            // 
            // lbl_TenCV
            // 
            this.lbl_TenCV.AutoSize = true;
            this.lbl_TenCV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TenCV.Location = new System.Drawing.Point(37, 137);
            this.lbl_TenCV.Name = "lbl_TenCV";
            this.lbl_TenCV.Size = new System.Drawing.Size(127, 22);
            this.lbl_TenCV.TabIndex = 9;
            this.lbl_TenCV.Text = "Tên Chức Vụ";
            // 
            // lbl_ThemMoi
            // 
            this.lbl_ThemMoi.AutoSize = true;
            this.lbl_ThemMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ThemMoi.Location = new System.Drawing.Point(58, 7);
            this.lbl_ThemMoi.Name = "lbl_ThemMoi";
            this.lbl_ThemMoi.Size = new System.Drawing.Size(233, 29);
            this.lbl_ThemMoi.TabIndex = 8;
            this.lbl_ThemMoi.Text = "Thêm Mới Chức Vụ";
            // 
            // grb_DS
            // 
            this.grb_DS.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.grb_DS.Controls.Add(this.btn_Xóa);
            this.grb_DS.Controls.Add(this.btn_CapNhat);
            this.grb_DS.Controls.Add(this.txt_TimKiemCV);
            this.grb_DS.Controls.Add(this.btn_TimKiem);
            this.grb_DS.Controls.Add(this.grv_ChucVu);
            this.grb_DS.Controls.Add(this.lbl_DSachCV);
            this.grb_DS.Location = new System.Drawing.Point(507, 39);
            this.grb_DS.Name = "grb_DS";
            this.grb_DS.Size = new System.Drawing.Size(579, 448);
            this.grb_DS.TabIndex = 3;
            this.grb_DS.TabStop = false;
            // 
            // btn_Xóa
            // 
            this.btn_Xóa.BackColor = System.Drawing.Color.Red;
            this.btn_Xóa.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btn_Xóa.Location = new System.Drawing.Point(437, 390);
            this.btn_Xóa.Name = "btn_Xóa";
            this.btn_Xóa.Size = new System.Drawing.Size(121, 42);
            this.btn_Xóa.TabIndex = 10;
            this.btn_Xóa.Text = "Xóa";
            this.btn_Xóa.UseVisualStyleBackColor = false;
            this.btn_Xóa.Click += new System.EventHandler(this.btn_Xóa_Click);
            // 
            // btn_CapNhat
            // 
            this.btn_CapNhat.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_CapNhat.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btn_CapNhat.Location = new System.Drawing.Point(290, 390);
            this.btn_CapNhat.Name = "btn_CapNhat";
            this.btn_CapNhat.Size = new System.Drawing.Size(121, 42);
            this.btn_CapNhat.TabIndex = 15;
            this.btn_CapNhat.Text = "Cập Nhật";
            this.btn_CapNhat.UseVisualStyleBackColor = false;
            this.btn_CapNhat.Click += new System.EventHandler(this.btn_CapNhat_Click);
            // 
            // txt_TimKiemCV
            // 
            this.txt_TimKiemCV.Location = new System.Drawing.Point(162, 80);
            this.txt_TimKiemCV.Multiline = true;
            this.txt_TimKiemCV.Name = "txt_TimKiemCV";
            this.txt_TimKiemCV.Size = new System.Drawing.Size(396, 40);
            this.txt_TimKiemCV.TabIndex = 11;
            // 
            // btn_TimKiem
            // 
            this.btn_TimKiem.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_TimKiem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_TimKiem.Location = new System.Drawing.Point(21, 80);
            this.btn_TimKiem.Name = "btn_TimKiem";
            this.btn_TimKiem.Size = new System.Drawing.Size(135, 44);
            this.btn_TimKiem.TabIndex = 14;
            this.btn_TimKiem.Text = "Tìm Kiếm";
            this.btn_TimKiem.UseVisualStyleBackColor = false;
            this.btn_TimKiem.Click += new System.EventHandler(this.btn_TimKiem_Click);
            // 
            // grv_ChucVu
            // 
            this.grv_ChucVu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grv_ChucVu.Location = new System.Drawing.Point(9, 159);
            this.grv_ChucVu.Name = "grv_ChucVu";
            this.grv_ChucVu.RowHeadersWidth = 62;
            this.grv_ChucVu.RowTemplate.Height = 28;
            this.grv_ChucVu.Size = new System.Drawing.Size(549, 144);
            this.grv_ChucVu.TabIndex = 13;
            this.grv_ChucVu.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grv_ChucVu_CellContentClick);
            // 
            // lbl_DSachCV
            // 
            this.lbl_DSachCV.AutoSize = true;
            this.lbl_DSachCV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DSachCV.Location = new System.Drawing.Point(4, 4);
            this.lbl_DSachCV.Name = "lbl_DSachCV";
            this.lbl_DSachCV.Size = new System.Drawing.Size(241, 29);
            this.lbl_DSachCV.TabIndex = 12;
            this.lbl_DSachCV.Text = "Danh Sách Chức Vụ";
            // 
            // frm_QLChucVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1136, 540);
            this.Controls.Add(this.grb_DS);
            this.Controls.Add(this.grb_Them);
            this.Name = "frm_QLChucVu";
            this.Text = "frm_QLChucVu";
            this.Load += new System.EventHandler(this.frm_QLChucVu_Load);
            this.grb_Them.ResumeLayout(false);
            this.grb_Them.PerformLayout();
            this.grb_DS.ResumeLayout(false);
            this.grb_DS.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grv_ChucVu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grb_Them;
        private System.Windows.Forms.Label lbl_IdCV;
        private System.Windows.Forms.TextBox txt_IdCV;
        private System.Windows.Forms.TextBox txt_TinhTrang;
        private System.Windows.Forms.TextBox txt_TenCV;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.Label lbl_TinhTrang;
        private System.Windows.Forms.Label lbl_TenCV;
        private System.Windows.Forms.Label lbl_ThemMoi;
        private System.Windows.Forms.GroupBox grb_DS;
        private System.Windows.Forms.Button btn_Xóa;
        private System.Windows.Forms.Button btn_CapNhat;
        private System.Windows.Forms.TextBox txt_TimKiemCV;
        private System.Windows.Forms.Button btn_TimKiem;
        private System.Windows.Forms.DataGridView grv_ChucVu;
        private System.Windows.Forms.Label lbl_DSachCV;
    }
}