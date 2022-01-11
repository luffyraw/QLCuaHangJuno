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
    public partial class frmXemThongTinCaNhan : Form
    {

        QuanLyCuaHangJunoContext db = new QuanLyCuaHangJunoContext();
        NhanVien nv = new NhanVien();
        public frmXemThongTinCaNhan(NhanVien nv)
        {
            this.nv = nv;
            InitializeComponent();
        }
        private void frmXemThongTinCaNhan_Load(object sender, EventArgs e)
        {
            txtTenTK.Text = nv.TenTk;
            txtMaNV.Text = nv.MaNv;
            txtHoTen.Text = nv.HoTenNv;
            if (nv.GioiTinh == "Nam")
                radNam.Checked = true;
            else
                radNu.Checked = true;
            dtNgaySinh.Value = nv.NgaySinh;
            txtCmt.Text = nv.Cmt;
            txtDiaChi.Text = nv.DiaChi;
            txtSdt.Text = nv.Sdt;
            txtEmail.Text = nv.Email;
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }
    }
}
