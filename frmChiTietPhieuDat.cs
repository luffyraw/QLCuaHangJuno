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
    public partial class frmChiTietPhieuDat : Form
    {
        QuanLyCuaHangJunoContext db = new QuanLyCuaHangJunoContext();
        public frmChiTietPhieuDat()
        {
            InitializeComponent();
        }

        private void frmChiTietPhieuDat_Load(object sender, EventArgs e)
        {
            var phieu = (from ph in db.PhieuDatHangs
                         where ph.MaPhieuDat == this.Tag.ToString()
                         select ph).FirstOrDefault();
            txtMaPhieuD.Text = phieu.MaPhieuDat;
            txtNgayLap.Text = phieu.NgayDat.ToString("dd-MM-yyyy HH:mm:ss");
            txtThoiHanGiaoHang.Text = phieu.ThoiHanGiaoHang.ToString("dd-MM-yyyy");
            var sps = from spd in db.DatHangSanPhams
                      where spd.MaPhieuDat == this.Tag.ToString()
                      select new
                      {
                          MaSpCt = spd.MaSpCt,
                          SoLuongDat = spd.SoLuongDat
                      };
            var sanPhamDats = from spct in db.SanPhamChiTiets
                              join spd in sps on spct.MaSpCt equals spd.MaSpCt
                              select new
                              {
                                  MaSp = spct.MaSp,
                                  TenSp = spct.MaSpNavigation.TenSp,
                                  Mau = spct.MaMauNavigation.Mau1,
                                  KichCo = spct.MaKcNavigation.KichCo1,
                                  SoLuongDat = spd.SoLuongDat
                              };
            dgvSanPhamDat.DataSource = sanPhamDats.ToList();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
