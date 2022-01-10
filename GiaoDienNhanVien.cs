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
        public GiaoDienNhanVien()
        {
            InitializeComponent();
        }
        QuanLyCuaHangJunoContext db = new QuanLyCuaHangJunoContext();
        NhanVien nv = new NhanVien();
        public GiaoDienNhanVien(NhanVien nv)
        {
            this.nv = nv;
            InitializeComponent();
        }
        private void thôngTinCáNhânToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmXemThongTinCaNhan thongTin = new frmXemThongTinCaNhan(nv);
            thongTin.Show();
        }

        private void đổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDoiMatKhau doiMK = new frmDoiMatKhau(nv);
            doiMK.Show();
        }

        private void tạoPhiếuBảoHànhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBaoHanh baoHanh = new frmBaoHanh(nv);
            baoHanh.Show();
        }

        private void xemPhiếuBảoHànhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmXemPhieuBaoHanh xemBaoHanh = new frmXemPhieuBaoHanh(nv);
            xemBaoHanh.Show();
        }
    }
}
