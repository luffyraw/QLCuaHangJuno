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
    public partial class frmPhieuDatHang : Form
    {
        QuanLyCuaHangJunoContext db = new QuanLyCuaHangJunoContext();
        int index = 0;
        public frmPhieuDatHang()
        {
            InitializeComponent();
        }

        private void frmPhieuDatHang_Load(object sender, EventArgs e)
        {
            HienThi();
        }
        private void HienThi()
        {
            var queryPhieuDat = from p in db.PhieuDatHangs
                                select new 
                                {
                                    MaPhieuDat = p.MaPhieuDat,
                                    NgayDat = p.NgayDat.ToString("dd-MM-yyyy HH:mm:ss"),
                                    ThoiHanGiaoHang = p.ThoiHanGiaoHang.ToString("dd-MM-yyyy")
                                };
            dgvPhieuDat.DataSource = queryPhieuDat.ToList();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            frmDatHang frm = new frmDatHang();
            frm.Show();
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            HienThi();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            var queryPhieu = from ph in db.PhieuDatHangs
                             where ph.MaPhieuDat == txtSearchMaPh.Text
                             select new
                             {
                                 MaPhieuDat = ph.MaPhieuDat,
                                 NgayDat = ph.NgayDat.ToString("dd-MM-yyyy HH:mm:ss"),
                                 ThoiHanGiaoHang = ph.ThoiHanGiaoHang.ToString("dd-MM-yyyy")
                             };
            dgvPhieuDat.DataSource = queryPhieu.ToList();
        }

        private void dgvPhieuDat_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
        }

        private void btnChiTietPh_Click(object sender, EventArgs e)
        {
            string maPhieu = dgvPhieuDat.Rows[index].Cells[0].Value.ToString();
            frmChiTietPhieuDat frm = new frmChiTietPhieuDat();
            frm.Tag = maPhieu;
            frm.Show();
        }
    }
}
