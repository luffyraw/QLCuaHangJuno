using System;
using System.Collections.Generic;

#nullable disable

namespace QLCuaHangJuno.DataModel
{
    public partial class PhieuDoiHang
    {
        public PhieuDoiHang()
        {
            PhieuDoiSanPhamDois = new HashSet<PhieuDoiSanPhamDoi>();
            PhieuDoiSanPhamHds = new HashSet<PhieuDoiSanPhamHd>();
        }

        public string MaPhieuDoi { get; set; }
        public DateTime NgayLap { get; set; }
        public string MaNv { get; set; }
        public string MaHd { get; set; }
        public string LyDoDoi { get; set; }
        public decimal TienThua { get; set; }
        public decimal TienThuLai { get; set; }

        public virtual HoaDonBanHang MaHdNavigation { get; set; }
        public virtual NhanVien MaNvNavigation { get; set; }
        public virtual ICollection<PhieuDoiSanPhamDoi> PhieuDoiSanPhamDois { get; set; }
        public virtual ICollection<PhieuDoiSanPhamHd> PhieuDoiSanPhamHds { get; set; }
    }
}
