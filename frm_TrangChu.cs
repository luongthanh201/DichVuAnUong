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
    public partial class frm_TrangChu : Form
    {
        public frm_TrangChu()
        {
            InitializeComponent();
        }

        private void nguyênLiệuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frm_QLNguyenLieu"] == null)
            {
                frm_QLNguyenLieu nlieu = new frm_QLNguyenLieu();
                nlieu.MdiParent = this;
                nlieu.Show();

            }
        }

        private void chứcVụToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frm_QLChucVu"] == null)
            {
                frm_QLChucVu chucvu = new frm_QLChucVu();
                chucvu.MdiParent = this;
                chucvu.Show();

            }
        }

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frm_NhanVien"] == null)
            {
                frm_NhanVien nhanvien = new frm_NhanVien();
                nhanvien.MdiParent = this;
                nhanvien.Show();

            }

        }

        private void nhậpKhoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frm_NhapKho"] == null)
            {
                frm_NhapKho nhapkho = new frm_NhapKho();
                nhapkho.MdiParent = this;
                nhapkho.Show();

            }

        }
    }
}
