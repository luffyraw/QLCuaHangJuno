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
/*using iTextSharp.text;
using iTextSharp.text.pdf;*/
using Spire.Doc;
using Spire.Pdf;
using Spire.Doc.Documents;
using Spire.Doc.Fields;
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
            {/*
                string filename = "D:/LT_WINDOW/BTL/QLCuaHangJuno/PhieuTraHang/"+lbMaPTH.Text+".pdf";
                Document document = new Document();
                PdfWriter.GetInstance(document, new FileStream(filename, FileMode.Create));
                document.Open();
                Paragraph p = new Paragraph("PHIẾU TIẾP NHẬN TRẢ HÀNG\n"
                +"Mã phiếu : "+lbMaPTH.Text+ "\t\t Ngày lập : "+lbNgayNhap.Text+"\n"
                +"Mã hóa đơn : "+lbMaHD.Text+"\n\n"
                +"Thông tin khách hàng"+"\n"
                +"Họ tên KH : "+lbTenKh.Text+"\n"
                +"SDT KH : "+lbSDTKH.Text+"\n"
                +"Địa chỉ KH : "+lbDCKH.Text+"\n\n"
                +"Thông tin nhân viên tiếp nhận"+"\n"
                +"Mã NV : "+lbMaNV.Text+"\n"
                +"Họ tên NV : "+lbTenNVHD.Text+"\n\n"
                +"Thông tin sản phẩm trả lại\n\n"
                +"STT       Mã sản phẩm     Tên sản phẩm                 Ngày mua        Lý do                               Hoàn tiền          \n"
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
                document.Close();*/
                // Tạo đối tượng tài liệu (Document)
                string filename = "D:/LT_WINDOW/BTL/QLCuaHangJuno/PhieuTraHang/"+lbMaPTH.Text+".doc";
                Document doc = new Document();

                // Tạo đối tượng đoạn (Paragraph)
                Paragraph paragraph = doc.AddSection().AddParagraph();
                // Tạo văn bản (TextRange)
                Spire.Doc.Fields.TextRange text = paragraph.AppendText("PHIẾU TIẾP NHẬN TRẢ HÀNG\n");
                
                //text.CharacterFormat.Italic = true;  // in nghiêng
                //text.CharacterFormat.UnderlineStyle = UnderlineStyle.Single; // gạch chân
                text.CharacterFormat.FontSize = 18;
                text.CharacterFormat.Bold = true;                                   // kiểu in đậm
                paragraph.Format.TextAlignment = TextAlignment.Center;              // văn bản canh giữa 
                paragraph.Format.HorizontalAlignment = Spire.Doc.Documents.HorizontalAlignment.Center;  
                // đoạn canh giữa                                                                                         
                //paragraph.Format.HorizontalAlignment = HorizontalAlignment.Left;  // đoạn canh trái                                                                                                      
                //paragraph.Format.HorizontalAlignment = HorizontalAlignment.Right; // đoạn canh phải                                                                                       
                // đoạn mới tên biến là  paragraph2
                Paragraph paragraph2 = doc.Sections[0].AddParagraph();
                // tên văn bản mới là text2
                Spire.Doc.Fields.TextRange text2 = paragraph2.AppendText(
                "Mã phiếu : " + lbMaPTH.Text + "\t\t Ngày lập : " + lbNgayNhap.Text + "\n");
                text2.CharacterFormat.FontSize = 14;
                text2.CharacterFormat.Bold = false;
                paragraph2.Format.TextAlignment = TextAlignment.Center;              // văn bản canh giữa 
                paragraph2.Format.HorizontalAlignment = Spire.Doc.Documents.HorizontalAlignment.Right;

                Paragraph paragraph3 = doc.Sections[0].AddParagraph();
                // tên văn bản mới là text2
                Spire.Doc.Fields.TextRange text3 = paragraph3.AppendText(
                "Mã hóa đơn : " + lbMaHD.Text + "\n\n");
 
                text3.CharacterFormat.FontSize = 14;
                text3.CharacterFormat.Bold = false;
                paragraph3.Format.TextAlignment = TextAlignment.Center;              // văn bản canh giữa 
                paragraph3.Format.HorizontalAlignment = Spire.Doc.Documents.HorizontalAlignment.Left;


                Paragraph paragraph4 = doc.Sections[0].AddParagraph();
                // tên văn bản mới là text2
                Spire.Doc.Fields.TextRange text4 = paragraph4.AppendText(
                "Thông tin khách hàng" + "\n");
                text4.CharacterFormat.FontSize = 14;
                text4.CharacterFormat.Bold = true;
                paragraph4.Format.TextAlignment = TextAlignment.Center;              // văn bản canh giữa 
                paragraph4.Format.HorizontalAlignment = Spire.Doc.Documents.HorizontalAlignment.Left;

                Paragraph paragraph5 = doc.Sections[0].AddParagraph();
                // tên văn bản mới là text2
                Spire.Doc.Fields.TextRange text5 = paragraph5.AppendText(
                "Họ tên KH : " + lbTenKh.Text + "\n"
                + "SDT KH : " + lbSDTKH.Text + "\n"
                + "Địa chỉ KH : " + lbDCKH.Text + "\n\n");
                text5.CharacterFormat.FontSize = 14;
                text5.CharacterFormat.Bold = false;
                paragraph5.Format.TextAlignment = TextAlignment.Center;              // văn bản canh giữa 
                paragraph5.Format.HorizontalAlignment = Spire.Doc.Documents.HorizontalAlignment.Left;


                Paragraph paragraph6 = doc.Sections[0].AddParagraph();
                // tên văn bản mới là text2
                Spire.Doc.Fields.TextRange text6 = paragraph6.AppendText(
                "Thông tin nhân viên tiếp nhận" + "\n");
                text6.CharacterFormat.FontSize = 14;
                text6.CharacterFormat.Bold = true;
                paragraph6.Format.TextAlignment = TextAlignment.Center;              // văn bản canh giữa 
                paragraph6.Format.HorizontalAlignment = Spire.Doc.Documents.HorizontalAlignment.Left;

                Paragraph paragraph7 = doc.Sections[0].AddParagraph();
                // tên văn bản mới là text2
                Spire.Doc.Fields.TextRange text7 = paragraph7.AppendText(
                "Mã NV : " + lbMaNV.Text + "\n"
                + "Họ tên NV : " + lbTenNVHD.Text + "\n\n");
                text7.CharacterFormat.FontSize = 14;
                text7.CharacterFormat.Bold = false;
                paragraph7.Format.TextAlignment = TextAlignment.Center;              // văn bản canh giữa 
                paragraph7.Format.HorizontalAlignment = Spire.Doc.Documents.HorizontalAlignment.Left;

                /*// Dữ liệu mẫu DSF 
                List<string> list = new List<string> { "One", "True", "Three" };*/
                int rows = 0;
                foreach (ListViewItem li in listView1.Items)
                {

                    rows += 1;

                }
                // Tạo đối tượng bảng Table
                Spire.Doc.Table table = doc.Sections[0].AddTable(true);

                // Tạo cột
                String[] Header = { "STT", "Mã sản phẩm ","Tên sản phẩm","Ngày mua","Lý do trả hàng","Hoàn tiền" };
                
                // Số dòng và số cột cho bảng
                table.ResetCells(rows, Header.Length);

                // Độ rộng bảng ở dòng 0 và 2 cột STT và Tên (tạo tiêu đề bảng)
                /*doc.Sections[0].Tables[0].Rows[0].Cells[0].Width = 200;
                doc.Sections[0].Tables[0].Rows[0].Cells[1].Width = 200;
*/
                // Tạo dòng tiêu đề cho bảng (dòng 0)
                Spire.Doc.TableRow FRow = table.Rows[0];
                FRow.IsHeader = true;
                FRow.Height = 23;

                for (int i = 0; i < Header.Length; i++)
                {
                    // Định dạng cell
                    Paragraph p = FRow.Cells[i].AddParagraph();
                    FRow.Cells[i].CellFormat.VerticalAlignment = VerticalAlignment.Middle;
                    p.Format.HorizontalAlignment = Spire.Doc.Documents.HorizontalAlignment.Center;

                    // Định dạng văn bản trong bảng
                    Spire.Doc.Fields.TextRange TR = p.AppendText(Header[i]);
                    TR.CharacterFormat.FontName = "Times New Roman";
                    TR.CharacterFormat.FontSize = 13;
                    TR.CharacterFormat.Bold = true;
                }

                // Định dạng dữ liệu từng dòng (lấy từ list)
                
                foreach (ListViewItem li in listView1.Items)
                {

                    Spire.Doc.TableRow DataRow = table.Rows[rows+1];
                    DataRow.Height = 20;
                    foreach (ListViewItem.ListViewSubItem lsi in li.SubItems)
                    {
                        
                        DataRow.Cells[0].CellFormat.VerticalAlignment = VerticalAlignment.Middle;
                        Paragraph p1 = DataRow.Cells[0].AddParagraph();
                        Spire.Doc.Fields.TextRange TR1 = p1.AppendText((lsi).ToString()); // STT
                        p1.Format.HorizontalAlignment = Spire.Doc.Documents.HorizontalAlignment.Center;

                        /*DataRow.Cells[1].CellFormat.VerticalAlignment = VerticalAlignment.Middle;
                        Paragraph p2 = DataRow.Cells[1].AddParagraph();
                        Spire.Doc.Fields.TextRange TR2 = p2.AppendText(list[r].ToString()); // Tên
                        p2.Format.HorizontalAlignment = Spire.Doc.Documents.HorizontalAlignment.Center;
*/                      
                        
                    }
                }



                // Lưu đối tượng tài liệu vào tập tin test.doc (nằm ở thư mục Debug của dự án)
                doc.SaveToFile(filename, Spire.Doc.FileFormat.Doc);

                // doc.SaveToFile("test.pdf", Spire.Doc.FileFormat.PDF); -- tạo PDF
               
                // đóng đối tượng
                doc.Close();
                MessageBox.Show("SCC: Xuất file thành công!");
            }
            catch(Exception ex)
            {
                MessageBox.Show("ERR: Lỗi khi xuất file!"+ex.Message);
            }
            
        }
    }
}
