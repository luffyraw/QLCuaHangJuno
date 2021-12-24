
namespace QLCuaHangJuno
{
    partial class frmKhuyenMaiHoaDon
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMaKM = new System.Windows.Forms.TextBox();
            this.txtTiLe = new System.Windows.Forms.TextBox();
            this.dtpNgayBD = new System.Windows.Forms.DateTimePicker();
            this.dtpNgayKT = new System.Windows.Forms.DateTimePicker();
            this.dgvKMHD = new System.Windows.Forms.DataGridView();
            this.MaGg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TgbatDau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TgketThuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TyLeGiamGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DieuKienApDung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtDK = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnChiTiet = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnThoat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKMHD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(321, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(317, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "Khuyễn Mãi Hóa Đơn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(79, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã khuyễn mãi:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(509, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ngày bắt đầu:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(508, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ngày kết thúc:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(79, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Tỷ lệ giảm giá: ";
            // 
            // txtMaKM
            // 
            this.txtMaKM.Location = new System.Drawing.Point(217, 94);
            this.txtMaKM.Name = "txtMaKM";
            this.txtMaKM.Size = new System.Drawing.Size(125, 27);
            this.txtMaKM.TabIndex = 0;
            // 
            // txtTiLe
            // 
            this.txtTiLe.Location = new System.Drawing.Point(217, 154);
            this.txtTiLe.Name = "txtTiLe";
            this.txtTiLe.Size = new System.Drawing.Size(125, 27);
            this.txtTiLe.TabIndex = 1;
            // 
            // dtpNgayBD
            // 
            this.dtpNgayBD.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayBD.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayBD.Location = new System.Drawing.Point(633, 92);
            this.dtpNgayBD.Name = "dtpNgayBD";
            this.dtpNgayBD.Size = new System.Drawing.Size(134, 27);
            this.dtpNgayBD.TabIndex = 3;
            // 
            // dtpNgayKT
            // 
            this.dtpNgayKT.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayKT.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayKT.Location = new System.Drawing.Point(633, 152);
            this.dtpNgayKT.Name = "dtpNgayKT";
            this.dtpNgayKT.Size = new System.Drawing.Size(134, 27);
            this.dtpNgayKT.TabIndex = 4;
            this.dtpNgayKT.Value = new System.DateTime(2021, 12, 23, 14, 44, 53, 0);
            // 
            // dgvKMHD
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvKMHD.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvKMHD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKMHD.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaGg,
            this.TgbatDau,
            this.TgketThuc,
            this.TyLeGiamGia,
            this.DieuKienApDung});
            this.dgvKMHD.Location = new System.Drawing.Point(45, 346);
            this.dgvKMHD.Name = "dgvKMHD";
            this.dgvKMHD.RowHeadersWidth = 51;
            this.dgvKMHD.RowTemplate.Height = 29;
            this.dgvKMHD.Size = new System.Drawing.Size(885, 275);
            this.dgvKMHD.TabIndex = 9;
            this.dgvKMHD.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKMHD_CellContentClick);
            // 
            // MaGg
            // 
            this.MaGg.DataPropertyName = "MaGg";
            this.MaGg.HeaderText = "Mã khuyễn mãi ";
            this.MaGg.MinimumWidth = 6;
            this.MaGg.Name = "MaGg";
            this.MaGg.Width = 150;
            // 
            // TgbatDau
            // 
            this.TgbatDau.DataPropertyName = "TgbatDau";
            this.TgbatDau.HeaderText = "Ngày bắt đầu";
            this.TgbatDau.MinimumWidth = 6;
            this.TgbatDau.Name = "TgbatDau";
            this.TgbatDau.Width = 150;
            // 
            // TgketThuc
            // 
            this.TgketThuc.DataPropertyName = "TgketThuc";
            this.TgketThuc.HeaderText = "Ngày kết thúc";
            this.TgketThuc.MinimumWidth = 6;
            this.TgketThuc.Name = "TgketThuc";
            this.TgketThuc.Width = 150;
            // 
            // TyLeGiamGia
            // 
            this.TyLeGiamGia.DataPropertyName = "TyLeGiamGia";
            this.TyLeGiamGia.HeaderText = "Tỷ lệ khuyến mãi (%)";
            this.TyLeGiamGia.MinimumWidth = 6;
            this.TyLeGiamGia.Name = "TyLeGiamGia";
            this.TyLeGiamGia.Width = 180;
            // 
            // DieuKienApDung
            // 
            this.DieuKienApDung.DataPropertyName = "DieuKienApDung";
            this.DieuKienApDung.HeaderText = "Điều kiện áp dụng";
            this.DieuKienApDung.MinimumWidth = 6;
            this.DieuKienApDung.Name = "DieuKienApDung";
            this.DieuKienApDung.Width = 200;
            // 
            // txtDK
            // 
            this.txtDK.Location = new System.Drawing.Point(217, 213);
            this.txtDK.Name = "txtDK";
            this.txtDK.Size = new System.Drawing.Size(125, 27);
            this.txtDK.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(76, 220);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(133, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Điều kiện áp dụng:";
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(103, 269);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(97, 36);
            this.btnThem.TabIndex = 5;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(266, 269);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(97, 36);
            this.btnSua.TabIndex = 6;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(451, 269);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(97, 36);
            this.btnXoa.TabIndex = 7;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnChiTiet
            // 
            this.btnChiTiet.Location = new System.Drawing.Point(643, 269);
            this.btnChiTiet.Name = "btnChiTiet";
            this.btnChiTiet.Size = new System.Drawing.Size(97, 36);
            this.btnChiTiet.TabIndex = 8;
            this.btnChiTiet.Text = "Chi tiết";
            this.btnChiTiet.UseVisualStyleBackColor = true;
            this.btnChiTiet.Click += new System.EventHandler(this.btnChiTiet_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(809, 269);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(99, 36);
            this.btnThoat.TabIndex = 9;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // frmKhuyenMaiHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(971, 655);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnChiTiet);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.txtDK);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dgvKMHD);
            this.Controls.Add(this.dtpNgayKT);
            this.Controls.Add(this.dtpNgayBD);
            this.Controls.Add(this.txtTiLe);
            this.Controls.Add(this.txtMaKM);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmKhuyenMaiHoaDon";
            this.Text = "frmKhuyenMaiHoaDon";
            this.Load += new System.EventHandler(this.frmKhuyenMaiHoaDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKMHD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMaKM;
        private System.Windows.Forms.TextBox txtTiLe;
        private System.Windows.Forms.DateTimePicker dtpNgayBD;
        private System.Windows.Forms.DateTimePicker dtpNgayKT;
        private System.Windows.Forms.DataGridView dgvKMHD;
        private System.Windows.Forms.TextBox txtDK;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnChiTiet;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaGg;
        private System.Windows.Forms.DataGridViewTextBoxColumn TgbatDau;
        private System.Windows.Forms.DataGridViewTextBoxColumn TgketThuc;
        private System.Windows.Forms.DataGridViewTextBoxColumn TyLeGiamGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn DieuKienApDung;
        private System.Windows.Forms.Button btnThoat;
    }
}