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
                                select p;
            dgvPhieuDat.DataSource = queryPhieuDat.ToList();
        }
    }
}
