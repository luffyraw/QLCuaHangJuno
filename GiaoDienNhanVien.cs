﻿using System;
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
    public partial class GiaoDienNhanVien : Form
    {
        public GiaoDienNhanVien()
        {
            InitializeComponent();
        }

     

        private void trảHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddPhieuTH form = new AddPhieuTH();
            form.Show();
        }

        private void đổiHàngtoolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddPhieuDoi form = new AddPhieuDoi();
            form.Show();
        }
    }
}
