using System;
using System.Collections.Generic;

#nullable disable

namespace QLCuaHangJuno.DataModel
{
    public partial class PhieuNhapHang
    {
        public PhieuNhapHang()
        {
            NhapHangSanPhams = new HashSet<NhapHangSanPham>();
        }

        public string MaPhNhap { get; set; }
        public DateTime NgayNhap { get; set; }
        public string NguoiGiao { get; set; }
        public string MaPhieuDat { get; set; }
        public string MaNv { get; set; }

        public virtual NhanVien MaNvNavigation { get; set; }
        public virtual PhieuDatHang MaPhieuDatNavigation { get; set; }
        public virtual ICollection<NhapHangSanPham> NhapHangSanPhams { get; set; }
    }
}
