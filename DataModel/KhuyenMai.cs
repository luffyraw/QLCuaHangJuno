using System;
using System.Collections.Generic;

#nullable disable

namespace QLCuaHangJuno.DataModel
{
    public partial class KhuyenMai
    {
        public KhuyenMai()
        {
            KhuyenMaiSanPhams = new HashSet<KhuyenMaiSanPham>();
        }

        public string MaKm { get; set; }
        public DateTime NgayBatDau { get; set; }
        public DateTime NgayKetThuc { get; set; }

        public virtual ICollection<KhuyenMaiSanPham> KhuyenMaiSanPhams { get; set; }
    }
}
