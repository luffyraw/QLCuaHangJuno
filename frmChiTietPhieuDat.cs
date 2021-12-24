using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLCuaHangJuno.DataModel;
using System.Drawing.Printing;

namespace QLCuaHangJuno
{
    public partial class frmChiTietPhieuDat : Form
    {
        QuanLyCuaHangJunoContext db = new QuanLyCuaHangJunoContext();
        public frmChiTietPhieuDat()
        {
            InitializeComponent();
        }

        private void frmChiTietPhieuDat_Load(object sender, EventArgs e)
        {
            var phieu = (from ph in db.PhieuDatHangs
                         where ph.MaPhieuDat == this.Tag.ToString()
                         select ph).FirstOrDefault();
            lblMaPhieuD.Text = phieu.MaPhieuDat;
            lblNgayLap.Text = phieu.NgayDat.ToString("dd-MM-yyyy HH:mm:ss");
            lblThoiHanGiaoHang.Text = phieu.ThoiHanGiaoHang.ToString("dd-MM-yyyy");
            var sps = from spd in db.DatHangSanPhams
                      where spd.MaPhieuDat == this.Tag.ToString()
                      select new
                      {
                          MaSpCt = spd.MaSpCt,
                          SoLuongDat = spd.SoLuongDat
                      };
            var sanPhamDats = from spct in db.SanPhamChiTiets
                              join spd in sps on spct.MaSpCt equals spd.MaSpCt
                              select new
                              {
                                  MaSp = spct.MaSp,
                                  TenSp = spct.MaSpNavigation.TenSp,
                                  Mau = spct.MaMauNavigation.Mau1,
                                  KichCo = spct.MaKcNavigation.KichCo1,
                                  SoLuongDat = spd.SoLuongDat
                              };
            dgvSanPhamDat.DataSource = sanPhamDats.ToList();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
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
        
        private Bitmap memoryimg;
        private void getprintarea(Panel pnl)
        {
            memoryimg = new Bitmap(pnl.Width, pnl.Height);
            pnl.DrawToBitmap(memoryimg, new Rectangle(0, 0, pnl.Width, pnl.Height));

        }
        private void btnPrint_Click(object sender, EventArgs e)
        {
            Print(this.panelPrint);
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            Rectangle pagearea = e.PageBounds;
            e.Graphics.DrawImage(memoryimg, (pagearea.Width / 2) - (this.panelPrint.Width / 2), this.panelPrint.Location.Y);

        }
    }
}
