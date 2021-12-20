using System;
using System.Collections.Generic;

#nullable disable

namespace QLCuaHangJuno.DataModel
{
    public partial class PhieuBaoHanh
    {
        public string MaPhieu { get; set; }
        public DateTime NgayLapPhieu { get; set; }
        public DateTime NgayTra { get; set; }
        public string MaNv { get; set; }
        public string MaSpCt { get; set; }
        public string MaHd { get; set; }
        public string Loi { get; set; }

        public virtual HoaDonBanHangSanPham Ma { get; set; }
        public virtual NhanVien MaNvNavigation { get; set; }
    }
}
