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
            if(query.ToList().Count>=0 && query.ToList().Count <=8)
            {
                lbMaPhieuTH.Text = "PT00" + (query.ToList().Count + 1);
            }else if(query.ToList().Count >=9 && query.ToList().Count <=98)
            {
                lbMaPhieuTH.Text = "PT0" + (query.ToList().Count + 1);
            }
            else
            {
                lbMaPhieuTH.Text = "PT" + (query.ToList().Count + 1);
            }

            lbNgayLap.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");

            txtMaNV.Text = "NV001";
            //txtMaNV.Enabled = false;
            var nv = (from n in db.NhanViens
                      where n.MaNv == "NV001"
                      select n).FirstOrDefault();
            txtTenNV.Text = nv.HoTenNv;
            //txtTenNV.Enabled = false;

           /* var queryCombo = from HD in db.HoaDonBanHangs
                             select HD;
            cbMaHD.DataSource = queryCombo.ToList();
            cbMaHD.DisplayMember = "MaHd";
            cbMaHD.ValueMember = "MaHd";*/
        }

        /*private void cbMaHD_SelectedIndexChanged(object sender, EventArgs e)
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
        }*/

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddSP_Click(object sender, EventArgs e)
        {
            if (checkLiDo() && checkMaHoaDon() &&checkKT() && checkMaSPCT() && checkMS() && checkTenSP())
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
                txtMaHD.Enabled = false;
                cbMaSPCT.Enabled = false;
                txtLiDoTra.Enabled = false;
                btnSearch.Enabled = false;

            }
            else
            {
                if (!checkMaHoaDon())
                {
                    checkMaHoaDon();
                    txtMaHD.Focus();
                }else if (!checkLiDo())
                {
                    checkLiDo();
                    txtLiDoTra.Focus();
                }
                else
                {
                    MessageBox.Show("ERR: Bạn chưa nhập đủ thông tin sản phẩm !");
                }
                

                
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
            txtMaHD.Text = null;

            btnSearch.Enabled = true;
            btnAddSP.Enabled = true;
            txtLiDoTra.Text = null;
            txtLiDoTra.Enabled = true;
            txtMaHD.Enabled = true;
            cbMaSPCT.Enabled = true;
            cbMaSPCT.DataSource = null;
            txtKT.Text = null;
            txtMS.Text = null;
            txtTenSp.Text = null;
            txtTenKH.Text = null;
            txtDCKH.Text = null;
            
            txtSDTKH.Text = null;
            txtMaHD.Focus();
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
                    phieu.MaHd = txtMaHD.Text;
                    phieu.LyDoTra = txtLiDoTra.Text;

                    var qr = (from pth in db.PhieuTraHangs
                              where pth.MaHd == txtMaHD.Text && pth.MaSpCt == cbMaSPCT.SelectedValue.ToString()
                              select pth).ToList();
                    var SL = (from hdsp in db.HoaDonBanHangSanPhams
                              where hdsp.MaHd == txtMaHD.Text && hdsp.MaSpCt == cbMaSPCT.SelectedValue.ToString()
                              select hdsp).ToList();
                    if (qr.Count >= SL.FirstOrDefault().SoLuongBan)
                    {
                        throw new Exception("Mặt hàng đã quá số lượng bán của hóa đơn!");
                    }
                    else
                    {
                        db.PhieuTraHangs.Add(phieu);

                        var query = from spct in db.SanPhamChiTiets
                                    where spct.MaSpCt == cbMaSPCT.SelectedValue.ToString()
                                    select spct;
                        
                        SanPhamChiTiet spSua = query.FirstOrDefault();
                        int sl = spSua.SoLuongTon;
                        spSua.SoLuongTon = sl + 1;
                        //spSua.MaLoai = txtMaLoai.Text;
                       /* db.SaveChanges();
                        HienThiDuLieu();*/

                        db.SaveChanges();

                        MessageBox.Show("SCC: Thêm phiếu trả hàng thành công!");
                        btnDeleteSp_Click(sender, e);
                    }

                    
                }catch(Exception ex)
                {
                    MessageBox.Show("ERROR: "+ex.Message);
                    a = 1;
                    index = 0;
                }

                if (a == 1)
                {
                    listView1.Items.Clear();
                    var queryCombo = from HD in db.HoaDonBanHangs
                                     select HD;
                    txtLiDoTra.Enabled = true;
                    txtMaHD.Enabled = true;
                    cbMaSPCT.Enabled = true;
                    btnAddSP.Enabled = true;
                    btnSearch.Enabled = true;
                }
            }
            else
            {
                MessageBox.Show("Bạn chưa nhập thông tin sản phẩm vào phiếu trả hàng !");
            }
        }

        private void cbMaSPCT_SelectedIndexChanged(object sender, EventArgs e)
        {
            var SPCT = (from Spct in db.SanPhamChiTiets
                              where Spct.MaSpCt == cbMaSPCT.Text
                              select Spct).ToList();

            if (SPCT.Count > 0)
            {
                var SP = (from Sp in db.SanPhams
                          where Sp.MaSp == SPCT.FirstOrDefault().MaSp
                          select new { Sp.TenSp }).FirstOrDefault();

                var MS = (from Ms in db.Maus
                          where Ms.MaMau == SPCT.FirstOrDefault().MaMau
                          select new { Ms.Mau1 }).FirstOrDefault();

                var KC = (from Kc in db.KichCos
                          where Kc.MaKc == SPCT.FirstOrDefault().MaKc
                          select new { Kc.KichCo1 }).FirstOrDefault();

                txtTenSp.Text = SP.TenSp;
                txtKT.Text = KC.KichCo1;
                txtMS.Text = MS.Mau1;
            }
           
        }

        private void txtMaHD_TextChanged(object sender, EventArgs e)
        {
            cbMaSPCT.Enabled = true;
            cbMaSPCT.DataSource = null;
            txtKT.Text = null;
            txtMS.Text = null;
            txtTenSp.Text = null;
            txtTenKH.Text = null;
            txtDCKH.Text = null;

            txtSDTKH.Text = null;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (checkMaHoaDon())
            {
                var HD = (from hd in db.HoaDonBanHangs
                          where hd.MaHd == txtMaHD.Text
                          select hd).ToList();
                if (HD.Count > 0) {
                    if (HD.FirstOrDefault() != null)
                    {
                        var SPCT = (from spct in db.HoaDonBanHangSanPhams
                                    where spct.MaHd == txtMaHD.Text
                                    select
                                    new
                                    {
                                        spct.MaSpCt,
                                    }).ToList();

                        cbMaSPCT.DataSource = SPCT.ToList();
                        cbMaSPCT.DisplayMember = "MaSpCt";
                        cbMaSPCT.ValueMember = "MaSpCt";



                        KhachHang kh = (from k in db.KhachHangs
                                        where k.MaKh == HD.FirstOrDefault().MaKh
                                        select k).FirstOrDefault();
                        txtTenKH.Text = kh.HoTenKh;
                        //txtTenKH.Enabled = false;
                        txtSDTKH.Text = kh.Sdt;
                        //txtSDTKH.Enabled = false;
                        txtDCKH.Text = kh.DiaChi;
                        //txtDCKH.Enabled = false;
                    }



                }
                else
                {
                    MessageBox.Show("ERR: Không tìm thấy hóa đơn bạn nhập!");
                }



            }
            else
            {
                checkMaHoaDon();
                txtMaHD.Focus();
            }
        }

        public bool checkMaHoaDon()
        {
            if (txtMaHD.Text == null || txtMaHD.Text == "")
            {
                errorProvider1.SetError(txtMaHD, "Bạn không được để trống mã hóa đơn!");

                //MessageBox.Show("Bạn không được để trống tên!");
                return false;
            }
            else
            {
                errorProvider1.SetError(txtMaHD, "");
                return true;
            }
        }

        public bool checkMaSPCT()
        {
            if (cbMaSPCT.Text == null || cbMaSPCT.Text == "")
            {
                //errorProvider1.SetError(txtMaHD, "Bạn không được để trống mã hóa đơn!");

                //MessageBox.Show("Bạn không được để trống tên!");
                return false;
            }
            else
            {
                //errorProvider1.SetError(txtMaHD, "");
                return true;
            }
        }
        public bool checkTenSP()
        {
            if (txtTenSp.Text == null || txtTenSp.Text == "")
            {
                //errorProvider1.SetError(txtMaHD, "Bạn không được để trống mã hóa đơn!");

                //MessageBox.Show("Bạn không được để trống tên!");
                return false;
            }
            else
            {
                //errorProvider1.SetError(txtMaHD, "");
                return true;
            }
        }

        public bool checkKT()
        {
            if (txtKT.Text == null || txtKT.Text == "")
            {
                //errorProvider1.SetError(txtMaHD, "Bạn không được để trống mã hóa đơn!");

                //MessageBox.Show("Bạn không được để trống tên!");
                return false;
            }
            else
            {
                //errorProvider1.SetError(txtMaHD, "");
                return true;
            }
        }

        public bool checkMS()
        {
            if (txtMS.Text == null || txtMS.Text == "")
            {
                //errorProvider1.SetError(txtMaHD, "Bạn không được để trống mã hóa đơn!");

                //MessageBox.Show("Bạn không được để trống tên!");
                return false;
            }
            else
            {
                //errorProvider1.SetError(txtMaHD, "");
                return true;
            }
        }

    }
}
