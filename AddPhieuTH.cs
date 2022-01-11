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
    public partial class AddPhieuTH : Form
    {
        QuanLyCuaHangJunoContext db = new QuanLyCuaHangJunoContext();
        int index = 0;
        public AddPhieuTH()
        {
            InitializeComponent();
        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void AddPhieuTH_Load(object sender, EventArgs e)
        {
            var query = (from pth in db.PhieuTraHangs
                         select pth);
            if (query.ToList().Count >= 0 && query.ToList().Count <= 8)
            {
                lbMaPhieuTH.Text = "PT00" + (query.ToList().Count + 1);
            }
            else if (query.ToList().Count >= 9 && query.ToList().Count <= 98)
            {
                lbMaPhieuTH.Text = "PT0" + (query.ToList().Count + 1);
            }
            else
            {
                lbMaPhieuTH.Text = "PT" + (query.ToList().Count + 1);
            }

            lbNgayLap.Text = DateTime.Now.ToString("dd/MM/yyyy");

            txtMaNV.Text = "NV001";
            txtMaNV.Enabled = false;
            var nv = (from n in db.NhanViens
                      where n.MaNv == "NV001"
                      select n).FirstOrDefault();
            txtTenNV.Text = nv.HoTenNv;
            txtTenNV.Enabled = false;

            var queryCombo = from HD in db.HoaDonBanHangs
                             select HD;
            cbMaHD.DataSource = queryCombo.ToList();
            cbMaHD.DisplayMember = "MaHd";
            cbMaHD.ValueMember = "MaHd";
        }

        private void cbMaHD_SelectedIndexChanged(object sender, EventArgs e)
        {
            var query = (from spct in db.HoaDonBanHangSanPhams
                         where spct.MaHd == cbMaHD.Text
                         select
                         new
                         {
                             spct.MaSpCt,
                         });

            cbMaSPCT.DataSource = query.ToList();
            cbMaSPCT.DisplayMember = "MaSpCt";
            cbMaSPCT.ValueMember = "MaSpCt";

            var a = (from h in db.HoaDonBanHangs
                     where h.MaHd == cbMaHD.Text
                     select h).ToList();


            if (a.Count > 0)
            {
                if (a.FirstOrDefault() != null)
                {
                    KhachHang kh = (from k in db.KhachHangs
                                    where k.MaKh == a.FirstOrDefault().MaKh
                                    select k).FirstOrDefault();
                    txtTenKH.Text = kh.HoTenKh;
                    txtTenKH.Enabled = false;
                    txtSDTKH.Text = kh.Sdt;
                    txtSDTKH.Enabled = false;
                    txtDCKH.Text = kh.DiaChi;
                    txtDCKH.Enabled = false;
                }

            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddSP_Click(object sender, EventArgs e)
        {
            if (checkLiDo())
            {

                var query = (from spct in db.SanPhamChiTiets
                             where spct.MaSpCt == cbMaSPCT.Text
                             select spct).FirstOrDefault();
                var query2 = (from sp in db.SanPhams
                              where sp.MaSp == query.MaSp
                              select sp).FirstOrDefault();


                listView1.Items.Add((index + 1).ToString());
                listView1.Items[index].SubItems.Add(query2.MaSp);
                listView1.Items[index].SubItems.Add(query2.TenSp);
                listView1.Items[index].SubItems.Add(txtLiDoTra.Text);
                index++;

                btnAddSP.Enabled = false;
                cbMaHD.Enabled = false;
                cbMaSPCT.Enabled = false;
                txtLiDoTra.Enabled = false;

                /*try
                {
                    
                }catch(Exception e)
                {

                }*/

            }
            else
            {
                checkLiDo();
                txtLiDoTra.Focus();
            }
        }

        public bool checkLiDo()
        {
            if (txtLiDoTra.Text == null || txtLiDoTra.Text == "")
            {
                errorProvider1.SetError(txtLiDoTra, "Bạn không được để trống li do trả hàng!");

                //MessageBox.Show("Bạn không được để trống tên!");
                return false;
            }
            else
            {
                errorProvider1.SetError(txtLiDoTra, "");
                return true;
            }
        }

        private void btnDeleteSp_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            index = 0;
            var queryCombo = from HD in db.HoaDonBanHangs
                             select HD;
            cbMaHD.DataSource = queryCombo.ToList();
            cbMaHD.DisplayMember = "MaHd";
            cbMaHD.ValueMember = "MaHd";


            txtLiDoTra.Text = null;
            txtLiDoTra.Enabled = true;
            cbMaHD.Enabled = true;
            cbMaSPCT.Enabled = true;
            btnAddSP.Enabled = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int a = 0;
            if (btnAddSP.Enabled == false)
            {
                try
                {
                    PhieuTraHang phieu = new PhieuTraHang();
                    phieu.MaPhieuTra = lbMaPhieuTH.Text;
                    phieu.NgayLap = DateTime.Now;
                    phieu.MaNv = txtMaNV.Text;
                    phieu.MaSpCt = cbMaSPCT.SelectedValue.ToString();
                    phieu.MaHd = cbMaHD.SelectedValue.ToString();
                    phieu.LyDoTra = txtLiDoTra.Text;

                    var qr = (from pth in db.PhieuTraHangs
                              where pth.MaHd == cbMaHD.SelectedValue.ToString() && pth.MaSpCt == cbMaSPCT.SelectedValue.ToString()
                              select pth).ToList();
                    if (qr.Count > 0)
                    {
                        throw new Exception("Mặt hàng cùng hóa đơn này đã tồn tại trong 1 phiếu trả hàng!");
                    }
                    else
                    {
                        db.PhieuTraHangs.Add(phieu);
                        db.SaveChanges();

                        DSPhieuTH ds = new DSPhieuTH();
                        ds.Show();
                    }


                }
                catch (Exception ex)
                {
                    MessageBox.Show("ERROR: " + ex.Message);
                    a = 1;
                }

                if (a == 1)
                {
                    listView1.Items.Clear();
                    var queryCombo = from HD in db.HoaDonBanHangs
                                     select HD;
                    txtLiDoTra.Enabled = true;
                    cbMaHD.Enabled = true;
                    cbMaSPCT.Enabled = true;
                    btnAddSP.Enabled = true;
                }
            }
            else
            {
                MessageBox.Show("Bạn chưa nhập thông tin sản phẩm vào phiếu trả hàng !");
            }
        }
    }
}
