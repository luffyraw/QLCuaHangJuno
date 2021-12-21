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
        QuanLyCuaHangJunoContext db = new QuanLyCuaHangJunoContext();
        HoaDonBanHang hd = new HoaDonBanHang();
        HoaDonBanHangSanPham hd_sp = new HoaDonBanHangSanPham();
        public HoaDonThanhToan()
        {
            InitializeComponent();
        }

        private void txt_masp_TextChanged(object sender, EventArgs e)
        {
            var sp = (from item in db.SanPhams
                      where item.MaSp == txt_masp.Text
                      select item).FirstOrDefault();
            var chitietsp = from item in db.SanPhamChiTiets 
                            where item.MaSp == txt_masp.Text select item;
            if (sp != null)
            {
                txt_soluong.Text = "1";
                txt_tensp.Text = sp.TenSp;
                foreach (var item in chitietsp)
                {
                    if (!cb_mausac.Items.Contains(item.MaMau))
                        cb_mausac.Items.Add(item.MaMau);
                    if (!cb_kichco.Items.Contains(item.MaKc))
                        cb_kichco.Items.Add(item.MaKc);
                }
               
                txt_dongia.Text = sp.DonGia.ToString();
                double thanhtien = double.Parse(txt_soluong.Text) * double.Parse(txt_dongia.Text);
                txt_thanhtien.Text = thanhtien.ToString();
            }
        }

        private void HoaDonThanhToan_Load(object sender, EventArgs e)
        {
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
        }

        private void cb_mausac_SelectedIndexChanged(object sender, EventArgs e)
        {
            
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
    }
}
