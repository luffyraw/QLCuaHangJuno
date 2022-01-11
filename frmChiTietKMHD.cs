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
    public partial class frmChiTietKMHD : Form
    {
        public frmChiTietKMHD()
        {
            InitializeComponent();
        }

        private void frmChiTietKMHD_Load(object sender, EventArgs e)
        {
            GiamGiaHoaDon km = (GiamGiaHoaDon)this.Tag;
            txtMaKM.Text = km.MaGg;
            txtTiLe.Text = km.TyLeGiamGia.ToString();
            txtDK.Text = km.DieuKienApDung.ToString();
            dtpNgayBD.Value = km.TgbatDau;
            dtpNgayKT.Value = km.TgketThuc;

        }
    }
}
