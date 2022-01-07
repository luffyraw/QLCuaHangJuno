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
    
    public partial class ThongKe : Form
    {
       
        public ThongKe()
        {
            InitializeComponent();

        }

        private void ThongKe_Load(object sender, EventArgs e)
        {
            QuanLyCuaHangJunoContext db = new QuanLyCuaHangJunoContext();
            var hd = from item in db.HoaDonBanHangs
                     where item.NgayBan.Year == dtp_thangnam.Value.Year
                     select item;
            string[] tkhd = new string[12];
            for (int i = 1; i <= 12; i++)
            {
                //int sohd = 0;
                //foreach (var item in hd.ToList())
                //{
                //    if (item.NgayBan.Month == i)
                //    {
                //        sohd++;
                //    }
                //}
                tkhd[i - 1] = i.ToString();
                
            }
            listView1.Columns.Add("Tháng 1",100);
            listView1.Columns.Add("Tháng 2",100);
            listView1.Columns.Add("Tháng 3",100);
            listView1.Columns.Add("Tháng 4",100);
            listView1.Columns.Add("Tháng 5",100);
            listView1.Columns.Add("Tháng 6",100);
            listView1.Columns.Add("Tháng 7",100);
            listView1.Columns.Add("Tháng 8",100);
            listView1.Columns.Add("Tháng 9",100);
            listView1.Columns.Add("Tháng 10",100);
            listView1.Columns.Add("Tháng 11",100);
            listView1.Columns.Add("Tháng 12",100);

            ListViewItem itm;
            //thêm Item vào ListView
           
            itm = new ListViewItem(tkhd);
            listView1.Items.Add(itm);



        }

        private void btn_tim_Click(object sender, EventArgs e)
        {
            QuanLyCuaHangJunoContext db = new QuanLyCuaHangJunoContext();
            var soHD = from item in db.HoaDonBanHangs
                       where item.NgayBan.Month == dtp_thangnam.Value.Month
                       && item.NgayBan.Year == dtp_thangnam.Value.Year
                       select item.MaHd;
            //   lb_hoadon.Text = soHD.Count().ToString();

            var sp = from item in db.HoaDonBanHangSanPhams
                     where soHD.Contains(item.MaHd)
                     select item;
            int sosp = 0;
            foreach (var item in sp)
            {
                sosp += item.SoLuongBan;
            }
            //   lb_sosp.Text = sosp.ToString();
        }

        private void dtp_thangnam_ValueChanged(object sender, EventArgs e)
        {

        }


    }
}
