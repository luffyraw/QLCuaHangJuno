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
    public partial class frmTaoPhieuNhapHang : Form
    {
        QuanLyCuaHangJunoContext db = new QuanLyCuaHangJunoContext();
        int row = -1;
        NhanVien nv = new NhanVien();
        public frmTaoPhieuNhapHang(NhanVien nv)
        {
            this.nv = nv;
            InitializeComponent();
        }
        private string MaPhieuNhap()
        {
            var phieu = from item in db.PhieuNhapHangs
                        select item;
            int soPhieu = phieu.Count() + 1;
            string maPhieu = "";
            if (soPhieu < 10)
            {
                maPhieu = String.Format("{0}00{1}", "PN", soPhieu);
            }
            else if (soPhieu < 100)
            {
                maPhieu = String.Format("{0}0{1}", "PN", soPhieu);
            }
            else if (soPhieu < 1000)
            {
                maPhieu = String.Format("{0}{1}", "PN", soPhieu);
            }
            else
            {
                maPhieu = soPhieu.ToString();
            }
            return maPhieu;
        }

        private void frmTaoPhieuNhapHang_Load(object sender, EventArgs e)
        {
            txtMaPhieuN.Text = MaPhieuNhap();
            dtpNgayLap.Value = DateTime.Now;
            lblNguoiNhap.Text = nv.HoTenNv;
        }
        private void txtMaPhieuD_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                dgvSanPhamNhap.Rows.Clear();
                if (txtMaPhieuD.Text != "")
                {
                    var queryPhieuDat = (from phieu in db.PhieuDatHangs
                                         where phieu.MaPhieuDat == txtMaPhieuD.Text
                                         select phieu).FirstOrDefault();
                    if (queryPhieuDat != null)
                    {
                        dgvSanPhamNhap.Rows.Clear();
                        if (queryPhieuDat.TrangThai == "Chưa nhập")
                        {
                            var spNhap = from spdat in db.DatHangSanPhams
                                         join spct in db.SanPhamChiTiets on spdat.MaSpCt equals spct.MaSpCt
                                         where spdat.MaPhieuDat == queryPhieuDat.MaPhieuDat
                                         select new
                                         {
                                             MaSpCt = spdat.MaSpCt,
                                             MaSp = spdat.MaSpCtNavigation.MaSp,
                                             TenSp = spct.MaSpNavigation.TenSp,
                                             Mau = spct.MaMauNavigation.Mau1,
                                             KichCo = spct.MaKcNavigation.KichCo1,
                                             SoLuongDat = spdat.SoLuongDat
                                         };
                            int index = 0;
                            foreach (var item in spNhap.ToList())
                            {
                                dgvSanPhamNhap.Rows.Add();
                                dgvSanPhamNhap.Rows[index].Cells[0].Value = index + 1;
                                dgvSanPhamNhap.Rows[index].Cells[1].Tag = item.MaSpCt;
                                dgvSanPhamNhap.Rows[index].Cells[1].Value = item.MaSp;
                                dgvSanPhamNhap.Rows[index].Cells[2].Value = item.TenSp;
                                dgvSanPhamNhap.Rows[index].Cells[3].Value = item.Mau;
                                dgvSanPhamNhap.Rows[index].Cells[4].Value = item.KichCo;
                                dgvSanPhamNhap.Rows[index].Cells[5].Value = item.SoLuongDat;
                                dgvSanPhamNhap.Rows[index].Cells[6].Value = 0;
                                dgvSanPhamNhap.Rows[index].Cells[7].Value = 0;
                                index++;

                            }
                        }
                        if (queryPhieuDat.TrangThai == "Nhập một phần")
                        {
                            var spDaNhap = from spN in db.NhapHangSanPhams
                                           where spN.MaPhNhapNavigation.MaPhieuDat == queryPhieuDat.MaPhieuDat
                                           group spN by spN.MaSpCt into g
                                           select new
                                           {
                                               MaSpCt = g.Key,
                                               SoLuongDaNhap = g.Sum(x => x.SoLuongNhap)
                                           };
                            var spNhap = from spdat in db.DatHangSanPhams
                                         join spct in db.SanPhamChiTiets on spdat.MaSpCt equals spct.MaSpCt
                                         where spdat.MaPhieuDat == queryPhieuDat.MaPhieuDat
                                         select new
                                         {
                                             MaSpCt = spdat.MaSpCt,
                                             MaSp = spdat.MaSpCtNavigation.MaSp,
                                             TenSp = spct.MaSpNavigation.TenSp,
                                             Mau = spct.MaMauNavigation.Mau1,
                                             KichCo = spct.MaKcNavigation.KichCo1,
                                             SoLuongDat = spdat.SoLuongDat
                                         };
                            int index = 0;
                            foreach (var item in spNhap.ToList())
                            {
                                dgvSanPhamNhap.Rows.Add();
                                dgvSanPhamNhap.Rows[index].Cells[0].Value = index + 1;
                                dgvSanPhamNhap.Rows[index].Cells[1].Tag = item.MaSpCt;
                                dgvSanPhamNhap.Rows[index].Cells[1].Value = item.MaSp;
                                dgvSanPhamNhap.Rows[index].Cells[2].Value = item.TenSp;
                                dgvSanPhamNhap.Rows[index].Cells[3].Value = item.Mau;
                                dgvSanPhamNhap.Rows[index].Cells[4].Value = item.KichCo;
                                dgvSanPhamNhap.Rows[index].Cells[5].Value = item.SoLuongDat;
                                dgvSanPhamNhap.Rows[index].Cells[6].Value = 0;
                                dgvSanPhamNhap.Rows[index].Cells[7].Value = 0;

                                var sanPhamNhap = spDaNhap.Where(x => x.MaSpCt == item.MaSpCt).FirstOrDefault();
                                if (sanPhamNhap != null)
                                {
                                    dgvSanPhamNhap.Rows[index].Cells[6].Value = sanPhamNhap.SoLuongDaNhap.ToString();
                                }
                                else
                                {
                                    dgvSanPhamNhap.Rows[index].Cells[6].Value = 0;
                                }

                                index++;
                            }

                        }
                        if (queryPhieuDat.TrangThai == "Hoàn thành")
                        {
                            MessageBox.Show("Phiếu đặt hàng có mã " + txtMaPhieuD.Text + " đã nhập đủ .","Error",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Không tồn tại phiếu đặt hàng có mã " + txtMaPhieuD.Text + " .", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }

        private void dgvSanPhamNhap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            row = e.RowIndex;
            if (row != -1)
            {
                txtMaSp.Text = dgvSanPhamNhap.Rows[row].Cells[1].Value.ToString();
                txtTenSp.Text = dgvSanPhamNhap.Rows[row].Cells[2].Value.ToString();
                txtMau.Text = dgvSanPhamNhap.Rows[row].Cells[3].Value.ToString();
                txtKichCo.Text = dgvSanPhamNhap.Rows[row].Cells[4].Value.ToString();
                txtSoLuongDat.Text = dgvSanPhamNhap.Rows[row].Cells[5].Value.ToString();
                txtSoLuongDaNhap.Text = dgvSanPhamNhap.Rows[row].Cells[6].Value.ToString();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (row != -1)
            {
                int soLuongNhap = (int)NumSoLuongNhap.Value;
                int chenhLech = int.Parse(txtSoLuongDat.Text) - int.Parse(txtSoLuongDaNhap.Text);
                if (soLuongNhap <= chenhLech)
                {
                    dgvSanPhamNhap.Rows[row].Cells[7].Value = soLuongNhap;
                }
                else
                {
                    MessageBox.Show("Số lượng nhập phải nhỏ hơn hoặc bằng " + chenhLech, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Bạn cần chọn 1 dòng trong danh sách sản phẩm để cập nhật. ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public bool CheckChuaNhap()
        {
            bool result = false;
            for (int i = 0; i < dgvSanPhamNhap.Rows.Count; i++)
            {
                if (int.Parse(dgvSanPhamNhap.Rows[i].Cells[7].Value.ToString()) != 0)
                {
                    result = true;
                    break;
                }
            }
            return result;
        }
        public bool CheckHoanThanh()
        {
            bool result = true;
            for (int i = 0; i < dgvSanPhamNhap.Rows.Count; i++)
            {
                if ((int.Parse(dgvSanPhamNhap.Rows[i].Cells[7].Value.ToString()) + int.Parse(dgvSanPhamNhap.Rows[i].Cells[6].Value.ToString())) < int.Parse(dgvSanPhamNhap.Rows[i].Cells[5].Value.ToString()))
                {
                    result = false;
                    break;
                }
            }
            return result;
        }
        public bool KiemTraDuLieuLuu()
        {
            bool check = false;
            if (txtMaPhieuD.Text != "")
            {
                errorProvider1.SetError(txtMaPhieuD, "");
                if (txtNguoiGiao.Text != "")
                {
                    errorProvider1.SetError(txtNguoiGiao, "");
                    if (dgvSanPhamNhap.Rows.Count != 0)
                    {
                        check = true;
                    }
                    else
                    {
                        MessageBox.Show("Không tồn tại sản phẩm nào trong danh sách sản phẩm nhập.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    errorProvider1.SetError(txtNguoiGiao, "Người giao không được để trống.");
                }
            }
            else
            {
                errorProvider1.SetError(txtMaPhieuD, "Mã phiếu đặt không được để trống.");
            }
            return check;
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (KiemTraDuLieuLuu())
            {
                PhieuNhapHang phieu = new PhieuNhapHang();
                phieu.MaPhNhap = txtMaPhieuN.Text;
                phieu.NgayNhap = dtpNgayLap.Value;
                phieu.NguoiGiao = txtNguoiGiao.Text;
                phieu.MaPhieuDat = txtMaPhieuD.Text;
                phieu.MaNv = nv.MaNv;
                db.PhieuNhapHangs.Add(phieu);
                for (int i = 0; i < dgvSanPhamNhap.Rows.Count; i++)
                {
                    int soLuongNhap = int.Parse(dgvSanPhamNhap.Rows[i].Cells[7].Value.ToString());
                    if (soLuongNhap > 0)
                    {
                        NhapHangSanPham nhsp = new NhapHangSanPham();
                        nhsp.MaPhNhap = phieu.MaPhNhap;
                        nhsp.MaSpCt = dgvSanPhamNhap.Rows[i].Cells[1].Tag.ToString();
                        nhsp.SoLuongNhap = soLuongNhap;
                        db.NhapHangSanPhams.Add(nhsp);
                        var spct = (from sp in db.SanPhamChiTiets
                                    where sp.MaSpCt == nhsp.MaSpCt
                                    select sp).FirstOrDefault();
                        spct.SoLuongTon += nhsp.SoLuongNhap;
                    }

                }
                if (CheckChuaNhap())
                {
                    var phieuDat = (from p in db.PhieuDatHangs
                                    where p.MaPhieuDat == txtMaPhieuD.Text
                                    select p).FirstOrDefault();
                    if (CheckHoanThanh())
                    {
                        phieuDat.TrangThai = "Hoàn thành";
                    }
                    else
                    {
                        phieuDat.TrangThai = "Nhập một phần";
                    }
                }
                db.SaveChanges();
                this.Close();
            }
        }
    }
}
