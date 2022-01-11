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
    public partial class frmXemSanPham : Form
    {
        QuanLyCuaHangJunoContext db = new QuanLyCuaHangJunoContext();
        int index = 0;
        public frmXemSanPham()
        {
            InitializeComponent();
        }

        private void frmXemSanPham_Load(object sender, EventArgs e)
        {
            HienThiDuLieuAll();
            var queryLSP = from lsp in db.LoaiSanPhams
                           select lsp;
            cboLoaiSp.DataSource = queryLSP.ToList();
            cboLoaiSp.DisplayMember = "TenLoaiSp";
            cboLoaiSp.ValueMember = "MaLoaiSp";
        }
        private void HienThiDuLieuAll()
        {

            var querySPCT = from spct in db.SanPhamChiTiets
                            group spct by spct.MaSp into g
                            select new
                            {
                                MaSp = g.Key,
                                SoLuongTon = g.Sum(sp => sp.SoLuongTon)
                            };
            var querySP = from sp in db.SanPhams
                          join spct in querySPCT on sp.MaSp equals spct.MaSp into g
                          from spct in g.DefaultIfEmpty()
                          select new
                          {
                              MaSp = sp.MaSp,
                              TenSp = sp.TenSp,
                              KieuDang = sp.KieuDang,
                              ChatLieu = sp.ChatLieu,
                              DonGia = sp.DonGia,
                              LoaiSp = sp.MaLoaiSpNavigation.TenLoaiSp,
                              ThoiGianBaoHanh = sp.ThoiGianBaoHanh + " tháng",
                              ThoiGianTraHang = sp.ThoiGianTraHang + " ngày",
                              SoLuongTon = spct.SoLuongTon
                          };


            dgvSanPham.DataSource = querySP.ToList();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            var querySPCT = from spct in db.SanPhamChiTiets
                            group spct by spct.MaSp into g
                            select new
                            {
                                MaSp = g.Key,
                                SoLuongTon = g.Sum(sp => sp.SoLuongTon)
                            };
            var querySP = from sp in db.SanPhams
                          join spct in querySPCT on sp.MaSp equals spct.MaSp
                          where sp.TenSp.Contains(txtSearchTenSp.Text)
                          select new
                          {
                              MaSp = sp.MaSp,
                              TenSp = sp.TenSp,
                              KieuDang = sp.KieuDang,
                              ChatLieu = sp.ChatLieu,
                              DonGia = sp.DonGia,
                              LoaiSp = sp.MaLoaiSpNavigation.TenLoaiSp,
                              ThoiGianBaoHanh = sp.ThoiGianBaoHanh + " tháng",
                              ThoiGianTraHang = sp.ThoiGianTraHang + " ngày",
                              SoLuongTon = spct.SoLuongTon
                          };


            dgvSanPham.DataSource = querySP.ToList();
        }

        private void btnLoc_Click(object sender, EventArgs e)
        {
            var querySPCT = from spct in db.SanPhamChiTiets
                            group spct by spct.MaSp into g
                            select new
                            {
                                MaSp = g.Key,
                                SoLuongTon = g.Sum(sp => sp.SoLuongTon)
                            };
            var querySP = from sp in db.SanPhams
                          join spct in querySPCT on sp.MaSp equals spct.MaSp
                          where sp.MaLoaiSp == cboLoaiSp.SelectedValue.ToString()
                          select new
                          {
                              MaSp = sp.MaSp,
                              TenSp = sp.TenSp,
                              KieuDang = sp.KieuDang,
                              ChatLieu = sp.ChatLieu,
                              DonGia = sp.DonGia,
                              LoaiSp = sp.MaLoaiSpNavigation.TenLoaiSp,
                              ThoiGianBaoHanh = sp.ThoiGianBaoHanh + " tháng",
                              ThoiGianTraHang = sp.ThoiGianTraHang + " ngày",
                              SoLuongTon = spct.SoLuongTon
                          };


            dgvSanPham.DataSource = querySP.ToList();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            HienThiDuLieuAll();
        }

        private void btn_ChiTietSP_Click(object sender, EventArgs e)
        {
            string maSP = dgvSanPham.Rows[index].Cells[0].Value.ToString();
            frmChiTietSanPham frm = new frmChiTietSanPham();
            frm.Tag = maSP;
            frm.Show();
        }

        private void dgvSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
        }
    }
}
