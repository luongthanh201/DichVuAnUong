using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyDichVuAnUong
{
    public partial class frm_ThemNLieu : Form
    {
        public frm_ThemNLieu()
        {
            InitializeComponent();
        }

        LopDungChung lopdungchung = new LopDungChung();

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            string sql = "Insert into NGUYENLIEU Values ('" + txt_IdNLieu.Text + "','" + txt_TenNL.Text + "','" + txt_SL.Text + "','" + txt_GiaTien.Text + "','" + txt_DVT.Text + "','" + txt_TinhTrang.Text + "')";
            int kq = lopdungchung.ThemSuaXoa(sql);
            if (kq >= 1) MessageBox.Show("Thêm thành công");
            else MessageBox.Show("That Bai");
        }

        private void btn_CapNhat_Click(object sender, EventArgs e)
        {
            string sql = "UPDATE CHUCVU SET TenChucVu = '" + txt_IdNLieu.Text + "','" + txt_TenNL.Text + "','" + txt_SL.Text + "','" + txt_GiaTien.Text + "','" +txt_DVT.Text + "','" + txt_TinhTrang.Text + "'";
            int kq = lopdungchung.ThemSuaXoa(sql);
            if (kq >= 1)
            {
                MessageBox.Show("Cập nhật thành công.");
            }
            else
            {
                MessageBox.Show("Cập nhật thất bại.");
            }
        }

        private void btn_Xóa_Click(object sender, EventArgs e)
        {
            string sql = "Delete NGUYENLIEU where Id_NguyenLieu = '" + txt_IdNLieu.Text + "'";
            int kq = lopdungchung.ThemSuaXoa(sql);
            if (kq >= 1) MessageBox.Show("Đã Xóa Thành Công");
            else MessageBox.Show("Thất Bại");
        }

        private void frm_ThemNLieu_Load(object sender, EventArgs e)
        {

        }
    }
}
