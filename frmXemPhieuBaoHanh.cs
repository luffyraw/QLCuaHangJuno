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
    public partial class frmXemPhieuBaoHanh : Form
    {
        QuanLyCuaHangJunoContext db = new QuanLyCuaHangJunoContext();
        NhanVien nv = new NhanVien();

        public frmXemPhieuBaoHanh(NhanVien nv)
        {
            this.nv = nv;
            InitializeComponent();
        }

        private void frmXemPhieuBaoHanh_Load(object sender, EventArgs e)
        {
            var phieuBaoHanh = from pbh in db.PhieuBaoHanhs
                               select new
                               {
                                   pbh.MaPhieu,
                                   pbh.NgayLapPhieu,
                                   pbh.MaNv,
                                   pbh.MaHd,
                                   pbh.NgayTra
                               };
            dgvBaoHanh.DataSource = phieuBaoHanh.ToList();
        }

        private void btXem_Click(object sender, EventArgs e)
        {
            if (txtMaPhieu.Text != "")
            {
                var phieuBH = (from pbh in db.PhieuBaoHanhs
                              where pbh.MaPhieu == txtMaPhieu.Text
                              select pbh).FirstOrDefault();
                if (phieuBH != null)
                {
                    var maphieuBH = (from mbh in db.PhieuBaoHanhs
                                     where mbh.MaPhieu == txtMaPhieu.Text
                                     select mbh).FirstOrDefault();

                    lbMaPhieu.Text = "Mã phiếu:   " + maphieuBH.MaPhieu;
                    lbNgayLap.Text = "Ngày lập phiếu:   " + maphieuBH.NgayLapPhieu.ToString("dd/MM/yyyy");
                    lbMaNV.Text = "Mã nhân viên:   " + maphieuBH.MaNv;
                    lbMaHD.Text = "Mã hóa đơn:   " + maphieuBH.MaHd;
                    lbNgayTra.Text = "Ngày trả:   " + maphieuBH.NgayTra.ToString("dd/MM/yyyy");

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
                else
                {
                    MessageBox.Show("Phiếu bảo hành mã " + txtMaPhieu.Text + " không tồn tại");
                }    
            }
            else
            {
                MessageBox.Show("Chưa nhập mã phiếu");
                txtMaPhieu.Focus();
            }
        }

        private void dgvBaoHanh_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvBaoHanh.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dgvBaoHanh.CurrentRow.Selected = true;
                txtMaPhieu.Text = dgvBaoHanh.Rows[e.RowIndex].Cells["MaPhieu"].FormattedValue.ToString();
            }
        }
    }
}
