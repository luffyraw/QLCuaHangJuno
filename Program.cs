using QLCuaHangJuno.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLCuaHangJuno
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            DangNhap login = new DangNhap();
            if (login.ShowDialog() == DialogResult.OK)
            {
                NhanVien nv = login.Tag as NhanVien;
                if (nv.Quyen == "Quản lý")
                {
                    GiaoDienAdmin form = new GiaoDienAdmin();
                    form.nv = login.Tag as NhanVien;
                    Application.Run(form);
                }
                else
                {
                    GiaoDienNhanVien form = new GiaoDienNhanVien();
                    form.nv = login.Tag as NhanVien;
                    Application.Run(form);

                }
            }
            else
            {
                Application.Exit();
            }




        }


    }
}
