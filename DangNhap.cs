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

        private void DangNhap_Load_1(object sender, EventArgs e)
        {
            txtTenDangNhap.Focus();

        }

        private void btn_dangnhap_Click(object sender, EventArgs e)
        {
            var user = (from item in db.NhanViens
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
                    this.Tag = user;
                    this.DialogResult = DialogResult.OK;

                }
                else if (user.Quyen == "Nhân viên")
                {
                    this.Tag = user;
                    this.DialogResult = DialogResult.OK;

                }
            }

        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
