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
    public partial class frmDatHang : Form
    {
        QuanLyCuaHangJunoContext db = new QuanLyCuaHangJunoContext();
        int index = 0;
        int rowDelete = -1;
        NhanVien nv = new NhanVien();

        public frmDatHang(NhanVien nv)
        {
            this.nv = nv;
            InitializeComponent();
        }

        

        private void frmDatHang_Load(object sender, EventArgs e)
        {
            txtMaPhieuD.Text = MaPhieuDat();
            dtpNgayLap.Value = DateTime.Now;
            dtpThoiHanGiaoHang.Value = DateTime.Now.AddDays(7);
            lblNguoiDat.Text = nv.HoTenNv;
        }

        private void txtMaSp_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtMaSp.Text != "")
                {
                    var querySP = (from sp in db.SanPhams
                                   where sp.MaSp == txtMaSp.Text
                                   select new
                                   {
                                       MaSp = sp.MaSp,
                                       TenSp = sp.TenSp,
                                       KieuDang = sp.KieuDang,
                                       ChatLieu = sp.ChatLieu,
                                       DonGia = sp.DonGia,
                                       LoaiSp = sp.MaLoaiSpNavigation.TenLoaiSp
                                   }).FirstOrDefault();
                    if (querySP != null)
                    {


                        txtTenSp.Text = querySP.TenSp;
                        txtKieuDang.Text = querySP.KieuDang;
                        txtChatLieu.Text = querySP.ChatLieu;
                        txtDonGia.Text = querySP.DonGia.ToString();
                        txtLoaiSp.Text = querySP.LoaiSp;

                        var listMau = (from mau in db.SanPhamChiTiets
                                       where mau.MaSp == querySP.MaSp
                                       select new
                                       {
                                           MaMau = mau.MaMau,
                                           Mau = mau.MaMauNavigation.Mau1
                                       }).Distinct();
                        cboMau.DataSource = listMau.ToList();
                        cboMau.DisplayMember = "Mau";
                        cboMau.ValueMember = "MaMau";
                        var listKC = (from kc in db.SanPhamChiTiets
                                      where kc.MaSp == querySP.MaSp && kc.MaMau == cboMau.SelectedValue.ToString()
                                      select new
                                      {
                                          MaKC = kc.MaKc,
                                          KichCo = kc.MaKcNavigation.KichCo1
                                      }).Distinct();
                        cboKichCo.DataSource = listKC.ToList();
                        cboKichCo.DisplayMember = "KichCo";
                        cboKichCo.ValueMember = "MaKC";
                    }
                    else
                    {
                        MessageBox.Show("Không tồn tại sản phẩm có mã " + txtMaSp.Text + " .");
                    }
                }
            }
        }
        private bool KiemTraDuLieuAddSP()
        {
            bool duLieuHopLe = false;
            if (txtMaSp.Text != "")
            {
                errorProvider1.SetError(txtMaSp, null);
                if (txtSoLuongDat.Text != "")
                {
                    errorProvider1.SetError(txtSoLuongDat, null);
                    try
                    {
                        int soLuong = int.Parse(txtSoLuongDat.Text);
                        errorProvider1.SetError(txtSoLuongDat, null);
                        if (soLuong > 0)
                        {
                            errorProvider1.SetError(txtSoLuongDat, null);
                            duLieuHopLe = true;
                        }
                        else
                        {
                            errorProvider1.SetError(txtSoLuongDat, "Số lượng đặt phải >0.");
                        }

                    }
                    catch (Exception ex)
                    {
                        errorProvider1.SetError(txtSoLuongDat, "Số lượng đặt phải là số nguyên.");
                    }
                }
                else
                {
                    errorProvider1.SetError(txtSoLuongDat, "Không được để trống");
                }
            }
            else
            {
                errorProvider1.SetError(txtMaSp, "Không được để trống");
            }
            return duLieuHopLe;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (KiemTraDuLieuAddSP())
            {

                int check = CheckDataGrid(txtMaSp.Text, cboMau.SelectedValue.ToString(), cboKichCo.SelectedValue.ToString());
                if (check >= 0)
                {
                    DialogResult result = MessageBox.Show("Sản phẩm " + txtTenSp.Text + " màu " + cboMau.SelectedValue.ToString() +
                       " cỡ " + cboKichCo.SelectedValue.ToString() + " đã có trong phiếu đặt. Bạn có muốn thay thế ?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        dgvSanPhamDat.Rows[check].Cells[4].Value = txtSoLuongDat.Text;
                    }
                }
                else
                {
                    dgvSanPhamDat.Rows.Add();
                    dgvSanPhamDat.Rows[index].Cells[0].Value = txtMaSp.Text;
                    dgvSanPhamDat.Rows[index].Cells[1].Value = txtTenSp.Text;
                    dgvSanPhamDat.Rows[index].Cells[2].Value = cboMau.Text;
                    dgvSanPhamDat.Rows[index].Cells[2].Tag = cboMau.SelectedValue.ToString();
                    dgvSanPhamDat.Rows[index].Cells[3].Value = cboKichCo.Text;
                    dgvSanPhamDat.Rows[index].Cells[3].Tag = cboKichCo.SelectedValue.ToString();
                    dgvSanPhamDat.Rows[index].Cells[4].Value = txtSoLuongDat.Text;
                    index++;

                }
            }

        }
        private int CheckDataGrid(string maSP, string maMau, string maKC)
        {
            int check = -1;
            for (int i = 0; i < index; i++)
            {
                if (dgvSanPhamDat.Rows[i].Cells[0].Value.ToString() == maSP &&
                    dgvSanPhamDat.Rows[i].Cells[2].Value.ToString() == maMau &&
                    dgvSanPhamDat.Rows[i].Cells[3].Value.ToString() == maKC)
                {
                    check = i;
                    break;
                }

            }
            return check;
        }

        private string MaPhieuDat()
        {
            var phieu = from item in db.PhieuDatHangs
                        select item;
            int soPhieu = phieu.Count() + 1;
            string maPhieu = "";
            if (soPhieu < 10)
            {
                maPhieu = String.Format("{0}00{1}", "PD", soPhieu);
            }
            else if (soPhieu < 100)
            {
                maPhieu = String.Format("{0}0{1}", "PD", soPhieu);
            }
            else if (soPhieu < 1000)
            {
                maPhieu = String.Format("{0}{1}", "PD", soPhieu);
            }
            else
            {
                maPhieu = soPhieu.ToString();
            }
            return maPhieu;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtMaSp.Clear();
            txtTenSp.Clear();
            txtKieuDang.Clear();
            txtChatLieu.Clear();
            txtDonGia.Clear();
            txtMaSp.Clear();
            txtSoLuongDat.Clear();
            cboMau.Text = "";
            cboKichCo.Text = "";
            txtMaSp.Focus();
        }

        private void dgvSanPhamDat_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            rowDelete = e.RowIndex;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (rowDelete >= 0)
            {
                dgvSanPhamDat.Rows.RemoveAt(rowDelete);
            }
        }

        private void btnDatHang_Click(object sender, EventArgs e)
        {
            if (index == 0)
            {
                MessageBox.Show("Không có sản phẩm nào được đặt hàng.");
            }
            else
            {
                PhieuDatHang phieu = new PhieuDatHang();
                phieu.MaPhieuDat = txtMaPhieuD.Text;
                phieu.NgayDat = dtpNgayLap.Value;
                phieu.ThoiHanGiaoHang = dtpThoiHanGiaoHang.Value;
                phieu.TrangThai = "Chưa nhập";
                phieu.MaNv = nv.MaNv;
                db.PhieuDatHangs.Add(phieu);

                for (int i = 0; i < index; i++)
                {
                    string maSPCT = (from spct in db.SanPhamChiTiets
                                     where (spct.MaSp == dgvSanPhamDat.Rows[i].Cells[0].Value.ToString()
                                             && spct.MaMau == dgvSanPhamDat.Rows[i].Cells[2].Tag.ToString()
                                             && spct.MaKc == dgvSanPhamDat.Rows[i].Cells[3].Tag.ToString())
                                     select spct).FirstOrDefault().MaSpCt;
                    DatHangSanPham dhsp = new DatHangSanPham();
                    dhsp.MaPhieuDat = phieu.MaPhieuDat;
                    dhsp.MaSpCt = maSPCT;
                    dhsp.SoLuongDat = int.Parse(dgvSanPhamDat.Rows[i].Cells[4].Value.ToString());
                    db.DatHangSanPhams.Add(dhsp);
                }
                db.SaveChanges();
                this.Close();

            }
        }
    }
}
