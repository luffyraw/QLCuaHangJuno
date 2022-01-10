using System;
using System.Collections.Generic;

#nullable disable

namespace QLCuaHangJuno.DataModel
{
    public partial class PhieuDatHang
    {
        public PhieuDatHang()
        {
            DatHangSanPhams = new HashSet<DatHangSanPham>();
            PhieuNhapHangs = new HashSet<PhieuNhapHang>();
        }

        public string MaPhieuDat { get; set; }
        public DateTime NgayDat { get; set; }
        public DateTime ThoiHanGiaoHang { get; set; }
        public string TrangThai { get; set; }
        public string MaNv { get; set; }

        public virtual NhanVien MaNvNavigation { get; set; }
        public virtual ICollection<DatHangSanPham> DatHangSanPhams { get; set; }
        public virtual ICollection<PhieuNhapHang> PhieuNhapHangs { get; set; }
    }
}
