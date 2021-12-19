using System;
using System.Collections.Generic;

#nullable disable

namespace QLCuaHangJuno.DataModel
{
    public partial class HoaDonBanHang
    {
        public HoaDonBanHang()
        {
            HoaDonBanHangSanPhams = new HashSet<HoaDonBanHangSanPham>();
        }

        public string MaHd { get; set; }
        public DateTime NgayBan { get; set; }
        public string MaKh { get; set; }
        public string MaGg { get; set; }
        public string MaNv { get; set; }

        public virtual GiamGiaHoaDon MaGgNavigation { get; set; }
        public virtual KhachHang MaKhNavigation { get; set; }
        public virtual NhanVien MaNvNavigation { get; set; }
        public virtual ICollection<HoaDonBanHangSanPham> HoaDonBanHangSanPhams { get; set; }
    }
}
