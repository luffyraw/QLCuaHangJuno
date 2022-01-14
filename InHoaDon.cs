using QLCuaHangJuno.DataModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLCuaHangJuno
{
    public partial class InHoaDon : Form
    {
        public NhanVien nv;
        public HoaDonBanHang hd;
        public string TenKH;
        public string sdt;
        public string diachi;
        public List<HoaDonBanHangSanPham> listsp;
        public string tongtien;
        public string giamgia;
        public string thanhtien;
        QuanLyCuaHangJunoContext db = new QuanLyCuaHangJunoContext();
        public InHoaDon()
        {
            InitializeComponent();
        }

        private void InHoaDon_Load(object sender, EventArgs e)
        {
            lb_mahd.Text = hd.MaHd;
            lb_ngaylap.Text = hd.NgayBan.ToString();

            lb_manv.Text = nv.MaNv;
            lb_hotennv.Text = nv.HoTenNv;

            lb_hotenkh.Text = TenKH;
            lb_sdt.Text = sdt;
            lb_diachi.Text = diachi;

            lb_tongtien.Text = tongtien;
            lb_gghd.Text = giamgia;
            lb_thanhtien.Text = thanhtien;

            var list = from item in listsp
                       join spct in db.SanPhamChiTiets on item.MaSpCt equals spct.MaSpCt
                       join sp in db.SanPhams on spct.MaSp equals sp.MaSp
                       join mausac in db.Maus on spct.MaMau equals mausac.MaMau
                       join kickco in db.KichCos on spct.MaKc equals kickco.MaKc
                       select new
                       {
                           masp = spct.MaSp,
                            tensp = sp.TenSp + " " + mausac.Mau1 + " " + kickco.KichCo1,
                            sl = item.SoLuongBan,
                            dg = sp.DonGia,
                            tt = double.Parse(item.SoLuongBan.ToString()) * double.Parse(sp.DonGia.ToString())
                       };

            dataGridView1.DataSource = list.ToList();
        }

        private void Print(Panel pnl)
        {
            PrinterSettings ps = new PrinterSettings();
            panelPrint = pnl;
            getprintarea(pnl);
            printPreviewDialog1.Document = printDocument1;
            printDocument1.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage);
            printPreviewDialog1.ShowDialog();


        }

        private Bitmap memoryImg;
        private void getprintarea(Panel pnl)
        {
            memoryImg = new Bitmap(pnl.Width, pnl.Height);
            pnl.DrawToBitmap(memoryImg, new Rectangle(0, 0, pnl.Width, pnl.Height));

        }


        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            Rectangle pagearea = e.PageBounds;
            e.Graphics.DrawImage(memoryImg, (pagearea.Width / 7) - (this.panelPrint.Width / 7), this.panelPrint.Location.Y);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Print(this.panelPrint);

        }
    }
}
