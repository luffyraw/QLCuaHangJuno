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
    public partial class GiaoDienNhanVien : Form
    {
        public NhanVien nv; 
        public GiaoDienNhanVien()
        {
            InitializeComponent();
        }

        private void bánHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseAllMDI();

            HoaDonThanhToan hd = new HoaDonThanhToan(nv);
            hd.MdiParent = this;
            hd.Show();
        }


        private void tạoPhiếuBảoHànhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseAllMDI();

            frmBaoHanh fr = new frmBaoHanh(nv);
            fr.MdiParent = this;
            fr.Show();
        }

        private void thôngTinCáNhânToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseAllMDI();

            frmXemThongTinCaNhan fr = new frmXemThongTinCaNhan(nv);
            fr.MdiParent = this;
            fr.Show();
        }

        private void đổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseAllMDI();

            frmDoiMatKhau fr = new frmDoiMatKhau(nv);
            fr.MdiParent = this;
            fr.Show();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void trảHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseAllMDI();

            AddPhieuTH fr = new AddPhieuTH();
            fr.MdiParent = this;
            fr.Show();
        }

        private void đổiHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseAllMDI();

            AddPhieuDoi fr = new AddPhieuDoi();
            fr.MdiParent = this;
            fr.Show();
        }

        private void sảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseAllMDI();

            frmXemSanPham fr = new frmXemSanPham();
            fr.MdiParent = this;
            fr.Show();
        }

        private void nhậpHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseAllMDI();

            frmTaoPhieuNhapHang fr = new frmTaoPhieuNhapHang(nv);
            fr.MdiParent = this;
            fr.Show();
        }
        public void CloseAllMDI()
        {
            foreach (Form frm in this.MdiChildren)
            {
                frm.Close();

            }
        }
    }
}
