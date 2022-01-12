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
    public partial class AddPhieuDoi : Form
    {
        private NhanVien nv;
        QuanLyCuaHangJunoContext db = new QuanLyCuaHangJunoContext();
        int index = 0;
        public AddPhieuDoi()
        {
            InitializeComponent();
        }
        public AddPhieuDoi(NhanVien nv)
        {
            this.nv = nv;
            InitializeComponent();
        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void label27_Click(object sender, EventArgs e)
        {

        }

        private void AddPhieuDoi_Load(object sender, EventArgs e)
        {
            var query = (from pdh in db.PhieuDoiHangs
                         select pdh);

            if (query.ToList().Count > 0)
            {
                lbMaPhieuDoi.Text = "PDH" + (query.ToList().Count + 1);
            }
            else
            {
                lbMaPhieuDoi.Text = "PDH1";
            }
            

            lbNgayLap.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");

            txtMaNV.Text = this.nv.MaNv;
            txtTenNV.Text = this.nv.HoTenNv;
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkMaHoaDon())
            {
                var HD = (from hd in db.HoaDonBanHangs
                          where hd.MaHd == txtMaHD.Text
                          select hd).ToList();
                if (HD.Count > 0)
                {
                    if (HD.FirstOrDefault() != null)
                    {
                        var SPCT = (from spct in db.HoaDonBanHangSanPhams
                                    where spct.MaHd == txtMaHD.Text
                                    select
                                    new
                                    {
                                        spct.MaSpCt,
                                    }).ToList();

                        cbMaSPCTHD.DataSource = SPCT.ToList();
                        cbMaSPCTHD.DisplayMember = "MaSpCt";
                        cbMaSPCTHD.ValueMember = "MaSpCt";



                        KhachHang kh = (from k in db.KhachHangs
                                        where k.MaKh == HD.FirstOrDefault().MaKh
                                        select k).FirstOrDefault();
                        txtTenKH.Text = kh.HoTenKh;
                        //txtTenKH.Enabled = false;
                        txtSDTKH.Text = kh.Sdt;
                        //txtSDTKH.Enabled = false;
                        txtDCKH.Text = kh.DiaChi;
                        //txtDCKH.Enabled = false;
                        textBox1.Enabled = true;
                        txtMaHD.Enabled = false;
                        button1.Enabled = false;
                    }



                }
                else
                {/*
                    cbMaSPCTHD.DataSource = null;
                    txtTenKH.Text = null;
                    //txtTenKH.Enabled = false;
                    txtSDTKH.Text = null;
                    //txtSDTKH.Enabled = false;
                    txtDCKH.Text = null;
                    //txtDCKH.Enabled = false;
                    textBox1.Enabled = false;*/
                    MessageBox.Show("ERR: Không tìm thấy hóa đơn bạn nhập!");
                }



            }
            else
            {
                checkMaHoaDon();
                txtMaHD.Focus();
            }
        }

        private void cbMaSPCTHD_SelectedIndexChanged(object sender, EventArgs e)
        {
            var SPCT = (from Spct in db.SanPhamChiTiets
                        where Spct.MaSpCt == cbMaSPCTHD.Text
                        select Spct).ToList();

            if (SPCT.Count > 0)
            {
                var SP = (from Sp in db.SanPhams
                          where Sp.MaSp == SPCT.FirstOrDefault().MaSp
                          select Sp).FirstOrDefault();
                var MS = (from Ms in db.Maus
                          where Ms.MaMau == SPCT.FirstOrDefault().MaMau
                          select Ms).FirstOrDefault();

                var KC = (from Kc in db.KichCos
                          where Kc.MaKc == SPCT.FirstOrDefault().MaKc
                          select Kc).FirstOrDefault();
                var LSP = (from Lsp in db.LoaiSanPhams
                           where Lsp.MaLoaiSp == SP.MaLoaiSp
                           select Lsp).FirstOrDefault();

                txtTenSPHD.Text = SP.TenSp;
                if (KC != null)
                {
                    txtKCHD.Text = KC.KichCo1;
                }
                if (MS != null)
                {
                    txtMSHD.Text = MS.Mau1;
                }
                
                txtLoaiSPHD.Text = LSP.TenLoaiSp;

                textBox1.Text = null;
                textBox1.Enabled = true;
                //txtSLDoi.Text = null;
                txtTenSPDoi.Text = null;
                txtLoaiSPDoi.Text = null;
                txtMauSacDoi.Text = null;
                txtKCDoi.Text = null;
                //btnAdd.Enabled = true;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            var SPCT = (from Spct in db.SanPhamChiTiets
                        where Spct.MaSpCt == textBox1.Text
                        select Spct).ToList();

            if (SPCT.Count > 0)
            {
                var SP = (from Sp in db.SanPhams
                          where Sp.MaSp == SPCT.FirstOrDefault().MaSp
                          select Sp).FirstOrDefault();
                var MS = (from Ms in db.Maus
                          where Ms.MaMau == SPCT.FirstOrDefault().MaMau
                          select Ms).FirstOrDefault();

                var KC = (from Kc in db.KichCos
                          where Kc.MaKc == SPCT.FirstOrDefault().MaKc
                          select Kc).FirstOrDefault();
                var LSP = (from Lsp in db.LoaiSanPhams
                           where Lsp.MaLoaiSp == SP.MaLoaiSp
                           select Lsp).FirstOrDefault();

                txtTenSPDoi.Text = SP.TenSp;
                if (KC != null)
                {
                    txtKCDoi.Text = KC.KichCo1;
                }
                if (MS != null)
                {
                    txtMauSacDoi.Text = MS.Mau1;
                }
                
                txtLoaiSPDoi.Text = LSP.TenLoaiSp;
                btnAdd.Enabled = true;
            }
            else
            {
                txtTenSPDoi.Text = null;
                txtKCDoi.Text = null;
                txtMauSacDoi.Text = null;
                txtLoaiSPDoi.Text = null;
                btnAdd.Enabled = false;
            }
        }

        private void txtMaHD_TextChanged(object sender, EventArgs e)
        {
            //cbMaSPCT.Enabled = true;
            cbMaSPCTHD.DataSource = null;
            txtKCHD.Text = null;
            txtMSHD.Text = null;
            txtTenSPHD.Text = null;
            txtLoaiSPHD.Text = null;
            //txtSLHD.Text = null;
            textBox1.Text = null;
            textBox1.Enabled = false;
            //txtSLDoi.Text = null;
            txtTenSPDoi.Text = null;
            txtLoaiSPDoi.Text = null;
            txtMauSacDoi.Text = null;
            txtKCDoi.Text = null;

            txtTenKH.Text = null;
            txtDCKH.Text = null;
            txtSDTKH.Text = null;

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtMaHD.Text = null;
            txtMaHD.Enabled = true;
            button1.Enabled = true;
            cbMaSPCTHD.DataSource = null;
            txtKCHD.Text = null;
            txtMSHD.Text = null;
            txtTenSPHD.Text = null;
            txtLoaiSPHD.Text = null;
            //txtSLHD.Text = null;
            textBox1.Text = null;
            textBox1.Enabled = false;
            //txtSLDoi.Text = null;
            txtTenSPDoi.Text = null;
            txtLoaiSPDoi.Text = null;
            txtMauSacDoi.Text = null;
            txtKCDoi.Text = null;

            txtTenKH.Text = null;
            txtDCKH.Text = null;
            txtSDTKH.Text = null;

            txtTienThua.Text = null;
            txtTienThuThem.Text = null;
            txtLidoDoi.Text = null;

            listView1.Items.Clear();
            listView2.Items.Clear();
            index = 0;

        }

        public int TinhSoNgay()
        {
            var HD = (from hd in db.HoaDonBanHangs
                      where hd.MaHd == txtMaHD.Text
                      select hd).ToList();
            int TongSoNgay = 0;
            if (HD.Count > 0)
            {
                if (HD.FirstOrDefault() != null)
                {
                    var ngaymua = HD.FirstOrDefault().NgayBan;
                    TimeSpan Time = DateTime.Now - ngaymua;
                    TongSoNgay = Time.Days;
                }
            }
            return TongSoNgay;

        }

        public int CheckLoaiSP()
        {
            var SPCT = (from Spct in db.SanPhamChiTiets
                        where Spct.MaSpCt == cbMaSPCTHD.Text
                        select Spct);
            int check = 0;
            if (SPCT.ToList().Count > 0)
            {
                var SPCT1 = SPCT.ToList().FirstOrDefault();
                var SP = (from Sp in db.SanPhams
                          where Sp.MaSp == SPCT1.MaSp
                          select Sp).ToList();
                if (SP.Count > 0)
                {
                    var SP1 = SP.FirstOrDefault();
                    if (SP1.MaLoaiSp == "LSP003")
                    {
                        check = 1;
                    }
                    else if (SP1.MaLoaiSp == "LSP007")
                    {
                        check = 2;
                    }
                    else
                    {
                        check = 3;
                    }
                }
            }
            return check;
        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (CheckLoaiSP() == 1)
            {
                if (TinhSoNgay() > 7)
                {
                    textBox1.Text = null;
                    //textBox1.Enabled = false;
                    //txtSLDoi.Text = null;
                    txtTenSPDoi.Text = null;
                    txtLoaiSPDoi.Text = null;
                    txtMauSacDoi.Text = null;
                    txtKCDoi.Text = null;
                    btnAdd.Enabled = false;
                    MessageBox.Show("Mặt hàng phụ kiện này đã quá 7 ngày đổi hàng");
                }
                else
                {
                    if (checkSPKM(cbMaSPCTHD.Text))
                    {
                        var SPCTDoi = (from spct in db.SanPhamChiTiets
                                       where spct.MaSpCt == textBox1.Text
                                       select spct).ToList();
                        if (SPCTDoi.Count > 0)
                        {
                            var SPCTDOi1 = SPCTDoi.FirstOrDefault();
                            if (!getMaSPHangTang().Contains(SPCTDOi1.MaSp))
                            {
                                if (TrongTGKM(cbMaSPCTHD.Text) == true)
                                {
                                    //MessageBox.Show("Là SPKM - MAKM :" + getMaKM() + " vẫn đang KM");
                                    var SPCT = (from spct in db.SanPhamChiTiets
                                                where spct.MaSpCt == textBox1.Text
                                                select spct).ToList();
                                    if (SPCT.Count > 0)
                                    {
                                        var SPCT1 = SPCT.FirstOrDefault();
                                        if (getMaSPCungCTKM(cbMaSPCTHD.Text).Contains(SPCT1.MaSp))
                                        {
                                            if (getSLDaDoi(txtMaHD.Text, cbMaSPCTHD.Text) > 0)
                                            {
                                                if (checkSLTrongListView(cbMaSPCTHD.Text) + 1 <= (getSLMua()- getSLDaDoi(txtMaHD.Text, cbMaSPCTHD.Text)))
                                                {
                                                    if (checkSLTrongListViewDoi(textBox1.Text) + 1 <= getSLTonSPDOi(textBox1.Text))
                                                    {
                                                        var TienThua = txtTienThua.Text;
                                                        var TienThuThem = txtTienThuThem.Text;
                                                        if (getMaSp(cbMaSPCTHD.Text) == getMaSp(textBox1.Text))
                                                        {
                                                            if (TienThua != null && TienThua != "" && TienThuThem != null && TienThuThem != "")
                                                            {
                                                                txtTienThua.Text = txtTienThua.Text;
                                                                txtTienThuThem.Text = txtTienThuThem.Text;
                                                            }
                                                            else
                                                            {
                                                                txtTienThua.Text = 0.ToString();
                                                                txtTienThuThem.Text = 0.ToString();
                                                            }
                                                        }
                                                        else
                                                        {
                                                            if (TienThua != null && TienThua != "" && TienThuThem != null && TienThuThem != "")
                                                            {

                                                                var TienThua1 = decimal.Parse(txtTienThua.Text);
                                                                var TienThuThem1 = decimal.Parse(txtTienThuThem.Text);

                                                                var TongTienThua = TienThua1 + TinhGiaKM(cbMaSPCTHD.Text);
                                                                var TongTienThuThem = TienThuThem1 + TinhGiaKM(textBox1.Text);

                                                                if (TongTienThua - TongTienThuThem > 0)
                                                                {
                                                                    txtTienThua.Text = (TongTienThua - TongTienThuThem).ToString();
                                                                    txtTienThuThem.Text = 0.ToString();
                                                                }
                                                                else if (TongTienThua - TongTienThuThem < 0)
                                                                {
                                                                    txtTienThuThem.Text = (TongTienThuThem - TongTienThua).ToString();
                                                                    txtTienThua.Text = 0.ToString();
                                                                }
                                                                else
                                                                {
                                                                    txtTienThua.Text = 0.ToString();
                                                                    txtTienThuThem.Text = 0.ToString();
                                                                }
                                                            }
                                                            else
                                                            {
                                                                var TtThua = TinhGiaKM(cbMaSPCTHD.Text);
                                                                var TTTThem = TinhGiaKM(textBox1.Text);
                                                                if (TtThua - TTTThem > 0)
                                                                {
                                                                    txtTienThua.Text = (TtThua - TTTThem).ToString();
                                                                    txtTienThuThem.Text = 0.ToString();
                                                                }
                                                                else if (TtThua - TTTThem < 0)
                                                                {
                                                                    txtTienThuThem.Text = (TTTThem - TtThua).ToString();
                                                                    txtTienThua.Text = 0.ToString();
                                                                }
                                                                else
                                                                {
                                                                    txtTienThua.Text = 0.ToString();
                                                                    txtTienThuThem.Text = 0.ToString();
                                                                }

                                                            }
                                                        }
                                                        listView1.Items.Add((index + 1).ToString());
                                                        listView1.Items[index].SubItems.Add(cbMaSPCTHD.Text);
                                                        listView1.Items[index].SubItems.Add((1).ToString());
                                                        listView2.Items.Add((index + 1).ToString());
                                                        listView2.Items[index].SubItems.Add(textBox1.Text);
                                                        listView2.Items[index].SubItems.Add((1).ToString());
                                                        index++;
                                                    }
                                                    else
                                                    {
                                                        MessageBox.Show("Vượt quá SL tồn của sản phẩm đổi :" + textBox1.Text);
                                                    }

                                                }
                                                else
                                                {
                                                    MessageBox.Show("Vượt quá SL mua còn lại của sản phẩm này!");
                                                }
                                            }
                                            else
                                            {
                                                if (checkSLTrongListView(cbMaSPCTHD.Text) + 1 <= getSLMua())
                                                {
                                                    if (checkSLTrongListViewDoi(textBox1.Text) + 1 <= getSLTonSPDOi(textBox1.Text))
                                                    {
                                                        var TienThua = txtTienThua.Text;
                                                        var TienThuThem = txtTienThuThem.Text;
                                                        if (getMaSp(cbMaSPCTHD.Text) == getMaSp(textBox1.Text))
                                                        {
                                                            if (TienThua != null && TienThua != "" && TienThuThem != null && TienThuThem != "")
                                                            {
                                                                txtTienThua.Text = txtTienThua.Text;
                                                                txtTienThuThem.Text = txtTienThuThem.Text;
                                                            }
                                                            else
                                                            {
                                                                txtTienThua.Text = 0.ToString();
                                                                txtTienThuThem.Text = 0.ToString();
                                                            }
                                                        }
                                                        else
                                                        {
                                                            if (TienThua != null && TienThua != "" && TienThuThem != null && TienThuThem != "")
                                                            {

                                                                var TienThua1 = decimal.Parse(txtTienThua.Text);
                                                                var TienThuThem1 = decimal.Parse(txtTienThuThem.Text);

                                                                var TongTienThua = TienThua1 + TinhGiaKM(cbMaSPCTHD.Text);
                                                                var TongTienThuThem = TienThuThem1 + TinhGiaKM(textBox1.Text);

                                                                if (TongTienThua - TongTienThuThem > 0)
                                                                {
                                                                    txtTienThua.Text = (TongTienThua - TongTienThuThem).ToString();
                                                                    txtTienThuThem.Text = 0.ToString();
                                                                }
                                                                else if (TongTienThua - TongTienThuThem < 0)
                                                                {
                                                                    txtTienThuThem.Text = (TongTienThuThem - TongTienThua).ToString();
                                                                    txtTienThua.Text = 0.ToString();
                                                                }
                                                                else
                                                                {
                                                                    txtTienThua.Text = 0.ToString();
                                                                    txtTienThuThem.Text = 0.ToString();
                                                                }
                                                            }
                                                            else
                                                            {
                                                                var TtThua = TinhGiaKM(cbMaSPCTHD.Text);
                                                                var TTTThem = TinhGiaKM(textBox1.Text);
                                                                if (TtThua - TTTThem > 0)
                                                                {
                                                                    txtTienThua.Text = (TtThua - TTTThem).ToString();
                                                                    txtTienThuThem.Text = 0.ToString();
                                                                }
                                                                else if (TtThua - TTTThem < 0)
                                                                {
                                                                    txtTienThuThem.Text = (TTTThem - TtThua).ToString();
                                                                    txtTienThua.Text = 0.ToString();
                                                                }
                                                                else
                                                                {
                                                                    txtTienThua.Text = 0.ToString();
                                                                    txtTienThuThem.Text = 0.ToString();
                                                                }

                                                            }
                                                        }
                                                        listView1.Items.Add((index + 1).ToString());
                                                        listView1.Items[index].SubItems.Add(cbMaSPCTHD.Text);
                                                        listView1.Items[index].SubItems.Add((1).ToString());
                                                        listView2.Items.Add((index + 1).ToString());
                                                        listView2.Items[index].SubItems.Add(textBox1.Text);
                                                        listView2.Items[index].SubItems.Add((1).ToString());
                                                        index++;
                                                    }
                                                    else
                                                    {
                                                        MessageBox.Show("Vượt quá SL tồn của sản phẩm đổi :" + textBox1.Text);
                                                    }

                                                }
                                                else
                                                {
                                                    MessageBox.Show("Vượt quá SL mua của sản phẩm này!");
                                                }
                                            }
                                            

                                            //
                                        }
                                        else
                                        {
                                            MessageBox.Show("SP của bạn vẫn đang trong chương trình KM. Bạn chỉ có thể đổi sang các SP cùng chương trình KM này!");
                                        }
                                    }
                                }
                                else
                                {
                                    if (getSLDaDoi(txtMaHD.Text, cbMaSPCTHD.Text) > 0)
                                    {
                                        if (checkSLTrongListView(cbMaSPCTHD.Text) + 1 <= (getSLMua()- getSLDaDoi(txtMaHD.Text, cbMaSPCTHD.Text)))
                                        {
                                            if (checkSLTrongListViewDoi(textBox1.Text) + 1 <= getSLTonSPDOi(textBox1.Text))
                                            {
                                                var TienThua = txtTienThua.Text;
                                                var TienThuThem = txtTienThuThem.Text;
                                                if (TienThua != null && TienThua != "" && TienThuThem != null && TienThuThem != "")
                                                {

                                                    var TienThua1 = decimal.Parse(txtTienThua.Text);
                                                    var TienThuThem1 = decimal.Parse(txtTienThuThem.Text);

                                                    var TongTienThua = TienThua1 + TinhGiaKM(cbMaSPCTHD.Text);

                                                    var TongTienThuThem = TienThuThem1/* + TinhGiaKM(textBox1.Text)*/;
                                                    if (checkSPKMDoi(textBox1.Text))
                                                    {
                                                        TongTienThuThem += TinhGiaKMDoi(textBox1.Text);
                                                    }
                                                    else
                                                    {
                                                        TongTienThuThem += getGiaGoc(textBox1.Text);
                                                    }


                                                    if (TongTienThua - TongTienThuThem > 0)
                                                    {
                                                        txtTienThua.Text = (TongTienThua - TongTienThuThem).ToString();
                                                        txtTienThuThem.Text = 0.ToString();
                                                    }
                                                    else if (TongTienThua - TongTienThuThem < 0)
                                                    {
                                                        txtTienThuThem.Text = (TongTienThuThem - TongTienThua).ToString();
                                                        txtTienThua.Text = 0.ToString();
                                                    }
                                                    else
                                                    {
                                                        txtTienThua.Text = 0.ToString();
                                                        txtTienThuThem.Text = 0.ToString();
                                                    }
                                                }
                                                else
                                                {
                                                    var TtThua = TinhGiaKM(cbMaSPCTHD.Text);
                                                    decimal TTTThem = 0;
                                                    if (checkSPKMDoi(textBox1.Text))
                                                    {
                                                        TTTThem += TinhGiaKMDoi(textBox1.Text);
                                                        //MessageBox.Show(TTTThem.ToString());
                                                    }
                                                    else
                                                    {
                                                        TTTThem += getGiaGoc(textBox1.Text);
                                                        //MessageBox.Show(TTTThem.ToString()+"    "+ TtThua.ToString());
                                                    }

                                                    if (TtThua - TTTThem > 0)
                                                    {
                                                        txtTienThua.Text = (TtThua - TTTThem).ToString();
                                                        txtTienThuThem.Text = 0.ToString();
                                                    }
                                                    else if (TtThua - TTTThem < 0)
                                                    {
                                                        txtTienThuThem.Text = (TTTThem - TtThua).ToString();
                                                        txtTienThua.Text = 0.ToString();
                                                    }
                                                    else
                                                    {
                                                        txtTienThua.Text = 0.ToString();
                                                        txtTienThuThem.Text = 0.ToString();
                                                    }

                                                }
                                                listView1.Items.Add((index + 1).ToString());
                                                listView1.Items[index].SubItems.Add(cbMaSPCTHD.Text);
                                                listView1.Items[index].SubItems.Add((1).ToString());
                                                listView2.Items.Add((index + 1).ToString());
                                                listView2.Items[index].SubItems.Add(textBox1.Text);
                                                listView2.Items[index].SubItems.Add((1).ToString());
                                                index++;
                                            }
                                            else
                                            {
                                                MessageBox.Show("Vượt quá SL tồn của sản phẩm đổi :" + textBox1.Text);
                                            }

                                        }
                                        else
                                        {
                                            MessageBox.Show("Vượt quá SL mua còn lại của sản phẩm này!");
                                        }
                                    }
                                    else
                                    {
                                        if (checkSLTrongListView(cbMaSPCTHD.Text) + 1 <= getSLMua())
                                        {
                                            if (checkSLTrongListViewDoi(textBox1.Text) + 1 <= getSLTonSPDOi(textBox1.Text))
                                            {
                                                var TienThua = txtTienThua.Text;
                                                var TienThuThem = txtTienThuThem.Text;
                                                if (TienThua != null && TienThua != "" && TienThuThem != null && TienThuThem != "")
                                                {

                                                    var TienThua1 = decimal.Parse(txtTienThua.Text);
                                                    var TienThuThem1 = decimal.Parse(txtTienThuThem.Text);

                                                    var TongTienThua = TienThua1 + TinhGiaKM(cbMaSPCTHD.Text);

                                                    var TongTienThuThem = TienThuThem1/* + TinhGiaKM(textBox1.Text)*/;
                                                    if (checkSPKMDoi(textBox1.Text))
                                                    {
                                                        TongTienThuThem += TinhGiaKMDoi(textBox1.Text);
                                                    }
                                                    else
                                                    {
                                                        TongTienThuThem += getGiaGoc(textBox1.Text);
                                                    }


                                                    if (TongTienThua - TongTienThuThem > 0)
                                                    {
                                                        txtTienThua.Text = (TongTienThua - TongTienThuThem).ToString();
                                                        txtTienThuThem.Text = 0.ToString();
                                                    }
                                                    else if (TongTienThua - TongTienThuThem < 0)
                                                    {
                                                        txtTienThuThem.Text = (TongTienThuThem - TongTienThua).ToString();
                                                        txtTienThua.Text = 0.ToString();
                                                    }
                                                    else
                                                    {
                                                        txtTienThua.Text = 0.ToString();
                                                        txtTienThuThem.Text = 0.ToString();
                                                    }
                                                }
                                                else
                                                {
                                                    var TtThua = TinhGiaKM(cbMaSPCTHD.Text);
                                                    decimal TTTThem = 0;
                                                    if (checkSPKMDoi(textBox1.Text))
                                                    {
                                                        TTTThem += TinhGiaKMDoi(textBox1.Text);
                                                        //MessageBox.Show(TTTThem.ToString());
                                                    }
                                                    else
                                                    {
                                                        TTTThem += getGiaGoc(textBox1.Text);
                                                        //MessageBox.Show(TTTThem.ToString()+"    "+ TtThua.ToString());
                                                    }

                                                    if (TtThua - TTTThem > 0)
                                                    {
                                                        txtTienThua.Text = (TtThua - TTTThem).ToString();
                                                        txtTienThuThem.Text = 0.ToString();
                                                    }
                                                    else if (TtThua - TTTThem < 0)
                                                    {
                                                        txtTienThuThem.Text = (TTTThem - TtThua).ToString();
                                                        txtTienThua.Text = 0.ToString();
                                                    }
                                                    else
                                                    {
                                                        txtTienThua.Text = 0.ToString();
                                                        txtTienThuThem.Text = 0.ToString();
                                                    }

                                                }
                                                listView1.Items.Add((index + 1).ToString());
                                                listView1.Items[index].SubItems.Add(cbMaSPCTHD.Text);
                                                listView1.Items[index].SubItems.Add((1).ToString());
                                                listView2.Items.Add((index + 1).ToString());
                                                listView2.Items[index].SubItems.Add(textBox1.Text);
                                                listView2.Items[index].SubItems.Add((1).ToString());
                                                index++;
                                            }
                                            else
                                            {
                                                MessageBox.Show("Vượt quá SL tồn của sản phẩm đổi :" + textBox1.Text);
                                            }

                                        }
                                        else
                                        {
                                            MessageBox.Show("Vượt quá SL mua của sản phẩm này!");
                                        }
                                    }
                                        //MessageBox.Show("Là SPKM - MAKM :" + getMaKM(cbMaSPCTHD.Text) + " hết TG KM");
                                        
                                }
                            }
                            else
                            {
                                MessageBox.Show("Không được đổi sản phẩm này sang sản phẩm hàng tặng!");
                            }
                        }
                    }
                    else
                    {
                        var SPCTDoi = (from spct in db.SanPhamChiTiets
                                       where spct.MaSpCt == textBox1.Text
                                       select spct).ToList();
                        if (SPCTDoi.Count > 0)
                        {
                            var SPCTDOi1 = SPCTDoi.FirstOrDefault();
                            if (!getMaSPHangTang().Contains(SPCTDOi1.MaSp))
                            {
                                if (getSLDaDoi(txtMaHD.Text, cbMaSPCTHD.Text) > 0)
                                {
                                    //MessageBox.Show("K phải SPKM");
                                    if (checkSLTrongListView(cbMaSPCTHD.Text) + 1 <= (getSLMua()- getSLDaDoi(txtMaHD.Text, cbMaSPCTHD.Text)))
                                    {
                                        if (checkSLTrongListViewDoi(textBox1.Text) + 1 <= getSLTonSPDOi(textBox1.Text))
                                        {
                                            var TienThua = txtTienThua.Text;
                                            var TienThuThem = txtTienThuThem.Text;
                                            if (getMaSp(cbMaSPCTHD.Text) == getMaSp(textBox1.Text))
                                            {
                                                if (TienThua != null && TienThua != "" && TienThuThem != null && TienThuThem != "")
                                                {
                                                    txtTienThua.Text = txtTienThua.Text;
                                                    txtTienThuThem.Text = txtTienThuThem.Text;
                                                }
                                                else
                                                {
                                                    txtTienThua.Text = 0.ToString();
                                                    txtTienThuThem.Text = 0.ToString();
                                                }
                                            }
                                            else
                                            {
                                                if (TienThua != null && TienThua != "" && TienThuThem != null && TienThuThem != "")
                                                {

                                                    var TienThua1 = decimal.Parse(txtTienThua.Text);
                                                    var TienThuThem1 = decimal.Parse(txtTienThuThem.Text);

                                                    var TongTienThua = TienThua1 + getGiaGoc(cbMaSPCTHD.Text);

                                                    var TongTienThuThem = TienThuThem1/* + TinhGiaKM(textBox1.Text)*/;
                                                    if (checkSPKMDoi(textBox1.Text))
                                                    {
                                                        TongTienThuThem += TinhGiaKMDoi(textBox1.Text);
                                                    }
                                                    else
                                                    {
                                                        TongTienThuThem += getGiaGoc(textBox1.Text);
                                                    }


                                                    if (TongTienThua - TongTienThuThem > 0)
                                                    {
                                                        txtTienThua.Text = (TongTienThua - TongTienThuThem).ToString();
                                                        txtTienThuThem.Text = 0.ToString();
                                                    }
                                                    else if (TongTienThua - TongTienThuThem < 0)
                                                    {
                                                        txtTienThuThem.Text = (TongTienThuThem - TongTienThua).ToString();
                                                        txtTienThua.Text = 0.ToString();
                                                    }
                                                    else
                                                    {
                                                        txtTienThua.Text = 0.ToString();
                                                        txtTienThuThem.Text = 0.ToString();
                                                    }
                                                }
                                                else
                                                {
                                                    var TtThua = getGiaGoc(cbMaSPCTHD.Text);
                                                    decimal TTTThem = 0;
                                                    if (checkSPKMDoi(textBox1.Text))
                                                    {
                                                        TTTThem += TinhGiaKMDoi(textBox1.Text);
                                                        //MessageBox.Show(TTTThem.ToString());
                                                    }
                                                    else
                                                    {
                                                        TTTThem += getGiaGoc(textBox1.Text);
                                                        //MessageBox.Show(TTTThem.ToString()+"    "+ TtThua.ToString());
                                                    }

                                                    if (TtThua - TTTThem > 0)
                                                    {
                                                        txtTienThua.Text = (TtThua - TTTThem).ToString();
                                                        txtTienThuThem.Text = 0.ToString();
                                                    }
                                                    else if (TtThua - TTTThem < 0)
                                                    {
                                                        txtTienThuThem.Text = (TTTThem - TtThua).ToString();
                                                        txtTienThua.Text = 0.ToString();
                                                    }
                                                    else
                                                    {
                                                        txtTienThua.Text = 0.ToString();
                                                        txtTienThuThem.Text = 0.ToString();
                                                    }

                                                }
                                            }
                                        
                                            listView1.Items.Add((index + 1).ToString());
                                            listView1.Items[index].SubItems.Add(cbMaSPCTHD.Text);
                                            listView1.Items[index].SubItems.Add((1).ToString());
                                            listView2.Items.Add((index + 1).ToString());
                                            listView2.Items[index].SubItems.Add(textBox1.Text);
                                            listView2.Items[index].SubItems.Add((1).ToString());
                                            index++;
                                        }
                                        else
                                        {
                                            MessageBox.Show("Vượt quá SL tồn của sản phẩm đổi :" + textBox1.Text);
                                        }


                                    }
                                    else
                                    {
                                        MessageBox.Show("Vượt quá SL mua còn lại của sản phẩm này!");
                                    }
                                }
                                else
                                {
                                    if (checkSLTrongListView(cbMaSPCTHD.Text) + 1 <= getSLMua())
                                    {
                                        if (checkSLTrongListViewDoi(textBox1.Text) + 1 <= getSLTonSPDOi(textBox1.Text))
                                        {
                                            var TienThua = txtTienThua.Text;
                                            var TienThuThem = txtTienThuThem.Text;
                                            if (TienThua != null && TienThua != "" && TienThuThem != null && TienThuThem != "")
                                            {

                                                var TienThua1 = decimal.Parse(txtTienThua.Text);
                                                var TienThuThem1 = decimal.Parse(txtTienThuThem.Text);

                                                var TongTienThua = TienThua1 + getGiaGoc(cbMaSPCTHD.Text);

                                                var TongTienThuThem = TienThuThem1/* + TinhGiaKM(textBox1.Text)*/;
                                                if (checkSPKMDoi(textBox1.Text))
                                                {
                                                    TongTienThuThem += TinhGiaKMDoi(textBox1.Text);
                                                }
                                                else
                                                {
                                                    TongTienThuThem += getGiaGoc(textBox1.Text);
                                                }


                                                if (TongTienThua - TongTienThuThem > 0)
                                                {
                                                    txtTienThua.Text = (TongTienThua - TongTienThuThem).ToString();
                                                    txtTienThuThem.Text = 0.ToString();
                                                }
                                                else if (TongTienThua - TongTienThuThem < 0)
                                                {
                                                    txtTienThuThem.Text = (TongTienThuThem - TongTienThua).ToString();
                                                    txtTienThua.Text = 0.ToString();
                                                }
                                                else
                                                {
                                                    txtTienThua.Text = 0.ToString();
                                                    txtTienThuThem.Text = 0.ToString();
                                                }
                                            }
                                            else
                                            {
                                                var TtThua = getGiaGoc(cbMaSPCTHD.Text);
                                                decimal TTTThem = 0;
                                                if (checkSPKMDoi(textBox1.Text))
                                                {
                                                    TTTThem += TinhGiaKMDoi(textBox1.Text);
                                                    //MessageBox.Show(TTTThem.ToString());
                                                }
                                                else
                                                {
                                                    TTTThem += getGiaGoc(textBox1.Text);
                                                    //MessageBox.Show(TTTThem.ToString()+"    "+ TtThua.ToString());
                                                }

                                                if (TtThua - TTTThem > 0)
                                                {
                                                    txtTienThua.Text = (TtThua - TTTThem).ToString();
                                                    txtTienThuThem.Text = 0.ToString();
                                                }
                                                else if (TtThua - TTTThem < 0)
                                                {
                                                    txtTienThuThem.Text = (TTTThem - TtThua).ToString();
                                                    txtTienThua.Text = 0.ToString();
                                                }
                                                else
                                                {
                                                    txtTienThua.Text = 0.ToString();
                                                    txtTienThuThem.Text = 0.ToString();
                                                }

                                            }
                                            listView1.Items.Add((index + 1).ToString());
                                            listView1.Items[index].SubItems.Add(cbMaSPCTHD.Text);
                                            listView1.Items[index].SubItems.Add((1).ToString());
                                            listView2.Items.Add((index + 1).ToString());
                                            listView2.Items[index].SubItems.Add(textBox1.Text);
                                            listView2.Items[index].SubItems.Add((1).ToString());
                                            index++;
                                        }
                                        else
                                        {
                                            MessageBox.Show("Vượt quá SL tồn của sản phẩm đổi :" + textBox1.Text);
                                        }


                                    }
                                    else
                                    {
                                        MessageBox.Show("Vượt quá SL mua của sản phẩm này!");
                                    }
                                }

                            }
                            else
                            {
                                MessageBox.Show("Không được đổi sản phẩm này sang sản phẩm hàng tặng!");
                            }
                        }
                    }
                }
            }
            else if (CheckLoaiSP() == 3)
            {
                
                if (checkSPKM(cbMaSPCTHD.Text))
                {
                    if (TinhGiaKM(cbMaSPCTHD.Text) <= 250000)
                    {
                        if (TinhSoNgay() > 7)
                        {
                            textBox1.Text = null;
                            //textBox1.Enabled = false;
                            //txtSLDoi.Text = null;
                            txtTenSPDoi.Text = null;
                            txtLoaiSPDoi.Text = null;
                            txtMauSacDoi.Text = null;
                            txtKCDoi.Text = null;
                            btnAdd.Enabled = false;
                            MessageBox.Show("Mặt hàng KM này giá <= 250000 đã quá 7 ngày đổi hàng");
                        }
                        else
                        {
                            var SPCTDoi = (from spct in db.SanPhamChiTiets
                                           where spct.MaSpCt == textBox1.Text
                                           select spct).ToList();
                            if (SPCTDoi.Count > 0)
                            {
                                var SPCTDOi1 = SPCTDoi.FirstOrDefault();
                                if (!getMaSPHangTang().Contains(SPCTDOi1.MaSp))
                                {
                                    if (TrongTGKM(cbMaSPCTHD.Text) == true)
                                    {
                                        //MessageBox.Show("Là SPKM - MAKM :" + getMaKM() + " vẫn đang KM");
                                        var SPCT = (from spct in db.SanPhamChiTiets
                                                    where spct.MaSpCt == textBox1.Text
                                                    select spct).ToList();
                                        if (SPCT.Count > 0)
                                        {
                                            var SPCT1 = SPCT.FirstOrDefault();
                                            if (getMaSPCungCTKM(cbMaSPCTHD.Text).Contains(SPCT1.MaSp))
                                            {
                                                if (getSLDaDoi(txtMaHD.Text, cbMaSPCTHD.Text) > 0)
                                                {
                                                    if (checkSLTrongListView(cbMaSPCTHD.Text) + 1 <= (getSLMua()- getSLDaDoi(txtMaHD.Text, cbMaSPCTHD.Text)))
                                                    {
                                                        if (checkSLTrongListViewDoi(textBox1.Text) + 1 <= getSLTonSPDOi(textBox1.Text))
                                                        {
                                                            var TienThua = txtTienThua.Text;
                                                            var TienThuThem = txtTienThuThem.Text;
                                                            if (getMaSp(cbMaSPCTHD.Text) == getMaSp(textBox1.Text))
                                                            {
                                                                if (TienThua != null && TienThua != "" && TienThuThem != null && TienThuThem != "")
                                                                {
                                                                    txtTienThua.Text = txtTienThua.Text;
                                                                    txtTienThuThem.Text = txtTienThuThem.Text;
                                                                }
                                                                else
                                                                {
                                                                    txtTienThua.Text = 0.ToString();
                                                                    txtTienThuThem.Text = 0.ToString();
                                                                }
                                                            }
                                                            else
                                                            {
                                                                if (TienThua != null && TienThua != "" && TienThuThem != null && TienThuThem != "")
                                                                {

                                                                    var TienThua1 = decimal.Parse(txtTienThua.Text);
                                                                    var TienThuThem1 = decimal.Parse(txtTienThuThem.Text);

                                                                    var TongTienThua = TienThua1 + TinhGiaKM(cbMaSPCTHD.Text);
                                                                    var TongTienThuThem = TienThuThem1 + TinhGiaKM(textBox1.Text);

                                                                    if (TongTienThua - TongTienThuThem > 0)
                                                                    {
                                                                        txtTienThua.Text = (TongTienThua - TongTienThuThem).ToString();
                                                                        txtTienThuThem.Text = 0.ToString();
                                                                    }
                                                                    else if (TongTienThua - TongTienThuThem < 0)
                                                                    {
                                                                        txtTienThuThem.Text = (TongTienThuThem - TongTienThua).ToString();
                                                                        txtTienThua.Text = 0.ToString();
                                                                    }
                                                                    else
                                                                    {
                                                                        txtTienThua.Text = 0.ToString();
                                                                        txtTienThuThem.Text = 0.ToString();
                                                                    }
                                                                }
                                                                else
                                                                {
                                                                    var TtThua = TinhGiaKM(cbMaSPCTHD.Text);
                                                                    var TTTThem = TinhGiaKM(textBox1.Text);
                                                                    if (TtThua - TTTThem > 0)
                                                                    {
                                                                        txtTienThua.Text = (TtThua - TTTThem).ToString();
                                                                        txtTienThuThem.Text = 0.ToString();
                                                                    }
                                                                    else if (TtThua - TTTThem < 0)
                                                                    {
                                                                        txtTienThuThem.Text = (TTTThem - TtThua).ToString();
                                                                        txtTienThua.Text = 0.ToString();
                                                                    }
                                                                    else
                                                                    {
                                                                        txtTienThua.Text = 0.ToString();
                                                                        txtTienThuThem.Text = 0.ToString();
                                                                    }

                                                                }
                                                            }
                                                            listView1.Items.Add((index + 1).ToString());
                                                            listView1.Items[index].SubItems.Add(cbMaSPCTHD.Text);
                                                            listView1.Items[index].SubItems.Add((1).ToString());
                                                            listView2.Items.Add((index + 1).ToString());
                                                            listView2.Items[index].SubItems.Add(textBox1.Text);
                                                            listView2.Items[index].SubItems.Add((1).ToString());
                                                            index++;
                                                        }
                                                        else
                                                        {
                                                            MessageBox.Show("Vượt quá SL tồn của sản phẩm đổi :" + textBox1.Text);
                                                        }
                                                    }
                                                    else
                                                    {
                                                        MessageBox.Show("Vượt quá SL mua còn lại của sản phẩm này!");
                                                    }
                                                }
                                                else
                                                {
                                                    if (checkSLTrongListView(cbMaSPCTHD.Text) + 1 <= getSLMua())
                                                    {
                                                        if (checkSLTrongListViewDoi(textBox1.Text) + 1 <= getSLTonSPDOi(textBox1.Text))
                                                        {
                                                            var TienThua = txtTienThua.Text;
                                                            var TienThuThem = txtTienThuThem.Text;
                                                            if (getMaSp(cbMaSPCTHD.Text) == getMaSp(textBox1.Text))
                                                            {
                                                                if (TienThua != null && TienThua != "" && TienThuThem != null && TienThuThem != "")
                                                                {
                                                                    txtTienThua.Text = txtTienThua.Text;
                                                                    txtTienThuThem.Text = txtTienThuThem.Text;
                                                                }
                                                                else
                                                                {
                                                                    txtTienThua.Text = 0.ToString();
                                                                    txtTienThuThem.Text = 0.ToString();
                                                                }
                                                            }
                                                            else
                                                            {
                                                                if (TienThua != null && TienThua != "" && TienThuThem != null && TienThuThem != "")
                                                                {

                                                                    var TienThua1 = decimal.Parse(txtTienThua.Text);
                                                                    var TienThuThem1 = decimal.Parse(txtTienThuThem.Text);

                                                                    var TongTienThua = TienThua1 + TinhGiaKM(cbMaSPCTHD.Text);
                                                                    var TongTienThuThem = TienThuThem1 + TinhGiaKM(textBox1.Text);

                                                                    if (TongTienThua - TongTienThuThem > 0)
                                                                    {
                                                                        txtTienThua.Text = (TongTienThua - TongTienThuThem).ToString();
                                                                        txtTienThuThem.Text = 0.ToString();
                                                                    }
                                                                    else if (TongTienThua - TongTienThuThem < 0)
                                                                    {
                                                                        txtTienThuThem.Text = (TongTienThuThem - TongTienThua).ToString();
                                                                        txtTienThua.Text = 0.ToString();
                                                                    }
                                                                    else
                                                                    {
                                                                        txtTienThua.Text = 0.ToString();
                                                                        txtTienThuThem.Text = 0.ToString();
                                                                    }
                                                                }
                                                                else
                                                                {
                                                                    var TtThua = TinhGiaKM(cbMaSPCTHD.Text);
                                                                    var TTTThem = TinhGiaKM(textBox1.Text);
                                                                    if (TtThua - TTTThem > 0)
                                                                    {
                                                                        txtTienThua.Text = (TtThua - TTTThem).ToString();
                                                                        txtTienThuThem.Text = 0.ToString();
                                                                    }
                                                                    else if (TtThua - TTTThem < 0)
                                                                    {
                                                                        txtTienThuThem.Text = (TTTThem - TtThua).ToString();
                                                                        txtTienThua.Text = 0.ToString();
                                                                    }
                                                                    else
                                                                    {
                                                                        txtTienThua.Text = 0.ToString();
                                                                        txtTienThuThem.Text = 0.ToString();
                                                                    }

                                                                }
                                                            }
                                                            listView1.Items.Add((index + 1).ToString());
                                                            listView1.Items[index].SubItems.Add(cbMaSPCTHD.Text);
                                                            listView1.Items[index].SubItems.Add((1).ToString());
                                                            listView2.Items.Add((index + 1).ToString());
                                                            listView2.Items[index].SubItems.Add(textBox1.Text);
                                                            listView2.Items[index].SubItems.Add((1).ToString());
                                                            index++;
                                                        }
                                                        else
                                                        {
                                                            MessageBox.Show("Vượt quá SL tồn của sản phẩm đổi :" + textBox1.Text);
                                                        }
                                                    }
                                                    else
                                                    {
                                                        MessageBox.Show("Vượt quá SL mua của sản phẩm này!");
                                                    }
                                                }

                                                //
                                            }
                                            else
                                            {
                                                MessageBox.Show("SP của bạn vẫn đang trong chương trình KM. Bạn chỉ có thể đổi sang các SP cùng chương trình KM này!");
                                            }
                                        }
                                    }
                                    else
                                    {
                                        if (getSLDaDoi(txtMaHD.Text, cbMaSPCTHD.Text) > 0)
                                        {
                                            //MessageBox.Show("Là SPKM - MAKM :" + getMaKM(cbMaSPCTHD.Text) + " hết TG KM");
                                            if (checkSLTrongListView(cbMaSPCTHD.Text) + 1 <= (getSLMua()- getSLDaDoi(txtMaHD.Text, cbMaSPCTHD.Text)))
                                            {
                                                if (checkSLTrongListViewDoi(textBox1.Text) + 1 <= getSLTonSPDOi(textBox1.Text))
                                                {
                                                    var TienThua = txtTienThua.Text;
                                                    var TienThuThem = txtTienThuThem.Text;
                                                    if (TienThua != null && TienThua != "" && TienThuThem != null && TienThuThem != "")
                                                    {

                                                        var TienThua1 = decimal.Parse(txtTienThua.Text);
                                                        var TienThuThem1 = decimal.Parse(txtTienThuThem.Text);

                                                        var TongTienThua = TienThua1 + TinhGiaKM(cbMaSPCTHD.Text);

                                                        var TongTienThuThem = TienThuThem1/* + TinhGiaKM(textBox1.Text)*/;
                                                        if (checkSPKMDoi(textBox1.Text))
                                                        {
                                                            TongTienThuThem += TinhGiaKMDoi(textBox1.Text);
                                                        }
                                                        else
                                                        {
                                                            TongTienThuThem += getGiaGoc(textBox1.Text);
                                                        }


                                                        if (TongTienThua - TongTienThuThem > 0)
                                                        {
                                                            txtTienThua.Text = (TongTienThua - TongTienThuThem).ToString();
                                                            txtTienThuThem.Text = 0.ToString();
                                                        }
                                                        else if (TongTienThua - TongTienThuThem < 0)
                                                        {
                                                            txtTienThuThem.Text = (TongTienThuThem - TongTienThua).ToString();
                                                            txtTienThua.Text = 0.ToString();
                                                        }
                                                        else
                                                        {
                                                            txtTienThua.Text = 0.ToString();
                                                            txtTienThuThem.Text = 0.ToString();
                                                        }
                                                    }
                                                    else
                                                    {
                                                        var TtThua = TinhGiaKM(cbMaSPCTHD.Text);
                                                        decimal TTTThem = 0;
                                                        if (checkSPKMDoi(textBox1.Text))
                                                        {
                                                            TTTThem += TinhGiaKMDoi(textBox1.Text);
                                                            //MessageBox.Show(TTTThem.ToString());
                                                        }
                                                        else
                                                        {
                                                            TTTThem += getGiaGoc(textBox1.Text);
                                                            //MessageBox.Show(TTTThem.ToString()+"    "+ TtThua.ToString());
                                                        }

                                                        if (TtThua - TTTThem > 0)
                                                        {
                                                            txtTienThua.Text = (TtThua - TTTThem).ToString();
                                                            txtTienThuThem.Text = 0.ToString();
                                                        }
                                                        else if (TtThua - TTTThem < 0)
                                                        {
                                                            txtTienThuThem.Text = (TTTThem - TtThua).ToString();
                                                            txtTienThua.Text = 0.ToString();
                                                        }
                                                        else
                                                        {
                                                            txtTienThua.Text = 0.ToString();
                                                            txtTienThuThem.Text = 0.ToString();
                                                        }

                                                    }
                                                    listView1.Items.Add((index + 1).ToString());
                                                    listView1.Items[index].SubItems.Add(cbMaSPCTHD.Text);
                                                    listView1.Items[index].SubItems.Add((1).ToString());
                                                    listView2.Items.Add((index + 1).ToString());
                                                    listView2.Items[index].SubItems.Add(textBox1.Text);
                                                    listView2.Items[index].SubItems.Add((1).ToString());
                                                    index++;
                                                }
                                                else
                                                {
                                                    MessageBox.Show("Vượt quá SL tồn của sản phẩm đổi :" + textBox1.Text);
                                                }

                                            }
                                            else
                                            {
                                                MessageBox.Show("Vượt quá SL mua còn lại của sản phẩm này!");
                                            }
                                        }
                                        else
                                        {
                                            //MessageBox.Show("Là SPKM - MAKM :" + getMaKM(cbMaSPCTHD.Text) + " hết TG KM");
                                            if (checkSLTrongListView(cbMaSPCTHD.Text) + 1 <= getSLMua())
                                            {
                                                if (checkSLTrongListViewDoi(textBox1.Text) + 1 <= getSLTonSPDOi(textBox1.Text))
                                                {
                                                    var TienThua = txtTienThua.Text;
                                                    var TienThuThem = txtTienThuThem.Text;
                                                    if (TienThua != null && TienThua != "" && TienThuThem != null && TienThuThem != "")
                                                    {

                                                        var TienThua1 = decimal.Parse(txtTienThua.Text);
                                                        var TienThuThem1 = decimal.Parse(txtTienThuThem.Text);

                                                        var TongTienThua = TienThua1 + TinhGiaKM(cbMaSPCTHD.Text);

                                                        var TongTienThuThem = TienThuThem1/* + TinhGiaKM(textBox1.Text)*/;
                                                        if (checkSPKMDoi(textBox1.Text))
                                                        {
                                                            TongTienThuThem += TinhGiaKMDoi(textBox1.Text);
                                                        }
                                                        else
                                                        {
                                                            TongTienThuThem += getGiaGoc(textBox1.Text);
                                                        }


                                                        if (TongTienThua - TongTienThuThem > 0)
                                                        {
                                                            txtTienThua.Text = (TongTienThua - TongTienThuThem).ToString();
                                                            txtTienThuThem.Text = 0.ToString();
                                                        }
                                                        else if (TongTienThua - TongTienThuThem < 0)
                                                        {
                                                            txtTienThuThem.Text = (TongTienThuThem - TongTienThua).ToString();
                                                            txtTienThua.Text = 0.ToString();
                                                        }
                                                        else
                                                        {
                                                            txtTienThua.Text = 0.ToString();
                                                            txtTienThuThem.Text = 0.ToString();
                                                        }
                                                    }
                                                    else
                                                    {
                                                        var TtThua = TinhGiaKM(cbMaSPCTHD.Text);
                                                        decimal TTTThem = 0;
                                                        if (checkSPKMDoi(textBox1.Text))
                                                        {
                                                            TTTThem += TinhGiaKMDoi(textBox1.Text);
                                                            //MessageBox.Show(TTTThem.ToString());
                                                        }
                                                        else
                                                        {
                                                            TTTThem += getGiaGoc(textBox1.Text);
                                                            //MessageBox.Show(TTTThem.ToString()+"    "+ TtThua.ToString());
                                                        }

                                                        if (TtThua - TTTThem > 0)
                                                        {
                                                            txtTienThua.Text = (TtThua - TTTThem).ToString();
                                                            txtTienThuThem.Text = 0.ToString();
                                                        }
                                                        else if (TtThua - TTTThem < 0)
                                                        {
                                                            txtTienThuThem.Text = (TTTThem - TtThua).ToString();
                                                            txtTienThua.Text = 0.ToString();
                                                        }
                                                        else
                                                        {
                                                            txtTienThua.Text = 0.ToString();
                                                            txtTienThuThem.Text = 0.ToString();
                                                        }

                                                    }
                                                    listView1.Items.Add((index + 1).ToString());
                                                    listView1.Items[index].SubItems.Add(cbMaSPCTHD.Text);
                                                    listView1.Items[index].SubItems.Add((1).ToString());
                                                    listView2.Items.Add((index + 1).ToString());
                                                    listView2.Items[index].SubItems.Add(textBox1.Text);
                                                    listView2.Items[index].SubItems.Add((1).ToString());
                                                    index++;
                                                }
                                                else
                                                {
                                                    MessageBox.Show("Vượt quá SL tồn của sản phẩm đổi :" + textBox1.Text);
                                                }

                                            }
                                            else
                                            {
                                                MessageBox.Show("Vượt quá SL mua của sản phẩm này!");
                                            }
                                        }
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Không được đổi sản phẩm này sang sản phẩm hàng tặng!");
                                }
                            }
                            
                        }
                    }
                    else
                    {
                        if (TinhSoNgay() > 30)
                        {
                            textBox1.Text = null;
                            //textBox1.Enabled = false;
                            //txtSLDoi.Text = null;
                            txtTenSPDoi.Text = null;
                            txtLoaiSPDoi.Text = null;
                            txtMauSacDoi.Text = null;
                            txtKCDoi.Text = null;
                            btnAdd.Enabled = false;
                            MessageBox.Show("Mặt hàng Km này giá > 250000 đã quá 30 ngày đổi hàng");
                        }
                        else
                        {
                            var SPCTDoi = (from spct in db.SanPhamChiTiets
                                           where spct.MaSpCt == textBox1.Text
                                           select spct).ToList();
                            if (SPCTDoi.Count > 0)
                            {
                                var SPCTDOi1 = SPCTDoi.FirstOrDefault();
                                if (!getMaSPHangTang().Contains(SPCTDOi1.MaSp))
                                {
                                    if (TrongTGKM(cbMaSPCTHD.Text) == true)
                                    {
                                        //MessageBox.Show("Là SPKM - MAKM :" + getMaKM() + " vẫn đang KM");
                                        var SPCT = (from spct in db.SanPhamChiTiets
                                                    where spct.MaSpCt == textBox1.Text
                                                    select spct).ToList();
                                        if (SPCT.Count > 0)
                                        {
                                            var SPCT1 = SPCT.FirstOrDefault();
                                            if (getMaSPCungCTKM(cbMaSPCTHD.Text).Contains(SPCT1.MaSp))
                                            {
                                                if (getSLDaDoi(txtMaHD.Text, cbMaSPCTHD.Text) > 0)
                                                {
                                                    if (checkSLTrongListView(cbMaSPCTHD.Text) + 1 <= (getSLMua()- getSLDaDoi(txtMaHD.Text, cbMaSPCTHD.Text)))
                                                    {
                                                        if (checkSLTrongListViewDoi(textBox1.Text) + 1 <= getSLTonSPDOi(textBox1.Text))
                                                        {
                                                            var TienThua = txtTienThua.Text;
                                                            var TienThuThem = txtTienThuThem.Text;
                                                            if (getMaSp(cbMaSPCTHD.Text) == getMaSp(textBox1.Text))
                                                            {
                                                                if (TienThua != null && TienThua != "" && TienThuThem != null && TienThuThem != "")
                                                                {
                                                                    txtTienThua.Text = txtTienThua.Text;
                                                                    txtTienThuThem.Text = txtTienThuThem.Text;
                                                                }
                                                                else
                                                                {
                                                                    txtTienThua.Text = 0.ToString();
                                                                    txtTienThuThem.Text = 0.ToString();
                                                                }
                                                            }
                                                            else
                                                            {
                                                                if (TienThua != null && TienThua != "" && TienThuThem != null && TienThuThem != "")
                                                                {

                                                                    var TienThua1 = decimal.Parse(txtTienThua.Text);
                                                                    var TienThuThem1 = decimal.Parse(txtTienThuThem.Text);

                                                                    var TongTienThua = TienThua1 + TinhGiaKM(cbMaSPCTHD.Text);
                                                                    var TongTienThuThem = TienThuThem1 + TinhGiaKM(textBox1.Text);

                                                                    if (TongTienThua - TongTienThuThem > 0)
                                                                    {
                                                                        txtTienThua.Text = (TongTienThua - TongTienThuThem).ToString();
                                                                        txtTienThuThem.Text = 0.ToString();
                                                                    }
                                                                    else if (TongTienThua - TongTienThuThem < 0)
                                                                    {
                                                                        txtTienThuThem.Text = (TongTienThuThem - TongTienThua).ToString();
                                                                        txtTienThua.Text = 0.ToString();
                                                                    }
                                                                    else
                                                                    {
                                                                        txtTienThua.Text = 0.ToString();
                                                                        txtTienThuThem.Text = 0.ToString();
                                                                    }
                                                                }
                                                                else
                                                                {
                                                                    var TtThua = TinhGiaKM(cbMaSPCTHD.Text);
                                                                    var TTTThem = TinhGiaKM(textBox1.Text);
                                                                    if (TtThua - TTTThem > 0)
                                                                    {
                                                                        txtTienThua.Text = (TtThua - TTTThem).ToString();
                                                                        txtTienThuThem.Text = 0.ToString();
                                                                    }
                                                                    else if (TtThua - TTTThem < 0)
                                                                    {
                                                                        txtTienThuThem.Text = (TTTThem - TtThua).ToString();
                                                                        txtTienThua.Text = 0.ToString();
                                                                    }
                                                                    else
                                                                    {
                                                                        txtTienThua.Text = 0.ToString();
                                                                        txtTienThuThem.Text = 0.ToString();
                                                                    }

                                                                }
                                                            }
                                                            listView1.Items.Add((index + 1).ToString());
                                                            listView1.Items[index].SubItems.Add(cbMaSPCTHD.Text);
                                                            listView1.Items[index].SubItems.Add((1).ToString());
                                                            listView2.Items.Add((index + 1).ToString());
                                                            listView2.Items[index].SubItems.Add(textBox1.Text);
                                                            listView2.Items[index].SubItems.Add((1).ToString());
                                                            index++;
                                                        }
                                                        else
                                                        {
                                                            MessageBox.Show("Vượt quá SL tồn của sản phẩm đổi :" + textBox1.Text);
                                                        }
                                                    }
                                                    else
                                                    {
                                                        MessageBox.Show("Vượt quá SL mua còn lại của sản phẩm này!");
                                                    }
                                                }
                                                else
                                                {
                                                    if (checkSLTrongListView(cbMaSPCTHD.Text) + 1 <= getSLMua())
                                                    {
                                                        if (checkSLTrongListViewDoi(textBox1.Text) + 1 <= getSLTonSPDOi(textBox1.Text))
                                                        {
                                                            var TienThua = txtTienThua.Text;
                                                            var TienThuThem = txtTienThuThem.Text;
                                                            if (getMaSp(cbMaSPCTHD.Text) == getMaSp(textBox1.Text))
                                                            {
                                                                if (TienThua != null && TienThua != "" && TienThuThem != null && TienThuThem != "")
                                                                {
                                                                    txtTienThua.Text = txtTienThua.Text;
                                                                    txtTienThuThem.Text = txtTienThuThem.Text;
                                                                }
                                                                else
                                                                {
                                                                    txtTienThua.Text = 0.ToString();
                                                                    txtTienThuThem.Text = 0.ToString();
                                                                }
                                                            }
                                                            else
                                                            {
                                                                if (TienThua != null && TienThua != "" && TienThuThem != null && TienThuThem != "")
                                                                {

                                                                    var TienThua1 = decimal.Parse(txtTienThua.Text);
                                                                    var TienThuThem1 = decimal.Parse(txtTienThuThem.Text);

                                                                    var TongTienThua = TienThua1 + TinhGiaKM(cbMaSPCTHD.Text);
                                                                    var TongTienThuThem = TienThuThem1 + TinhGiaKM(textBox1.Text);

                                                                    if (TongTienThua - TongTienThuThem > 0)
                                                                    {
                                                                        txtTienThua.Text = (TongTienThua - TongTienThuThem).ToString();
                                                                        txtTienThuThem.Text = 0.ToString();
                                                                    }
                                                                    else if (TongTienThua - TongTienThuThem < 0)
                                                                    {
                                                                        txtTienThuThem.Text = (TongTienThuThem - TongTienThua).ToString();
                                                                        txtTienThua.Text = 0.ToString();
                                                                    }
                                                                    else
                                                                    {
                                                                        txtTienThua.Text = 0.ToString();
                                                                        txtTienThuThem.Text = 0.ToString();
                                                                    }
                                                                }
                                                                else
                                                                {
                                                                    var TtThua = TinhGiaKM(cbMaSPCTHD.Text);
                                                                    var TTTThem = TinhGiaKM(textBox1.Text);
                                                                    if (TtThua - TTTThem > 0)
                                                                    {
                                                                        txtTienThua.Text = (TtThua - TTTThem).ToString();
                                                                        txtTienThuThem.Text = 0.ToString();
                                                                    }
                                                                    else if (TtThua - TTTThem < 0)
                                                                    {
                                                                        txtTienThuThem.Text = (TTTThem - TtThua).ToString();
                                                                        txtTienThua.Text = 0.ToString();
                                                                    }
                                                                    else
                                                                    {
                                                                        txtTienThua.Text = 0.ToString();
                                                                        txtTienThuThem.Text = 0.ToString();
                                                                    }

                                                                }
                                                            }
                                                            listView1.Items.Add((index + 1).ToString());
                                                            listView1.Items[index].SubItems.Add(cbMaSPCTHD.Text);
                                                            listView1.Items[index].SubItems.Add((1).ToString());
                                                            listView2.Items.Add((index + 1).ToString());
                                                            listView2.Items[index].SubItems.Add(textBox1.Text);
                                                            listView2.Items[index].SubItems.Add((1).ToString());
                                                            index++;
                                                        }
                                                        else
                                                        {
                                                            MessageBox.Show("Vượt quá SL tồn của sản phẩm đổi :" + textBox1.Text);
                                                        }
                                                    }
                                                    else
                                                    {
                                                        MessageBox.Show("Vượt quá SL mua của sản phẩm này!");
                                                    }
                                                }

                                                //
                                            }
                                            else
                                            {
                                                MessageBox.Show("SP của bạn vẫn đang trong chương trình KM. Bạn chỉ có thể đổi sang các SP cùng chương trình KM này!");
                                            }
                                        }
                                    }
                                    else
                                    {
                                        if (getSLDaDoi(txtMaHD.Text, cbMaSPCTHD.Text) > 0)
                                        {
                                            //MessageBox.Show("Là SPKM - MAKM :" + getMaKM(cbMaSPCTHD.Text) + " hết TG KM");
                                            if (checkSLTrongListView(cbMaSPCTHD.Text) + 1 <= (getSLMua()- getSLDaDoi(txtMaHD.Text, cbMaSPCTHD.Text)))
                                            {
                                                if (checkSLTrongListViewDoi(textBox1.Text) + 1 <= getSLTonSPDOi(textBox1.Text))
                                                {
                                                    var TienThua = txtTienThua.Text;
                                                    var TienThuThem = txtTienThuThem.Text;
                                                    if (TienThua != null && TienThua != "" && TienThuThem != null && TienThuThem != "")
                                                    {


                                                        var TienThua1 = decimal.Parse(txtTienThua.Text);
                                                        var TienThuThem1 = decimal.Parse(txtTienThuThem.Text);

                                                        var TongTienThua = TienThua1 + TinhGiaKM(cbMaSPCTHD.Text);

                                                        var TongTienThuThem = TienThuThem1/* + TinhGiaKM(textBox1.Text)*/;
                                                        if (checkSPKMDoi(textBox1.Text))
                                                        {
                                                            TongTienThuThem += TinhGiaKMDoi(textBox1.Text);
                                                        }
                                                        else
                                                        {
                                                            TongTienThuThem += getGiaGoc(textBox1.Text);
                                                        }


                                                        if (TongTienThua - TongTienThuThem > 0)
                                                        {
                                                            txtTienThua.Text = (TongTienThua - TongTienThuThem).ToString();
                                                            txtTienThuThem.Text = 0.ToString();
                                                        }
                                                        else if (TongTienThua - TongTienThuThem < 0)
                                                        {
                                                            txtTienThuThem.Text = (TongTienThuThem - TongTienThua).ToString();
                                                            txtTienThua.Text = 0.ToString();
                                                        }
                                                        else
                                                        {
                                                            txtTienThua.Text = 0.ToString();
                                                            txtTienThuThem.Text = 0.ToString();
                                                        }
                                                    }
                                                    else
                                                    {
                                                        var TtThua = TinhGiaKM(cbMaSPCTHD.Text);
                                                        decimal TTTThem = 0;
                                                        if (checkSPKMDoi(textBox1.Text))
                                                        {
                                                            TTTThem += TinhGiaKMDoi(textBox1.Text);
                                                            //MessageBox.Show(TTTThem.ToString());
                                                        }
                                                        else
                                                        {
                                                            TTTThem += getGiaGoc(textBox1.Text);
                                                            //MessageBox.Show(TTTThem.ToString()+"    "+ TtThua.ToString());
                                                        }

                                                        if (TtThua - TTTThem > 0)
                                                        {
                                                            txtTienThua.Text = (TtThua - TTTThem).ToString();
                                                            txtTienThuThem.Text = 0.ToString();
                                                        }
                                                        else if (TtThua - TTTThem < 0)
                                                        {
                                                            txtTienThuThem.Text = (TTTThem - TtThua).ToString();
                                                            txtTienThua.Text = 0.ToString();
                                                        }
                                                        else
                                                        {
                                                            txtTienThua.Text = 0.ToString();
                                                            txtTienThuThem.Text = 0.ToString();
                                                        }

                                                    }
                                                    listView1.Items.Add((index + 1).ToString());
                                                    listView1.Items[index].SubItems.Add(cbMaSPCTHD.Text);
                                                    listView1.Items[index].SubItems.Add((1).ToString());
                                                    listView2.Items.Add((index + 1).ToString());
                                                    listView2.Items[index].SubItems.Add(textBox1.Text);
                                                    listView2.Items[index].SubItems.Add((1).ToString());
                                                    index++;
                                                }
                                                else
                                                {
                                                    MessageBox.Show("Vượt quá SL tồn của sản phẩm đổi :" + textBox1.Text);
                                                }

                                            }
                                            else
                                            {
                                                MessageBox.Show("Vượt quá SL mua còn lại của sản phẩm này!");
                                            }
                                        }
                                        else
                                        {
                                            //MessageBox.Show("Là SPKM - MAKM :" + getMaKM(cbMaSPCTHD.Text) + " hết TG KM");
                                            if (checkSLTrongListView(cbMaSPCTHD.Text) + 1 <= getSLMua())
                                            {
                                                if (checkSLTrongListViewDoi(textBox1.Text) + 1 <= getSLTonSPDOi(textBox1.Text))
                                                {
                                                    var TienThua = txtTienThua.Text;
                                                    var TienThuThem = txtTienThuThem.Text;
                                                    if (TienThua != null && TienThua != "" && TienThuThem != null && TienThuThem != "")
                                                    {


                                                        var TienThua1 = decimal.Parse(txtTienThua.Text);
                                                        var TienThuThem1 = decimal.Parse(txtTienThuThem.Text);

                                                        var TongTienThua = TienThua1 + TinhGiaKM(cbMaSPCTHD.Text);

                                                        var TongTienThuThem = TienThuThem1/* + TinhGiaKM(textBox1.Text)*/;
                                                        if (checkSPKMDoi(textBox1.Text))
                                                        {
                                                            TongTienThuThem += TinhGiaKMDoi(textBox1.Text);
                                                        }
                                                        else
                                                        {
                                                            TongTienThuThem += getGiaGoc(textBox1.Text);
                                                        }


                                                        if (TongTienThua - TongTienThuThem > 0)
                                                        {
                                                            txtTienThua.Text = (TongTienThua - TongTienThuThem).ToString();
                                                            txtTienThuThem.Text = 0.ToString();
                                                        }
                                                        else if (TongTienThua - TongTienThuThem < 0)
                                                        {
                                                            txtTienThuThem.Text = (TongTienThuThem - TongTienThua).ToString();
                                                            txtTienThua.Text = 0.ToString();
                                                        }
                                                        else
                                                        {
                                                            txtTienThua.Text = 0.ToString();
                                                            txtTienThuThem.Text = 0.ToString();
                                                        }
                                                    }
                                                    else
                                                    {
                                                        var TtThua = TinhGiaKM(cbMaSPCTHD.Text);
                                                        decimal TTTThem = 0;
                                                        if (checkSPKMDoi(textBox1.Text))
                                                        {
                                                            TTTThem += TinhGiaKMDoi(textBox1.Text);
                                                            //MessageBox.Show(TTTThem.ToString());
                                                        }
                                                        else
                                                        {
                                                            TTTThem += getGiaGoc(textBox1.Text);
                                                            //MessageBox.Show(TTTThem.ToString()+"    "+ TtThua.ToString());
                                                        }

                                                        if (TtThua - TTTThem > 0)
                                                        {
                                                            txtTienThua.Text = (TtThua - TTTThem).ToString();
                                                            txtTienThuThem.Text = 0.ToString();
                                                        }
                                                        else if (TtThua - TTTThem < 0)
                                                        {
                                                            txtTienThuThem.Text = (TTTThem - TtThua).ToString();
                                                            txtTienThua.Text = 0.ToString();
                                                        }
                                                        else
                                                        {
                                                            txtTienThua.Text = 0.ToString();
                                                            txtTienThuThem.Text = 0.ToString();
                                                        }

                                                    }
                                                    listView1.Items.Add((index + 1).ToString());
                                                    listView1.Items[index].SubItems.Add(cbMaSPCTHD.Text);
                                                    listView1.Items[index].SubItems.Add((1).ToString());
                                                    listView2.Items.Add((index + 1).ToString());
                                                    listView2.Items[index].SubItems.Add(textBox1.Text);
                                                    listView2.Items[index].SubItems.Add((1).ToString());
                                                    index++;
                                                }
                                                else
                                                {
                                                    MessageBox.Show("Vượt quá SL tồn của sản phẩm đổi :" + textBox1.Text);
                                                }

                                            }
                                            else
                                            {
                                                MessageBox.Show("Vượt quá SL mua của sản phẩm này!");
                                            }
                                        }
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Không được đổi sản phẩm này sang sản phẩm hàng tặng!");
                                }
                            }
                        }
                    
                    }

                }
                else
                {
                    var SPCTDoi = (from spct in db.SanPhamChiTiets
                                where spct.MaSpCt == textBox1.Text
                                select spct).ToList();
                    if (SPCTDoi.Count > 0)
                    {
                        var SPCTDOi1 = SPCTDoi.FirstOrDefault();
                        if (!getMaSPHangTang().Contains(SPCTDOi1.MaSp))
                        {
                            if (TinhSoNgay() <= 30)
                            {
                                if (getSLDaDoi(txtMaHD.Text, cbMaSPCTHD.Text) > 0)
                                {
                                    //MessageBox.Show("K phải SPKM");
                                    if (checkSLTrongListView(cbMaSPCTHD.Text) + 1 <= (getSLMua()- getSLDaDoi(txtMaHD.Text, cbMaSPCTHD.Text)))
                                    {
                                        if (checkSLTrongListViewDoi(textBox1.Text) + 1 <= getSLTonSPDOi(textBox1.Text))
                                        {
                                            var TienThua = txtTienThua.Text;
                                            var TienThuThem = txtTienThuThem.Text;
                                            if (getMaSp(cbMaSPCTHD.Text) == getMaSp(textBox1.Text))
                                            {
                                                if (TienThua != null && TienThua != "" && TienThuThem != null && TienThuThem != "")
                                                {
                                                    txtTienThua.Text = txtTienThua.Text;
                                                    txtTienThuThem.Text = txtTienThuThem.Text;
                                                }
                                                else
                                                {
                                                    txtTienThua.Text = 0.ToString();
                                                    txtTienThuThem.Text = 0.ToString();
                                                }
                                            }
                                            else
                                            {
                                                if (TienThua != null && TienThua != "" && TienThuThem != null && TienThuThem != "")
                                                {

                                                    var TienThua1 = decimal.Parse(txtTienThua.Text);
                                                    var TienThuThem1 = decimal.Parse(txtTienThuThem.Text);

                                                    var TongTienThua = TienThua1 + getGiaGoc(cbMaSPCTHD.Text);

                                                    var TongTienThuThem = TienThuThem1/* + TinhGiaKM(textBox1.Text)*/;
                                                    if (checkSPKMDoi(textBox1.Text))
                                                    {
                                                        TongTienThuThem += TinhGiaKMDoi(textBox1.Text);
                                                    }
                                                    else
                                                    {
                                                        TongTienThuThem += getGiaGoc(textBox1.Text);
                                                    }


                                                    if (TongTienThua - TongTienThuThem > 0)
                                                    {
                                                        txtTienThua.Text = (TongTienThua - TongTienThuThem).ToString();
                                                        txtTienThuThem.Text = 0.ToString();
                                                    }
                                                    else if (TongTienThua - TongTienThuThem < 0)
                                                    {
                                                        txtTienThuThem.Text = (TongTienThuThem - TongTienThua).ToString();
                                                        txtTienThua.Text = 0.ToString();
                                                    }
                                                    else
                                                    {
                                                        txtTienThua.Text = 0.ToString();
                                                        txtTienThuThem.Text = 0.ToString();
                                                    }
                                                }
                                                else
                                                {
                                                    var TtThua = getGiaGoc(cbMaSPCTHD.Text);
                                                    decimal TTTThem = 0;
                                                    if (checkSPKMDoi(textBox1.Text))
                                                    {
                                                        TTTThem += TinhGiaKMDoi(textBox1.Text);
                                                        //MessageBox.Show(TTTThem.ToString());
                                                    }
                                                    else
                                                    {
                                                        TTTThem += getGiaGoc(textBox1.Text);
                                                        //MessageBox.Show(TTTThem.ToString()+"    "+ TtThua.ToString());
                                                    }

                                                    if (TtThua - TTTThem > 0)
                                                    {
                                                        txtTienThua.Text = (TtThua - TTTThem).ToString();
                                                        txtTienThuThem.Text = 0.ToString();
                                                    }
                                                    else if (TtThua - TTTThem < 0)
                                                    {
                                                        txtTienThuThem.Text = (TTTThem - TtThua).ToString();
                                                        txtTienThua.Text = 0.ToString();
                                                    }
                                                    else
                                                    {
                                                        txtTienThua.Text = 0.ToString();
                                                        txtTienThuThem.Text = 0.ToString();
                                                    }

                                                }
                                            }
                                            listView1.Items.Add((index + 1).ToString());
                                            listView1.Items[index].SubItems.Add(cbMaSPCTHD.Text);
                                            listView1.Items[index].SubItems.Add((1).ToString());
                                            listView2.Items.Add((index + 1).ToString());
                                            listView2.Items[index].SubItems.Add(textBox1.Text);
                                            listView2.Items[index].SubItems.Add((1).ToString());
                                            index++;
                                        }
                                        else
                                        {
                                            MessageBox.Show("Vượt quá SL tồn của sản phẩm đổi :" + textBox1.Text);
                                        }

                                    }
                                    else
                                    {
                                        MessageBox.Show("Vượt quá SL mua còn lại của sản phẩm này!");
                                    }
                                }
                                else
                                {
                                    //MessageBox.Show("K phải SPKM");
                                    if (checkSLTrongListView(cbMaSPCTHD.Text) + 1 <= getSLMua())
                                    {
                                        if (checkSLTrongListViewDoi(textBox1.Text) + 1 <= getSLTonSPDOi(textBox1.Text))
                                        {
                                            var TienThua = txtTienThua.Text;
                                            var TienThuThem = txtTienThuThem.Text;
                                            if (getMaSp(cbMaSPCTHD.Text) == getMaSp(textBox1.Text))
                                            {
                                                if (TienThua != null && TienThua != "" && TienThuThem != null && TienThuThem != "")
                                                {
                                                    txtTienThua.Text = txtTienThua.Text;
                                                    txtTienThuThem.Text = txtTienThuThem.Text;
                                                }
                                                else
                                                {
                                                    txtTienThua.Text = 0.ToString();
                                                    txtTienThuThem.Text = 0.ToString();
                                                }
                                            }
                                            else
                                            {
                                                if (TienThua != null && TienThua != "" && TienThuThem != null && TienThuThem != "")
                                                {

                                                    var TienThua1 = decimal.Parse(txtTienThua.Text);
                                                    var TienThuThem1 = decimal.Parse(txtTienThuThem.Text);

                                                    var TongTienThua = TienThua1 + getGiaGoc(cbMaSPCTHD.Text);

                                                    var TongTienThuThem = TienThuThem1/* + TinhGiaKM(textBox1.Text)*/;
                                                    if (checkSPKMDoi(textBox1.Text))
                                                    {
                                                        TongTienThuThem += TinhGiaKMDoi(textBox1.Text);
                                                    }
                                                    else
                                                    {
                                                        TongTienThuThem += getGiaGoc(textBox1.Text);
                                                    }


                                                    if (TongTienThua - TongTienThuThem > 0)
                                                    {
                                                        txtTienThua.Text = (TongTienThua - TongTienThuThem).ToString();
                                                        txtTienThuThem.Text = 0.ToString();
                                                    }
                                                    else if (TongTienThua - TongTienThuThem < 0)
                                                    {
                                                        txtTienThuThem.Text = (TongTienThuThem - TongTienThua).ToString();
                                                        txtTienThua.Text = 0.ToString();
                                                    }
                                                    else
                                                    {
                                                        txtTienThua.Text = 0.ToString();
                                                        txtTienThuThem.Text = 0.ToString();
                                                    }
                                                }
                                                else
                                                {
                                                    var TtThua = getGiaGoc(cbMaSPCTHD.Text);
                                                    decimal TTTThem = 0;
                                                    if (checkSPKMDoi(textBox1.Text))
                                                    {
                                                        TTTThem += TinhGiaKMDoi(textBox1.Text);
                                                        //MessageBox.Show(TTTThem.ToString());
                                                    }
                                                    else
                                                    {
                                                        TTTThem += getGiaGoc(textBox1.Text);
                                                        //MessageBox.Show(TTTThem.ToString()+"    "+ TtThua.ToString());
                                                    }

                                                    if (TtThua - TTTThem > 0)
                                                    {
                                                        txtTienThua.Text = (TtThua - TTTThem).ToString();
                                                        txtTienThuThem.Text = 0.ToString();
                                                    }
                                                    else if (TtThua - TTTThem < 0)
                                                    {
                                                        txtTienThuThem.Text = (TTTThem - TtThua).ToString();
                                                        txtTienThua.Text = 0.ToString();
                                                    }
                                                    else
                                                    {
                                                        txtTienThua.Text = 0.ToString();
                                                        txtTienThuThem.Text = 0.ToString();
                                                    }

                                                }
                                            }
                                            listView1.Items.Add((index + 1).ToString());
                                            listView1.Items[index].SubItems.Add(cbMaSPCTHD.Text);
                                            listView1.Items[index].SubItems.Add((1).ToString());
                                            listView2.Items.Add((index + 1).ToString());
                                            listView2.Items[index].SubItems.Add(textBox1.Text);
                                            listView2.Items[index].SubItems.Add((1).ToString());
                                            index++;
                                        }
                                        else
                                        {
                                            MessageBox.Show("Vượt quá SL tồn của sản phẩm đổi :" + textBox1.Text);
                                        }

                                    }
                                    else
                                    {
                                        MessageBox.Show("Vượt quá SL mua của sản phẩm này!");
                                    }
                                }
                            }
                            else
                            {
                                MessageBox.Show("SP đã quá 30 ngày đổi hàng!");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Không được đổi sản phẩm này sang sản phẩm hàng tặng!");
                        }
                    }
                    

                }

            }
            else
            {
                if (TinhSoNgay() <= 7)
                {
                    var SPCT = (from spct in db.SanPhamChiTiets
                                where spct.MaSpCt == textBox1.Text
                                select spct).ToList();
                    if (SPCT.Count > 0)
                    {
                        var SPCT1 = SPCT.FirstOrDefault();
                        if (getMaSPHangTang().Contains(SPCT1.MaSp))
                        {
                            if (getSLDaDoi(txtMaHD.Text, cbMaSPCTHD.Text) > 0)
                            {
                                if (checkSLTrongListView(cbMaSPCTHD.Text) + 1 <= (getSLMua()- getSLDaDoi(txtMaHD.Text, cbMaSPCTHD.Text)))
                                {
                                    if (checkSLTrongListViewDoi(textBox1.Text) + 1 <= getSLTonSPDOi(textBox1.Text))
                                    {
                                        listView1.Items.Add((index + 1).ToString());
                                        listView1.Items[index].SubItems.Add(cbMaSPCTHD.Text);
                                        listView1.Items[index].SubItems.Add((1).ToString());
                                        listView2.Items.Add((index + 1).ToString());
                                        listView2.Items[index].SubItems.Add(textBox1.Text);
                                        listView2.Items[index].SubItems.Add((1).ToString());
                                        index++;
                                    }
                                    else
                                    {
                                        MessageBox.Show("Vượt quá SL tồn của sản phẩm đổi :" + textBox1.Text);
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Vượt quá SL mua còn lại của SP!");
                                }
                            }
                            else
                            {
                                if (checkSLTrongListView(cbMaSPCTHD.Text) + 1 <= getSLMua())
                                {
                                    if (checkSLTrongListViewDoi(textBox1.Text) + 1 <= getSLTonSPDOi(textBox1.Text))
                                    {
                                        listView1.Items.Add((index + 1).ToString());
                                        listView1.Items[index].SubItems.Add(cbMaSPCTHD.Text);
                                        listView1.Items[index].SubItems.Add((1).ToString());
                                        listView2.Items.Add((index + 1).ToString());
                                        listView2.Items[index].SubItems.Add(textBox1.Text);
                                        listView2.Items[index].SubItems.Add((1).ToString());
                                        index++;
                                    }
                                    else
                                    {
                                        MessageBox.Show("Vượt quá SL tồn của sản phẩm đổi :" + textBox1.Text);
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Vượt quá SL mua của SP!");
                                }

                            }
                                
                        }
                        else
                        {
                            MessageBox.Show("SP Hàng tặng chỉ được đổi với SP cùng là Hàng tặng!");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("SP Hàng tặng này đã quá 7 ngày đổi hàng!");
                }
            }

        }

        public List<String> getMaSPHangTang()
        {
            List<String> list = new List<String>();
            var SP = (from sp in db.SanPhams
                      where sp.MaLoaiSp== "LSP007"
                      select sp).ToList();
            if (SP.Count > 0)
            {
                foreach (var i1 in SP)
                {
                    list.Add(i1.MaSp);
                }
            }
            

            return list;
        }

        public decimal TinhGiaKM(string a)
        {
            decimal giaKM = 0;
            if (checkSPKM(a))
            {
                /*if (TrongTGKM(a))
                {*/
                    var KM = (from spkm in db.KhuyenMaiSanPhams
                              where spkm.MaSp == getMaSp(a) && spkm.MaKm == getMaKM(a)
                              select spkm).ToList();
                    if (KM.Count > 0)
                    {
                        var tyle = Convert.ToDecimal(KM.FirstOrDefault().TyLeKhuyenMai);
                        giaKM = getGiaGoc(a) - (tyle * getGiaGoc(a));
                    }
               /* }*/
            }
            return giaKM;
        }

        public decimal TinhGiaKMDoi(string a)
        {
            decimal giaKM = 0;
            if (checkSPKMDoi(a))
            {

                var KM = (from spkm in db.KhuyenMaiSanPhams
                          where spkm.MaSp == getMaSp(a) && spkm.MaKm == getMaKMDoi(a)
                          select spkm).ToList();
                if (KM.Count > 0)
                {
                    var tyle = Convert.ToDecimal(KM.FirstOrDefault().TyLeKhuyenMai);
                    giaKM = getGiaGoc(a) - (tyle * getGiaGoc(a));
                }

            }
            return giaKM;
        }

        public decimal getGiaGoc(string a)
        {
            var SP = (from sp in db.SanPhams
                      where sp.MaSp == getMaSp(a)
                      select sp).ToList();
            decimal gia = 0;
            if (SP.Count > 0)
            {
                gia = SP.FirstOrDefault().DonGia;
            }
            return gia;
        }

        public string getMaSp(string a)
        {
            var SPCT = (from spct in db.SanPhamChiTiets
                        where spct.MaSpCt == a
                        select spct).ToList();
            string ma = null;
            if (SPCT.Count > 0)
            {
                ma = SPCT.FirstOrDefault().MaSp;
            }
            return ma;
        }

        public int getSLMua()
        {
            var HDSP = (from hdsp in db.HoaDonBanHangSanPhams
                        where hdsp.MaHd == txtMaHD.Text && hdsp.MaSpCt == cbMaSPCTHD.Text
                        select hdsp).ToList();
            var SL = 0;
            if (HDSP.Count > 0)
            {
                SL = HDSP.FirstOrDefault().SoLuongBan;
            }
            return SL;
        }

        public int getSLTonSPDOi(string a)
        {
            var SPCT = (from spct in db.SanPhamChiTiets
                        where spct.MaSpCt == a
                        select spct).ToList();
            var SL = 0;
            if (SPCT.Count > 0)
            {
                SL = SPCT.FirstOrDefault().SoLuongTon;
            }
            return SL;
        }

        public int checkSLTrongListViewDoi(string a)
        {
            int i = 0;
            int count = 0;
            for (i = 0; i < listView2.Items.Count; i++)
            {
                if (listView2.Items[i].SubItems[1].Text == a)
                {
                    count += 1;
                }

            }
            return count;
        }

        public int checkSLTrongListView(string a)
        {
            int i = 0;
            int count = 0;
            for (i = 0; i < listView1.Items.Count; i++)
            {
                if (listView1.Items[i].SubItems[1].Text == a)
                {
                    count += 1;
                }

            }
            return count;
        }

        public List<String> getMaSPCungCTKM(string a)
        {
            var KMSP = (from kmsp in db.KhuyenMaiSanPhams
                        where kmsp.MaKm == getMaKM(a)
                        select kmsp).ToList();
            List<String> list = new List<String>();
            var SP = (from sp in db.SanPhams
                      select sp).ToList();
            foreach (var i in KMSP)
            {
                foreach (var i1 in SP)
                {
                    if (i1.MaSp == i.MaSp)
                    {
                        list.Add(i1.MaSp);
                    }
                }
            }

            return list;
        }

        public bool TrongTGKM(string a)
        {
            var SPCTHD = (from Spcthd in db.SanPhamChiTiets
                          where Spcthd.MaSpCt == a
                          select Spcthd).ToList();
            bool check = false;
            if (SPCTHD.Count > 0)
            {
                var SPCTHD1 = SPCTHD.FirstOrDefault();
                var SP = (from Sp in db.SanPhams
                          where Sp.MaSp == SPCTHD1.MaSp
                          select Sp).ToList();


                if (SP.Count > 0)
                {
                    var SP1 = SP.FirstOrDefault();

                    var KM = (from km in db.KhuyenMais
                              select km).ToList();
                    var HD = (from hd in db.HoaDonBanHangs
                              where hd.MaHd == txtMaHD.Text
                              select hd).ToList();

                    if (HD.Count > 0)
                    {
                        if (HD.FirstOrDefault() != null)
                        {
                            foreach (var i in KM)
                            {
                                if (i.MaKm == getMaKM(a))
                                {
                                    TimeSpan Time1 = i.NgayKetThuc - DateTime.Now;
                                    if (Time1.Days >= 0)
                                    {
                                        check = true;
                                        break;
                                    }
                                }

                            }

                        }
                    }
                }

            }
            return check;
        }

        public bool checkSPKMDoi(string a)
        {
            var SPCTHD = (from Spcthd in db.SanPhamChiTiets
                          where Spcthd.MaSpCt == a
                          select Spcthd).ToList();
            bool check = false;
            if (SPCTHD.Count > 0)
            {
                var SPCTHD1 = SPCTHD.FirstOrDefault();
                var SP = (from Sp in db.SanPhams
                          where Sp.MaSp == SPCTHD1.MaSp
                          select Sp).ToList();
                if (SP.Count > 0)
                {
                    var SP1 = SP.FirstOrDefault();
                    var SPKM = (from Spkm in db.KhuyenMaiSanPhams
                                where Spkm.MaSp == SP1.MaSp
                                select Spkm).ToList();
                    var KM = (from km in db.KhuyenMais
                              select km).ToList();
                    if (SPKM.Count > 0)
                    {
                        foreach (var i in SPKM)
                        {
                            if (check == true)
                            {
                                break;
                            }
                            else
                            {
                                foreach (var i1 in KM)
                                {
                                    TimeSpan Time1 = DateTime.Now - i1.NgayBatDau;
                                    TimeSpan Time2 = i1.NgayKetThuc - DateTime.Now;
                                    if (i1.MaKm == i.MaKm && Time1.Days >= 0 && Time2.Days >= 0)
                                    {
                                        check = true;
                                        break;

                                    }
                                    else
                                    {
                                        check = false;
                                    }
                                }
                            }

                        }
                    }


                }
            }
            return check;
        }

        public string getMaKMDoi(string a)
        {
            var SPCTHD = (from Spcthd in db.SanPhamChiTiets
                          where Spcthd.MaSpCt == a
                          select Spcthd).ToList();
            bool check = false;
            string maKM = null;
            if (SPCTHD.Count > 0)
            {
                var SPCTHD1 = SPCTHD.FirstOrDefault();
                var SP = (from Sp in db.SanPhams
                          where Sp.MaSp == SPCTHD1.MaSp
                          select Sp).ToList();
                if (SP.Count > 0)
                {
                    var SP1 = SP.FirstOrDefault();
                    var SPKM = (from Spkm in db.KhuyenMaiSanPhams
                                where Spkm.MaSp == SP1.MaSp
                                select Spkm).ToList();
                    var KM = (from km in db.KhuyenMais
                              select km).ToList();
                    if (SPKM.Count > 0)
                    {
                        foreach (var i in SPKM)
                        {
                            if (check == true)
                            {
                                break;
                            }
                            else
                            {
                                foreach (var i1 in KM)
                                {
                                    TimeSpan Time1 = DateTime.Now - i1.NgayBatDau;
                                    TimeSpan Time2 = i1.NgayKetThuc - DateTime.Now;
                                    if (i1.MaKm == i.MaKm && Time1.Days >= 0 && Time2.Days >= 0)
                                    {
                                        check = true;
                                        maKM = i1.MaKm;
                                        break;

                                    }
                                    else
                                    {
                                        check = false;
                                    }
                                }
                            }

                        }
                    }


                }
            }
            return maKM;
        }

        public bool checkSPKM(string a)
        {
            var SPCTHD = (from Spcthd in db.SanPhamChiTiets
                          where Spcthd.MaSpCt == a
                          select Spcthd).ToList();
            bool check = false;
            if (SPCTHD.Count > 0)
            {
                var SPCTHD1 = SPCTHD.FirstOrDefault();
                var SP = (from Sp in db.SanPhams
                          where Sp.MaSp == SPCTHD1.MaSp
                          select Sp).ToList();


                if (SP.Count > 0)
                {
                    var SP1 = SP.FirstOrDefault();
                    var HD = (from hd in db.HoaDonBanHangs
                              where hd.MaHd == txtMaHD.Text
                              select hd).ToList();

                    if (HD.Count > 0)
                    {
                        if (HD.FirstOrDefault() != null)
                        {
                            var ngaymua = HD.FirstOrDefault().NgayBan;
                            //TimeSpan Time = DateTime.Now - ngaymua;
                            //TongSoNgay = Time.Days;
                            var SPKM = (from Spkm in db.KhuyenMaiSanPhams
                                        where Spkm.MaSp == SP1.MaSp
                                        select Spkm).ToList();
                            var KM = (from km in db.KhuyenMais
                                      select km).ToList();
                            if (SPKM.Count > 0)
                            {
                                foreach (var i in SPKM)
                                {
                                    if (check == true)
                                    {
                                        break;
                                    }
                                    else
                                    {
                                        foreach (var i1 in KM)
                                        {
                                            TimeSpan Time1 = ngaymua - i1.NgayBatDau;
                                            TimeSpan Time2 = i1.NgayKetThuc - ngaymua;
                                            if (i1.MaKm == i.MaKm && Time1.Days >= 0 && Time2.Days >= 0)
                                            {

                                                check = true;
                                                break;

                                            }
                                            else
                                            {
                                                check = false;
                                            }
                                        }
                                    }

                                }
                            }
                        }
                    }
                }
            }
            return check;
        }

        public string getMaKM(string a)
        {
            var SPCTHD = (from Spcthd in db.SanPhamChiTiets
                          where Spcthd.MaSpCt == a
                          select Spcthd).ToList();
            bool check = false;
            string MaKM = null;
            if (SPCTHD.Count > 0)
            {
                var SPCTHD1 = SPCTHD.FirstOrDefault();
                var SP = (from Sp in db.SanPhams
                          where Sp.MaSp == SPCTHD1.MaSp
                          select Sp).ToList();


                if (SP.Count > 0)
                {
                    var SP1 = SP.FirstOrDefault();
                    var HD = (from hd in db.HoaDonBanHangs
                              where hd.MaHd == txtMaHD.Text
                              select hd).ToList();

                    if (HD.Count > 0)
                    {
                        if (HD.FirstOrDefault() != null)
                        {
                            var ngaymua = HD.FirstOrDefault().NgayBan;
                            //TimeSpan Time = DateTime.Now - ngaymua;
                            //TongSoNgay = Time.Days;
                            var SPKM = (from Spkm in db.KhuyenMaiSanPhams
                                        where Spkm.MaSp == SP1.MaSp
                                        select Spkm).ToList();
                            var KM = (from km in db.KhuyenMais
                                      select km).ToList();
                            if (SPKM.Count > 0)
                            {
                                foreach (var i in SPKM)
                                {
                                    if (check == true)
                                    {
                                        break;
                                    }
                                    else
                                    {
                                        foreach (var i1 in KM)
                                        {
                                            TimeSpan Time1 = ngaymua - i1.NgayBatDau;
                                            TimeSpan Time2 = i1.NgayKetThuc - ngaymua;
                                            if (i1.MaKm == i.MaKm && Time1.Days >= 0 && Time2.Days >= 0)
                                            {
                                                MaKM = i1.MaKm;
                                                check = true;
                                                break;

                                            }
                                            else
                                            {
                                                check = false;
                                            }
                                        }
                                    }

                                }
                            }
                        }
                    }
                }
            }
            return MaKM;
        }

        public bool checkLiDo()
        {
            if (txtLidoDoi.Text == null || txtLidoDoi.Text == "")
            {
                errorProvider1.SetError(txtLidoDoi, "Bạn không được để trống li do đổi hàng!");

                //MessageBox.Show("Bạn không được để trống tên!");
                return false;
            }
            else
            {
                errorProvider1.SetError(txtLidoDoi, "");
                return true;
            }
        }

        public bool tonTaiSPtrongLv()
        {
            if(listView1.Items.Count>0 && listView2.Items.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (checkLiDo() && tonTaiSPtrongLv())
            {
                try
                {
                    PhieuDoiHang phieu = new PhieuDoiHang();
                    phieu.MaPhieuDoi = lbMaPhieuDoi.Text;
                    phieu.NgayLap = DateTime.Now;
                    phieu.MaNv = txtMaNV.Text;

                    phieu.MaHd = txtMaHD.Text;
                    phieu.LyDoDoi = txtLidoDoi.Text;
                    phieu.TienThua = decimal.Parse(txtTienThua.Text);
                    phieu.TienThuLai = decimal.Parse(txtTienThuThem.Text);
                    db.PhieuDoiHangs.Add(phieu);
                    var SPCT = (from spct in db.SanPhamChiTiets
                                select spct).ToList();
                    for (int i = 0; i < listView1.Items.Count; i++)
                    {
                        PhieuDoiSanPhamHd pdhd = new PhieuDoiSanPhamHd();
                        pdhd.MaPd = lbMaPhieuDoi.Text;
                        pdhd.MaSpct = listView1.Items[i].SubItems[1].Text;
                        pdhd.Sl = int.Parse(listView1.Items[i].SubItems[2].Text);
                        db.PhieuDoiSanPhamHds.Add(pdhd);
                        foreach(var i1 in SPCT)
                        {
                            if(i1.MaSpCt == listView1.Items[i].SubItems[1].Text)
                            {
                                i1.SoLuongTon += 1;
                                break;
                            }
                        }

                    }
                    for (int i = 0; i < listView2.Items.Count; i++)
                    {
                        PhieuDoiSanPhamDoi pdd = new PhieuDoiSanPhamDoi();
                        pdd.MaPd = lbMaPhieuDoi.Text;
                        pdd.MaSpct = listView2.Items[i].SubItems[1].Text;
                        pdd.Sl = int.Parse(listView2.Items[i].SubItems[2].Text);
                        db.PhieuDoiSanPhamDois.Add(pdd);
                        foreach (var i1 in SPCT)
                        {
                            if (i1.MaSpCt == listView2.Items[i].SubItems[1].Text)
                            {
                                i1.SoLuongTon -= 1;
                                break;
                            }
                        }

                    }

                    db.SaveChanges();

                    btnReset_Click(sender, e);
                    AddPhieuDoi_Load(sender, e);
                    MessageBox.Show("SCC: Thêm phiếu đổi hàng thành công!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("ERROR: " + ex.Message);  
                }
            }
            else
            {
                if (checkLiDo() == false)
                {
                    checkLiDo();
                    txtLidoDoi.Focus();
                }
                if(tonTaiSPtrongLv()==false)
                {
                    MessageBox.Show("Bạn chưa thêm sản phẩm vào Phiếu!");
                }
                

            }
        }

        public int getSLDaDoi(string a, string b)
        {
            var PD = (from pd in db.PhieuDoiHangs
                      where pd.MaHd == a
                      select pd).ToList();
            int SL = 0;
            if (PD.Count > 0)
            {
                foreach(var i in PD)
                {
                    var PDHD = (from pdhd in db.PhieuDoiSanPhamHds
                                where pdhd.MaPd==i.MaPhieuDoi
                                select pdhd).ToList();
                    if (PDHD.Count > 0)
                    {
                        foreach(var i1 in PDHD)
                        {
                            if (i1.MaSpct == b)
                            {
                                SL += 1;

                            }
                        }
                    }
                    
                }
            }
            else
            {
                SL = 0;
            }
            return SL;
        }
    }
}
