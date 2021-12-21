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
        
        public HoaDonThanhToan()
        {
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
                //Màu sắc, kích cỡ
                var chitietsp = from item in db.SanPhamChiTiets
                                where item.MaSp == txt_masp.Text
                                select item;
                
                foreach (var item in chitietsp)
                {
                    if (!cb_mausac.Items.Contains(item.MaMau))
                        cb_mausac.Items.Add(item.MaMau);
                    if (!cb_kichco.Items.Contains(item.MaKc))
                        cb_kichco.Items.Add(item.MaKc);
                }
                //Khuyến mãi
                var km = (from item in db.KhuyenMaiSanPhams where item.MaSp == txt_masp.Text select item).FirstOrDefault();
                if (km != null) txt_giamgia.Text = km.TyLeKhuyenMai.ToString();
                if (txt_giamgia.Text == null) txt_giamgia.Text = "0";
                //Đơn giá
                txt_dongia.Text = sp.DonGia.ToString();
                //Hiển thị tổng tiền
                txt_thanhtien.Text = TinhTienSP().ToString();
            }
        }

        private void HoaDonThanhToan_Load(object sender, EventArgs e)
        {
            //Gợi ý mã sản phẩm
            AutoCompleteStringCollection autoComplete = new AutoCompleteStringCollection();

            var SPList = from item in db.SanPhams
                         select item;
            foreach (var item in SPList)
            {
                autoComplete.Add(item.MaSp);
            }
            txt_masp.AutoCompleteMode = AutoCompleteMode.Suggest;
            txt_masp.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txt_masp.AutoCompleteCustomSource = autoComplete;
            //Đặt giá trị mặc định
            txt_giamgia.Text = "0";
            txt_dongia.Text = "0";
            txt_soluong.Text = "1";
            ThongTinHoaDon();
        }
        private void ThongTinHoaDon()
        {
            //tự sinh thông tin hóa đơn
            var hoadon = from item in db.HoaDonBanHangs select item;   
            lb_mahd.Text = "Mã hóa đơn: " + maHD();
            lb_ngaylap.Text = "Ngày lập:" + DateTime.Now.ToString("dd/MM/yyyy");
            hd.MaHd = maHD();
            hd.NgayBan = DateTime.Now;
        }
        private string maHD()
        {
            //Tự sinh mã hóa đơn
            var hoadon = from item in db.HoaDonBanHangs select item;
            string maHD = "";
            int soHD = hoadon.Count();
            if (soHD < 10)
            {
                maHD = "HD00" + (soHD + 1).ToString();
            }
            else if (soHD < 100) maHD = "HD0" + (soHD + 1).ToString();
            return maHD;
        }
        private void cb_mausac_SelectedIndexChanged(object sender, EventArgs e)
        {
            //thay đổi combobox kích cỡ
            var kichco = from item in db.SanPhamChiTiets
                        where (item.MaSp == txt_masp.Text && item.MaMau == cb_mausac.Text)
                        select item;
            cb_kichco.Items.Clear();
            foreach (var item in kichco)
            {
                if (!cb_kichco.Items.Contains(item.MaKc))
                    cb_kichco.Items.Add(item.MaKc);
            }
            
        }

        private void cb_kichco_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Thay đổi combobox màu sắc
            var mausac = from item in db.SanPhamChiTiets
                        where (item.MaSp == txt_masp.Text && item.MaKc == cb_kichco.Text)
                        select item;
            cb_mausac.Items.Clear();
            foreach (var item in mausac)
            {
                if (!cb_mausac.Items.Contains(item.MaMau))
                    cb_mausac.Items.Add(item.MaMau);
            }
            
        }

        private void txt_soluong_TextChanged(object sender, EventArgs e)
        {
            //Hiển thị tổng tiền cho 1 mã sản phẩm
            txt_thanhtien.Text = TinhTienSP().ToString();
        }
        private double TinhTienSP()
        {
            //Tính tổng tiền 1 sản phẩm
            return ((double.Parse(txt_dongia.Text) * double.Parse(txt_soluong.Text)) * double.Parse(txt_giamgia.Text) / 100);
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
           var MaSpCt = (from item in db.SanPhamChiTiets
                      where (item.MaSp == txt_masp.Text && item.MaMau == cb_mausac.Text && item.MaKc == cb_kichco.Text)
                      select item.MaSpCt).FirstOrDefault();
            HoaDonBanHangSanPham sp = new HoaDonBanHangSanPham();
            sp.MaHd = maHD();
            sp.MaSpCt = MaSpCt.ToString();
            sp.SoLuongBan = int.Parse(txt_soluong.Text);
            bool check = false;
            foreach (var item in listsp)
                if (item.MaSpCt == sp.MaSpCt) check = true;
            if (!check) listsp.Add(sp);
            HienThiDataGrid();
        }

        private void HienThiDataGrid()
        {
            
            dgv_dssp.DataSource = listsp.ToList();
        }

        private void btn_luu_Click(object sender, EventArgs e)
        {
            db.HoaDonBanHangs.Add(hd);
            foreach (var item in listsp)
            {
                db.HoaDonBanHangSanPhams.Add(item);
            }    
            db.SaveChanges();
        }
    }
}
