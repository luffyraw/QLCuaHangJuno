using System;
using System.Collections.Generic;

#nullable disable

namespace QLCuaHangJuno.DataModel
{
    public partial class HoaDonBanHangSanPham
    {
        public HoaDonBanHangSanPham()
        {
            PhieuBaoHanhs = new HashSet<PhieuBaoHanh>();
            PhieuTraHangs = new HashSet<PhieuTraHang>();
        }

        public string MaHd { get; set; }
        public string MaSpCt { get; set; }
        public int SoLuongBan { get; set; }

        public virtual HoaDonBanHang MaHdNavigation { get; set; }
        public virtual SanPhamChiTiet MaSpCtNavigation { get; set; }
        public virtual ICollection<PhieuBaoHanh> PhieuBaoHanhs { get; set; }
        public virtual ICollection<PhieuTraHang> PhieuTraHangs { get; set; }
    }
}
