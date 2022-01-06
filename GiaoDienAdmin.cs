using QLCuaHangJuno.DataModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLCuaHangJuno
{
    public partial class GiaoDienAdmin : Form
    {
        NhanVien nv = new NhanVien();
        public GiaoDienAdmin(NhanVien nv)
        {
            this.nv = nv;
            InitializeComponent();
        }

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void quảnLíNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQuanLiNhanVien qlNV = new frmQuanLiNhanVien();
            qlNV.Show();
        }

        private void thốngKêToolStripMenuItem_Click(object sender, EventArgs e)
        {
         
            Form new_mdi_child = new ThongKe();
            new_mdi_child.Text = "Cửa sổ con MDI";
            new_mdi_child.MdiParent = this;
            new_mdi_child.Show();
        }

        private void GiaoDienAdmin_Load(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
