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
    public partial class frmChiTietPhieuNhap : Form
    {
        QuanLyCuaHangJunoContext db = new QuanLyCuaHangJunoContext();
        public frmChiTietPhieuNhap()
        {
            InitializeComponent();
        }

        private void frmChiTietPhieuNhap_Load(object sender, EventArgs e)
        {
            var phieu = (from ph in db.PhieuNhapHangs
                         where ph.MaPhNhap == this.Tag.ToString()
                         select new
                         {
                             MaPhNhap = ph.MaPhNhap,
                             MaPhieuDat = ph.MaPhieuDat,
                             NgayNhap = ph.NgayNhap.ToString("dd-MM-yyyy HH:mm:ss"),
                             NguoiNhap = ph.MaNvNavigation.HoTenNv,
                             NguoiGiao = ph.NguoiGiao
                         }).FirstOrDefault();
            lblMaPhieuN.Text = phieu.MaPhNhap;
            lblMaPhieuD.Text = phieu.MaPhieuDat;
            lblNgayLap.Text = phieu.NgayNhap;
            lblNguoiNhap.Text = phieu.NguoiNhap;
            lblNguoiGiao.Text = phieu.NguoiGiao;
            var sps = from spn in db.NhapHangSanPhams
                      where spn.MaPhNhap == this.Tag.ToString()
                      select new
                      {
                          MaSpCt = spn.MaSpCt,
                          SoLuongNhap = spn.SoLuongNhap
                      };
            var sanPhamNhaps = from spct in db.SanPhamChiTiets
                               join spn in sps on spct.MaSpCt equals spn.MaSpCt
                               select new
                               {
                                   MaSp = spct.MaSp,
                                   TenSp = spct.MaSpNavigation.TenSp,
                                   Mau = spct.MaMauNavigation.Mau1,
                                   KichCo = spct.MaKcNavigation.KichCo1,
                                   DonGia = spct.MaSpNavigation.DonGia,
                                   SoLuongNhap = spn.SoLuongNhap,
                                   ThanhTien = spct.MaSpNavigation.DonGia * spn.SoLuongNhap
                               };

            dgvSanPhamNhap.DataSource = sanPhamNhaps.ToList();
            for (int i = 0; i < dgvSanPhamNhap.Rows.Count; i++)
            {
                dgvSanPhamNhap.Rows[i].Cells[0].Value = i + 1;
            }
            int tongSL = sanPhamNhaps.Sum(x => x.SoLuongNhap);
            decimal tongTien = sanPhamNhaps.Sum(x => x.ThanhTien);
            lblTongSL.Text = String.Format("{0:n0}", tongSL);
            lblTongTien.Text = String.Format("{0:n0}", tongTien);
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
            e.Graphics.DrawImage(memoryimg, this.panelPrint.Location.X, this.panelPrint.Location.Y); 

        }
    }
}
