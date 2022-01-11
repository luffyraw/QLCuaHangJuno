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
    public partial class frmQuanLiNhanVien : Form
    {
        public frmQuanLiNhanVien()
        {
            InitializeComponent();
        }

        QuanLyCuaHangJunoContext db = new QuanLyCuaHangJunoContext();
        private void frmQuanLiNhanVien_Load(object sender, EventArgs e)
        {
            HienThiDuLieu();
            var queryCombo = from quyen in db.NhanViens
                             select quyen;
            cbQuyen.DataSource = queryCombo.ToList();
            cbQuyen.DisplayMember = "Quyen";

        }

        private void HienThiDuLieu()
        {
            var query = from nv in db.NhanViens
                        select nv;
            dgvNhanVien.DataSource = query.ToList();
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            NhanVien nvMoi = new NhanVien();
            nvMoi.MaNv = txtMaNV.Text;
            nvMoi.HoTenNv = txtHoTen.Text;
            if (radNam.Checked == true)
            {
                nvMoi.GioiTinh = "Nam";
            }
            else if (radNu.Checked == true)
            {
                nvMoi.GioiTinh = "Nữ";
            }
            nvMoi.NgaySinh = dtNgaySinh.Value;
            nvMoi.Cmt = txtCMT.Text;
            nvMoi.DiaChi = txtDiaChi.Text;
            nvMoi.Sdt = txtSDT.Text;
            nvMoi.Email = txtEmail.Text;
            nvMoi.TenTk = txtTenTaiKhoan.Text;
            nvMoi.MatKhau = txtMatKhau.Text;
            nvMoi.Quyen = cbQuyen.SelectedValue.ToString();

            db.NhanViens.Add(nvMoi);
            db.SaveChanges();
            HienThiDuLieu();
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            var query = from nv in db.NhanViens
                        where nv.MaNv == txtMaNV.Text
                        select nv;
            NhanVien nvSua = query.FirstOrDefault();
            nvSua.HoTenNv = txtHoTen.Text;
            if (radNam.Checked == true)
            {
                nvSua.GioiTinh = "Nam";
            }
            else if (radNu.Checked == true)
            {
                nvSua.GioiTinh = "Nữ";
            }
            nvSua.NgaySinh = dtNgaySinh.Value;
            nvSua.Cmt = txtCMT.Text;
            nvSua.DiaChi = txtDiaChi.Text;
            nvSua.Sdt = txtSDT.Text;
            nvSua.Email = txtEmail.Text;
            nvSua.TenTk = txtTenTaiKhoan.Text;
            nvSua.MatKhau = txtMatKhau.Text;
            nvSua.Quyen = cbQuyen.SelectedValue.ToString();

            db.SaveChanges();
            HienThiDuLieu();
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            NhanVien nvXoa = (from nv in db.NhanViens
                              where nv.MaNv == txtMaNV.Text
                              select nv).FirstOrDefault();

            db.Remove(nvXoa);
            db.SaveChanges();
            HienThiDuLieu();
        }
    }
}
