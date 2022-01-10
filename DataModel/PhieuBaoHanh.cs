using System;
using System.Collections.Generic;

#nullable disable

namespace QLCuaHangJuno.DataModel
{
    public partial class PhieuBaoHanh
    {
        public PhieuBaoHanh()
        {
            PhieuBaohanhSanPhams = new HashSet<PhieuBaohanhSanPham>();
        }

        public string MaPhieu { get; set; }
        public DateTime NgayLapPhieu { get; set; }
        public string MaHd { get; set; }
        public string MaNv { get; set; }
        public DateTime NgayTra { get; set; }

        public virtual HoaDonBanHang MaHdNavigation { get; set; }
        public virtual NhanVien MaNvNavigation { get; set; }
        public virtual ICollection<PhieuBaohanhSanPham> PhieuBaohanhSanPhams { get; set; }
    }
}
