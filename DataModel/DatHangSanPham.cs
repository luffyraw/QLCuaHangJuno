using System;
using System.Collections.Generic;

#nullable disable

namespace QLCuaHangJuno.DataModel
{
    public partial class DatHangSanPham
    {
        public string MaPhieuDat { get; set; }
        public string MaSp { get; set; }
        public int SoLuongDat { get; set; }

        public virtual PhieuDatHang MaPhieuDatNavigation { get; set; }
        public virtual SanPham MaSpNavigation { get; set; }
    }
}
