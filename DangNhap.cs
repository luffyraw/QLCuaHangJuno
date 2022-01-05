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

        QuanLyCuaHangJunoContext jn = new QuanLyCuaHangJunoContext();
        private void DangNhap_Load(object sender, EventArgs e)
        {
            txtTenDangNhap.Focus();
        }

        private void btDangNhap_Click(object sender, EventArgs e)
        {
            var user = (from item in jn.NhanViens
                        where txtTenDangNhap.Text == item.TenTk && txtMatKhau.Text == item.MatKhau
                        select item).FirstOrDefault();
            if (user == null)
            {

                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không chính xác không chính xác");

            }
            else
            {
                if (user.Quyen == "Quản lý")
                {

                    GiaoDienAdmin admin = new GiaoDienAdmin();
                    admin.Show();
                    this.DialogResult = DialogResult.OK;

                }
                else if (user.Quyen == "Nhân viên")
                {
                    GiaoDienNhanVien nhanVien = new GiaoDienNhanVien(user);
                    nhanVien.Show();
                    this.DialogResult = DialogResult.Yes;

                }
            }
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
