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
using iTextSharp.text;
using iTextSharp.text.pdf;
/*using Spire.Doc;
using Spire.Pdf;
using Spire.Doc.Documents;
using Spire.Doc.Fields;*/
using System.IO;

namespace QLCuaHangJuno
{
    public partial class ChiTietPhieuTH : Form
    {
        QuanLyCuaHangJunoContext db = new QuanLyCuaHangJunoContext();
        private string maPhieuTH;
        int index = 0;
        public ChiTietPhieuTH()
        {
            InitializeComponent();
        }

        public ChiTietPhieuTH(string a) : this()
        {
            maPhieuTH = a;
            lbMaPTH.Text = a;
            var pth = (from p in db.PhieuTraHangs
                       where p.MaPhieuTra == a
                       select p).ToList();
            if (pth.Count > 0)
            {
                lbNgayNhap.Text = pth.FirstOrDefault().NgayLap.ToString("dd/MM/yyyy");
                lbMaHD.Text = pth.FirstOrDefault().MaHd;

                NhanVien nv = (from n in db.NhanViens
                               where n.MaNv == pth.FirstOrDefault().MaNv
                               select n).FirstOrDefault();
                lbTenNVTN.Text = nv.HoTenNv;
                lbMaNV.Text = nv.MaNv;
                lbTenNVHD.Text = nv.HoTenNv;

                HoaDonBanHang hd = (from h in db.HoaDonBanHangs
                                    where h.MaHd == pth.FirstOrDefault().MaHd
                                    select h).FirstOrDefault();

                KhachHang kh = (from k in db.KhachHangs
                                where k.MaKh == hd.MaKh
                                select k).FirstOrDefault();

                lbTenKh.Text = kh.HoTenKh;
                lbSDTKH.Text = kh.Sdt;
                lbDCKH.Text = kh.DiaChi;
                lbTenKH2.Text = kh.HoTenKh;
                SanPhamChiTiet spct = (from s1 in db.SanPhamChiTiets
                                       where s1.MaSpCt == pth.FirstOrDefault().MaSpCt
                                       select s1).FirstOrDefault();

                SanPham sp = (from s in db.SanPhams
                              where s.MaSp == spct.MaSp
                              select s).FirstOrDefault();


                listView1.Items.Add((index + 1).ToString());
                listView1.Items[index].SubItems.Add(sp.MaSp);
                listView1.Items[index].SubItems.Add(sp.TenSp);
                listView1.Items[index].SubItems.Add(hd.NgayBan.ToString("dd/MM/yyyy"));
                listView1.Items[index].SubItems.Add(pth.FirstOrDefault().LyDoTra);
                string formattedMoneyValue = String.Format("{0:C}", sp.DonGia);

                listView1.Items[index].SubItems.Add(formattedMoneyValue + " VND");
                index++;
            }
            else
            {
                MessageBox.Show("ERR: Không tìm thấy phiếu trả với vã bạn nhập !");
            }

        }
        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void ChiTietPhieuTH_Load(object sender, EventArgs e)
        {
            /*PhieuTraHang pth = (from p in db.PhieuTraHangs
                                where p.MaPhieuTra == this.maPhieuTH
                                select p).FirstOrDefault();

            lbNgayNhap.Text = pth.NgayLap.ToString("dd/MM/yyyy");
            lbMaHD.Text = pth.MaHd;
            
            NhanVien nv = (from n in db.NhanViens
                           where n.MaNv == pth.MaNv
                           select n).FirstOrDefault();
            lbTenNVTN.Text = nv.HoTenNv;
            lbMaNV.Text = nv.MaNv;
            HoaDonBanHang hd = (from h in db.HoaDonBanHangs
                           where h.MaHd == pth.MaHd
                           select h).FirstOrDefault();

            KhachHang kh = (from k in db.KhachHangs
                            where k.MaKh == hd.MaKh
                            select k).FirstOrDefault();

            lbTenKh.Text = kh.HoTenKh;
            lbSDTKH.Text = kh.Sdt;
            lbDCKH.Text = kh.DiaChi;
            lbTenKH2.Text = kh.HoTenKh;*/
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            try
            {
                string filename = "D:/LT_WINDOW/BTL/QLCuaHangJuno/PhieuTraHang/" + lbMaPTH.Text + ".pdf";
                iTextSharp.text.Document document = new Document();
                PdfWriter.GetInstance(document, new FileStream(filename, FileMode.Create));
                document.Open();
                Paragraph p = new Paragraph("PHIẾU TIẾP NHẬN TRẢ HÀNG\n"
                + "Mã phiếu : " + lbMaPTH.Text + "\t\t Ngày lập : " + lbNgayNhap.Text + "\n"
                + "Mã hóa đơn : " + lbMaHD.Text + "\n\n"
                + "Thông tin khách hàng" + "\n"
                + "Họ tên KH : " + lbTenKh.Text + "\n"
                + "SDT KH : " + lbSDTKH.Text + "\n"
                + "Địa chỉ KH : " + lbDCKH.Text + "\n\n"
                + "Thông tin nhân viên tiếp nhận" + "\n"
                + "Mã NV : " + lbMaNV.Text + "\n"
                + "Họ tên NV : " + lbTenNVHD.Text + "\n\n"
                + "Thông tin sản phẩm trả lại\n\n"
                + "STT       Mã sản phẩm     Tên sản phẩm                 Ngày mua        Lý do                               Hoàn tiền          \n"
                );
                string tmp = "";
                foreach (ListViewItem li in listView1.Items)
                {

                    foreach (ListViewItem.ListViewSubItem lsi in li.SubItems)
                    {
                        tmp += lsi.Text + "              ";
                    }
                    tmp += "\n";

                }
                Paragraph p1 = new Paragraph(tmp);

                document.Add(p);
                document.Add(p1);
                document.Close();

                MessageBox.Show("SCC: Xuất file thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERR: Lỗi khi xuất file!" + ex.Message);
            }

        }
    }
}
