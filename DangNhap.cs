﻿using QLCuaHangJuno.DataModel;
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
    public partial class DangNhap : Form
    {
        QuanLyCuaHangJunoContext db = new QuanLyCuaHangJunoContext(); 
        public DangNhap()
        {
            InitializeComponent();
        }

        private void DangNhap_Load(object sender, EventArgs e)
        {
            GiaoDienNhanVien gd = new GiaoDienNhanVien();
            gd.Show();
        }
    }
}
