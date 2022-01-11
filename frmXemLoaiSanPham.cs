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
    public partial class frmXemLoaiSanPham : Form
    {
        QuanLyCuaHangJunoContext db = new QuanLyCuaHangJunoContext();
        public frmXemLoaiSanPham()
        {
            InitializeComponent();
        }

        private void frmXemLoaiSanPham_Load(object sender, EventArgs e)
        {
            var query = from lsp in db.LoaiSanPhams
                        select lsp;
            dgvLoaiSanPham.DataSource = query.ToList();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            var query = db.LoaiSanPhams.Where(x => x.TenLoaiSp.Contains(txtSearchLSp.Text));
            dgvLoaiSanPham.DataSource = query.ToList();
        }
    }
}
