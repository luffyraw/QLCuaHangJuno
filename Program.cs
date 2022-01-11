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



            do
            {
                using (DangNhap login = new DangNhap())
                {
                    if (login.ShowDialog() == DialogResult.OK)
                    {
                        Application.Run(new GiaoDienAdmin(login.Tag as NhanVien));
                    }
                    else if (login.ShowDialog() == DialogResult.Yes)
                    {
                        Application.Run(new GiaoDienNhanVien(login.Tag as NhanVien));
                    }
                }
            } while (true);
        }
    }
}
