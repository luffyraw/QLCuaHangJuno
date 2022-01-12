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
        public NhanVien nv;
        public GiaoDienAdmin()
        {
            InitializeComponent();
        }

        private void GiaoDienAdmin_Load(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;
        }



        private void hóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void đặtHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseAllMDI();
            frmPhieuDatHang fr = new frmPhieuDatHang(nv);
            fr.MdiParent = this;

            fr.Show();
        }

        private void nhậpHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseAllMDI();

            frmPhieuNhapHang fr = new frmPhieuNhapHang(nv);
            fr.MdiParent = this;

            fr.Show();

        }

        private void kháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseAllMDI();

            frmKhachHang fr = new frmKhachHang();
            fr.MdiParent = this;

            fr.Show();
        }

        private void quảnLýNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseAllMDI();

            frmQuanLiNhanVien fr = new frmQuanLiNhanVien();
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

            DSPhieuTH fr = new DSPhieuTH();
            fr.MdiParent = this;

            fr.Show();
        }

        private void đổiHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseAllMDI();

            DSPhieuDoi fr = new DSPhieuDoi();
            fr.MdiParent = this;

            fr.Show();
        }

        private void sảnPhẩmToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CloseAllMDI();

            frmXemSanPham fr = new frmXemSanPham();
            fr.MdiParent = this;

            fr.Show();
        }

        private void loạiSảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseAllMDI();

            frmXemLoaiSanPham fr = new frmXemLoaiSanPham();
            fr.MdiParent = this;

            fr.Show();
        }

        private void theoHóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseAllMDI();

            frmKhuyenMaiHoaDon fr = new frmKhuyenMaiHoaDon();
            fr.MdiParent = this;

            fr.Show();
        }

        private void mãSảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseAllMDI();

            frmKhuyenMai fr = new frmKhuyenMai();
            fr.MdiParent = this;

            fr.Show();
        }

        private void danhSáchSảnPhẩmKhuyếnMãiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseAllMDI();

            frmKhuyenMaiSanPham fr = new frmKhuyenMaiSanPham();
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

        private void bảoHànhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseAllMDI();
            frmXemPhieuBaoHanh fr = new frmXemPhieuBaoHanh(nv);
            fr.MdiParent = this;
            fr.Show();
        }

        private void thốngKêHằngNămToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseAllMDI();
            ThongKe fr = new ThongKe();
            fr.MdiParent = this;
            fr.Show();
        }

        private void hoạtĐộngNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseAllMDI();
            ThongKeNhanVien fr = new ThongKeNhanVien();
            fr.MdiParent = this;
            fr.Show();
        }

        private void sảnPhẩmToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            CloseAllMDI();
            ThongKeSanPham fr = new ThongKeSanPham();
            fr.MdiParent = this;
            fr.Show();
        }
    }
}
