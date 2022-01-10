using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using QLCuaHangJuno.DataModel;

namespace QLCuaHangJuno
{
    public partial class frmChiTietSanPham : Form
    {
        //QuanLyCuaHangJunoContext db = new QuanLyCuaHangJunoContext();
        public frmChiTietSanPham()
        {
            InitializeComponent();
        }

        private void frmChiTietSanPham_Load(object sender, EventArgs e)
        {
            //var sp = (from sanpham in db.SanPhams
            //         where sanpham.MaSp == this.Tag.ToString()
            //         select new
            //         {
            //             MaSp = sanpham.MaSp,
            //             TenSp = sanpham.TenSp,
            //             KieuDang = sanpham.KieuDang,
            //             ChatLieu = sanpham.ChatLieu,
            //             DonGia = sanpham.DonGia,
            //             LoaiSp = sanpham.MaLoaiSpNavigation.TenLoaiSp,
            //             ThoiGianBaoHanh = sanpham.ThoiGianBaoHanh + " tháng",
            //             ThoiGianTraHang = sanpham.ThoiGianTraHang + " ngày",
            //         }).FirstOrDefault();
            //txtMaSp.Text = sp.MaSp;
            //txtTenSp.Text = sp.TenSp;
            //txtKieuDang.Text = sp.KieuDang;
            //txtChatLieu.Text = sp.ChatLieu;
            //txtDonGia.Text = sp.DonGia.ToString();
            //txtLoaiSp.Text = sp.LoaiSp;
            //txtBaoHanh.Text = sp.ThoiGianBaoHanh;
            //txtTraHang.Text = sp.ThoiGianTraHang;
            //var query = from spct in db.SanPhamChiTiets
            //            where spct.MaSp == this.Tag.ToString()
            //            select new
            //            {
            //                Mau = spct.MaMauNavigation.Mau1,
            //                KichCo = spct.MaKcNavigation.KichCo1,
            //                SoLuongCon = spct.SoLuongTon
            //            };
            //dgvChiTietSP.DataSource = query.ToList();

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
