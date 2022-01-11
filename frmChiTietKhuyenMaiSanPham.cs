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
    public partial class frmChiTietKhuyenMaiSanPham : Form
    {
        QuanLyCuaHangJunoContext db = new QuanLyCuaHangJunoContext();
        private string makm;
        public frmChiTietKhuyenMaiSanPham()
        {
            InitializeComponent();
        }
        public frmChiTietKhuyenMaiSanPham(string a) : this()
        {
            makm = a;
            cbMaSP.Text = a;
            var pth = (from kmsp in db.KhuyenMaiSanPhams
                       where kmsp.MaSp == a
                       select kmsp).ToList();
            if (pth.Count() > 0)
            {
                cbMaKM.Text = pth.FirstOrDefault().MaKm;
                cbMaSP.Text = pth.FirstOrDefault().MaSp;
                txtTyLe.Text = pth.FirstOrDefault().TyLeKhuyenMai.ToString() ;
                SanPham sp = (from s in db.SanPhams
                              where s.MaSp == pth.FirstOrDefault().MaSp
                              select s).FirstOrDefault();
                cbMaLoaiSP.Text = sp.MaLoaiSp;
                KhuyenMai km = (from k in db.KhuyenMais
                              where k.MaKm == pth.FirstOrDefault().MaKm
                              select k).FirstOrDefault();
                dtpNgayBD.Text = km.NgayBatDau.ToString();
                dtpNgayKT.Text = km.NgayKetThuc.ToString();
            }
        }

        
    }
}
