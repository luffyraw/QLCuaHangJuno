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
            hd.Show();
        }
    }
}
