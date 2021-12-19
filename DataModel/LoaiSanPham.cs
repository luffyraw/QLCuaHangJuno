using System;
using System.Collections.Generic;

#nullable disable

namespace QLCuaHangJuno.DataModel
{
    public partial class LoaiSanPham
    {
        public LoaiSanPham()
        {
            SanPhams = new HashSet<SanPham>();
        }

        public string MaLoaiSp { get; set; }
        public string TenLoaiSp { get; set; }

        public virtual ICollection<SanPham> SanPhams { get; set; }
    }
}
