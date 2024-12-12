namespace QuanLyDichVuAnUong
{
    partial class frm_NhanVien
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
            this.grb_DS = new System.Windows.Forms.GroupBox();
            this.btn_Xóa = new System.Windows.Forms.Button();
            this.btn_CapNhat = new System.Windows.Forms.Button();
            this.txt_TimKiemNV = new System.Windows.Forms.TextBox();
            this.btn_TimKiem = new System.Windows.Forms.Button();
            this.grv_NhanVien = new System.Windows.Forms.DataGridView();
            this.lbl_DSachCV = new System.Windows.Forms.Label();
            this.grb_Them = new System.Windows.Forms.GroupBox();
            this.lbl_IdNVien = new System.Windows.Forms.Label();
            this.txt_IdNV = new System.Windows.Forms.TextBox();
            this.txt_TinhTrang = new System.Windows.Forms.TextBox();
            this.txt_TenNV = new System.Windows.Forms.TextBox();
            this.btn_Them = new System.Windows.Forms.Button();
            this.lbl_TinhTrang = new System.Windows.Forms.Label();
            this.lbl_TenNV = new System.Windows.Forms.Label();
            this.lbl_ThemMoi = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Email = new System.Windows.Forms.TextBox();
            this.txt_MK = new System.Windows.Forms.TextBox();
            this.txt_SDT = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_DChi = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_CV = new System.Windows.Forms.TextBox();
            this.grb_DS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grv_NhanVien)).BeginInit();
            this.grb_Them.SuspendLayout();
            this.SuspendLayout();
            // 
            // grb_DS
            // 
            this.grb_DS.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.grb_DS.Controls.Add(this.btn_Xóa);
            this.grb_DS.Controls.Add(this.btn_CapNhat);
            this.grb_DS.Controls.Add(this.txt_TimKiemNV);
            this.grb_DS.Controls.Add(this.btn_TimKiem);
            this.grb_DS.Controls.Add(this.grv_NhanVien);
            this.grb_DS.Controls.Add(this.lbl_DSachCV);
            this.grb_DS.Location = new System.Drawing.Point(455, 12);
            this.grb_DS.Name = "grb_DS";
            this.grb_DS.Size = new System.Drawing.Size(668, 513);
            this.grb_DS.TabIndex = 5;
            this.grb_DS.TabStop = false;
            // 
            // btn_Xóa
            // 
            this.btn_Xóa.BackColor = System.Drawing.Color.Red;
            this.btn_Xóa.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btn_Xóa.Location = new System.Drawing.Point(510, 430);
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
            this.btn_CapNhat.Location = new System.Drawing.Point(346, 430);
            this.btn_CapNhat.Name = "btn_CapNhat";
            this.btn_CapNhat.Size = new System.Drawing.Size(121, 42);
            this.btn_CapNhat.TabIndex = 15;
            this.btn_CapNhat.Text = "Cập Nhật";
            this.btn_CapNhat.UseVisualStyleBackColor = false;
            this.btn_CapNhat.Click += new System.EventHandler(this.btn_CapNhat_Click);
            // 
            // txt_TimKiemNV
            // 
            this.txt_TimKiemNV.Location = new System.Drawing.Point(162, 80);
            this.txt_TimKiemNV.Multiline = true;
            this.txt_TimKiemNV.Name = "txt_TimKiemNV";
            this.txt_TimKiemNV.Size = new System.Drawing.Size(485, 40);
            this.txt_TimKiemNV.TabIndex = 11;
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
            // grv_NhanVien
            // 
            this.grv_NhanVien.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.grv_NhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grv_NhanVien.Location = new System.Drawing.Point(9, 159);
            this.grv_NhanVien.Name = "grv_NhanVien";
            this.grv_NhanVien.RowHeadersWidth = 62;
            this.grv_NhanVien.RowTemplate.Height = 28;
            this.grv_NhanVien.Size = new System.Drawing.Size(638, 192);
            this.grv_NhanVien.TabIndex = 13;
            this.grv_NhanVien.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grv_NhanVien_CellContentClick);
            // 
            // lbl_DSachCV
            // 
            this.lbl_DSachCV.AutoSize = true;
            this.lbl_DSachCV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DSachCV.Location = new System.Drawing.Point(4, 4);
            this.lbl_DSachCV.Name = "lbl_DSachCV";
            this.lbl_DSachCV.Size = new System.Drawing.Size(265, 29);
            this.lbl_DSachCV.TabIndex = 12;
            this.lbl_DSachCV.Text = "Danh Sách Nhân Viên";
            // 
            // grb_Them
            // 
            this.grb_Them.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.grb_Them.Controls.Add(this.txt_CV);
            this.grb_Them.Controls.Add(this.label5);
            this.grb_Them.Controls.Add(this.txt_DChi);
            this.grb_Them.Controls.Add(this.label4);
            this.grb_Them.Controls.Add(this.label3);
            this.grb_Them.Controls.Add(this.label2);
            this.grb_Them.Controls.Add(this.txt_SDT);
            this.grb_Them.Controls.Add(this.txt_MK);
            this.grb_Them.Controls.Add(this.txt_Email);
            this.grb_Them.Controls.Add(this.label1);
            this.grb_Them.Controls.Add(this.lbl_IdNVien);
            this.grb_Them.Controls.Add(this.txt_IdNV);
            this.grb_Them.Controls.Add(this.txt_TinhTrang);
            this.grb_Them.Controls.Add(this.txt_TenNV);
            this.grb_Them.Controls.Add(this.btn_Them);
            this.grb_Them.Controls.Add(this.lbl_TinhTrang);
            this.grb_Them.Controls.Add(this.lbl_TenNV);
            this.grb_Them.Controls.Add(this.lbl_ThemMoi);
            this.grb_Them.Location = new System.Drawing.Point(12, 12);
            this.grb_Them.Name = "grb_Them";
            this.grb_Them.Size = new System.Drawing.Size(410, 513);
            this.grb_Them.TabIndex = 4;
            this.grb_Them.TabStop = false;
            // 
            // lbl_IdNVien
            // 
            this.lbl_IdNVien.AutoSize = true;
            this.lbl_IdNVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_IdNVien.Location = new System.Drawing.Point(6, 59);
            this.lbl_IdNVien.Name = "lbl_IdNVien";
            this.lbl_IdNVien.Size = new System.Drawing.Size(62, 22);
            this.lbl_IdNVien.TabIndex = 15;
            this.lbl_IdNVien.Text = "ID NV";
            // 
            // txt_IdNV
            // 
            this.txt_IdNV.Location = new System.Drawing.Point(101, 59);
            this.txt_IdNV.Multiline = true;
            this.txt_IdNV.Name = "txt_IdNV";
            this.txt_IdNV.Size = new System.Drawing.Size(59, 22);
            this.txt_IdNV.TabIndex = 14;
            // 
            // txt_TinhTrang
            // 
            this.txt_TinhTrang.Location = new System.Drawing.Point(156, 412);
            this.txt_TinhTrang.Multiline = true;
            this.txt_TinhTrang.Name = "txt_TinhTrang";
            this.txt_TinhTrang.Size = new System.Drawing.Size(220, 40);
            this.txt_TinhTrang.TabIndex = 13;
            // 
            // txt_TenNV
            // 
            this.txt_TenNV.Location = new System.Drawing.Point(156, 104);
            this.txt_TenNV.Multiline = true;
            this.txt_TenNV.Name = "txt_TenNV";
            this.txt_TenNV.Size = new System.Drawing.Size(220, 40);
            this.txt_TenNV.TabIndex = 12;
            // 
            // btn_Them
            // 
            this.btn_Them.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_Them.Location = new System.Drawing.Point(293, 467);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(102, 40);
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
            this.lbl_TinhTrang.Location = new System.Drawing.Point(6, 430);
            this.lbl_TinhTrang.Name = "lbl_TinhTrang";
            this.lbl_TinhTrang.Size = new System.Drawing.Size(109, 22);
            this.lbl_TinhTrang.TabIndex = 10;
            this.lbl_TinhTrang.Text = "Tình Trạng";
            // 
            // lbl_TenNV
            // 
            this.lbl_TenNV.AutoSize = true;
            this.lbl_TenNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TenNV.Location = new System.Drawing.Point(6, 120);
            this.lbl_TenNV.Name = "lbl_TenNV";
            this.lbl_TenNV.Size = new System.Drawing.Size(144, 22);
            this.lbl_TenNV.TabIndex = 9;
            this.lbl_TenNV.Text = "Tên Nhân Viên";
            // 
            // lbl_ThemMoi
            // 
            this.lbl_ThemMoi.AutoSize = true;
            this.lbl_ThemMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ThemMoi.Location = new System.Drawing.Point(58, 7);
            this.lbl_ThemMoi.Name = "lbl_ThemMoi";
            this.lbl_ThemMoi.Size = new System.Drawing.Size(257, 29);
            this.lbl_ThemMoi.TabIndex = 8;
            this.lbl_ThemMoi.Text = "Thêm Mới Nhân Viên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 187);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 22);
            this.label1.TabIndex = 16;
            this.label1.Text = "Email";
            // 
            // txt_Email
            // 
            this.txt_Email.Location = new System.Drawing.Point(156, 169);
            this.txt_Email.Multiline = true;
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(220, 40);
            this.txt_Email.TabIndex = 17;
            // 
            // txt_MK
            // 
            this.txt_MK.Location = new System.Drawing.Point(156, 226);
            this.txt_MK.Multiline = true;
            this.txt_MK.Name = "txt_MK";
            this.txt_MK.Size = new System.Drawing.Size(220, 40);
            this.txt_MK.TabIndex = 18;
            // 
            // txt_SDT
            // 
            this.txt_SDT.Location = new System.Drawing.Point(156, 294);
            this.txt_SDT.Multiline = true;
            this.txt_SDT.Name = "txt_SDT";
            this.txt_SDT.Size = new System.Drawing.Size(220, 40);
            this.txt_SDT.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 244);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 22);
            this.label2.TabIndex = 20;
            this.label2.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 312);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 22);
            this.label3.TabIndex = 21;
            this.label3.Text = "SĐT";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 375);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 22);
            this.label4.TabIndex = 22;
            this.label4.Text = "Địa Chỉ";
            // 
            // txt_DChi
            // 
            this.txt_DChi.Location = new System.Drawing.Point(156, 357);
            this.txt_DChi.Multiline = true;
            this.txt_DChi.Name = "txt_DChi";
            this.txt_DChi.Size = new System.Drawing.Size(220, 40);
            this.txt_DChi.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(201, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 22);
            this.label5.TabIndex = 24;
            this.label5.Text = "ID CV";
            // 
            // txt_CV
            // 
            this.txt_CV.Location = new System.Drawing.Point(321, 60);
            this.txt_CV.Multiline = true;
            this.txt_CV.Name = "txt_CV";
            this.txt_CV.Size = new System.Drawing.Size(59, 22);
            this.txt_CV.TabIndex = 25;
            // 
            // frm_NhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1164, 537);
            this.Controls.Add(this.grb_DS);
            this.Controls.Add(this.grb_Them);
            this.Name = "frm_NhanVien";
            this.Text = "frm_NhanVien";
            this.Load += new System.EventHandler(this.frm_NhanVien_Load);
            this.grb_DS.ResumeLayout(false);
            this.grb_DS.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grv_NhanVien)).EndInit();
            this.grb_Them.ResumeLayout(false);
            this.grb_Them.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grb_DS;
        private System.Windows.Forms.Button btn_Xóa;
        private System.Windows.Forms.Button btn_CapNhat;
        private System.Windows.Forms.TextBox txt_TimKiemNV;
        private System.Windows.Forms.Button btn_TimKiem;
        private System.Windows.Forms.DataGridView grv_NhanVien;
        private System.Windows.Forms.Label lbl_DSachCV;
        private System.Windows.Forms.GroupBox grb_Them;
        private System.Windows.Forms.Label lbl_IdNVien;
        private System.Windows.Forms.TextBox txt_IdNV;
        private System.Windows.Forms.TextBox txt_TinhTrang;
        private System.Windows.Forms.TextBox txt_TenNV;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.Label lbl_TinhTrang;
        private System.Windows.Forms.Label lbl_TenNV;
        private System.Windows.Forms.Label lbl_ThemMoi;
        private System.Windows.Forms.TextBox txt_MK;
        private System.Windows.Forms.TextBox txt_Email;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_SDT;
        private System.Windows.Forms.TextBox txt_CV;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_DChi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}