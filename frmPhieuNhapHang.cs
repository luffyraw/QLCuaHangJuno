using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLCuaHangJuno.DataModel;

namespace QLCuaHangJuno
{
    public partial class frmPhieuNhapHang : Form
    {
        QuanLyCuaHangJunoContext db = new QuanLyCuaHangJunoContext();
        NhanVien nv = new NhanVien();
        int index = 0;
        public frmPhieuNhapHang(NhanVien nv)
        {
            this.nv = nv;
            InitializeComponent();
        }

        private void frmPhieuNhapHang_Load(object sender, EventArgs e)
        {
            HienThi();
        }
        private void HienThi()
        {
            var queryPhieuNhap = from p in db.PhieuNhapHangs
                                 select new
                                 {
                                     MaPhNhap = p.MaPhNhap,
                                     MaPhieuDat = p.MaPhieuDat,
                                     NgayNhap = p.NgayNhap.ToString("dd-MM-yyyy HH:mm:ss"),
                                     NguoiNhap = p.MaNvNavigation.HoTenNv,
                                     NguoiGiao = p.NguoiGiao
                                 };
            dgvPhieuNhap.DataSource = queryPhieuNhap.ToList();
            for (int i = 0; i < dgvPhieuNhap.Rows.Count; i++)
            {
                dgvPhieuNhap.Rows[i].Cells[0].Value = i + 1;
            }
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            var queryPhieuNhap = from p in db.PhieuNhapHangs
                                 where p.MaPhNhap == txtSearchMaPh.Text
                                 select new
                                 {
                                     MaPhNhap = p.MaPhNhap,
                                     MaPhieuDat = p.MaPhieuDat,
                                     NgayNhap = p.NgayNhap.ToString("dd-MM-yyyy HH:mm:ss"),
                                     NguoiNhap = p.MaNvNavigation.HoTenNv,
                                     NguoiGiao = p.NguoiGiao
                                 };
            dgvPhieuNhap.DataSource = queryPhieuNhap.ToList();
            for (int i = 0; i < dgvPhieuNhap.Rows.Count; i++)
            {
                dgvPhieuNhap.Rows[i].Cells[0].Value = i + 1;
            }
        }

        private void btnSearchByDate_Click(object sender, EventArgs e)
        {
            var queryPhieuNhap = from p in db.PhieuNhapHangs
                                 where p.NgayNhap >= dtpDateStart.Value && p.NgayNhap <= dtpDateEnd.Value
                                 select new
                                 {
                                     MaPhNhap = p.MaPhNhap,
                                     MaPhieuDat = p.MaPhieuDat,
                                     NgayNhap = p.NgayNhap.ToString("dd-MM-yyyy HH:mm:ss"),
                                     NguoiNhap = p.MaNvNavigation.HoTenNv,
                                     NguoiGiao = p.NguoiGiao
                                 };
            dgvPhieuNhap.DataSource = queryPhieuNhap.ToList();
            for (int i = 0; i < dgvPhieuNhap.Rows.Count; i++)
            {
                dgvPhieuNhap.Rows[i].Cells[0].Value = i + 1;
            }
        }

        private void btnChiTietPh_Click(object sender, EventArgs e)
        {
            string maPhieu = dgvPhieuNhap.Rows[index].Cells[1].Value.ToString();
            frmChiTietPhieuNhap frm = new frmChiTietPhieuNhap();
            frm.Tag = maPhieu;
            frm.Show();
        }

        private void dgvPhieuNhap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            frmTaoPhieuNhapHang frm = new frmTaoPhieuNhapHang(nv);
            frm.Show();
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            HienThi();
        }

        private void btnLoc_Click(object sender, EventArgs e)
        {
            if (txtMaPhieuD.Text != "")
            {
                var queryPhieuD = (from p in db.PhieuDatHangs
                                   where p.MaPhieuDat == txtMaPhieuD.Text
                                   select p).FirstOrDefault();
                if (queryPhieuD != null)
                {
                    if (queryPhieuD.TrangThai == "Chưa nhập")
                    {
                        MessageBox.Show("Phiếu đặt hàng có mã " + txtMaPhieuD.Text + " chưa được nhập.");
                    }
                    else
                    {
                        var queryPhieuNhap = from p in db.PhieuNhapHangs
                                             where p.MaPhieuDat == txtMaPhieuD.Text
                                             select new
                                             {
                                                 MaPhNhap = p.MaPhNhap,
                                                 MaPhieuDat = p.MaPhieuDat,
                                                 NgayNhap = p.NgayNhap.ToString("dd-MM-yyyy HH:mm:ss"),
                                                 NguoiNhap = p.MaNvNavigation.HoTenNv,
                                                 NguoiGiao = p.NguoiGiao
                                             };
                        dgvPhieuNhap.DataSource = queryPhieuNhap.ToList();
                        for (int i = 0; i < dgvPhieuNhap.Rows.Count; i++)
                        {
                            dgvPhieuNhap.Rows[i].Cells[0].Value = i + 1;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Không tồn tại phiếu đặt hàng có mã " + txtMaPhieuD.Text);
                } 
            }
        }
    }
}
