using System;
using System.Collections.Generic;

#nullable disable

namespace QLCuaHangJuno.DataModel
{
    public partial class SanPhamChiTiet
    {
        public string MaSpCt { get; set; }
        public string MaSp { get; set; }
        public string MaMau { get; set; }
        public string MaKc { get; set; }
        public int SoLuongTon { get; set; }

        public virtual KichCo MaKcNavigation { get; set; }
        public virtual Mau MaMauNavigation { get; set; }
        public virtual SanPham MaSpNavigation { get; set; }
    }
}
