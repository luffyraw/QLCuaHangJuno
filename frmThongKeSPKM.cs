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
    public partial class frmThongKeSPKM : Form
    {
        public frmThongKeSPKM()
        {
            InitializeComponent();
        }

        private void frmThongKeSPKM_Load(object sender, EventArgs e)
        {
            TKSP(DateTime.Now.Year);
            QuanLyCuaHangJunoContext db = new QuanLyCuaHangJunoContext();
            var tk = from item in db.HoaDonBanHangs
                     join s in db.HoaDonBanHangSanPhams on item.MaHd equals s.MaHd
                     join d in db.SanPhamChiTiets on s.MaSpCt equals d.MaSpCt
                     join g in db.SanPhams on d.MaSp equals g.MaSp
                     join k in db.KhuyenMaiSanPhams on g.MaSp equals k.MaSp
                     where item.NgayBan.Year == DateTime.Now.Year && s.MaSpCtNavigation.MaSp == k.MaSp
                     select new
                     {
                         thang = item.NgayBan.Month,
                         gia = g.DonGia * s.SoLuongBan,
                         sl = s.SoLuongBan
                     };

            double tongsp = 0, tongdt = 0;
            string[] tksp = new string[12];
            string[] tkdt = new string[12];
            string[] tkkm = new string[12];
            if (tk != null)
            {
                for (int i = 1; i <= 12; i++)
                {
                    int sosp = 0;
                    double dt = 0;
                    tongsp += sosp;
                    tongdt += dt;
                    tksp[i - 1] = sosp.ToString();
                    tkdt[i - 1] = dt.ToString();

                }
            }

            //Hiển thị tổng
            lb_tongsp.Text = "Tổng số sản phẩm đã bán: " + tongsp;
            lb_doanhthu.Text = "Tổng doanh thu: " + tongdt + " VND";


            //THống kê số sản phẩm
            listView1.Items[0].Text = "Số sản phẩm";
            for (int i = 0; i < 12; i++)
            {
                listView1.Items[0].SubItems.Add(tksp[i]);
            }
            //THống kê doanh thu
            listView1.Items.Add("Doanh thu");
            for (int i = 0; i < 12; i++)
            {
                listView1.Items[1].SubItems.Add(tkdt[i]);
            }
        }

        private void btn_tim_Click(object sender, EventArgs e)
        {
            TKSP(int.Parse(cb_year.Text));
            label1.Text = "Thống kê sản phẩm khuyễn mãi năm " + cb_year.Text;
            for (int i = 0; i < listView1.Items.Count; i++)
            {
                if (listView1.Items[i].Selected)
                {
                    listView1.Items[i].Remove();
                    i--;
                }
            }
            QuanLyCuaHangJunoContext db = new QuanLyCuaHangJunoContext();
            var tk = from item in db.HoaDonBanHangs
                     join s in db.HoaDonBanHangSanPhams on item.MaHd equals s.MaHd
                     join d in db.SanPhamChiTiets on s.MaSpCt equals d.MaSpCt
                     join g in db.SanPhams on d.MaSp equals g.MaSp
                     join k in db.KhuyenMaiSanPhams on g.MaSp equals k.MaSp
                     where item.NgayBan.Year == int.Parse(cb_year.Text) && s.MaSpCtNavigation.MaSp == k.MaSp
                     select new
                     {
                         thang = item.NgayBan.Month,
                         gia = g.DonGia * s.SoLuongBan,
                         sl = s.SoLuongBan
                     };
            double tongsp = 0, tongdt = 0;

            string[] tksp = new string[12];
            string[] tkdt = new string[12];

            for (int i = 1; i <= 12; i++)
            {
                int sosp = 0;
                double dt = 0;
                foreach (var item in tk.ToList())
                {
                    if (item.thang == i)
                    {
                        sosp += item.sl;
                        dt += ((double)item.gia);
                    }
                }
                tongsp += sosp;
                tongdt += dt;
                tksp[i - 1] = sosp.ToString();
                tkdt[i - 1] = dt.ToString();

            }
            //Hiển thị tổng
            lb_tongsp.Text = "Tổng số sản phẩm đã bán: " + tongsp;
            lb_doanhthu.Text = "Tổng doanh thu: " + tongdt + " VND";
            //THống kê số sản phẩm

            for (int i = 0; i < 12; i++)
            {
                listView1.Items[0].SubItems[i + 1].Text = tksp[i];

            }
            //THống kê doanh thu
            for (int i = 0; i < 12; i++)
            {
                listView1.Items[1].SubItems[i + 1].Text = tkdt[i];
            }
        }
        private void TKSP(int nam)
        {
            QuanLyCuaHangJunoContext db = new QuanLyCuaHangJunoContext();
            for (int i = listView2.Items.Count - 1; i > 0; i--)
            {

                listView2.Items[i].Remove();

            }
            List<KhuyenMaiSanPham> listsp = (from item in db.KhuyenMaiSanPhams select item).ToList();
            label3.Text = "Tổng số sản phẩm: " + listsp.Count();

            var listhd = from hd in db.KhuyenMaiSanPhams
                         join ctsp in db.KhuyenMais on hd.MaKm equals ctsp.MaKm
                         where hd.MaKmNavigation.NgayBatDau.Year == nam
                         select new
                         {
                             thang = hd.MaKmNavigation.NgayBatDau.Month,
                             mact = hd.MaSp,
                             sl = 1
                         };

            int stt = 1;
            foreach (var item in listsp.ToList())
            {
                string msp = (from sp in db.KhuyenMais where sp.MaKm == item.MaKm select item.MaSp).FirstOrDefault();
                listView2.Items.Add(msp);
                listView2.Items[stt].SubItems.Add(item.MaKm);
                for (int i = 1; i <= 12; i++)
                {
                    int sosp = 0;
                    foreach (var hd in listhd.ToList())
                    {
                        if (hd.thang == i && hd.mact == item.MaSp)
                            sosp += hd.sl;
                    }
                    listView2.Items[stt].SubItems.Add(sosp.ToString());
                }
                stt++;
            }

        }
    }
}
