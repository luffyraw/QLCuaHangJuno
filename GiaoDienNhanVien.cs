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
        NhanVien nv = new NhanVien();
        public GiaoDienNhanVien(NhanVien nv)
        {
            this.nv = nv;
            InitializeComponent();
        }

        private void hóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HoaDonThanhToan hd = new HoaDonThanhToan(nv);
            hd.Text = "Tạo hóa đơn";
            hd.MdiParent = this;
            hd.Show();
        }
     

        private void trảHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddPhieuTH form = new AddPhieuTH();
            form.Show();
        }

        private void đổiHàngtoolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddPhieuDoi form = new AddPhieuDoi();
            form.Show();
        }

        private void nhậpHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTaoPhieuNhapHang frm = new frmTaoPhieuNhapHang(nv);
            frm.Show();
        }
    }
}
