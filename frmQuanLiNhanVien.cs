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
            cbQuyen.ValueMember = "Quyen";
        }

        private void HienThiDuLieu()
        {
            var nhanVien = from nv in db.NhanViens
                           select new
                           {
                               nv.MaNv,
                               nv.HoTenNv,
                               nv.GioiTinh,
                               nv.NgaySinh,
                               nv.Cmt,
                               nv.DiaChi,
                               nv.Sdt,
                               nv.Email,
                               nv.TenTk,
                               nv.MatKhau,
                               nv.Quyen
                           };
            dgvNhanVien.DataSource = nhanVien.ToList();
        }

        private bool kiemTraNgoaiLe()
        {
            bool dulieuhople = false;
            var user = (from item in db.NhanViens
                        where txtMaNV.Text == item.MaNv
                        select item).FirstOrDefault();
            var tkuser = (from tentk in db.NhanViens
                          where txtTenTaiKhoan.Text == tentk.TenTk
                          select tentk).FirstOrDefault();
            if (txtMaNV.Text != "")
            {
                if (txtHoTen.Text != "")
                {
                    int tuoi = DateTime.Now.Year - dtNgaySinh.Value.Year;
                    if (tuoi >= 18)
                    {
                        if (txtCMT.Text != "")
                        {
                            if (txtDiaChi.Text != "")
                            {
                                if (txtSDT.Text != "")
                                {
                                    if (txtEmail.Text != "")
                                    {
                                        if (txtTenTaiKhoan.Text != "")
                                        {
                                            if (txtMatKhau.Text != "")
                                            {
                                                if (user == null)
                                                {
                                                    if (tkuser == null)
                                                    {
                                                        dulieuhople = true;
                                                    }
                                                    else
                                                    {
                                                        MessageBox.Show("Tên tài khoản đã tồn tại");
                                                    }

                                                }
                                                else
                                                {
                                                    MessageBox.Show("Mã nhân viên đã tồn tại");
                                                }
                                            }
                                            else
                                            {
                                                MessageBox.Show("Bạn chưa nhập mật khẩu cho tài khoản nhân viên");
                                            }
                                        }
                                        else
                                        {
                                            MessageBox.Show("Bạn chưa nhập tên tài khoản nhân viên");
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("Bạn chưa nhập email nhân viên");
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Bạn chưa nhập số điện thoại nhân viên");
                                }
                            }
                            else
                            {
                                MessageBox.Show("Bạn chưa nhập địa chỉ nhân viên");
                            }

                        }
                        else
                        {
                            MessageBox.Show("Bạn chưa nhập số chứng minh thư của nhân viên");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Tuổi phải lớn hơn 18");
                    }
                }
                else
                {
                    MessageBox.Show("Bạn chưa nhập họ tên nhân viên");
                }
            }
            else
            {
                MessageBox.Show("Bạn chưa nhập mã nhân viên");
                txtMaNV.Focus();
            }
            return dulieuhople;
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            if (kiemTraNgoaiLe())
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
                MessageBox.Show("Thêm thành công");
            }
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

            if (nvXoa != null)
            {
                DialogResult tl = MessageBox.Show("Bạn muốn xóa nhân viên " + nvXoa.HoTenNv + "?", "Cập nhật dữ liệu", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (tl == DialogResult.Yes)
                {
                    db.Remove(nvXoa);
                    db.SaveChanges();
                    HienThiDuLieu();
                }
            }
            else
            {
                MessageBox.Show("Không có nhân viên " + txtMaNV.Text);
            }
        }
    }
}
