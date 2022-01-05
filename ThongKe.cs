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
    public partial class ThongKe : Form
    {
        public ThongKe()
        {
            InitializeComponent();
        }

        private void ThongKe_Load(object sender, EventArgs e)
        {
            QuanLyCuaHangJunoContext db = new QuanLyCuaHangJunoContext();
            var soHD = from item in db.HoaDonBanHangs
                       where item.NgayBan.Month == DateTime.Now.Month
                       && item.NgayBan.Year == DateTime.Now.Year
                       select item.MaHd;
         //   lb_hoadon.Text = soHD.Count().ToString();

            var sp = from item in db.HoaDonBanHangSanPhams
                     where soHD.Contains(item.MaHd)
                     select item;
            int sosp = 0;
            foreach (var item in sp)
            {
                sosp += item.SoLuongBan;
            }
           // lb_sosp.Text = sosp.ToString();
        }

        private void btn_tim_Click(object sender, EventArgs e)
        {
            QuanLyCuaHangJunoContext db = new QuanLyCuaHangJunoContext();
            var soHD = from item in db.HoaDonBanHangs
                       where item.NgayBan.Month == dtp_thangnam.Value.Month
                       && item.NgayBan.Year == dtp_thangnam.Value.Year
                       select item.MaHd;
         //   lb_hoadon.Text = soHD.Count().ToString();

            var sp = from item in db.HoaDonBanHangSanPhams
                     where soHD.Contains(item.MaHd)
                     select item;
            int sosp = 0;
            foreach (var item in sp)
            {
                sosp += item.SoLuongBan;
            }
         //   lb_sosp.Text = sosp.ToString();
        }
    }
}
