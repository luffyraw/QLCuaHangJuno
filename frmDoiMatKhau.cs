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
    public partial class frmDoiMatKhau : Form
    {
        QuanLyCuaHangJunoContext db = new QuanLyCuaHangJunoContext();
        NhanVien nv = new NhanVien();
        public frmDoiMatKhau(NhanVien nv)
        {
            this.nv = nv;
            InitializeComponent();
        }

        private void frmDoiMatKhau_Load(object sender, EventArgs e)
        {

        }

        private void btCapNhat_Click(object sender, EventArgs e)
        {
            if (txtMkCu.Text == nv.MatKhau)
            {
                if (txtMkMoi.Text == txtReMkMoi.Text)
                {
                    var query = from nvp in db.NhanViens
                                where nvp.MaNv == nv.MaNv
                                select nvp;
                    NhanVien nvSua = query.FirstOrDefault();
                    nvSua.MatKhau = txtMkMoi.Text;
                    db.SaveChanges();
                    DialogResult tl = MessageBox.Show("Đổi mật khẩu thành công", "Thông báo", MessageBoxButtons.OK);
                    if (tl == DialogResult.OK)
                    {
                        this.Visible = false;
                    }
                }
                else
                {
                    MessageBox.Show("Nhập lại mật khẩu mới không chính xác");
                }
            }
            else
            {
                MessageBox.Show("Mật khẩu hiện tại không chính xác");
            }

        }

        private void btHuy_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }
    }
}
