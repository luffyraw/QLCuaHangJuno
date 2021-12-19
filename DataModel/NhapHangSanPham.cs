using System;
using System.Collections.Generic;

#nullable disable

namespace QLCuaHangJuno.DataModel
{
    public partial class NhapHangSanPham
    {
        public string MaSp { get; set; }
        public string MaPhNhap { get; set; }
        public int SoLuongNhap { get; set; }

        public virtual PhieuNhapHang MaPhNhapNavigation { get; set; }
        public virtual SanPham MaSpNavigation { get; set; }
    }
}
