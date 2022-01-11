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

namespace QLCuaHangJuno
{
    public partial class frmBaoHanh : Form
    {
        QuanLyCuaHangJunoContext db = new QuanLyCuaHangJunoContext();
        NhanVien nv = new NhanVien();

        public frmBaoHanh(NhanVien nv)
        {
            this.nv = nv;
            InitializeComponent();
        }

        private void frmBaoHanh_Load(object sender, EventArgs e)
        {
            var soPhieu = (from mp in db.PhieuBaoHanhs
                           select mp).Count();
            var maPhieu = ("PBH");
            maPhieu += (soPhieu + 1).ToString();
            txtMaPhieu.Text = maPhieu;
            txtMaNV.Text = nv.MaNv;
            cbLoi.Items.Add("Lỗi sản xuất");
            cbLoi.Items.Add("Lí do khác");
        }

        private void HienThiDuLieu()
        {
            var baohanh = from bh in db.PhieuBaohanhSanPhams
                          where bh.MaPhieu == txtMaPhieu.Text
                          select new
                          {
                              bh.MaSpCt,
                              bh.SoLuong,
                              bh.Loi,
                              bh.ChiTietLoi,
                          };
            dgvSanPham.DataSource = baohanh.ToList();
        }
        private bool KiemTraNgoaiLe()
        {
            bool dulieuhople = false;
            var maHD = (from mhd in db.HoaDonBanHangs
                        where mhd.MaHd == txtMaHD.Text
                        select mhd).FirstOrDefault();



            if (txtMaHD.Text != "")
            {
                if (maHD != null)
                {
                    int time = 0;
                    if (maHD.NgayBan.Year < dtLapPhieu.Value.Year)
                    {
                        time = 12 - maHD.NgayBan.Month + dtLapPhieu.Value.Month;
                    }
                    else if (maHD.NgayBan.Year == dtLapPhieu.Value.Year)
                    {
                        time = dtLapPhieu.Value.Month - maHD.NgayBan.Month;
                    }
                    if (time <= 6)
                    {
                        int tgTra = 0;
                        if (dtNgayTra.Value.Month == dtLapPhieu.Value.Month)
                        {
                            tgTra = dtNgayTra.Value.Day - dtLapPhieu.Value.Day;
                        }
                        else if (dtNgayTra.Value.Month > dtLapPhieu.Value.Month)
                        {
                            tgTra = 30 - dtLapPhieu.Value.Day + dtNgayTra.Value.Day;
                        }
                        if (tgTra >= 2 && tgTra <= 7)
                        {
                            dulieuhople = true;
                        }
                        else
                        {
                            MessageBox.Show("Thời gian trả tối thiểu là 2 ngày và tối đa là 7 ngày");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Hóa đơn quá hạn bảo hành");
                    }
                }
                else
                {
                    MessageBox.Show("Hóa đơn không tồn tại");
                }
            }
            else
            {
                MessageBox.Show("Bạn chưa nhập mã hóa đơn");
                txtMaHD.Focus();
            }
            return dulieuhople;
        }
        private void btThem_Click(object sender, EventArgs e)
        {
            if (KiemTraNgoaiLe())
            {
                PhieuBaoHanh pBaoHanh = new PhieuBaoHanh();
                pBaoHanh.MaPhieu = txtMaPhieu.Text;
                pBaoHanh.NgayLapPhieu = dtLapPhieu.Value;
                pBaoHanh.MaNv = txtMaNV.Text;
                pBaoHanh.MaHd = txtMaHD.Text;
                pBaoHanh.NgayTra = dtNgayTra.Value;

                db.PhieuBaoHanhs.Add(pBaoHanh);
                db.SaveChanges();

                lbMaPhieu.Text = "Mã phiếu:   " + txtMaPhieu.Text;
                lbNgayLap.Text = "Ngày lập phiếu:   " + dtLapPhieu.Value.ToString("dd/MM/yyyy");
                lbMaNV.Text = "Mã nhân viên:   " + txtMaNV.Text;
                lbMaHD.Text = "Mã hóa đơn:   " + txtMaHD.Text;
                lbNgayTra.Text = "Ngày trả:   " + dtNgayTra.Value.ToString("dd/MM/yyyy");
            }
        }

        private void btClearAll_Click(object sender, EventArgs e)
        {
            frmBaoHanh baoHanh = new frmBaoHanh(nv);
            baoHanh.Show();
            this.Close();
        }

        private void btClearSP_Click(object sender, EventArgs e)
        {
            txtMaSP.Clear();
            txtSoLuong.Clear();
            cbLoi.SelectedIndex = -1;
            txtChiTietLoi.Clear();
        }

        private void btThemSP_Click(object sender, EventArgs e)
        {
            if (KiemTraNgoaiLe())
            {
                var pbhCheck = (from pbh in db.PhieuBaoHanhs
                                where pbh.MaPhieu == txtMaPhieu.Text
                                select pbh).FirstOrDefault();
                if (pbhCheck != null)
                {
                    if (txtMaSP.Text != "")
                    {
                        if (txtSoLuong.Text != "")
                        {
                            if (cbLoi.SelectedIndex != -1)
                            {
                                if (txtChiTietLoi.Text != "")
                                {
                                    var masanpham = (from msp in db.HoaDonBanHangSanPhams
                                                     where msp.MaHd == txtMaHD.Text && msp.MaSpCt == txtMaSP.Text
                                                     select msp).FirstOrDefault();
                                    if (masanpham != null)
                                    {
                                        var soluong = (from sl in db.HoaDonBanHangSanPhams
                                                       where sl.MaSpCt == txtMaSP.Text
                                                       select sl).FirstOrDefault();
                                        int SoLuong = int.Parse(txtSoLuong.Text);
                                        if (SoLuong <= soluong.SoLuongBan)
                                        {
                                            var maPhieu = (from mp in db.PhieuBaoHanhs
                                                           where mp.MaPhieu == txtMaPhieu.Text
                                                           select mp).FirstOrDefault();
                                            PhieuBaohanhSanPham pbhSP = new PhieuBaohanhSanPham();
                                            pbhSP.MaPhieu = maPhieu.MaPhieu;
                                            pbhSP.MaHd = maPhieu.MaHd;
                                            pbhSP.MaSpCt = txtMaSP.Text;
                                            pbhSP.Loi = cbLoi.Text;
                                            pbhSP.ChiTietLoi = txtChiTietLoi.Text;
                                            pbhSP.SoLuong = int.Parse(txtSoLuong.Text);
                                            db.PhieuBaohanhSanPhams.Add(pbhSP);
                                            db.SaveChanges();
                                            MessageBox.Show("Thêm thành công");
                                            HienThiDuLieu();
                                        }
                                        else
                                        {
                                            MessageBox.Show("Số lượng không hợp lệ, nhiều hơn số lượng mua");
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("Không có sản phẩm này trong hóa đơn");
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Chưa nhập chi tiết lỗi");
                                }
                            }
                            else
                            {
                                MessageBox.Show("Chưa chọn lỗi");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Bạn chưa nhập số lượng");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Bạn chưa nhập mã sản phẩm");
                        txtMaSP.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Chưa thêm phiếu bảo hành");
                }
            }
        }

        private void txtSoLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
                MessageBox.Show("Chỉ được nhập số");
            }
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            PhieuBaohanhSanPham pbhSPXoa = (from pbh in db.PhieuBaohanhSanPhams
                                            where pbh.MaSpCt == txtMaSP.Text
                                            select pbh).FirstOrDefault();
            if (txtMaSP.Text != "")
            {
                if (pbhSPXoa != null)
                {
                    DialogResult tl = MessageBox.Show("Bạn muốn xóa sản phẩm " + pbhSPXoa.MaSpCt + "?", "Cập nhật dữ liệu", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (tl == DialogResult.Yes)
                    {
                        db.Remove(pbhSPXoa);
                        db.SaveChanges();
                        HienThiDuLieu();
                    }
                }
                else
                {
                    MessageBox.Show("Không có sản phẩm " + txtMaSP.Text);
                }
            }
            else
            {
                MessageBox.Show("Chưa nhập mã sản phẩm");
                txtMaSP.Focus();
            }
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            if (txtMaSP.Text != "")
            {
                if (txtSoLuong.Text != "")
                {
                    if (cbLoi.SelectedIndex != -1)
                    {
                        if (txtChiTietLoi.Text != "")
                        {
                            var soluong = (from sl in db.HoaDonBanHangSanPhams
                                           where sl.MaSpCt == txtMaSP.Text
                                           select sl).FirstOrDefault();
                            int SoLuong = int.Parse(txtSoLuong.Text);
                            if (SoLuong <= soluong.SoLuongBan)
                            {
                                var pbhSpSua = (from pbh in db.PhieuBaohanhSanPhams
                                                where pbh.MaSpCt == txtMaSP.Text
                                                select pbh).FirstOrDefault();
                                pbhSpSua.SoLuong = int.Parse(txtSoLuong.Text);
                                pbhSpSua.Loi = cbLoi.Text;
                                pbhSpSua.ChiTietLoi = txtChiTietLoi.Text;
                                db.SaveChanges();
                                HienThiDuLieu();
                            }
                            else
                            {
                                MessageBox.Show("Số lượng không hợp lệ, nhiều hơn số lượng mua");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Chưa nhập chi tiết lỗi");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Chưa chọn lỗi");
                    }
                }
                else
                {
                    MessageBox.Show("Chưa nhập số lượng");
                }
            }
            else
            {
                MessageBox.Show("Chưa nhập mã sản phẩm");
                txtMaSP.Focus();
            }

        }

        private void dgvSanPham_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvSanPham.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dgvSanPham.CurrentRow.Selected = true;
                txtMaSP.Text = dgvSanPham.Rows[e.RowIndex].Cells["MaSP"].FormattedValue.ToString();
                txtSoLuong.Text = dgvSanPham.Rows[e.RowIndex].Cells["SoLuong"].FormattedValue.ToString();
                cbLoi.Text= dgvSanPham.Rows[e.RowIndex].Cells["Loi"].FormattedValue.ToString();
                txtChiTietLoi.Text = dgvSanPham.Rows[e.RowIndex].Cells["ChiTiet"].FormattedValue.ToString();
            }
        }
    }
}
