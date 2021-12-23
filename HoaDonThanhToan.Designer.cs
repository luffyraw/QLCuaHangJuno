
namespace QLCuaHangJuno
{
    partial class HoaDonThanhToan
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
            this.txt_masp = new System.Windows.Forms.TextBox();
            this.dgv_dssp = new System.Windows.Forms.DataGridView();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_themKH = new System.Windows.Forms.Button();
            this.btn_luu = new System.Windows.Forms.Button();
            this.lb_thanhtien = new System.Windows.Forms.Label();
            this.lb_gghd = new System.Windows.Forms.Label();
            this.lb_tongtien = new System.Windows.Forms.Label();
            this.txt_diachiKH = new System.Windows.Forms.TextBox();
            this.txt_sdtKH = new System.Windows.Forms.TextBox();
            this.txt_hotenKH = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.lb_hotennv = new System.Windows.Forms.Label();
            this.lb_manv = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lb_ngaylap = new System.Windows.Forms.Label();
            this.lb_mahd = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_tensp = new System.Windows.Forms.TextBox();
            this.cb_mausac = new System.Windows.Forms.ComboBox();
            this.cb_kichco = new System.Windows.Forms.ComboBox();
            this.btn_them = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txt_dongia = new System.Windows.Forms.TextBox();
            this.txt_giamgia = new System.Windows.Forms.TextBox();
            this.txt_thanhtien = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.lb_soluong = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel2 = new System.Windows.Forms.Panel();
            this.num_soluong = new System.Windows.Forms.NumericUpDown();
            this.label23 = new System.Windows.Forms.Label();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_dssp)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_soluong)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_masp
            // 
            this.txt_masp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_masp.Location = new System.Drawing.Point(19, 71);
            this.txt_masp.Name = "txt_masp";
            this.txt_masp.PlaceholderText = "Mã sản phẩm";
            this.txt_masp.Size = new System.Drawing.Size(141, 27);
            this.txt_masp.TabIndex = 0;
            this.txt_masp.TextChanged += new System.EventHandler(this.txt_masp_TextChanged);
            // 
            // dgv_dssp
            // 
            this.dgv_dssp.AllowUserToAddRows = false;
            this.dgv_dssp.AllowUserToDeleteRows = false;
            this.dgv_dssp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_dssp.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10,
            this.Column11,
            this.Column12});
            this.dgv_dssp.Location = new System.Drawing.Point(19, 240);
            this.dgv_dssp.Name = "dgv_dssp";
            this.dgv_dssp.RowHeadersWidth = 51;
            this.dgv_dssp.RowTemplate.Height = 29;
            this.dgv_dssp.Size = new System.Drawing.Size(1222, 543);
            this.dgv_dssp.TabIndex = 1;
            this.dgv_dssp.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_dssp_CellContentClick);
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "masp";
            this.Column5.HeaderText = "MSP";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Width = 80;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "ten";
            this.Column6.HeaderText = "Tên";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.Width = 250;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "mausac";
            this.Column7.HeaderText = "Màu sắc";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.Width = 125;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "kichco";
            this.Column8.HeaderText = "Kích cỡ";
            this.Column8.MinimumWidth = 6;
            this.Column8.Name = "Column8";
            this.Column8.Width = 125;
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "soluong";
            this.Column9.HeaderText = "Số lượng";
            this.Column9.MinimumWidth = 6;
            this.Column9.Name = "Column9";
            this.Column9.Width = 125;
            // 
            // Column10
            // 
            this.Column10.DataPropertyName = "dongia";
            this.Column10.HeaderText = "Đơn giá (VND)";
            this.Column10.MinimumWidth = 6;
            this.Column10.Name = "Column10";
            this.Column10.Width = 150;
            // 
            // Column11
            // 
            this.Column11.DataPropertyName = "khuyenmai";
            this.Column11.HeaderText = "Khuyến mãi (%)";
            this.Column11.MinimumWidth = 6;
            this.Column11.Name = "Column11";
            this.Column11.Width = 150;
            // 
            // Column12
            // 
            this.Column12.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column12.DataPropertyName = "thanhtien";
            this.Column12.HeaderText = "Thành tiền (VND)";
            this.Column12.MinimumWidth = 6;
            this.Column12.Name = "Column12";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btn_themKH);
            this.panel1.Controls.Add(this.btn_luu);
            this.panel1.Controls.Add(this.lb_thanhtien);
            this.panel1.Controls.Add(this.lb_gghd);
            this.panel1.Controls.Add(this.lb_tongtien);
            this.panel1.Controls.Add(this.txt_diachiKH);
            this.panel1.Controls.Add(this.txt_sdtKH);
            this.panel1.Controls.Add(this.txt_hotenKH);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.lb_hotennv);
            this.panel1.Controls.Add(this.lb_manv);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.lb_ngaylap);
            this.panel1.Controls.Add(this.lb_mahd);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(1345, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(500, 783);
            this.panel1.TabIndex = 2;
            // 
            // btn_themKH
            // 
            this.btn_themKH.Location = new System.Drawing.Point(220, 331);
            this.btn_themKH.Name = "btn_themKH";
            this.btn_themKH.Size = new System.Drawing.Size(185, 39);
            this.btn_themKH.TabIndex = 6;
            this.btn_themKH.Text = "Thêm khách hàng mới";
            this.btn_themKH.UseVisualStyleBackColor = true;
            this.btn_themKH.Click += new System.EventHandler(this.btn_themKH_Click);
            // 
            // btn_luu
            // 
            this.btn_luu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_luu.Location = new System.Drawing.Point(48, 712);
            this.btn_luu.Name = "btn_luu";
            this.btn_luu.Size = new System.Drawing.Size(89, 54);
            this.btn_luu.TabIndex = 5;
            this.btn_luu.Text = "Lưu";
            this.btn_luu.UseVisualStyleBackColor = true;
            this.btn_luu.Click += new System.EventHandler(this.btn_luu_Click);
            // 
            // lb_thanhtien
            // 
            this.lb_thanhtien.AutoSize = true;
            this.lb_thanhtien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_thanhtien.Location = new System.Drawing.Point(48, 664);
            this.lb_thanhtien.Name = "lb_thanhtien";
            this.lb_thanhtien.Size = new System.Drawing.Size(96, 22);
            this.lb_thanhtien.TabIndex = 4;
            this.lb_thanhtien.Text = "Thành tiền";
            // 
            // lb_gghd
            // 
            this.lb_gghd.AutoSize = true;
            this.lb_gghd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_gghd.Location = new System.Drawing.Point(48, 616);
            this.lb_gghd.Name = "lb_gghd";
            this.lb_gghd.Size = new System.Drawing.Size(191, 22);
            this.lb_gghd.TabIndex = 4;
            this.lb_gghd.Text = "Giảm giá theo hóa đơn";
            // 
            // lb_tongtien
            // 
            this.lb_tongtien.AutoSize = true;
            this.lb_tongtien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_tongtien.Location = new System.Drawing.Point(48, 568);
            this.lb_tongtien.Name = "lb_tongtien";
            this.lb_tongtien.Size = new System.Drawing.Size(156, 22);
            this.lb_tongtien.TabIndex = 4;
            this.lb_tongtien.Text = "Tổng tiền hóa đơn";
            // 
            // txt_diachiKH
            // 
            this.txt_diachiKH.Location = new System.Drawing.Point(189, 289);
            this.txt_diachiKH.Name = "txt_diachiKH";
            this.txt_diachiKH.PlaceholderText = "Địa chỉ";
            this.txt_diachiKH.Size = new System.Drawing.Size(216, 27);
            this.txt_diachiKH.TabIndex = 3;
            // 
            // txt_sdtKH
            // 
            this.txt_sdtKH.Location = new System.Drawing.Point(189, 241);
            this.txt_sdtKH.Name = "txt_sdtKH";
            this.txt_sdtKH.PlaceholderText = "Số điện thoại";
            this.txt_sdtKH.Size = new System.Drawing.Size(216, 27);
            this.txt_sdtKH.TabIndex = 3;
            // 
            // txt_hotenKH
            // 
            this.txt_hotenKH.Location = new System.Drawing.Point(189, 193);
            this.txt_hotenKH.Name = "txt_hotenKH";
            this.txt_hotenKH.PlaceholderText = "Họ tên khách hàng";
            this.txt_hotenKH.Size = new System.Drawing.Size(216, 27);
            this.txt_hotenKH.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(48, 289);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 22);
            this.label9.TabIndex = 2;
            this.label9.Text = "Địa chỉ";
            // 
            // lb_hotennv
            // 
            this.lb_hotennv.AutoSize = true;
            this.lb_hotennv.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_hotennv.Location = new System.Drawing.Point(48, 472);
            this.lb_hotennv.Name = "lb_hotennv";
            this.lb_hotennv.Size = new System.Drawing.Size(63, 22);
            this.lb_hotennv.TabIndex = 2;
            this.lb_hotennv.Text = "Họ tên";
            // 
            // lb_manv
            // 
            this.lb_manv.AutoSize = true;
            this.lb_manv.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_manv.Location = new System.Drawing.Point(48, 424);
            this.lb_manv.Name = "lb_manv";
            this.lb_manv.Size = new System.Drawing.Size(117, 22);
            this.lb_manv.TabIndex = 2;
            this.lb_manv.Text = "Mã nhân viên";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(48, 241);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(115, 22);
            this.label8.TabIndex = 2;
            this.label8.Text = "Số điện thoại";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(48, 193);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 22);
            this.label7.TabIndex = 2;
            this.label7.Text = "Họ tên";
            // 
            // lb_ngaylap
            // 
            this.lb_ngaylap.AutoSize = true;
            this.lb_ngaylap.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_ngaylap.Location = new System.Drawing.Point(48, 104);
            this.lb_ngaylap.Name = "lb_ngaylap";
            this.lb_ngaylap.Size = new System.Drawing.Size(81, 22);
            this.lb_ngaylap.TabIndex = 2;
            this.lb_ngaylap.Text = "Ngày lập";
            // 
            // lb_mahd
            // 
            this.lb_mahd.AutoSize = true;
            this.lb_mahd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_mahd.Location = new System.Drawing.Point(48, 69);
            this.lb_mahd.Name = "lb_mahd";
            this.lb_mahd.Size = new System.Drawing.Size(104, 22);
            this.lb_mahd.TabIndex = 2;
            this.lb_mahd.Text = "Mã hóa đơn";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(115, 514);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(250, 29);
            this.label4.TabIndex = 1;
            this.label4.Text = "Thông tin thanh toán";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(115, 373);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(241, 29);
            this.label3.TabIndex = 1;
            this.label3.Text = "Thông tin nhân viên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(94, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(262, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Thông tin khách hàng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(126, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(301, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hóa đơn thanh toán";
            // 
            // txt_tensp
            // 
            this.txt_tensp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_tensp.Location = new System.Drawing.Point(181, 71);
            this.txt_tensp.Name = "txt_tensp";
            this.txt_tensp.PlaceholderText = "Tên sản phẩm";
            this.txt_tensp.ReadOnly = true;
            this.txt_tensp.Size = new System.Drawing.Size(876, 27);
            this.txt_tensp.TabIndex = 0;
            // 
            // cb_mausac
            // 
            this.cb_mausac.Cursor = System.Windows.Forms.Cursors.Default;
            this.cb_mausac.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cb_mausac.FormattingEnabled = true;
            this.cb_mausac.Location = new System.Drawing.Point(19, 138);
            this.cb_mausac.Name = "cb_mausac";
            this.cb_mausac.Size = new System.Drawing.Size(141, 28);
            this.cb_mausac.TabIndex = 1;
            this.cb_mausac.Text = "Màu sắc";
            this.cb_mausac.SelectedIndexChanged += new System.EventHandler(this.cb_mausac_SelectedIndexChanged);
            // 
            // cb_kichco
            // 
            this.cb_kichco.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cb_kichco.FormattingEnabled = true;
            this.cb_kichco.Location = new System.Drawing.Point(181, 138);
            this.cb_kichco.Name = "cb_kichco";
            this.cb_kichco.Size = new System.Drawing.Size(115, 28);
            this.cb_kichco.TabIndex = 2;
            this.cb_kichco.Text = "Kích cỡ";
            this.cb_kichco.SelectedIndexChanged += new System.EventHandler(this.cb_kichco_SelectedIndexChanged);
            // 
            // btn_them
            // 
            this.btn_them.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_them.Location = new System.Drawing.Point(1092, 105);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(142, 68);
            this.btn_them.TabIndex = 5;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(1092, 30);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(68, 68);
            this.button1.TabIndex = 5;
            this.button1.Text = "Hủy bỏ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(1166, 30);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(68, 68);
            this.button2.TabIndex = 5;
            this.button2.Text = "Xóa";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txt_dongia
            // 
            this.txt_dongia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_dongia.Location = new System.Drawing.Point(509, 135);
            this.txt_dongia.Name = "txt_dongia";
            this.txt_dongia.PlaceholderText = "Đơn giá";
            this.txt_dongia.ReadOnly = true;
            this.txt_dongia.Size = new System.Drawing.Size(171, 27);
            this.txt_dongia.TabIndex = 4;
            // 
            // txt_giamgia
            // 
            this.txt_giamgia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_giamgia.Location = new System.Drawing.Point(694, 135);
            this.txt_giamgia.Name = "txt_giamgia";
            this.txt_giamgia.PlaceholderText = "Giảm giá";
            this.txt_giamgia.ReadOnly = true;
            this.txt_giamgia.Size = new System.Drawing.Size(171, 27);
            this.txt_giamgia.TabIndex = 4;
            // 
            // txt_thanhtien
            // 
            this.txt_thanhtien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_thanhtien.Location = new System.Drawing.Point(886, 135);
            this.txt_thanhtien.Name = "txt_thanhtien";
            this.txt_thanhtien.PlaceholderText = "Thành tiền";
            this.txt_thanhtien.ReadOnly = true;
            this.txt_thanhtien.Size = new System.Drawing.Size(167, 27);
            this.txt_thanhtien.TabIndex = 4;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label15.Location = new System.Drawing.Point(19, 41);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(110, 20);
            this.label15.TabIndex = 6;
            this.label15.Text = "Mã sản phẩm";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label16.Location = new System.Drawing.Point(181, 41);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(115, 20);
            this.label16.TabIndex = 6;
            this.label16.Text = "Tên sản phẩm";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label17.Location = new System.Drawing.Point(19, 108);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(73, 20);
            this.label17.TabIndex = 6;
            this.label17.Text = "Màu sắc";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label18.Location = new System.Drawing.Point(181, 108);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(65, 20);
            this.label18.TabIndex = 6;
            this.label18.Text = "Kích cỡ";
            // 
            // lb_soluong
            // 
            this.lb_soluong.AutoSize = true;
            this.lb_soluong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_soluong.Location = new System.Drawing.Point(312, 105);
            this.lb_soluong.Name = "lb_soluong";
            this.lb_soluong.Size = new System.Drawing.Size(74, 20);
            this.lb_soluong.TabIndex = 6;
            this.lb_soluong.Text = "Số lượng";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label20.Location = new System.Drawing.Point(509, 105);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(119, 20);
            this.label20.TabIndex = 6;
            this.label20.Text = "Đơn giá (VND)";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label21.Location = new System.Drawing.Point(694, 105);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(108, 20);
            this.label21.TabIndex = 6;
            this.label21.Text = "Giảm giá (%)";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label22.Location = new System.Drawing.Point(886, 108);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(140, 20);
            this.label22.TabIndex = 6;
            this.label22.Text = "Thành tiền (VND)";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.num_soluong);
            this.panel2.Controls.Add(this.label23);
            this.panel2.Controls.Add(this.label16);
            this.panel2.Controls.Add(this.label22);
            this.panel2.Controls.Add(this.label21);
            this.panel2.Controls.Add(this.label20);
            this.panel2.Controls.Add(this.lb_soluong);
            this.panel2.Controls.Add(this.label18);
            this.panel2.Controls.Add(this.label17);
            this.panel2.Controls.Add(this.label15);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.btn_them);
            this.panel2.Controls.Add(this.txt_thanhtien);
            this.panel2.Controls.Add(this.txt_giamgia);
            this.panel2.Controls.Add(this.txt_dongia);
            this.panel2.Controls.Add(this.cb_kichco);
            this.panel2.Controls.Add(this.cb_mausac);
            this.panel2.Controls.Add(this.dgv_dssp);
            this.panel2.Controls.Add(this.txt_tensp);
            this.panel2.Controls.Add(this.txt_masp);
            this.panel2.Location = new System.Drawing.Point(14, 31);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1288, 800);
            this.panel2.TabIndex = 7;
            // 
            // num_soluong
            // 
            this.num_soluong.Location = new System.Drawing.Point(312, 138);
            this.num_soluong.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.num_soluong.Name = "num_soluong";
            this.num_soluong.Size = new System.Drawing.Size(186, 27);
            this.num_soluong.TabIndex = 3;
            this.num_soluong.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.num_soluong.ValueChanged += new System.EventHandler(this.num_soluong_ValueChanged);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label23.Location = new System.Drawing.Point(19, 192);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(233, 31);
            this.label23.TabIndex = 8;
            this.label23.Text = "Danh sách sản phẩm";
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MaSP";
            this.Column1.HeaderText = "Mã sản phẩm";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "MaMau";
            this.Column2.HeaderText = "Mã màu";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "MaKC";
            this.Column3.HeaderText = "Mã kích cỡ";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // HoaDonThanhToan
            // 
            this.AcceptButton = this.btn_them;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1902, 853);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "HoaDonThanhToan";
            this.Text = " ";
            this.Load += new System.EventHandler(this.HoaDonThanhToan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_dssp)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_soluong)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txt_masp;
        private System.Windows.Forms.DataGridView dgv_dssp;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txt_tensp;
        private System.Windows.Forms.ComboBox cb_mausac;
        private System.Windows.Forms.ComboBox cb_kichco;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lb_hotennv;
        private System.Windows.Forms.Label lb_manv;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lb_ngaylap;
        private System.Windows.Forms.Label lb_mahd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_dongia;
        private System.Windows.Forms.TextBox txt_giamgia;
        private System.Windows.Forms.TextBox txt_thanhtien;
        private System.Windows.Forms.Label lb_thanhtien;
        private System.Windows.Forms.Label lb_gghd;
        private System.Windows.Forms.Label lb_tongtien;
        private System.Windows.Forms.TextBox txt_diachiKH;
        private System.Windows.Forms.TextBox txt_sdtKH;
        private System.Windows.Forms.TextBox txt_hotenKH;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label lb_soluong;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Button btn_luu;
        private System.Windows.Forms.NumericUpDown num_soluong;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.Button btn_themKH;
    }
}