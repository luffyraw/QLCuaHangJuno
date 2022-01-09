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
    public partial class DSPhieuDoi : Form
    {
        QuanLyCuaHangJunoContext db = new QuanLyCuaHangJunoContext();
        public DSPhieuDoi()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                dateTimePicker1.Enabled = true;
            }
            else
            {
                dateTimePicker1.Enabled = false;
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtMaPD.Text = null;
            txtMaHD.Text = null;
            txtMaNV.Text = null;
            dateTimePicker1.Value = DateTime.Now;
            checkBox1.Checked = false;
            txtMaPD.Focus();
            HienThiDuLieu();
        }
        private void HienThiDuLieu()
        {

            Focus();
            var query = from p in db.PhieuDoiHangs
                        select new
                        {
                            p.MaPhieuDoi,
                            NgayLap = p.NgayLap.ToString("dd/MM/yyyy"),
                            p.MaNv,
                            p.MaHd,
                            p.TienThua,
                            p.TienThuLai
                        };
            dataGridView1.DataSource = query.ToList();
            /* query = "SELECT * FROM PhieuTraHang";
             //var qr = from tl in db.TheLoais
             //         select new
             //         {
             //             tl.MaTheLoai,
             //             tl.TenTheLoai,
             //         };
             connect = new SqlConnection(connectString);

             connect.Open();
             SqlDataAdapter adt = new SqlDataAdapter(query, connect);
             DataTable table = new DataTable();
             adt.Fill(table);
             //dgv_theloai.DataSource = qr.ToList();
             dataGridView1.DataSource = table;
             connect.Close();*/

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void DSPhieuDoi_Load(object sender, EventArgs e)
        {
            HienThiDuLieu();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows.Count > 0 && e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewCell cell = dataGridView1.Rows[e.RowIndex].Cells[0];
                if (cell != null && !String.IsNullOrEmpty(cell.Value as string))
                {
                    // do something
                    txtMaPD.Text = cell.Value.ToString();
                }
            }
        }

        public bool checkMaPD()
        {
            if (txtMaPD.Text.Length > 10)
            {
                errorProvider1.SetError(txtMaPD, "Mã phiếu trả hàng <= 10 kí tự!");

                //MessageBox.Show("Bạn không được để trống tên!");
                return false;
            }
            else
            {
                errorProvider1.SetError(txtMaPD, "");
                return true;
            }
        }

        public bool checkMaNV()
        {
            if (txtMaNV.Text.Length > 10)
            {
                errorProvider1.SetError(txtMaNV, "Mã nhân viên <= 10 kí tự!");

                //MessageBox.Show("Bạn không được để trống tên!");
                return false;
            }
            else
            {
                errorProvider1.SetError(txtMaNV, "");
                return true;
            }
        }

        public bool checkMaHD()
        {
            if (txtMaHD.Text.Length > 10)
            {
                errorProvider1.SetError(txtMaHD, "Mã hóa đơn <= 10 kí tự!");

                //MessageBox.Show("Bạn không được để trống tên!");
                return false;
            }
            else
            {
                errorProvider1.SetError(txtMaHD, "");
                return true;
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (checkMaPD() && checkMaNV() && checkMaHD())
            {

                var query = from p in db.PhieuDoiHangs
                            select new
                            {
                                p.MaPhieuDoi,
                                NgayLap = p.NgayLap.Date.ToString("dd/MM/yyyy"),
                                p.MaNv,
                                p.MaHd,
                                p.TienThua,
                                p.TienThuLai
                            };

                if (txtMaPD.Text != null && txtMaPD.Text != "")
                {
                    query = query.Where(p => p.MaPhieuDoi == txtMaPD.Text);
                }
                if (txtMaHD.Text != null && txtMaHD.Text != "")
                {
                    query = query.Where(p => p.MaHd == txtMaHD.Text);
                }
                if (txtMaNV.Text != null && txtMaNV.Text != "")
                {
                    query = query.Where(p => p.MaNv == txtMaNV.Text);
                }
                if (dateTimePicker1.Enabled == true)
                {

                    query = query.Where(p => (p.NgayLap) == dateTimePicker1.Value.Date.ToString("dd/MM/yyyy"));
                    //MessageBox.Show(dateTimePicker1.Value.Date);
                }

                dataGridView1.DataSource = query.ToList();

                if (query.ToList().Count <= 0)
                {
                    MessageBox.Show("Không có phiếu trả nào phù hợp với điều kiện bạn tìm kiếm");
                }
            }
            else
            {

                if (!checkMaPD())
                {
                    txtMaPD.Focus();
                }
                else if (!checkMaHD())
                {
                    txtMaHD.Focus();
                }
                else if (!checkMaNV())
                {
                    txtMaNV.Focus();
                }

            }
        }

        private void btnChiTiet_Click(object sender, EventArgs e)
        {
            if (txtMaPD.Text != "" && txtMaPD.Text != null)
            {
                var pth = (from p in db.PhieuDoiHangs
                           where p.MaPhieuDoi == txtMaPD.Text
                           select p).ToList();
                if (pth.Count > 0)
                {
                    ChiTietPhieuDoi ct = new ChiTietPhieuDoi(txtMaPD.Text);
                    ct.Show();
                }
                else
                {
                    MessageBox.Show("ERR: Không tìm thấy phiếu trùng với mã bạn nhập !");
                }

            }
            else
            {
                MessageBox.Show("ERR: Bạn chưa nhập mã phiếu đổi hàng !");
            }
        }
    }
}
