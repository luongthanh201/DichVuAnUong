namespace QuanLyDichVuAnUong
{
    partial class frm_NhapKho
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
            this.grb_Them = new System.Windows.Forms.GroupBox();
            this.Id_NKho = new System.Windows.Forms.Label();
            this.txt_TTien = new System.Windows.Forms.TextBox();
            this.txt_IDNKho = new System.Windows.Forms.TextBox();
            this.btn_Them = new System.Windows.Forms.Button();
            this.lbl_ThemMoi = new System.Windows.Forms.Label();
            this.grb_DS = new System.Windows.Forms.GroupBox();
            this.btn_Xóa = new System.Windows.Forms.Button();
            this.grv_NKho = new System.Windows.Forms.DataGridView();
            this.lbl_DSachNKho = new System.Windows.Forms.Label();
            this.btn_TimKiem = new System.Windows.Forms.Button();
            this.txt_TimKiem = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_NCC = new System.Windows.Forms.ComboBox();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_NV = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_NL = new System.Windows.Forms.TextBox();
            this.txt_HDNK = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_SLuong = new System.Windows.Forms.TextBox();
            this.txt_DGia = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.grb_Them.SuspendLayout();
            this.grb_DS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grv_NKho)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // grb_Them
            // 
            this.grb_Them.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.grb_Them.Controls.Add(this.label8);
            this.grb_Them.Controls.Add(this.txt_DGia);
            this.grb_Them.Controls.Add(this.txt_SLuong);
            this.grb_Them.Controls.Add(this.label7);
            this.grb_Them.Controls.Add(this.txt_HDNK);
            this.grb_Them.Controls.Add(this.txt_NL);
            this.grb_Them.Controls.Add(this.label6);
            this.grb_Them.Controls.Add(this.label5);
            this.grb_Them.Controls.Add(this.txt_NV);
            this.grb_Them.Controls.Add(this.label4);
            this.grb_Them.Controls.Add(this.txt_TimKiem);
            this.grb_Them.Controls.Add(this.btn_TimKiem);
            this.grb_Them.Controls.Add(this.Id_NKho);
            this.grb_Them.Controls.Add(this.txt_IDNKho);
            this.grb_Them.Controls.Add(this.btn_Them);
            this.grb_Them.Controls.Add(this.lbl_ThemMoi);
            this.grb_Them.Location = new System.Drawing.Point(12, 22);
            this.grb_Them.Name = "grb_Them";
            this.grb_Them.Size = new System.Drawing.Size(431, 448);
            this.grb_Them.TabIndex = 4;
            this.grb_Them.TabStop = false;
            // 
            // Id_NKho
            // 
            this.Id_NKho.AutoSize = true;
            this.Id_NKho.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Id_NKho.Location = new System.Drawing.Point(2, 143);
            this.Id_NKho.Name = "Id_NKho";
            this.Id_NKho.Size = new System.Drawing.Size(123, 22);
            this.Id_NKho.TabIndex = 15;
            this.Id_NKho.Text = "ID Nhập Kho";
            // 
            // txt_TTien
            // 
            this.txt_TTien.Location = new System.Drawing.Point(506, 260);
            this.txt_TTien.Multiline = true;
            this.txt_TTien.Name = "txt_TTien";
            this.txt_TTien.Size = new System.Drawing.Size(96, 38);
            this.txt_TTien.TabIndex = 14;
            // 
            // txt_IDNKho
            // 
            this.txt_IDNKho.Location = new System.Drawing.Point(135, 130);
            this.txt_IDNKho.Multiline = true;
            this.txt_IDNKho.Name = "txt_IDNKho";
            this.txt_IDNKho.Size = new System.Drawing.Size(71, 35);
            this.txt_IDNKho.TabIndex = 13;
            // 
            // btn_Them
            // 
            this.btn_Them.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_Them.Location = new System.Drawing.Point(288, 390);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(103, 42);
            this.btn_Them.TabIndex = 11;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // lbl_ThemMoi
            // 
            this.lbl_ThemMoi.AutoSize = true;
            this.lbl_ThemMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ThemMoi.Location = new System.Drawing.Point(58, 7);
            this.lbl_ThemMoi.Name = "lbl_ThemMoi";
            this.lbl_ThemMoi.Size = new System.Drawing.Size(265, 29);
            this.lbl_ThemMoi.TabIndex = 8;
            this.lbl_ThemMoi.Text = "Danh Sách Nhân Viên";
            // 
            // grb_DS
            // 
            this.grb_DS.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.grb_DS.Controls.Add(this.comboBox1);
            this.grb_DS.Controls.Add(this.label3);
            this.grb_DS.Controls.Add(this.label2);
            this.grb_DS.Controls.Add(this.cb_NCC);
            this.grb_DS.Controls.Add(this.label1);
            this.grb_DS.Controls.Add(this.btn_Xóa);
            this.grb_DS.Controls.Add(this.txt_TTien);
            this.grb_DS.Controls.Add(this.grv_NKho);
            this.grb_DS.Controls.Add(this.lbl_DSachNKho);
            this.grb_DS.Location = new System.Drawing.Point(465, 22);
            this.grb_DS.Name = "grb_DS";
            this.grb_DS.Size = new System.Drawing.Size(621, 448);
            this.grb_DS.TabIndex = 5;
            this.grb_DS.TabStop = false;
            // 
            // btn_Xóa
            // 
            this.btn_Xóa.BackColor = System.Drawing.Color.Red;
            this.btn_Xóa.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btn_Xóa.Location = new System.Drawing.Point(534, 390);
            this.btn_Xóa.Name = "btn_Xóa";
            this.btn_Xóa.Size = new System.Drawing.Size(81, 52);
            this.btn_Xóa.TabIndex = 10;
            this.btn_Xóa.Text = "Xóa";
            this.btn_Xóa.UseVisualStyleBackColor = false;
            this.btn_Xóa.Click += new System.EventHandler(this.btn_Xóa_Click);
            // 
            // grv_NKho
            // 
            this.grv_NKho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grv_NKho.Location = new System.Drawing.Point(9, 71);
            this.grv_NKho.Name = "grv_NKho";
            this.grv_NKho.RowHeadersWidth = 62;
            this.grv_NKho.RowTemplate.Height = 28;
            this.grv_NKho.Size = new System.Drawing.Size(593, 144);
            this.grv_NKho.TabIndex = 13;
            // 
            // lbl_DSachNKho
            // 
            this.lbl_DSachNKho.AutoSize = true;
            this.lbl_DSachNKho.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DSachNKho.Location = new System.Drawing.Point(4, 4);
            this.lbl_DSachNKho.Name = "lbl_DSachNKho";
            this.lbl_DSachNKho.Size = new System.Drawing.Size(260, 29);
            this.lbl_DSachNKho.TabIndex = 12;
            this.lbl_DSachNKho.Text = "Danh Sách Nhập Kho";
            // 
            // btn_TimKiem
            // 
            this.btn_TimKiem.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_TimKiem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_TimKiem.Location = new System.Drawing.Point(6, 71);
            this.btn_TimKiem.Name = "btn_TimKiem";
            this.btn_TimKiem.Size = new System.Drawing.Size(105, 44);
            this.btn_TimKiem.TabIndex = 16;
            this.btn_TimKiem.Text = "Tìm Kiếm";
            this.btn_TimKiem.UseVisualStyleBackColor = false;
            // 
            // txt_TimKiem
            // 
            this.txt_TimKiem.Location = new System.Drawing.Point(117, 75);
            this.txt_TimKiem.Multiline = true;
            this.txt_TimKiem.Name = "txt_TimKiem";
            this.txt_TimKiem.Size = new System.Drawing.Size(287, 40);
            this.txt_TimKiem.TabIndex = 16;
            this.txt_TimKiem.TextChanged += new System.EventHandler(this.txt_TimKiem_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 235);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 22);
            this.label1.TabIndex = 17;
            this.label1.Text = "Chọn Nhà Cung Cấp";
            // 
            // cb_NCC
            // 
            this.cb_NCC.FormattingEnabled = true;
            this.cb_NCC.Location = new System.Drawing.Point(206, 235);
            this.cb_NCC.Name = "cb_NCC";
            this.cb_NCC.Size = new System.Drawing.Size(205, 28);
            this.cb_NCC.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(500, 235);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 22);
            this.label2.TabIndex = 19;
            this.label2.Text = "Tổng Tiền";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 295);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(230, 22);
            this.label3.TabIndex = 20;
            this.label3.Text = "Nhập Ghi Chú Nhập Kho";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(223, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 22);
            this.label4.TabIndex = 17;
            this.label4.Text = "ID NV";
            // 
            // txt_NV
            // 
            this.txt_NV.Location = new System.Drawing.Point(320, 130);
            this.txt_NV.Multiline = true;
            this.txt_NV.Name = "txt_NV";
            this.txt_NV.Size = new System.Drawing.Size(71, 35);
            this.txt_NV.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 193);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 22);
            this.label5.TabIndex = 19;
            this.label5.Text = "ID NLieu";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(223, 193);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 22);
            this.label6.TabIndex = 20;
            this.label6.Text = "ID HDon";
            // 
            // txt_NL
            // 
            this.txt_NL.Location = new System.Drawing.Point(135, 192);
            this.txt_NL.Multiline = true;
            this.txt_NL.Name = "txt_NL";
            this.txt_NL.Size = new System.Drawing.Size(71, 35);
            this.txt_NL.TabIndex = 21;
            // 
            // txt_HDNK
            // 
            this.txt_HDNK.Location = new System.Drawing.Point(320, 192);
            this.txt_HDNK.Multiline = true;
            this.txt_HDNK.Name = "txt_HDNK";
            this.txt_HDNK.Size = new System.Drawing.Size(71, 35);
            this.txt_HDNK.TabIndex = 22;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 241);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 22);
            this.label7.TabIndex = 23;
            this.label7.Text = "Số Lượng";
            // 
            // txt_SLuong
            // 
            this.txt_SLuong.Location = new System.Drawing.Point(135, 241);
            this.txt_SLuong.Multiline = true;
            this.txt_SLuong.Name = "txt_SLuong";
            this.txt_SLuong.Size = new System.Drawing.Size(136, 35);
            this.txt_SLuong.TabIndex = 24;
            // 
            // txt_DGia
            // 
            this.txt_DGia.Location = new System.Drawing.Point(135, 310);
            this.txt_DGia.Multiline = true;
            this.txt_DGia.Name = "txt_DGia";
            this.txt_DGia.Size = new System.Drawing.Size(136, 35);
            this.txt_DGia.TabIndex = 25;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(10, 311);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 22);
            this.label8.TabIndex = 26;
            this.label8.Text = "Đơn Giá";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(6, 339);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(401, 28);
            this.comboBox1.TabIndex = 21;
            // 
            // frm_NhapKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1099, 493);
            this.Controls.Add(this.grb_Them);
            this.Controls.Add(this.grb_DS);
            this.Name = "frm_NhapKho";
            this.Text = "frm_NhapKho";
            this.Load += new System.EventHandler(this.frm_NhapKho_Load);
            this.grb_Them.ResumeLayout(false);
            this.grb_Them.PerformLayout();
            this.grb_DS.ResumeLayout(false);
            this.grb_DS.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grv_NKho)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grb_Them;
        private System.Windows.Forms.Button btn_TimKiem;
        private System.Windows.Forms.Label Id_NKho;
        private System.Windows.Forms.TextBox txt_TTien;
        private System.Windows.Forms.TextBox txt_IDNKho;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.Label lbl_ThemMoi;
        private System.Windows.Forms.GroupBox grb_DS;
        private System.Windows.Forms.Button btn_Xóa;
        private System.Windows.Forms.DataGridView grv_NKho;
        private System.Windows.Forms.Label lbl_DSachNKho;
        private System.Windows.Forms.TextBox txt_TimKiem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb_NCC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_HDNK;
        private System.Windows.Forms.TextBox txt_NL;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_NV;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_DGia;
        private System.Windows.Forms.TextBox txt_SLuong;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}