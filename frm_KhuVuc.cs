using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quanlydichvuanuong
{
    public partial class frm_KhuVuc : Form
    {
        public frm_KhuVuc()
        {
            InitializeComponent();
        }
        LopDungChung lopdungchung = new LopDungChung();

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM khuVuc WHERE ten_khu_vuc LIKE '%" + txt_TimKiem.Text + "%'";
            DataTable dt = lopdungchung.LoadDL(sql);

            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Đã tìm thấy. ");
                grv_KhuVuc.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Không tìm thấy tên nào. ");
                grv_KhuVuc.DataSource = null;

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string sql = "UPDATE khuVuc SET ten_khu_vuc = '" + txt_TenKhuVuc.Text + "','" +  txt_TinhTrang.Text + "'" + txt_IDKV.Text + "','" + txt_SlugKhuVuc.Text + "'";
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

        private void frm_KhuVuc_Load(object sender, EventArgs e)
        {
            string sqlKhuVuc = "SELECT * FROM khuVuc";
            grv_KhuVuc.DataSource = lopdungchung.LoadDL(sqlKhuVuc);
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            string sql = "Insert into khuVuc Values ('" + txt_IDKV.Text +  "','" + txt_TinhTrang.Text +  txt_SlugKhuVuc.Text +  "')";
            int kq = lopdungchung.ThemSuaXoa(sql);
            if (kq >= 1) MessageBox.Show("Thêm thành công");
            else MessageBox.Show("Thêm thất bại");
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            string sql = "Delete khuVuc where Id = '" + txt_IDKV.Text + "'" ;
            int kq = lopdungchung.ThemSuaXoa(sql);
            if (kq >= 1) MessageBox.Show("Đã Xóa Thành Công");
            else MessageBox.Show("Thất Bại");

        }
    }
}
