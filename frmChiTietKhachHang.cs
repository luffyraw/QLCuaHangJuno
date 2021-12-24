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
    public partial class frmChiTietKhachHang : Form
    {
        public frmChiTietKhachHang()
        {
            InitializeComponent();
        }

        private void frmChiTietKhachHang_Load(object sender, EventArgs e)
        {
            KhachHang kh = (KhachHang)this.Tag;
            txtMa.Text = kh.MaKh;
            txtTen.Text = kh.HoTenKh;
            txtSdt.Text = kh.Sdt;
            txtDC.Text = kh.DiaChi;
        }
    }
}
