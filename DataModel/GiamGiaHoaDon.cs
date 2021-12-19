using System;
using System.Collections.Generic;

#nullable disable

namespace QLCuaHangJuno.DataModel
{
    public partial class GiamGiaHoaDon
    {
        public GiamGiaHoaDon()
        {
            HoaDonBanHangs = new HashSet<HoaDonBanHang>();
        }

        public string MaGg { get; set; }
        public DateTime TgbatDau { get; set; }
        public DateTime TgketThuc { get; set; }
        public double TyLeGiamGia { get; set; }
        public decimal DieuKienApDung { get; set; }

        public virtual ICollection<HoaDonBanHang> HoaDonBanHangs { get; set; }
    }
}
