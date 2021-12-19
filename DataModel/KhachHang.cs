using System;
using System.Collections.Generic;

#nullable disable

namespace QLCuaHangJuno.DataModel
{
    public partial class KhachHang
    {
        public KhachHang()
        {
            HoaDonBanHangs = new HashSet<HoaDonBanHang>();
        }

        public string MaKh { get; set; }
        public string HoTenKh { get; set; }
        public string Sdt { get; set; }
        public string DiaChi { get; set; }

        public virtual ICollection<HoaDonBanHang> HoaDonBanHangs { get; set; }
    }
}
