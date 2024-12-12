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
    public partial class frm_QLNguyenLieu : Form
    {
        public frm_QLNguyenLieu()
        {
            InitializeComponent();
        }
        LopDungChung lopdungchung = new LopDungChung();



        private void frm_QLNguyenLieu_Load(object sender, EventArgs e)
        {
           
            string sqlQLNguyenLieu = "SELECT * FROM NGUYENLIEU";
            grv_NLieu.DataSource = lopdungchung.LoadDL(sqlQLNguyenLieu);

        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frm_ThemNLieu"] == null)
            {
                frm_ThemNLieu nguyenlieu = new frm_ThemNLieu();
                nguyenlieu.Show();

            }
        }

        private void btn_TimKiem_Click(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM NGUYENLIEU WHERE TenNLieu LIKE '%" + txt_TimKiem.Text + "%'";
            DataTable dt = lopdungchung.LoadDL(sql);

            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Đã tìm thấy. ");
                grv_NLieu.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Không tìm thấy tên nào. ");
                grv_NLieu.DataSource = null;

            }
        }

        private void grb_NL_Enter(object sender, EventArgs e)
        {

        }

        private void btn_Xóa_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frm_ThemNLieu"] == null)
            {
                frm_ThemNLieu nguyenlieu = new frm_ThemNLieu();
                nguyenlieu.Show();

            }
        }

        private void btn_CapNhat_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frm_ThemNLieu"] == null)
            {
                frm_ThemNLieu nguyenlieu = new frm_ThemNLieu();
                nguyenlieu.Show();

            }
        }
    }
}
