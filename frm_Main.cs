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
    public partial class frm_Main : Form
    {
        public frm_Main()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void frm_Main_Load(object sender, EventArgs e)
        {

        }

        private void nhàCcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frm_NhaCungCap"] == null)
            {
                frm_NhaCungCap Nhacc = new frm_NhaCungCap();
                Nhacc.MdiParent = this;
                Nhacc.Show();

            }
        }

        private void khuVựcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["frm_KhuVuc"] == null)
            {
                frm_KhuVuc Khuvuc = new frm_KhuVuc();
                Khuvuc.MdiParent = this;
                Khuvuc.Show();

            }
        }
    }
}
