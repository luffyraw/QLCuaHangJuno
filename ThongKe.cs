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
            var tk = from item in db.HoaDonBanHangs
                     join s in db.HoaDonBanHangSanPhams on item.MaHd equals s.MaHd
                     join d in db.SanPhamChiTiets on s.MaSpCt equals d.MaSpCt
                     join g in db.SanPhams on d.MaSp equals g.MaSp
                     where item.NgayBan.Year == DateTime.Now.Year
                     select new
                     {
                         thang = item.NgayBan.Month,
                         gia = g.DonGia * s.SoLuongBan,
                         sl = s.SoLuongBan
                     };
            double tonghd=0, tongsp=0, tongdt=0;
            string[] tkhd = new string[12];
            string[] tksp = new string[12];
            string[] tkdt = new string[12];

            for (int i = 1; i <= 12; i++)
            {
                int sohd = 0;
                int sosp = 0;
                double dt = 0;
                foreach (var item in tk.ToList())
                {
                    if (item.thang == i)
                    {
                        sohd++;
                        sosp += item.sl;
                        dt += ((double)item.gia);
                    }
                }
                tonghd += sohd;
                tongsp += sosp;
                tongdt += dt;
                tkhd[i - 1] = sohd.ToString();
                tksp[i - 1] = sosp.ToString();
                tkdt[i - 1] = dt.ToString();

            }
            //Hiển thị tổng
            lb_tongdh.Text = "Tổng số hóa đơn: " + tonghd;
            lb_tongsp.Text = "Tổng số sản phẩm: " + tongsp;
            lb_doanhthu.Text = "Tổng doanh thu: " + tongdt +" VND";
            //THống kê số hóa đơn
            listView1.Items[0].Text = "Hóa đơn";
            for (int i = 0; i < 12; i++)
            {
                listView1.Items[0].SubItems.Add(tkhd[i]);
            }
            //THống kê số sản phẩm
      
            listView1.Items.Add("Số sản phẩm");
            for (int i = 0; i < 12; i++)
            {
                listView1.Items[1].SubItems.Add(tksp[i]);
            }
            //THống kê doanh thu
            listView1.Items.Add("Doanh thu");
            for (int i = 0; i < 12; i++)
            {
                listView1.Items[2].SubItems.Add(tkdt[i]);
            }

        }

        private void btn_tim_Click(object sender, EventArgs e)
        {
            label1.Text = "Báo cáo tài chính năm " + cb_year.Text;
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
                     where item.NgayBan.Year == int.Parse(cb_year.Text)
                     select new
                     {
                         thang = item.NgayBan.Month,
                         gia = g.DonGia * s.SoLuongBan,
                         sl = s.SoLuongBan
                     };
            double tonghd = 0, tongsp = 0, tongdt = 0;

            string[] tkhd = new string[12];
            string[] tksp = new string[12];
            string[] tkdt = new string[12];

            for (int i = 1; i <= 12; i++)
            {
                int sohd = 0;
                int sosp = 0;
                double dt = 0;
                foreach (var item in tk.ToList())
                {
                    if (item.thang == i)
                    {
                        sohd++;
                        sosp += item.sl;
                        dt += ((double)item.gia);
                    }
                }
                tonghd += sohd;
                tongsp += sosp;
                tongdt += dt;
                tkhd[i - 1] = sohd.ToString();
                tksp[i - 1] = sosp.ToString();
                tkdt[i - 1] = dt.ToString();

            }
            //Hiển thị tổng
            lb_tongdh.Text = "Tổng số hóa đơn: " + tonghd;
            lb_tongsp.Text = "Tổng số sản phẩm: " + tongsp;
            lb_doanhthu.Text = "Tổng doanh thu: " + tongdt + " VND";
            //THống kê số hóa đơn
            for (int i = 0; i < 12; i++)
            {
                listView1.Items[0].SubItems[i + 1].Text = tkhd[i];
            }
            //THống kê số sản phẩm

            for (int i = 0; i < 12; i++)
            {
                listView1.Items[1].SubItems[i + 1].Text = tksp[i];

            }
            //THống kê doanh thu
            for (int i = 0; i < 12; i++)
            {
                listView1.Items[2].SubItems[i + 1].Text = tkdt[i];
            }
        }

        private void dtp_thangnam_ValueChanged(object sender, EventArgs e)
        {

        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
