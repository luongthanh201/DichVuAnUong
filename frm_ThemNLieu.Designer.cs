namespace QuanLyDichVuAnUong
{
    partial class frm_ThemNLieu
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
            this.txt_IdNLieu = new System.Windows.Forms.TextBox();
            this.txt_TenNL = new System.Windows.Forms.TextBox();
            this.txt_SL = new System.Windows.Forms.TextBox();
            this.txt_GiaTien = new System.Windows.Forms.TextBox();
            this.txt_DVT = new System.Windows.Forms.TextBox();
            this.txt_TinhTrang = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_Them = new System.Windows.Forms.Button();
            this.btn_CapNhat = new System.Windows.Forms.Button();
            this.btn_Xóa = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_IdNLieu
            // 
            this.txt_IdNLieu.Location = new System.Drawing.Point(222, 24);
            this.txt_IdNLieu.Name = "txt_IdNLieu";
            this.txt_IdNLieu.Size = new System.Drawing.Size(30, 26);
            this.txt_IdNLieu.TabIndex = 0;
            // 
            // txt_TenNL
            // 
            this.txt_TenNL.Location = new System.Drawing.Point(222, 91);
            this.txt_TenNL.Name = "txt_TenNL";
            this.txt_TenNL.Size = new System.Drawing.Size(172, 26);
            this.txt_TenNL.TabIndex = 1;
            // 
            // txt_SL
            // 
            this.txt_SL.Location = new System.Drawing.Point(222, 154);
            this.txt_SL.Name = "txt_SL";
            this.txt_SL.Size = new System.Drawing.Size(172, 26);
            this.txt_SL.TabIndex = 2;
            // 
            // txt_GiaTien
            // 
            this.txt_GiaTien.Location = new System.Drawing.Point(222, 226);
            this.txt_GiaTien.Name = "txt_GiaTien";
            this.txt_GiaTien.Size = new System.Drawing.Size(172, 26);
            this.txt_GiaTien.TabIndex = 3;
            // 
            // txt_DVT
            // 
            this.txt_DVT.Location = new System.Drawing.Point(222, 288);
            this.txt_DVT.Name = "txt_DVT";
            this.txt_DVT.Size = new System.Drawing.Size(172, 26);
            this.txt_DVT.TabIndex = 4;
            // 
            // txt_TinhTrang
            // 
            this.txt_TinhTrang.Location = new System.Drawing.Point(222, 354);
            this.txt_TinhTrang.Name = "txt_TinhTrang";
            this.txt_TinhTrang.Size = new System.Drawing.Size(172, 26);
            this.txt_TinhTrang.TabIndex = 5;
            this.txt_TinhTrang.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Tên Nguyên Liệu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Số Lượng Nguyên Liệu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 226);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Giá Tiền";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 288);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Đơn Vị Tính";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(41, 354);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Tình Trạng";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(41, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "ID";
            // 
            // btn_Them
            // 
            this.btn_Them.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_Them.Location = new System.Drawing.Point(456, 400);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(121, 42);
            this.btn_Them.TabIndex = 12;
            this.btn_Them.Text = "Thêm Mới";
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // btn_CapNhat
            // 
            this.btn_CapNhat.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn_CapNhat.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btn_CapNhat.Location = new System.Drawing.Point(131, 400);
            this.btn_CapNhat.Name = "btn_CapNhat";
            this.btn_CapNhat.Size = new System.Drawing.Size(121, 42);
            this.btn_CapNhat.TabIndex = 13;
            this.btn_CapNhat.Text = "Cập Nhật";
            this.btn_CapNhat.UseVisualStyleBackColor = false;
            this.btn_CapNhat.Click += new System.EventHandler(this.btn_CapNhat_Click);
            // 
            // btn_Xóa
            // 
            this.btn_Xóa.BackColor = System.Drawing.Color.Red;
            this.btn_Xóa.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btn_Xóa.Location = new System.Drawing.Point(291, 400);
            this.btn_Xóa.Name = "btn_Xóa";
            this.btn_Xóa.Size = new System.Drawing.Size(121, 42);
            this.btn_Xóa.TabIndex = 14;
            this.btn_Xóa.Text = "Xóa";
            this.btn_Xóa.UseVisualStyleBackColor = false;
            this.btn_Xóa.Click += new System.EventHandler(this.btn_Xóa_Click);
            // 
            // frm_ThemNLieu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 454);
            this.Controls.Add(this.btn_Xóa);
            this.Controls.Add(this.btn_CapNhat);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_TinhTrang);
            this.Controls.Add(this.txt_DVT);
            this.Controls.Add(this.txt_GiaTien);
            this.Controls.Add(this.txt_SL);
            this.Controls.Add(this.txt_TenNL);
            this.Controls.Add(this.txt_IdNLieu);
            this.Name = "frm_ThemNLieu";
            this.Text = "frm_ThemNLieu";
            this.Load += new System.EventHandler(this.frm_ThemNLieu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_IdNLieu;
        private System.Windows.Forms.TextBox txt_TenNL;
        private System.Windows.Forms.TextBox txt_SL;
        private System.Windows.Forms.TextBox txt_GiaTien;
        private System.Windows.Forms.TextBox txt_DVT;
        private System.Windows.Forms.TextBox txt_TinhTrang;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.Button btn_CapNhat;
        private System.Windows.Forms.Button btn_Xóa;
    }
}