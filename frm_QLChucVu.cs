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
    public partial class frm_QLChucVu : Form
    {
        public frm_QLChucVu()
        {
            InitializeComponent();
        }

        LopDungChung lopdungchung = new LopDungChung();

        private void frm_QLChucVu_Load(object sender, EventArgs e)
        {
            string sqlChucVu = "SELECT * FROM CHUCVU";
            grv_ChucVu.DataSource = lopdungchung.LoadDL(sqlChucVu);
        }

        private void btn_TimKiem_Click(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM CHUCVU WHERE TenChucVu LIKE '%" + txt_TimKiemCV.Text + "%'";
            DataTable dt = lopdungchung.LoadDL(sql);

            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Đã tìm thấy. ");
                grv_ChucVu.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Không tìm thấy tên nào. ");
                grv_ChucVu.DataSource = null;

            }
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            string sql = "Insert into CHUCVU Values ('" + txt_IdCV.Text + "','" + txt_TenCV.Text + "','" + txt_TinhTrang.Text + "')";
            int kq = lopdungchung.ThemSuaXoa(sql);
            if (kq >= 1) MessageBox.Show("Thêm thành công");
            else MessageBox.Show("Thêm thất bại");
        }

        private void btn_Xóa_Click(object sender, EventArgs e)
        {
            string sql = "Delete CHUCVU where Id_ChucVu = '" + txt_IdCV.Text + "'";
            int kq = lopdungchung.ThemSuaXoa(sql);
            if (kq >= 1) MessageBox.Show("Đã Xóa Thành Công");
            else MessageBox.Show("Thất Bại");

        }

        private void btn_CapNhat_Click(object sender, EventArgs e)
        {
            string sql = "UPDATE CHUCVU SET TenChucVu = '" + txt_TenCV.Text + "','" + txt_IdCV.Text + "','" + txt_TinhTrang.Text + "'";
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

        private void grv_ChucVu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
