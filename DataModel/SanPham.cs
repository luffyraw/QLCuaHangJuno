using System;
using System.Collections.Generic;

#nullable disable

namespace QLCuaHangJuno.DataModel
{
    public partial class SanPham
    {
        public SanPham()
        {
            KhuyenMaiSanPhams = new HashSet<KhuyenMaiSanPham>();
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
        public virtual ICollection<KhuyenMaiSanPham> KhuyenMaiSanPhams { get; set; }
        public virtual ICollection<SanPhamChiTiet> SanPhamChiTiets { get; set; }
    }
}
