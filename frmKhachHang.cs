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
    public partial class frmKhachHang : Form
    {
        QuanLyCuaHangJunoContext db = new QuanLyCuaHangJunoContext();
        public frmKhachHang()
        {
            InitializeComponent();
        }

        private void frmKhachHang_Load(object sender, EventArgs e)
        {
           HienThiDuLieu();
        }
        private void HienThiDuLieu()
        {
            var query = from kh in db.KhachHangs
                        select new
                        {
                            kh.MaKh,
                            kh.HoTenKh,
                            kh.Sdt,
                            kh.DiaChi,
                        };
            dgvKhachHang.DataSource = query.ToList();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            KhachHang khNew = new KhachHang();
            if (KiemTraDuLieu())
            {
                khNew.MaKh = txtMa.Text;
                khNew.HoTenKh = txtTen.Text;
                khNew.Sdt = txtSdt.Text;
                khNew.DiaChi = txtDC.Text;
                if (!db.KhachHangs.Contains(khNew))
                {
                    db.KhachHangs.Add(khNew);
                    db.SaveChanges();
                    MessageBox.Show("Đã thêm khách hàng " + txtMa.Text);
                    HienThiDuLieu();
                }
                else
                {
                    MessageBox.Show("Đã có khách hàng " + txtMa.Text, "THÊM DỮ LIỆU", MessageBoxButtons.OK);
                }
            }

        }

        private bool KiemTraDuLieu()
        {
            bool duLieuHopLe = false;
            if (txtMa.Text != "")
            {
                errorProvider1.SetError(txtMa, null);
                {
                    if (txtTen.Text != "")
                    {
                        
                        errorProvider1.SetError(txtTen, null);
                        try
                        {
                            if (txtSdt.Text != "")
                            {
                                errorProvider1.SetError(txtSdt, null);
                                {
                                    if (txtDC.Text != "")
                                    {
                                        errorProvider1.SetError(txtDC, null);
                                        duLieuHopLe = true;
                                    }
                                    else
                                    {
                                        errorProvider1.SetError(txtDC, "Địa chỉ không được để trống!");
                                    }
                                }
                            }
                            else
                            {
                                errorProvider1.SetError(txtSdt, "SĐT không được để trống!");
                            }

                        }
                        catch (Exception)
                        {
                            errorProvider1.SetError(txtSdt, "SĐT là một số");
                        }
                    }
                    else
                    {
                        errorProvider1.SetError(txtTen, "Họ tên không được để trống!");
                    }
                }
            }
            else
            {
                errorProvider1.SetError(txtMa, "Mã khách hàng không được để trống!");
                txtMa.Focus();
            }
            return duLieuHopLe;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            var query = (from kh in db.KhachHangs
                         where kh.MaKh == txtMa.Text
                         select kh).FirstOrDefault();
            if (KiemTraDuLieu())
            {
                query.HoTenKh = txtTen.Text;
                query.Sdt = txtSdt.Text;
                query.DiaChi = txtDC.Text;

                db.SaveChanges();
                HienThiDuLieu();
            }

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            KhachHang khXoa = (from kh in db.KhachHangs
                               where kh.MaKh == txtMa.Text
                               select kh).FirstOrDefault();

            if (khXoa != null)
            {
                DialogResult kq = MessageBox.Show("Bạn muốn xóa khách hàng " + khXoa.HoTenKh + "? ", "CẬP NHẬT DỮ LIỆU", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (kq == DialogResult.Yes)
                {
                    txtMa.Text = "";
                    txtTen.Text = "";
                    txtSdt.Text = "";
                    txtDC.Text = "";
                    db.Remove(khXoa);
                    db.SaveChanges();
                    HienThiDuLieu();
                }
            }
            else
            {
                MessageBox.Show("Không có khách hàng " + txtTen.Text);
            }
        }

        private void dgvKhachHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvKhachHang.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dgvKhachHang.CurrentRow.Selected = true;
                txtMa.Text = dgvKhachHang.Rows[e.RowIndex].Cells["MaKh"].FormattedValue.ToString();
                txtTen.Text = dgvKhachHang.Rows[e.RowIndex].Cells["HoTenKh"].FormattedValue.ToString();
                txtSdt.Text = dgvKhachHang.Rows[e.RowIndex].Cells["Sdt"].FormattedValue.ToString();
                txtDC.Text = dgvKhachHang.Rows[e.RowIndex].Cells["DiaChi"].FormattedValue.ToString();
            }
        }

        private void btnChiTiet_Click(object sender, EventArgs e)
        {
            frmChiTietKhachHang chitiet = new frmChiTietKhachHang();
            KhachHang khShow = (from kh in db.KhachHangs
                                where kh.MaKh == txtMa.Text
                                select kh).FirstOrDefault();
            if (khShow != null)
            {
                chitiet.Tag = khShow;
                chitiet.Show();
            }

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            var query = from kh in db.KhachHangs
                        where kh.MaKh == txtTim.Text || kh.HoTenKh == txtTim.Text
                        select new
                        {
                            kh.MaKh,
                            kh.HoTenKh,
                            kh.Sdt,
                            kh.DiaChi,
                        };

            if (query.Count()>0)
            {
                dgvKhachHang.DataSource = query.ToList();
            }
            else
            {
                HienThiDuLieu();
                MessageBox.Show("Không có khách hàng " + txtTim.Text);
            }
        }
    }
}
