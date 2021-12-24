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
    public partial class frmKhuyenMaiHoaDon : Form
    {
        QuanLyCuaHangJunoContext db = new QuanLyCuaHangJunoContext();
        public frmKhuyenMaiHoaDon()
        {
            InitializeComponent();
        }

        private void HienThiDuLieu()
        {
            var query = from Gg in db.GiamGiaHoaDons
                        select new
                        {
                            Gg.MaGg,
                            Gg.TyLeGiamGia,
                            Gg.DieuKienApDung,
                            Gg.TgbatDau,
                            Gg.TgketThuc,
                        };
            dgvKMHD.DataSource = query.ToList();
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            GiamGiaHoaDon GgHD = new GiamGiaHoaDon();
            if (KiemTraDuLieu())
            {
                GgHD.MaGg = txtMaKM.Text;
                GgHD.TyLeGiamGia = double.Parse(txtTiLe.Text);
                GgHD.DieuKienApDung = decimal.Parse(txtDK.Text);
                GgHD.TgbatDau = dtpNgayBD.Value;
                GgHD.TgketThuc = dtpNgayKT.Value;
                if (!db.GiamGiaHoaDons.Contains(GgHD))
                {
                    db.GiamGiaHoaDons.Add(GgHD);
                    db.SaveChanges();
                    HienThiDuLieu();
                }
                else
                {
                    MessageBox.Show("Đã có mã khuyễn mãi " + txtMaKM.Text, "THÊM DỮ LIỆU", MessageBoxButtons.OK);
                }
            }
        }
        private bool KiemTraDuLieu()
        {
            bool duLieuHopLe = false;
            if (txtMaKM.Text != "")
            {
                errorProvider1.SetError(txtMaKM, null);
                try 
                {
                    double tile = double.Parse(txtTiLe.Text);
                    if (tile >=0)
                    {
                        errorProvider1.SetError(txtTiLe, null);
                        try
                        {
                            var dkap = decimal.Parse(txtDK.Text);
                            if (dkap>=0)
                            {
                                errorProvider1.SetError(txtDK, null);
                                {
                                    var ngaybd = dtpNgayBD.Value;
                                    if (dtpNgayBD.Text != "")
                                    {
                                        errorProvider1.SetError(dtpNgayBD, null);
                                        {
                                            var ngaykt = dtpNgayKT.Value;
                                            if(dtpNgayKT.Text != "" && ngaykt>=ngaybd)
                                            {
                                                errorProvider1.SetError(dtpNgayKT, null);
                                                duLieuHopLe = true;
                                            }
                                            else
                                            {
                                                errorProvider1.SetError(dtpNgayKT, "Ngày kết thúc phải lơn hơn ngày bắt đầu!");
                                            }
                                        }
                                    }
                                    else
                                    {
                                        errorProvider1.SetError(dtpNgayBD, "Ngày bắt đầu không được để trống!");
                                    }
                                }
                            }
                            else
                            {
                                errorProvider1.SetError(txtDK, "Điều kiện áp dụng phải lớn hơn hoặc bằng 0!");
                            }
                        }
                        catch (Exception)
                        {
                            errorProvider1.SetError(txtDK, "Điều kiện áp dụng phải là một số!");
                        }
                    }
                    else
                    {
                        errorProvider1.SetError(txtTiLe, "Tỉ lệ khuyến mãi phải lớn hơn hoặc bằng 0!");
                    }
                }
                catch (Exception)
                {
                    errorProvider1.SetError(txtTiLe, "Tỉ lệ phải là một số!");
                }
            }
            else
            {
                errorProvider1.SetError(txtMaKM, "Mã khuyến mãi không được để trống!");
                txtMaKM.Focus();
            }
            return duLieuHopLe;
        }

        private void frmKhuyenMaiHoaDon_Load(object sender, EventArgs e)
        {
            HienThiDuLieu();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            var query = (from Gg in db.GiamGiaHoaDons
                         where Gg.MaGg == txtMaKM.Text
                         select Gg).FirstOrDefault();
            if (KiemTraDuLieu())
            {
                query.TyLeGiamGia = double.Parse(txtTiLe.Text);
                query.DieuKienApDung =decimal.Parse( txtDK.Text);
                query.TgbatDau = dtpNgayBD.Value;
                query.TgketThuc = dtpNgayKT.Value;
                db.SaveChanges();
                HienThiDuLieu();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            GiamGiaHoaDon GgXoa = (from km in db.GiamGiaHoaDons
                               where km.MaGg == txtMaKM.Text
                               select km).FirstOrDefault();

            if (GgXoa != null)
            {
                DialogResult kq = MessageBox.Show("Bạn muốn xóa mã giảm giá " + GgXoa.MaGg + "? ", "CẬP NHẬT DỮ LIỆU", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (kq == DialogResult.Yes)
                {
                    txtMaKM.Text = "";
                    txtTiLe.Text = "";
                    txtDK.Text = "";
                    dtpNgayBD.Value = DateTime.Now;
                    dtpNgayKT.Value = DateTime.Now;
                    db.Remove(GgXoa);
                    db.SaveChanges();
                    HienThiDuLieu();
                }
            }
            else
            {
                MessageBox.Show("Không có giảm giá hóa đơn " + txtMaKM.Text);
            }
        }
        private void btnChiTiet_Click(object sender, EventArgs e)
        {
            frmChiTietKMHD chitiet = new frmChiTietKMHD();
            GiamGiaHoaDon kmShow = (from km in db.GiamGiaHoaDons
                                where km.MaGg == txtMaKM.Text
                                select km).FirstOrDefault();
            if (kmShow != null)
            {
                chitiet.Tag = kmShow;
                chitiet.Show();
            }
        }

        private void dgvKMHD_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvKMHD.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dgvKMHD.CurrentRow.Selected = true;
                txtMaKM.Text = dgvKMHD.Rows[e.RowIndex].Cells["MaGg"].FormattedValue.ToString();
                dtpNgayBD.Text = dgvKMHD.Rows[e.RowIndex].Cells["TgbatDau"].FormattedValue.ToString();
                dtpNgayKT.Text = dgvKMHD.Rows[e.RowIndex].Cells["TgketThuc"].FormattedValue.ToString();
                txtTiLe.Text = dgvKMHD.Rows[e.RowIndex].Cells["TyLeGiamGia"].FormattedValue.ToString();
                txtDK.Text = dgvKMHD.Rows[e.RowIndex].Cells["DieuKienApDung"].FormattedValue.ToString();

            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            var query = from km in db.GiamGiaHoaDons
                        where (km.MaGg == txtTimkiem.Text 
                               || km.TyLeGiamGia == int.Parse(txtTimkiem.Text)
                               || km.DieuKienApDung== int.Parse(txtTimkiem.Text))
                        select km;
            if (query!=null)
            {
                dgvKMHD.DataSource = query.ToList();
            }
            else
            {
                MessageBox.Show("Không tồn tại mã " + txtTimkiem.Text, "THÊM DỮ LIỆU", MessageBoxButtons.OK);
            }
           
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtMaKM.Text = "";
            txtTiLe.Text = "";
            txtDK.Text = "";
            dtpNgayBD.Value = DateTime.Now;
            dtpNgayKT.Value = DateTime.Now;
        }
    }
}
