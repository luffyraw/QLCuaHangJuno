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
    public partial class ThongKeNhanVien : Form
    {
        QuanLyCuaHangJunoContext db = new QuanLyCuaHangJunoContext();
        public ThongKeNhanVien()
        {
            InitializeComponent();
        }

        private void ThongKeNhanVien_Load(object sender, EventArgs e)
        {
            label1.Text = "Báo cáo hoạt động nhân viên tháng " + DateTime.Now.Month + "năm " + DateTime.Now.Year;
            cb_thang.Text = DateTime.Now.Month.ToString();
            var sonv = (from item in db.NhanViens select item).Count();
            lb_Nv.Text = "Số nhân viên " + sonv;
            TKNhanVien(DateTime.Now.Month, DateTime.Now.Year);
        }
        private void TKNhanVien(int thang, int nam)
        {
            for (int i = listView1.Items.Count - 1; i > 0; i--)
            {
                
                    listView1.Items[i].Remove();
                
            }
            var listhd = from item in db.HoaDonBanHangs
                     join s in db.HoaDonBanHangSanPhams on item.MaHd equals s.MaHd
                     join nv in db.NhanViens on item.MaNv equals nv.MaNv
                     where item.NgayBan.Year == nam
                     && item.NgayBan.Month == thang
                     select new
                     {
                         manv = nv.MaNv,
                         ten = nv.HoTenNv,
                         sl = s.SoLuongBan
                     };
            List<NhanVien> listnv = (from item in db.NhanViens select item).ToList();
            lb_Nv.Text = "Số nhân viên: " + (from item in db.NhanViens select item).Count().ToString();
            listView1.Items[0].Text = "1";
            listView1.Items[0].SubItems.Add("2");
            listView1.Items[0].SubItems.Add("3");
            listView1.Items[0].SubItems.Add("4");
            int stt = 1;
            foreach (NhanVien item in listnv)
            {
                int sohd = 0;
                int slban = 0;
                foreach (var hd in listhd.ToList())
                {
                    if (hd.manv == item.MaNv)
                    {
                        sohd++;
                        slban += hd.sl;
                    }
                }
                listView1.Items.Add(item.MaNv);
                listView1.Items[stt].SubItems.Add(item.HoTenNv);
                listView1.Items[stt].SubItems.Add(sohd.ToString());
                listView1.Items[stt].SubItems.Add(slban.ToString());
                stt++;
            }



        }

        private void btn_tim_Click(object sender, EventArgs e)
        {
            label1.Text = "Báo cáo hoạt động nhân viên tháng " + cb_thang.Text + "năm " + cb_year.Text;
            TKNhanVien(int.Parse(cb_thang.Text), int.Parse(cb_year.Text));

        }
    }
}
