using System;
using System.Collections.Generic;

#nullable disable

namespace QLCuaHangJuno.DataModel
{
    public partial class PhieuTraHang
    {
        public string MaPhieuTra { get; set; }
        public DateTime NgayLap { get; set; }
        public string MaNv { get; set; }
        public string MaSp { get; set; }
        public string MaHd { get; set; }
        public string LyDoTra { get; set; }

        public virtual HoaDonBanHangSanPham Ma { get; set; }
        public virtual NhanVien MaNvNavigation { get; set; }
    }
}
