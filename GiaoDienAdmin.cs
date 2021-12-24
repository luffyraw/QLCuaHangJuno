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
        public GiaoDienAdmin()
        {
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
        private void kháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmKhachHang kh = new frmKhachHang();
            kh.Show();
        }

        private void khuyễnMãiTheoHóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmKhuyenMaiHoaDon km = new frmKhuyenMaiHoaDon();
            km.Show();
        }

        private void mãKhuyễnMãiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmKhuyenMai km = new frmKhuyenMai();
            km.Show();
        }

        private void danhSáchSảnPhẩmKhuyếnMãiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmKhuyenMaiSanPham km = new frmKhuyenMaiSanPham();
            km.Show();
        }
    }
}
