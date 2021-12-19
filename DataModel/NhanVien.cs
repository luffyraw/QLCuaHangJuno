using System;
using System.Collections.Generic;

#nullable disable

namespace QLCuaHangJuno.DataModel
{
    public partial class NhanVien
    {
        public NhanVien()
        {
            HoaDonBanHangs = new HashSet<HoaDonBanHang>();
            PhieuBaoHanhs = new HashSet<PhieuBaoHanh>();
            PhieuNhapHangs = new HashSet<PhieuNhapHang>();
            PhieuTraHangs = new HashSet<PhieuTraHang>();
        }

        public string MaNv { get; set; }
        public string HoTenNv { get; set; }
        public string GioiTinh { get; set; }
        public DateTime NgaySinh { get; set; }
        public string Cmt { get; set; }
        public string DiaChi { get; set; }
        public string Sdt { get; set; }
        public string Email { get; set; }
        public string TenTk { get; set; }
        public string MatKhau { get; set; }
        public string Quyen { get; set; }
        public bool TrangThai { get; set; }

        public virtual ICollection<HoaDonBanHang> HoaDonBanHangs { get; set; }
        public virtual ICollection<PhieuBaoHanh> PhieuBaoHanhs { get; set; }
        public virtual ICollection<PhieuNhapHang> PhieuNhapHangs { get; set; }
        public virtual ICollection<PhieuTraHang> PhieuTraHangs { get; set; }
    }
}
