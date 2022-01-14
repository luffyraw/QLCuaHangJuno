using QLCuaHangJuno.DataModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLCuaHangJuno
{
    public partial class XemHoaDon : Form
    {
        QuanLyCuaHangJunoContext db = new QuanLyCuaHangJunoContext();
        public XemHoaDon()
        {
            InitializeComponent();
        }

        private void XemHoaDon_Load(object sender, EventArgs e)
        {
            HienThiDGV();
        }
        private void HienThiDGV()
        {
            var listhd = from item in db.HoaDonBanHangs
                         join hdsp in db.HoaDonBanHangSanPhams on item.MaHd equals hdsp.MaHd
                         join spct in db.SanPhamChiTiets on hdsp.MaSpCt equals spct.MaSpCt
                         join sp in db.SanPhams on spct.MaSp equals sp.MaSp
                         join kh in db.KhachHangs on item.MaKh equals kh.MaKh
                         join nv in db.NhanViens on item.MaNv equals nv.MaNv
                         select new
                         {
                             mahd = item.MaHd,
                             nhanvien = nv.HoTenNv,
                             ngaylap = item.NgayBan.ToString("dd/MM/yyyy"),
                             khachhang = kh.HoTenKh,
                         };
            listhd = listhd.Distinct();

            dgv_dshd.DataSource = listhd.ToList();


        }

        private void dgv_dshd_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int numrow;
            numrow = e.RowIndex;
            if (numrow >= 0)
            {
                txt_mahd.Text = dgv_dshd.Rows[numrow].Cells[0].Value.ToString();
                txt_nhanvien.Text = dgv_dshd.Rows[numrow].Cells[1].Value.ToString();
                txt_ngay.Text = dgv_dshd.Rows[numrow].Cells[2].Value.ToString();
                txt_khachhang.Text = dgv_dshd.Rows[numrow].Cells[3].Value.ToString();

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var listhd = from item in db.HoaDonBanHangs
                         join hdsp in db.HoaDonBanHangSanPhams on item.MaHd equals hdsp.MaHd
                         join spct in db.SanPhamChiTiets on hdsp.MaSpCt equals spct.MaSpCt
                         join sp in db.SanPhams on spct.MaSp equals sp.MaSp
                         join kh in db.KhachHangs on item.MaKh equals kh.MaKh
                         join nv in db.NhanViens on item.MaNv equals nv.MaNv
                         where item.MaHd.Contains(txt_mahd.Text) 
                         && nv.HoTenNv.Contains(txt_nhanvien.Text)
                         && kh.HoTenKh.Contains(txt_khachhang.Text)
                         select new
                         {
                             mahd = item.MaHd,
                             nhanvien = nv.HoTenNv,
                             ngaylap = item.NgayBan.ToString("dd/MM/yyyy"),
                             khachhang = kh.HoTenKh,
                         };

            listhd = listhd.Distinct();       
            dgv_dshd.DataSource = listhd.ToList();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txt_mahd.Text = "";
            txt_khachhang.Text = "";
            txt_nhanvien.Text = "";
            txt_ngay.Text = DateTime.Now.ToString("dd/MM/yyyy");
            lb_mahd.Text = "";
            lb_manv.Text = "";
            lb_nv.Text = "";
            lb_ngaylap.Text = "";
            lb_diachi.Text = "";
            lb_khachhang.Text = "";
            lb_sdt.Text = "";
            HienThiDGV();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var hd = (from item in db.HoaDonBanHangs where item.MaHd == txt_mahd.Text select item).FirstOrDefault();
            lb_mahd.Text = txt_mahd.Text;
            lb_manv.Text = hd.MaNv;
            lb_nv.Text = txt_nhanvien.Text;
            lb_ngaylap.Text = txt_ngay.Text;
            KhachHang kh = (from item in db.KhachHangs where item.MaKh == hd.MaKh select item).FirstOrDefault();
            lb_diachi.Text = kh.DiaChi;
            lb_khachhang.Text = kh.HoTenKh;
            lb_sdt.Text = kh.Sdt;
            var listsp = from item in db.HoaDonBanHangSanPhams
                         join spct in db.SanPhamChiTiets on item.MaSpCt equals spct.MaSpCt
                         join sp in db.SanPhams on spct.MaSp equals sp.MaSp
                         where item.MaHd == txt_mahd.Text
                         select new
                         {
                             masp = sp.MaSp,
                             mact = spct.MaSpCt,
                             sl = item.SoLuongBan,
                             dg = sp.DonGia
                         };
            double tongtien = 0;
            foreach (var item in listsp)
            {
                tongtien += double.Parse(item.sl.ToString()) * double.Parse(item.dg.ToString());
            }
            lb_tongtien.Text = tongtien.ToString() + "VND";
            dgv_dssp.DataSource = listsp.ToList();
        }
    }
}
