using System;
using System.Collections.Generic;

#nullable disable

namespace QLCuaHangJuno.DataModel
{
    public partial class KichCo
    {
        public KichCo()
        {
            SanPhamChiTiets = new HashSet<SanPhamChiTiet>();
        }

        public string MaKc { get; set; }
        public string KichCo1 { get; set; }

        public virtual ICollection<SanPhamChiTiet> SanPhamChiTiets { get; set; }
    }
}
