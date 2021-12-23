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
namespace QLCuaHangJuno
{
    public partial class HoaDonThanhToan : Form
    {
        //Cơ sở dữ liệu
        QuanLyCuaHangJunoContext db = new QuanLyCuaHangJunoContext();
        HoaDonBanHang hd = new HoaDonBanHang();
        List<HoaDonBanHangSanPham> listsp = new List<HoaDonBanHangSanPham>();
        double tongtien = 0;
        double gghd = 0;
        double thanhtien = 0;
        NhanVien nv = new NhanVien();
        KhachHang kh = new KhachHang();

        public HoaDonThanhToan(NhanVien nv)
        {
            this.nv = nv;
            InitializeComponent();
        }

        private void txt_masp_TextChanged(object sender, EventArgs e)
        {
            //Truy vấn bảng SanPham tìm mã sản phẩm
            var sp = (from item in db.SanPhams
                      where item.MaSp == txt_masp.Text
                      select item).FirstOrDefault();
            //nếu mã sp tồn tại, tự động điền các textbox khác
            if (sp != null)
            {
                //tên sản phẩm
                txt_tensp.Text = sp.TenSp;

                //combobox màu sắc
                var listMau = from item in db.SanPhamChiTiets
                              join a in db.Maus on item.MaMau equals a.MaMau
                              where txt_masp.Text == item.MaSp
                              select new
                              {
                                  MaMau = item.MaMau,
                                  Mau = a.Mau1
                              };
                listMau = listMau.Distinct();
                cb_mausac.DataSource = listMau.ToList();
                cb_mausac.DisplayMember = "Mau";
                cb_mausac.ValueMember = "MaMau";
                //combobox kích cỡ
                var listKC = from item in db.SanPhamChiTiets
                             join a in db.KichCos on item.MaKc equals a.MaKc
                             where txt_masp.Text == item.MaSp
                             select new
                             {
                                 MaKC = item.MaKc,
                                 KC = a.KichCo1
                             };
                listKC = listKC.Distinct();
                cb_kichco.DataSource = listKC.ToList();
                cb_kichco.DisplayMember = "KC";
                cb_kichco.ValueMember = "MaKC";
                //Đơn giá
                txt_dongia.Text = sp.DonGia.ToString(".");
                //Số lượng max
                DatSoLuongMax();
                //Khuyến mãi
                var km = (from item in db.KhuyenMaiSanPhams where item.MaSp == txt_masp.Text select item).FirstOrDefault();
                if (km != null) txt_giamgia.Text = km.TyLeKhuyenMai.ToString();
                if (txt_giamgia.Text == null) txt_giamgia.Text = "0";

                //Hiển thị tổng tiền
                txt_thanhtien.Text = TinhTienSP().ToString();
            }
        }

        private void HoaDonThanhToan_Load(object sender, EventArgs e)
        {
            //Gợi ý mã sản phẩm
            autoCompleteSP();
            //Gợi ý tên khách hàng
            autoCompleteKH();
            //Gợi ý số điện thoại
            autoCompleteSDT();
            //Đặt giá trị mặc định
            txt_giamgia.Text = "0";
            txt_dongia.Text = "0";
            ThongTinHoaDon();
        }

        private void autoCompleteSDT()
        {
            AutoCompleteStringCollection autoCompleteSDT = new AutoCompleteStringCollection();
            var KHList = from item in db.KhachHangs select item;
            foreach (var item in KHList)
            {
                autoCompleteSDT.Add(item.Sdt);
            }
            txt_sdtKH.AutoCompleteMode = AutoCompleteMode.Suggest;
            txt_sdtKH.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txt_sdtKH.AutoCompleteCustomSource = autoCompleteSDT;
        }

        //Thêm sản phẩm vào danh sách sản phẩm
        private void btn_them_Click(object sender, EventArgs e)
        {
            //Tìm mã sản phẩm trong db
            var sp1 = (from item in db.SanPhams
                       where item.MaSp == txt_masp.Text
                       select item.MaSp).FirstOrDefault();
            //kiểm tra null
            if (sp1 == null)
            {
                MessageBox.Show("Bạn phải nhập mã sản phẩm Chính xác");
                txt_masp.Focus();
                return;
            }
            //tìm mã chi tiết sp
            var MaSpCt = (from item in db.SanPhamChiTiets
                          where (item.MaSp == txt_masp.Text
                          && item.MaMau == cb_mausac.SelectedValue.ToString()
                          && item.MaKc == cb_kichco.SelectedValue.ToString())
                          select item).FirstOrDefault();
            //kiểm tra mã chi tiết null
            if (MaSpCt == null)
            {
                MessageBox.Show("Không tồn tại sản phẩm có mã " + txt_masp.Text + " màu " + cb_mausac.Text + " kích cỡ " + cb_kichco.Text);
                return;
            }
            if (MaSpCt.SoLuongTon == 0)
            {
                MessageBox.Show("Sản phẩm " + txt_masp.Text + " màu " + cb_mausac.Text + " kích cỡ " + cb_kichco.Text + " đã hết hàng trong kho");
                return;
            }
            HoaDonBanHangSanPham sp = new HoaDonBanHangSanPham();
            sp.MaHd = maHD();
            sp.MaSpCt = MaSpCt.MaSpCt.ToString();
            sp.SoLuongBan = ((int)num_soluong.Value);
            //kiểm tra xem sản phẩm đã có trong giỏ hàng chưa
            bool check = false;
            foreach (var item in listsp)
                if (item.MaSpCt == sp.MaSpCt) check = true;
            //nếu chưa có, thêm vào giỏ hàng
            if (!check) listsp.Add(sp);

            else
            {
                //nếu đã có, không thay đổi số lượng
                var spcu = (from item in listsp where item.MaSpCt == sp.MaSpCt select item).FirstOrDefault();
                if (sp.SoLuongBan == spcu.SoLuongBan)
                    MessageBox.Show("Đã có sản phẩm này");
                //thay đổi số lượng
                else
                {
                    spcu.SoLuongBan = sp.SoLuongBan;
                    MessageBox.Show("Cập nhật số lượng");
                }
            }
            HienThiDataGrid();
        }
        //Hiển thị lên datagridview
        private void HienThiDataGrid()
        {
            thanhtien = 0;
            tongtien = 0;
            var listct = from item in listsp
                         select item.MaSpCt;
            var list = from item in listsp
                       join a in db.SanPhamChiTiets on item.MaSpCt equals a.MaSpCt
                       join b in db.SanPhams on a.MaSp equals b.MaSp
                       join e in db.KhuyenMaiSanPhams on a.MaSp equals e.MaSp
                       join c in db.Maus on a.MaMau equals c.MaMau
                       join d in db.KichCos on a.MaKc equals d.MaKc
                       select new
                       {
                           masp = a.MaSp,
                           ten = b.TenSp,
                           mausac = c.Mau1,
                           kichco = d.KichCo1,
                           soluong = item.SoLuongBan,
                           dongia = b.DonGia,
                           khuyenmai = e.TyLeKhuyenMai,
                           thanhtien = (double)item.SoLuongBan * (double)b.DonGia * (100 - e.TyLeKhuyenMai)/100,
                       };
            foreach (var item in list)
            {
                tongtien = tongtien + item.thanhtien;
            }
            lb_tongtien.Text = "Tiền hàng: " + tongtien.ToString() + "VND";
            var giamgiahd = (from item in db.GiamGiaHoaDons
                          where ((double)item.DieuKienApDung) <= tongtien
                          && item.TgbatDau <= DateTime.Now
                          && item.TgketThuc >= DateTime.Now
                          && item.MaGg != "GG000"
                          select item).FirstOrDefault();
            if (giamgiahd != null)
            {
                hd.MaGg = giamgiahd.MaGg;
                gghd = giamgiahd.TyLeGiamGia;
            }
            else
            {
                hd.MaGg = "GG000";
                gghd = 0;
            }
            thanhtien = tongtien * (100 - gghd) / 100;
            lb_gghd.Text = "Giảm giá theo hóa đơn: "+ gghd.ToString() + "%";
            lb_thanhtien.Text = "Thành tiền: " + thanhtien.ToString() + " VND";

            dgv_dssp.DataSource = list.ToList();
        }
        //Lưu hóa đơn vào csdl
        private void btn_luu_Click(object sender, EventArgs e)
        {
            //Kiểm tra list sản phẩm
            if (listsp.Count == 0)
            {
                MessageBox.Show("Giỏ hàng trống");
                return;
            }    
            //Kiểm tra khách hàng
            kh = (from item in db.KhachHangs
                  where txt_hotenKH.Text == item.HoTenKh && txt_sdtKH.Text == item.Sdt
                  select item).FirstOrDefault();
            if (kh == null)
            {
                MessageBox.Show("Không tìm thấy khách hàng này.\n Bạn cần thêm khách hàng trước");
                return;
            }
            else
            {
                hd.MaKh = kh.MaKh;
            }
            //Thêm hóa đơn vào csdl
            db.HoaDonBanHangs.Add(hd);
            //Thêm hóa đơn-sản phẩm
            foreach (var item in listsp)
            {
                db.HoaDonBanHangSanPhams.Add(item);
                //Thay đổi số lượng tồn
                var spsua = db.SanPhamChiTiets.SingleOrDefault(i => i.MaSpCt == item.MaSpCt);
                spsua.SoLuongTon = spsua.SoLuongTon - item.SoLuongBan;

            }

            db.SaveChanges();
            MessageBox.Show("Lưu thành công");
            HoaDonThanhToan hdtt = new HoaDonThanhToan(nv);
            hdtt.Show();
            this.Close();

        }

        private void num_soluong_ValueChanged(object sender, EventArgs e)
        {
            txt_thanhtien.Text = TinhTienSP().ToString();
        }

        private void cb_mausac_SelectedIndexChanged(object sender, EventArgs e)
        {
            DatSoLuongMax();
        }

        private void cb_kichco_SelectedIndexChanged(object sender, EventArgs e)
        {
            DatSoLuongMax();
        }

        private void DatSoLuongMax()
        {
            if (cb_mausac.SelectedValue != null && cb_kichco.SelectedValue != null)
            {
                int slmax = (from item in db.SanPhamChiTiets
                             where (item.MaSp == txt_masp.Text && item.MaMau == cb_mausac.SelectedValue.ToString() && item.MaKc == cb_kichco.SelectedValue.ToString())
                             select item.SoLuongTon).FirstOrDefault();
                num_soluong.Maximum = slmax;
                num_soluong.Minimum = 1;
                lb_soluong.Text = "Số lượng (tối đa " + slmax + ")";

            }
        }
        private void autoCompleteSP()
        {
            //Gợi ý mã sản phẩm
            AutoCompleteStringCollection autoCompleteSP = new AutoCompleteStringCollection();

            var SPList = from item in db.SanPhamChiTiets
                         select item;
            foreach (var item in SPList)
            {
                autoCompleteSP.Add(item.MaSp);
            }
            txt_masp.AutoCompleteMode = AutoCompleteMode.Suggest;
            txt_masp.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txt_masp.AutoCompleteCustomSource = autoCompleteSP;
        }
        //Gợi ý tên khác hàng
        private void autoCompleteKH()
        {
            AutoCompleteStringCollection autoCompleteKH = new AutoCompleteStringCollection();
            var KHList = from item in db.KhachHangs select item;
            foreach (var item in KHList)
            {
                autoCompleteKH.Add(item.HoTenKh);
            }
            txt_hotenKH.AutoCompleteMode = AutoCompleteMode.Suggest;
            txt_hotenKH.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txt_hotenKH.AutoCompleteCustomSource = autoCompleteKH;
        }
        private void ThongTinHoaDon()
        {
            //tự sinh thông tin hóa đơn
            var hoadon = from item in db.HoaDonBanHangs select item;
            lb_mahd.Text = "Mã hóa đơn: " + maHD();
            lb_ngaylap.Text = "Ngày lập: " + DateTime.Now.ToString("dd/MM/yyyy");
            hd.MaHd = maHD();
            hd.NgayBan = DateTime.Now;
            hd.MaNv = nv.MaNv;
            hd.MaGg = "GG000";
            lb_manv.Text = "Mã nhân viên: " + nv.MaNv;
            lb_hotennv.Text = "Họ tên: " + nv.HoTenNv;
        }
        private string maHD()
        {
            //Tự sinh mã hóa đơn
            var hoadon = from item in db.HoaDonBanHangs select item;
            int soHD = hoadon.Count();
            string maHD = "HD" + (soHD + 1).ToString();
            return maHD;
        }
        private double TinhTienSP()
        {
            //Tính tổng tiền 1 sản phẩm
            return ((double.Parse(txt_dongia.Text) * ((double)num_soluong.Value)) * (100 - double.Parse(txt_giamgia.Text)) / 100);
        }
        //xóa thông tin trong các hộp
        private void button1_Click(object sender, EventArgs e)
        {
            txt_masp.Text = null;
            txt_tensp.Text = null;
            cb_kichco.DataSource = null;
            cb_mausac.DataSource = null;
            cb_kichco.Text = "Kích cỡ";
            cb_mausac.Text = "Màu sắc";
            lb_soluong.Text = "Số lượng";
            txt_dongia.Text = "0";
            txt_giamgia.Text = "0";
            txt_thanhtien.Text = "0";
            num_soluong.Value = 1;
        }
        //Hiển thị thông tin từ datagrid lên text
        private void dgv_dssp_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int numrow;
            numrow = e.RowIndex;
            if (numrow >=0 )
            {
                txt_masp.Text = dgv_dssp.Rows[numrow].Cells[0].Value.ToString();
                cb_mausac.Text = dgv_dssp.Rows[numrow].Cells[2].Value.ToString();
                cb_kichco.Text = dgv_dssp.Rows[numrow].Cells[3].Value.ToString();
                var num = dgv_dssp.Rows[numrow].Cells[4].Value.ToString();
                num_soluong.Value = int.Parse(num);
            }    
            
        }
        // Xóa sản phẩm khỏi danh sách
        private void button2_Click(object sender, EventArgs e)
        {
            var sp1 = (from item in db.SanPhamChiTiets
                       where item.MaSp == txt_masp.Text
                       && item.MaMau == cb_mausac.SelectedValue.ToString()
                       && item.MaKc == cb_kichco.SelectedValue.ToString()
                       select item.MaSpCt).FirstOrDefault();
            if (sp1 == null)
            {
                MessageBox.Show("Ko có sản phẩm này");
                txt_masp.Focus();
                return;
            }
            else
            {
                foreach (var item in listsp)
                {
                    if (item.MaSpCt == sp1)
                    {
                        listsp.Remove(item);
                        HienThiDataGrid();
                        return;
                    }
                }
                MessageBox.Show("Không có sản phẩm này trong danh sách");
                txt_masp.Focus();
                return;
            }
        }

        //kiểm tra thông tin khách hàng trước khi thêm
        private void btn_themKH_Click(object sender, EventArgs e)
        {
            if (txt_hotenKH.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập tên khách hàng");
                txt_hotenKH.Focus();
                return;
            }
            if (txt_sdtKH.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập số điện thoại");
                txt_sdtKH.Focus();
                return;
            }
            double sdt;
            if (!double.TryParse(txt_sdtKH.Text, out sdt) && txt_sdtKH.Text.Length != 10)
            {
                MessageBox.Show("Số điện thoại phải là 10 ký tự số");
                txt_sdtKH.Focus();
                return;
            }
            if (txt_diachiKH.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập địa chỉ");
                txt_diachiKH.Focus();
                return;
            }
            kh.MaKh = "KH" + (db.KhachHangs.Count() + 1).ToString();
            kh.HoTenKh = txt_hotenKH.Text;
            kh.Sdt = txt_sdtKH.Text;
            kh.DiaChi = txt_diachiKH.Text;
            DialogResult dialogResult = MessageBox.Show("Thêm khách hàng:\n Mã khách hàng: " + kh.MaKh + "\nHọ tên: " + kh.HoTenKh + "\nSố điện thoại: " + kh.Sdt + "\n Địa chỉ: " + kh.DiaChi, "Xác nhận", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                db.KhachHangs.Add(kh);
                db.SaveChanges();
            }
            else if (dialogResult == DialogResult.No)
            {

            }



        }
    }
}
