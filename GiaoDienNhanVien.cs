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

        private void GiaoDienNhanVien_Load(object sender, EventArgs e)
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
