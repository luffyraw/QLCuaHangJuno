using System;
using System.Collections.Generic;

#nullable disable

namespace QLCuaHangJuno.DataModel
{
    public partial class PhieuDoiSanPhamHd
    {
        public int Id { get; set; }
        public string MaPd { get; set; }
        public string MaSpct { get; set; }
        public int Sl { get; set; }

        public virtual PhieuDoiHang MaPdNavigation { get; set; }
    }
}
