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
    public partial class frmKhuyenMaiSanPham : Form
    {
        QuanLyCuaHangJunoContext db = new QuanLyCuaHangJunoContext();
        public frmKhuyenMaiSanPham()
        {
            InitializeComponent();
        }

        private void HienThiDuLieu()
        {
            var query = from km in db.KhuyenMaiSanPhams
                        select new { 
                            km.MaKm,
                            km.MaSp,
                            km.TyLeKhuyenMai,
                            km.MaKmNavigation.NgayBatDau,
                            km.MaKmNavigation.NgayKetThuc,
                            km.MaSpNavigation.MaLoaiSp,
                        };
            
           /* foreach (var item in query)
            {
                if (item.NgayKetThuc < DateTime.Now)
                {
                    db.Remove(item);
                    
                }
            }*/
            dgvKMSP.DataSource = query.ToList();

        }
        private bool KiemTraDuLieu()
        {
            bool duLieuHopLe = false;
            if (cbMaKM.Text != "")
            {
                errorProvider1.SetError(cbMaKM, null);
                try
                {
                    double tile = double.Parse(txtTyLe.Text);
                    if (tile >= 0)
                    {
                        errorProvider1.SetError(txtTyLe, null);

                        duLieuHopLe = true;

                    }
                    else
                    {
                        errorProvider1.SetError(txtTyLe, "Tỉ lệ khuyến mãi phải lớn hơn hoặc bằng 0!");
                    }
                }
                catch (Exception)
                {
                    errorProvider1.SetError(txtTyLe, "Tỉ lệ phải là một số!");
                }
            }
            else
            {
                errorProvider1.SetError(cbMaKM, "Mã khuyến mãi không được để trống!");
                cbMaSP.Focus();
            }
            return duLieuHopLe;
        }

        private void btnThem_Click_1(object sender, EventArgs e)
        {
            KhuyenMaiSanPham kmsp = new KhuyenMaiSanPham();
            var lstsp = (from sp in db.SanPhams
                         where sp.MaLoaiSp == cbMaLoaiSP.Text
                         select new {
                             sp.MaSp,
                         }).ToList();
            if (KiemTraDuLieu())
            {
                if (cbMaSP.Text != "")
                {
                    kmsp.MaKm = cbMaKM.Text;
                    kmsp.MaSp = cbMaSP.Text;
                    kmsp.TyLeKhuyenMai = int.Parse(txtTyLe.Text);
                    if (!db.KhuyenMaiSanPhams.Contains(kmsp))
                    {
                        db.KhuyenMaiSanPhams.Add(kmsp);
                        db.SaveChanges();
                        MessageBox.Show("Đã thêm khuyễn mãi ");
                        HienThiDuLieu();
                    }
                    else
                    {
                        MessageBox.Show("Đã có mã khuyễn mãi ", "THÊM DỮ LIỆU", MessageBoxButtons.OK);
                    }
                }
                else if( cbMaLoaiSP.Text != "")
                {
                    if (!db.KhuyenMaiSanPhams.Contains(kmsp))
                    {
                        foreach (var item in lstsp)
                        {
                                kmsp.MaKm = cbMaKM.Text;
                                kmsp.TyLeKhuyenMai =int.Parse( txtTyLe.Text);
                                kmsp.MaSp = item.MaSp;
                                db.KhuyenMaiSanPhams.Add(kmsp);         
                        }
                    }
                    else
                    {
                        MessageBox.Show("Đã có mã khuyễn mãi ", "THÊM DỮ LIỆU", MessageBoxButtons.OK);
                    }
                    db.SaveChanges();
                    HienThiDuLieu();
                }
                
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            var query = (from km in db.KhuyenMaiSanPhams
                         where km.MaSp == cbMaSP.Text 
                         select km).FirstOrDefault();
            if (KiemTraDuLieu())
            {
                query.MaKm = cbMaKM.Text;
                query.MaSp = cbMaSP.Text;
                query.TyLeKhuyenMai = int.Parse(txtTyLe.Text);
                db.SaveChanges();
                HienThiDuLieu();
            }
        }


        private void frmKhuyenMaiSanPham_Load(object sender, EventArgs e)
        {
            HienThiDuLieu();

            var queryCombo = from lsp in db.SanPhams
                             select lsp;
            var queryCombo1 = from lsp in db.LoaiSanPhams
                              select lsp;
            cbMaLoaiSP.DataSource = queryCombo1.ToList();
            cbMaLoaiSP.ValueMember = "MaLoaiSp";
            cbMaLoaiSP.DisplayMember = "MaLoai";
            cbMaLoaiSP.Text = "";
            cbMaSP.DataSource = queryCombo.ToList();
            cbMaSP.ValueMember = "MaSp";
            cbMaSP.Text = "";
            var queryCombo2 = from lsp1 in db.KhuyenMais
                              select lsp1;
            cbMaKM.DataSource = queryCombo2.ToList();
            cbMaKM.ValueMember = "MaKm";
            cbMaKM.Text = "";
            
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            KhuyenMaiSanPham kmXoa = (from kmsp in db.KhuyenMaiSanPhams
                                      
                                      where kmsp.MaKm == cbMaKM.Text
                                   select kmsp).FirstOrDefault();

            if (kmXoa != null)
            {
                DialogResult kq = MessageBox.Show("Bạn muốn xóa mã giảm giá " + kmXoa.MaKm + "? ", "CẬP NHẬT DỮ LIỆU", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (kq == DialogResult.Yes)
                {
                    
                    db.Remove(kmXoa);
                    db.SaveChanges();
                    cbMaKM.Text = "";
                    cbMaSP.Text = "";
                    txtTyLe.Text = "";
                    cbMaLoaiSP.Text = "";
                    HienThiDuLieu();
                }
            }
            else
            {
                MessageBox.Show("Không có sp km  " + cbMaKM.Text);
            }
        }

        private void dgvKMSP_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvKMSP.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dgvKMSP.CurrentRow.Selected = true;
                cbMaKM.Text = dgvKMSP.Rows[e.RowIndex].Cells["MaKM"].FormattedValue.ToString();
                cbMaSP.Text = dgvKMSP.Rows[e.RowIndex].Cells["Masanpham"].FormattedValue.ToString();
                txtTyLe.Text = dgvKMSP.Rows[e.RowIndex].Cells["TyLeKhuyenMai"].FormattedValue.ToString();
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnChitiet_Click(object sender, EventArgs e)
        {
            frmChiTietKhuyenMaiSanPham chitiet = new frmChiTietKhuyenMaiSanPham( cbMaSP.Text);
            chitiet.Show();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            cbMaKM.Text = "";
            cbMaSP.Text = "";
            cbMaLoaiSP.Text = "";
            txtTyLe.Text = "";
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            var query = from km in db.KhuyenMaiSanPhams
                        where (km.MaKm == txtTimkiem.Text
                            || km.MaSp == txtTimkiem.Text
                            || km.TyLeKhuyenMai.ToString() == txtTimkiem.Text
                            )
                        select new
                        {
                            MaKm = km.MaKm,
                            MaSp = km.MaSp,
                            TyLeKhuyenMai = km.TyLeKhuyenMai,
                            NgayBatDau = km.MaKmNavigation.NgayBatDau,
                            NgayKetThuc = km.MaKmNavigation.NgayKetThuc,
                            MaLoaiSp = km.MaSpNavigation.MaLoaiSp,
                        };
            if (query.Count()>0)
            {
                dgvKMSP.DataSource = query.ToList();
            }
            else
            {
                MessageBox.Show("Không tồn tại mã " + txtTimkiem.Text, "THÊM DỮ LIỆU", MessageBoxButtons.OK);
            }
        }

        private void btnKM_Click(object sender, EventArgs e)
        {
            frmKhuyenMai km = new frmKhuyenMai();
            km.Show();
        }

        
    }
}
