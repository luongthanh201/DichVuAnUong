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
    public partial class frm_NhanVien : Form
    {
        public frm_NhanVien()
        {
            InitializeComponent();
        }
        LopDungChung lopdungchung = new LopDungChung();

        private void frm_NhanVien_Load(object sender, EventArgs e)
        {
            string sqlNVien = "SELECT * FROM NHANVIEN";
            grv_NhanVien.DataSource = lopdungchung.LoadDL(sqlNVien);

        }

        private void btn_TimKiem_Click(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM NHANVIEN WHERE HoVaTen LIKE '%" + txt_TenNV.Text + "%'";
            DataTable dt = lopdungchung.LoadDL(sql);

            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Đã tìm thấy. ");
                grv_NhanVien.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Không tìm thấy tên nào. ");
                grv_NhanVien.DataSource = null;

            }
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            string sql = "Insert into NHANVIEN Values ('" + txt_IdNV.Text + "','" + txt_TenNV.Text + "','" + txt_Email.Text + "','" + txt_MK.Text + "','" + txt_SDT.Text + "','" + txt_DChi.Text + "','" + txt_CV.Text + "','" + txt_TinhTrang.Text +  "')";
            int kq = lopdungchung.ThemSuaXoa(sql);
            if (kq >= 1) MessageBox.Show("Thêm thành công");
            else MessageBox.Show("Thêm thất bại");
        }

        private void btn_Xóa_Click(object sender, EventArgs e)
        {

            string sql = "Delete NHANVIEN where Id_NV = '" + txt_IdNV.Text + "'";
            int kq = lopdungchung.ThemSuaXoa(sql);
            if (kq >= 1) MessageBox.Show("Đã Xóa Thành Công");
            else MessageBox.Show("Thất Bại");
        }

        private void btn_CapNhat_Click(object sender, EventArgs e)
        {
            string sql = "UPDATE NHANVIEN SET HoVaTen = '" + txt_TenNV.Text + "','" + txt_IdNV.Text + "','" + txt_TinhTrang.Text + txt_Email.Text + "','" + txt_MK.Text + "','" + txt_SDT.Text + "','" + txt_DChi.Text + "','" + txt_CV.Text + "'";
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

        private void grv_NhanVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > 0)
            {
                DataGridViewRow row = grv_NhanVien.Rows[e.RowIndex];

                txt_IdNV.Text = row.Cells[0].Value.ToString();
                txt_TenNV.Text = row.Cells[1].Value.ToString();
                txt_Email.Text = row.Cells[2].Value.ToString();
                txt_MK.Text = row.Cells[3].Value.ToString();
                txt_SDT.Text = row.Cells[4].Value.ToString();
                txt_DChi.Text = row.Cells[5].Value.ToString();
                txt_CV.Text = row.Cells[6].Value.ToString();
                txt_TinhTrang.Text = row.Cells[7].Value.ToString();
            }
        }
    }
}
