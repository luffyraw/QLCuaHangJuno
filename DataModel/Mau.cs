using System;
using System.Collections.Generic;

#nullable disable

namespace QLCuaHangJuno.DataModel
{
    public partial class Mau
    {
        public Mau()
        {
            SanPhamChiTiets = new HashSet<SanPhamChiTiet>();
        }

        public string MaMau { get; set; }
        public string Mau1 { get; set; }

        public virtual ICollection<SanPhamChiTiet> SanPhamChiTiets { get; set; }
    }
}
