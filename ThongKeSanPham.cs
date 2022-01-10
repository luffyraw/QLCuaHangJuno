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

            TKSP(DateTime.Now.Year);
        }
        QuanLyCuaHangJunoContext db = new QuanLyCuaHangJunoContext();
        private void TKSP(int nam)
        {
            for (int i = listView1.Items.Count - 1; i > 0; i--)
            {

                listView1.Items[i].Remove();

            }
            List<SanPhamChiTiet> listsp = (from item in db.SanPhamChiTiets select item).ToList();
            lb_tongsp.Text = "Tổng số sản phẩm: " + listsp.Count();


            listView1.Items[0].Text = "1";
            for (int i = 2; i <= 14; i++)
            {
                listView1.Items[0].SubItems.Add(i.ToString());
            }
            var listhd = from hd in db.HoaDonBanHangs
                         join ctsp in db.HoaDonBanHangSanPhams on hd.MaHd equals ctsp.MaHd
                         where hd.NgayBan.Year == nam
                         select new
                         {
                             thang = hd.NgayBan.Month,
                             mact = ctsp.MaSpCt,
                             sl = ctsp.SoLuongBan
                         };

            List<SanPhamChiTiet> listct = (from item in db.SanPhamChiTiets select item).ToList();
            int stt = 1;
            foreach (SanPhamChiTiet item in listct.ToList())
            {
                string msp = (from sp in db.SanPhams where sp.MaSp == item.MaSp select sp.MaSp).FirstOrDefault();
                listView1.Items.Add(msp);
                listView1.Items[stt].SubItems.Add(item.MaSpCt);

                for (int i = 1; i <= 12; i++)
                {
                    int sosp = 0;
                    foreach (var hd in listhd.ToList())
                    {
                        if (hd.thang == i && hd.mact == item.MaSpCt)
                            sosp += hd.sl;
                    }
                    listView1.Items[stt].SubItems.Add(sosp.ToString());
                }
                stt++;
            }



        }

        private void btn_tim_Click(object sender, EventArgs e)
        {
            TKSP(int.Parse(cb_year.Text));

        }
    }
}
