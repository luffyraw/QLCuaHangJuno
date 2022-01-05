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
            using (DangNhap login = new DangNhap()) //if data ok, form will close it self!
            {
                if (login.ShowDialog() == DialogResult.OK)
                    Application.Run(new GiaoDienAdmin());
                if (login.ShowDialog() == DialogResult.Yes)
                    Application.Run(new GiaoDienNhanVien());
            }
        }
    }
}
