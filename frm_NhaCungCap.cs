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
    public partial class frm_NhaCungCap : Form
    {
        public frm_NhaCungCap()
        {
            InitializeComponent();
        }
         LopDungChung lopdungchung = new LopDungChung();
        private void btn_Them_Click(object sender, EventArgs e)
        {
            
        }

        private void frm_NhaCungCap_Load(object sender, EventArgs e)
        {
            string sqlNhaCungCap = "SELECT * FROM NhaCungCap";
            grv_Nhacc.DataSource = lopdungchung.LoadDL(sqlNhaCungCap);
        }
    }
}
