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
    public partial class ThongKeSanPham : Form
    {
        public ThongKeSanPham()
        {
            InitializeComponent();
        }

        private void ThongKeSanPham_Load(object sender, EventArgs e)
        {

        }
        QuanLyCuaHangJunoContext db = new QuanLyCuaHangJunoContext();
        private void TKNhanVien(int thang, int nam)
        {
            for (int i = listView1.Items.Count - 1; i > 0; i--)
            {

                listView1.Items[i].Remove();

            }
            List<SanPhamChiTiet> listsp = (from item in db.SanPhamChiTiets select item).ToList();
            lb_tongsp.Text = "Tổng số sản phẩm: " + listsp.Count();


            listView1.Items[0].Text = "1";
            for (int i =2; i<=12;i++)
            {
                listView1.Items[0].SubItems.Add(i.ToString());
            }
            var listhd = from hd in db.HoaDonBanHangs
                         join ctsp in db.HoaDonBanHangSanPhams on hd.MaHd equals ctsp.MaHd
                         join sp in db.SanPhams on ctsp.MaSpCt equals sp.MaSp
                         where hd.NgayBan.Year == nam && hd.NgayBan.Month == thang
                         select new
                         {
                             ngayban = hd.NgayBan,
                             masp = sp.MaSp,
                             mact = ctsp.MaSpCt,
                             sl = ctsp.SoLuongBan
                         };

            List<SanPhamChiTiet> listct = (from item in db.SanPhamChiTiets select item).ToList();
            foreach (SanPhamChiTiet item in listct)
            {                
                
            }



        }
    }
}
