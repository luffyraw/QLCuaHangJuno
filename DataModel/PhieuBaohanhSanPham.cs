using System;
using System.Collections.Generic;

#nullable disable

namespace QLCuaHangJuno.DataModel
{
    public partial class PhieuBaohanhSanPham
    {
        public string MaPhieu { get; set; }
        public string MaHd { get; set; }
        public string MaSpCt { get; set; }
        public string Loi { get; set; }
        public string ChiTietLoi { get; set; }
        public int SoLuong { get; set; }

        public virtual HoaDonBanHangSanPham Ma { get; set; }
        public virtual PhieuBaoHanh MaPhieuNavigation { get; set; }
    }
}
