
namespace QLCuaHangJuno
{
    partial class frmKhuyenMaiSanPham
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvKMSP = new System.Windows.Forms.DataGridView();
            this.MaKM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Masanpham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaLoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayBatDau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayKetThuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TyLeKhuyenMai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cbMaSP = new System.Windows.Forms.ComboBox();
            this.cbMaLoaiSP = new System.Windows.Forms.ComboBox();
            this.txtTyLe = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnKM = new System.Windows.Forms.Button();
            this.cbMaKM = new System.Windows.Forms.ComboBox();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnChitiet = new System.Windows.Forms.Button();
            this.txtTimkiem = new System.Windows.Forms.TextBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKMSP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(837, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Khuyến mãi sản phẩm";
            // 
            // dgvKMSP
            // 
            this.dgvKMSP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvKMSP.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvKMSP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKMSP.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaKM,
            this.Masanpham,
            this.MaLoai,
            this.NgayBatDau,
            this.NgayKetThuc,
            this.TyLeKhuyenMai});
            this.dgvKMSP.Location = new System.Drawing.Point(491, 373);
            this.dgvKMSP.Name = "dgvKMSP";
            this.dgvKMSP.RowHeadersWidth = 51;
            this.dgvKMSP.RowTemplate.Height = 29;
            this.dgvKMSP.Size = new System.Drawing.Size(943, 250);
            this.dgvKMSP.TabIndex = 15;
            this.dgvKMSP.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKMSP_CellContentClick);
            // 
            // MaKM
            // 
            this.MaKM.DataPropertyName = "MaKm";
            this.MaKM.HeaderText = "Mã khuyễn mãi";
            this.MaKM.MinimumWidth = 6;
            this.MaKM.Name = "MaKM";
            this.MaKM.Width = 150;
            // 
            // Masanpham
            // 
            this.Masanpham.DataPropertyName = "MaSp";
            this.Masanpham.HeaderText = "Mã sản phẩm";
            this.Masanpham.MinimumWidth = 6;
            this.Masanpham.Name = "Masanpham";
            this.Masanpham.Width = 150;
            // 
            // MaLoai
            // 
            this.MaLoai.DataPropertyName = "MaLoaiSp";
            this.MaLoai.HeaderText = "Mã loại sản phẩm";
            this.MaLoai.MinimumWidth = 6;
            this.MaLoai.Name = "MaLoai";
            this.MaLoai.Width = 170;
            // 
            // NgayBatDau
            // 
            this.NgayBatDau.DataPropertyName = "NgayBatDau";
            this.NgayBatDau.HeaderText = "Ngày bắt đầu";
            this.NgayBatDau.MinimumWidth = 6;
            this.NgayBatDau.Name = "NgayBatDau";
            this.NgayBatDau.Width = 140;
            // 
            // NgayKetThuc
            // 
            this.NgayKetThuc.DataPropertyName = "NgayKetThuc";
            this.NgayKetThuc.HeaderText = "Ngày kết thúc";
            this.NgayKetThuc.MinimumWidth = 6;
            this.NgayKetThuc.Name = "NgayKetThuc";
            this.NgayKetThuc.Width = 140;
            // 
            // TyLeKhuyenMai
            // 
            this.TyLeKhuyenMai.DataPropertyName = "TyLeKhuyenMai";
            this.TyLeKhuyenMai.HeaderText = "Tỷ lệ khuyến mãi (%)";
            this.TyLeKhuyenMai.MinimumWidth = 6;
            this.TyLeKhuyenMai.Name = "TyLeKhuyenMai";
            this.TyLeKhuyenMai.Width = 160;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(165, 166);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(94, 29);
            this.btnThem.TabIndex = 16;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click_1);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(295, 166);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(94, 29);
            this.btnSua.TabIndex = 17;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(443, 166);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(94, 29);
            this.btnXoa.TabIndex = 18;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(860, 166);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(94, 29);
            this.btnThoat.TabIndex = 20;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(106, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Mã sản phẩm:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(470, 45);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(130, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Mã loại sản phẩm:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(470, 107);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(122, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "Tỷ lệ khuyễn mãi:";
            // 
            // cbMaSP
            // 
            this.cbMaSP.FormattingEnabled = true;
            this.cbMaSP.Location = new System.Drawing.Point(251, 100);
            this.cbMaSP.Name = "cbMaSP";
            this.cbMaSP.Size = new System.Drawing.Size(175, 28);
            this.cbMaSP.TabIndex = 10;
            // 
            // cbMaLoaiSP
            // 
            this.cbMaLoaiSP.FormattingEnabled = true;
            this.cbMaLoaiSP.Location = new System.Drawing.Point(615, 37);
            this.cbMaLoaiSP.Name = "cbMaLoaiSP";
            this.cbMaLoaiSP.Size = new System.Drawing.Size(175, 28);
            this.cbMaLoaiSP.TabIndex = 11;
            // 
            // txtTyLe
            // 
            this.txtTyLe.Location = new System.Drawing.Point(615, 100);
            this.txtTyLe.Name = "txtTyLe";
            this.txtTyLe.Size = new System.Drawing.Size(175, 27);
            this.txtTyLe.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(104, 45);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(112, 20);
            this.label8.TabIndex = 14;
            this.label8.Text = "Mã khuyễn mãi:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnKM);
            this.groupBox2.Controls.Add(this.cbMaKM);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.btnLamMoi);
            this.groupBox2.Controls.Add(this.btnThoat);
            this.groupBox2.Controls.Add(this.txtTyLe);
            this.groupBox2.Controls.Add(this.cbMaLoaiSP);
            this.groupBox2.Controls.Add(this.cbMaSP);
            this.groupBox2.Controls.Add(this.btnChitiet);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.btnXoa);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.btnSua);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.btnThem);
            this.groupBox2.Location = new System.Drawing.Point(485, 94);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(954, 195);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thêm sản phẩm khuyễn mãi";
            // 
            // btnKM
            // 
            this.btnKM.Location = new System.Drawing.Point(0, 166);
            this.btnKM.Name = "btnKM";
            this.btnKM.Size = new System.Drawing.Size(119, 29);
            this.btnKM.TabIndex = 26;
            this.btnKM.Text = "Thêm mã KM";
            this.btnKM.UseVisualStyleBackColor = true;
            this.btnKM.Click += new System.EventHandler(this.btnKM_Click);
            // 
            // cbMaKM
            // 
            this.cbMaKM.FormattingEnabled = true;
            this.cbMaKM.Location = new System.Drawing.Point(251, 44);
            this.cbMaKM.Name = "cbMaKM";
            this.cbMaKM.Size = new System.Drawing.Size(175, 28);
            this.cbMaKM.TabIndex = 15;
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Location = new System.Drawing.Point(733, 166);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(94, 29);
            this.btnLamMoi.TabIndex = 23;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = true;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // btnChitiet
            // 
            this.btnChitiet.Location = new System.Drawing.Point(595, 166);
            this.btnChitiet.Name = "btnChitiet";
            this.btnChitiet.Size = new System.Drawing.Size(94, 29);
            this.btnChitiet.TabIndex = 19;
            this.btnChitiet.Text = "Chi tiết";
            this.btnChitiet.UseVisualStyleBackColor = true;
            this.btnChitiet.Click += new System.EventHandler(this.btnChitiet_Click);
            // 
            // txtTimkiem
            // 
            this.txtTimkiem.Location = new System.Drawing.Point(1131, 336);
            this.txtTimkiem.Name = "txtTimkiem";
            this.txtTimkiem.Size = new System.Drawing.Size(190, 27);
            this.txtTimkiem.TabIndex = 24;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(1340, 334);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(94, 29);
            this.btnTimKiem.TabIndex = 25;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // frmKhuyenMaiSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1844, 759);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.txtTimkiem);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dgvKMSP);
            this.Controls.Add(this.label1);
            this.Name = "frmKhuyenMaiSanPham";
            this.Text = "frmKhuyenMaiSanPham";
            this.Load += new System.EventHandler(this.frmKhuyenMaiSanPham_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKMSP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvKMSP;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtTyLe;
        private System.Windows.Forms.ComboBox cbMaLoaiSP;
        private System.Windows.Forms.ComboBox cbMaSP;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbMaKM;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaKM;
        private System.Windows.Forms.DataGridViewTextBoxColumn Masanpham;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaLoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayBatDau;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayKetThuc;
        private System.Windows.Forms.DataGridViewTextBoxColumn TyLeKhuyenMai;
        private System.Windows.Forms.Button btnChitiet;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.TextBox txtTimkiem;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Button btnKM;
    }
}