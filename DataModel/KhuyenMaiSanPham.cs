using System;
using System.Collections.Generic;

#nullable disable

namespace QLCuaHangJuno.DataModel
{
    public partial class KhuyenMaiSanPham
    {
        public string MaKm { get; set; }
        public string MaSp { get; set; }
        public double TyLeKhuyenMai { get; set; }

        public virtual KhuyenMai MaKmNavigation { get; set; }
        public virtual SanPham MaSpNavigation { get; set; }
    }
}
