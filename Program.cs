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
                            GiaoDienAdmin form = new GiaoDienAdmin();
                            form.nv = login.Tag as NhanVien;
                            Application.Run(form);
                        }
                        if (login.ShowDialog() == DialogResult.Yes)
                        {
                            GiaoDienNhanVien form = new GiaoDienNhanVien();
                            form.nv = login.Tag as NhanVien;
                            Application.Run(form);
                        }
                    
                   
                                      
                }
            } while (true);
        }

        
    }
}
