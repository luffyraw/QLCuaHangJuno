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
    public partial class GiaoDienAdmin : Form
    {
        public GiaoDienAdmin()
        {
            InitializeComponent();
        }

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

       

        private void traHangToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DSPhieuTH ds = new DSPhieuTH();
            ds.Show();
        }

        private void đổiHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DSPhieuDoi ds = new DSPhieuDoi();
            ds.Show();
        }
    }
}
