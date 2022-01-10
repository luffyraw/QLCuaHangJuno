
namespace QLCuaHangJuno
{
    partial class frmBaoHanh
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbNgayTra = new System.Windows.Forms.Label();
            this.lbMaHD = new System.Windows.Forms.Label();
            this.lbMaNV = new System.Windows.Forms.Label();
            this.lbNgayLap = new System.Windows.Forms.Label();
            this.lbMaPhieu = new System.Windows.Forms.Label();
            this.dgvSanPham = new System.Windows.Forms.DataGridView();
            this.MaSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Loi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChiTiet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labe11 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btSua = new System.Windows.Forms.Button();
            this.btXoa = new System.Windows.Forms.Button();
            this.btClearAll = new System.Windows.Forms.Button();
            this.btClearSP = new System.Windows.Forms.Button();
            this.btThemSP = new System.Windows.Forms.Button();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtChiTietLoi = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.btThem = new System.Windows.Forms.Button();
            this.dtNgayTra = new System.Windows.Forms.DateTimePicker();
            this.dtLapPhieu = new System.Windows.Forms.DateTimePicker();
            this.cbLoi = new System.Windows.Forms.ComboBox();
            this.txtMaSP = new System.Windows.Forms.TextBox();
            this.txtMaHD = new System.Windows.Forms.TextBox();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.txtMaPhieu = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanPham)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lbNgayTra);
            this.panel1.Controls.Add(this.lbMaHD);
            this.panel1.Controls.Add(this.lbMaNV);
            this.panel1.Controls.Add(this.lbNgayLap);
            this.panel1.Controls.Add(this.lbMaPhieu);
            this.panel1.Controls.Add(this.dgvSanPham);
            this.panel1.Controls.Add(this.labe11);
            this.panel1.Location = new System.Drawing.Point(655, 42);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(685, 442);
            this.panel1.TabIndex = 0;
            // 
            // lbNgayTra
            // 
            this.lbNgayTra.AutoSize = true;
            this.lbNgayTra.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbNgayTra.Location = new System.Drawing.Point(395, 142);
            this.lbNgayTra.Name = "lbNgayTra";
            this.lbNgayTra.Size = new System.Drawing.Size(57, 15);
            this.lbNgayTra.TabIndex = 5;
            this.lbNgayTra.Text = "Ngày trả:";
            // 
            // lbMaHD
            // 
            this.lbMaHD.AutoSize = true;
            this.lbMaHD.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbMaHD.Location = new System.Drawing.Point(124, 186);
            this.lbMaHD.Name = "lbMaHD";
            this.lbMaHD.Size = new System.Drawing.Size(76, 15);
            this.lbMaHD.TabIndex = 5;
            this.lbMaHD.Text = "Mã hóa đơn:";
            // 
            // lbMaNV
            // 
            this.lbMaNV.AutoSize = true;
            this.lbMaNV.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbMaNV.Location = new System.Drawing.Point(395, 102);
            this.lbMaNV.Name = "lbMaNV";
            this.lbMaNV.Size = new System.Drawing.Size(84, 15);
            this.lbMaNV.TabIndex = 5;
            this.lbMaNV.Text = "Mã nhân viên:";
            // 
            // lbNgayLap
            // 
            this.lbNgayLap.AutoSize = true;
            this.lbNgayLap.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbNgayLap.Location = new System.Drawing.Point(124, 142);
            this.lbNgayLap.Name = "lbNgayLap";
            this.lbNgayLap.Size = new System.Drawing.Size(91, 15);
            this.lbNgayLap.TabIndex = 5;
            this.lbNgayLap.Text = "Ngày lập phiếu:";
            // 
            // lbMaPhieu
            // 
            this.lbMaPhieu.AutoSize = true;
            this.lbMaPhieu.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbMaPhieu.Location = new System.Drawing.Point(124, 102);
            this.lbMaPhieu.Name = "lbMaPhieu";
            this.lbMaPhieu.Size = new System.Drawing.Size(61, 15);
            this.lbMaPhieu.TabIndex = 5;
            this.lbMaPhieu.Text = "Mã phiếu:";
            // 
            // dgvSanPham
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSanPham.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSanPham.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaSP,
            this.SoLuong,
            this.Loi,
            this.ChiTiet});
            this.dgvSanPham.Location = new System.Drawing.Point(43, 248);
            this.dgvSanPham.Name = "dgvSanPham";
            this.dgvSanPham.RowTemplate.Height = 25;
            this.dgvSanPham.Size = new System.Drawing.Size(603, 150);
            this.dgvSanPham.TabIndex = 4;
            this.dgvSanPham.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSanPham_CellContentClick);
            // 
            // MaSP
            // 
            this.MaSP.DataPropertyName = "MaSpCt";
            this.MaSP.HeaderText = "Mã sản phẩm";
            this.MaSP.Name = "MaSP";
            this.MaSP.Width = 110;
            // 
            // SoLuong
            // 
            this.SoLuong.DataPropertyName = "SoLuong";
            this.SoLuong.HeaderText = "Số lượng";
            this.SoLuong.Name = "SoLuong";
            // 
            // Loi
            // 
            this.Loi.DataPropertyName = "Loi";
            this.Loi.HeaderText = "Lỗi";
            this.Loi.Name = "Loi";
            this.Loi.Width = 150;
            // 
            // ChiTiet
            // 
            this.ChiTiet.DataPropertyName = "ChiTietLoi";
            this.ChiTiet.HeaderText = "Chi tiết lỗi";
            this.ChiTiet.Name = "ChiTiet";
            this.ChiTiet.Width = 200;
            // 
            // labe11
            // 
            this.labe11.AutoSize = true;
            this.labe11.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labe11.Location = new System.Drawing.Point(229, 39);
            this.labe11.Name = "labe11";
            this.labe11.Size = new System.Drawing.Size(215, 37);
            this.labe11.TabIndex = 3;
            this.labe11.Text = "Phiếu bảo hành";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.HighlightText;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btSua);
            this.panel2.Controls.Add(this.btXoa);
            this.panel2.Controls.Add(this.btClearAll);
            this.panel2.Controls.Add(this.btClearSP);
            this.panel2.Controls.Add(this.btThemSP);
            this.panel2.Controls.Add(this.txtSoLuong);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.txtChiTietLoi);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label15);
            this.panel2.Controls.Add(this.btThem);
            this.panel2.Controls.Add(this.dtNgayTra);
            this.panel2.Controls.Add(this.dtLapPhieu);
            this.panel2.Controls.Add(this.cbLoi);
            this.panel2.Controls.Add(this.txtMaSP);
            this.panel2.Controls.Add(this.txtMaHD);
            this.panel2.Controls.Add(this.txtMaNV);
            this.panel2.Controls.Add(this.txtMaPhieu);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(597, 657);
            this.panel2.TabIndex = 1;
            // 
            // btSua
            // 
            this.btSua.Location = new System.Drawing.Point(140, 578);
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(93, 41);
            this.btSua.TabIndex = 15;
            this.btSua.Text = "Sửa ";
            this.btSua.UseVisualStyleBackColor = true;
            this.btSua.Click += new System.EventHandler(this.btSua_Click);
            // 
            // btXoa
            // 
            this.btXoa.Location = new System.Drawing.Point(255, 578);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(91, 41);
            this.btXoa.TabIndex = 14;
            this.btXoa.Text = "Xóa";
            this.btXoa.UseVisualStyleBackColor = true;
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
            // 
            // btClearAll
            // 
            this.btClearAll.Location = new System.Drawing.Point(478, 578);
            this.btClearAll.Name = "btClearAll";
            this.btClearAll.Size = new System.Drawing.Size(90, 41);
            this.btClearAll.TabIndex = 11;
            this.btClearAll.Text = "Làm mới tất cả";
            this.btClearAll.UseVisualStyleBackColor = true;
            this.btClearAll.Click += new System.EventHandler(this.btClearAll_Click);
            // 
            // btClearSP
            // 
            this.btClearSP.Location = new System.Drawing.Point(368, 578);
            this.btClearSP.Name = "btClearSP";
            this.btClearSP.Size = new System.Drawing.Size(90, 41);
            this.btClearSP.TabIndex = 10;
            this.btClearSP.Text = "Làm mới sản phẩm";
            this.btClearSP.UseVisualStyleBackColor = true;
            this.btClearSP.Click += new System.EventHandler(this.btClearSP_Click);
            // 
            // btThemSP
            // 
            this.btThemSP.Location = new System.Drawing.Point(25, 578);
            this.btThemSP.Name = "btThemSP";
            this.btThemSP.Size = new System.Drawing.Size(90, 41);
            this.btThemSP.TabIndex = 9;
            this.btThemSP.Text = "Thêm";
            this.btThemSP.UseVisualStyleBackColor = true;
            this.btThemSP.Click += new System.EventHandler(this.btThemSP_Click);
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(166, 448);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(158, 23);
            this.txtSoLuong.TabIndex = 6;
            this.txtSoLuong.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoLuong_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(87, 451);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 15);
            this.label10.TabIndex = 13;
            this.label10.Text = "Số lượng:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(104, 336);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(345, 37);
            this.label9.TabIndex = 12;
            this.label9.Text = "Thêm sản phẩm bảo hành";
            // 
            // txtChiTietLoi
            // 
            this.txtChiTietLoi.Location = new System.Drawing.Point(166, 529);
            this.txtChiTietLoi.Name = "txtChiTietLoi";
            this.txtChiTietLoi.Size = new System.Drawing.Size(158, 23);
            this.txtChiTietLoi.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(80, 532);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 15);
            this.label8.TabIndex = 10;
            this.label8.Text = "Chi tiết lỗi:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label15.Location = new System.Drawing.Point(104, 14);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(347, 37);
            this.label15.TabIndex = 9;
            this.label15.Text = "Thêm thông tin cho phiếu";
            // 
            // btThem
            // 
            this.btThem.Location = new System.Drawing.Point(202, 284);
            this.btThem.Name = "btThem";
            this.btThem.Size = new System.Drawing.Size(75, 23);
            this.btThem.TabIndex = 8;
            this.btThem.Text = "Thêm";
            this.btThem.UseVisualStyleBackColor = true;
            this.btThem.Click += new System.EventHandler(this.btThem_Click);
            // 
            // dtNgayTra
            // 
            this.dtNgayTra.CustomFormat = "dd/MM/yyyy";
            this.dtNgayTra.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtNgayTra.Location = new System.Drawing.Point(166, 243);
            this.dtNgayTra.Name = "dtNgayTra";
            this.dtNgayTra.Size = new System.Drawing.Size(158, 23);
            this.dtNgayTra.TabIndex = 7;
            // 
            // dtLapPhieu
            // 
            this.dtLapPhieu.CustomFormat = "dd/MM/yyyy";
            this.dtLapPhieu.Enabled = false;
            this.dtLapPhieu.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtLapPhieu.Location = new System.Drawing.Point(166, 106);
            this.dtLapPhieu.Name = "dtLapPhieu";
            this.dtLapPhieu.Size = new System.Drawing.Size(158, 23);
            this.dtLapPhieu.TabIndex = 2;
            // 
            // cbLoi
            // 
            this.cbLoi.FormattingEnabled = true;
            this.cbLoi.Location = new System.Drawing.Point(166, 488);
            this.cbLoi.Name = "cbLoi";
            this.cbLoi.Size = new System.Drawing.Size(158, 23);
            this.cbLoi.TabIndex = 7;
            // 
            // txtMaSP
            // 
            this.txtMaSP.Location = new System.Drawing.Point(166, 408);
            this.txtMaSP.Name = "txtMaSP";
            this.txtMaSP.Size = new System.Drawing.Size(158, 23);
            this.txtMaSP.TabIndex = 5;
            // 
            // txtMaHD
            // 
            this.txtMaHD.Location = new System.Drawing.Point(166, 198);
            this.txtMaHD.Name = "txtMaHD";
            this.txtMaHD.Size = new System.Drawing.Size(158, 23);
            this.txtMaHD.TabIndex = 4;
            // 
            // txtMaNV
            // 
            this.txtMaNV.Location = new System.Drawing.Point(166, 153);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.ReadOnly = true;
            this.txtMaNV.Size = new System.Drawing.Size(158, 23);
            this.txtMaNV.TabIndex = 3;
            // 
            // txtMaPhieu
            // 
            this.txtMaPhieu.Location = new System.Drawing.Point(166, 69);
            this.txtMaPhieu.Name = "txtMaPhieu";
            this.txtMaPhieu.ReadOnly = true;
            this.txtMaPhieu.Size = new System.Drawing.Size(158, 23);
            this.txtMaPhieu.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(118, 491);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 15);
            this.label7.TabIndex = 0;
            this.label7.Text = "Lỗi:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(70, 201);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 15);
            this.label6.TabIndex = 0;
            this.label6.Text = "Mã hóa đơn:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(62, 411);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "Mã sản phẩm:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(62, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "Mã nhân viên:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(89, 249);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Ngày trả:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ngày lập phiếu:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(84, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã phiếu:";
            // 
            // frmBaoHanh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1370, 709);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmBaoHanh";
            this.Text = "frmBaoHanh";
            this.Load += new System.EventHandler(this.frmBaoHanh_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanPham)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtNgayTra;
        private System.Windows.Forms.DateTimePicker dtLapPhieu;
        private System.Windows.Forms.ComboBox cbLoi;
        private System.Windows.Forms.TextBox txtMaSP;
        private System.Windows.Forms.TextBox txtMaHD;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.TextBox txtMaPhieu;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btThem;
        private System.Windows.Forms.Label labe11;
        private System.Windows.Forms.DataGridView dgvSanPham;
        private System.Windows.Forms.TextBox txtChiTietLoi;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btClearAll;
        private System.Windows.Forms.Button btClearSP;
        private System.Windows.Forms.Button btThemSP;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lbNgayTra;
        private System.Windows.Forms.Label lbMaHD;
        private System.Windows.Forms.Label lbMaNV;
        private System.Windows.Forms.Label lbNgayLap;
        private System.Windows.Forms.Label lbMaPhieu;
        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.Button btSua;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn Loi;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChiTiet;
    }
}