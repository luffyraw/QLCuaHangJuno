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
    public partial class ChiTietPhieuDoi : Form
    {
        QuanLyCuaHangJunoContext db = new QuanLyCuaHangJunoContext();
        private string maPhieuDoi;
        int index = 0;
        int index1 = 0;
        public ChiTietPhieuDoi()
        {
            InitializeComponent();
        }

        public ChiTietPhieuDoi(string a) : this()
        {
            maPhieuDoi = a;
            lbMaPhieuDoi.Text = a;
            var PD = (from pd in db.PhieuDoiHangs
                      where pd.MaPhieuDoi == a
                      select pd).ToList();
            if (PD.Count > 0)
            {
                lbNgayLap.Text = PD.FirstOrDefault().NgayLap.ToString("dd/MM/yyyy HH:mm:ss");
                lbMaHD.Text = PD.FirstOrDefault().MaHd;
                var info = System.Globalization.CultureInfo.GetCultureInfo("vi-VN");
                lbTienThua.Text = String.Format(info,"{0:C}",PD.FirstOrDefault().TienThua);
                lbTienThuThem.Text = String.Format(info,"{0:C}", PD.FirstOrDefault().TienThuLai);
                lbLiDoDoi.Text = PD.FirstOrDefault().LyDoDoi;

                NhanVien nv = (from n in db.NhanViens
                               where n.MaNv == PD.FirstOrDefault().MaNv
                               select n).FirstOrDefault();
                lbMaNV.Text = nv.MaNv;
                lbTenNV.Text = nv.HoTenNv;
                lbTenNVKy.Text = nv.HoTenNv;


                HoaDonBanHang hd = (from h in db.HoaDonBanHangs
                                    where h.MaHd == PD.FirstOrDefault().MaHd
                                    select h).FirstOrDefault();

                KhachHang kh = (from k in db.KhachHangs
                                where k.MaKh == hd.MaKh
                                select k).FirstOrDefault();

                lbTenKH.Text = kh.HoTenKh;
                lbSDTKH.Text = kh.Sdt;
                lbDCKH.Text = kh.DiaChi;
                lbTenKHKy.Text = kh.HoTenKh;

                var SPCTPDHD = (from spctpdhd in db.PhieuDoiSanPhamHds
                                where spctpdhd.MaPd == a
                                select spctpdhd).ToList();

                var SPCTPDD = (from spctpdd in db.PhieuDoiSanPhamDois
                               where spctpdd.MaPd == a
                               select spctpdd).ToList();

                var SP = (from sp in db.SanPhams
                          select sp).ToList();

                foreach(var i in SPCTPDHD)
                {
                    listView1.Items.Add((index + 1).ToString());
                    listView1.Items[index].SubItems.Add(i.MaSpct);
                    var spct = (from spct1 in db.SanPhamChiTiets
                                where spct1.MaSpCt == i.MaSpct
                                select spct1).FirstOrDefault();
                    foreach(var i1 in SP)
                    {
                        if(i1.MaSp == spct.MaSp)
                        {
                            listView1.Items[index].SubItems.Add(i1.TenSp);
                            break;
                        }
                    }
                    listView1.Items[index].SubItems.Add((1).ToString());
                    index++;
                }

                foreach (var i in SPCTPDD)
                {
                    listView2.Items.Add((index1 + 1).ToString());
                    listView2.Items[index1].SubItems.Add(i.MaSpct);
                    var spct = (from spct1 in db.SanPhamChiTiets
                                where spct1.MaSpCt == i.MaSpct
                                select spct1).FirstOrDefault();
                    foreach (var i1 in SP)
                    {
                        if (i1.MaSp == spct.MaSp)
                        {
                            listView2.Items[index1].SubItems.Add(i1.TenSp);
                            break;
                        }
                    }
                    listView2.Items[index1].SubItems.Add((1).ToString());
                    index1++;
                }

            }

        }

            private void ChiTietPhieuDoi_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

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
        private void btnExport_Click(object sender, EventArgs e)
        {
            Print(this.panelPrint);
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            Rectangle pagearea = e.PageBounds;
            e.Graphics.DrawImage(memoryImg, (pagearea.Width / 7) - (this.panelPrint.Width / 7), this.panelPrint.Location.Y);
        }
    }
}
