using System;
using System.Collections.Generic;

#nullable disable

namespace QLCuaHangJuno.DataModel
{
    public partial class SanPham
    {
        public SanPham()
        {
            DatHangSanPhams = new HashSet<DatHangSanPham>();
            HoaDonBanHangSanPhams = new HashSet<HoaDonBanHangSanPham>();
            KhuyenMaiSanPhams = new HashSet<KhuyenMaiSanPham>();
            NhapHangSanPhams = new HashSet<NhapHangSanPham>();
            SanPhamChiTiets = new HashSet<SanPhamChiTiet>();
        }

        public string MaSp { get; set; }
        public string TenSp { get; set; }
        public string KieuDang { get; set; }
        public string ChatLieu { get; set; }
        public decimal DonGia { get; set; }
        public int ThoiGianBaoHanh { get; set; }
        public int ThoiGianTraHang { get; set; }
        public string MaLoaiSp { get; set; }

        public virtual LoaiSanPham MaLoaiSpNavigation { get; set; }
        public virtual ICollection<DatHangSanPham> DatHangSanPhams { get; set; }
        public virtual ICollection<HoaDonBanHangSanPham> HoaDonBanHangSanPhams { get; set; }
        public virtual ICollection<KhuyenMaiSanPham> KhuyenMaiSanPhams { get; set; }
        public virtual ICollection<NhapHangSanPham> NhapHangSanPhams { get; set; }
        public virtual ICollection<SanPhamChiTiet> SanPhamChiTiets { get; set; }
    }
}
