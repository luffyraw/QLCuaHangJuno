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
    public partial class frmKhuyenMai : Form
    {
        QuanLyCuaHangJunoContext db = new QuanLyCuaHangJunoContext();
        public frmKhuyenMai()
        {
            InitializeComponent();
        }

        private void frmKhuyenMai_Load(object sender, EventArgs e)
        {
            HienThiDuLieu();
        }
        private void HienThiDuLieu()
        {
            var query = from km in db.KhuyenMais
                        select km;
            
            dgvKM.DataSource = query.ToList();

        }
        private bool KiemTraDuLieu()
        {
            bool duLieuHopLe = false;
            if (txtMaKM.Text != "")
            {
                errorProvider1.SetError(txtMaKM, null);
                
                {
                    var ngaybd = dtpNgayBD.Value;
                    if (ngaybd.Day>=DateTime.Now.Day && ngaybd.Month>=DateTime.Now.Month)
                    {
                        errorProvider1.SetError(dtpNgayBD, null);
                        {
                            var ngaykt = dtpNgayKT.Value;
                            if ( ngaykt.Day >= ngaybd.Day && ngaykt.Month>=ngaybd.Month)
                            {
                                errorProvider1.SetError(dtpNgayKT, null);
                                duLieuHopLe = true;
                            }
                            else
                            {
                                errorProvider1.SetError(dtpNgayKT, "Ngày kết thúc phải lơn hơn hoặc bằng ngày bắt đầu và ngày hiện tại!");
                            }
                        }
                    }
                    else
                    {
                        errorProvider1.SetError(dtpNgayBD, "Ngày bắt đầu phải lơn hơn hoặc bằng ngày hiện tại!");
                    }
                 }
            }
            else
            {
                errorProvider1.SetError(txtMaKM, "Mã khuyến mãi không được để trống!");
            }
             
            
            return duLieuHopLe;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            KhuyenMai km = new KhuyenMai();
            if (KiemTraDuLieu())
            {
                km.MaKm = txtMaKM.Text;
                km.NgayBatDau = dtpNgayBD.Value;
                km.NgayKetThuc = dtpNgayKT.Value;
                if (!db.KhuyenMais.Contains(km))
                {
                    db.KhuyenMais.Add(km);
                    db.SaveChanges();
                    MessageBox.Show("Đã thêm mã khuyễn mãi " + txtMaKM.Text);
                    HienThiDuLieu();
                }
                else
                {
                    MessageBox.Show("Đã có mã khuyễn mãi " + txtMaKM.Text, "THÊM DỮ LIỆU", MessageBoxButtons.OK);
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            var query = (from km in db.KhuyenMais
                         where km.MaKm == txtMaKM.Text
                         select km).FirstOrDefault();
            if (KiemTraDuLieu())
            {
                query.MaKm = txtMaKM.Text;
                query.NgayBatDau = dtpNgayBD.Value;
                query.NgayKetThuc = dtpNgayKT.Value;
                db.SaveChanges();
                HienThiDuLieu();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            KhuyenMai kmXoa = (from km in db.KhuyenMais
                                   where km.MaKm == txtMaKM.Text
                                   select km).FirstOrDefault();

            if (kmXoa != null)
            {
                DialogResult kq = MessageBox.Show("Bạn muốn xóa mã giảm giá " + kmXoa.MaKm + "? ", "CẬP NHẬT DỮ LIỆU", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (kq == DialogResult.Yes)
                {
                    txtMaKM.Text = "";
                    dtpNgayBD.Value = DateTime.Now;
                    dtpNgayKT.Value = DateTime.Now;
                    db.Remove(kmXoa);
                    db.SaveChanges();
                    HienThiDuLieu();
                }
            }
            else
            {
                MessageBox.Show("Không có khách hàng " + txtMaKM.Text);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvKM_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvKM.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dgvKM.CurrentRow.Selected = true;
                txtMaKM.Text = dgvKM.Rows[e.RowIndex].Cells["MaKM"].FormattedValue.ToString();
                dtpNgayBD.Text = dgvKM.Rows[e.RowIndex].Cells["NgayBatDau"].FormattedValue.ToString();
                dtpNgayKT.Text = dgvKM.Rows[e.RowIndex].Cells["NgayKetThuc"].FormattedValue.ToString();

            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtMaKM.Text = "";
            dtpNgayBD.Value = DateTime.Now;
            dtpNgayKT.Value = DateTime.Now;
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            var query = from km in db.KhuyenMais
                        where km.MaKm == txtTimkiem.Text
                        select km;
            if (query.Count() > 0)
            {
                dgvKM.DataSource = query.ToList();
            }
            else
            {
                MessageBox.Show("Không tồn tại mã " + txtTimkiem.Text, "THÊM DỮ LIỆU", MessageBoxButtons.OK);
            }
            
        }
    }
}
