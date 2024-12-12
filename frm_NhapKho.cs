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
    public partial class frm_NhapKho : Form
    {
        public frm_NhapKho()
        {
            InitializeComponent();
        }
        LopDungChung lopdungchung = new LopDungChung();

        private void frm_NhapKho_Load(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM NHACUNGCAP";
            cb_NCC.DataSource = lopdungchung.LoadDL(sql);
            cb_NCC.DisplayMember = "TenCongTy";
            cb_NCC.ValueMember = "MaSoThue";


            string sqlNKho = "SELECT * FROM NHAPKHO";
            grv_NKho.DataSource = lopdungchung.LoadDL(sqlNKho);
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            string sql = "Insert into NHAPKHO Values ('" + txt_IDNKho.Text + "','" + txt_NL.Text + "','" + txt_SLuong.Text + "','" + txt_DGia.Text + "','" + txt_TTien.Text + "','" + txt_HDNK.Text + "','" + txt_NV.Text + "')";
            int kq = lopdungchung.ThemSuaXoa(sql);
            if (kq >= 1) MessageBox.Show("Thêm thành công");
            else MessageBox.Show("Thêm thất bại");
        }

        private void btn_Xóa_Click(object sender, EventArgs e)
        {
            string sql = "Delete NHAPKHO where Id_NhapKho = '" + txt_IDNKho.Text + "'";
            int kq = lopdungchung.ThemSuaXoa(sql);
            if (kq >= 1) MessageBox.Show("Đã Xóa Thành Công");
            else MessageBox.Show("Thất Bại");
        }

        private void txt_TimKiem_TextChanged(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM NHAPKHO WHERE Id_NhapKho LIKE '%" + txt_IDNKho.Text + "%'";
            DataTable dt = lopdungchung.LoadDL(sql);

            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Đã Tìm Thấy Id Nhập Kho. ");
                grv_NKho.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Không tìm thấy ID. ");
                grv_NKho.DataSource = null;
            }
        }
    }
}
