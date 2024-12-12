namespace quanlydichvuanuong
{
    partial class frm_NhaCungCap
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.grv_Nhacc = new System.Windows.Forms.DataGridView();
            this.btn_TimKiem = new System.Windows.Forms.Button();
            this.btn_CapNhat = new System.Windows.Forms.Button();
            this.btn_TamDung = new System.Windows.Forms.Button();
            this.btn_HoatDong = new System.Windows.Forms.Button();
            this.txt_TimKiem = new System.Windows.Forms.TextBox();
            this.btn_Them = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grv_Nhacc)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.grv_Nhacc);
            this.panel1.Controls.Add(this.btn_TimKiem);
            this.panel1.Controls.Add(this.btn_CapNhat);
            this.panel1.Controls.Add(this.btn_TamDung);
            this.panel1.Controls.Add(this.btn_HoatDong);
            this.panel1.Controls.Add(this.txt_TimKiem);
            this.panel1.Controls.Add(this.btn_Them);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 51);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(916, 373);
            this.panel1.TabIndex = 1;
            // 
            // grv_Nhacc
            // 
            this.grv_Nhacc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grv_Nhacc.Location = new System.Drawing.Point(18, 91);
            this.grv_Nhacc.Name = "grv_Nhacc";
            this.grv_Nhacc.RowHeadersWidth = 51;
            this.grv_Nhacc.RowTemplate.Height = 24;
            this.grv_Nhacc.Size = new System.Drawing.Size(886, 170);
            this.grv_Nhacc.TabIndex = 12;
            // 
            // btn_TimKiem
            // 
            this.btn_TimKiem.Location = new System.Drawing.Point(728, 48);
            this.btn_TimKiem.Name = "btn_TimKiem";
            this.btn_TimKiem.Size = new System.Drawing.Size(75, 23);
            this.btn_TimKiem.TabIndex = 11;
            this.btn_TimKiem.Text = "Tìm kiếm";
            this.btn_TimKiem.UseVisualStyleBackColor = true;
            // 
            // btn_CapNhat
            // 
            this.btn_CapNhat.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_CapNhat.Location = new System.Drawing.Point(823, 333);
            this.btn_CapNhat.Name = "btn_CapNhat";
            this.btn_CapNhat.Size = new System.Drawing.Size(81, 23);
            this.btn_CapNhat.TabIndex = 11;
            this.btn_CapNhat.Text = "Cập nhật";
            this.btn_CapNhat.UseVisualStyleBackColor = false;
            // 
            // btn_TamDung
            // 
            this.btn_TamDung.BackColor = System.Drawing.Color.Red;
            this.btn_TamDung.Location = new System.Drawing.Point(728, 304);
            this.btn_TamDung.Name = "btn_TamDung";
            this.btn_TamDung.Size = new System.Drawing.Size(93, 23);
            this.btn_TamDung.TabIndex = 10;
            this.btn_TamDung.Text = "Tạm dừng";
            this.btn_TamDung.UseVisualStyleBackColor = false;
            // 
            // btn_HoatDong
            // 
            this.btn_HoatDong.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.btn_HoatDong.ForeColor = System.Drawing.Color.Black;
            this.btn_HoatDong.Location = new System.Drawing.Point(634, 304);
            this.btn_HoatDong.Name = "btn_HoatDong";
            this.btn_HoatDong.Size = new System.Drawing.Size(88, 23);
            this.btn_HoatDong.TabIndex = 9;
            this.btn_HoatDong.Text = "Hoạt động";
            this.btn_HoatDong.UseVisualStyleBackColor = false;
            // 
            // txt_TimKiem
            // 
            this.txt_TimKiem.Location = new System.Drawing.Point(204, 48);
            this.txt_TimKiem.Name = "txt_TimKiem";
            this.txt_TimKiem.Size = new System.Drawing.Size(518, 22);
            this.txt_TimKiem.TabIndex = 8;
            // 
            // btn_Them
            // 
            this.btn_Them.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_Them.Location = new System.Drawing.Point(775, 13);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(75, 23);
            this.btn_Them.TabIndex = 7;
            this.btn_Them.Text = "Thêm mới";
            this.btn_Them.UseVisualStyleBackColor = false;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(251, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Danh sách nhà cung cấp";
            // 
            // frm_NhaCungCap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 450);
            this.Controls.Add(this.panel1);
            this.Name = "frm_NhaCungCap";
            this.Text = "frm_NhaCungCap";
            this.Load += new System.EventHandler(this.frm_NhaCungCap_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grv_Nhacc)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_CapNhat;
        private System.Windows.Forms.Button btn_TamDung;
        private System.Windows.Forms.Button btn_HoatDong;
        private System.Windows.Forms.TextBox txt_TimKiem;
        private System.Windows.Forms.Button btn_TimKiem;
        private System.Windows.Forms.DataGridView grv_Nhacc;
    }
}